namespace primeiro_poo
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        public double Atacar(double f, double p) {
            return f*p;
        }

        public string Defender() {
            return $"{nome} defendeu.";
        }
    }
}