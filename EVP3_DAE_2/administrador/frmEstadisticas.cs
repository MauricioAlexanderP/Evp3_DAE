using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EVP3_DAE_2.DataSetTableAdapters;

namespace EVP3_DAE_2.administrador
{
  public partial class frmEstadisticas : Form
  {
    // Crear una instancia del adaptador de tabla preferencias
    preferenciasTableAdapter adapter = new preferenciasTableAdapter();
    // Crear una instancia del adaptador de tabla Autos2
    Autos2TableAdapter adapter2 = new Autos2TableAdapter();
    public frmEstadisticas()
    {
      InitializeComponent();

    }

    private void frmEstadisticas_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dataSet.Preferencias' Puede moverla o quitarla según sea necesario.
      this.preferenciasTableAdapter.Fill(this.dataSet.Preferencias);
      // TODO: esta línea de código carga datos en la tabla 'dataSet.Autos' Puede moverla o quitarla según sea necesario.
      this.autosTableAdapter.Fill(this.dataSet.Autos);

      // Limpiar ChartAreas, Titles y Series previas para evitar duplicados
      gModelos.ChartAreas.Clear();
      gModelos.Titles.Clear();
      gModelos.Series.Clear();

      // Agregar nueva área de gráfico
      ChartArea area = new ChartArea();
      gModelos.ChartAreas.Add(area);

      // Configurar título
      Title titulo = new Title("Modelos");
      titulo.Font = new Font("Arial", 15, FontStyle.Bold);
      gModelos.Titles.Add(titulo);


      // Configurar la serie
      Series series = new Series("modelosPopulares");
      series.ChartType = SeriesChartType.Bar;
      series.XValueMember = "modelo";
      series.YValueMembers = "NUM";
      series.IsValueShownAsLabel = true;

      // Añadir la serie al gráfico
      gModelos.Series.Add(series);

      // Asignar la fuente de datos
      gModelos.DataSource = adapter.ModelosMasPopulares();

      // Configuración adicional para mejorar la legibilidad en el gráfico de barras
      gModelos.ChartAreas[0].AxisX.Title = "Modelo";
      gModelos.ChartAreas[0].AxisY.Title = "Cantidad";
      gModelos.ChartAreas[0].AxisX.Interval = 1; // Asegura que cada marca se muestre en el eje X

      // Actualizar el gráfico para reflejar los cambios en los datos
      gModelos.DataBind();



      //Garfica 2
      // Limpiar ChartAreas, Titles y Series previas para evitar duplicados
      gMarca.ChartAreas.Clear();
      gMarca.Titles.Clear();
      gMarca.Series.Clear();

      // Agregar una nueva área de gráfico
      ChartArea area2 = new ChartArea();
      gMarca.ChartAreas.Add(area2);

      // Configurar título del gráfico
      Title titulo2 = new Title("Marcas");
      titulo2.Font = new Font("Arial", 15, FontStyle.Bold);
      gMarca.Titles.Add(titulo2);

      // Configurar la serie para el gráfico de barras
      Series series2 = new Series("marcasPopulares");
      series2.ChartType = SeriesChartType.Pie; // Tipo de gráfico de barras
      series2.XValueMember = "marca";          // Valor del eje X
      series2.YValueMembers = "NUM";           // Valor del eje Y
      series2.IsValueShownAsLabel = true;      // Mostrar valores como etiquetas

      // Añadir la serie al gráfico
      gMarca.Series.Add(series2);

      // Asignar la fuente de datos
      gMarca.DataSource = adapter2.MarcaMasPopular();

      // Configuración adicional para mejorar la legibilidad en el gráfico de barras
      gMarca.ChartAreas[0].AxisX.Title = "Marca";
      gMarca.ChartAreas[0].AxisY.Title = "Cantidad";
      gMarca.ChartAreas[0].AxisX.Interval = 1; // Asegura que cada marca se muestre en el eje X

      // Actualizar el gráfico para reflejar los cambios en los datos
      gMarca.DataBind();



