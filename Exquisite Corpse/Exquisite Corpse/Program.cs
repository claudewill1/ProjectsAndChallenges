using System;

namespace Exquisite_Corpse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Would you like to create a RANDOM creature or CREATE one: ");
            string userChoice = Console.ReadLine().ToUpper();
            if (userChoice == "RANDOM")
            {
                RandomMode();
            }
            else
            {
                Console.Write("Would you like the head to be a BUG, GHOST, or MONSTER: ");
                string head = Console.ReadLine().ToLower();
                Console.Write("Would you like the body to be a BUG, GHOST, or MONSTER: ");
                string body = Console.ReadLine().ToLower();
                Console.Write("Would you like the feet to be a BUG, GHOST, or MONSTER: ");
            string feet = Console.ReadLine().ToLower();
                BuildACreature(head, body, feet);
            }
        }
        static void BuildACreature(string head, string body, string feet)
        {
            // this will return an ASCII creature
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);

            SwitchCase(headNum, bodyNum, feetNum);


        }
        static void RandomMode()
        {
            Random ran = new Random();
            int head = ran.Next(1, 4);
            int body = ran.Next(1, 4);
            int feet = ran.Next(1, 4);

            SwitchCase(head, body, feet);
        }
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                default:
                    MonsterHead();
                    break;

            }
            switch (body)
            {
                case 1:
                    BugBody();
                    break;
                case 2:
                    GhostBody();
                    break;
                default:
                    MonsterBody();
                    break;
            }
            switch (feet)
            {
                case 1:
                    BugFeet();
                    break;
                case 2:
                    GhostFeet();
                    break;
                default:
                    MonsterFeet();
                    break;

            }
        }
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "bug":
                    return 1;

                case "ghost":
                    return 2;

                default:
                    return 3;

            }
        }
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
