namespace EVP3_DAE_2
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.lblCrearCuenta = new System.Windows.Forms.Label();
      this.txtClave = new System.Windows.Forms.TextBox();
      this.txtUser = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblCrearCuenta
      // 
      this.lblCrearCuenta.AutoSize = true;
      this.lblCrearCuenta.BackColor = System.Drawing.SystemColors.Control;
      this.lblCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lblCrearCuenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCrearCuenta.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblCrearCuenta.Location = new System.Drawing.Point(458, 496);
      this.lblCrearCuenta.Name = "lblCrearCuenta";
      this.lblCrearCuenta.Size = new System.Drawing.Size(113, 23);
      this.lblCrearCuenta.TabIndex = 17;
      this.lblCrearCuenta.Text = "Crear Cuenta";
      this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click_1);
      // 
      // txtClave
      // 
      this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtClave.Location = new System.Drawing.Point(196, 314);
      this.txtClave.Multiline = true;
      this.txtClave.Name = "txtClave";
      this.txtClave.PasswordChar = '*';
      this.txtClave.Size = new System.Drawing.Size(375, 47);
      this.txtClave.TabIndex = 16;
      this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtUser
      // 
      this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUser.Location = new System.Drawing.Point(196, 238);
      this.txtUser.Multiline = true;
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(375, 47);
      this.txtUser.TabIndex = 15;
      this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(108)))), ((int)(((byte)(116)))));
      this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnLogin.FlatAppearance.BorderSize = 0;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(131, 407);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(440, 45);
      this.btnLogin.TabIndex = 14;
      this.btnLogin.Text = "LOGIN";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(1, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(686, 641);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 13;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(686, 643);
      this.Controls.Add(this.lblCrearCuenta);
      this.Controls.Add(this.txtClave);
      this.Controls.Add(this.txtUser);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblCrearCuenta;
    private System.Windows.Forms.TextBox txtClave;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

