namespace business.Resources
{
    public class Parameter
    {
        public Parameter(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
        public string name { get; set;  }
        public string value { get; set; }
    }
}
