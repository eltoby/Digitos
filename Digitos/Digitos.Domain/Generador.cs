namespace Digitos.Domain
{
    using System.Text;

    public class Generador : IGenerador
    {
        private StringBuilder cadena;
        private int numero;

        public Generador()
        {
            this.cadena = new StringBuilder();
        }

        public string GetCadena(int length)
        {
            while (cadena.Length < length)
            {
                numero++;
                cadena.Append(numero);
            }
            return cadena.ToString();                        
        }
    }
}
