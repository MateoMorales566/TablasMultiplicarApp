namespace TablasMultiplicarApp
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            botonLista = new Button();
            botonPractica = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 48);
            label1.Name = "label1";
            label1.Size = new Size(494, 48);
            label1.TabIndex = 1;
            label1.Text = "Tablas de multiplicar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // botonLista
            // 
            botonLista.BackColor = Color.FromArgb(0, 192, 0);
            botonLista.Location = new Point(133, 184);
            botonLista.Name = "botonLista";
            botonLista.Size = new Size(411, 54);
            botonLista.TabIndex = 3;
            botonLista.Text = "Lista completa de multiplicaciones";
            botonLista.UseVisualStyleBackColor = false;
            botonLista.Click += botonLista_Click;
            // 
            // botonPractica
            // 
            botonPractica.BackColor = Color.FromArgb(0, 192, 0);
            botonPractica.Location = new Point(133, 264);
            botonPractica.Name = "botonPractica";
            botonPractica.Size = new Size(411, 56);
            botonPractica.TabIndex = 4;
            botonPractica.Text = "Practica de multiplicaciones";
            botonPractica.UseVisualStyleBackColor = false;
            botonPractica.Click += botonPractica_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Tomato;
            btnSalir.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(943, 497);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 44);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button3_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1182, 553);
            Controls.Add(btnSalir);
            Controls.Add(botonPractica);
            Controls.Add(botonLista);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuCalculadora";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button botonLista;
        private Button botonPractica;
        private Button btnSalir;
    }
}
