namespace LibAtem.Common
{

    public enum AdjustmentDomain
    {
        /// <summary>PTZ Control</summary>
        PtzControl = 11,

        /// <summary>Media</summary>
        Media = 10,

        /// <summary>Color Correction</summary>
        ColorCorrection = 8,

        /// <summary>Confi-guration</summary>
        ConfiGuration = 7,

        /// <summary>Reference</summary>
        Reference = 6,

        /// <summary>Tally</summary>
        Tally = 5,

        /// <summary>Display</summary>
        Display = 4,

        /// <summary>Output</summary>
        Output = 3,

        /// <summary>Audio</summary>
        Audio = 2,

        /// <summary>Video</summary>
        Video = 1,

        /// <summary>Lens</summary>
        Lens = 0

    }

    /// <summary>PTZ Control</summary>
    public enum PtzControlFeature
    {
        /// <summary>
        /// <para>Pan/Tilt Velocity</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = pan velocity</term>
        /// <description>
        /// <para>Type: fixed 16</para>
        /// <para>Minimum: -1.0</para>
        /// <para>Maximum: 1.0</para>
        /// <para>Interpretation: -1.0 = full speed left,, 1.0 = full speed right</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = tilt velocity</term>
        /// <description>
        /// <para>Type: fixed 16</para>
        /// <para>Minimum: -1.0</para>
        /// <para>Maximum: 1.0</para>
        /// <para>Interpretation: -1.0 = full speed down,, 1.0 = full speed up</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        PanTiltVelocity = 11,
        /// <summary>
        /// <para>Memory Preset</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = preset command</term>
        /// <description>
        /// <para>Type: int8 enum</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0 = reset,, 1 = store location,, 2 = recall location</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = preset slot</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 5</para>
        /// <para>Interpretation: �</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        MemoryPreset = 1
    }

    /// <summary>Media</summary>
    public enum MediaFeature
    {
        /// <summary>
        /// <para>Codec</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = basic codec</term>
        /// <description>
        /// <para>Type: int8 enum</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0 = RAW,, 1 = DNxHD,, 2 = ProRes,, 3 = Blackmagic RAW</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = codec variant</term>
        /// <description>
        /// <para>Type: int8 enum</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: RAW:, 0 = Uncompressed,, 1 = lossy 3:1,, 2 = lossy 4:1, ProRes:, 0 = HQ,, 1 = 422,, 2 = LT, 3 = Proxy,, 4 = 444, 5 = 444XQ, Blackmagic RAW:, 0 = Q0,, 1 = Q5,, 2 = 3:1,, 3 = 5:1,, 4 = 8:1,, 5 = 12:1</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        Codec = 10,
        /// <summary>
        /// <para>Transport mode</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = mode</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0 = Preview,, 1 = Play,, 2 = Record</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = speed</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: -ve = multiple speeds, backwards,, 0 = pause,, +ve = multiple, speeds forwards</para>
        /// </description>
        /// </item><item>
        /// <term>[2] = flags</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 1&lt;&lt;0 = loop,, 1&lt;&lt;1 = play all,, 1&lt;&lt;5 = disk1 active,, 1&lt;&lt;6 = disk2 active,, 1&lt;&lt;7 = time-lapse recording</para>
        /// </description>
        /// </item><item>
        /// <term>[3] = active storage medium</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0 = CFast card,, 1 = SD</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        TransportMode = 1
    }

