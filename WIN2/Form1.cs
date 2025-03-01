using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APLICACION_BROMA
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FORMATEANDO SU DISCO DURO");
        }

        private void BTN_CANCEL_MouseHover(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - BTN_CANCEL.Width;
            int maxY = this.ClientSize.Height - BTN_CANCEL.Height;

            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            BTN_CANCEL.Location = new Point(newX, newY);
        }
    }

}