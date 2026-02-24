namespace TablasMultiplicarApp
{
    partial class Practica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practica));
            btnVolver = new Button();
            lblOperacion = new Label();
            txtRespuesta = new TextBox();
            btnVerificar = new Button();
            btnNueva = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Tomato;
            btnVolver.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(905, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(139, 57);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.UseWaitCursor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperacion.Location = new Point(148, 139);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(588, 73);
            lblOperacion.TabIndex = 1;
            lblOperacion.Text = "¿Cuánto es 3 × 7?";
            lblOperacion.UseWaitCursor = true;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(742, 181);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(60, 27);
            txtRespuesta.TabIndex = 2;
            txtRespuesta.UseWaitCursor = true;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(0, 192, 0);
            btnVerificar.Location = new Point(190, 256);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(131, 67);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.UseWaitCursor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnNueva
            // 
            btnNueva.BackColor = Color.Yellow;
            btnNueva.Location = new Point(345, 256);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(149, 67);
            btnNueva.TabIndex = 4;
            btnNueva.Text = "Nueva Pregunta";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.UseWaitCursor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(851, 181);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(36, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "N/A";
            lblResultado.UseWaitCursor = true;
            // 
            // Practica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1182, 553);
            Controls.Add(lblResultado);
            Controls.Add(btnNueva);
            Controls.Add(btnVerificar);
            Controls.Add(txtRespuesta);
            Controls.Add(lblOperacion);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Practica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Practica de multiplicaciones";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblOperacion;
        private TextBox txtRespuesta;
        private Button btnVerificar;
        private Button btnNueva;
        private Label lblResultado;
    }
}