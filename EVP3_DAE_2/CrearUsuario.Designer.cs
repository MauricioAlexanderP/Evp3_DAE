namespace EVP3_DAE_2
{
  partial class CrearUsuario
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btn_Registar_Usuario = new System.Windows.Forms.Button();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.txtClave = new System.Windows.Forms.TextBox();
      this.txtemail = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtApellido = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
      this.panel1.Controls.Add(this.groupBox2);
      this.panel1.Controls.Add(this.groupBox1);
      this.panel1.Location = new System.Drawing.Point(7, 1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(786, 569);
      this.panel1.TabIndex = 6;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.btn_Registar_Usuario);
      this.groupBox2.Controls.Add(this.pictureBox3);
      this.groupBox2.Controls.Add(this.pictureBox2);
      this.groupBox2.Controls.Add(this.txtClave);
      this.groupBox2.Controls.Add(this.txtemail);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.ForeColor = System.Drawing.Color.Aqua;
      this.groupBox2.Location = new System.Drawing.Point(48, 275);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(682, 261);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Informacion de la cuenta";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(55, 109);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 20);
      this.label4.TabIndex = 13;
      this.label4.Text = "Clave";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(55, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 20);
      this.label3.TabIndex = 12;
      this.label3.Text = "Email";
      // 
      // btn_Registar_Usuario
      // 
      this.btn_Registar_Usuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.btn_Registar_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_Registar_Usuario.ForeColor = System.Drawing.Color.Transparent;
      this.btn_Registar_Usuario.Location = new System.Drawing.Point(394, 189);
      this.btn_Registar_Usuario.Name = "btn_Registar_Usuario";
      this.btn_Registar_Usuario.Size = new System.Drawing.Size(235, 48);
      this.btn_Registar_Usuario.TabIndex = 11;
      this.btn_Registar_Usuario.Text = "Registrar nuevo Usuario";
      this.btn_Registar_Usuario.UseVisualStyleBackColor = false;
      this.btn_Registar_Usuario.Click += new System.EventHandler(this.btn_Registar_Usuario_Click);
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(14, 132);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(35, 37);
      this.pictureBox3.TabIndex = 8;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(14, 64);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(35, 37);
      this.pictureBox2.TabIndex = 7;
      this.pictureBox2.TabStop = false;
      // 
      // txtClave
      // 
      this.txtClave.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.txtClave.Location = new System.Drawing.Point(55, 132);
      this.txtClave.Name = "txtClave";
      this.txtClave.Size = new System.Drawing.Size(574, 27);
      this.txtClave.TabIndex = 6;
      // 
      // txtemail
      // 
      this.txtemail.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.txtemail.Location = new System.Drawing.Point(55, 64);
      this.txtemail.Name = "txtemail";
      this.txtemail.Size = new System.Drawing.Size(574, 27);
      this.txtemail.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtApellido);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtNombre);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
      this.groupBox1.Location = new System.Drawing.Point(48, 32);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(682, 220);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Informacion personal";
      // 
      // txtApellido
      // 
      this.txtApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.txtApellido.Location = new System.Drawing.Point(55, 168);
      this.txtApellido.Name = "txtApellido";
      this.txtApellido.Size = new System.Drawing.Size(574, 28);
      this.txtApellido.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(50, 131);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "Apellido";
      // 
      // txtNombre
      // 
      this.txtNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.txtNombre.Location = new System.Drawing.Point(55, 75);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(574, 28);
      this.txtNombre.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(50, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre";
      // 
      // CrearUsuario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 572);
      this.Controls.Add(this.panel1);
      this.Name = "CrearUsuario";
      this.Text = "From2";
      this.panel1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btn_Registar_Usuario;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.TextBox txtClave;
    private System.Windows.Forms.TextBox txtemail;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtApellido;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
  }
}