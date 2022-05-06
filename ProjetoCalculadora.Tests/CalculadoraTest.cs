using System.Collections.Generic;
using Xunit;

// Tutorial YT - teste unitário: https://www.youtube.com/watch?v=40TujcOnLdQ&t=81s&ab_channel=CanalTI
namespace ProjetoCalculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calculadora.Somar(10, 10));
            Assert.Equal(110, Calculadora.Somar(77, 33));
            Assert.Equal(1, Calculadora.Somar(-5, 6));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, Calculadora.Subtrair(10, 10));
            Assert.Equal(-10, Calculadora.Subtrair(0, 10));
            Assert.Equal(4999, Calculadora.Subtrair(5000, 1));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicar(10, 10));
            Assert.Equal(2500, Calculadora.Multiplicar(50, 50));
            Assert.Equal(60, Calculadora.Multiplicar(30, 2));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, Calculadora.Dividir(10, 10));
            Assert.Equal(10, Calculadora.Dividir(100, 10));
            Assert.Equal(100, Calculadora.Dividir(1000, 10));
        }

        [Fact]
        public void RaizQuadrada()
        {
            Assert.Equal(3, Calculadora.RaizQuadrada(9));
            Assert.Equal(5, Calculadora.RaizQuadrada(25));
            Assert.Equal(10, Calculadora.RaizQuadrada(100));
        }

        [Fact]
        public void Potencia()
        {
            Assert.Equal(27, Calculadora.Potencia(3, 3));
            Assert.Equal(512, Calculadora.Potencia(2, 9));
            Assert.Equal(49, Calculadora.Potencia(7, 2));
        }

        [Fact]
        public void IsNumeroPar()
        {
            Assert.True(Calculadora.IsNumeroPar(4));
            Assert.True(Calculadora.IsNumeroPar(1002));
            Assert.False(Calculadora.IsNumeroPar(3));
        }

        [Fact]
        public void IsNumeroImpar()
        {
            Assert.True(Calculadora.IsNumeroImpar(3));
            Assert.True(Calculadora.IsNumeroImpar(1001));
            Assert.False(Calculadora.IsNumeroImpar(4));
        }

        [Fact]
        public void Porcentagem()
        {
            Assert.Equal(1, Calculadora.Porcentagem(2, 50)); // Segundo parâmetro, "porcentagem", como número "inteiro";
            Assert.Equal(1, Calculadora.Porcentagem(2, 0.50)); // Segundo parâmetro, "porcentagem", como número "de porcetagem";
            Assert.Equal(7, Calculadora.Porcentagem(10, 70));
            Assert.Equal(234.83089999999999, Calculadora.Porcentagem(853, 27.53));
        }

        [Fact]
        public void RegraDeTres()
        {
            Assert.Equal(50, Calculadora.RegraDeTres(10, 100, 5, true));
            Assert.Equal(750, Calculadora.RegraDeTres(2, 300, 5, true)); // 2 bolos, 300 gramas de açucar; 5 bolos, x gramas de açucar;
            Assert.Equal(20, Calculadora.RegraDeTres(8, 30, 12, false)); // 8 pedreiros construiram uma casa em 30 dias, 12 pedreiros demorariam quantos dias?
        }

        [Fact]
        public void NumeroMaior()
        {
            Assert.Equal(10.1, Calculadora.NumeroMaior(new List<double>(new double[] { 2, 5.2, 8, 10.1 })));
            Assert.Equal(1302.2, Calculadora.NumeroMaior(new List<double>(new double[] { -10, 80.1, 1302.2, 4 })));
            Assert.Equal(1, Calculadora.NumeroMaior(new List<double>(new double[] { -50000, 1, -0.2 })));
        }

        [Fact]
        public void NumeroMenor()
        {
            Assert.Equal(2, Calculadora.NumeroMenor(new List<double>(new double[] { 2, 5.2, 8, 10.1 })));
            Assert.Equal(-10, Calculadora.NumeroMenor(new List<double>(new double[] { -10, 80.1, 1302.2, 4 })));
            Assert.Equal(-50000, Calculadora.NumeroMenor(new List<double>(new double[] { -50000, 1, -0.2 })));
        }

        [Fact]
        public void ValidarSenha()
        {
            Assert.False(Calculadora.ValidarSenha("123"));
            Assert.True(Calculadora.ValidarSenha("Teste30@"));
            Assert.False(Calculadora.ValidarSenha("TesteTeste"));
            Assert.True(Calculadora.ValidarSenha("TesteTeste1"));
        }
    }
}