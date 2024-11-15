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

namespace EVP3_DAE_2
{
  public partial class frmPreferencias : Form
  {
    PreferenciasTableAdapter adapter = new PreferenciasTableAdapter();
    AutosTableAdapter adapterAutos = new AutosTableAdapter();
    public int idUsuario { get; set; }

    public string marcaAuto;
    public string modeloAuto;
    public string anioAuto;
    public int idAuto;

    public frmPreferencias()
    {
      InitializeComponent();
    }
    private void frmPreferencias_Load(object sender, EventArgs e)
    {
      listaFavoritos();
      listaAutos();
    }

    //lista los autos favoritos del usuario
    private void listaFavoritos()
    {
      // Asigna los datos de la consulta "Preferencias" al control DataGridView "dPrefernciasAutos"
      dPrefernciasAutos.DataSource = adapter.Preferencias(idUsuario);
      // Oculta la columna 0 del control DataGridView "dPrefernciasAutos"
      dPrefernciasAutos.Columns[0].Visible = false;
      // Oculta la columna 1 del control DataGridView "dPrefernciasAutos"
      dPrefernciasAutos.Columns[1].Visible = false;
      // Oculta la columna 2 del control DataGridView "dPrefernciasAutos"
      dPrefernciasAutos.Columns[2].Visible = false;
      // Oculta la columna 3 del control DataGridView "dPrefernciasAutos"
      dPrefernciasAutos.Columns[3].Visible = false;
      // Oculta la columna 4 del control DataGridView "dPrefernciasAutos"
      dPrefernciasAutos.Columns[4].Visible = false;
      // Oculta la columna 8 del control DataGridView "dPrefernciasAutos"
      dPrefernciasAutos.Columns[8].Visible = false;

    }

    //Lista todos los autos disponibles
    private void listaAutos()
    {
      dAutos.DataSource = adapterAutos.GetData();
    }


    //Funcion para agregar auto a favoritos
    private void btnAgregar_Click(object sender, EventArgs e)
    {
      // Cambia la pestaña activa en el control TabControl a tabPage2
      tabControl1.SelectedTab = tabPage2;
    }

    private void dAutos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      // Verifica si el índice de la fila seleccionada es válido (mayor o igual a 0)
      if (e.RowIndex >= 0)
      {
        // Obtiene la fila seleccionada del DataGridView "dAutos"
        DataGridViewRow row = dAutos.Rows[e.RowIndex];

        // Asigna el valor de la celda "marca" de la fila seleccionada a la variable "marcaAuto"
        marcaAuto = row.Cells["marca"].Value.ToString();

        // Asigna el valor de la celda "modelo" de la fila seleccionada a la variable "modeloAuto"
        modeloAuto = row.Cells["modelo"].Value.ToString();

        // Asigna el valor de la celda "año" de la fila seleccionada a la variable "anioAuto"
        anioAuto = row.Cells["año"].Value.ToString();

        // Asigna el valor de la celda "id" de la fila seleccionada a la variable "idAuto"
        idAuto = (int)row.Cells["id"].Value;
      }
      
    }
    private void btnAgregaFavoritos_Click(object sender, EventArgs e)
    {
      bool autoYaEnFavoritos = false;

      foreach (DataGridViewRow row in dPrefernciasAutos.Rows)
      {
        // Ensure the column name is correct
        if (row.Cells["id_auto"] != null && row.Cells["id_auto"].Value != null && (int)row.Cells["id_auto"].Value == idAuto)
        {
          autoYaEnFavoritos = true;
          break;
        }
      }
      if (autoYaEnFavoritos)
      {
        MessageBox.Show("Auto ya se encuentra en favoritos", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        adapter.AgregarAPreferencia(idUsuario, idAuto);
        listaFavoritos();
        tabControl1.SelectedTab = tabPage1;
      }
    }


    //Funciones para eliminar auto de favoritos
    private void btnEliminar_Click(object sender, EventArgs e)
    {
      // Verifica si no se ha seleccionado un auto (idAuto es 0)
      if (idAuto == 0)
      {
        // Muestra un mensaje de error indicando que se debe seleccionar un auto
        MessageBox.Show("Seleccione un auto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        // Llama al método para eliminar el auto de los favoritos usando el idAuto
        adapter.EliminarAutoDeFavoritos(idAuto);

        // Actualiza la lista de autos favoritos
        listaFavoritos();

        // Muestra un mensaje informando que el auto ha sido eliminado de los favoritos
        MessageBox.Show("Auto eliminado de favoritos", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      
      
    }
    private void dPrefernciasAutos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridViewRow row = dPrefernciasAutos.Rows[e.RowIndex];
        idAuto = (int)row.Cells["id_auto"].Value;
      }
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {
      // Obtiene el DataTable que es la fuente de datos del DataGridView "dAutos"
      DataTable dt = (DataTable)dAutos.DataSource;

      // Verifica si el DataTable no es nulo
      if (dt != null)
      {
        // Aplica un filtro a la vista predeterminada del DataTable para mostrar solo las filas
        // donde la columna "marca" o "modelo" contiene el texto ingresado en el TextBox "txtBuscar"
        dt.DefaultView.RowFilter = string.Format("marca LIKE '%{0}%' OR modelo LIKE '%{0}%'", txtBuscar.Text);
      }
    }
  }
}
