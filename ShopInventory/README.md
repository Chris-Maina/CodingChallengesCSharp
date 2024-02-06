## Shop inventory
### Challenge
Add an indexer to an existing class to access its Dictionary property.

**Input**
- Integer value(dictonary key)

**Output**
- String value(dictonary value)

#### Criteria
Throw an error when an item does not exist or has not been assigned, or if the user tries to add a duplicate item.
Handle errors in the Main program when using the indexer.

Example
shop[0] = "Milk";
shop[1] = "Eggs";
shop[2] = "Cereal";
var item = shop[1];

shop[0] = "Milk";
shop[1] = "Eggs";
shop[2] = "Eggs";
Duplicates cannot be added;

shop[0] = "Milk";
shop[1] = "Eggs";
shop[2] = "Cereal";
var item = shop[4];
Item does not exist or had not been assigned.

