namespace Formularios
{
    partial class FrmRegistroEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEstudiante));
            lblRegistroEstudiante = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            textDireccion = new TextBox();
            textTelefono = new TextBox();
            textEmail = new TextBox();
            btnRegistro = new Button();
            RbtnCambiarcontrasenia = new RadioButton();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblRegistroEstudiante
            // 
            lblRegistroEstudiante.AutoSize = true;
            lblRegistroEstudiante.BackColor = Color.Transparent;
            lblRegistroEstudiante.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblRegistroEstudiante.Location = new Point(713, 68);
            lblRegistroEstudiante.Margin = new Padding(4, 0, 4, 0);
            lblRegistroEstudiante.Name = "lblRegistroEstudiante";
            lblRegistroEstudiante.Size = new Size(250, 32);
            lblRegistroEstudiante.TabIndex = 0;
            lblRegistroEstudiante.Text = "Registro Estudiante";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Khaki;
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.Location = new Point(759, 135);
            textNombre.Margin = new Padding(4, 5, 4, 5);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(141, 24);
            textNombre.TabIndex = 1;
            textNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textApellido
            // 
            textApellido.BackColor = Color.Khaki;
            textApellido.BorderStyle = BorderStyle.None;
            textApellido.Location = new Point(759, 198);
            textApellido.Margin = new Padding(4, 5, 4, 5);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(141, 24);
            textApellido.TabIndex = 2;
            textApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // textDni
            // 
            textDni.BackColor = Color.Khaki;
            textDni.BorderStyle = BorderStyle.None;
            textDni.Location = new Point(759, 257);
            textDni.Margin = new Padding(4, 5, 4, 5);
            textDni.Name = "textDni";
            textDni.PlaceholderText = "DNI";
            textDni.Size = new Size(141, 24);
            textDni.TabIndex = 3;
            textDni.TextAlign = HorizontalAlignment.Center;
            // 
            // textDireccion
            // 
            textDireccion.BackColor = Color.Khaki;
            textDireccion.BorderStyle = BorderStyle.None;
            textDireccion.Location = new Point(759, 317);
            textDireccion.Margin = new Padding(4, 5, 4, 5);
            textDireccion.Name = "textDireccion";
            textDireccion.PlaceholderText = "Direccion";
            textDireccion.Size = new Size(141, 24);
            textDireccion.TabIndex = 4;
            textDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // textTelefono
            // 
            textTelefono.BackColor = Color.Khaki;
            textTelefono.BorderStyle = BorderStyle.None;
            textTelefono.Location = new Point(759, 372);
            textTelefono.Margin = new Padding(4, 5, 4, 5);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(141, 24);
            textTelefono.TabIndex = 5;
            textTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.Khaki;
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Location = new Point(759, 426);
            textEmail.Margin = new Padding(4, 5, 4, 5);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(141, 24);
            textEmail.TabIndex = 6;
            textEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.Gold;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Location = new Point(885, 549);
            btnRegistro.Margin = new Padding(4, 5, 4, 5);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(107, 38);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += BtnRegistro_Click;
            // 
            // RbtnCambiarcontrasenia
            // 
            RbtnCambiarcontrasenia.AutoSize = true;
            RbtnCambiarcontrasenia.BackColor = Color.Gold;
            RbtnCambiarcontrasenia.Location = new Point(738, 483);
            RbtnCambiarcontrasenia.Margin = new Padding(4, 5, 4, 5);
            RbtnCambiarcontrasenia.Name = "RbtnCambiarcontrasenia";
            RbtnCambiarcontrasenia.Size = new Size(180, 29);
            RbtnCambiarcontrasenia.TabIndex = 9;
            RbtnCambiarcontrasenia.TabStop = true;
            RbtnCambiarcontrasenia.Text = "Cambiar Contraña";
            RbtnCambiarcontrasenia.UseVisualStyleBackColor = false;
            RbtnCambiarcontrasenia.CheckedChanged += RbtnCambiarcontrasenia_CheckedChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(671, 549);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 38);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnVolver);
            Controls.Add(RbtnCambiarcontrasenia);
            Controls.Add(btnRegistro);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(textDireccion);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(lblRegistroEstudiante);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmRegistroEstudiante";
            Text = "FrmRegistroEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroEstudiante;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDni;
        private TextBox textDireccion;
        private TextBox textTelefono;
        private TextBox textEmail;
        private Button btnRegistro;
        private RadioButton RbtnCambiarcontrasenia;
        private Button btnVolver;
    }
}