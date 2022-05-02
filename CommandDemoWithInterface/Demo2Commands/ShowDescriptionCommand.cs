namespace CommandDemoWithInterface.Demo2Commands
{
    internal class ShowDescriptionCommand : ICommand
    {
        private readonly Stats _stats;
        public string Name => "show";
        public string MenuText => "vise stats";

        public ShowDescriptionCommand(Stats stats)
        {
            _stats = stats;
        }

        public void Run()
        {
            Console.WriteLine(_stats.Description);
        }
    }
}
