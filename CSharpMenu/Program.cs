public class Menu
{
    private string _nomePiatto;
    private decimal _costoPiatto;
    private static List<Menu> _piattoScelto = new List<Menu>();

    public string NomePiatto
    {
        get
        {
            return _nomePiatto;
        }
        set
        {
            _nomePiatto = value;
        }
    }
    public decimal CostoPiatto
    {
        get
        {
            return _costoPiatto;
        }
        set
        {
            _costoPiatto = value;
        }
    }
    public static List<Menu> PiattoScelto
    {
        get
        {
            return _piattoScelto;
        }
        set
        {
            _piattoScelto = value;
        }
    }

    public Menu(string nomepiatto, decimal costo)
    {
        this._nomePiatto = nomepiatto;
        this._costoPiatto = costo;
    }

    public static void ScriviContoFinale()
    {
        decimal contoFinale = 0;
        decimal servizio = 3;

        Console.WriteLine("======Il tuo conto:======");
        Console.WriteLine("PIATTI SCELTI");
        foreach (Menu m in Menu.PiattoScelto)
        {
            Console.WriteLine($"{m.NomePiatto} - € {m.CostoPiatto}");
            contoFinale += m.CostoPiatto;
        }
        Console.WriteLine($"Servizio: {servizio}");
        Console.WriteLine($"Totale Conto: {(contoFinale + servizio)}");
        Console.WriteLine("Grazie per averci scelto!");
        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ScriviMenu();
    }

    public static void ScriviMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("==============MENU===============");
        Console.WriteLine("1:  Coca Cola 150 ml (€ 2.50)");
        Console.WriteLine("2:  Insalata di pollo (€ 5.20)");
        Console.WriteLine("3:  Pizza Margherita (€ 10.00)");
        Console.WriteLine("4:  Pizza 4 Formaggi (€ 12.50)");
        Console.WriteLine("5:  Pz patatine fritte (€ 3.50)");
        Console.WriteLine("6:  Insalata di riso (€ 8.00)");
        Console.WriteLine("7:  Frutta di stagione (€ 5.00)");
        Console.WriteLine("8:  Pizza fritta (€ 6.80)");
        Console.WriteLine("9:  Piadina vegetariana (€ 6.00)");
        Console.WriteLine("10: Panino Hamburger (€ 7.90)");
        Console.WriteLine("11: Stampa conto finale e conferma");
        Console.WriteLine("==============MENU===============");

        var scelta = Console.ReadLine();
        switch (scelta)
        {
            case "1":
                Menu m = new Menu("Coca Cola", (decimal)2.50);
                Menu.PiattoScelto.Add(m);
                ScriviMenu();
                break;
            case "2":
                Menu m1 = new Menu("Insalata di pollo", (decimal)5.20);
                Menu.PiattoScelto.Add(m1);
                ScriviMenu();
                break;
            case "3":
                Menu m2 = new Menu("Pizza Margherita", (decimal)10.00);
                Menu.PiattoScelto.Add(m2);
                ScriviMenu();
                break;
            case "4":
                Menu m3 = new Menu("Pizza 4 formaggi", (decimal)12.20);
                Menu.PiattoScelto.Add(m3);
                ScriviMenu();
                break;
            case "5":
                Menu m4 = new Menu("Patatine Fritte", (decimal)3.50);
                Menu.PiattoScelto.Add(m4);
                ScriviMenu();
                break;
            case "6":
                Menu m5 = new Menu("Insalata di riso", (decimal)8.00);
                Menu.PiattoScelto.Add(m5);
                ScriviMenu();
                break;
            case "7":
                Menu m6 = new Menu("Frutta di stagione", (decimal)5.00);
                Menu.PiattoScelto.Add(m6);
                ScriviMenu();
                break;
            case "8":
                Menu m7 = new Menu("Pizza fritta", (decimal)6.50);
                Menu.PiattoScelto.Add(m7);
                ScriviMenu();
                break;
            case "9":
                Menu m8 = new Menu("Piadina vegetariana", (decimal)6.00);
                Menu.PiattoScelto.Add(m8);
                ScriviMenu();
                break;
            case "10":
                Menu m9 = new Menu("Hamburger", (decimal)7.90);
                Menu.PiattoScelto.Add(m9);
                ScriviMenu();
                break;
            case "11":
                Menu.ScriviContoFinale();
                break;
        }
    }

}