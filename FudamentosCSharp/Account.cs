namespace FudamentosCSharp
{
    internal class Account
    {
        private int balance { get; set; }

        public Account(int balance)
        {
            this.balance = balance;
        }

        public int getBalance()
        {
            return this.balance;
        }

        public string withdraw(int value)
        {
            this.balance -= value;
            return $"Tu nuevo saldo es de {this.balance}";
        }

        public string deposit(int value)
        {
            this.balance += value;
            return $"Tu nuevo saldo es de {this.balance}";
        }

        public string transfer(int value, Person persona)
        {
            persona.deposit(value);
            this.balance -= value;

            return $"Transferencia realizada de {value} a {persona.getName()}";
        }

    }
}
