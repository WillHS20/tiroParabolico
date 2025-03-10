using System; // Espacio de nombres principal para funcionalidades básicas.
using System.Windows.Forms; // Espacio de nombres para la creación de formularios Windows Forms.

namespace Tiro_parabolico
{
    public partial class Form1 : Form
    {
        clsFormulas Operaciones; // Instancia de la clase encargada de realizar las fórmulas de tiro parabólico.

        // Constructor del formulario, se inicializan componentes y la clase `clsFormulas`.
        public Form1()
        {
            InitializeComponent();
            Operaciones = new clsFormulas();
        }

        // Variables globales para almacenar velocidad inicial, ángulo y tiempo.
        double vi = 0; // Velocidad inicial.
        double a = 0;  // Ángulo del disparo.
        double t = 0;  // Tiempo.

        // Evento del botón 1: Calcula la velocidad en el eje X.
        private void button1_Click(object sender, EventArgs e)
        {
            // Validación básica para verificar si los campos necesarios están llenos.
            if (txtVelocidad.Text == "" || txtAngulo.Text == "")
            {
                lblRespuesta.Text = "Por favor, introduce valores numéricos."; // Mensaje de error.
            }
            else
            {
                // Conversión de las entradas a valores numéricos.
                vi = Convert.ToDouble(txtVelocidad.Text);
                if (vi <= 0 || a < 0 || a > 90)
                {
                    lblRespuesta.Text = "Valores no válidos: revisa la velocidad y el ángulo.";
                    return;
                }

                a = Convert.ToDouble(txtAngulo.Text);
                a = a * (Math.PI / 180); // Convierte de grados a radianes.

                // Llamada al método para calcular la velocidad en X.
                Operaciones.velocidadX(vi, a);

                // Muestra el resultado en el label.
                lblRespuesta.Text = Convert.ToString(Operaciones.getVx()) + " m/s";
            }
        }

        // Evento del botón 2: Calcula la velocidad en el eje Y.
        private void button2_Click(object sender, EventArgs e)
        {
            // Validación para asegurarse de que los campos necesarios tienen valores.
            if (txtTiempo.Text == "" || txtAngulo.Text == "" || txtVelocidad.Text == "")
            {
                lblRespuesta.Text = "Por favor, introduce valores numéricos."; // Mensaje de error.
            }
            else
            {
                // Conversión de entradas a valores numéricos.
                vi = Convert.ToDouble(txtVelocidad.Text);
                if (vi <= 0 || a < 0 || a > 90)
                {
                    lblRespuesta.Text = "Valores no válidos: revisa la velocidad y el ángulo.";
                    return;
                }

                a = Convert.ToDouble(txtAngulo.Text);
                a = a * (Math.PI / 180); // Convierte de grados a radianes.
                t = Convert.ToDouble(txtTiempo.Text);

                // Llamada al método para calcular la velocidad en Y.
                Operaciones.velocidadY(vi, a, t);

                // Muestra el resultado en el label.
                lblRespuesta.Text = Convert.ToString(Operaciones.getVy()) + " m/s";
            }
        }

        // Evento del botón 3: Calcula la posición horizontal X.
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtTiempo.Text == "" || txtAngulo.Text == "" || txtVelocidad.Text == "")
            {
                lblRespuesta.Text = "Por favor, introduce valores numéricos.";
            }
            else
            {
                // Conversión de entradas a valores numéricos.
                vi = Convert.ToDouble(txtVelocidad.Text);
                if (vi <= 0 || a < 0 || a > 90)
                {
                    lblRespuesta.Text = "Valores no válidos: revisa la velocidad y el ángulo.";
                    return;
                }

                a = Convert.ToDouble(txtAngulo.Text);
                a = a * (Math.PI / 180); // Convierte de grados a radianes.
                t = Convert.ToDouble(txtTiempo.Text);

                // Llamada al método para calcular la posición horizontal.
                Operaciones.calcX(vi, a, t);

                // Muestra el resultado en el label.
                lblRespuesta.Text = Convert.ToString(Operaciones.getX()) + " m";
            }
        }

        // Evento del botón 4: Calcula la altura máxima (H).
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtVelocidad.Text == "" || txtAngulo.Text == "")
            {
                lblRespuesta.Text = "Por favor, introduce valores numéricos.";
            }
            else
            {
                vi = Convert.ToDouble(txtVelocidad.Text);
                if (vi <= 0 || a < 0 || a > 90)
                {
                    lblRespuesta.Text = "Valores no válidos: revisa la velocidad y el ángulo.";
                    return;
                }

                a = Convert.ToDouble(txtAngulo.Text);
                a = a * (Math.PI / 180); // Convierte de grados a radianes.

                // Llamada al método para calcular la altura máxima.
                Operaciones.calcH(vi, a);

                // Muestra el resultado en el label.
                lblRespuesta.Text = Convert.ToString(Operaciones.getH()) + " m de altura";
            }
        }

        // Evento del botón 5: Calcula la distancia máxima horizontal (L).
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtVelocidad.Text == "" || txtAngulo.Text == "")
            {
                lblRespuesta.Text = "Por favor, introduce valores numéricos.";
            }
            else
            {
                vi = Convert.ToDouble(txtVelocidad.Text);
                if (vi <= 0 || a < 0 || a > 90)
                {
                    lblRespuesta.Text = "Valores no válidos: revisa la velocidad y el ángulo.";
                    return;
                }

                a = Convert.ToDouble(txtAngulo.Text);
                a = a * (Math.PI / 180); // Convierte de grados a radianes.

                // Llamada al método para calcular la longitud máxima.
                Operaciones.calcL(vi, a);

                // Muestra el resultado en el label.
                lblRespuesta.Text = Convert.ToString(Operaciones.getL()) + " m de longitud";
            }
        }
    }
}
