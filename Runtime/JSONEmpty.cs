namespace JackSParrot.JSON
{
    [System.Serializable]
    public class JSONEmpty : JSONValue
    {
        public JSONEmpty() : base(JSONValueType.Empty)
        {
        }

        public override string ToString()
        {
            return "";
        }

        public override void Serialize(System.Text.StringBuilder sb)
        {
            sb.Append("");
        }

        public override JSON Clone()
        {
            return new JSONEmpty();
        }

        public override bool Equals(JSON other)
        {
            return base.Equals(other) || (other.IsEmpty() && IsEmpty());
        }
    }
}
