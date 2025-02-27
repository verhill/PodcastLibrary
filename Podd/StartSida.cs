using BLL.Controller;
using System.Diagnostics;

namespace Podd
{
    public partial class StartSida : Form
    {
        KategoriController kategoriController;
        public StartSida()
        {
            InitializeComponent();
            kategoriController = new KategoriController();
            kategoriController.SkapaFardigKategori();
        }

        private void startsidanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSida startSida = new StartSida();
            startSida.Show();
        }

        private void minaPoddarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MinaPoddar minaPoddar = new MinaPoddar();
            minaPoddar.Show();
        }

        private void laggTillPoddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LaggTillPodd2 laggTillPodd = new LaggTillPodd2();
            laggTillPodd.Show();
        }

        private void hanteraKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HanteraKategorier hanteraKategorier = new HanteraKategorier();
            hanteraKategorier.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://poddtoppen.se/", UseShellExecute = true 
            });
        }
    }
}
