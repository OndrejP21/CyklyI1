// While cyklus => používáme, když neznáme počet opakování, ale máme podmínku pro opakování

int y = 0;
while (y < 10)
{
    Console.WriteLine(++y);
}

Console.WriteLine("Zadej číslo, které je větší než 10");
int number = 0;
while (!int.TryParse(Console.ReadLine(), out number) || number <= 10)
{
    Console.WriteLine("Zadal jsi neplatné číslo, zadej, prosím, znovu!");
}

Console.WriteLine("Zadej jakýkoliv text, který vypíšeme po znacích!");
string text = Console.ReadLine();

// Výpis jednotlivých znaků pomocí for cyklu
for (int i = 0; i < text.Length; i++)
{
    // AHOJ => ["A", "H", "O", "J"];
    char a = text[i];
    Console.WriteLine($"{i + 1}. {a}");
}

Console.WriteLine("Výpis pomocí foreach");
foreach (char c in text)
{
    Console.WriteLine(c);
}

Console.ReadKey();

Console.WriteLine("Ahoj, já jsem papoušek a zopakuji po Tobě cokoliv, kolikrát budeš chtít!");
Console.WriteLine("Zadej text pro zopakování!");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Nic jsi nezadal!");
    Console.ReadKey();
    return;
}

Console.WriteLine("Zadej počet opakování!");
int count = 0;
if (!int.TryParse(Console.ReadLine(), out count))
{
    Console.WriteLine("Zadej jsi neplatné číslo!");
    Console.ReadKey();
    return;
}

// For cyklus => opakuje, pokud známe počet opakování!
for (int i = 0; i < count; i++)
{
    Console.WriteLine(input);
}

Console.ReadKey();