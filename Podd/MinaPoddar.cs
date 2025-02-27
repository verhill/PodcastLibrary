using BLL;
using BLL.Controller;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podd
{
    public partial class MinaPoddar : Form
    {
        private PoddController poddController;
        KategoriController kategoriController;
        Validering validering;
        public MinaPoddar()
        {
            InitializeComponent();
            rtbAvsnitt.WordWrap = false;
            rtbAvsnitt.ScrollBars = RichTextBoxScrollBars.Both;
            rtbBeskrivning.ScrollBars = RichTextBoxScrollBars.Both;
            rtbAvsnitt.ReadOnly = true;
            rtbBeskrivning.ReadOnly = true;
            tbMinaPoddar.ReadOnly = true;
            poddController = new PoddController();
            kategoriController = new KategoriController();
            validering = new Validering();

            Fyllcb();
            VisaPoddar();
            FyllCbPoddar();
        }

        private void VisaPoddar()
        {
            tbMinaPoddar.Clear();
            var poddar = poddController.GetAllPods();

            foreach (var podd in poddar.Distinct())
            {
                tbMinaPoddar.AppendText(podd.PodTitel + Environment.NewLine);
            }
        }

        private void FyllCbPoddar()
        {
            cbTaBortPodd.Items.Clear();
            cbAndraNamn.Items.Clear();
            List<Pod> poddLista = poddController.GetAllPods();
            foreach (var poddar in poddLista.Distinct())
            {
                cbTaBortPodd.Items.Add(poddar.PodTitel);
                cbAndraNamn.Items.Add(poddar.PodTitel);
                cbAndraPoddKategori.Items.Add(poddar.PodTitel);
            }
        }

        private void Fyllcb()
        {
            cbValKategori.Items.Clear();
            List<string> kategoriLista = kategoriController.LasAllaKategorier();
            foreach (string kategori in kategoriLista)
            {
                cbValKategori.Items.Add(kategori);
                cbAndraKategori.Items.Add(kategori);
            }
        }

        private void cbValKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            string valdKategori = cbValKategori.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(valdKategori))
            {
                var poddarForKategori = kategoriController.HamtaPoddarForKategori(valdKategori);

                tbMinaPoddar.Clear();

                foreach (var podd in poddarForKategori)
                {
                    tbMinaPoddar.AppendText(podd.PodTitel + Environment.NewLine);
                }
            }
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

        private void läggTillPoddToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void VisaAvsnittForPodd(Pod poddTitel)
        {
            rtbAvsnitt.Clear();
            Color[] colors = { Color.White, Color.LightGray };
            int colorIndex = 0;

            foreach (var avsnitt in poddTitel.Avsnitt)
            {
                rtbAvsnitt.SelectionBackColor = colors[colorIndex];
                rtbAvsnitt.AppendText(avsnitt.Titel + Environment.NewLine);
                colorIndex = (colorIndex + 1) % colors.Length;
            }

            rtbAvsnitt.SelectionBackColor = rtbAvsnitt.BackColor;
        }

        private void VisaBeskrivningForAvsnitt(string avsnittTitel)
        {
            var poddar = poddController.GetAllPods();
            foreach (var podd in poddar)
            {
                var avsnitt = podd.Avsnitt.FirstOrDefault(a => a.Titel.Equals(avsnittTitel));
                if (avsnitt != null)
                {
                    rtbBeskrivning.Clear();
                    rtbBeskrivning.AppendText(avsnitt.Beskrivning);
                    break;
                }
            }
        }

        private void tbMinaPoddar_MouseClick(object sender, MouseEventArgs e)
        {

            int index = tbMinaPoddar.GetLineFromCharIndex(tbMinaPoddar.SelectionStart);
            if (index >= 0 && index < tbMinaPoddar.Lines.Length)
            {
                string valdPodTitel = tbMinaPoddar.Lines[index].Trim();
                Pod podd = poddController.GetPodByTitle(valdPodTitel);
                if (podd != null)
                {
                    VisaAvsnittForPodd(podd);
                }
                else
                {
                    MessageBox.Show("Podd not found: " + valdPodTitel);
                }
            }
        }


        private void rtbAvsnitt_MouseClick(object sender, MouseEventArgs e)
        {
            int index = rtbAvsnitt.GetLineFromCharIndex(rtbAvsnitt.SelectionStart);
            if (index >= 0 && index < rtbAvsnitt.Lines.Length)
            {
                string selectedAvsnittTitle = rtbAvsnitt.Lines[index];
                VisaBeskrivningForAvsnitt(selectedAvsnittTitle);
            }
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTaBortPodd.Text))
            {
                MessageBox.Show("Ingen podd att ta bort är vald!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Är du säker?", "Ta bort podcast", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string valdPodd = cbTaBortPodd.SelectedItem.ToString();
                poddController.DeletePod(valdPodd);
                FyllCbPoddar();
                VisaPoddar();
            }
            else if (dialogResult == DialogResult.No)
            {
                MinaPoddar minaPoddar = new MinaPoddar();
            }

        }

        private void btnAndraNamn_Click_1(object sender, EventArgs e)
        {
            string nyttNamn = tbAndraNamn.Text;
            string valdPodTitel = "";
            if (cbAndraNamn.SelectedItem != null) 
            { 
                valdPodTitel = cbAndraNamn.SelectedItem.ToString();
            }
            else 
            {
                if (validering.CheckIfStringIsEmpty(valdPodTitel)) 
                {
                    MessageBox.Show("Vänligen välj en podd att ändra namn på!", "", MessageBoxButtons.OK);
                    return;
                }
            }
                poddController.UppdateraPoddNamn(valdPodTitel, nyttNamn);
            VisaPoddar();
        }

        private void cbAndraNamn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valdPodd = cbAndraNamn.SelectedItem.ToString();
            tbAndraNamn.Text = valdPodd.ToString();
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            string valdPoddTitel = "";
            string nyKategoriNamn = "";

            if (cbAndraKategori.SelectedItem != null && cbAndraPoddKategori.SelectedItem != null)
            {
                 valdPoddTitel = cbAndraPoddKategori.SelectedItem.ToString();
                 nyKategoriNamn = cbAndraKategori.SelectedItem.ToString();
            }
            else
            {
                if (validering.CheckIfStringIsEmpty(valdPoddTitel))
                {
                    MessageBox.Show("Vänligen välj en podd!", "", MessageBoxButtons.OK);
                    return;
                }

                if (validering.CheckIfStringIsEmpty(nyKategoriNamn))
                {
                    MessageBox.Show("Vänligen välj en kategori!", "", MessageBoxButtons.OK);
                    return;
                }
            }

           

            try
            {
                poddController.BytPoddKategori(valdPoddTitel, nyKategoriNamn);
                MessageBox.Show("Podden har uppdaterats till den nya kategorin");
                FyllCbPoddar();
                VisaPoddar();
            }
            catch(Exception)
            {
                MessageBox.Show("Ett fel uppstod"); 
            }
        }
    }

}
