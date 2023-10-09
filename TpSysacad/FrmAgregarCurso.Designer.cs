namespace Formularios
{
    partial class FrmAgregarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCurso));
            textNombre = new TextBox();
            textCodigo = new TextBox();
            textDescripcion = new TextBox();
            textCupoMax = new TextBox();
            BtnAgregar = new Button();
            label1 = new Label();
            cBAula = new ComboBox();
            cBHorarios = new ComboBox();
            cBDias = new ComboBox();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Khaki;
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.Location = new Point(567, 161);
            textNombre.Margin = new Padding(4);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(155, 24);
            textNombre.TabIndex = 0;
            textNombre.TextAlign = HorizontalAlignment.Center;
            textNombre.TextChanged += textBox1_TextChanged;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.Khaki;
            textCodigo.BorderStyle = BorderStyle.None;
            textCodigo.Location = new Point(567, 244);
            textCodigo.Margin = new Padding(4);
            textCodigo.Name = "textCodigo";
            textCodigo.PlaceholderText = "Código";
            textCodigo.Size = new Size(155, 24);
            textCodigo.TabIndex = 1;
            textCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // textDescripcion
            // 
            textDescripcion.BackColor = Color.Khaki;
            textDescripcion.BorderStyle = BorderStyle.None;
            textDescripcion.Location = new Point(567, 322);
            textDescripcion.Margin = new Padding(4);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.PlaceholderText = "Descripción";
            textDescripcion.Size = new Size(155, 24);
            textDescripcion.TabIndex = 2;
            textDescripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // textCupoMax
            // 
            textCupoMax.BackColor = Color.Khaki;
            textCupoMax.BorderStyle = BorderStyle.None;
            textCupoMax.ForeColor = SystemColors.WindowText;
            textCupoMax.Location = new Point(567, 399);
            textCupoMax.Margin = new Padding(4);
            textCupoMax.Name = "textCupoMax";
            textCupoMax.PlaceholderText = "Cupo Máximo";
            textCupoMax.Size = new Size(155, 24);
            textCupoMax.TabIndex = 3;
            textCupoMax.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Khaki;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Location = new Point(751, 508);
            BtnAgregar.Margin = new Padding(4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(118, 36);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(732, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 5;
            label1.Text = "Nuevo Curso";
            // 
            // cBAula
            // 
            cBAula.BackColor = Color.Gold;
            cBAula.FlatStyle = FlatStyle.Flat;
            cBAula.FormattingEnabled = true;
            cBAula.Location = new Point(842, 173);
            cBAula.Name = "cBAula";
            cBAula.Size = new Size(182, 33);
            cBAula.TabIndex = 6;
            cBAula.Text = "Aula";
            cBAula.KeyPress += cBAula_KeyPress;
            // 
            // cBHorarios
            // 
            cBHorarios.BackColor = Color.Gold;
            cBHorarios.FlatStyle = FlatStyle.Flat;
            cBHorarios.FormattingEnabled = true;
            cBHorarios.Location = new Point(842, 255);
            cBHorarios.Name = "cBHorarios";
            cBHorarios.Size = new Size(182, 33);
            cBHorarios.TabIndex = 7;
            cBHorarios.Text = "Horarios";
            cBHorarios.KeyPress += cBHorarios_KeyPress;
            // 
            // cBDias
            // 
            cBDias.BackColor = Color.Gold;
            cBDias.FlatStyle = FlatStyle.Flat;
            cBDias.FormattingEnabled = true;
            cBDias.Location = new Point(842, 349);
            cBDias.Name = "cBDias";
            cBDias.Size = new Size(182, 33);
            cBDias.TabIndex = 8;
            cBDias.Text = "Dias";
            cBDias.KeyPress += cBDias_KeyPress;
            // 
            // FrmAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(cBDias);
            Controls.Add(cBHorarios);
            Controls.Add(cBAula);
            Controls.Add(label1);
            Controls.Add(BtnAgregar);
            Controls.Add(textCupoMax);
            Controls.Add(textDescripcion);
            Controls.Add(textCodigo);
            Controls.Add(textNombre);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmAgregarCurso";
            Text = "FrmAgregarCurso";
            Load += FrmAgregarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private TextBox textCodigo;
        private TextBox textDescripcion;
        private TextBox textCupoMax;
        private Button BtnAgregar;
        private Label label1;
        private ComboBox cBAula;
        private ComboBox cBHorarios;
        private ComboBox cBDias;
    }
}