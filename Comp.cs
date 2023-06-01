using System.Data;
namespace compiler
{
    internal class Comp
    {
        private readonly string sub;
        string rezultat = "";
        private int arg1Int, arg2Int;
        readonly DataTable t = new();
        public Comp(string sub)
        {
            this.sub = sub;
        }
        //matematicke komande
        public string BinConvert() //u binarni
        {
            int dec = int.Parse(sub);
            rezultat = "";
            int bin;
            while (dec > 0)
            {
                bin = dec % 2;
                dec /= 2;
                rezultat = bin.ToString() + rezultat;
            }
            return rezultat;
        }
        public string OctConvert() //u oktalni
        {
            int dec = int.Parse(sub);
            rezultat = "";
            int oct;
            while (dec > 0)
            {
                oct = dec % 8;
                dec /= 8;
                rezultat = oct.ToString() + rezultat;
            }
            return rezultat;
        }
        public string HexConvert() //u heksa
        {
            int dec = int.Parse(sub);
            rezultat = "";
            int hex;
            while (dec > 0)
            {
                hex = dec % 16;
                dec /= 16;
                rezultat = hex switch
                {
                    10 => "A" + rezultat,
                    11 => "B" + rezultat,
                    12 => "C" + rezultat,
                    13 => "D" + rezultat,
                    14 => "E" + rezultat,
                    15 => "F" + rezultat,
                    _ => hex.ToString() + rezultat,
                };
            }
            return rezultat;
        }
        public string Convert(string arg1, string arg2) //convert sa bilo kojom bazom
        {
            rezultat = "";
            int rezInt;
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            while (arg1Int > 0)
            { 
                rezInt = arg1Int % arg2Int;
                arg1Int /= arg2Int;
                string broj;
                if (rezInt > 9)
                {
                    int razlika = rezInt - 9;
                    broj = ((char)(64 + razlika)).ToString();
                }
                else
                {
                    broj = rezInt.ToString();
                }
                rezultat = broj + rezultat;
            }
            return rezultat;
        }
        public string Pow(string arg1, string arg2) //stepen
        {
            rezultat = "";
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            double powb = Math.Pow(arg1Int, arg2Int);
            rezultat = powb.ToString();
            return rezultat;
        }
        public string Root(string arg1, string arg2) //koren
        {
            rezultat = "";
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            string arg1S = arg1Int.ToString();
            string arg2S = arg2Int.ToString();
            double arg1D = double.Parse(arg1S);
            double arg2D = 1/double.Parse(arg2S);
            double powb = Math.Pow(arg1D, arg2D);
            rezultat = powb.ToString();
            return rezultat;
        }
        public string Fact() //faktorijal
        {
            rezultat = "";
            int p = int.Parse(sub);
            double f = 1;
            for (int i = 1; i <= p; i++)
            {
                f *= i;
            }
            rezultat = f.ToString();
            return rezultat;
        }
        public string Random(string arg1, string arg2) //random
        {
            rezultat = "";
            Random R = new Random();
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            double ranb = R.Next(arg1Int, arg2Int + 1);
            rezultat = ranb.ToString();
            return rezultat;
        }
        public string Log(string arg1, string arg2) //logaritam
        {
            rezultat = "";
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            double logb = Math.Log(arg1Int, arg2Int);
            rezultat = logb.ToString();
            return rezultat;
        }
        //kraj matematickih komanda
        //string komande
        public string Count() //broji
        {
            rezultat = "";
            rezultat = sub.Length.ToString();
            return rezultat;
        }
        public string Remove(string arg1, string arg2) //brise
        {
            rezultat = "";
            rezultat = arg1.Replace(arg2, "");
            return rezultat;
        }
        public int Ascii() //ascii
        {
            return sub[0];
        }
        public string Back() //unazad
        {
            rezultat = "";
            for (int i = 0; i < sub.Length; i++)
            {
                rezultat = sub[i] + rezultat;
            }
            return rezultat;
        }
        public string ToUpper() //pretvara u velika slova
        {
            return sub.ToUpper();
        }
        public string ToLower() //pretvara u mala slova
        {
            return sub.ToLower();
        }
        public string RemoveCount(string arg1, string arg2) //brise prvih n slova
        {
            rezultat = "";
            arg2Int = (int)t.Compute(arg2, "");
            rezultat = arg1.Remove(0, arg2Int);
            return rezultat;
        }
        public string WriteFor(string arg1, string arg2) //ispisuje vise puta
        {
            rezultat = "";
            arg2Int = (int)t.Compute(arg2, "");
            for (int i = 0; i < arg2Int; i++)
            {
                rezultat += arg1;
            }
            return rezultat;
        }
        public string WriteLineFor(string arg1, string arg2) //ispisuje i dodaje novi red vise puta
        {
            rezultat = "";
            arg2Int = (int)t.Compute(arg2, "");
            for (int i = 0; i < arg2Int; i++)
            {
                rezultat += arg1 + "\n";
            }
            return rezultat;
        }
        public void MsgBox(string arg1, string arg2)
        {
            MessageBox.Show(arg1,arg2);
        }
        //kraj string komandi
        public void Wait()
        {
            Thread.Sleep(int.Parse(sub));
        }
    }
}