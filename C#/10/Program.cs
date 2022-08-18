// Given a string made up of letters a, b, and/or c, switch the position of letters a and b 
//(change a to b and vice versa). Leave any incidence of c untouched.
//Example:
//'acb' --> 'bca'
//'aabacbaa' --> 'bbabcabb'
string Switcheroo(string x)
{
    /*string result = String.Empty;
    for (int i = 0; i < x.Length; i++)
    {
        switch (x[i])
        {
            case 'a':
                result = result + 'b';
                break;
            case 'b':
                result = result + 'a';
                break;
            default:
                result = result + x[i];
                break;
        }
    }
    return result;*/
    return  x.Replace("a","B").Replace("b","a").ToLower(); //(что меняем, на что меняем)
    
    //return x.Replace("a","d").Replace("b","a").Replace("d","b");
}
Console.WriteLine(Switcheroo("abc"));
