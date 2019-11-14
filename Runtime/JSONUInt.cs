namespace JackSParrot.JSON
{
    [System.Serializable]
    public class JSONUInt : JSONValue
    {
        uint _value;

        public static implicit operator uint(JSONUInt data) => data.ToUInt();
        public static implicit operator JSONUInt(uint data) => new JSONUInt(data);

        public JSONUInt(uint value = 0) : base(JSONValueType.UInt)
        {
            _value = value;
        }

        public override JSONValue SetUInt(uint value)
        {
            _value = value;
            return this;
        }

        public override JSONValue SetInt(int value)
        {
            return SetInt((int)value);
        }

        public override JSONValue SetLong(long value)
        {
            return SetUInt((uint)value);
        }

        public override JSONValue SetFloat(float value)
        {
            return SetUInt((uint)value);
        }

        public override JSONValue SetBool(bool value)
        {
            return SetUInt(value ? 1u : 0u);
        }

        public override JSONValue SetString(string value)
        {
            uint toParse;
            if (!uint.TryParse(value, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out toParse))
            {
                toParse = 0;
            }
            return SetUInt(toParse);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override void Serialize(System.Text.StringBuilder sb)
        {
            sb.Append(_value);
        }

        public override bool ToBool()
        {
            return _value != 0;
        }

        public override uint ToUInt()
        {
            return _value;
        }

        public override long ToLong()
        {
            return (long)_value;
        }

        public override float ToFloat()
        {
            return (float)_value;
        }

        public override JSON Clone()
        {
            return new JSONUInt(_value);
        }

        public override bool Equals(JSON other)
        {
            return base.Equals(other) || (other.GetJSONType() == JSONType.Value && other.AsValue().GetValueType() == JSONValueType.UInt && (other.AsValue() as JSONUInt)._value == _value);
        }
    }
}