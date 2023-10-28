const string saida = "Adeus";

Console.WriteLine("-----CHAT DO GROOT-----\n");

string pergunta;

do
{
    Console.Write("Faça uma pergunta para o Groot.....:");
    pergunta = Console.ReadLine()!;
    
    string resposta = RespostadoGroot(pergunta);
    ExibeResposta(RespostadoGroot(pergunta));
    
} 
while  (pergunta.Trim().ToLower() != saida);

    void ExibeResposta(string resposta)
    {
    
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"RESPOSTA {resposta}");
        Console.ResetColor();      
    }
  RespostadoGroot(string pergunta);
 {
  return pergunta.Trim().ToLower() == saida ?

    "Eu sou o Groot!":
    "Eu sou o Groot";  
 }   










// ﻿const string FraseParaSair = "tchau";

// Console.WriteLine("--- Groot Chatbot ---\n");

// string pergunta;
// do
// {
//     Console.Write("Pergunta: ");
//     pergunta = Console.ReadLine()!;

//     string resposta = ObtemRespostaGroot(pergunta);

//     ExibeResposta(ObtemRespostaGroot(pergunta));

// } while (pergunta.Trim().ToLower() != FraseParaSair);


// void ExibeResposta(string resposta)
// {
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine($"                          Resposta: {resposta}");
//     Console.ResetColor();
// }

// string ObtemRespostaGroot(string pergunta)
// {
//     return pergunta.Trim().ToLower() == FraseParaSair ?
//         "Eu sou Groot!" :
//         "Eu sou Groot.";
// }