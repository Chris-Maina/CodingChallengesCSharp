using System.Reflection;

namespace cardealership
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hit ENTER to find the vehicles you're looking for!");
      Console.ReadKey();
      
      var cars = GetModels(typeof(Car));
      foreach (var car in cars)
      {
        Console.WriteLine(car.Name);
      }

      Console.ReadKey();
    }

    public static List<Type> GetModels(Type abstractClass)
    {
      Type[] allTypes = Assembly.GetAssembly(abstractClass)!.GetTypes();
      IEnumerable<Type> filteredTypes = allTypes.Where(type => !type.IsAbstract && abstractClass.IsAssignableFrom(type));

      return filteredTypes.ToList();
    }
  }
}
