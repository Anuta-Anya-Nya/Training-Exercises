/*
Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.

Examples
"4556364607935616" --> "############5616"
     "64607935616" -->      "#######5616"
               "1" -->                "1"
                "" -->                 ""

// "What was the name of your first pet?"

"Skippy" --> "##ippy"

"Nananananananananananananananana Batman!"
-->
"####################################man!"
*/
string Maskify(string cc)
  {
    string result = "";
    if (cc.Length<=4){
      result = cc;
    }
    else 
    {
      for (int i=0; i<cc.Length-4; i++)
    {
        result = result + "#";
    }
    for (int i=cc.Length-4; i<cc.Length;i++)
    {
        result = result + cc[i];
    }
    }
    
    return result;
  }

string text = "987654321";
Console. WriteLine(Maskify(text));
