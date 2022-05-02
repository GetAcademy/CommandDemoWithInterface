namespace CommandDemoWithInterface.Demo1Interface
{
    internal class ChemicalToilet : IFlushable
    {
        public void Flush()
        {
            Console.WriteLine("Adding chemicals");
        }
    }
}
