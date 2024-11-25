using CA24112503;

Auto a01 = new("XYZ-123", "Peugeto", "206", 60, 8.5F);
//Auto a02 = new("ASD-012");
//Auto a03 = new(1234);

Console.WriteLine(a01);

a01.TulajokRogzitese(
    "Végh Béla",
    "Martin Ralph Lauren",
    "Ice Wallow Come",
    "Lakatos Dzsenáró");

Console.WriteLine(a01.TulajdonosokListaja);

//Console.WriteLine(a02);
//Console.WriteLine(a03);
