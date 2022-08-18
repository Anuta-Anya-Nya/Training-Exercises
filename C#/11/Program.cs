// you are given a string of space separated numbers, and have to return the highest and lowest number.
// Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
string HighAndLow(string numbers)
{
// int[] arr = numbers.Split(' ').Select(Int32.Parse).ToArray(); // массив чисел из строки

string[] arr = numbers.Split(' '); // массив строк
int max = Convert.ToInt32(arr[0]);
int min = Convert.ToInt32(arr[0]);
for (int i=1; i<arr.Length; i++)
{
    if (max < Convert.ToInt32(arr[i])) 
    {
        max = Convert.ToInt32(arr[i]);  
    }
    if (min > Convert.ToInt32(arr[i]))
    {
        min = Convert.ToInt32(arr[i]);  
    }
}
return $"{max} {min}";
}
Console.WriteLine(HighAndLow("5 0 8 45 12 -1 100"));

string HighAndLow2(string numbers)
  {
    var listnums = numbers.Split(' ').Select(int.Parse); //коллекция 
    return string.Format("{0} {1}", listnums.Max(), listnums.Min());
  }
