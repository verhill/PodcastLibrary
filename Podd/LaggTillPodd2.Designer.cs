namespace Podd
{
    partial class LaggTillPodd2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPodd = new Label();
            tbPoddNamn = new TextBox();
            lblValKategori = new Label();
            lblNamn = new Label();
            lblLank = new Label();
            cbValKategori = new ComboBox();
            tbNamn = new TextBox();
            btnSparaPodd = new Button();
            tbLank = new TextBox();
            menuStrip1 = new MenuStrip();
            startsidanToolStripMenuItem = new ToolStripMenuItem();
            minaPoddarToolStripMenuItem = new ToolStripMenuItem();
            läggTillPoddToolStripMenuItem = new ToolStripMenuItem();
            hanteraKategoriToolStripMenuItem = new ToolStripMenuItem();
            btnHamtaPodd1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPodd
            // 
            lblPodd.AutoSize = true;
            lblPodd.Location = new Point(386, 34);
            lblPodd.Margin = new Padding(2, 0, 2, 0);
            lblPodd.Name = "lblPodd";
            lblPodd.Size = new Size(49, 15);
            lblPodd.TabIndex = 28;
            lblPodd.Text = "Podcast";
            // 
            // tbPoddNamn
            // 
            tbPoddNamn.Location = new Point(386, 61);
            tbPoddNamn.Margin = new Padding(2);
            tbPoddNamn.Name = "tbPoddNamn";
            tbPoddNamn.Size = new Size(205, 23);
            tbPoddNamn.TabIndex = 27;
            // 
            // lblValKategori
            // 
            lblValKategori.AutoSize = true;
            lblValKategori.Location = new Point(84, 186);
            lblValKategori.Margin = new Padding(2, 0, 2, 0);
            lblValKategori.Name = "lblValKategori";
            lblValKategori.Size = new Size(71, 15);
            lblValKategori.TabIndex = 26;
            lblValKategori.Text = "Välj kategori";
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(86, 122);
            lblNamn.Margin = new Padding(2, 0, 2, 0);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(60, 15);
            lblNamn.TabIndex = 25;
            lblNamn.Text = "Ge Namn:";
            // 
            // lblLank
            // 
            lblLank.AutoSize = true;
            lblLank.Location = new Point(78, 40);
            lblLank.Margin = new Padding(2, 0, 2, 0);
            lblLank.Name = "lblLank";
            lblLank.Size = new Size(32, 15);
            lblLank.TabIndex = 24;
            lblLank.Text = "Länk";
            // 
            // cbValKategori
            // 
            cbValKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbValKategori.FormattingEnabled = true;
            cbValKategori.Location = new Point(78, 203);
            cbValKategori.Margin = new Padding(2);
            cbValKategori.Name = "cbValKategori";
            cbValKategori.Size = new Size(177, 23);
            cbValKategori.TabIndex = 23;
            cbValKategori.SelectedIndexChanged += cbValKategori_SelectedIndexChanged;
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(78, 144);
            tbNamn.Margin = new Padding(2);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(177, 23);
            tbNamn.TabIndex = 22;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.Location = new Point(274, 275);
            btnSparaPodd.Margin = new Padding(2);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(164, 23);
            btnSparaPodd.TabIndex = 21;
            btnSparaPodd.Text = "Spara Podd";
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // tbLank
            // 
            tbLank.Location = new Point(78, 61);
            tbLank.Margin = new Padding(2);
            tbLank.Name = "tbLank";
            tbLank.Size = new Size(177, 23);
            tbLank.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startsidanToolStripMenuItem, minaPoddarToolStripMenuItem, läggTillPoddToolStripMenuItem, hanteraKategoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // startsidanToolStripMenuItem
            // 
            startsidanToolStripMenuItem.Name = "startsidanToolStripMenuItem";
            startsidanToolStripMenuItem.Size = new Size(71, 20);
            startsidanToolStripMenuItem.Text = "Startsidan";
            startsidanToolStripMenuItem.Click += startsidanToolStripMenuItem_Click;
            // 
            // minaPoddarToolStripMenuItem
            // 
            minaPoddarToolStripMenuItem.Name = "minaPoddarToolStripMenuItem";
            minaPoddarToolStripMenuItem.Size = new Size(87, 20);
            minaPoddarToolStripMenuItem.Text = "Mina poddar";
            minaPoddarToolStripMenuItem.Click += minaPoddarToolStripMenuItem_Click_1;
            // 
            // läggTillPoddToolStripMenuItem
            // 
            läggTillPoddToolStripMenuItem.Name = "läggTillPoddToolStripMenuItem";
            läggTillPoddToolStripMenuItem.Size = new Size(92, 20);
            läggTillPoddToolStripMenuItem.Text = "Lägg till podd";
            // 
            // hanteraKategoriToolStripMenuItem
            // 
            hanteraKategoriToolStripMenuItem.Name = "hanteraKategoriToolStripMenuItem";
            hanteraKategoriToolStripMenuItem.Size = new Size(107, 20);
            hanteraKategoriToolStripMenuItem.Text = "Hantera kategori";
            hanteraKategoriToolStripMenuItem.Click += hanteraKategoriToolStripMenuItem_Click;
            // 
            // btnHamtaPodd1
            // 
            btnHamtaPodd1.Location = new Point(99, 83);
            btnHamtaPodd1.Margin = new Padding(2);
            btnHamtaPodd1.Name = "btnHamtaPodd1";
            btnHamtaPodd1.Size = new Size(125, 20);
            btnHamtaPodd1.TabIndex = 29;
            btnHamtaPodd1.Text = "Hämta Podd";
            btnHamtaPodd1.UseVisualStyleBackColor = true;
            btnHamtaPodd1.Click += btnHamtaPodd1_Click;
            // 
            // LaggTillPodd2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 567);
            Controls.Add(btnHamtaPodd1);
            Controls.Add(lblPodd);
            Controls.Add(tbPoddNamn);
            Controls.Add(lblValKategori);
            Controls.Add(lblNamn);
            Controls.Add(lblLank);
            Controls.Add(cbValKategori);
            Controls.Add(tbNamn);
            Controls.Add(btnSparaPodd);
            Controls.Add(tbLank);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "LaggTillPodd2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaggTillPodd2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPodd;
        private TextBox tbPoddNamn;
        private Label lblValKategori;
        private Label lblNamn;
        private Label lblLank;
        private ComboBox cbValKategori;
        private TextBox tbNamn;
        private Button btnSparaPodd;
        private TextBox tbLank;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startsidanToolStripMenuItem;
        private ToolStripMenuItem minaPoddarToolStripMenuItem;
        private ToolStripMenuItem läggTillPoddToolStripMenuItem;
        private ToolStripMenuItem hanteraKategoriToolStripMenuItem;
        private object btnHamtaPodd;
        private Button btnHamtaPodd1;
    }
}