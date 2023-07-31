namespace netx;


/*
Records: to build immutable types and thread-safe objects.
It Helps improve memory management. It also makes your code more readable and easier to maintain. 
*/
public class RecordTypes
{
    public abstract record DegreeDays(double baseTemperature, 
                                      IEnumerable<DailyTemperature> tempRecords);

    public sealed record HeatingDegreeDays(double baseTemperature, 
                                IEnumerable<DailyTemperature> tempRecords)
    : DegreeDays(baseTemperature, tempRecords)
    {
        public double DegreeDays = tempRecords
                    .Where(s => s.Mean < baseTemperature)
                    .Sum(s => baseTemperature - s.Mean);
    }

    public sealed record CoolingDegreeDays(double baseTemperature, 
                                        IEnumerable<DailyTemperature> tempRecords)
        : DegreeDays(baseTemperature, tempRecords)
    {
        public double DegreeDays = tempRecords
                    .Where(s => s.Mean > baseTemperature)
                    .Sum(s => s.Mean - baseTemperature);
    }

    public readonly record struct DailyTemperature(double HighTemp, double LowTemp)
    {
       public double Mean { 
            get { return (HighTemp + LowTemp) / 2.0; }
        }
    }

    private static DailyTemperature[] data = new DailyTemperature[]
    {
        new DailyTemperature(HighTemp: 57, LowTemp: 30) ,   
        new DailyTemperature(60, 35),
        new DailyTemperature(63, 33),
        new DailyTemperature(68, 29),
        new DailyTemperature(72, 47)
    };

    public void testRecordTypes(){
        var heatingDegreeDays = new HeatingDegreeDays(65, data);  // base , array data
        Console.WriteLine(heatingDegreeDays);

        var coolingDegreeDays = new CoolingDegreeDays(65, data);
        Console.WriteLine(coolingDegreeDays);

    }

}
