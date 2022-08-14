// ПРи введении количества лепестков, необходимо узнать какую фразу нагадает ромашка
void howMuchILoveYou(int nbPetals) {
    switch (nbPetals%6)
    {
        case 1: Console.WriteLine("I love you");
        break;
        case 2: Console.WriteLine("a little");
        break;
        case 3: Console.WriteLine("a lot");
        break;
        case 4: Console.WriteLine("passionately");
        break;
        case 5: Console.WriteLine("madly");
        break;
        case 0: Console.WriteLine("not at all");
        break;    
    }
}
howMuchILoveYou(7);
howMuchILoveYou(10);
// решение 2
string howMuchILoveYou2(int nbPetals) 
{
    string[] phrases = { "I love you", "a little", "a lot", "passionately", "madly", "not at all"};
    return phrases[(nbPetals-1) % phrases.Length]; // return new string[] {"I love you", "a little", "a lot", "passionately", "madly", "not at all"}[(nb_petals - 1) % 6];

}
Console.WriteLine(howMuchILoveYou2(7));
Console.WriteLine(howMuchILoveYou2(10));
