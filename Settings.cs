using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiformapp_chachulova
{
    public partial class Settings : Form
    {
        private Game hra;

        public Settings(Game instanceHry)
        {
            InitializeComponent(); 
            this.hra = instanceHry;
            
            cmbSady.Items.Clear();
            cmbSady.Items.AddRange(Game.SadyNazvy);
            cmbSady.SelectedItem = hra.AktualniSada;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int radky = 4;
            int sloupce = 4;
         
            if (rb4x6.Checked) { radky = 4; sloupce = 6; }
            else if (rb6x6.Checked) { radky = 6; sloupce = 6; }

            string vybranaSada = cmbSady.SelectedItem?.ToString() ?? "Zvirata";
            
            hra.NovaHra(radky, sloupce, vybranaSada);
           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {          
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void NactiNahled()
        {
            string nazev = cmbSady.SelectedItem?.ToString() ?? "Zvirata";
            string[] symboly = Game.GetSadu(nazev);
            
            lblNahled.Text = string.Join(" ", symboly.Take(5)) + " ...";
        }
        
        private void cmbSady_Changed(object sender, EventArgs e)
        {
            NactiNahled();
        }
    }
}

