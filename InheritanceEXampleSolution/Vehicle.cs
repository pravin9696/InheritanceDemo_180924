namespace InheritanceDemo_180924.InheritanceEXampleSolution
{
    internal class Vehicle
    {
        string Vehicle_model;
        int Registration_number;
        int Vehicle_speed;
        int Fuel_Capacity;
        int Fuel_Consumption;
        public Vehicle()
        {

        }
        public Vehicle(string vm, int rn, int vs, int fc, int fcons)
        {
            Vehicle_model = vm;
            Registration_number = rn;
            Vehicle_speed = vs;
            Fuel_Capacity = fc;
            Fuel_Consumption = fcons;
        }

        public int fuelNeeded(int distance)
        {
            int fuelNeed = distance / Fuel_Consumption;
            return fuelNeed;
        }

        public void distanceCovered(int time)
        {
            int distance;
            distance = Vehicle_speed * time;
            Console.WriteLine($"Total Distance will convered int {time} is {distance} KM/Hr");
        }

        public virtual void display()
        {
            Console.WriteLine(Vehicle_model);
            Console.WriteLine(Registration_number);
            Console.WriteLine(Vehicle_speed);
            Console.WriteLine(Fuel_Capacity);
            Console.WriteLine(Fuel_Consumption);
        }

    }
    class Truck : Vehicle
    {
        private int Cargo_weight_limit;
        public Truck(string vm1, int rn1,int  vs,int fc1,int fcons1,int cwl) : base(vm1, rn1, vs,fc1, fcons1)
        {
          
            Cargo_weight_limit = cwl;   
        }
        public override void display()
        {
            base.display();
            Console.WriteLine(Cargo_weight_limit);
        }

    }
    class Bus : Vehicle
    {

    }
}
