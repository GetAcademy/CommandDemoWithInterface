namespace CommandDemoWithInterface.Demo3CommandsWithInheritance
{
    internal class AddNumberCommand : Command
    {
        private readonly Stats _stats;

        public AddNumberCommand(Stats stats)
        {
            _stats = stats;
            Name = "add";
            MenuText = "legge til tall";
        }

        public override void Run()
        {
            var number = AskForInt("Skriv tall: ");
            _stats.Add(number);
        }
    }
}
