namespace compiler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verzijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriFajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sačuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajKodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definicijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bojaTekstaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bojaPozadineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTekstaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujPreferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Source Code Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(4, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(873, 399);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Write(\'Hello World\');";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.Font = new System.Drawing.Font("Source Code Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox2.Location = new System.Drawing.Point(4, 455);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(873, 399);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Hello World";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(4, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(815, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Izvrši";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem,
            this.fajlToolStripMenuItem,
            this.definicijeToolStripMenuItem,
            this.preferenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.oAplikacijiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputstvoToolStripMenuItem,
            this.verzijaToolStripMenuItem});
            this.oAplikacijiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // uputstvoToolStripMenuItem
            // 
            this.uputstvoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uputstvoToolStripMenuItem.Image")));
            this.uputstvoToolStripMenuItem.Name = "uputstvoToolStripMenuItem";
            this.uputstvoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.uputstvoToolStripMenuItem.Text = "Uputstvo";
            this.uputstvoToolStripMenuItem.Click += new System.EventHandler(this.uputstvoToolStripMenuItem_Click);
            // 
            // verzijaToolStripMenuItem
            // 
            this.verzijaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verzijaToolStripMenuItem.Image")));
            this.verzijaToolStripMenuItem.Name = "verzijaToolStripMenuItem";
            this.verzijaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.verzijaToolStripMenuItem.Text = "Informacija";
            this.verzijaToolStripMenuItem.Click += new System.EventHandler(this.verzijaToolStripMenuItem_Click);
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriFajlToolStripMenuItem,
            this.sačuvajToolStripMenuItem,
            this.sacuvajKodToolStripMenuItem});
            this.fajlToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlToolStripMenuItem.Text = "Fajl";
            // 
            // otvoriFajlToolStripMenuItem
            // 
            this.otvoriFajlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otvoriFajlToolStripMenuItem.Image")));
            this.otvoriFajlToolStripMenuItem.Name = "otvoriFajlToolStripMenuItem";
            this.otvoriFajlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otvoriFajlToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.otvoriFajlToolStripMenuItem.Text = "Otvori fajl";
            this.otvoriFajlToolStripMenuItem.Click += new System.EventHandler(this.otvoriFajlToolStripMenuItem_Click);
            // 
            // sačuvajToolStripMenuItem
            // 
            this.sačuvajToolStripMenuItem.Enabled = false;
            this.sačuvajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sačuvajToolStripMenuItem.Image")));
            this.sačuvajToolStripMenuItem.Name = "sačuvajToolStripMenuItem";
            this.sačuvajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sačuvajToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sačuvajToolStripMenuItem.Text = "Sačuvaj";
            this.sačuvajToolStripMenuItem.Click += new System.EventHandler(this.sačuvajToolStripMenuItem_Click);
            // 
            // sacuvajKodToolStripMenuItem
            // 
            this.sacuvajKodToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sacuvajKodToolStripMenuItem.Image")));
            this.sacuvajKodToolStripMenuItem.Name = "sacuvajKodToolStripMenuItem";
            this.sacuvajKodToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sacuvajKodToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sacuvajKodToolStripMenuItem.Text = "Sačuvaj kao";
            this.sacuvajKodToolStripMenuItem.Click += new System.EventHandler(this.sacuvajKodToolStripMenuItem_Click);
            // 
            // definicijeToolStripMenuItem
            // 
            this.definicijeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.definicijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriToolStripMenuItem,
            this.uputstvoToolStripMenuItem1});
            this.definicijeToolStripMenuItem.Name = "definicijeToolStripMenuItem";
            this.definicijeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.definicijeToolStripMenuItem.Text = "Definicije";
            // 
            // otvoriToolStripMenuItem
            // 
            this.otvoriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otvoriToolStripMenuItem.Image")));
            this.otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            this.otvoriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.otvoriToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.otvoriToolStripMenuItem.Text = "Otvori";
            this.otvoriToolStripMenuItem.Click += new System.EventHandler(this.otvoriToolStripMenuItem_Click);
            // 
            // uputstvoToolStripMenuItem1
            // 
            this.uputstvoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("uputstvoToolStripMenuItem1.Image")));
            this.uputstvoToolStripMenuItem1.Name = "uputstvoToolStripMenuItem1";
            this.uputstvoToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.uputstvoToolStripMenuItem1.Text = "Uputstvo";
            this.uputstvoToolStripMenuItem1.Click += new System.EventHandler(this.uputstvoToolStripMenuItem1_Click);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bojaTekstaToolStripMenuItem,
            this.bojaPozadineToolStripMenuItem,
            this.fontTekstaToolStripMenuItem,
            this.resetujPreferenceToolStripMenuItem});
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.preferenceToolStripMenuItem.Text = "Preference";
            // 
            // bojaTekstaToolStripMenuItem
            // 
            this.bojaTekstaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bojaTekstaToolStripMenuItem.Image")));
            this.bojaTekstaToolStripMenuItem.Name = "bojaTekstaToolStripMenuItem";
            this.bojaTekstaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bojaTekstaToolStripMenuItem.Text = "Boja teksta";
            this.bojaTekstaToolStripMenuItem.Click += new System.EventHandler(this.bojaTekstaToolStripMenuItem_Click);
            // 
            // bojaPozadineToolStripMenuItem
            // 
            this.bojaPozadineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bojaPozadineToolStripMenuItem.Image")));
            this.bojaPozadineToolStripMenuItem.Name = "bojaPozadineToolStripMenuItem";
            this.bojaPozadineToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bojaPozadineToolStripMenuItem.Text = "Boja pozadine";
            this.bojaPozadineToolStripMenuItem.Click += new System.EventHandler(this.bojaPozadineToolStripMenuItem_Click);
            // 
            // fontTekstaToolStripMenuItem
            // 
            this.fontTekstaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontTekstaToolStripMenuItem.Image")));
            this.fontTekstaToolStripMenuItem.Name = "fontTekstaToolStripMenuItem";
            this.fontTekstaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fontTekstaToolStripMenuItem.Text = "Font teksta";
            this.fontTekstaToolStripMenuItem.Click += new System.EventHandler(this.fontTekstaToolStripMenuItem_Click);
            // 
            // resetujPreferenceToolStripMenuItem
            // 
            this.resetujPreferenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetujPreferenceToolStripMenuItem.Image")));
            this.resetujPreferenceToolStripMenuItem.Name = "resetujPreferenceToolStripMenuItem";
            this.resetujPreferenceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetujPreferenceToolStripMenuItem.Text = "Resetuj preference";
            this.resetujPreferenceToolStripMenuItem.Click += new System.EventHandler(this.resetujPreferenceToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(817, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "AC";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(881, 858);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(897, 897);
            this.MinimumSize = new System.Drawing.Size(897, 897);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPPL Compiler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private Button button2;
        private ToolStripMenuItem uputstvoToolStripMenuItem;
        private ToolStripMenuItem verzijaToolStripMenuItem;
        private ToolStripMenuItem fajlToolStripMenuItem;
        private ToolStripMenuItem sacuvajKodToolStripMenuItem;
        private ToolStripMenuItem otvoriFajlToolStripMenuItem;
        private ToolStripMenuItem definicijeToolStripMenuItem;
        private ToolStripMenuItem otvoriToolStripMenuItem;
        private ToolStripMenuItem uputstvoToolStripMenuItem1;
        private ToolStripMenuItem preferenceToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private ToolStripMenuItem bojaTekstaToolStripMenuItem;
        private ToolStripMenuItem bojaPozadineToolStripMenuItem;
        private ToolStripMenuItem fontTekstaToolStripMenuItem;
        private ToolStripMenuItem resetujPreferenceToolStripMenuItem;
        private ToolStripMenuItem sačuvajToolStripMenuItem;
    }
}