using Globals;
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
    public partial class UpdateOLA : Form
    {
        Hoofdvenster hoofdvenster;
        ILogica logic;
        Boolean edit = false;
        OLA ola;
        Docent docent;
        OPO opo;
        Docent GetVorigeDocent;
        string GetVorigeOpo;
        public UpdateOLA(Hoofdvenster hoofdvenster)
        {
            InitializeComponent();
            logic = new Logica();
            CmbDocent.DataSource = logic.GetDocents();
            CmbDocent.DisplayMember = "fullname";

            CmbOPO.DataSource = logic.GetAllOPOs();
            CmbOPO.DisplayMember = "Naam";

            if (hoofdvenster.GetIndex().Equals("Edit"))
            {
                edit = true;
                GetVorigeDocent = (Docent)hoofdvenster.GetDocent(); ;
                GetVorigeOpo = hoofdvenster.GetValues().SelectedItems[0].SubItems[2].Text;
                TxtCode.Text = hoofdvenster.GetValues().SelectedItems[0].SubItems[0].Text;
                TxtCode.ReadOnly = true;
                TxtNaam.Text = hoofdvenster.GetValues().SelectedItems[0].SubItems[1].Text;
                NudStudiepunten.Value = Convert.ToInt32(hoofdvenster.GetValues().SelectedItems[0].SubItems[3].Text);
                CmbOPO.SelectedIndex = CmbOPO.FindStringExact(hoofdvenster.GetValues().SelectedItems[0].SubItems[2].Text);
                CmbDocent.SelectedIndex = CmbDocent.FindStringExact(hoofdvenster.GetCmb());
                docent =(Docent)CmbDocent.SelectedItem;
                opo=(OPO) CmbOPO.SelectedItem;
            }
        }

        public OLA GetSelectedOla()
        {
            return ola = (new OLA{Id = logic.GetOlaByCode(TxtCode.Text).Id, Code = TxtCode.Text, Naam = TxtNaam.Text, Studiepunten = Convert.ToInt32(NudStudiepunten.Value), Opo= logic.GetOPOById(opo.id), docenten={logic.GetDocentById(docent.Id) } });
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                GetSelectedOla().docenten.Remove(GetVorigeDocent);
                GetSelectedOla().AddDocent((Docent)CmbDocent.SelectedItem);
                GetSelectedOla().Opo = (OPO)CmbOPO.SelectedItem;
                logic.UpdateOla(ola);
            }
            else
            {
                logic.AddOla(TxtCode.Text, TxtNaam.Text, (int)NudStudiepunten.Value, (Docent)CmbDocent.SelectedItem, (OPO)CmbOPO.SelectedItem);
            }

        }
    }
}
