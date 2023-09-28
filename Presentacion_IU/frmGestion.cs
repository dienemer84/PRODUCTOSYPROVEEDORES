using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Negocio_BLL;

namespace Presentacion_IU
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();

            oBLLProducto = new BLLProducto();

        }

        BLLProducto  oBLLProducto;

        BEProducto  oBEProducto;

        private void frmGestion_Load(object sender, EventArgs e)
        {

        }
    }
}
