namespace GameTOP.lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _nome;

        public Jogador1(string nome = "Renan")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está chutando\n";
        }

        public string Corre()
        {
            return $"{_nome} está correndo\n";
        }

        public string Passe()
        {
            return $"{_nome} está passando\n";
        }
    }
}