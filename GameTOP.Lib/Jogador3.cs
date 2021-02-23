using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string chutar()
        {
            return "teste chutar";
        }

        public string correr()
        {
            return "teste correr";
        }

        public string passar()
        {
            return "teste passar";
        }
    }
}