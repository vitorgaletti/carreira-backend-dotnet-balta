namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {

            var pagamento = new Pagamento();

            Console.WriteLine("Hello World");
        }
    }

    public class Pagamento
    {
        protected DateTime Vencimento;

        protected void Pagar()
        {

        }
    }

}
