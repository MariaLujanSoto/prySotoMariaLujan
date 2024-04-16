using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySotoMariaLujan
{


    internal class clsNave
    {
        public PictureBox nave;
       
        public Timer timer;
        public void crearNave()
        {
            nave = new PictureBox();
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "ImgJuego", "nave.png");
            nave.ImageLocation = ruta;
            nave.SizeMode = PictureBoxSizeMode.StretchImage;
            nave.Size = new Size(100, 100);
            nave.BackColor = Color.Transparent;
        }
    }
}
