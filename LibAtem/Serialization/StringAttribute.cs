﻿using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LibAtem.Serialization
{
    public class StringAttribute : SerializableAttributeBase, IRandomGeneratorAttribute
    {
        private readonly int _length;

        public StringAttribute(int length)
        {
            _length = length;
        }

        public override void Serialize(byte[] data, uint start, object val)
        {
            string str = (string)val;
            byte[] res = new byte[_length];
            int i;

            for (i = 0; i < _length && i < str.Length; i++)
                res[i] = (byte)str[i];

            for (; i < _length; i++)
                res[i] = 0;

            res.CopyTo(data, (int) start);
        }

        public override object Deserialize(byte[] data, uint start, PropertyInfo prop)
        {
            string str = Encoding.ASCII.GetString(data, (int) start, _length);
            int len = str.IndexOf((char) 0);
            return len < 0 ? str : str.Substring(0, len);
        }

        public override bool AreEqual(object val1, object val2)
        {
            return Equals(val1, val2);
        }

        public object GetRandom(Random random)
        {
            int targetLength = random.Next(_length);

            var str = new StringBuilder();
            while (str.Length < targetLength)
                str.Append(Guid.NewGuid());

            return str.ToString().Substring(0, targetLength);
        }

        public bool IsValid(object obj)
        {
            return true;
        }
    }

    public class StringLengthAttribute : SerializableAttributeBase, IRandomGeneratorAttribute
    {
        private readonly uint _maxlength;

        public StringLengthAttribute(uint maxlength=128)
        {
            _maxlength = maxlength;
        }

        public override void Serialize(byte[] data, uint start, object val)
        {
            string str = (string) val;
            byte[] bytes = BitConverter.GetBytes(str.Length);
            data[start] = bytes[1];
            data[start + 1] = bytes[0];
        }

        public override object Deserialize(byte[] data, uint start, PropertyInfo prop)
        {
            int len = (data[start] << 8) + data[start + 1];
            return new string(' ', len);
        }

        public override bool AreEqual(object val1, object val2)
        {
            return Equals(val1, val2);
        }

        public object GetRandom(Random random)
        {
            int len = random.Next((int) _maxlength);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, len)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public bool IsValid(object obj)
        {
            string str = (string) obj;
            return str.Length <= _maxlength;
        }
    }
}