namespace ConsoleApp1
{
    public class Conta
    {
        public int NumeroDaConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta(int NumeroDaConta, string Nome, double Saldo)
        {
            this.NumeroDaConta = NumeroDaConta;
            this.Nome = Nome;
            this.Saldo = Saldo;
        }
    }

}
