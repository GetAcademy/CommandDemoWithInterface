namespace CommandDemoWithInterface.Demo2CommandsWithInterface
{
    internal class ResetCommand : ICommand
    {
        private readonly Stats _stats;
        public string Name => "reset";
        public string MenuText => "nullstille";

        public ResetCommand(Stats stats)
        {
            _stats = stats;
        }

        public void Run()
        {
            _stats.Reset();
        }

    }
}
