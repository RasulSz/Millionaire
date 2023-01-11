using System.Globalization;

namespace Millionairee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] array = new string[10][]
            {
                new string[] {"What is the capital of Azerbaijan?\n","Baku","Oslo","Berlin"},
                new string[] {"Who owns Facebook?\n","Steve Jobs","Mark Zuckerberg","Jeff Bezos"},
                new string[] {"What is the smallest country in the world?\n","Vatican","Italy","Iran"},
                new string[] {"Which model series is latest Iphone model?\n","13","12","14"},
                new string[] {"What is the fastest car in the world?\n","Bugatti Chiron","Koenigsegg Jesco","Mclaren 720s"},
                new string[] {"How many people is the world population?\n","7billion","7.5billion","8billion"},
                new string[] {"Who is president of America?\n","Donalt Trump","Barac Obama","Joe Biden"},
                new string[] {"Which of them is located in Baku?\n","Piza Tower","Flame Towers","Eiffel Tower"},
                new string[] {"How many states are there in America?\n","49","51","53"},
                new string[] {"What is the population of Turkey?\n","83mln","84mln","85mln"},
            };

            string[] results = new string[] { "Baku", "Mark Zuckerberg", "Vatican", "14", "Koenigsegg Jesco", "8billion", "Joe Biden", "Flame Towers", "51", "84mln" };
            int choice = 65;
            int anscounter = 0;
            int counter = 0;
            int questcounter = 1;
            int[] arrayy = new int[] { };
            string[] answers = new string[] { };
            int[] variants=new int[] { };
            while (counter <= 10)
            {
                Random random = new Random();
                int order = random.Next(0,10);
                if (!arrayy.Contains(order))
                {
                    Array.Resize(ref arrayy, arrayy.Length + 1);
                    arrayy[arrayy.Length-1] = order;
                    int answerorder = 5;
                    for (int i = order; ;)
                    {
                        Array.Clear(variants, 0, variants.Length);
                        Array.Resize(ref variants, 0);
                        Array.Clear(answers,0, answers.Length);
                        Array.Resize(ref answers, 0);
                        Console.Write(questcounter);
                        Console.Write(")");
                        Console.Write($"{array[i][0]}");
                        questcounter++;
                        for (int k = answerorder; ;)
                        {
                            random = new Random();
                            answerorder = random.Next(1, 4);
                            if (variants.Contains(answerorder))
                            {
                                Array.Resize(ref variants, variants.Length + 1);
                                variants[variants.Length-1] = answerorder;
                                Console.Write((char)choice);
                                Console.Write(")");
                                Console.Write($"{array[i][answerorder]}");
                                Array.Resize(ref answers, answers.Length + 1);
                                answers[answers.Length - 1] = array[i][answerorder];
                                choice++;
                                if (variants.Length == 3)
                                {
                                    choice = 65;
                                    break;
                                }
                            }
                            else
                            {
                                continue;
                            }
;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter Your Choice : ");
                        char answer = char.Parse(Console.ReadLine());
                        int intversion=(int)answer;
                        intversion -= 65;
                        if (answers[intversion] == answers[i])
                        {
                            anscounter++;
                            if (anscounter == 10)
                            {
                                Console.WriteLine("You Won");
                            }
                        }
                        counter++;
                        if(counter == 10)
                        {
                            break;
                        }
                        else
                        {
                        continue;
                        }
                    }
                }
            }
        }   
    }
}