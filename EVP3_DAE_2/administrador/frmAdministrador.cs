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
  public partial class frmAdministrador : Form
  {
    AutosTableAdapter adapter = new AutosTableAdapter();
    Autos1TableAdapter adapter1 = new Autos1TableAdapter();
    public int idAuto;
    public frmAdministrador()
    {
      InitializeComponent();
      // Configuración del DateTimePicker para seleccionar solo el año
      dtAnio.Format = DateTimePickerFormat.Custom;
      dtAnio.CustomFormat = "yyyy";
      dtAnio.ShowUpDown = true; // Deshabilita el calendario desplegable
      Vehicolos();

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      agregarAuto();
      Vehicolos();
      MessageBox.Show($"{txtMarca} {txtModelo} agregado correctamente");
    }
    private void button2_Click(object sender, EventArgs e)
    {
      ElimiarAuto();
      txtMarca.Text = "";
      txtModelo.Text = "";
    }

    private void Vehicolos()
    {
      dAutos.DataSource = adapter.GetData();
    }
    private void agregarAuto()
    {
      // Comprueba si los campos de texto de marca y modelo están vacíos
      if (txtMarca.Text == "" && txtModelo.Text == "")
      {
        // Muestra un mensaje de error indicando que se deben ingresar la marca y el modelo del auto
        MessageBox.Show("Debe ingresar la marca y el modelo del auto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        // Llama al método AgregarAuto del adaptador de tabla AutosTableAdapter para agregar un nuevo auto
        // Pasando como argumentos la marca y el modelo ingresados en los campos de texto, y el año seleccionado en el DateTimePicker
        adapter.AgregarAuto(txtMarca.Text.Trim(), txtModelo.Text.Trim(), int.Parse(dtAnio.Value.ToString("yyyy")));
      }
    }

    private void dAutos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        // Obtiene la fila seleccionada en el DataGridView
        DataGridViewRow row = dAutos.Rows[e.RowIndex];

        // Obtiene el valor de la celda "marca" de la fila seleccionada y lo convierte a string
        string marca = row.Cells["marca"].Value.ToString();

        // Obtiene el valor de la celda "modelo" de la fila seleccionada y lo convierte a string
        string modelo = row.Cells["modelo"].Value.ToString();

        // Obtiene el valor de la celda "año" de la fila seleccionada y lo convierte a int
        int anio = (int)row.Cells["año"].Value;

        // Asigna el valor de la marca al TextBox txtMarca
        txtMarca.Text = marca;

        // Asigna el valor del modelo al TextBox txtModelo
        txtModelo.Text = modelo;

        // Crea una nueva instancia de DateTime con el valor del año y el primer día del mes (1 de enero)
        dtAnio.Value = new DateTime(anio, 1, 1);

        // Obtiene el ID del auto utilizando el adaptador de tabla Autos1TableAdapter
        var autoTable = adapter1.IdAuto(marca.Trim(), modelo.Trim(), anio);

        // Verifica si se encontraron resultados para el auto seleccionado
        if (autoTable.Rows.Count > 0)
        {
          // Obtiene el valor de la columna "id_auto" de la primera fila y lo asigna a la variable idAuto
          idAuto = autoTable.First().id_auto;
        }
        else
        {
          // Muestra un mensaje indicando que no se encontraron resultados para el auto seleccionado
          MessageBox.Show("No se encontraron resultados para el auto seleccionado.");
        }
      }
      
    }

    private void ElimiarAuto()
    {
      if (idAuto > 0)
      {
        adapter.ElimarAuto(idAuto); // Llama al método ElimarAuto del adaptador de tabla AutosTableAdapter para eliminar el auto con el ID especificado
        MessageBox.Show("Auto eliminado correctamente"); // Muestra un mensaje indicando que el auto se ha eliminado correctamente
        Vehicolos(); // Actualiza la lista de autos en el DataGridView
      }
      else
      {
        MessageBox.Show("No se ha seleccionado un auto para eliminar"); // Muestra un mensaje indicando que no se ha seleccionado un auto para eliminar
      }
    }

    private void ActualizarAuto()
    {
      // Obtiene los valores de la marca, modelo y año del auto seleccionado en el DataGridView
      string marca;
      string modelo;
      int anio;
      if (txtMarca.Text == dAutos.CurrentRow.Cells[1].Value.ToString())
      {
        marca = dAutos.CurrentRow.Cells[1].Value.ToString();
      }
      else
      {
        marca = txtMarca.Text;
      }
      if (txtModelo.Text == dAutos.CurrentRow.Cells[2].Value.ToString())
      {
        modelo = dAutos.CurrentRow.Cells[2].Value.ToString();
      }
      else
      {
        modelo = txtModelo.Text;
      }
      if (dtAnio.Value.ToString("yyyy") == dAutos.CurrentRow.Cells[3].Value.ToString())
      {
        anio = int.Parse(dAutos.CurrentRow.Cells[3].Value.ToString());
      }
      else
      {
        anio = int.Parse(dtAnio.Value.ToString("yyyy"));
      }

      // Verifica si se ha seleccionado un auto
      if (idAuto > 0)
      {
        // Llama al método ActualizarAuto del adaptador de tabla AutosTableAdapter para actualizar el auto con los nuevos valores
        adapter.ActualizarAuto(marca, modelo, anio, idAuto);
        // Muestra un mensaje indicando que el auto se ha actualizado correctamente
        MessageBox.Show("Auto actualizado correctamente");
        // Actualiza la lista de autos en el DataGridView
        Vehicolos();
      }
      else
      {
        // Muestra un mensaje indicando que no se ha seleccionado un auto para actualizar
        MessageBox.Show("No se ha seleccionado un auto para actualizar");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      ActualizarAuto();
    }
  }
}
