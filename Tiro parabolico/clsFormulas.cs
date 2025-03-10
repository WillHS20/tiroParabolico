using System; // Espacio de nombres principal para funciones básicas.

namespace Tiro_parabolico
{
    // Clase que contiene las fórmulas del tiro parabólico.
    class clsFormulas
    {
        const double g = 9.81; // Constante de gravedad (m/s²).

        // Variables para almacenar resultados y datos temporales.
        double t;  // Tiempo.
        double Vx; // Velocidad horizontal.
        double Vy; // Velocidad vertical.
        double X;  // Posición horizontal.
        double H;  // Altura máxima.
        double L;  // Longitud máxima.

        // Constructor: inicializa las variables con valores por defecto.
        public clsFormulas()
        {
            Vx = 0;
            Vy = 0;
            X = 0;
            H = 0;
            L = 0;
        }

        // Método para establecer el tiempo (setter opcional).
        public void setT(double _t)
        {
            t = _t;
        }

        // Método para calcular la velocidad horizontal.
        public void velocidadX(double vi, double a)
        {
            Vx = vi * Math.Cos(a); // Vx = vi * cos(a).
        }

        // Método para calcular la velocidad vertical en un tiempo dado.
        public void velocidadY(double vi, double a, double t)
        {
            Vy = vi * Math.Sin(a) - (g * t); // Vy = vi * sin(a) - g * t.
        }

        // Método para calcular la posición horizontal en un tiempo dado.
        public void calcX(double vi, double a, double t)
        {
            X = (vi * Math.Cos(a) * t) - (0.5 * g * t * t); // Correcta fórmula para X.
        }

        // Método para calcular la altura máxima.
        public void calcH(double vi, double a)
        {
            H = ((vi * vi) * (Math.Sin(a) * Math.Sin(a))) / (2 * g); // H = (vi² * sin²(a)) / (2 * g).
        }

        // Método para calcular la longitud máxima.
        public void calcL(double vi, double a)
        {
            L = (vi * vi * Math.Sin(2 * a)) / g; // L = (vi² * sin(2a)) / g.
        }

        // Métodos "get" para obtener los resultados de las variables calculadas.
        public double getVx() { return Vx; }
        public double getVy() { return Vy; }
        public double getX() { return X; }
        public double getH() { return H; }
        public double getL() { return L; }
    }
}
