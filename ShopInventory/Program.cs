namespace shopinventory
{
  class MainClass
  {
    private static Shop _shop = new Shop();

    public static void Main()
    {
      Console.WriteLine("Add your inventory items");

      for (int index = 0; index < 3; index++)
      {
        var item = Console.ReadLine();
        if (!string.IsNullOrEmpty(item))
          AddItem(index, item);
      }

      Console.WriteLine("Retrieve all stored items:");
      GetAllItems();
    }

    public static void AddItem(int index, string name)
    {
      try
      {
        _shop[index] = name;
      }
      catch (System.Exception e)
      {
        
        Console.WriteLine(e.Message);
      }
      
    }

    public static void GetAllItems()
    {
      for (int index = 0; index < 5; index++)
      {
        try
        {
          Console.WriteLine(_shop[index]);
        }
        catch (System.Exception e)
        {
          Console.WriteLine(e.Message);
        }
        
      }
    }
  }
}
