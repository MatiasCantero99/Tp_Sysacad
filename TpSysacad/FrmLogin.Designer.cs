namespace Formularios
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            BtnLogin = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAutompletar = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnAutEstudiante = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(227, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(655, 54);
            label1.TabIndex = 0;
            label1.Text = "Universidad Tecnológica Nacional";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(336, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 32);
            label2.TabIndex = 1;
            label2.Text = "Sistema Académico SYSACAD";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(153, 0, 255);
            BtnLogin.BackgroundImage = (Image)resources.GetObject("BtnLogin.BackgroundImage");
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.ForeColor = Color.Transparent;
            BtnLogin.Location = new Point(470, 476);
            BtnLogin.Margin = new Padding(4, 5, 4, 5);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(107, 32);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(153, 0, 255);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(470, 241);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(114, 24);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(153, 0, 255);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Location = new Point(470, 330);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(114, 24);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAutompletar
            // 
            btnAutompletar.BackColor = Color.BurlyWood;
            btnAutompletar.FlatAppearance.BorderSize = 0;
            btnAutompletar.FlatStyle = FlatStyle.Flat;
            btnAutompletar.ForeColor = Color.Black;
            btnAutompletar.Location = new Point(770, 330);
            btnAutompletar.Name = "btnAutompletar";
            btnAutompletar.Size = new Size(131, 34);
            btnAutompletar.TabIndex = 5;
            btnAutompletar.Text = "AutAdmin";
            btnAutompletar.UseVisualStyleBackColor = false;
            btnAutompletar.Click += btnAutompletar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(749, 685);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // btnAutEstudiante
            // 
            btnAutEstudiante.BackColor = Color.MediumPurple;
            btnAutEstudiante.FlatAppearance.BorderSize = 0;
            btnAutEstudiante.FlatStyle = FlatStyle.Flat;
            btnAutEstudiante.ForeColor = Color.Black;
            btnAutEstudiante.Location = new Point(770, 370);
            btnAutEstudiante.Name = "btnAutEstudiante";
            btnAutEstudiante.Size = new Size(131, 34);
            btnAutEstudiante.TabIndex = 7;
            btnAutEstudiante.Text = "AutEstudiante";
            btnAutEstudiante.UseVisualStyleBackColor = false;
            btnAutEstudiante.Click += btnAutEstudiante_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login2;
            ClientSize = new Size(1078, 717);
            Controls.Add(btnAutEstudiante);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnAutompletar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmLogin";
            Text = "Sysacad Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnLogin;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAutompletar;
        private DateTimePicker dateTimePicker1;
        private Button btnAutEstudiante;
    }
}