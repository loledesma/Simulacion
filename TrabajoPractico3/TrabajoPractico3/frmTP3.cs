using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico3
{
    public partial class frmTP3 : Form
    {
        public frmTP3()
        {
            InitializeComponent();
        }
        private void btn_grafico_Click(object sender, EventArgs e)
        {
            grafico graficoDistribucion = new grafico(); 
            graficoDistribucion.Show();
        }
    }
}
