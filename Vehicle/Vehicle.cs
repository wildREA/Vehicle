namespace Vehicle
{
    // Car class definition
    public class Vehicle
    {
        required public string Brand { get; set; }
        public int MaxSpeed { get; set; }


        public static void Main(string[] args)
        {
            DisplayVehicles();
        }
        public virtual void Drive()
        {
            Console.WriteLine($"Vehicle: {Brand} is driving at {MaxSpeed} km/h");
        }
        public static void DisplayVehicles()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle { Brand = "Generic Vehicle", MaxSpeed = 60 },
                new Bicycle { Brand = "Mountain Bike", MaxSpeed = 30, HasBell = true },
                new Bicycle { Brand = "Road Bike", MaxSpeed = 45, HasBell = false },
                new Car { Brand = "Toyota", MaxSpeed = 120, NumberOfDoors = 4 },
                new Car { Brand = "Ferrari", MaxSpeed = 200, NumberOfDoors = 2 }
            };
            Console.WriteLine("Displaying all vehicles:");
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
        }
    }
}
