namespace CommandDemoWithInterface.Demo3CommandsWithInheritance
{
    internal class ShowDescriptionCommand : Command
    {
        private readonly Stats _stats;

        public ShowDescriptionCommand(Stats stats)
        {
            _stats = stats;
            MenuText = "vise stats";
            Name = "show";
        }

        public override void Run()
        {
            Console.WriteLine(_stats.Description);
        }
    }
}