    /// <summary>Color Correction</summary>
    public enum ColorCorrectionFeature
    {
        /// <summary>
        /// <para>Lift Adjust</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] red</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -2</para>
        /// <para>Maximum: 2</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[1] green</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -2</para>
        /// <para>Maximum: 2</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[2] blue</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -2</para>
        /// <para>Maximum: 2</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[3] luma</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -2</para>
        /// <para>Maximum: 2</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        LiftAdjust = 8,
        /// <summary>
        /// <para>Correction Reset Default</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>void</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>reset to defaults</description>
        /// </item>
        /// </list>
        /// </summary>
        CorrectionResetDefault = 7,
        /// <summary>
        /// <para>Color Adjust</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] hue</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -1</para>
        /// <para>Maximum: 1</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[1] sat</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 2</para>
        /// <para>Interpretation: default 1.0</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        ColorAdjust = 6,
        /// <summary>
        /// <para>Luma mix</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>default 1.0</description>
        /// </item>
        /// </list>
        /// </summary>
        LumaMix = 5,
        /// <summary>
        /// <para>Contrast Adjust</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] pivot</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 1</para>
        /// <para>Interpretation: default 0.5</para>
        /// </description>
        /// </item><item>
        /// <term>[1] adj</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 2</para>
        /// <para>Interpretation: default 1.0</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        ContrastAdjust = 4,
        /// <summary>
        /// <para>Offset Adjust</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] red</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -8</para>
        /// <para>Maximum: 8</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[1] green</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -8</para>
        /// <para>Maximum: 8</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[2] blue</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -8</para>
        /// <para>Maximum: 8</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[3] luma</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -8</para>
        /// <para>Maximum: 8</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        OffsetAdjust = 3,
        /// <summary>
        /// <para>Gain Adjust</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] red</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 16</para>
        /// <para>Interpretation: default 1.0</para>
        /// </description>
        /// </item><item>
        /// <term>[1] green</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 16</para>
        /// <para>Interpretation: default 1.0</para>
        /// </description>
        /// </item><item>
        /// <term>[2] blue</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 16</para>
        /// <para>Interpretation: default 1.0</para>
        /// </description>
        /// </item><item>
        /// <term>[3] luma</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 16</para>
        /// <para>Interpretation: default 1.0</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        GainAdjust = 2,
        /// <summary>
        /// <para>Gamma Adjust</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] red</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -4</para>
        /// <para>Maximum: 4</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[1] green</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -4</para>
        /// <para>Maximum: 4</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[2] blue</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -4</para>
        /// <para>Maximum: 4</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item><item>
        /// <term>[3] luma</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: -4</para>
        /// <para>Maximum: 4</para>
        /// <para>Interpretation: default 0.0</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        GammaAdjust = 1
    }

    /// <summary>Confi-guration</summary>
    public enum ConfiGurationFeature
    {
        /// <summary>
        /// <para>Location</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] latitude</term>
        /// <description>
        /// <para>Type: int64</para>
        /// <para>Minimum: _</para>
        /// <para>Maximum: _</para>
        /// <para>Interpretation: BCD - s0DDdddddddddddd, where s is the sign:, 0 = north (+), 1 = south (-);, DD degrees, dddddddddddd, decimal degrees</para>
        /// </description>
        /// </item><item>
        /// <term>[1] longitude</term>
        /// <description>
        /// <para>Type: int64</para>
        /// <para>Minimum: _</para>
        /// <para>Maximum: _</para>
        /// <para>Interpretation: BCD - sDDDdddddddddddd, where s is the sign: 0 = west, (-), 1 = east (+); DDD degrees,, dddddddddddd, decimal degrees</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        Location = 3,
        /// <summary>
        /// <para>Timezone</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int32</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>_</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>_</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Minutes offset from UTC</description>
        /// </item>
        /// </list>
        /// </summary>
        Timezone = 2,
        /// <summary>
        /// <para>System language</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>string</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>_</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>_</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>ISO-639-1 two character, language code</description>
        /// </item>
        /// </list>
        /// </summary>
        SystemLanguage = 1,
        /// <summary>
        /// <para>Real Time Clock</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] time</term>
        /// <description>
        /// <para>Type: int32</para>
        /// <para>Minimum: _</para>
        /// <para>Maximum: _</para>
        /// <para>Interpretation: BCD - HHMMSSFF (UCT)</para>
        /// </description>
        /// </item><item>
        /// <term>[1] date</term>
        /// <description>
        /// <para>Type: int32</para>
        /// <para>Minimum: _</para>
        /// <para>Maximum: _</para>
        /// <para>Interpretation: BCD - YYYYMMDD</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        RealTimeClock = 7
    }

    /// <summary>Reference</summary>
    public enum ReferenceFeature
    {
        /// <summary>
        /// <para>Offset</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int32</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>+/- offset in pixels</description>
        /// </item>
        /// </list>
        /// </summary>
        Offset = 1,
        /// <summary>
        /// <para>Source</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8 enum</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>2</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0 = internal,, 1 = program,, 2 = external</description>
        /// </item>
        /// </list>
        /// </summary>
        Source = 6
    }

