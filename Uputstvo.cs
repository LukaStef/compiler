namespace compiler
{
    public partial class Uputstvo : Form
    {
        public Uputstvo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region pomoc
            textBox1.Text = comboBox1.Text switch
            {
                "Promenljive" => "%komanda ime=vrednost\r\nKomande za promenljive su %var i %assign.\r\n%var pravi novu promenljivu, dok %assign menja postojeću promenljivu.\r\nVrednosti može biti string, izraz ili druga promenljiva.",
                "Write()" => "Write(argumenti)\r\nIspisuje neki string ili rezultat izraza.\n",
                "WriteLine()" => "WriteLine(argumenti)\r\nIspisuje neki string ili rezultat izraza i postavlja novi red.\n",
                "WriteDelay()" => "WriteDelay('string'&izraz)\r\nIspisuje string slovo po slovo, i pravi (izraz) pauzu izmedju svakog slova. Izraz je izrazen u milisekundama.\n",
                "WriteLineDelay()" => "WriteLineDelay('string&izraz')\r\nIspisuje string slovo po slovo, pravi (izraz) pauzu izmedju svakog slova i dodaje novi red nakon svakog slova. Izraz je izrazen u milisekundama.\n",
                "BinConvert()" => "BinConvert(izraz)\r\nIspisuje binarni oblik izraza.\n",
                "OctConvert()" => "OctConvert(izraz)\r\nIspisuje oktalni oblik izraza.\n",
                "HexConvert()" => "HexConvert(izraz)\r\nIspisuje heksadecimalni oblik izraza.\n",
                "Convert()" => "Convert(izraz&izraz)\r\nIspisuje oblik prvog izraza u proizvoljnom brojnom sistemu. Drugi izraz je baza izabranog sistema.\n",
                "Pow()" => "Pow(prvi&drugi)\r\nIspisuje stepenovanje prvog broja drugim brojem.\n",
                "Root()" => "Sqrt(prvi&drugi)\r\nIspisuje (drugi) koren prvog izraza.\n",
                "Fact()" => "Fact(izraz)\r\nIspisuje faktorijal izraza.\n",
                "Random()" => "Random(prvi&drugi)\r\nIspisuje nasumican broj izmedju prvog i drugog broja.\n",
                "Log()" => "Log(prvi&drugi)\r\nIspisuje logaritam prvog broja na bazi drugog broja.\n",
                "Count()" => "Count(argumenti)\r\nIspisuje broj karaktera u stringu.\n",
                "Remove()" => "Remove('string'&'string').\r\nIspisuje prvi string u kome su izbrisane sve instance drugog stringa.\n",
                "Ascii()" => "Ascii('slovo')\r\nIspisuje ASCII kod jednog slova. Ako je u zagradama napisan string, ispisace se kod samo prvog karaktera.\n",
                "Back()" => "Back(argumenti)\r\nIspisuje string unazad. Ako je unet izraz, rezultat ce biti ispisan unazad.\n",
                "BackLine()" => "BackLine(argumenti)\r\nIspisuje string unazad i postavlja novi red. Ako je unet izraz, rezultat ce biti ispisan unazad.\n",
                "ToUpper()" => "ToUpper(argumenti)\r\nIspisuje string u kome su sva slova velika.\n",
                "ToLower()" => "ToLower(argumenti)\r\nIspisuje string u kome su sva slova mala.\n",
                "RemoveCount()" => "RemoveCount('string'&izraz)\r\nIspisuje string kome su izbrisana prvih (izraz) slova.\n",
                "WriteFor()" => "WriteFor('string'&izraz)\r\nIspisuje string (izraz) puta.\n",
                "WriteLineFor()" => "WriteLineFor('string'&izraz)\r\nIspisuje string (izraz) puta i postavlja novi red.\n",
                "MsgBox()" => "MsgBox('tekst'&'naslov')\r\nPravi messagebox ciji je sadrzaj prvi string, a naslov drugi string.\n",
                "Wait()" => "Wait(izraz)\r\nPravi pauzu od (izraz) milisekundi pre nego sto nastavi da izvrsava kod.\n",
                "Clear()" => "Clear('')\r\nCisti celu kutiju sa rezultatom koda.\n",
                _ => "Nepoznata komanda.\n",
            };
            #endregion
        }

        private void Uputstvo_Load(object sender, EventArgs e)
        {
            label2.Text = Uput.Naslov;
            if (Uput.Naslov == "Opšte uputstvo")
            {
                textBox2.Text = "U gornjoj kutiji se upisuje program. Ubacite sve komande i promenljive koje želite i odvojite ih sa ;. Kad završite, kliknite na dugme 'Izvrši' pa će rezultat vašeg koda da se pojavi u donjoj kutiji.";
            }
            else if (Uput.Naslov == "Definicije")
            {
                textBox2.Text = "U definicije.txt fajl se upisuju reči koje mogu zameniti šta god poželite (neku kljucnu rec, komandu itd.). U fajl se upisuju u formatu 'novi string - stari string', i sve definicije se razdvajaju novim redom. Definicije ne utiču na funkcionalnost vašeg koda.";
            }
        }
    }
}
