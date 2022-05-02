namespace CommandDemoWithInterface.Demo3CommandsWithInheritance
{
    internal class RemoveNumberCommand : Command
    {
        private readonly Stats _stats;
        public RemoveNumberCommand(Stats stats)
        {
            _stats = stats;
            Name = "remove";
            MenuText = "fjerne tall";
        }

        public override void Run()
        {
            var number = AskForInt("Skriv tall: ");
            _stats.Remove(number);
        }
    }
}
