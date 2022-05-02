namespace CommandDemoWithInterface.Demo3CommandsWithInheritance
{
    internal class Demo3
    {
        public static void Run()
        {
            var stats = new Stats();
            while (true)
            {
                var commands = new Command[]
                {
                    new AddNumberCommand(stats),
                    new ShowDescriptionCommand(stats),
                    new ResetCommand(stats),
                    new RemoveNumberCommand(stats)
                };

                Console.WriteLine("Meny: ");
                foreach (var command in commands)
                {
                    Console.WriteLine($"{command.Name} => {command.MenuText}");
                }
                Console.Write("Hva vil du gjøre? ");
                var cmdName = Console.ReadLine();

                //ICommand cmd = null;
                //foreach (var command in commands)
                //{
                //    if (command.Name == cmdName) cmd = command;
                //}

                var cmd = commands.FirstOrDefault(c => c.Name == cmdName);
                cmd?.Run();
            }
        }
    }
}