    /// <summary>Tally</summary>
    public enum TallyFeature
    {
        /// <summary>
        /// <para>Tally brightness</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Sets the tally front and tally, rear brightness to the, same level., 0.0 = minimum,, 1.0 = maximum</description>
        /// </item>
        /// </list>
        /// </summary>
        TallyBrightness = 5,
        /// <summary>
        /// <para>Rear tally brightness</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Sets the tally rear brightness., 0.0 = minimum,, 1.0 = maximum, Tally rear brightness cannot, be turned off</description>
        /// </item>
        /// </list>
        /// </summary>
        RearTallyBrightness = 2,
        /// <summary>
        /// <para>Front tally brightness</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Sets the tally front, brightness., 0.0 = minimum,, 1.0 = maximum</description>
        /// </item>
        /// </list>
        /// </summary>
        FrontTallyBrightness = 1
    }

    /// <summary>Display</summary>
    public enum DisplayFeature
    {
        /// <summary>
        /// <para>Focus Assist</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = focus assist method</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0 = Peak,, 1 = Colored lines</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = focus line color</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0 = Red,, 1 = Green,, 2 = Blue,, 3 = White,, 4 = Black</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        FocusAssist = 5,
        /// <summary>
        /// <para>Color bars display time (seconds)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>30</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0 = disable bars, 1-30 =, enable bars with timeout (s)</description>
        /// </item>
        /// </list>
        /// </summary>
        ColorBarsDisplayTimeSeconds = 4,
        /// <summary>
        /// <para>Peaking level</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = minimum,, 1.0 = maximum</description>
        /// </item>
        /// </list>
        /// </summary>
        PeakingLevel = 3,
        /// <summary>
        /// <para>Zebra level</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = minimum,, 1.0 = maximum</description>
        /// </item>
        /// </list>
        /// </summary>
        ZebraLevel = 2,
        /// <summary>
        /// <para>Overlay enables</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>�</term>
        /// <description>
        /// <para>Type: int16 bit field</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0x4 = zebra</para>
        /// </description>
        /// </item><item>
        /// <term>�</term>
        /// <description>
        /// <para>Type: int16 bit field</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0x8 = peaking</para>
        /// </description>
        /// </item><item>
        /// <term>�</term>
        /// <description>
        /// <para>Type: int16 bit field</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: </para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        OverlayEnables = 1
    }

    /// <summary>Output</summary>
    public enum OutputFeature
    {
        /// <summary>
        /// <para>Overlays (replaces .1 and .2 above from Cameras 4.0)</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = frame guides style</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: 0 = off, 1 = 2.4:1, 2 = 2.39:1,, 3 = 2.35:1, 4 = 1.85:1, 5 = 16:9,, 6 = 14:9, 7 = 4:3</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = frame guide opacity</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 100</para>
        /// <para>Interpretation: 0 = transparent,, 100 = opaque</para>
        /// </description>
        /// </item><item>
        /// <term>[2] = safe area percentage</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 100</para>
        /// <para>Interpretation: percentage of full frame, used by safe area guide, (0 means off)</para>
        /// </description>
        /// </item><item>
        /// <term>[3] = grid style</term>
        /// <description>
        /// <para>Type: int8</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: bit flags: [0] = display thirds,, [1] = display cross hairs,, [2] = display center dot</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        OverlaysReplacesAndAboveFromCameras = 3,
        /// <summary>
        /// <para>Frame guides opacity (Camera 3.x)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0.1</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = transparent,, 1.0 = opaque</description>
        /// </item>
        /// </list>
        /// </summary>
        FrameGuidesOpacityCameraX = 2,
        /// <summary>
        /// <para>Frame guides style (Camera 3.x)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>8</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0 = HDTV, 1 = 4:3, 2 = 2.4:1,, 3 = 2.39:1, 4 = 2.35:1,, 5 = 1.85:1, 6 = thirds</description>
        /// </item>
        /// </list>
        /// </summary>
        FrameGuidesStyleCameraX = 1
    }

