## Sending Newsletters
### Challenge
Write a C# function that searches JSON payload for a specific property.

**Input**
- String value (list of subscribers)

**Output**
- List of integer values (id property of any subscribers that do not have an email)

#### Criteria
- Fast data access
- Read-only
- No serialization needed

Example
"Subscribers" : [
  {
    "Name": "Jack Powell",
    "ID": 231,
    "Email": "jspowello@hplussport.com"
  },
  {
    "Name": "Emily Garcia",
    "ID": 221,
  }
]

Output will be {221}