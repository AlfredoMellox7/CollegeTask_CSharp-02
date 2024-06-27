public abstract class Veiculo{       //Serve de base, não deve ser implementada.
    protected int velocidade;

    public abstract void Acelerar();

    public abstract void Frear();

    public void ExibeVelocidade()
    {
        Console.WriteLine($"Velocidade : {velocidade}.\n"); // Abstrato existe não tem implementação e
    }                                                     // obrigam os outros a implementá-lo .

}                                                         // Array em csharp = Coleção de elementos fixos do mesmo tipo .