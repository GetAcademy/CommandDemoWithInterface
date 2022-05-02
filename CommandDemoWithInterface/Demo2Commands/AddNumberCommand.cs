namespace CommandDemoWithInterface.Demo2Commands
{
    internal class AddNumberCommand : ICommand
    {
        private readonly Stats _stats;
        public string Name => "add";
        public string MenuText => "legge til tall";

        public AddNumberCommand(Stats stats)
        {
            _stats = stats;
        }

        public void Run()
        {
            Console.Write("Skriv tall: ");
            var numberStr = Console.ReadLine();
            var number = Convert.ToInt32(numberStr);
            _stats.Add(number);
        }
    }
}
