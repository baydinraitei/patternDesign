namespace Common
{
    public static class Design
    {
        public static void header(string designPattern, string? synopsis = null, string? sujet = null)
        {
            ConsoleColor consoleColor = ConsoleColor.Blue;
            Console.WriteLine("********************************************************************");



            Console.Write("Pattern: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"{designPattern}\n");
            Console.ResetColor();

            Console.Write("Synopsis: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(synopsis);
            Console.ResetColor();

            if(sujet != null)
            {
                Console.Write("Sujet: ");
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(sujet);
                Console.ResetColor();
            }

        
            Console.WriteLine("********************************************************************\n");
        }
    }
}