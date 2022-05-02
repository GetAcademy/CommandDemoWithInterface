namespace CommandDemoWithInterface.Demo1Interface
{
    internal class BurningToilet : IFlushable
    {
        public void Flush()
        {
            Console.WriteLine("Tenner på");
        }
    }
}
