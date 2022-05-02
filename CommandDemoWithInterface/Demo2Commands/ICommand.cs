namespace CommandDemoWithInterface.Demo2Commands
{
    internal interface ICommand
    {
        void Run();
        string Name { get; }
        string MenuText { get; }
    }
}
