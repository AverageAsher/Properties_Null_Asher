namespace Properties_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Create a Car object
            Car car1 = new Car();
            car1.Model = "Corolla";
            car1.Make = "Toyota";

            // Display results
            Console.WriteLine("Car 1:");
            Console.WriteLine($"Model: {car1.Model}");
            Console.WriteLine($"Make: {car1.Make}");
            Console.WriteLine();

            // Create another Car object
            Car car2 = new Car();
            car2.Model = "Civic";
            car2.Make = "Honda";

            // Display results
            Console.WriteLine("Car 2:");
            Console.WriteLine($"Model: {car2.Model}");
            Console.WriteLine($"Make: {car2.Make}");

            Console.ReadLine(); // To prevent the console window from closing immediately
        }
    }
}