namespace POO
{
    public class Animal
    {
        private string nome = "Flokitinho";
        private string raca = "Calopsita";

        public void Comer()
        {
            Console.WriteLine("O animal está comendo");
        }

        public void DadosAnimal()
        {
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Raça: {this.raca}");
        }
    }

    //Classe cachorro herda todos atributos e métodos da classe animal
    public class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine("O cachorro esta latindo");
        }
    }
}
