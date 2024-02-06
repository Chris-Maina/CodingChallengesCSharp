## Movie night
### Challenge
Write a C# function that adds a unique description to a class's **ToString** method.

Input
- No input
Output
- String value

#### Criteria
The custom description needs to print out the movie's **title**, **rating** and **review score**, If the movie's review score is higher than **75**, the description also needs to mention that the movie is "certified fresh."

Example
var mobius - new Movie("Morbius", "PG-13", 17)
 - Morbius
    Rated PG-13
    17% on RT

var batman - new Movie("The Batman", "PG-13", 85)
 - The Batman
    Rated PG-13
    85% on RT - Certified Fresh!