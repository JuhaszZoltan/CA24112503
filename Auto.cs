namespace CA24112503;

internal class Auto
{
    private List<Ember> tulajdonosok = [];

    public string Rendszam { get; set; }
    public string Gyarto { get; set; }
    public string Modell { get; set; }
    public int Teljesitmeny { get; set; }
    public float Fogyasztas { get; set; }

    public void TulajokRogzitese(params string[] tulajdonosok)
    {
        foreach (var tulaj in tulajdonosok)
        {
            this.tulajdonosok.Add(new Ember(tulaj));
        }
    }

    public string TulajdonosokListaja =>
        string.Join('\n', this.tulajdonosok);

    public override string ToString() =>
        $"[{Rendszam}] {Gyarto} {Modell} ({Teljesitmeny} hp, {Fogyasztas} l/100km)";

    //DRY = Don't Repeat Yourself!

    /// <summary>
    /// részletesen meg kell adni azt autó adatait
    /// </summary>
    /// <param name="rendszam">az autó rendszáma</param>
    /// <param name="gyarto">az autót gyártó cég</param>
    /// <param name="modell">az autómodell megnevezése</param>
    /// <param name="teljesitmeny">a teljesítmény lóerőben</param>
    /// <param name="fogyasztas">fogyasztás lirben 100km-en</param>
    public Auto(string rendszam, string gyarto, string modell, int teljesitmeny, float fogyasztas, params string[] tulajok)
    {
        Rendszam = rendszam;
        Gyarto = gyarto;
        Modell = modell;
        Teljesitmeny = teljesitmeny;
        Fogyasztas = fogyasztas;

        foreach (var tulaj in tulajok)
        {
            this.tulajdonosok.Add(new Ember(tulaj));
        }
    }


    /// <summary>
    /// Ez a konstruktor egy 250hp-s, 6.7-es fogyasztású Ford Focust fog inicializálni. 
    /// </summary>
    /// <param name="rendszam">az autó rendszáma</param>
    public Auto(string rendszam) : this(rendszam, "Ford", "Focus", 250, 6.7F) { }

    public Auto(int randomSeed)
    {
        Random rnd = new(randomSeed);
        Rendszam = $"{(char)rnd.Next(65, 91)}{(char)rnd.Next(65, 91)}{(char)rnd.Next(65, 91)}-{rnd.Next(100, 1000)}";

        string[] gyartok = ["Ford", "Peugeto", "Audi"];
        Gyarto = gyartok[rnd.Next(gyartok.Length)];

        string[] modellek = ["Bubu", "Ruru", "Bika"];
        Modell = modellek[rnd.Next(modellek.Length)];

        Teljesitmeny = rnd.Next(80, 300);

        Fogyasztas = rnd.Next(50, 100) / 10F;

    }
}
