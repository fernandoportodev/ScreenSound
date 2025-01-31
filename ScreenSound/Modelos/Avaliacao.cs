namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public int Nota { get; }
    
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public static Avaliacao Parse(string nota)
    {
        return new Avaliacao(int.Parse(nota));
    }
}
