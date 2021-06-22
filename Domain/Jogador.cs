namespace Jogo
{
    public class Jogador : IJogador
    {
        public string Nome { get; set; }
        public Jogador(string nome)
        {
            this.Nome = nome;
        }

        public string Chutar()
        {
            return $"O jogador {this.Nome} está chutando a bola.";
        }
        public string Correr()
        {
            return $"O jogador {this.Nome} está correndo atrás da bola.";
        }
        public string Passar()
        {
            return $"O jogador {this.Nome} está passando a bola.";
        }
    }
}