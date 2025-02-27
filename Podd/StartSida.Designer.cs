namespace Podd
{
    partial class StartSida
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
            components = new System.ComponentModel.Container();
            rubrik = new Label();
            process1 = new System.Diagnostics.Process();
            menuStrip1 = new MenuStrip();
            startsidanToolStripMenuItem = new ToolStripMenuItem();
            minaPoddarToolStripMenuItem = new ToolStripMenuItem();
            läggTillPoddToolStripMenuItem = new ToolStripMenuItem();
            hanteraKategoriToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            linkLabel1 = new LinkLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // rubrik
            // 
            rubrik.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            rubrik.Location = new Point(379, 252);
            rubrik.Margin = new Padding(4, 0, 4, 0);
            rubrik.Name = "rubrik";
            rubrik.Size = new Size(850, 333);
            rubrik.TabIndex = 4;
            rubrik.Text = "Poddspelare";
            rubrik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startsidanToolStripMenuItem, minaPoddarToolStripMenuItem, läggTillPoddToolStripMenuItem, hanteraKategoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1638, 44);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // startsidanToolStripMenuItem
            // 
            startsidanToolStripMenuItem.Name = "startsidanToolStripMenuItem";
            startsidanToolStripMenuItem.Size = new Size(138, 36);
            startsidanToolStripMenuItem.Text = "Startsidan";
            startsidanToolStripMenuItem.Click += startsidanToolStripMenuItem_Click;
            // 
            // minaPoddarToolStripMenuItem
            // 
            minaPoddarToolStripMenuItem.Name = "minaPoddarToolStripMenuItem";
            minaPoddarToolStripMenuItem.Size = new Size(171, 36);
            minaPoddarToolStripMenuItem.Text = "Mina poddar";
            minaPoddarToolStripMenuItem.Click += minaPoddarToolStripMenuItem_Click;
            // 
            // läggTillPoddToolStripMenuItem
            // 
            läggTillPoddToolStripMenuItem.Name = "läggTillPoddToolStripMenuItem";
            läggTillPoddToolStripMenuItem.Size = new Size(181, 36);
            läggTillPoddToolStripMenuItem.Text = "Lägg till podd";
            läggTillPoddToolStripMenuItem.Click += laggTillPoddToolStripMenuItem_Click;
            // 
            // hanteraKategoriToolStripMenuItem
            // 
            hanteraKategoriToolStripMenuItem.Name = "hanteraKategoriToolStripMenuItem";
            hanteraKategoriToolStripMenuItem.Size = new Size(212, 36);
            hanteraKategoriToolStripMenuItem.Text = "Hantera kategori";
            hanteraKategoriToolStripMenuItem.Click += hanteraKategoriToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 15F);
            linkLabel1.LinkArea = new LinkArea(0, 10);
            linkLabel1.Location = new Point(492, 563);
            linkLabel1.Margin = new Padding(6, 0, 6, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(589, 109);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Tag = "";
            linkLabel1.Text = "PoddToppen";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // StartSida
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 1210);
            Controls.Add(linkLabel1);
            Controls.Add(menuStrip1);
            Controls.Add(rubrik);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StartSida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label rubrik;
        private System.Diagnostics.Process process1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startsidanToolStripMenuItem;
        private ToolStripMenuItem minaPoddarToolStripMenuItem;
        private ToolStripMenuItem läggTillPoddToolStripMenuItem;
        private ToolStripMenuItem hanteraKategoriToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private LinkLabel linkLabel1;
    }
}
