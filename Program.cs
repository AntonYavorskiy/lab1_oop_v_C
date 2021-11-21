using System;

namespace lab1_incaps
{


    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 1 ~~~ Вариант 5 ~~~ Выполнил Яворский Антон");
            Console.WriteLine("****************************************************************");

            treugolnik tr1 = new treugolnik(3 , 1 , 3);
            Console.WriteLine(tr1.GetInfo());
            Console.WriteLine("Периметр  = " + tr1.Perimetr());
            Console.WriteLine("Площадь = " + tr1.Ploshad());
            Console.WriteLine("СР.ЗНАЧ Периметра = " + tr1.Perimetr()/3);

            Console.WriteLine("--------");

            treugolnik tr2 = new treugolnik(4, 5, 6);
            Console.WriteLine(tr2.GetInfo());
            Console.WriteLine("Периметр  = " + tr2.Perimetr());
            Console.WriteLine("Площадь = " + tr2.Ploshad());
            Console.WriteLine("СР.ЗНАЧ Периметра = " + tr2.Perimetr() / 3);

            Console.WriteLine("--------");

            treugolnik tr3 = new treugolnik(2, 1, 2);
            Console.WriteLine(tr3.GetInfo());
            Console.WriteLine("Периметр  = " + tr3.Perimetr());
            Console.WriteLine("Площадь  = " + tr3.Ploshad());
            Console.WriteLine("СР.ЗНАЧ Периметра = " + tr3.Perimetr() / 3);

            Console.WriteLine("--------");

            if (tr1.Ploshad() > tr2.Ploshad() & tr1.Ploshad() > tr3.Ploshad()) Console.WriteLine("Макс. Площадь = " + tr1.Ploshad());
            if (tr2.Ploshad() > tr1.Ploshad() & tr2.Ploshad() > tr3.Ploshad()) Console.WriteLine("Макс. Площадь = " + tr2.Ploshad());
            if (tr3.Ploshad() > tr2.Ploshad() & tr3.Ploshad() > tr1.Ploshad()) Console.WriteLine("Макс. Площадь = " + tr3.Ploshad());

            Console.WriteLine("СР. ЗНАЧ. Периметра ВСЕХ треугольников = " + (tr1.Perimetr() + tr2.Perimetr() + tr3.Perimetr()) / 3);


            Console.ReadKey();

        }
    }

    class treugolnik
    {
       
        private double a;
        private double b;
        private double c;

        public treugolnik(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
     

        public double Perimetr()
        {
            return a + b + c;
        }

        public double Ploshad()
        {
            double hp = (a + b + c) / 2;
            return Math.Sqrt(hp * (hp - a) * (hp - b) * (hp - c));
            
        }



        public string GetInfo()
        {
            
            return $" Треугольник со сторонами {a} {b} {c}";
        }

     

        

    }
 
}
