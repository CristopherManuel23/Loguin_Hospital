namespace Loguin_Hospital
{
    partial class Form1
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
            txtusuario = new TextBox();
            label1 = new Label();
            txtcontrasenia = new TextBox();
            btningresar = new Button();
            btncancelar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.Black;
            txtusuario.BorderStyle = BorderStyle.None;
            txtusuario.Font = new Font("Century Gothic", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            txtusuario.ForeColor = Color.DimGray;
            txtusuario.Location = new Point(419, 123);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(243, 24);
            txtusuario.TabIndex = 1;
            txtusuario.Text = "USER";
            txtusuario.Enter += txtusuario_Enter;
            txtusuario.Leave += txtusuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(509, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 36);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // txtcontrasenia
            // 
            txtcontrasenia.BackColor = Color.Black;
            txtcontrasenia.BorderStyle = BorderStyle.None;
            txtcontrasenia.Font = new Font("Century Gothic", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            txtcontrasenia.ForeColor = Color.DimGray;
            txtcontrasenia.Location = new Point(419, 179);
            txtcontrasenia.Name = "txtcontrasenia";
            txtcontrasenia.Size = new Size(243, 24);
            txtcontrasenia.TabIndex = 2;
            txtcontrasenia.Text = "PASSWORD";
            txtcontrasenia.TextChanged += txtcontrasenia_TextChanged;
            txtcontrasenia.Enter += txtcontrasenia_Enter;
            txtcontrasenia.Leave += txtcontrasenia_Leave;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.FromArgb(40, 40, 40);
            btningresar.FlatAppearance.BorderSize = 0;
            btningresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btningresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btningresar.ForeColor = Color.DarkSlateBlue;
            btningresar.Location = new Point(383, 254);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(158, 32);
            btningresar.TabIndex = 5;
            btningresar.Text = "INGRESAR";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(40, 40, 40);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btncancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.DarkSlateBlue;
            btncancelar.Location = new Point(578, 254);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(158, 32);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_hospital;
            pictureBox1.Location = new Point(-43, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 344);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(769, 344);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Controls.Add(txtcontrasenia);
            Controls.Add(label1);
            Controls.Add(txtusuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtusuario;
        private Label label1;
        private TextBox txtcontrasenia;
        private Button btningresar;
        private Button btncancelar;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
