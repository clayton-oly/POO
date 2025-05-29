namespace POO
{
    public class Forma
    {
        public virtual void Desenha()
        {
            Console.WriteLine("Desenhando uma forma genérica");
        }
    }

    public class Circulo : Forma
    {
        public override void Desenha()
        {
            Console.WriteLine("Desenhando um circulo");
        }
    }
}
