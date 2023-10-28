internal class Program
{
    private static void Main(string[] args)
    {
        const string saida = "Adeus";

        Console.WriteLine("-----CHAT DO GROOT-----\n");

        string pergunta;
        do
        {
            Console.Write("Fale oi para o Groot.....:");
            pergunta = Console.ReadLine()!;

            string resposta = RespostadoGroot(pergunta);
            ExibeResposta(RespostadoGroot(pergunta));

        }
        while (pergunta.Trim().ToLower() != saida);

        void ExibeResposta(string resposta)
        {

            Console.ForegroundColor = ConsoleColor.Green
        ;
            Console.WriteLine($"RESPOSTA.....: {resposta}");
            Console.ResetColor();
        }

        string RespostadoGroot(string pergunta)
        
        {
            return pergunta.Trim().ToLower() == saida ?
                "Eu sou Groot!" :
                "Eu sou Groot";
        }
        while (saida != "S" && saida != Console.ReadLine()) ;
    }
}