namespace CommandDemoWithInterface.Demo2CommandsWithInterface
{
    internal class RemoveNumberCommand : ICommand
    {
        private readonly Stats _stats;
        public string Name => "remove";
        public string MenuText => "fjerne tall";

        public RemoveNumberCommand(Stats stats)
        {
            _stats = stats;
        }

        public void Run()
        {
            Console.Write("Skriv tall: ");
            var numberStr = Console.ReadLine();
            var number = Convert.ToInt32(numberStr);
            _stats.Remove(number);
        }
    }
}
