public class Moto : Veiculo
{
    public override void Acelerar()     // Carro e mot são elementos do tipo veículo .
    {
        velocidade += 15;
        Console.WriteLine("Moto acelerou .\n");
    }

    public override void Frear()
    {
        velocidade -=10;
        Console.WriteLine("Carro freiou .\n");
    }
}