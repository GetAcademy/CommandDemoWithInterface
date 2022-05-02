namespace CommandDemoWithInterface.Demo2CommandsWithInterface
{
    internal interface ICommand
    {
        void Run();
        string Name { get; }
        string MenuText { get; }
    }
}
