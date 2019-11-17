using System;
using System.Collections.Generic;
using System.Linq;
using LibAtem.Commands;
using LibAtem.Commands.DeviceProfile;
using LibAtem.Commands.Settings;
using LibAtem.Commands.Settings.Multiview;
using LibAtem.Common;

namespace LibAtem.State.Builder
{
    internal static class SettingsStateUpdater
    {
        public static void Update(AtemState state, UpdateResultImpl result, ICommand command)
        {
            if (command is SerialPortModeCommand serialCmd)
            {
                state.Settings.SerialMode = serialCmd.SerialMode;
                result.SetSuccess($"Settings.SerialMode");
            }
            else if (command is VideoModeGetCommand videoCmd)
            {
                state.Settings.VideoMode = videoCmd.VideoMode;
                result.SetSuccess($"Settings.VideoMode");
            }

            UpdateInputs(state, result, command);
            UpdateMultiViewers(state, result, command);
        }

        private static void UpdateInputs(AtemState state, UpdateResultImpl result, ICommand command)
        {
            if (command is InputPropertiesGetCommand propsCmd)
            {
                if (!state.Settings.Inputs.ContainsKey(propsCmd.Id))
                    state.Settings.Inputs[propsCmd.Id] = new InputState();
                InputState props = state.Settings.Inputs[propsCmd.Id];
            
                props.Properties.LongName = propsCmd.LongName;
                props.Properties.ShortName = propsCmd.ShortName;

                // Tuple<string, string> defaultName = propsCmd.Id.GetDefaultName(profile);
                // props.AreNamesDefault = propsCmd.LongName == defaultName.Item1 && propsCmd.ShortName == defaultName.Item2;

                //props.IsExternal = cmd.IsExternal;
                props.Properties.AvailableExternalPortTypes = propsCmd.AvailableExternalPorts;
                props.Properties.CurrentExternalPortType = propsCmd.ExternalPortType;
                //props.InternalPortType = cmd.InternalPortType;
                //props.SourceAvailability = cmd.SourceAvailability;
                //props.MeAvailability = cmd.MeAvailability;
                result.SetSuccess($"Settings.Inputs.{propsCmd.Id}.Properties");
            }
            else if (command is TallyBySourceCommand tallyCmd)
            {
                foreach (KeyValuePair<VideoSource, Tuple<bool, bool>> inp in tallyCmd.Tally)
                {
                    state.Settings.Inputs[inp.Key].Tally.ProgramTally = inp.Value.Item1;
                    state.Settings.Inputs[inp.Key].Tally.PreviewTally = inp.Value.Item2;
                    result.SetSuccess($"Settings.Inputs.{inp.Key}.Tally");
                }
            }
        }

