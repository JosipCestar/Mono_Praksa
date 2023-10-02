

public class Hoodie : ClothingItem, IState
{
    public string HoodieStyle { get; set; }

    public Hoodie(string itemName, int itemPrice, string itemStyle, string itemState, StreetwearBrand? ItemBrand)
    {
        ClothingItemName = itemName;
        ClothingItemPrice = itemPrice;
        if (itemStyle == "Zipped" || itemStyle == "No hoodie")
        {
            HoodieStyle = itemStyle;
        }
        else
        {
            Console.WriteLine("The style of the Hoodie \"{0}\" is not valid", ClothingItemName);
            HoodieStyle = null;
        }


        if (itemState == "In Stock" || itemState == "Last One" || itemState == "Sold Out")
        {
            ClothingItemState = itemState;
        }
        else
        {
            Console.WriteLine("The state of the T-Shirt \"{0}\" is not valid", ClothingItemName);
            ClothingItemState = null;
        }

        if (ItemBrand == null)
        {
            Console.WriteLine("The T-Shirt \"{0}\" is not made by any brand", ClothingItemName);
        }
        else
        {
            StreetwearBrandReference = ItemBrand;
            ItemBrand.AddHoodie(this);
        }

    }


    public void ChangeState(string newState)
    {
        ClothingItemState = newState;
    }

    public void PrintState()
    {
        Console.WriteLine("The state of the Hoodie \"{0}\" is: {1}", ClothingItemName, ClothingItemState);
    }

    public void BuyItem() { 
        Console.WriteLine("The Hoodie \"{0}\" was bought", ClothingItemName);
    }
}
