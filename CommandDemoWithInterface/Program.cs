using CommandDemoWithInterface.Demo1Interface;

// Pause til 10:30

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


//var stats = new Stats();
//while (true)
//{
//    Console.Write("Skriv tall: ");
//    var numberStr = Console.ReadLine();
//    var number = Convert.ToInt32(numberStr);
//    stats.Add(number);
//    Console.WriteLine(stats.GetDescription());

//    Console.WriteLine(stats.Count);
//    //stats.Count = 17;
//}