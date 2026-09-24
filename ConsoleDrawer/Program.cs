//Console. Title = "Üdvözlö";
//Console. Write("add meg a neved");
//string name = Console.ReadLineC;
//Console. WriteLine($"Szia {name)!");
//Console WindowHeight;
//Console. Windowwidth;
//Console. SetCursorPosition( 0, 0 );
//var position = Console.GetCursorPositionQ;
//position. Top, position. Left //Console. WindowLeftO;
//Console. WindowTopO;
//Console. ForegroundColor = ConsoleColor Green;
//Console. BackgroundColor = ConsoLeCoLor.Green;
//Thread.Sleep(miLisec);
using System.ComponentModel;

namespace DrawingProject

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawEdges();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.ReadKey();
            Console.WriteLine();
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 0)
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < Console.WindowHeight - 1)
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft > 0)
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft < Console.WindowWidth - 1)
                            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write("█");
                        break;
                    case ConsoleKey.F1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case ConsoleKey.F2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case ConsoleKey.F3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case ConsoleKey.F4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case ConsoleKey.D1:
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case ConsoleKey.D2:
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        break;
                    case ConsoleKey.D3:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        break;
                    case ConsoleKey.D4:
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.D5:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;
                    case ConsoleKey.D6:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        break;
                    case ConsoleKey.D7:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        break;
                    case ConsoleKey.D8:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        break;
                    case ConsoleKey.D9:
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        break;
                    case ConsoleKey.Delete:
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.Backspace:
                        if (Console.CursorLeft > 0)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        }
                        break;
                }
            }
        }
        private static void DrawEdges()
        {
            Console.Write("╔");
            {
                for (int i = 0; i < Console.WindowWidth - 2; i++)
                {
                    Console.Write("═");
                }

            }
            Console.Write("╗");
            for (int i = 0; i < Console.WindowHeight - 2; i++)
            {
                Console.WriteLine("║");

            }
            Console.Write("╚");
            for (int i = 0; i < Console.WindowWidth - 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.WriteLine("║");
            }
        }
    }
}
//╔═╗║╚╝█░▒▓
//1. keret kirajzolasa 
//2. kurzor mozgatasa(nyilakkal) -> keretből nem mehetsz ki 
//3. space-re kiirsz karaktereket 
//4. karakter beallitasa (F1-F4) 
//5. alap karakterszin beallitasa D1-... 
//6. -ra dark verzio +-ra visszaáll
//7. background color
//8. delete & backspace -> törlés
//9. caps lock -> kurzor csikot húz