using System;


public abstract class ClothingItem
{

    public string ClothingItemName { get; set; }

    public int ClothingItemPrice { get; set; }

    public string? ClothingItemState { get; set; }

    protected StreetwearBrand? StreetwearBrandReference { get; set; }


    public void PrintClothingDetails()
    {
        if (StreetwearBrandReference == null)
        {
            Console.WriteLine("The clothing item \"{0}\" is not made by any brand", ClothingItemName);

        }
        else
        {
            Console.WriteLine("The clothing item \"{0}\" is made by {1} ", ClothingItemName, StreetwearBrandReference.BrandName);
        }
    }
}