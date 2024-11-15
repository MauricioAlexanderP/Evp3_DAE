namespace EVP3_DAE_2.administrador
{
  partial class frmEstadisticas
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.gMarca = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.gModelos = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.gTiempo = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label1 = new System.Windows.Forms.Label();
      this.btnBuscar = new controles.Controles.MButton();
      this.dataSet = new EVP3_DAE_2.DataSet();
      this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.autosTableAdapter = new EVP3_DAE_2.DataSetTableAdapters.AutosTableAdapter();
      this.cbBuscar = new System.Windows.Forms.ComboBox();
      this.autosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.autosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.autosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
      this.autosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
      this.fKPreferencidau5165187FBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.preferenciasTableAdapter = new EVP3_DAE_2.DataSetTableAdapters.PreferenciasTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.gMarca)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gModelos)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gTiempo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKPreferencidau5165187FBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gMarca
      // 
      chartArea22.Name = "ChartArea1";
      this.gMarca.ChartAreas.Add(chartArea22);
      legend22.Name = "Legend1";
      this.gMarca.Legends.Add(legend22);
      this.gMarca.Location = new System.Drawing.Point(8, 36);
      this.gMarca.Name = "gMarca";
      this.gMarca.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
      this.gMarca.Size = new System.Drawing.Size(865, 426);
      this.gMarca.TabIndex = 1;
      this.gMarca.Text = "chart1";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(889, 499);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.gMarca);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(881, 470);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Estadisticas de Marcas";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.gModelos);
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(881, 470);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Estadisticas de Modelos";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // gModelos
      // 
      chartArea24.Name = "ChartArea1";
      this.gModelos.ChartAreas.Add(chartArea24);
      legend24.Name = "Legend1";
      this.gModelos.Legends.Add(legend24);
      this.gModelos.Location = new System.Drawing.Point(8, 28);
      this.gModelos.Name = "gModelos";
      this.gModelos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
      this.gModelos.Size = new System.Drawing.Size(850, 415);
      this.gModelos.TabIndex = 1;
      this.gModelos.Text = "chart1";
      this.gModelos.Click += new System.EventHandler(this.gModelos_Click_1);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.cbBuscar);
      this.tabPage3.Controls.Add(this.btnBuscar);
      this.tabPage3.Controls.Add(this.label1);
      this.tabPage3.Controls.Add(this.gTiempo);
      this.tabPage3.Location = new System.Drawing.Point(4, 25);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(881, 470);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Interés por Modelo a lo Largo del Tiempo";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // gTiempo
      // 
      chartArea23.Name = "ChartArea1";
      this.gTiempo.ChartAreas.Add(chartArea23);
      legend23.Name = "Legend1";
      this.gTiempo.Legends.Add(legend23);
      this.gTiempo.Location = new System.Drawing.Point(3, 95);
      this.gTiempo.Name = "gTiempo";
      this.gTiempo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
      series8.ChartArea = "ChartArea1";
      series8.Legend = "Legend1";
      series8.Name = "Series1";
      this.gTiempo.Series.Add(series8);
      this.gTiempo.Size = new System.Drawing.Size(872, 357);
      this.gTiempo.TabIndex = 0;
      this.gTiempo.Text = "chart1";
      this.gTiempo.Click += new System.EventHandler(this.gTiempo_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 27);
      this.label1.TabIndex = 1;
      this.label1.Text = "Buscar";
      // 
      // btnBuscar
      // 
      this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.btnBuscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
      this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnBuscar.BorderRadius = 20;
      this.btnBuscar.BorderSize = 0;
      this.btnBuscar.FlatAppearance.BorderSize = 0;
      this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBuscar.ForeColor = System.Drawing.Color.White;
      this.btnBuscar.Location = new System.Drawing.Point(700, 30);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(150, 40);
      this.btnBuscar.TabIndex = 3;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.TextColor = System.Drawing.Color.White;
      this.btnBuscar.UseVisualStyleBackColor = false;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // dataSet
      // 
      this.dataSet.DataSetName = "DataSet";
      this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // autosBindingSource
      // 
      this.autosBindingSource.DataMember = "Autos";
      this.autosBindingSource.DataSource = this.dataSet;
      // 
      // autosTableAdapter
      // 
      this.autosTableAdapter.ClearBeforeFill = true;
      // 
      // cbBuscar
      // 
      this.cbBuscar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autosBindingSource, "id_auto", true));
      this.cbBuscar.DataSource = this.autosBindingSource;
      this.cbBuscar.DisplayMember = "modelo";
      this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbBuscar.FormattingEnabled = true;
      this.cbBuscar.Location = new System.Drawing.Point(11, 46);
      this.cbBuscar.Name = "cbBuscar";
      this.cbBuscar.Size = new System.Drawing.Size(326, 31);
      this.cbBuscar.TabIndex = 4;
      this.cbBuscar.ValueMember = "id_auto";
      // 
      // autosBindingSource1
      // 
      this.autosBindingSource1.DataMember = "Autos";
      this.autosBindingSource1.DataSource = this.dataSet;
      // 
      // autosBindingSource2
      // 
      this.autosBindingSource2.DataMember = "Autos";
      this.autosBindingSource2.DataSource = this.dataSet;
      // 
      // autosBindingSource3
      // 
      this.autosBindingSource3.DataMember = "Autos";
      this.autosBindingSource3.DataSource = this.dataSet;
      // 
      // autosBindingSource4
      // 
      this.autosBindingSource4.DataMember = "Autos";
      this.autosBindingSource4.DataSource = this.dataSet;
      // 
      // fKPreferencidau5165187FBindingSource
      // 
      this.fKPreferencidau5165187FBindingSource.DataMember = "FK__Preferenc__id_au__5165187F";
      this.fKPreferencidau5165187FBindingSource.DataSource = this.autosBindingSource;
      // 
      // preferenciasTableAdapter
      // 
      this.preferenciasTableAdapter.ClearBeforeFill = true;
      // 
      // frmEstadisticas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(889, 499);
      this.Controls.Add(this.tabControl1);
      this.Name = "frmEstadisticas";
      this.Text = "frmEstadisticas";
      this.Load += new System.EventHandler(this.frmEstadisticas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gMarca)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gModelos)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gTiempo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKPreferencidau5165187FBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataVisualization.Charting.Chart gMarca;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataVisualization.Charting.Chart gModelos;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataVisualization.Charting.Chart gTiempo;
    private System.Windows.Forms.Label label1;
    private controles.Controles.MButton btnBuscar;
    private DataSet dataSet;
    private System.Windows.Forms.BindingSource autosBindingSource;
    private DataSetTableAdapters.AutosTableAdapter autosTableAdapter;
    private System.Windows.Forms.ComboBox cbBuscar;
    private System.Windows.Forms.BindingSource autosBindingSource1;
    private System.Windows.Forms.BindingSource autosBindingSource2;
    private System.Windows.Forms.BindingSource autosBindingSource4;
    private System.Windows.Forms.BindingSource autosBindingSource3;
    private System.Windows.Forms.BindingSource fKPreferencidau5165187FBindingSource;
    private DataSetTableAdapters.PreferenciasTableAdapter preferenciasTableAdapter;
  }
}