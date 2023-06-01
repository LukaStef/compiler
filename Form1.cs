using System.Data;
using System.Diagnostics;

namespace compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //napravljeno: 20.01.2023.
        //poslednja izmena: 17.05.2023.
        #region Promenljive
        readonly List<string> prIme = new(); //cuva imena promenljivih
        readonly List<string> prVred = new(); //cuva vrednosti promenljivih
        readonly DataTable t = new(); //za racunanje izraza
        string imeFajla = "Untitled.lppl";
        string? aktivanFajl;
        
        private void button2_Click(object sender, EventArgs e) // cisti obe kutije
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
        #endregion
        #region Glavni deo
        private void button1_Click(object sender, EventArgs e) //izvrsava kod
        {
            if (richTextBox1.Text == "")
            {
                richTextBox2.Text = "";
                return;
            }
            prIme.Clear();
            prVred.Clear();
            try
            {
                #region Odvajanje
                richTextBox2.Text = "";
                string k = richTextBox1.Text;
                k = k.Replace("\r", "");
                k = k.Replace("\n", "");
                k = k.Replace("\t", "");
                if (File.ReadAllText(@"definicije.txt").Length>0)
                    k = Definicije(k);
                string[] n = new string[k.Length];
                n = k.Split(";");
                #endregion
                #region Prevodjenje
                string com, sub;
                for (int i = 0; i < n.Length-1; i-=-1)
                {
                    List<string> argument = new();
                    string cmd = n[i];
                    if (cmd[0] != '%') //ako nije deklaracija promenljive
                    {
                        com = "";
                        sub = "";
                        bool dosloDoZagrade = false;
                        foreach (char ch in cmd)
                        {
                            if (ch == '(')
                            { 
                                dosloDoZagrade = true;
                            }
                            if (!dosloDoZagrade)
                            {
                                com += ch.ToString();
                            }
                        }
                        sub = cmd.Replace(com, "");
                        sub = sub.Remove(0, 1);
                        sub = sub.Remove(sub.Length - 1, 1);
                        if (sub.Contains('&')) //ako ima vise argumenata
                        {
                            string subTemp = ""; //privremena vrednost. predstavlja podargument u trenutnom ciklusu
                            string[] podela = sub.Split('&'); //niz sa argumentima
                            for (int j = 0; j < podela.Length; j++)
                            {
                                string subArgument = podela[j];
                                subArgument = Parsiranje(subArgument);
                                argument.Add(subArgument);
                                subTemp += subArgument;
                                sub = subTemp;
                            }
                        }
                        else //ako ima samo jedan arg
                        {
                            sub = Parsiranje(sub);
                        }
                        Comp c = new(sub); //klasa sa komandama
                        switch (com) //komande
                        {
                            case "Write": //dodaje tekst na postojeci tekst
                                richTextBox2.Text += sub;
                                break;
                            case "WriteLine": //dodaje tekst i novi red
                                richTextBox2.Text += sub + "\n";
                                break;
                            case "BinConvert": //pretvara zadat broj u binarni i ispisuje
                                richTextBox2.Text += c.BinConvert();
                                break;
                            case "OctConvert": //pretvara zadat broj u oktalni i ispisuje
                                richTextBox2.Text += c.OctConvert();
                                break;
                            case "Convert": //pretvara u bilo koj brojni sistem
                                richTextBox2.Text += c.Convert(argument[0], argument[1]);
                                break;
                            case "HexConvert": //pretvara zadat broj u heksadekadni i ispisuje
                                richTextBox2.Text += c.HexConvert();
                                break;
                            case "Pow": //racuna stepen broja, drugi broj je stepen
                                richTextBox2.Text += c.Pow(argument[0], argument[1]);
                                break;
                            case "Root": //racuna koren broja
                                richTextBox2.Text += c.Root(argument[0], argument[1]);
                                break;
                            case "Fact": //racuna faktorijal broja
                                richTextBox2.Text += c.Fact();
                                break;
                            case "Random": //ispisuje nasumican broj
                                richTextBox2.Text += c.Random(argument[0], argument[1]);
                                break;
                            case "Log": //racuna logaritam
                                richTextBox2.Text += c.Log(argument[0], argument[1]);
                                break;
                            case "Count": //broji slova u stringu
                                richTextBox2.Text += c.Count();
                                break;
                            case "Remove": //brise drugi string iz prvog
                                richTextBox2.Text += c.Remove(argument[0], argument[1]);
                                break;
                            case "Ascii": //prikazuje ascii kod karaktera
                                richTextBox2.Text += c.Ascii();
                                break;
                            case "Back": //ispisuje string unazad
                                richTextBox2.Text += c.Back();
                                break;
                            case "BackLine": //ispisuje string unazad i dodaje novi red
                                richTextBox2.Text += c.Back() + "\n";
                                break;
                            case "ToUpper": //ispisuje string u velikim slovima
                                richTextBox2.Text += c.ToUpper();
                                break;
                            case "ToLower": //ispisuje string u malim slovima
                                richTextBox2.Text += c.ToLower();
                                break;
                            case "RemoveCount": //brise slova
                                richTextBox2.Text += c.RemoveCount(argument[0], argument[1]);
                                break;
                            case "WriteFor": //ispisuje vise puta
                                richTextBox2.Text += c.WriteFor(argument[0], argument[1]);
                                break;
                            case "WriteLineFor": //ispisuje vise puta i dodaje novi red
                                richTextBox2.Text += c.WriteLineFor(argument[0], argument[1]);
                                break;
                            case "MsgBox": //prikazuje messagebox
                                MessageBox.Show(argument[0], argument[1]);
                                break;
                            case "Wait": //pravi pauzu
                                Refresh();
                                c.Wait();
                                break;
                            case "Clear": //cisti kutiju sa rezultatom koda
                                richTextBox2.Text = "";
                                break;
                            case "WriteDelay": //ispisuje slovo po slovo
                                for (int b = 0; b < argument[0].Length; b++)
                                {
                                    richTextBox2.Text += argument[0][b];
                                    Thread.Sleep(int.Parse(argument[1]));
                                    Refresh();
                                }
                                break;
                            case "WriteLineDelay": //ispisuje slovo po slovo i dodaje novi red
                                for (int b = 0; b < argument[0].Length; b++)
                                {
                                    richTextBox2.Text += argument[0][b];
                                    Thread.Sleep(int.Parse(argument[1]));
                                    Refresh();
                                }
                                richTextBox2.Text += "\n";
                                break;
                            default:
                                MessageBox.Show("Komanda '" + com + "' ne postoji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                richTextBox2.Text = "";
                                break;
                        }
                    }
                    else //ako jeste promenljiva
                    {
                        string[] pr = new string[cmd.Length];
                        pr = cmd.Split('=');
                        string tipime = pr[0];
                        string vred = pr[1];
                        string[] tipimeN = new string[tipime.Length];
                        tipimeN = tipime.Split(' ');
                        string tip = tipimeN[0];
                        string ime = tipimeN[1];
                        prIme.Add(ime);
                        string vredTemp = "";
                        if (tip == "%var") // deklarisanje nove promenljive
                        {
                            if (vred.Contains('&'))
                            {
                                vredTemp = "";
                                string[] podela = vred.Split('&');
                                for (int j = 0; j < podela.Length; j++)
                                {
                                    string subArgument = podela[j];
                                    subArgument = Parsiranje(subArgument);
                                    vredTemp += subArgument;
                                }
                                vred = vredTemp;
                            }
                            else
                            {
                                vred = Parsiranje(vred);
                            }
                            prVred.Add(vred);
                        }
                        else if (tip == "%assign") //menjanje vrednosti postojece promenljive
                        {
                            if (prIme.Contains(ime)) //ako promenljiva postoji
                            {
                                int ind = prIme.IndexOf(ime);
                                if (vred.Contains('&'))
                                {
                                    vredTemp = "";
                                    string[] podela = vred.Split('&');
                                    for (int j = 0; j < podela.Length; j++)
                                    {
                                        string subArgument = podela[j];
                                        subArgument = Parsiranje(subArgument);
                                        vredTemp += subArgument;
                                    }
                                    vred = vredTemp;
                                }
                                else
                                {
                                    vred = Parsiranje(vred);
                                }
                                prVred[ind] = vred;
                            }
                            else
                            {
                                MessageBox.Show("Promenljiva '" + ime + "' ne postoji", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Komanda '" + ime + "' ne postoji", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            richTextBox2.Text = "";
                        }
                    }
                }
                #endregion
            }
            catch (Exception x)
            { 
                MessageBox.Show("Kod nije ispravan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(x.Message);
                richTextBox2.Text = ""; 
            }
        }
        #endregion
        #region Meni
        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Naslov = "Opšte uputstvo";
            Uputstvo f = new();
            f.Show();
        }
        
        private void verzijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info f = new()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.ShowDialog();
        }

        private void uputstvoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Uput.Naslov = "Definicije";
            Uputstvo f = new();
            f.Show();
        }
        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"notepad.exe", @"definicije.txt");
        }
        #endregion
        #region Cuvanje i otvaranje
        private void otvoriFajlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "LPPL kod|*.lppl";
            openFileDialog1.FileName = "";
            richTextBox2.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                string[] podela = openFileDialog1.FileName.Split('\\');
                imeFajla = podela[^1];
                ActiveForm.Text = "LPPL Compiler - " + openFileDialog1.FileName;
                aktivanFajl = openFileDialog1.FileName;
                sačuvajToolStripMenuItem.Enabled = true;
                MessageBox.Show("Kod uspešno učitan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void sacuvajKodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "LPPL kod|*.lppl";
            saveFileDialog1.FileName = imeFajla;
            if (richTextBox1.Text.Length > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    string[] podela = saveFileDialog1.FileName.Split('\\');
                    imeFajla = podela[^1];
                    ActiveForm.Text = "LPPL Compiler - " + saveFileDialog1.FileName;
                    aktivanFajl = saveFileDialog1.FileName;
                    sačuvajToolStripMenuItem.Enabled = true;
                    MessageBox.Show("Kod uspešno sačuvan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nije dozvoljeno čuvanje praznog sadržaja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(aktivanFajl, RichTextBoxStreamType.PlainText);
            MessageBox.Show("Kod uspešno sačuvan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Metode
        private string Parsiranje(string argument) //prepoznaje tip argumenta i pretvara ga u odgovarajuci oblik
        {
            if (argument[0].Equals('\'') && argument[^1].Equals('\'')) //ako je string
            {
                argument = argument.Remove(0, 1);
                argument = argument.Remove(argument.Length - 1, 1);
                argument = Menjanje(argument);
            }
            else if (argument[0].Equals('%')) //ako je promenljiva
            {
                argument = argument.Remove(0, 1);
                if (prIme.Contains(argument))
                {
                    argument = prVred[prIme.IndexOf(argument)];
                }
                else
                {
                    MessageBox.Show("Promenljiva " + argument + " ne postoji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox2.Text = "";
                    return "";
                }
            }
            else //ako je izraz
            {
                try
                {
                    double r;
                    if (argument.Contains('/'))
                    {
                        r = (double)t.Compute(argument, "");
                    }
                    else
                    {
                        r = (int)t.Compute(argument, "");
                    }
                    argument = r.ToString();
                }
                catch
                {
                    MessageBox.Show("Argument " + argument + " nije ispravan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox2.Text = "";
                    return "";
                }
            }
            return argument;
        }
        static string Menjanje(string arg) //ubacuje specijalne karaktere
        {
            arg = arg.Replace("\\n", "\n");
            arg = arg.Replace("\\t", "\t");
            arg = arg.Replace("\\a", "&");
            arg = arg.Replace("\\s", ";");
            arg = arg.Replace("\\oz", "(");
            arg = arg.Replace("\\zz", ")");
            return arg;
        }
        static string Definicije(string kod) //ubacuje definicije
        {
            string def = File.ReadAllText(@"definicije.txt");
            string[] podela = def.Split("\n");
            foreach (string s in podela)
            {
                string[] podela2 = s.Split(" - ");
                string novi = podela2[0];
                string stari = podela2[1];
                kod = kod.Replace(novi,stari);
            }
            return kod;
        }
        
        #endregion
        #region Preference
        private void bojaTekstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
                richTextBox2.ForeColor = colorDialog1.Color;
            }
        }

        private void bojaPozadineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
                richTextBox2.BackColor = colorDialog1.Color;
            }
        }

        private void fontTekstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox2.Font = fontDialog1.Font;
            }
        }

        private void resetujPreferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Lime;
            richTextBox2.ForeColor = Color.Lime;

            richTextBox1.BackColor = Color.Black;
            richTextBox2.BackColor = Color.Black;

            richTextBox1.Font = new Font("Source Code Pro", 13);
            richTextBox2.Font = new Font("Source Code Pro", 13);
        }
        #endregion
    }
}