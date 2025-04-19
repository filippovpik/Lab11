namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создние массива с объектами
            Animal[] animals = new Animal[]
            {
            new Dog(),
            new Cat()
            };

            //Использование полиморфизма
            foreach (var animal in animals)
            {
                animal.ShowInfo();
            }

            Console.ReadLine();
        }
    }

    //Абстрактный класс
    public abstract class Animal
    {
        //Абстрактное свойство
        public abstract string Name { get; }

        //Абстрактный метод
        public abstract void Say();

        //Неабстрактный метод
        public void ShowInfo()
        {
            Console.WriteLine($"Имя:{Name}");
            Say();
        }
    }

    public class Dog : Animal
    {
        public override string Name => "Собака";

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }

    public class Cat : Animal
    {
        public override string Name => "Кошка";

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}



