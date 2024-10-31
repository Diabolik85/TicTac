using System.ComponentModel.DataAnnotations;

namespace tik_tac_toe__2422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Tictac = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9', };
            int Players = 1;
            int choise;
            Console.WriteLine("Игрок 1 введите имя");
            string Player1 = Console.ReadLine();
            Console.WriteLine("Игрок 2 введите имя");
            string Player2 = Console.ReadLine();
            do
            {

                for (int i = 0; i < 9; i++)
                {
                    Console.Clear();
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("|       |       |       |");
                    Console.WriteLine("|  {0}    |   {1}   |   {2}   |", Tictac[0], Tictac[1], Tictac[2]);
                    Console.WriteLine("|_______|_______|_______|");
                    Console.WriteLine("|       |       |       |");
                    Console.WriteLine("|  {0}    |   {1}   |   {2}   |", Tictac[3], Tictac[4], Tictac[5]);
                    Console.WriteLine("|_______|_______|_______|");
                    Console.WriteLine("|       |       |       |");
                    Console.WriteLine("|  {0}    |   {1}   |   {2}   |", Tictac[6], Tictac[7], Tictac[8]);
                    Console.WriteLine("|_______|_______|_______|");


                    if (
                        (Tictac[0] == 'X' && Tictac[1] == 'X' && Tictac[2] == 'X') ||
                        (Tictac[3] == 'X' && Tictac[4] == 'X' && Tictac[5] == 'X') ||
                        (Tictac[6] == 'X' && Tictac[7] == 'X' && Tictac[8] == 'X') ||
                        (Tictac[0] == 'X' && Tictac[3] == 'X' && Tictac[6] == 'X') ||
                        (Tictac[2] == 'X' && Tictac[5] == 'X' && Tictac[8] == 'X') ||
                        (Tictac[0] == 'X' && Tictac[4] == 'X' && Tictac[8] == 'X') ||
                        (Tictac[6] == 'X' && Tictac[4] == 'X' && Tictac[2] == 'X'))
                    {
                        Console.WriteLine($"Победил {Player1}");                       
                       return;
                        
                    }
                    else if (
                        (Tictac[0] == '0' && Tictac[1] == '0' && Tictac[2] == '0') ||
                        (Tictac[3] == '0' && Tictac[4] == '0' && Tictac[5] == '0') ||
                        (Tictac[6] == '0' && Tictac[7] == '0' && Tictac[8] == '0') ||
                        (Tictac[0] == '0' && Tictac[3] == '0' && Tictac[6] == '0') ||
                        (Tictac[2] == '0' && Tictac[5] == '0' && Tictac[8] == '0') ||
                        (Tictac[0] == '0' && Tictac[4] == '0' && Tictac[8] == '0') ||
                        (Tictac[6] == '0' && Tictac[4] == '0' && Tictac[2] == '0'))
                    {
                        Console.WriteLine($"Победил  {Player2}");
                        return;
                    }
                    else if (Tictac[0] != '1' && Tictac[1] != '2' && Tictac[2] != '3' && Tictac[3] != '4' && Tictac[4] != '5' && Tictac[5] != '6' && Tictac[6] != '7' && Tictac[7] != '8' && Tictac[8] != '9')
                    {
                        Console.WriteLine($"Ничья");
                        return;
                    }
                    if (Players % 2 == 0)
                    {
                        Console.WriteLine($"Ходит:  {Player1}");
                    }
                    else
                    {
                        Console.WriteLine($"Ходит:  {Player2}");
                    }
 
                    choise = int.Parse(Console.ReadLine()!) - 1;
                    if (Tictac[choise] != 'X' && Tictac[choise] != '0')
                    {
                        if (Players % 2 == 0)
                        {
                            Tictac[choise] = 'X';
                            Players++;
                        }
                        else
                        {
                            Tictac[choise] = '0';
                            Players++;
                        }
                    }
                }
            } while (true);           
        }

    }
}




































