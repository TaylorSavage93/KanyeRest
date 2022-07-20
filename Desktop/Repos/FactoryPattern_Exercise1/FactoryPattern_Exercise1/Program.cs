using FactoryPattern_Exercise1;

int numOfWheels;
bool input = false;
do
{
    Console.WriteLine("Enter the amount of tires for your desired vehicle...");

    input = int.TryParse(Console.ReadLine(), out numOfWheels);

} while (input == false);

var vehicle = VehicleFactory.GetVehicle(numOfWheels);


vehicle.Drive();
