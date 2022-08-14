Console.Clear(); 
Console.CursorVisible = false; 
 
int x = 3, y = 3; 
while (true) 
{ 
  var key = Console.ReadKey().Key; 
  if (key == ConsoleKey.A) { x--; } 
  if (key == ConsoleKey.D) { x++; } 
  if (key == ConsoleKey.W) { y--; } 
  if (key == ConsoleKey.S) { y++; } 
  Console.Clear(); 
  Console.SetCursorPosition(x, y); 
  Console.WriteLine("+"); 
 
}