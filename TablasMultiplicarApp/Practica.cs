using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TablasMultiplicarApp
{
    public partial class Practica : Form
    {
        private readonly Random _rnd = new Random();
        private int _a; // primer número
        private int _b; // segundo número
        private System.Windows.Forms.Timer _timer;
        public Practica()
        {
            InitializeComponent();



            // Opcional: permitir Enter para verificar
            this.Shown += Practica_Shown;
            this.AcceptButton = btnVerificar;
        }
        private void Practica_Shown(object sender, EventArgs e)
        {
            GenerarNuevaOperacion(); // random al entrar
        }

        private void GenerarNuevaOperacion()
        {
            _a = _rnd.Next(1, 11); // 1..10
            _b = _rnd.Next(1, 11); // 1..10

            lblOperacion.Text = $"¿Cuánto es {_a} × {_b}?";
            txtRespuesta.Clear();
            lblResultado.Text = "";
            txtRespuesta.Focus();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            GenerarNuevaOperacion(); // random al dar click en Nueva
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRespuesta.Text.Trim(), out int user))
            {
                lblResultado.Text = "Escribe un número válido.";
                txtRespuesta.Focus();
                txtRespuesta.SelectAll();
                return;
            }

            int correcta = _a * _b;

            if (user == correcta)
            {
                lblResultado.Text = "✅ ¡Correcto!";
                
                _timer = new System.Windows.Forms.Timer();
                _timer.Interval = 900;
                _timer.Tick += Timer_Tick;  
                _timer.Start();            
            }
            else
            {
                lblResultado.Text = $"❌ Incorrecto. La respuesta era {correcta}.";
                txtRespuesta.Focus();
                txtRespuesta.SelectAll();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
            GenerarNuevaOperacion();
        }


        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
