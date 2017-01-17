namespace Digitos.Domain
{
    public class Buscador : IBuscador
    {
        private IGenerador generador;

        public Buscador(IGenerador generador)
        {
            this.generador = generador;
        }

        public int Buscar(int numero)
        {
            for(var i = 1; i <= 100000; i++)
            {
                var subcadena = generador.GetCadena(i + i.ToString().Length - 1);
                var result = subcadena.IndexOf(numero.ToString());
                if (result != -1)
                    return result + 1;
            }
            return -1;
        }
    }
}