    /// <summary>Audio</summary>
    public enum AudioFeature
    {
        /// <summary>
        /// <para>Phantom power</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>boolean</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>true = powered,, false = not powered</description>
        /// </item>
        /// </list>
        /// </summary>
        PhantomPower = 6,
        /// <summary>
        /// <para>Input levels</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] ch0</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 1</para>
        /// <para>Interpretation: 0.0 = minimum,, 1.0 = maximum</para>
        /// </description>
        /// </item><item>
        /// <term>[1] ch1</term>
        /// <description>
        /// <para>Type: fixed16</para>
        /// <para>Minimum: 0</para>
        /// <para>Maximum: 1</para>
        /// <para>Interpretation: 0.0 = minimum,, 1.0 = maximum</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        InputLevels = 5,
        /// <summary>
        /// <para>Input type</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>2</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0 = internal mic,, 1 = line level input,, 2 = low mic level input,, 3 = high mic level input</description>
        /// </item>
        /// </list>
        /// </summary>
        InputType = 4,
        /// <summary>
        /// <para>Speaker level</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = minimum,, 1.0 = maximum</description>
        /// </item>
        /// </list>
        /// </summary>
        SpeakerLevel = 3,
        /// <summary>
        /// <para>Headphone program mix</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = minimum,, 1.0 = maximum</description>
        /// </item>
        /// </list>
        /// </summary>
        HeadphoneProgramMix = 2,
        /// <summary>
        /// <para>Headphone level</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = minimum,, 1.0 = maximum</description>
        /// </item>
        /// </list>
        /// </summary>
        HeadphoneLevel = 1
    }

    /// <summary>Video</summary>
    public enum VideoFeature
    {
        /// <summary>
        /// <para>ISO</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int32</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>2147483647</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>ISO value</description>
        /// </item>
        /// </list>
        /// </summary>
        Iso = 14,
        /// <summary>
        /// <para>Gain</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>-128</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>127</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Gain in decibel (dB)</description>
        /// </item>
        /// </list>
        /// </summary>
        GaindB = 13,
        /// <summary>
        /// <para>Shutter speed</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int32</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>24</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>2000</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Shutter speed value as a, fraction of 1, so 50 for 1/50th, of a second</description>
        /// </item>
        /// </list>
        /// </summary>
        ShutterSpeed = 12,
        /// <summary>
        /// <para>Shutter angle</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int32</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>100</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>36000</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Shutter angle in degrees,, multiplied by 100</description>
        /// </item>
        /// </list>
        /// </summary>
        ShutterAngle = 11,
        /// <summary>
        /// <para>Set auto exposure mode</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>4</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0 = Manual Trigger,, 1 = Iris,, 2 = Shutter,, 3 = Iris + Shutter,, 4 = Shutter + Iris</description>
        /// </item>
        /// </list>
        /// </summary>
        SetAutoExposureMode = 10,
        /// <summary>
        /// <para>Recording format</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = file frame rate</term>
        /// <description>
        /// <para>Type: int16</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: fps as integer, (eg 24, 25, 30, 50, 60, 120)</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = sensor frame rate</term>
        /// <description>
        /// <para>Type: int16</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: fps as integer, valid when, sensor-off-speed set (eg 24,, 25, 30, 33, 48, 50, 60, 120),, no change will be performed, if this value is set to 0</para>
        /// </description>
        /// </item><item>
        /// <term>[2] = frame width</term>
        /// <description>
        /// <para>Type: int16</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: in pixels</para>
        /// </description>
        /// </item><item>
        /// <term>[3] = frame height</term>
        /// <description>
        /// <para>Type: int16</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: in pixels</para>
        /// </description>
        /// </item><item>
        /// <term>[4] = flags</term>
        /// <description>
        /// <para>Type: int16</para>
        /// <para>Minimum: �</para>
        /// <para>Maximum: �</para>
        /// <para>Interpretation: [0] = file-M-rate, [1] = sensor-M-rate, valid, when sensor-off-speed-set, [2] = sensor-off-speed, [3] = interlaced, [4] = windowed mode</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        RecordingFormat = 9,
        /// <summary>
        /// <para>Video sharpening level</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8 enum</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>3</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0 = off, 1 = low,, 2 = medium, 3 = high</description>
        /// </item>
        /// </list>
        /// </summary>
        VideoSharpeningLevel = 8,
        /// <summary>
        /// <para>Dynamic Range Mode</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8 enum</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0 = film, 1 = video,</description>
        /// </item>
        /// </list>
        /// </summary>
        DynamicRangeMode = 7,
        /// <summary>
        /// <para>Exposure (ordinal)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>n</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Steps through available, exposure values from, minimum (0) to maximum (n)</description>
        /// </item>
        /// </list>
        /// </summary>
        ExposureOrdinal = 6,
        /// <summary>
        /// <para>Exposure (us)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int32</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>42000</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>time in us</description>
        /// </item>
        /// </list>
        /// </summary>
        ExposureUs = 5,
        /// <summary>
        /// <para>Restore auto WB</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>void</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Use latest auto white, balance setting</description>
        /// </item>
        /// </list>
        /// </summary>
        RestoreAutoWb = 4,
        /// <summary>
        /// <para>Set auto WB</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>void</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Calculate and set, auto white balance</description>
        /// </item>
        /// </list>
        /// </summary>
        SetAutoWb = 3,
        /// <summary>
        /// <para>Manual White Balance</para>
        /// <list type="table">
        /// <listHeader><term>Index</term><description>-</description></listHeader>
        /// <item>
        /// <term>[0] = color temp</term>
        /// <description>
        /// <para>Type: int16</para>
        /// <para>Minimum: 2500</para>
        /// <para>Maximum: 10000</para>
        /// <para>Interpretation: Color temperature in K</para>
        /// </description>
        /// </item><item>
        /// <term>[1] = tint</term>
        /// <description>
        /// <para>Type: int16</para>
        /// <para>Minimum: -50</para>
        /// <para>Maximum: 50</para>
        /// <para>Interpretation: tint</para>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        ManualWhiteBalance = 2,
        /// <summary>
        /// <para>Gain</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int8</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>16</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>1 = 100 ISO,, 2 = 200 ISO,, 4 = 400 ISO,, 8 = 800 ISO,, 16 = 1600 ISO</description>
        /// </item>
        /// </list>
        /// </summary>
        Gain = 1
    }

