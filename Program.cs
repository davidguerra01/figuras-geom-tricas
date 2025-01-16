using System;

namespace FigurasGeometricas
{
    // Clase base para figuras geométricas
    abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    // Clase Cuadrado
    class Cuadrado : Figura
    {
        private double lado;

        // Constructor
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Cálculo del área
        public override double CalcularArea()
        {
            return lado * lado; // Área = lado^2
        }

        // Cálculo del perímetro
        public override double CalcularPerimetro()
        {
            return 4 * lado; // Perímetro = 4 * lado
        }
    }

    // Clase Triángulo
    class Triangulo : Figura
    {
        private double baseTriangulo;
        private double altura;
        private double lado1, lado2, lado3;

        // Constructor
        public Triangulo(double baseTriangulo, double altura, double lado1, double lado2, double lado3)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        // Cálculo del área
        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2; // Área = (base * altura) / 2
        }

        // Cálculo del perímetro
        public override double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3; // Perímetro = lado1 + lado2 + lado3
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalcularCuadrado();
                        break;
                    case 2:
                        CalcularTriangulo();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresione cualquier tecla para regresar al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 3);

            Console.WriteLine("Programa finalizado. ¡Gracias por usar el sistema!");
        }

        // Función para mostrar el menú
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("==== MENÚ DE FIGURAS GEOMÉTRICAS ====");
            Console.WriteLine("1. Calcular área y perímetro de un cuadrado");
            Console.WriteLine("2. Calcular área y perímetro de un triángulo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
        }

        // Función para calcular el área y perímetro de un cuadrado
        static void CalcularCuadrado()
        {
            Console.Clear();
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(lado);

            // Mostrar resultados
            Console.WriteLine($"\nÁrea del cuadrado: {cuadrado.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro():F2}");
        }

        // Función para calcular el área y perímetro de un triángulo
        static void CalcularTriangulo()
        {
            Console.Clear();
            Console.Write("Ingrese la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el lado 1 del triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el lado 2 del triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el lado 3 del triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(baseTriangulo, altura, lado1, lado2, lado3);

            // Mostrar resultados
            Console.WriteLine($"\nÁrea del triángulo: {triangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.CalcularPerimetro():F2}");
        }
    }
}
