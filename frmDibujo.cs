using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;


namespace prySotoMariaLujan
{

    public partial class frmDibujo : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Bitmap guardarFirma;

        public frmDibujo()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink300, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.Pink100, MaterialSkin.Accent.Pink100, MaterialSkin.TextShade.WHITE);

            pctFirma.MouseDown += pctFirma_MouseDown;
            pctFirma.MouseMove += pctFirma_MouseMove;
            pctFirma.MouseUp += pctFirma_MouseUp;

            guardarFirma = new Bitmap(pctFirma.Width, pctFirma.Height);
            pctFirma.Image = guardarFirma;
        }

        private Point posicionAnterior;
        private bool dibujando = false;

        private void frmDibujo_Load(object sender, EventArgs e)
        {
            pctFirma.BackColor = Color.White;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el bitmap que contiene la firma
            using (Graphics g = Graphics.FromImage(guardarFirma))
            {
                g.Clear(Color.White); // Limpia el bitmap con un fondo blanco
            }
            pctFirma.Invalidate();
        }

        private void pctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = true;
                posicionAnterior = e.Location;

            }
        }

        private void pctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = false;
            }
        }

        private void pctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics firma = Graphics.FromImage(guardarFirma))
                {
                    Pen pen = new Pen(Color.Black, 2);
                    firma.DrawLine(pen, posicionAnterior, e.Location);
                }
                pctFirma.Invalidate();
                posicionAnterior = e.Location;

            }
        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (guardarFirma != null)
       
            {
                try
                {
                    string carpetaImagenesFirmas = Path.Combine(Application.StartupPath, "Imagenes Firmas");

                    if (!Directory.Exists(carpetaImagenesFirmas))
                    {
                        Directory.CreateDirectory(carpetaImagenesFirmas);
                    }

                    string nombreArchivo = $"firma_{DateTime.Now.ToString("yyyy-MM-dd-HH,mm,ss")}.png";

                    string rutaArchivo = Path.Combine(carpetaImagenesFirmas, nombreArchivo);

                    guardarFirma.Save(rutaArchivo, System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show("¡Firma guardada con exito!");

                    LimpiarFirma();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la firma: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se registro ninguna firma, vuelva a intenrarlo");
            }
        }

        private void LimpiarFirma()
        {
            // Limpiar el bitmap que contiene la firma
            using (Graphics g = Graphics.FromImage(guardarFirma))
            {
                g.Clear(Color.White); // Limpia el bitmap con un fondo blanco
            }

            // Actualizar el PictureBox para mostrar el bitmap limpio
            pctFirma.Invalidate();
        }
    }
}
