namespace CommandDemoWithInterface.Demo3CommandsWithInheritance
{
    internal class ResetCommand : Command
    {
        private readonly Stats _stats;

        public ResetCommand(Stats stats)
        {
            _stats = stats;
            Name = "reset";
            MenuText = "nullstille";
        }

        public override void Run()
        {
            _stats.Reset();
        }
    }
}
