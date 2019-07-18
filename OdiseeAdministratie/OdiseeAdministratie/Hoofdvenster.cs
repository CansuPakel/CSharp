using Logiclayer;
using SharpRepository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdiseeAdministratie
{
    public partial class Hoofdvenster : Form
    {
        ILogica logica;
        public Hoofdvenster()
        {
            logica = new Logica();
            InitializeComponent();
        }

        private void Hoofdvenster_Load(object sender, EventArgs e)
        {
            cmbDocenten.DataSource = logica.GetDocents();
            cmbDocenten.ValueMember = "naam";

        }
    }
}
