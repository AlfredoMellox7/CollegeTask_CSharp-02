public class Carro : Veiculo
{
    public override void Acelerar()         // Carro e mot são elementos do tipo veículo .
    {
        velocidade = velocidade + 10;
        Console.WriteLine("Carro acelerou .");
    }

    public override void Frear()
    {
        velocidade = velocidade - 5;
        Console.WriteLine("Carro freiou .");
    }
}