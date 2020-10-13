namespace GameTOP
{
    public class JogoFODA
    {
        private readonly string _jogador;

        public JogoFODA(Jogador jogador){
            _jogador = jogador;
        }


        public void IniciarJogo(){
            Console.Write($"{_jogador.nome} deu um passe");
        }
    }
}