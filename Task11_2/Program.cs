namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[]
                {
                new Bird(200),
                new Airplane(11000,300),
                };

            foreach (var flyable in flyables)
            {
                flyable.Fly();
            }

            Console.ReadLine();
        }
    }

    //Интерфейс
    public interface IFlyable
    {
        //Автосвойство
        int MaxAltitude { get; }

        //Метод
        public void Fly();
    }

    //Новый класс птица с реализацией интерфейса
    public class Bird : IFlyable
    {
        public int MaxAltitude { get; }

        public Bird(int _MaxAltitude)
        {
            MaxAltitude = _MaxAltitude;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }

    //Новый класс самолет с реализацией интерфейса
    public class Airplane : IFlyable
    {
        public int CountPassengers { get; }
        public int MaxAltitude { get; }

        //Конструктор
        public Airplane(int _MaxAltitude, int _CountPassengers)
        {
            MaxAltitude= _MaxAltitude;
            CountPassengers= _CountPassengers;
        }

        //Реалицазия метода
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }

}
