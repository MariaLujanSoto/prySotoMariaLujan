using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls; 

namespace prySotoMariaLujan
{
    public partial class frmPrincipal : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmPrincipal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink300, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.Pink100, MaterialSkin.Accent.Pink100, MaterialSkin.TextShade.WHITE);

           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void dibujarOFirmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDibujo frmDibujo = new frmDibujo();  
            frmDibujo.Show();
            this.Hide();
        }

        private void jugarGálagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJugarGalaga frmJugarGalaga = new frmJugarGalaga();
            frmJugarGalaga.Show();
            this.Hide();

        }
    }
}
