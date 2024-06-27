Carro c1 = new Carro();

Moto m1 = new Moto();

// Criação de array.
// int[] notas = new int [5];


// Acessando e imprimindo as notas dos alunos .
// notas[0] = 90;
// notas[1] = 85;
// notas[2] = 86;
// notas[3] = 92;
// notas[4] = 95;

// for(int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Notas do aluno : { i + 1}: {notas[i]}.");
// }

List<Veiculo> veiculos = new List<Veiculo>();

veiculos.Add(c1);
veiculos.Add(m1);

// veiculos.Remove(c1);

foreach(var veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibeVelocidade();
    veiculo.Frear();
    veiculo.ExibeVelocidade();
}