using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVP3_DAE_2.DataSetTableAdapters;
using System.Text.RegularExpressions;
using EVP3_DAE_2.administrador;

namespace EVP3_DAE_2
{
  public partial class Form1 : Form
  {

    

    UsuariosTableAdapter userAdapter = new UsuariosTableAdapter();

    public Form1()
    {
      InitializeComponent();
    }
    public bool EsCorreoValido(string correo)
    {
      string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
      return Regex.IsMatch(correo, patron);
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      DataTable dt = new DataTable();

      string claveUsuario = txtClave.Text.Trim();
      string usuario = txtUser.Text.Trim();
      if (EsCorreoValido(usuario))
      {
        dt = userAdapter.LoginUsuario(txtUser.Text.Trim(), txtClave.Text.Trim());
        if (dt.Rows.Count > 0)
        {
          if (dt.Rows[0][6].ToString() == "administrador")
          {
            mdiAdministrador administrador = new mdiAdministrador();
            this.Hide();
            administrador.Show();
          }
          else if (dt.Rows[0][6].ToString() == "usuario")
          {
            int id = (int)dt.Rows[0][0];
            this.Hide();
            frmPreferencias preferencias = new frmPreferencias();
            preferencias.idUsuario = id;
            preferencias.Show();

          }
        }
        else
        {
          MessageBox.Show("Usuario o clave incorrecta");
        }
      }
      else
      {
        MessageBox.Show("El formato del correo electrónico no es válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      } 
    }
    private void lblCrearCuenta_Click_1(object sender, EventArgs e)
    {
      CrearUsuario frm = new CrearUsuario();
      frm.Show();
      this.Hide();
    }
  }
}
