using Xunit;

// Teste unitário: https://www.codemotion.com/magazine/dev-hub/backend-dev/testing-your-c-code-with-xunit/
namespace ProjetoCalculadora.Tests
{
    public class OutrosTest
    {
        [Fact]
        public void ValidarSenha()
        {
            Assert.False(Outros.ValidarSenha("123"));
            Assert.True(Outros.ValidarSenha("Teste30@"));
            Assert.False(Outros.ValidarSenha("TesteTeste"));
            Assert.True(Outros.ValidarSenha("TesteTeste1"));
        }

        [Fact]
        public void Test_ValidarEmail()
        {
            // O padrão AAA (Arrange, Act, Assert);
            // Arrange/Organizar;
            const string email = "junior.souza@hotmail.com";

            // Act/Agir;
            bool isValid = Outros.IsValidAddress(email);

            // Assert/Declarar;
            Assert.True(isValid, $"O e-mail {email} não é válido");
        }

        [Theory]
        [InlineData("junior.souza@hotmail.com", true)]
        [InlineData("juniorsouza@hotmail.com", true)]
        [InlineData("junior.souza@hotmail.aea", true)]
        [InlineData("junior.souza@hotmail.it", true)]
        [InlineData("junior.souza.hotmail.com", false)]
        [InlineData("junior@souza@hotmail.com", false)]
        [InlineData("junior", false)]
        [InlineData("", false)]
        public void Test_ValidarMultiplosEmailsComTheory(string email, bool resultadoEsperado)
        {
            Assert.Equal(resultadoEsperado, Outros.IsValidAddress(email));
        }
    }
}