//-----------------------Classes, atributos e métodos-----------------------

//Cria um novo objeto do tipo referencial do tipo Pessoa com uma nova instancia
using POO;

Pessoa pessoa = new();

//Recebendo os valores para os atributos da objeto pessoa
//pessoa.nome = Console.ReadLine();
pessoa.idade = 24;

//Atribuindo valores para os atributos do objeto diretamente
pessoa.nome = "Júlia";
pessoa.idade = 19;

//Acessando o método da classe pessoa
pessoa.Apresentar();

//-----------------------Encapsulamento-----------------------
ContaBancaria contaBancaria = new();
contaBancaria.Depositar(1000);
contaBancaria.Sacar(500);
Console.WriteLine($"R${contaBancaria.ConsultarSaldo()}");

//-----------------------Herança-----------------------
Cachorro cachorro = new ();
cachorro.Comer();
cachorro.Latir();
cachorro.DadosAnimal();

//-----------------------Polimorfismo-----------------------
Forma forma = new Circulo();
forma.Desenha();

//-----------------------Abstração-----------------------
Funcionario funcionario = new Gerente();
funcionario.CalcularSalario();



