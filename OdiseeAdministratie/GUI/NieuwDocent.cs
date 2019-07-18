using Logiclayer;
using System;
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
    public partial class NieuwDocent : Form
    {
        Hoofdvenster hoofdvenster;
        ILogica logic;
        public NieuwDocent(Hoofdvenster hoofdvenster)
        {
            InitializeComponent();
            logic = new Logica();
        }



        private void BtnOk_Click(object sender, EventArgs e)
        {
            logic.AddDocent(TxtNaam.Text, TxtVoornaam.Text, TxtPersoneelsnummer.Text);
        }

        private void NieuwDocent_Load(object sender, EventArgs e)
        {

        }
    }
}
