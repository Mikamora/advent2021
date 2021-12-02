namespace Movement
{
    public class Move
    {
        public static void DepthAndDistance()
        {
            string[] instructions = System.IO.File.ReadAllLines(@"C:\Users\Mikamora\Documents\JS\advent\advent-2-input.txt");
            var forward = 0;
            var depth = 0;
            for (var i = 0; i < instructions.Length; i++)
            {
                var number = instructions[i].Split(" ");
                if (instructions[i].Contains("forward"))
                {
                    forward = forward + int.Parse(number[1]);
                }
                else if (instructions[i].Contains("down"))
                {
                    depth = depth + int.Parse(number[1]);
                }
                else if (instructions[i].Contains("up"))
                {
                    depth = depth - int.Parse(number[1]);
                }
            }
            Console.WriteLine(forward + "," + depth);
            Console.WriteLine(forward * depth);
        }
        public static void Aim()
        {
            string[] instructions = System.IO.File.ReadAllLines(@"C:\Users\Mikamora\Documents\JS\advent\advent-2-input.txt");
            var forward = 0;
            var aim = 0;
            var depth = 0;
            for (var i = 0; i < instructions.Length; i++)
            {
                var number = instructions[i].Split(" ");
                if (instructions[i].Contains("forward"))
                {
                    forward = forward + int.Parse(number[1]);
                    depth = (int.Parse(number[1]) * aim) + depth;
                }
                else if (instructions[i].Contains("down"))
                {
                    aim = aim + int.Parse(number[1]);
                }
                else if (instructions[i].Contains("up"))
                {
                    aim = aim - int.Parse(number[1]);
                }
            }
            Console.WriteLine(forward + "," + depth + "," + aim);
            Console.WriteLine(forward * depth);
        }
    }
}