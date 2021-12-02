namespace Sonar
{
    public class Sweep
    {
        public static void Greater()
        {
            int isGreater = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Mikamora\Documents\JS\advent\advent-1-input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if (i + 3 < lines.Length)
                {
                    int measure1 = Int32.Parse(lines[i]) + Int32.Parse(lines[i + 1]) + Int32.Parse(lines[i + 2]);
                    int measure2 = Int32.Parse(lines[i + 1]) + Int32.Parse(lines[i + 2]) + Int32.Parse(lines[i + 3]);
                    if (measure1 < measure2)
                    {
                        isGreater++;
                    }

                }

                else
                {
                    Console.WriteLine(isGreater);
                    return;
                }
            }
        }
    }
}