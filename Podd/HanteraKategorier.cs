using BLL;
using BLL.Controller;
using DAL.Repository;
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
    public partial class HanteraKategorier : Form
    {
        KategoriController kategoriController;
        KategoriRepository kategoriRepository;
        Validering validering;
        public HanteraKategorier()
        {
            InitializeComponent();
            kategoriController = new KategoriController();
            kategoriRepository = new KategoriRepository();
            validering = new Validering();

            Fyllcb();

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


        private void Fyllcb()
        {
            cbBytNamnKategori.Items.Clear();
            cbKategori.Items.Clear();
            List<string> kategoriLista = kategoriController.LasAllaKategorier();
            foreach (string kategori in kategoriLista)
            {
                cbBytNamnKategori.Items.Add(kategori);
                cbKategori.Items.Add(kategori);
            }
            cbBytNamnKategori.SelectedIndex = -1;
            cbKategori.SelectedIndex = -1;
        }

        private void btnSparaNamn_Click(object sender, EventArgs e)
        {
            string valdKategori = "";
            string nyttKategoriNamn = "";

            if (cbBytNamnKategori.SelectedItem != null)
            {
                valdKategori = cbBytNamnKategori.SelectedItem.ToString();
            }
            else 
            {
                if (validering.CheckIfStringIsEmpty(valdKategori)) 
                {
                    MessageBox.Show("Vänligen välj en kategori", "", MessageBoxButtons.OK);
                    return;
                }
                
            }
            if (tbBytNamn.Text != "")
            {
                nyttKategoriNamn = tbBytNamn.Text;
            }
            else
            {
                if (validering.CheckIfStringIsEmpty(nyttKategoriNamn))
                {
                    MessageBox.Show("Vänligen fyll i ett nytt kategori-namn", "", MessageBoxButtons.OK);
                    return;
                }
            }

                Kategori kategori = kategoriController.hamtaKategoriByName(valdKategori);
            DialogResult dialogResult = MessageBox.Show("Är du säker?", "Byt namn på kategori", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (kategori != null)
                {
                    kategori.KattNamn = nyttKategoriNamn;

                    kategoriController.UpdateraKategori(kategori);
                }


                kategoriController.AndraKategoriNamn(valdKategori, nyttKategoriNamn);
                cbBytNamnKategori.Items.Clear();
                tbBytNamn.Clear();
                this.Hide();
                HanteraKategorier hanteraKategorier = new HanteraKategorier();
                hanteraKategorier.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                HanteraKategorier hanteraKategorier = new HanteraKategorier();
                hanteraKategorier.Show();

            }
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            string valdKategori = "";

            if (cbKategori.SelectedItem != null)
            {
                valdKategori = cbKategori.SelectedItem.ToString();
            }
            else 
            {
                if (validering.CheckIfStringIsEmpty(valdKategori)) 
                {
                    MessageBox.Show("Vänligen välj en kategori att ta bort!", "", MessageBoxButtons.OK);
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Är du säker?", "Ta bort kategori", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                int i = kategoriRepository.GetIndex(valdKategori);
                kategoriRepository.Delete(i);
                kategoriRepository.TaBortKate(valdKategori);
                this.Hide();
                HanteraKategorier hanteraKategorier = new HanteraKategorier();
                hanteraKategorier.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                HanteraKategorier hanteraKategorier = new HanteraKategorier();
                hanteraKategorier.Show();
            }
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            string kategoriNamn = tbLaggTillKategori.Text;
            if (validering.CheckIfCategoryExist(kategoriNamn)) 
            {
                MessageBox.Show("Namnet på kategorin finns redan, vänligen välj ett annat namn!", "", MessageBoxButtons.OK);
                return;
            }

            if (!string.IsNullOrEmpty(kategoriNamn))
            {
                kategoriController.LaggTillKategori(kategoriNamn, new List<Pod>());
                KategoriRepository.LaggTillKategori(kategoriNamn);
                tbLaggTillKategori.Clear();
                this.Hide();
                HanteraKategorier hanteraKategorier = new HanteraKategorier();
                hanteraKategorier.Show();
            }
            else
            {
                MessageBox.Show("Fältet kan inte vara tomt!");
                this.Hide();
                HanteraKategorier hanteraKategorier = new HanteraKategorier();
                hanteraKategorier.Show();
            }
        }
    }
}