      //-----------------------
      // Eliminar las series existentes antes de agregar una nueva
      gTiempo.Series.Clear();

      // Obtener los datos usando el TableAdapter desde el DataSet
      preferenciasFechaTableAdapter adapterFecha = new preferenciasFechaTableAdapter();
      DataTable datosPreferencias = adapterFecha.TodasLasPreferencias(); // Devuelve un DataTable con la consulta

      // Configuración del área del gráfico
      var chartArea = gTiempo.ChartAreas[0];
      chartArea.AxisX.Title = "Mes";
      chartArea.AxisY.Title = "Cantidad de Preferencias";
      chartArea.AxisX.Interval = 1; // Mostrar cada mes en el eje X

      // Crear una serie para cada modelo
      var modelosAgrupados = datosPreferencias.AsEnumerable()
          .GroupBy(row => row.Field<string>("modelo")); // Agrupar por modelo

      foreach (var grupo in modelosAgrupados)
      {
        // Crear la serie para cada modelo
        Series series3 = new Series(grupo.Key) // Usar el nombre del modelo como nombre de la serie
        {
          ChartType = SeriesChartType.Line,  // Tipo de gráfico de línea
          IsValueShownAsLabel = true,        // Mostrar valores como etiquetas
          BorderWidth = 2                    // Ancho de la línea para mejorar la visibilidad
        };

        // Añadir los datos de ese modelo al gráfico
        foreach (var row in grupo)
        {
          int mes = row.Field<int>("mes");
          int totalPreferencias = row.Field<int>("total_preferencias");

          // Agregar el punto al gráfico (mes en X, total_preferencias en Y)
          series3.Points.AddXY(mes, totalPreferencias);
        }

        // Añadir la serie al gráfico
        gTiempo.Series.Add(series3);
      }

      // Actualizar el gráfico para reflejar los cambios en los datos
      gTiempo.DataBind();



    }
    private void gModelos_Click_1(object sender, EventArgs e)
    {

    }

    private void gTiempo_Click(object sender, EventArgs e)
    {

    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      // Obtener el DataRowView seleccionado
      DataRowView rowView = (DataRowView)cbBuscar.SelectedItem;

      // Obtener el modelo deseado del DataRowView seleccionado
      string modeloDeseado = rowView["modelo"].ToString();

      // Eliminar las series existentes antes de agregar una nueva
      gTiempo.Series.Clear();

      // Obtener los datos de preferencias para el modelo deseado usando el TableAdapter desde el DataSet
      preferenciasFechaTableAdapter adapterFecha = new preferenciasFechaTableAdapter();
      DataTable datosPreferencias = adapterFecha.EvolucionDePreferencias(modeloDeseado); // Devuelve un DataTable

      // Configuración del área del gráfico
      var chartArea = gTiempo.ChartAreas[0];
      chartArea.AxisX.Title = "Mes";
      chartArea.AxisY.Title = "Cantidad de Preferencias";
      chartArea.AxisX.Interval = 1; // Mostrar cada mes en el eje X

      // Crear una serie para el modelo deseado en el gráfico de línea
      Series series3 = new Series(modeloDeseado)
      {
        ChartType = SeriesChartType.Line,  // Tipo de gráfico de línea
        IsValueShownAsLabel = true,        // Mostrar valores como etiquetas
        BorderWidth = 2                    // Ancho de la línea para mejorar la visibilidad
      };

      // Añadir los datos al gráfico desde el DataTable
      foreach (DataRow row in datosPreferencias.Rows)
      {
        int mes = Convert.ToInt32(row["mes"]);
        int totalPreferencias = Convert.ToInt32(row["total_preferencias"]);

        // Agregar el punto al gráfico (mes en X, total_preferencias en Y)
        series3.Points.AddXY(mes, totalPreferencias);
      }

      // Añadir la serie al gráfico
      gTiempo.Series.Add(series3);

      // Actualizar el gráfico para reflejar los cambios en los datos
      gTiempo.DataBind();
    }

  }
}
