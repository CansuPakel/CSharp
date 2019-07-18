using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globals;
using Logiclayer;
namespace GUI
{
    public partial class Hoofdvenster : Form
    {
        ILogica logica;

        public Hoofdvenster(ILogica logica)
        {
            this.logica = logica;
            InitializeComponent();
        }

        private void Hoofdvenster_Load(object sender, EventArgs e)
        {
            cmbDocenten.DataSource = logica.GetDocents();
            cmbDocenten.DisplayMember = "fullname";
        }

        public Logiclayer.ILogica Logiclayer
        {
            get => logica;
            set
            {
                logica = value;
            }
        }

        private void BtnNieuwDocent_Click(object sender, EventArgs e)
        {
            new NieuwDocent(this).Show();
            this.Hide();

        }

        private void BtnNieuwOpo_Click(object sender, EventArgs e)
        {
            new NieuwOPO(this).Show();
            this.Hide();
        }

        private void BtnUpdateOla_Click(object sender, EventArgs e)
        {
            new UpdateOLA(this).Show();
            this.Hide();
        }

        private void cmbDocenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOlas.Items.Clear();
            foreach (var i in logica.GetOlaDocent((Docent)cmbDocenten.SelectedItem))
            {
                lstOlas.Items.Add(i);

            }
        }

        private void lstOlas_SelectedIndexChanged(object sender, EventArgs e)
        {
            logica.GetOlaDocent((Docent)cmbDocenten.SelectedItem);
            Console.WriteLine(GetIndex());
        }

        private void BtnVerwijderOLA_Click(object sender, EventArgs e)
        {
            logica.DeleteOla(lstOlas.SelectedItems[0].Text);
        }

        public string GetIndex()
        {
            if (lstOlas.SelectedItems.Count > 0)
            {
                return "Edit";
            }
            return "";
        }

        public ListView GetValues()
        {
            return lstOlas;
        }

        public string GetCmb()
        {
            return ((Docent)cmbDocenten.SelectedItem).Voornaam + ' ' + ((Docent)cmbDocenten.SelectedItem).Naam + ' ' + ((Docent)cmbDocenten.SelectedItem).Personeelsnummer;
        }

        public Docent GetDocent()
        {
            return (Docent)(cmbDocenten.SelectedItem);
        }

        private void BtnNiewOla_Click(object sender, EventArgs e)
        {
            new UpdateOLA(this).Show();
            this.Hide();
        }
    }
}
