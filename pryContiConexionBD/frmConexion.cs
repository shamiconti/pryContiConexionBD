using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryContiConexionBD
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private void frmConexion_Load(object sender, EventArgs e)
        {
            
        }

        clsConexionBD ObjConexion = new clsConexionBD();

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ObjConexion.ConectarBase(dgvConexion);
        }
    }
}
