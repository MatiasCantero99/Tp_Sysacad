﻿namespace Formularios
{
    partial class FrmEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCurso));
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxCupoMax = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(460, 216);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 0;
            label1.Text = "Editar Curso";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.Khaki;
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Location = new Point(470, 301);
            textBoxNombre.Margin = new Padding(4, 5, 4, 5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(141, 24);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Text = "Nombre";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BackColor = Color.Khaki;
            textBoxCodigo.BorderStyle = BorderStyle.None;
            textBoxCodigo.Location = new Point(470, 360);
            textBoxCodigo.Margin = new Padding(4, 5, 4, 5);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(141, 24);
            textBoxCodigo.TabIndex = 2;
            textBoxCodigo.Text = "Codigo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BackColor = Color.Khaki;
            textBoxDescripcion.BorderStyle = BorderStyle.None;
            textBoxDescripcion.Location = new Point(470, 426);
            textBoxDescripcion.Margin = new Padding(4, 5, 4, 5);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(141, 24);
            textBoxDescripcion.TabIndex = 3;
            textBoxDescripcion.Text = "Descripcion";
            // 
            // textBoxCupoMax
            // 
            textBoxCupoMax.BackColor = Color.Khaki;
            textBoxCupoMax.BorderStyle = BorderStyle.None;
            textBoxCupoMax.Location = new Point(470, 488);
            textBoxCupoMax.Margin = new Padding(4, 5, 4, 5);
            textBoxCupoMax.Name = "textBoxCupoMax";
            textBoxCupoMax.Size = new Size(141, 24);
            textBoxCupoMax.TabIndex = 4;
            textBoxCupoMax.Text = "Cupo Maximo";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Gold;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(483, 565);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 38);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmEditarCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnAceptar);
            Controls.Add(textBoxCupoMax);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEditarCurso";
            Text = "FrmEditarCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxCodigo;
        private TextBox textBoxDescripcion;
        private TextBox textBoxCupoMax;
        private Button btnAceptar;
    }
}