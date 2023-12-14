
List<Animal> animals = new List<Animal>()
{
new Cow(){IsMale=true,Weight=250,BirthDate=new DateTime(2022,10,05),},
new Sheep(){IsMale = false, Weight = 100,BirthDate=new DateTime(2021,09,05)},
 new Sheep(){IsMale = false, Weight = 100,BirthDate=new DateTime(2021,09,05),},
};


foreach (Animal animal in animals)
{
    Console.WriteLine(animal);
}




class HealthParameter<T>
{
    public string Name { get; set; }
    public T Current { get; set; }
    public  T Standard { get; set; }
    public double Alpha { get; set; }
    public virtual double StressFactor() =>
           (Convert.ToDouble(Current) / Convert.ToDouble(Standard)) * Alpha;



}


    public class Environment
    {
        public HealthParameter TDS { get; set; }

        public HealthParameter Temperature { get; set; }

        public HealthParameter Density { get; set; }

        public HealthParameter db { get; set; }

        public HealthParameter AQI { get; set; }

        public HealthParameter OX { get; set; }

        public DateTime Date { get; set; }
    }



public class CowParameter 
{
    public HealthParameter   TimeToStand { get; set; }

    public HealthParameter TimeToDie { get; set; }

    public HealthParameter TimeToRelax { get; set; }

    public HealthParameter NumberOfMeals { get; set; }

    public HealthParameter NumberOfMilkProduction { get; set; }

    public DateTime Date { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}
public class SheepParameter
{
    public HealthParameter TimeToStand { get; set; }

    public HealthParameter TimeToDie { get; set; }

    public HealthParameter TimeToRelax { get; set; }

    public HealthParameter NumberOfMeals { get; set; }

    public HealthParameter NumberOfMilkProduction { get; set; }

    public DateTime Date { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}


