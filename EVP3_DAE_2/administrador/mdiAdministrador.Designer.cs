namespace EVP3_DAE_2.administrador
{
  partial class mdiAdministrador
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.inicnioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicnioToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // inicnioToolStripMenuItem
      // 
      this.inicnioToolStripMenuItem.Name = "inicnioToolStripMenuItem";
      this.inicnioToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
      this.inicnioToolStripMenuItem.Text = "Autos";
      this.inicnioToolStripMenuItem.Click += new System.EventHandler(this.inicnioToolStripMenuItem_Click);
      // 
      // estadisticasToolStripMenuItem
      // 
      this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
      this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
      this.estadisticasToolStripMenuItem.Text = "Estadisticas";
      this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
      // 
      // mdiAdministrador
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "mdiAdministrador";
      this.Text = "mdiAdministrador";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem inicnioToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
  }
}