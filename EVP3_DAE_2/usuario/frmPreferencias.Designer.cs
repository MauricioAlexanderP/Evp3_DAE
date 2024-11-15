namespace EVP3_DAE_2
{
  partial class frmPreferencias
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferencias));
      this.dPrefernciasAutos = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnAgregar = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.txtBuscar = new System.Windows.Forms.TextBox();
      this.btnAgregaFavoritos = new System.Windows.Forms.Button();
      this.dAutos = new System.Windows.Forms.DataGridView();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dPrefernciasAutos)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dAutos)).BeginInit();
      this.SuspendLayout();
      // 
      // dPrefernciasAutos
      // 
      this.dPrefernciasAutos.AllowUserToAddRows = false;
      this.dPrefernciasAutos.AllowUserToDeleteRows = false;
      this.dPrefernciasAutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      this.dPrefernciasAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dPrefernciasAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dPrefernciasAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
      this.dPrefernciasAutos.GridColor = System.Drawing.SystemColors.ButtonFace;
      this.dPrefernciasAutos.Location = new System.Drawing.Point(9, 47);
      this.dPrefernciasAutos.Name = "dPrefernciasAutos";
      this.dPrefernciasAutos.ReadOnly = true;
      this.dPrefernciasAutos.RowHeadersWidth = 51;
      this.dPrefernciasAutos.RowTemplate.Height = 24;
      this.dPrefernciasAutos.Size = new System.Drawing.Size(555, 364);
      this.dPrefernciasAutos.TabIndex = 2;
      this.dPrefernciasAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dPrefernciasAutos_CellClick);
      // 
      // Column1
      // 
      this.Column1.DataPropertyName = " id_preferencia";
      this.Column1.HeaderText = "ID";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 50;
      // 
      // Column2
      // 
      this.Column2.DataPropertyName = "marca";
      this.Column2.HeaderText = "Marca";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 150;
      // 
      // Column3
      // 
      this.Column3.DataPropertyName = "modelo";
      this.Column3.HeaderText = "Modelo";
      this.Column3.MinimumWidth = 6;
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 150;
      // 
      // Column4
      // 
      this.Column4.DataPropertyName = "año";
      this.Column4.HeaderText = "Año";
      this.Column4.MinimumWidth = 6;
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 150;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(9, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 23);
      this.label1.TabIndex = 3;
      this.label1.Text = "Mis Favoritos";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(-1, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(691, 450);
      this.tabControl1.TabIndex = 4;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.tabPage1.Controls.Add(this.btnEliminar);
      this.tabPage1.Controls.Add(this.btnAgregar);
      this.tabPage1.Controls.Add(this.dPrefernciasAutos);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(683, 421);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Favoritos";
      // 
      // btnEliminar
      // 
      this.btnEliminar.ImageKey = "eliminar.png";
      this.btnEliminar.ImageList = this.imageList1;
      this.btnEliminar.Location = new System.Drawing.Point(579, 57);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 76);
      this.btnEliminar.TabIndex = 5;
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "agregar.png");
      this.imageList1.Images.SetKeyName(1, "eliminar.png");
      // 
      // btnAgregar
      // 
      this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.btnAgregar.ImageKey = "agregar.png";
      this.btnAgregar.ImageList = this.imageList1;
      this.btnAgregar.Location = new System.Drawing.Point(579, 171);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(84, 76);
      this.btnAgregar.TabIndex = 4;
      this.btnAgregar.UseVisualStyleBackColor = false;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.txtBuscar);
      this.tabPage2.Controls.Add(this.btnAgregaFavoritos);
      this.tabPage2.Controls.Add(this.dAutos);
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(683, 421);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Autos";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(20, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 24);
      this.label2.TabIndex = 7;
      this.label2.Text = "Marca";
      // 
      // txtBuscar
      // 
      this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBuscar.Location = new System.Drawing.Point(24, 41);
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new System.Drawing.Size(557, 30);
      this.txtBuscar.TabIndex = 6;
      this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
      // 
      // btnAgregaFavoritos
      // 
      this.btnAgregaFavoritos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.btnAgregaFavoritos.ImageKey = "agregar.png";
      this.btnAgregaFavoritos.ImageList = this.imageList1;
      this.btnAgregaFavoritos.Location = new System.Drawing.Point(587, 95);
      this.btnAgregaFavoritos.Name = "btnAgregaFavoritos";
      this.btnAgregaFavoritos.Size = new System.Drawing.Size(84, 76);
      this.btnAgregaFavoritos.TabIndex = 5;
      this.toolTip1.SetToolTip(this.btnAgregaFavoritos, "Agregar a favoritos");
      this.btnAgregaFavoritos.UseVisualStyleBackColor = false;
      this.btnAgregaFavoritos.Click += new System.EventHandler(this.btnAgregaFavoritos_Click);
      // 
      // dAutos
      // 
      this.dAutos.AllowUserToAddRows = false;
      this.dAutos.AllowUserToDeleteRows = false;
      this.dAutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      this.dAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.marca,
            this.modelo,
            this.año});
      this.dAutos.GridColor = System.Drawing.SystemColors.ButtonFace;
      this.dAutos.Location = new System.Drawing.Point(24, 95);
      this.dAutos.Name = "dAutos";
      this.dAutos.ReadOnly = true;
      this.dAutos.RowHeadersWidth = 51;
      this.dAutos.RowTemplate.Height = 24;
      this.dAutos.Size = new System.Drawing.Size(557, 300);
      this.dAutos.TabIndex = 3;
      this.dAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dAutos_CellClick);
      // 
      // id
      // 
      this.id.DataPropertyName = "id_auto";
      this.id.HeaderText = "ID";
      this.id.MinimumWidth = 6;
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 50;
      // 
      // marca
      // 
      this.marca.DataPropertyName = "marca";
      this.marca.HeaderText = "Marca";
      this.marca.MinimumWidth = 6;
      this.marca.Name = "marca";
      this.marca.ReadOnly = true;
      this.marca.Width = 150;
      // 
      // modelo
      // 
      this.modelo.DataPropertyName = "modelo";
      this.modelo.HeaderText = "Modelo";
      this.modelo.MinimumWidth = 6;
      this.modelo.Name = "modelo";
      this.modelo.ReadOnly = true;
      this.modelo.Width = 150;
      // 
      // año
      // 
      this.año.DataPropertyName = "año";
      this.año.HeaderText = "Año";
      this.año.MinimumWidth = 6;
      this.año.Name = "año";
      this.año.ReadOnly = true;
      this.año.Width = 120;
      // 
      // frmPreferencias
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(697, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "frmPreferencias";
      this.Text = "frmPreferencias";
      this.Load += new System.EventHandler(this.frmPreferencias_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dPrefernciasAutos)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dAutos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView dPrefernciasAutos;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.DataGridView dAutos;
    private System.Windows.Forms.Button btnAgregaFavoritos;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtBuscar;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn marca;
    private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
    private System.Windows.Forms.DataGridViewTextBoxColumn año;
  }
}