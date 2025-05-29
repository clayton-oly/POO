namespace POO
{
    public abstract class Funcionario
    {
        public string nome;
        public abstract void CalcularSalario();
    }

    public class Gerente : Funcionario
    {
        public override void CalcularSalario()
        {
            Console.WriteLine("Sálario do gerente: R$5000");
        }
    }
}
