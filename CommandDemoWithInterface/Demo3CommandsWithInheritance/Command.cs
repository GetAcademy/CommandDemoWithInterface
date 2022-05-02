namespace CommandDemoWithInterface.Demo3CommandsWithInheritance
{
    internal abstract class Command
    {
        public abstract void Run();
        public string Name { get; protected set; }
        public string MenuText { get; protected set; }

        public static int AskForInt(string question)
        {
            Console.Write(question);
            var numberStr = Console.ReadLine();
            var number = Convert.ToInt32(numberStr);
            return number;
        }
    }
}
