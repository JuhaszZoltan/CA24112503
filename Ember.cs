namespace CA24112503;

internal class Ember
{
    public Guid Guid { get; set; }
    public string Nev { get; set; }

    public override string ToString() =>
        $"{Nev} ({Guid})";

    public Ember(string nev)
    {
        Guid = Guid.NewGuid();
        Nev = nev;
    }
}
