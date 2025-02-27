namespace Podd
{
    partial class HanteraKategorier
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
            cbKategori = new ComboBox();
            label1 = new Label();
            btnTaBort = new Button();
            tbLaggTillKategori = new TextBox();
            label2 = new Label();
            tbBytNamn = new TextBox();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            startsidanToolStripMenuItem = new ToolStripMenuItem();
            minaPoddarToolStripMenuItem = new ToolStripMenuItem();
            läggTillPoddToolStripMenuItem = new ToolStripMenuItem();
            hanteraKategoriToolStripMenuItem = new ToolStripMenuItem();
            btnSparaKategori = new Button();
            btnSparaNamn = new Button();
            cbBytNamnKategori = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(190, 119);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(121, 23);
            cbKategori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 101);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(190, 148);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(75, 23);
            btnTaBort.TabIndex = 2;
            btnTaBort.Text = "Ta bort";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // tbLaggTillKategori
            // 
            tbLaggTillKategori.Location = new Point(190, 272);
            tbLaggTillKategori.Name = "tbLaggTillKategori";
            tbLaggTillKategori.Size = new Size(131, 23);
            tbLaggTillKategori.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 254);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Lägg till kategori";
            // 
            // tbBytNamn
            // 
            tbBytNamn.Location = new Point(616, 119);
            tbBytNamn.Name = "tbBytNamn";
            tbBytNamn.Size = new Size(131, 23);
            tbBytNamn.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 100);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Byt namn";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startsidanToolStripMenuItem, minaPoddarToolStripMenuItem, läggTillPoddToolStripMenuItem, hanteraKategoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 24);
            menuStrip1.TabIndex = 8;
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
            minaPoddarToolStripMenuItem.Click += minaPoddarToolStripMenuItem_Click;
            // 
            // läggTillPoddToolStripMenuItem
            // 
            läggTillPoddToolStripMenuItem.Name = "läggTillPoddToolStripMenuItem";
            läggTillPoddToolStripMenuItem.Size = new Size(92, 20);
            läggTillPoddToolStripMenuItem.Text = "Lägg till podd";
            läggTillPoddToolStripMenuItem.Click += läggTillPoddToolStripMenuItem_Click;
            // 
            // hanteraKategoriToolStripMenuItem
            // 
            hanteraKategoriToolStripMenuItem.Name = "hanteraKategoriToolStripMenuItem";
            hanteraKategoriToolStripMenuItem.Size = new Size(107, 20);
            hanteraKategoriToolStripMenuItem.Text = "Hantera kategori";
            hanteraKategoriToolStripMenuItem.Click += hanteraKategoriToolStripMenuItem_Click;
            // 
            // btnSparaKategori
            // 
            btnSparaKategori.Location = new Point(190, 301);
            btnSparaKategori.Name = "btnSparaKategori";
            btnSparaKategori.Size = new Size(75, 23);
            btnSparaKategori.TabIndex = 5;
            btnSparaKategori.Text = "Spara ";
            btnSparaKategori.UseVisualStyleBackColor = true;
            btnSparaKategori.Click += btnSparaKategori_Click;
            // 
            // btnSparaNamn
            // 
            btnSparaNamn.Location = new Point(579, 144);
            btnSparaNamn.Name = "btnSparaNamn";
            btnSparaNamn.Size = new Size(75, 23);
            btnSparaNamn.TabIndex = 9;
            btnSparaNamn.Text = "Spara ";
            btnSparaNamn.UseVisualStyleBackColor = true;
            btnSparaNamn.Click += btnSparaNamn_Click;
            // 
            // cbBytNamnKategori
            // 
            cbBytNamnKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBytNamnKategori.FormattingEnabled = true;
            cbBytNamnKategori.Location = new Point(463, 119);
            cbBytNamnKategori.Margin = new Padding(2);
            cbBytNamnKategori.Name = "cbBytNamnKategori";
            cbBytNamnKategori.Size = new Size(129, 23);
            cbBytNamnKategori.TabIndex = 10;
            // 
            // HanteraKategorier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 567);
            Controls.Add(cbBytNamnKategori);
            Controls.Add(btnSparaNamn);
            Controls.Add(label3);
            Controls.Add(tbBytNamn);
            Controls.Add(btnSparaKategori);
            Controls.Add(label2);
            Controls.Add(tbLaggTillKategori);
            Controls.Add(btnTaBort);
            Controls.Add(label1);
            Controls.Add(cbKategori);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HanteraKategorier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKategori;
        private Label label1;
        private Button btnTaBort;
        private TextBox tbLaggTillKategori;
        private Label label2;
        private TextBox tbBytNamn;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startsidanToolStripMenuItem;
        private ToolStripMenuItem minaPoddarToolStripMenuItem;
        private ToolStripMenuItem läggTillPoddToolStripMenuItem;
        private ToolStripMenuItem hanteraKategoriToolStripMenuItem;
        private Button btnSparaKategori;
        private Button btnSparaNamn;
        private ComboBox cbBytNamnKategori;
    }
}