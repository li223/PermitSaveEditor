using Newtonsoft.Json;

namespace PermitSaveEditor.Objects
{
    public class Color
    {
        public Color() { }

        public Color(double r, double g, double b, double a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public Color(string r, string g, string b, string a)
        {
            R = double.Parse(r);
            G = double.Parse(g);
            B = double.Parse(b);
            A = double.Parse(a);
        }

        [JsonProperty("r")]
        public double R { get; set; }

        [JsonProperty("g")]
        public double G { get; set; }

        [JsonProperty("b")]
        public double B { get; set; }

        [JsonProperty("a")]
        public double A { get; set; }
    }
}
