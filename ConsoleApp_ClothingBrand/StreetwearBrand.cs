using System;

public class StreetwearBrand
{
    public string BrandName { get; set; }
    public int BrandYearEstablished { get; set; }
    private int BrandValue { get; set; }

    private int BrandNumberOfWorkers { get; set; }

    public List<Hoodie> Hoodies { get; } = new List<Hoodie>();

    public List<TShirt> TShirts { get; } = new List<TShirt>();


    public StreetwearBrand() { }

    public StreetwearBrand(string brandName, int brandYearEstablished, int brandValue, int brandNumberOfWorkers)
    {
        BrandName = brandName;
        BrandYearEstablished = brandYearEstablished;
        BrandValue = brandValue;
        BrandNumberOfWorkers = brandNumberOfWorkers;
    }


    public void PrintBrand()
    {
        Console.WriteLine("The clothing brand \"{0}\" was established {1}., its value is estimated to be {2} $ ", BrandName, BrandYearEstablished, BrandValue);
    }

    public void CalculateBrandValuePerWorker()
    {
        Console.WriteLine("The clothing brand \"{0}\" has {1} workers, and its value per worker is {2} $ ", BrandName, BrandNumberOfWorkers, (float)BrandValue / BrandNumberOfWorkers);
    }

    public void AddHoodie(Hoodie hoodie)
    {
        Hoodies.Add(hoodie);
    }

    public void AddTShirt(TShirt tShirt)
    {
        TShirts.Add(tShirt);
    }

    public void PrintHoodies()
    {
        foreach (var hoodie in Hoodies)
        {
            Console.WriteLine(hoodie.ClothingItemName);
        }
    }

    public void PrintTShirts()
    {
        foreach (var tShirt in TShirts)
        {
            Console.WriteLine(tShirt.ClothingItemName);
        }
    }

    public void PrintInventory()
    {
        Dictionary<string, string> inventory = new Dictionary<string, string>();
        foreach (var hoodie in Hoodies)
        {

            inventory.Add(hoodie.ClothingItemName, hoodie.ClothingItemState);
        }
        foreach (var tShirt in TShirts)
        {
            inventory.Add(tShirt.ClothingItemName, tShirt.ClothingItemState);
        }

        //print out dictionary

        foreach (var kvp in inventory)
        {
            
            Console.WriteLine("({0},{1})", kvp.Key, kvp.Value);
            
        }


    }


}