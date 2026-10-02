Console.WriteLine("--- Tempo de Download ---");
Console.WriteLine();

Console.Write("Tamanho do arquivo em MB........: ");
double tamanhoArquivo = Convert.ToDouble(Console.ReadLine());

Console.Write("Velocidade da conexão em Mbps...: ");
double velocidade = Convert.ToDouble(Console.ReadLine());

double tempoSegundos = tamanhoArquivo * 8 / velocidade;
double tempoMinutos = tempoSegundos / 60;

Console.WriteLine();
Console.WriteLine($"Tempo estimado de download: {tempoMinutos:F1} minutos");