    /// <summary>Lens</summary>
    public enum LensFeature
    {
        /// <summary>
        /// <para>Set continuous zoom (speed)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>-1</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>+1.0</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Start/stop zooming at, specified rate: -1.0 = zoom, wider fast, 0.0 = stop,, +1 = zoom tele fast</description>
        /// </item>
        /// </list>
        /// </summary>
        SetContinuousZoomSpeed = 9,
        /// <summary>
        /// <para>Set absolute zoom (normalised)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Move to specified focal, length: 0.0 = wide, 1.0 = tele</description>
        /// </item>
        /// </list>
        /// </summary>
        SetAbsoluteZoomNormalised = 8,
        /// <summary>
        /// <para>Set absolute zoom (mm)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>max</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Move to specified focal, length in mm, from minimum, (0) to maximum (max)</description>
        /// </item>
        /// </list>
        /// </summary>
        SetAbsoluteZoomMm = 7,
        /// <summary>
        /// <para>Optical image stabilisation</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>boolean</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>true = enabled, false, = disabled</description>
        /// </item>
        /// </list>
        /// </summary>
        OpticalImageStabilisation = 6,
        /// <summary>
        /// <para>Instantaneous auto aperture</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>void</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>trigger instantaneous, auto aperture</description>
        /// </item>
        /// </list>
        /// </summary>
        InstantaneousAutoAperture = 5,
        /// <summary>
        /// <para>Aperture (ordinal)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>int16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>n</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Steps through available, aperture values from, minimum (0) to maximum (n)</description>
        /// </item>
        /// </list>
        /// </summary>
        ApertureOrdinal = 4,
        /// <summary>
        /// <para>Aperture (normalised)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = smallest, 1.0 = largest</description>
        /// </item>
        /// </list>
        /// </summary>
        ApertureNormalised = 3,
        /// <summary>
        /// <para>Aperture (f-stop)</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>-1</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>16</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>Aperture Value (where, fnumber = sqrt(2^AV))</description>
        /// </item>
        /// </list>
        /// </summary>
        ApertureFStop = 2,
        /// <summary>
        /// <para>Instantaneous autofocus</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>void</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>�</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>trigger, instantaneous autofocus</description>
        /// </item>
        /// </list>
        /// </summary>
        InstantaneousAutofocus = 1,
        /// <summary>
        /// <para>Focus</para>
        /// <list type="table">
        /// <item>
        /// <term>Type</term>
        /// <description>fixed16</description>
        /// </item><item>
        /// <term>Minimum</term>
        /// <description>0</description>
        /// </item><item>
        /// <term>Maximum</term>
        /// <description>1</description>
        /// </item><item>
        /// <term>Interpretation</term>
        /// <description>0.0 = near, 1.0 = far</description>
        /// </item>
        /// </list>
        /// </summary>
        Focus = 0
    }
}
