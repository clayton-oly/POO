namespace POO
{
    public class ContaBancaria
    {
        //Atributo privado acesso apenas na própria classe
        private double saldo;

        //método público void (sem retorno), acesso em qualquer classe da aplicação
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        //método público void(sem retorno), acesso em qualquer classe da aplicação
        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
        }

        //método público com retorno de um atributo privado, pode ser acessado em qualquer classe da aplicação
        public double ConsultarSaldo()
        {
            return saldo;
        }
    }
}
