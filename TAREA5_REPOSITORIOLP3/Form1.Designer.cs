﻿
namespace TAREA5_REPOSITORIOLP3
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
            this.FilatextBox1 = new System.Windows.Forms.TextBox();
            this.ColumnatextBox2 = new System.Windows.Forms.TextBox();
            this.Filalabel1 = new System.Windows.Forms.Label();
            this.Columnaslabel1 = new System.Windows.Forms.Label();
            this.Consultarbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilatextBox1
            // 
            this.FilatextBox1.Location = new System.Drawing.Point(101, 59);
            this.FilatextBox1.Name = "FilatextBox1";
            this.FilatextBox1.Size = new System.Drawing.Size(100, 20);
            this.FilatextBox1.TabIndex = 0;
            // 
            // ColumnatextBox2
            // 
            this.ColumnatextBox2.Location = new System.Drawing.Point(312, 59);
            this.ColumnatextBox2.Name = "ColumnatextBox2";
            this.ColumnatextBox2.Size = new System.Drawing.Size(100, 20);
            this.ColumnatextBox2.TabIndex = 1;
            // 
            // Filalabel1
            // 
            this.Filalabel1.AutoSize = true;
            this.Filalabel1.Location = new System.Drawing.Point(53, 66);
            this.Filalabel1.Name = "Filalabel1";
            this.Filalabel1.Size = new System.Drawing.Size(28, 13);
            this.Filalabel1.TabIndex = 2;
            this.Filalabel1.Text = "Filas";
            // 
            // Columnaslabel1
            // 
            this.Columnaslabel1.AutoSize = true;
            this.Columnaslabel1.Location = new System.Drawing.Point(253, 66);
            this.Columnaslabel1.Name = "Columnaslabel1";
            this.Columnaslabel1.Size = new System.Drawing.Size(53, 13);
            this.Columnaslabel1.TabIndex = 3;
            this.Columnaslabel1.Text = "Columnas";
            // 
            // Consultarbutton1
            // 
            this.Consultarbutton1.Location = new System.Drawing.Point(194, 122);
            this.Consultarbutton1.Name = "Consultarbutton1";
            this.Consultarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Consultarbutton1.TabIndex = 4;
            this.Consultarbutton1.Text = "Consultar";
            this.Consultarbutton1.UseVisualStyleBackColor = true;
            this.Consultarbutton1.Click += new System.EventHandler(this.Consultarbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consultarbutton1);
            this.Controls.Add(this.Columnaslabel1);
            this.Controls.Add(this.Filalabel1);
            this.Controls.Add(this.ColumnatextBox2);
            this.Controls.Add(this.FilatextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilatextBox1;
        private System.Windows.Forms.TextBox ColumnatextBox2;
        private System.Windows.Forms.Label Filalabel1;
        private System.Windows.Forms.Label Columnaslabel1;
        private System.Windows.Forms.Button Consultarbutton1;
    }
}

