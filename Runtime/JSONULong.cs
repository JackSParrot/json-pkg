namespace JackSParrot.JSON
{
    [System.Serializable]
    public class JSONULong : JSONValue
    {
        ulong _value;

        public static implicit operator ulong(JSONULong data) => data.ToULong();
        public static implicit operator JSONULong(ulong data) => new JSONULong(data);

        public JSONULong(ulong value = 0UL) : base(JSONValueType.ULong)
        {
            _value = value;
        }

        public override JSONValue SetInt(int value)
        {
            return SetLong((long)value);
        }

        public override JSONValue SetLong(long value)
        {
            return SetULong((ulong)value);
        }

        public override JSONValue SetULong(ulong value)
        {
            _value = value;
            return this;
        }

        public override JSONValue SetFloat(float value)
        {
            return SetLong((long)value);
        }

        public override JSONValue SetBool(bool value)
        {
            return SetInt(value ? 1 : 0);
        }

        public override JSONValue SetString(string value)
        {
            ulong outVal;
            if (!ulong.TryParse(value, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out outVal))
            {
                outVal = 0;
            }
            return SetULong(outVal);
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

        public override int ToInt()
        {
            return (int)_value;
        }

        public override long ToLong()
        {
            return (long)_value;
        }

        public override ulong ToULong()
        {
            return _value;
        }

        public override float ToFloat()
        {
            return (float)_value;
        }

        public override JSON Clone()
        {
            return new JSONULong(_value);
        }

        public override bool Equals(JSON other)
        {
            return base.Equals(other) || (other.GetJSONType() == JSONType.Value && other.AsValue().GetValueType() == JSONValueType.Long && (other.AsValue() as JSONULong)._value == _value);
        }
    }
}

