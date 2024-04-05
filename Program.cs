namespace palindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.Write("---------Bem-vindo(a) ao Verificador de Palíndromo------------ \n|Escolha uma opção : \n|1) para escrever uma palavra e verificar se é palindromo \n|2) para sair do programa. \nEscolha : ");
                int? choose = Convert.ToInt32(Console.ReadLine());
                switch(choose) 
                {
                    case 1:
                        Console.Write("Escreva a palavra : ");
                        string? input = Console.ReadLine();

                        if (string.IsNullOrEmpty(input)) { Console.WriteLine("[ERROR] A palavra não pode ser vazia!"); }
                        else if (input.Reverse().SequenceEqual(input)) 
                        { 
                            Console.Write("-------------------------\n\n --> a palavra \"{0}\" ao contrário fica \"{1}\" ou seja", input.ToUpper(), new string(input.ToUpper().Reverse().ToArray()));
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" É ");
                            Console.ResetColor();
                            Console.WriteLine("Palindromo\n"); 
                        }
                        else 
                        { 
                            Console.Write("-------------------------\n\n --> a palavra \"{0}\" ao contrário fica \"{1}\" ou seja", input.ToUpper(), new string(input.ToUpper().Reverse().ToArray()));
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" NÃO É ");
                            Console.ResetColor();
                            Console.WriteLine("Palindromo\n");
                        } 
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("digite uma opção valida");
                        break;
                }
            }
        }
    }
}