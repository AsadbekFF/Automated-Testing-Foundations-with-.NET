namespace Transports
{
    public class Engine
    {
        public string Power { get; set; }
        public double Capacity { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }

        public override string ToString()
        {
            return $"Engine" +
                $"\n\t\tPower: {Power}" +
                $"\n\t\tVolume: {Capacity}" +
                $"\n\t\tType: {Type}" +
                $"\n\t\tSerial Number: {SerialNumber}";
        }
    }
}
