using System.Media;namespace compiler
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new(@"lajanje.wav");
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = "https://www.lukastefanovic.com/";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = url
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
