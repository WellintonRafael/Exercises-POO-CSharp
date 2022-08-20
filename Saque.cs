namespace ConsoleApp1
{
    public class Saque
    {
        public Conta contaSaida { get; }
        public double valorSaque { get; }
        public Saque(Conta contaSaida, double valorSaque)
        {
            this.contaSaida = contaSaida;
            this.valorSaque = valorSaque;
        }
        public void Sacar()
        {
            if (valorSaque > contaSaida.Saldo)
            {
                Console.WriteLine("Saldo insuficiente seu pobre!");
            }
            else
            {
                contaSaida.Saldo -= valorSaque;
                Console.WriteLine("Novo saldo da sua conta: {0}.", contaSaida.Saldo);
            }
        }

    }
}
