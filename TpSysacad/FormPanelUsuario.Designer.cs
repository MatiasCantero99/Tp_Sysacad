namespace Formularios
{
    partial class FormPanelUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelUsuario));
            btnRegistrarEstudiante = new Button();
            btnGestionarCursos = new Button();
            lblTitulo = new Label();
            btnInscripcionCurso = new Button();
            btnConsultarHorario = new Button();
            btnRealizarPagos = new Button();
            btnSalir = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.BackColor = Color.BurlyWood;
            btnRegistrarEstudiante.FlatAppearance.BorderSize = 0;
            btnRegistrarEstudiante.FlatStyle = FlatStyle.Flat;
            btnRegistrarEstudiante.Location = new Point(444, 273);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(186, 33);
            btnRegistrarEstudiante.TabIndex = 0;
            btnRegistrarEstudiante.Text = "Registrar Estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = false;
            btnRegistrarEstudiante.Click += button1_Click;
            // 
            // btnGestionarCursos
            // 
            btnGestionarCursos.BackColor = Color.BurlyWood;
            btnGestionarCursos.FlatAppearance.BorderSize = 0;
            btnGestionarCursos.FlatStyle = FlatStyle.Flat;
            btnGestionarCursos.Location = new Point(444, 340);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(186, 33);
            btnGestionarCursos.TabIndex = 1;
            btnGestionarCursos.Text = "Gestionar Curso";
            btnGestionarCursos.UseVisualStyleBackColor = false;
            btnGestionarCursos.Click += BtnGestionarCursos_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(393, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(82, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Panel";
            // 
            // btnInscripcionCurso
            // 
            btnInscripcionCurso.BackColor = Color.MediumPurple;
            btnInscripcionCurso.FlatAppearance.BorderSize = 0;
            btnInscripcionCurso.FlatStyle = FlatStyle.Flat;
            btnInscripcionCurso.ForeColor = Color.Black;
            btnInscripcionCurso.Location = new Point(444, 273);
            btnInscripcionCurso.Name = "btnInscripcionCurso";
            btnInscripcionCurso.Size = new Size(186, 33);
            btnInscripcionCurso.TabIndex = 3;
            btnInscripcionCurso.Text = "Inscripcion a cursos";
            btnInscripcionCurso.UseVisualStyleBackColor = false;
            btnInscripcionCurso.Click += button2_Click;
            // 
            // btnConsultarHorario
            // 
            btnConsultarHorario.BackColor = Color.MediumPurple;
            btnConsultarHorario.FlatAppearance.BorderSize = 0;
            btnConsultarHorario.FlatStyle = FlatStyle.Flat;
            btnConsultarHorario.Location = new Point(444, 340);
            btnConsultarHorario.Name = "btnConsultarHorario";
            btnConsultarHorario.Size = new Size(186, 33);
            btnConsultarHorario.TabIndex = 4;
            btnConsultarHorario.Text = "Consultar Horario";
            btnConsultarHorario.UseVisualStyleBackColor = false;
            btnConsultarHorario.Click += button3_Click;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.BackColor = Color.MediumPurple;
            btnRealizarPagos.FlatAppearance.BorderSize = 0;
            btnRealizarPagos.FlatStyle = FlatStyle.Flat;
            btnRealizarPagos.Location = new Point(444, 399);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Size = new Size(186, 33);
            btnRealizarPagos.TabIndex = 5;
            btnRealizarPagos.Text = "Realizar Pagos";
            btnRealizarPagos.UseVisualStyleBackColor = false;
            btnRealizarPagos.Click += button4_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(444, 490);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(186, 33);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(689, 156);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(748, 686);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(330, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // FormPanelUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnRealizarPagos);
            Controls.Add(btnConsultarHorario);
            Controls.Add(btnInscripcionCurso);
            Controls.Add(lblTitulo);
            Controls.Add(btnGestionarCursos);
            Controls.Add(btnRegistrarEstudiante);
            MaximizeBox = false;
            Name = "FormPanelUsuario";
            Text = "PanelUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEstudiante;
        private Button btnGestionarCursos;
        private Label label1;
        private Label lblTitulo;
        private Button btnInscripcionCurso;
        private Button btnConsultarHorario;
        private Button btnRealizarPagos;
        private Button btnSalir;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}