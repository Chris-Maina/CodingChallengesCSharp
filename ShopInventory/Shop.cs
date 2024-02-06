namespace shopinventory
{
  public class Shop
  {
    private Dictionary<int, string> _inventory = new Dictionary<int, string>();

    public string this[int index]
    {
      get {
        string name;
        // check it index is out of range
        if (!_inventory.TryGetValue(index, out name))
          throw new ArgumentOutOfRangeException(nameof(index), "Item does not exist or had not been assigned.");
        return name;
      }
      set {
        // check it value exists
        if (_inventory.ContainsValue(value))
          throw new ArgumentException("Duplicates cannot be added");
        _inventory[index] = value;
      }
    }
  }
}