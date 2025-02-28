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
        int x = 417;
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
            x = x + 200;

            BTN_CANCEL.Location = new Point(x, 224);
        }
    }

}