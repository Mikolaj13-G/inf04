int[] wagi = new int[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
char SprawdzPlec(int[] pesel)
{
    if (pesel[9] % 2 == 0)
    {
        return 'K';
    }
     
    return 'M';
    
}
bool SprawdzSumeKontrolna(int[] pesel)
{
    int S = 0;
    for (int i = 0; i < wagi.Length; i++)
    {
        S += pesel[i] * wagi[i];
    }
    int M = S % 10;
    int R;

    if (M == 0)
    {
        R = 0;
    }
    else
    {
        R = 10 - M;
    }
    if (R == pesel[10])
    {
        return true;
    }
    return false;
}

Console.WriteLine("Wpisz pesel: ");
string peselString = Console.ReadLine();
int[] peselInts = new int[11];
for (int i = 0; i<11; i++ )
{

    peselInts[i] = peselString[i]-'0';
}
char plec = SprawdzPlec(peselInts);
if(plec == 'K')
{
    Console.WriteLine("Kobieta");
}
else
{
    Console.WriteLine("Mężczyzna");
}
bool czyZgodny = SprawdzSumeKontrolna(peselInts);
if (czyZgodny)
{

    Console.WriteLine("Zgodny");

}
else
{
    Console.WriteLine("Nie zgodny");
}