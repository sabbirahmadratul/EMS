﻿namespace EMS
{
  partial class Splash
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
      this.label1 = new System.Windows.Forms.Label();
      this.myProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
      this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
      this.myProgressBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.OrangeRed;
      this.label1.Location = new System.Drawing.Point(80, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(387, 26);
      this.label1.TabIndex = 0;
      this.label1.Text = "EMPLOYEE MANAGEMENT SYSTEM";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // myProgressBar
      // 
      this.myProgressBar.Controls.Add(this.guna2CirclePictureBox1);
      this.myProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
      this.myProgressBar.FillThickness = 10;
      this.myProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.myProgressBar.ForeColor = System.Drawing.Color.White;
      this.myProgressBar.Location = new System.Drawing.Point(177, 57);
      this.myProgressBar.MaximumSize = new System.Drawing.Size(167, 160);
      this.myProgressBar.Minimum = 0;
      this.myProgressBar.MinimumSize = new System.Drawing.Size(167, 160);
      this.myProgressBar.Name = "myProgressBar";
      this.myProgressBar.ProgressThickness = 10;
      this.myProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
      this.myProgressBar.Size = new System.Drawing.Size(167, 160);
      this.myProgressBar.TabIndex = 1;
      this.myProgressBar.Text = "guna2CircleProgressBar1";
      // 
      // guna2CirclePictureBox1
      // 
      this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
      this.guna2CirclePictureBox1.ImageRotate = 0F;
      this.guna2CirclePictureBox1.Location = new System.Drawing.Point(39, 30);
      this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
      this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
      this.guna2CirclePictureBox1.Size = new System.Drawing.Size(88, 93);
      this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.guna2CirclePictureBox1.TabIndex = 0;
      this.guna2CirclePictureBox1.TabStop = false;
      // 
      // Splash
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(523, 251);
      this.Controls.Add(this.myProgressBar);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(523, 251);
      this.MinimumSize = new System.Drawing.Size(523, 251);
      this.Name = "Splash";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form";
      this.myProgressBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private Guna.UI2.WinForms.Guna2CircleProgressBar myProgressBar;
    private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
  }
}

