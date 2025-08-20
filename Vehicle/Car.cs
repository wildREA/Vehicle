namespace Vehicle
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"Car: The {NumberOfDoors}-door {Brand} is driving at {MaxSpeed}");
        }
    }
}
