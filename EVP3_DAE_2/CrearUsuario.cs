using EVP3_DAE_2.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EVP3_DAE_2
{
  public partial class CrearUsuario : Form
  {
    UsuariosTableAdapter userAdapter = new UsuariosTableAdapter();
    idTableAdapter idAdapter = new idTableAdapter();
    public CrearUsuario()
    {
      InitializeComponent();
    }

    // Método que verifica si una dirección de correo electrónico es válida
    public bool EsCorreoValido(string correo)
    {
      // Define un patrón de expresión regular para validar el formato del correo electrónico
      string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

      // Utiliza el método Regex.IsMatch para comprobar si el correo coincide con el patrón
      return Regex.IsMatch(correo, patron);
    }


    private void btn_Registar_Usuario_Click(object sender, EventArgs e)
    {

      // Verifica si el correo electrónico ingresado es válido
      if (EsCorreoValido(txtemail.Text.Trim()))
      {
        // Verifica si alguno de los campos de texto está vacío
        if (txtNombre.Text == "" || txtApellido.Text == "" || txtemail.Text == "" || txtClave.Text == "")
        {
          // Muestra un mensaje de error indicando que se deben llenar todos los campos
          MessageBox.Show("Por favor, llene todos los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
          try
          {
            // Encripta el usuario y la clave
            string usuario = txtemail.Text.Trim();
            string clave = txtClave.Text.Trim();
            DataTable dt = new DataTable();
            DataTable idt = new DataTable();
            idt = idAdapter.ultimoId();

            // Obtiene los datos de los usuarios existentes
            dt = userAdapter.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
              // Verifica si el correo electrónico ya está registrado
              if (dt.Rows[i]["email"].ToString() == usuario)
              {
                // Muestra un mensaje de error indicando que el usuario ya existe
                MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              }
              else
              {
                // Agrega el nuevo usuario a la base de datos
                userAdapter.AgregarUsuario(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtemail.Text.Trim(), clave, "usuario");

                // Muestra un mensaje de éxito
                MessageBox.Show("Registro exitoso", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cierra el formulario actual
                this.Close();

                // Abre el formulario de preferencias y asigna el id del nuevo usuario
                frmPreferencias preferencias = new frmPreferencias();
                preferencias.idUsuario = Convert.ToInt32(idt.Rows[0][0]) + 1;
                preferencias.Show();
                break;
              }
            }
          }
          catch (Exception ex)
          {
            // Muestra un mensaje de error en caso de excepción
            MessageBox.Show("Error al registrar el usuario: " + ex.Message);
          }
        }
      }
      else
      {
        // Muestra un mensaje de error indicando que el formato del correo electrónico no es válido
        MessageBox.Show("El formato del correo electrónico no es válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
        
    }
  }
}