        private static void UpdateMultiViewers(AtemState state, UpdateResultImpl result, ICommand command)
        {
            if (command is MultiviewerConfigCommand multiviewCmd)
            {
                state.Settings.MultiViewers = UpdaterUtil.CreateList(multiviewCmd.Count, i => new MultiViewerState
                {
                    Windows = UpdaterUtil.CreateList(multiviewCmd.WindowCount,
                        w => new MultiViewerState.WindowState()),
                    SupportsVuMeters = multiviewCmd.SupportsVuMeters
                });
                result.SetSuccess($"Settings.MultiViewers");
            }
            else if (command is MultiviewVuOpacityCommand vuOpacityCmd)
            {
                UpdaterUtil.TryForIndex(result, state.Settings.MultiViewers, (int)vuOpacityCmd.MultiviewIndex, mv =>
                {
                    mv.VuMeterOpacity = vuOpacityCmd.Opacity;
                    result.SetSuccess($"Settings.MultiViewers.{vuOpacityCmd.MultiviewIndex}.VuMeterOpacity");
                });
            }
            else if (command is MultiviewPropertiesGetV8Command props8Cmd)
            {
                UpdaterUtil.TryForIndex(result, state.Settings.MultiViewers, (int)props8Cmd.MultiviewIndex, mv =>
                {
                    mv.Properties.Layout = props8Cmd.Layout;
                    mv.Properties.ProgramPreviewSwapped = props8Cmd.ProgramPreviewSwapped;

                    // Enforce some legacy behaviour
                    if (mv.Windows.Count == 10) // TODO - perhaps this check can be done better?
                    {
                        if (mv.SupportsVuMeters) // TODO - could this be moved off state?
                        {
                            mv.Windows[0].SupportsVuMeter = props8Cmd.ProgramPreviewSwapped;
                            mv.Windows[1].SupportsVuMeter = !props8Cmd.ProgramPreviewSwapped;
                            
                            result.SetSuccess($"Settings.MultiViewers.{props8Cmd.MultiviewIndex}.Windows.0");
                            result.SetSuccess($"Settings.MultiViewers.{props8Cmd.MultiviewIndex}.Windows.1");
                        }
                        
                    }

                    result.SetSuccess($"Settings.MultiViewers.{props8Cmd.MultiviewIndex}.Properties");
                });
            }
            else if (command is MultiviewPropertiesGetCommand propsCmd)
            {
                UpdaterUtil.TryForIndex(result, state.Settings.MultiViewers, (int)propsCmd.MultiviewIndex, mv =>
                {
                    mv.Properties.Layout = propsCmd.Layout;
                    mv.Properties.ProgramPreviewSwapped = propsCmd.ProgramPreviewSwapped;

                    // Enforce some legacy behaviour
                    if (mv.Windows.Count == 10) // TODO - perhaps this check can be done better?
                    {
                        mv.Windows[0].SafeAreaEnabled = propsCmd.SafeAreaEnabled && propsCmd.ProgramPreviewSwapped;
                        mv.Windows[1].SafeAreaEnabled = propsCmd.SafeAreaEnabled && !propsCmd.ProgramPreviewSwapped;
                        
                        if (mv.SupportsVuMeters) // TODO - could this be moved off state?
                        {
                            mv.Windows[0].SupportsVuMeter = propsCmd.ProgramPreviewSwapped;
                            mv.Windows[1].SupportsVuMeter = !propsCmd.ProgramPreviewSwapped;
                        }
                        
                        result.SetSuccess($"Settings.MultiViewers.{propsCmd.MultiviewIndex}.Windows.0");
                        result.SetSuccess($"Settings.MultiViewers.{propsCmd.MultiviewIndex}.Windows.1");
                    }

                    result.SetSuccess($"Settings.MultiViewers.{propsCmd.MultiviewIndex}.Properties");
                });
            }
            else if (command is MultiviewWindowInputGetCommand winCmd)
            {
                UpdaterUtil.TryForIndex(result, state.Settings.MultiViewers, (int)winCmd.MultiviewIndex, mv =>
                {
                    UpdaterUtil.TryForIndex(result, mv.Windows, (int) winCmd.WindowIndex, win =>
                    {
                        win.Source = winCmd.Source;
                        
                        if (mv.SupportsVuMeters)
                        {
                            win.SupportsVuMeter = winCmd.Source.SupportsVuMeter();

                            // Preview never supports it
                            if (winCmd.WindowIndex == 0)
                                win.SupportsVuMeter = mv.Properties.ProgramPreviewSwapped;
                            if (winCmd.WindowIndex == 1)
                                win.SupportsVuMeter = !mv.Properties.ProgramPreviewSwapped;
                        } else
                        {
                            win.SupportsVuMeter = false;
                        }

                        result.SetSuccess($"Settings.MultiViewers.{winCmd.MultiviewIndex}.Windows.{winCmd.WindowIndex}");
                    });
                });
            }
            else if (command is MultiviewWindowVuMeterGetCommand vuMeterCmd)
            {
                UpdaterUtil.TryForIndex(result, state.Settings.MultiViewers, (int)vuMeterCmd.MultiviewIndex, mv =>
                {
                    UpdaterUtil.TryForIndex(result, mv.Windows, (int) vuMeterCmd.WindowIndex, win =>
                    {
                        win.VuMeter = vuMeterCmd.VuEnabled;
                        result.SetSuccess($"Settings.MultiViewers.{vuMeterCmd.MultiviewIndex}.Windows.{vuMeterCmd.WindowIndex}");
                    });
                });
            }
        }
    }
}