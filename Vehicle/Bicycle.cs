namespace Vehicle
{
    internal class Bicycle : Vehicle
    {
        public bool HasBell { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"Bicycle: {(HasBell ? "has a bell: RING RING! MOVE!" : "does not have a bell. There was lots of traffic")}");
        }
    }
}
