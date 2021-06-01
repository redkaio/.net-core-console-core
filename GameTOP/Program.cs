namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                
                new Jogador1(),
                new Jogador1("Day")
                );
            jogo.IniciarJogo();
        }
    }
}
