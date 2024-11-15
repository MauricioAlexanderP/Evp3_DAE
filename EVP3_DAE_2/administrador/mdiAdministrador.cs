using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVP3_DAE_2.administrador
{
  public partial class mdiAdministrador : Form
  {
    public mdiAdministrador()
    {
      InitializeComponent();
    }

    private void inicnioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmAdministrador frm = new frmAdministrador();
      frm.MdiParent = this;
      frm.Show();
    }

    private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmEstadisticas frm = new frmEstadisticas();
      frm.MdiParent = this;
      frm.Show();
    }
  }
}
