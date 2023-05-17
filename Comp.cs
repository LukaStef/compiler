using System.Data;
namespace compiler
{
    internal class Comp
    {
        private readonly string sub;
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
            string bins = "";
            int bin;
            while (dec > 0)
            {
                bin = dec % 2;
                dec /= 2;
                bins = bin.ToString() + bins;
            }
            return bins;
        }
        public string OctConvert() //u oktalni
        {
            int dec = int.Parse(sub);
            string octs = "";
            int oct;
            while (dec > 0)
            {
                oct = dec % 8;
                dec /= 8;
                octs = oct.ToString() + octs;
            }
            return octs;
        }
        public string HexConvert() //u heksa
        {
            int dec = int.Parse(sub);
            string hexs = "";
            int hex;
            while (dec > 0)
            {
                hex = dec % 16;
                dec /= 16;
                hexs = hex switch
                {
                    10 => "A" + hexs,
                    11 => "B" + hexs,
                    12 => "C" + hexs,
                    13 => "D" + hexs,
                    14 => "E" + hexs,
                    15 => "F" + hexs,
                    _ => hex.ToString() + hexs,
                };
            }
            return hexs;
        }
        public string Convert(string arg1, string arg2) //convert sa bilo kojom bazom
        {
            string rez="";
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
                rez = broj + rez;
            }
            return rez;
        }
        public string Pow(string arg1, string arg2) //stepen
        {
            string pow;
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            double powb = Math.Pow(arg1Int, arg2Int);
            pow = powb.ToString();
            return pow;
        }
        public string Root(string arg1, string arg2) //koren
        {
            string pow;
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            string arg1S = arg1Int.ToString();
            string arg2S = arg2Int.ToString();
            double arg1D = double.Parse(arg1S);
            double arg2D = 1/double.Parse(arg2S);
            double powb = Math.Pow(arg1D, arg2D);
            pow = powb.ToString();
            return pow;
        }
        public string Fact() //faktorijal
        {
            string fact;
            int p = int.Parse(sub);
            double f = 1;
            for (int i = 1; i <= p; i++)
            {
                f *= i;
            }
            fact = f.ToString();
            return fact;
        }
        public string Random(string arg1, string arg2) //random
        {
            string ran;
            Random R = new Random();
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            double ranb = R.Next(arg1Int, arg2Int + 1);
            ran = ranb.ToString();
            return ran;
        }
        public string Log(string arg1, string arg2) //logaritam
        {
            string log;
            arg1Int = (int)t.Compute(arg1, "");
            arg2Int = (int)t.Compute(arg2, "");
            double logb = Math.Log(arg1Int, arg2Int);
            log = logb.ToString();
            return log;
        }
        //kraj matematickih komanda
        //string komande
        public string Count() //broji
        {
            string cnt;
            cnt = sub.Length.ToString();
            return cnt;
        }
        public string Remove(string arg1, string arg2) //brise
        {
            string nov;
            nov = arg1.Replace(arg2, "");
            return nov;
        }
        public int Ascii() //ascii
        {
            return (int)sub[0];
        }
        public string Back() //unazad
        {
            string back = "";
            for (int i = 0; i < sub.Length; i++)
            {
                back = sub[i] + back;
            }
            return back;
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
            string nov;
            arg2Int = (int)t.Compute(arg2, "");
            nov = arg1.Remove(0, arg2Int);
            return nov;
        }
        public string WriteFor(string arg1, string arg2) //ispisuje vise puta
        {
            string nov = "";
            arg2Int = (int)t.Compute(arg2, "");
            for (int i = 0; i < arg2Int; i++)
            {
                nov += arg1;
            }
            return nov;
        }
        public string WriteLineFor(string arg1, string arg2) //ispisuje i dodaje novi red vise puta
        {
            string nov = "";
            arg2Int = (int)t.Compute(arg2, "");
            for (int i = 0; i < arg2Int; i++)
            {
                nov += arg1 + "\n";
            }
            return nov;
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