using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFODA(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogadorA.correr());
            System.Console.WriteLine(_jogadorA.chutar());
            System.Console.WriteLine(_jogadorA.passar());
            System.Console.WriteLine("Próximo Jogador \n");
            System.Console.WriteLine(_jogadorB.correr());
            System.Console.WriteLine(_jogadorB.chutar());
            System.Console.WriteLine(_jogadorB.passar());
        }
    }

}