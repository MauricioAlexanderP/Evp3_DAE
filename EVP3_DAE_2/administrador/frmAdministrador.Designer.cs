namespace EVP3_DAE_2
{
  partial class frmAdministrador
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
      this.dAutos = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtMarca = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.txtModelo = new System.Windows.Forms.TextBox();
      this.dtAnio = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dAutos)).BeginInit();
      this.SuspendLayout();
      // 
      // dAutos
      // 
      this.dAutos.AllowUserToAddRows = false;
      this.dAutos.AllowUserToDeleteRows = false;
      this.dAutos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
      this.dAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.marca,
            this.modelo,
            this.año});
      this.dAutos.GridColor = System.Drawing.SystemColors.Control;
      this.dAutos.Location = new System.Drawing.Point(12, 257);
      this.dAutos.Name = "dAutos";
      this.dAutos.ReadOnly = true;
      this.dAutos.RowHeadersWidth = 51;
      this.dAutos.RowTemplate.Height = 24;
      this.dAutos.Size = new System.Drawing.Size(557, 181);
      this.dAutos.TabIndex = 0;
      this.dAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dAutos_CellClick);
      // 
      // id
      // 
      this.id.DataPropertyName = "id_auto";
      this.id.HeaderText = "ID";
      this.id.MinimumWidth = 6;
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 125;
      // 
      // marca
      // 
      this.marca.DataPropertyName = "marca";
      this.marca.HeaderText = "Marca";
      this.marca.MinimumWidth = 6;
      this.marca.Name = "marca";
      this.marca.ReadOnly = true;
      this.marca.Width = 125;
      // 
      // modelo
      // 
      this.modelo.DataPropertyName = "modelo";
      this.modelo.HeaderText = "Modelo";
      this.modelo.MinimumWidth = 6;
      this.modelo.Name = "modelo";
      this.modelo.ReadOnly = true;
      this.modelo.Width = 125;
      // 
      // año
      // 
      this.año.DataPropertyName = "año";
      this.año.HeaderText = "Año";
      this.año.MinimumWidth = 6;
      this.año.Name = "año";
      this.año.ReadOnly = true;
      this.año.Width = 125;
      // 
      // txtMarca
      // 
      this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMarca.Location = new System.Drawing.Point(41, 43);
      this.txtMarca.Name = "txtMarca";
      this.txtMarca.Size = new System.Drawing.Size(269, 26);
      this.txtMarca.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(38, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Marca";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button1.ImageKey = "agregar.png";
      this.button1.ImageList = this.imageList1;
      this.button1.Location = new System.Drawing.Point(377, 31);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(164, 50);
      this.button1.TabIndex = 3;
      this.button1.Text = "Agregar Auto";
      this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "agregar.png");
      this.imageList1.Images.SetKeyName(1, "eliminar.png");
      this.imageList1.Images.SetKeyName(2, "actualizar.png");
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(38, 93);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 20);
      this.label2.TabIndex = 4;
      this.label2.Text = "Modelo";
      // 
      // txtModelo
      // 
      this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtModelo.Location = new System.Drawing.Point(41, 116);
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(269, 26);
      this.txtModelo.TabIndex = 5;
      // 
      // dtAnio
      // 
      this.dtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtAnio.Location = new System.Drawing.Point(42, 181);
      this.dtAnio.Name = "dtAnio";
      this.dtAnio.Size = new System.Drawing.Size(117, 27);
      this.dtAnio.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(38, 159);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 20);
      this.label3.TabIndex = 7;
      this.label3.Text = "Modelo";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button2.ImageKey = "eliminar.png";
      this.button2.ImageList = this.imageList1;
      this.button2.Location = new System.Drawing.Point(377, 111);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(164, 50);
      this.button2.TabIndex = 8;
      this.button2.Text = "Eliminar Auto";
      this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button3.ImageKey = "agregar.png";
      this.button3.ImageList = this.imageList1;
      this.button3.Location = new System.Drawing.Point(377, 190);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(164, 50);
      this.button3.TabIndex = 9;
      this.button3.Text = "Actualizar Auto";
      this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // frmAdministrador
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(574, 450);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dtAnio);
      this.Controls.Add(this.txtModelo);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMarca);
      this.Controls.Add(this.dAutos);
      this.Name = "frmAdministrador";
      this.Text = "mdiAdministrador";
      ((System.ComponentModel.ISupportInitialize)(this.dAutos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dAutos;
    private System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.DateTimePicker dtAnio;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn marca;
    private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
    private System.Windows.Forms.DataGridViewTextBoxColumn año;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
  }
}