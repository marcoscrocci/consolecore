using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        //Chuta
        public string chutar()
        {
            return $"{_Nome} está chutando.";
        }

        //Correr
        public string correr()
        {
            return $"{_Nome} está correndo.";           
        }

        //Passe
        public string passar()
        {
            return $"{_Nome} está passando.";
        }

    }
}