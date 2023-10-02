public class TShirt : ClothingItem, IState
{
    public string? TShirtStyle { get; set; }

    public TShirt(string itemName, int itemPrice, string itemStyle, string itemState, StreetwearBrand? ItemBrand)
    {
        ClothingItemName = itemName;
        ClothingItemPrice = itemPrice;
        if (itemStyle == "Long Sleeve" || itemStyle == "Short Sleeve" || itemStyle == "Sleeveless" || itemStyle == "Oversized")
        {
            TShirtStyle = itemStyle;
        }
        else
        {
            Console.WriteLine("The style of the T-Shirt \"{0}\" is not valid", ClothingItemName);
            TShirtStyle = null;
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
            ItemBrand.AddTShirt(this);
        }

    }

    public void ChangeState(string newState)
    {
        ClothingItemState = newState;
    }

    public void PrintState()
    {
        Console.WriteLine("The state of the TShirt \"{0}\" is: {1}", ClothingItemName, ClothingItemState);
    }

    public void BuyItem() { 
        Console.WriteLine("The TShirt \"{0}\" was bought", ClothingItemName);
    }
}