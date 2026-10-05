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
#pragma warning disable CA1416 // Validate platform compatibility
using System.ComponentModel;

namespace DrawingProject

{
    internal class Program
    {

        static void Main(string[] args)
        {
            DrawEdges();
            Menu();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.ReadKey();;
            char drawchar = '█';
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 0)
                        {
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        }
                        if (Console.CapsLock)
                        {
                            Console.Write(drawchar);
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < Console.WindowHeight - 2)
                        {
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                        }
                        if (Console.CapsLock)
                        {
                            Console.Write(drawchar);
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft > 1)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        }
                        if (Console.CapsLock)
                        {
                            Console.Write(drawchar);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft < Console.WindowWidth - 2)
                        {
                            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                        }
                        if (Console.CapsLock)
                        {
                            Console.Write(drawchar);
                            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(drawchar);
                        break;
                    case ConsoleKey.F1:
                        drawchar = '█';
                        break;
                    case ConsoleKey.F2:
                        drawchar = '▓';
                        break;
                    case ConsoleKey.F3:
                        drawchar = '▒';
                        break;
                    case ConsoleKey.F4:
                        drawchar = '░';
                        break;
                    case ConsoleKey.D1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case ConsoleKey.D2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case ConsoleKey.D3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case ConsoleKey.D4:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case ConsoleKey.D5:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case ConsoleKey.D6:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case ConsoleKey.D7:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case ConsoleKey.D8:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case ConsoleKey.D9:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case ConsoleKey.Delete:
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.Backspace:
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.Subtract:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case
                        ConsoleKey.Add:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.F:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        DrawEdges();
                        break;
                }

            }
            
        }
        private static void Menu()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 12);
            Console.WriteLine("╔══════════════════╗");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 11);
            Console.WriteLine("Létrehozás");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 11);
            Console.WriteLine("║");
            Console.SetCursorPosition(Console.WindowWidth / 2 + 9, Console.WindowHeight / 2 - 11);
            Console.WriteLine("║");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 10);
            Console.WriteLine("╚══════════════════╝");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 8);
            Console.WriteLine("╔══════════════════╗");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 7);
            Console.WriteLine("Betöltés");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 7);
            Console.WriteLine("║");
            Console.SetCursorPosition(Console.WindowWidth / 2 + 9, Console.WindowHeight / 2 - 7);
            Console.WriteLine("║");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 6);
            Console.WriteLine("╚══════════════════╝");

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