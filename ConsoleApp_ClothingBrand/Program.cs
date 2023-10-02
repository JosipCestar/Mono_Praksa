using System;
using System.Net;




class Program
{
    static void Main()
     {
        StreetwearBrand brandA = new StreetwearBrand("BrandA", 2015, 500000, 25);
        StreetwearBrand brandB = new StreetwearBrand("BrandB", 2008, 1200000, 40);
        StreetwearBrand brandC = new StreetwearBrand("BrandC", 2020, 300000, 15);

        Hoodie hoodie1 = new Hoodie("Cool Hoodie", 50, "Zipped", "In Stock", brandA);
        Hoodie hoodie2 = new Hoodie("Stylish Hoodie", 65, "Zipped", "Last One", brandB);
        Hoodie hoodie3 = new Hoodie("Comfy Hoodie", 45, "No hoodie", "In Stock", brandC);
        Hoodie hoodie4 = new Hoodie("Grey Hoodie", 50, "Zipped", "Last One", brandA);
        Hoodie hoodie5 = new Hoodie("Blue Hoodie", 70, "Zipped", "Sold Out", brandB);
        Hoodie hoodie6 = new Hoodie("Red Hoodie", 30, "No hoodie", "In Stock", brandC);

        TShirt tshirt1 = new TShirt("BlueT", 30, "Long Sleeve", "In Stock", brandA);
        TShirt tshirt2 = new TShirt("Redt", 32, "Short Sleeve", "Sold Out", brandB);
        TShirt tshirt3 = new TShirt("Greent", 35, "Short Sleeve", "Last One", brandC);
        TShirt tshirt4 = new TShirt("less", 38, "Sleeveless", "In Stock", brandA);
        TShirt tshirt5 = new TShirt("Loeve", 37, "Long Sleeve", "In Stock", brandB);
        TShirt tshirt6 = new TShirt("Shorve", 31, "Short Sleeve", "In Stock", brandC);

        Console.WriteLine("Welcome To The Webshop");

        MainMenu:

        Console.WriteLine("Press:");
        Console.WriteLine("1. Costumer");
        Console.WriteLine("2. Manager");
        Console.WriteLine("Please enter 1 or 2");

        int choice1 = int.Parse(Console.ReadLine());

        if (choice1==1) {
            Console.WriteLine("Search up inventory");
            Console.WriteLine("1.BrandA");
            Console.WriteLine("2.BrandB");
            Console.WriteLine("3.BrandC");
            Console.WriteLine("4.Back to main menu");
            int choice2 = int.Parse(Console.ReadLine());

            switch (choice2) {
                case 1:
                    brandA.PrintInventory();
                    Console.WriteLine("Pick 1 for hoodies 2 for tshirts");
                    int choice3 = int.Parse(Console.ReadLine());
                    switch (choice3) {
                        case 1:
                            brandA.PrintHoodies();
                            Console.WriteLine("Pick hoodie");
                            int choice4 = int.Parse(Console.ReadLine());
                            brandA.Hoodies[choice4-1].BuyItem();
                            break;
                        case 2:
                            brandA.PrintTShirts();
                            Console.WriteLine("Pick tshirt");
                            int choice5 = int.Parse(Console.ReadLine());
                            brandA.TShirts[choice5-1].BuyItem();
                            break;
                        case 3:
                            goto MainMenu;
                    };
                    break;
                case 2:
                    brandB.PrintInventory();
                    Console.WriteLine("Pick 1 for hoodies 2 for tshirts");
                    int choice6 = int.Parse(Console.ReadLine());
                    switch (choice6)
                    {
                        case 1:
                            brandB.PrintHoodies();
                            Console.WriteLine("Pick hoodie");
                            int choice7 = int.Parse(Console.ReadLine());
                            brandB.Hoodies[choice7-1].BuyItem();
                            goto MainMenu;
                        case 2:
                            brandB.PrintTShirts();
                            Console.WriteLine("Pick tshirt");
                            int choice8 = int.Parse(Console.ReadLine());
                            brandB.TShirts[choice8-1].BuyItem();
                            goto MainMenu;
                        case 3:
                            goto MainMenu;
                    };  
                    break;
                case 3:
                    brandC.PrintInventory();
                    Console.WriteLine("Pick 1 for hoodies 2 for tshirts");
                    int choice9 = int.Parse(Console.ReadLine());
                    switch (choice9)
                    {
                        case 1:
                            brandC.PrintHoodies();
                            Console.WriteLine("Pick hoodie");
                            int choice10 = int.Parse(Console.ReadLine());
                            brandC.Hoodies[choice10-1].BuyItem();
                            goto MainMenu;
                        case 2:
                            brandC.PrintTShirts();
                            Console.WriteLine("Pick tshirt");
                            int choice11 = int.Parse(Console.ReadLine());
                            brandC.TShirts[choice11-1].BuyItem();
                            goto MainMenu;
                        case 3:
                            goto MainMenu;

                    };
                    break;
                case 4:
                    goto MainMenu;
            
            };
        }
        else
        {
            Console.WriteLine("Please choose brand for description");
            Console.WriteLine("Please choose a brand to see its products");
            Console.WriteLine("1. BrandA");
            Console.WriteLine("2. BrandB");
            Console.WriteLine("3. BrandC");
            Console.WriteLine("Please enter a number from 1 to 3");

            int choice2 = int.Parse(Console.ReadLine());



            switch (choice2)
            {
                case (1):
                    brandA.PrintBrand();
                    goto MainMenu;
                    break;
                case (2):
                    brandB.PrintBrand();
                    goto MainMenu;
                    break;
                case (3):
                    brandC.PrintBrand();
                    goto MainMenu;
                    break;

            }
        }
        Console.ReadKey();
     }
}