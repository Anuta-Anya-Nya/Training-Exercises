// You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
/*
Implement the function which takes an array containing the names of people that like an item. 
It must return the display text as shown in the examples:

[]                                -->  "no one likes this"
["Peter"]                         -->  "Peter likes this"
["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this" */

string Likes(string[] name)
{
    string result = "";
    if (name.Length == 0)
    {
        result = "no one likes this";
    }
    else if (name.Length == 1)
    {
        result = name[0] + " likes this";
    }
    else if (name.Length == 2)
    {
        result = name[0] + " and " + name[1] + " likes this";
    }
    else if (name.Length == 3)
    {
        result = name[0] + ", " + name[1] + " and " + name[2] + " likes this";
    }
    else
    {
        result = name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
    }
    return result;
}
string[] names = { "Alex", "Jacob" };
Console.WriteLine(Likes(names));


/*
public static string Likes(params string[] users)
  {
    switch (users.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{users[0]} likes this";
                case 2:
                    return $"{users[0]} and {users[1]} like this";
                case 3:
                    return $"{users[0]}, {users[1]} and {users[2]} like this";
                default:
                    return $"{users[0]}, {users[1]} and {users.Length - 2} others like this";
            }
  }
  или 
   public static string Likes(string[] name)
    {
        string[] pattern = { "no one likes this", "{0} likes this", "{0} and {1} like this", "{0}, {1} and {2} like this", "{0}, {1} and {2} others like this" };

        return name.Length < 4 ? string.Format(pattern[name.Length], name) : string.Format(pattern[4], name[0], name[1], name.Length - 2);
    }
*/