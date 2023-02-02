namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero) : base(numero)
        {

        }

        public Nokia(string numero, string modelo, string imei, int memoria) : this(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            
        }
    }
}