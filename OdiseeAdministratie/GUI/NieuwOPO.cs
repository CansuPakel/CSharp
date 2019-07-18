using Logiclayer;
using System;
using Globals;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NieuwOPO : Form
    {
        Hoofdvenster hoofdvenster;
        ILogica logic;
        public NieuwOPO(Hoofdvenster hoofdvenster)
        {
            InitializeComponent();
            hoofdvenster = this.hoofdvenster;
            logic = new Logica();
        }

        public Logiclayer.ILogica GetLogiclayer
        {
            get => hoofdvenster.Logiclayer;
            set
            {
                hoofdvenster.Logiclayer = value;
            }
        }
        private void NieuwOPO_Load(object sender, EventArgs e)
        {
            CmbFase.DataSource = Enum.GetValues(typeof(Fase));
            CmbSemester.DataSource = Enum.GetValues(typeof(Semester));
            CmbVerantwoordelijke.DataSource = logic.GetDocents();
            CmbVerantwoordelijke.DisplayMember = "fullname";



        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                logic.AddOpo(TxtCode.Text, TxtNaam.Text, (int)NudStudiepunten.Value, (Fase)Enum.Parse(typeof(Fase), CmbFase.SelectedValue.ToString()), (Semester)Enum.Parse(typeof(Semester), CmbSemester.SelectedValue.ToString()), (Docent)CmbVerantwoordelijke.SelectedItem);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void TxtNaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void NudStudiepunten_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbVerantwoordelijke_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
