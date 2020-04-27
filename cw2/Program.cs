using System;
using System.IO;
using System.Collections;

namespace cw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            if (args.Length == 2)
            {
                args[2] = "xml";
            }else if (args.Length == 1)
            { 
            
                args[2] = "xml";
                args[1] = "zezult.xml";
            } else if (args.Length == 0);
            {
                args[2] = "xml";
                args[1] = "zazult.xml";
                args[0] = "dane.csv";
            }

            try
            {
                if (!File.Exists(args[0]))
                    throw new FileNotFoundException("Podana sciezka jest niepoprawna");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                var lines = File.ReadLines(args[0]);

                System.Text.StringBuilder builder = new System.Text.StringBuilder("<uczelnia createdAt =");
                builder.Append(String.Format("\'", DateTime.Today));
                builder.Append("\" author=\"Alia Molodets\" <studenci>");

                ArrayList students = new ArrayList();
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                    System.Text.StringBuilder student = new System.Text.StringBuilder("<uczelnia createdAt = ");
                    //student.Append();
                    String[] word = line.Split(",");
                    if (word.Length < 8)
                    {
                        continue;
                    }
                    for (int i = 0; i < 9; i++)
                    {
                        if (word[i] == " " || word[i] == null)
                        {
                            continue;
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Podana sciezka jest niepoprawna");
            }

        }
    }
}
