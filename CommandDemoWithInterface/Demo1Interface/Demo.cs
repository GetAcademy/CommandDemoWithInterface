namespace CommandDemoWithInterface.Demo1Interface
{
    internal class Demo
    {
        public static void Run()
        {
            var toilets = new IFlushable[]
            {
                new WaterCloset(),
                new BurningToilet(),
                new ChemicalToilet()
            };

            foreach (var t in toilets)
            {
                t.Flush();
            }
        }
    }
}
