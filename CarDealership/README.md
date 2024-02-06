## Car dealership
### Challenge
Write a C# function that can find all concrete classes that inherit from a given abstract class.

**Input**
- Type value (abstract class type)

**Output**
- List of types (all concerete classes excluding the abstract)

**Example**
public abstract class Car;
public class Sedan : Car {}
public class Sport : Car {}

GetModels(typeof(Car));
{Sedan, Sport}