using System;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly Jogador _jogador;

        public JogoFODA(Jogador jogador){
            _jogador = jogador;
        }


        public void IniciarJogo(){
            _jogador.chuta();
            _jogador.corre();
            _jogador.passe();
     
        }
    }
}