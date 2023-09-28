namespace KTInterfase
{

    interface IAnimal
    {
        string Name { get; set; }
        void MakeSound();
    }

    // Класс Dog, реализующий интерфейс IAnimal
    class Dog : IAnimal
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("The dog " + Name + " says Woof!");
        }
    }

    // Класс Cat, реализующий интерфейс IAnimal
    class Cat : IAnimal
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("The cat " + Name + " says Meow!");
        }
    }

    // Интерфейс IShape
    interface IShape
    {
        double Area { get; }
        double Perimeter { get; }
    }

    // Класс Circle, реализующий интерфейс IShape
    class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public double Perimeter => 2 * Math.PI * Radius;
    }

    // Класс Rectangle, реализующий интерфейс IShape
    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width;

        public double Perimeter => 2 * (Length + Width);
    }

    // Класс Triangle, реализующий интерфейс IShape
    class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double Area
        {
            get
            {
                double s = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
            }
        }

        public double Perimeter => Side1 + Side2 + Side3;
    }

    // Интерфейс IComparable<T>
    interface IComparable<T>
    {
        int CompareTo(T other);
    }

    // Класс Student, реализующий интерфейс IComparable<Student>
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public int CompareTo(Student other)
        {
            return this.Grade - other.Grade;
        }
    }

    // Класс Book, реализующий интерфейс IComparable<Book>
    class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public int CompareTo(Book other)
        {
            return Price.CompareTo(other.Price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dog dog = new Dog { Name = "Buddy" };
                Cat cat = new Cat { Name = "Whiskers" };
                dog.MakeSound(); 
                cat.MakeSound(); 

                Circle circle = new Circle { Radius = 5 };
                Rectangle rectangle = new Rectangle { Length = 4, Width = 6 };
                Triangle triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };

                Console.WriteLine("Circle area: " + circle.Area);           
                Console.WriteLine("Circle perimeter: " + circle.Perimeter);

                Console.WriteLine("Rectangle area: " + rectangle.Area);           
                Console.WriteLine("Rectangle perimeter: " + rectangle.Perimeter); 

                Console.WriteLine("Triangle area: " + triangle.Area);         
                Console.WriteLine("Triangle perimeter: " + triangle.Perimeter);

                Student student1 = new Student { Name = "Alice", Age = 18, Grade = 85 };
                Student student2 = new Student { Name = "Bob", Age = 19, Grade = 75 };
                Book book1 = new Book { Title = "Harry Potter", Author = "J.K. Rowling", Price = 10.99 };
                Book book2 = new Book { Title = "Lord of the Rings", Author = "J.R.R. Tolkien", Price = 9.99 };

                Console.WriteLine("Student comparison: " + student1.CompareTo(student2)); 
                Console.WriteLine("Book comparison: " + book1.CompareTo(book2));        


                Console.ReadLine();
            }
            catch(Exception ex) 
            {
              Console.WriteLine(ex.Message);
            }
        } 
    } 
}
