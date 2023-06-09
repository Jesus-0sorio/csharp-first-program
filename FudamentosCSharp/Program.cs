// See https://aka.ms/new-console-template for more information

using FudamentosCSharp;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----------  Mi primer programa en C#  -----------\n");

        List<Person> users = new List<Person>();

        const string opcion = @"
Opciones:
1. Crear un usuario
2. Listar los usuarios existentes
3. Finalizar el programa
        ";



        while (true)
        {
            Console.WriteLine(opcion);
            try
            {
                int selectOpcion = Convert.ToInt32(Console.ReadLine());

                switch (selectOpcion)
                {
                    case 1:
                        addUser(
            users);
                        break;
                    case 2:
                        users.ForEach(user =>
                        {
                            Console.WriteLine($"\nLa posicion del usuario es: {users.IndexOf(user) + 1}");
                            user.getInfo();
                        });
                        break;
                    case 3:
                        Console.WriteLine("Adios");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Escoga un opcion valida");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Eliga alguna de las opciones validas");
            }



        }

        
        static void addUser(List<Person> users)
        {
            string name;
            int age;
            string nacionality;

            Console.WriteLine("\nIngresa tu nombre: ");
            name = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");

            while (true)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Solo se aceptan numeros positivos");
                    }
                }
                catch
                {
                    Console.WriteLine("Solo se aceptan numero");
                }
            }

            Console.WriteLine("Ingresa tu pais de nacimiento: ");

            nacionality = Console.ReadLine();

            var cuenta = new Account(1000);

            var persona = new Person(name, age, nacionality, cuenta);

            persona.getInfo();
            users.Add(persona);
        }
    }

}