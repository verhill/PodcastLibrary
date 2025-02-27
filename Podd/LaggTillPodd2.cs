using BLL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Podd
{
    public partial class LaggTillPodd2 : Form
    {
        PoddController poddController;
        KategoriController kategoriController;
        Validering validering;
        public LaggTillPodd2()
        {
            InitializeComponent();
            tbPoddNamn.ReadOnly = true;
            kategoriController = new KategoriController();
            validering = new Validering();
            poddController = new PoddController();
            Fyllcb();
        }

        private async void btnSparaPodd_Click(object sender, EventArgs e)
        {
            string podName = "";
            string kategori = "";
            if (tbPoddNamn.Text != "")
            {
                podName = string.IsNullOrEmpty(tbNamn.Text) ? tbPoddNamn.Text : tbNamn.Text;
            }
            else 
            {
                if (validering.CheckIfStringIsEmpty(podName)) 
                {
                    MessageBox.Show("Vänligen fyll i poddnamn", "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (cbValKategori.SelectedItem != null)
            {
                kategori = cbValKategori.SelectedItem?.ToString() ?? "";
            }
            else
            {
                if (validering.CheckIfStringIsEmpty(kategori))
                {
                    MessageBox.Show("Vänligen välj en kategori!", "", MessageBoxButtons.OK);
                    return;
                }
            }


            

            if (!validering.CheckIfNameExist(podName)) 
            {
                MessageBox.Show("Namnen du angett på podden finns redan!", "", MessageBoxButtons.OK);
                return;
            }
            await Task.Delay(100);

            poddController.SavePod(tbLank.Text, podName, kategori);

            tbLank.Text = string.Empty;
            tbNamn.Text = string.Empty;
            tbPoddNamn.Text = string.Empty;
            cbValKategori.SelectedIndex = -1;

            MessageBox.Show("Podd sparad!");
        }

        private void cbValKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Fyllcb()
        {
            List<string> kategoriLista = kategoriController.LasAllaKategorier();
            foreach (string s in kategoriLista)
            {
                cbValKategori.Items.Add(s);
            }

        }

        private async void btnHamtaPodd1_Click(object sender, EventArgs e)
        {
            string hamtaUrl = tbLank.Text;
            if (validering.CheckIfUrlExist(hamtaUrl)) 
            {
                MessageBox.Show("Denna url finns redan sparad!", "", MessageBoxButtons.OK);
                return;
            }
            if (!validering.TryParseFeed(hamtaUrl))
            {
                MessageBox.Show("Ogiltigt URL format", "", MessageBoxButtons.OK);
                return;
            }
            await Task.Delay(100);

            poddController.HamtaPoddFranRss(hamtaUrl);
            tbPoddNamn.Text = poddController.GetPodName();
            tbNamn.Text = poddController.GetPodName();
        }

        private void startsidanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSida startsida = new StartSida();
            startsida.Show();
        }

        private void minaPoddarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MinaPoddar minaPoddar = new MinaPoddar();
            minaPoddar.Show();
        }

        private void hanteraKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HanteraKategorier hanteraKategorier = new HanteraKategorier();
            hanteraKategorier.Show();
        }
    }
}
