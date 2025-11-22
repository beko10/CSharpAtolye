/*
 Karar yappıları (conditional statements) programlamada belirli koşullara göre farklı işlemler yapmamızı sağlar.
*/

int sayi = 10;

{
    int scopeVal = 20;
    Console.WriteLine(scopeVal);
}
//Console.WriteLine(scopeVal); => Hata verir çünkü scopeVal değişkeni sadece yukarıdaki blok içinde geçerlidir.

Console.WriteLine(sayi);

Console.WriteLine("==========If-Else Yapısı==========");

Console.WriteLine("Program Başladı...");
int age = 16;

if(age >= 18)
{
    Console.WriteLine("Reşitsiniz.");
}
else
{
    Console.WriteLine("Reşit değilsiniz.");
}

Console.WriteLine("Program Bitti...");

Console.WriteLine("==========Not Değerlendirme==========");
Console.WriteLine("Program Başladı...");
int not = 85;

if (not >= 90)
{
    Console.WriteLine("Notunuz: A");
}
else if (not >= 80)
{
    Console.WriteLine("Notunuz: B");
}
else if (not >= 70)
{
    Console.WriteLine("Notunuz: C");
}
else if (not >= 60)
{
    Console.WriteLine("Notunuz: D");
}
else
{
    Console.WriteLine("Notunuz: F");
}

Console.WriteLine("Program Bitti...");

//int not = 85;

//if (not >= 90)
//{
//    Console.WriteLine("Notunuz: A");
//    return;
//}
//if (not >= 80)
//{
//    Console.WriteLine("Notunuz: B");
//    return;
//}
//if (not >= 70)
//{
//    Console.WriteLine("Notunuz: C");
//    return;
//}
//if (not >= 60)
//{
//    Console.WriteLine("Notunuz: D");
//    return;
//}

//Console.WriteLine("Program Bitti...");

//Switch-Case Yapısı
int gun = 8;

switch (gun)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2: 
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;

    default:
        Console.WriteLine("Geçersiz gün numarası.");
        break;
}