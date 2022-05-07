using System.Text.RegularExpressions;

namespace ProjetoCalculadora
{
    public class Outros
    {
        public static bool ValidarSenha(string senha)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(senha) && hasUpperChar.IsMatch(senha) && hasMinimum8Chars.IsMatch(senha);

            return isValidated;
        }

        public static bool IsValidAddress(string email)
        {
            Regex regex = new(@"^[\w0-9._%+-]+@[\w0-9.-]+\.[\w]{2,6}$");
            return regex.IsMatch(email);
        }
    }
}
