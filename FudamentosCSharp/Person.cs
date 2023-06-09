namespace FudamentosCSharp
{
    internal class Person
    {
            private string name;
            private int age;
            private string nacionality;
            private Account account { get; set; }

            public Person(string name, int age, string nacionality, Account account)
            {
                this.name = name;
                this.age = age;
                this.nacionality = nacionality;
                this.account = account;
            }

            public string getName()
            {
                return this.name;
            }

            public int getAge()
            {
                return this.age;
            }

            public string getNacionality()
            {
                return this.nacionality;
            }

            public string setName(string name)
            {
                this.name = name;
                return "Cambio exitoso";
            }

            public string setAge(int age)
            {
                this.age = age;
                return "Cambio exitoso";
            }

            public string setNacionality(string nacionality)
            {
                this.nacionality = nacionality;
                return "Cambio exitoso";
            }

            public void getInfo()
            {
                Console.WriteLine($"\nNombre: {name} \nEdad: {age} años \nPais: {nacionality} \nSaldo: {account.getBalance()}");
            }

            public void transfer(int value, Person persona)
            {
                Console.WriteLine(account.transfer(value, persona));
            }

            public void deposit(int value)
            {
                Console.WriteLine(account.deposit(value));
            }

            public void withdraw(int value)
            {
                Console.WriteLine(account.withdraw(value));
            }

        
    }
}
