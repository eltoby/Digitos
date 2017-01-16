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
                var subcadena = generador.GetParteCadena(i, 1);
                if (subcadena == numero.ToString())
                    return i;
            }
            return -1;
        }
    }
}
