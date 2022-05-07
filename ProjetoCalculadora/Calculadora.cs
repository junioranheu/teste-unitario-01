namespace ProjetoCalculadora
{
    public static class Calculadora
    {
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

        public static double RaizQuadrada(int n1)
        {
            return Math.Sqrt(n1);
        }

        public static double Potencia(int n1, int expoente)
        {
            return Math.Pow(n1, expoente);
        }

        public static bool IsNumeroPar(int n1)
        {
            return (n1 % 2 == 0);
        }

        public static bool IsNumeroImpar(int n1)
        {
            return (n1 % 2 == 1);
        }

        public static double Porcentagem(int n1, double porcentagem)
        {
            // Ajustar o parâmetro "porcentagem" caso seja >= 1;
            porcentagem = (porcentagem >= 1 ? (porcentagem / 100) : porcentagem);
            double r = n1 * porcentagem;

            return r;
        }

        public static double RegraDeTres(double n1, double grandeza1, double n2, bool isRegraDeTresEmXis)
        {
            double rIncognita = 0;

            if (isRegraDeTresEmXis)
            {
                rIncognita = (n2 * grandeza1) / n1;
            } else
            {
                rIncognita = (n1 * grandeza1) / n2;
            }

            return rIncognita;
        }

        public static double NumeroMaior(List<double> listaNumeros)
        {
            return listaNumeros.Max<double>(); 
        }

        public static double NumeroMenor(List<double> listaNumeros)
        {
            return listaNumeros.Min<double>(); 
        }
    }
}
