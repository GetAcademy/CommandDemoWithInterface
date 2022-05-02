namespace CommandDemoWithInterface.Demo1Interface
{
    internal class WaterCloset : IFlushable
    {
        public void Flush()
        {
            Console.WriteLine("Spyler med vann");
        }
    }
}
