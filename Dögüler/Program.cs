//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");

// For Döngüsü
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hello, World!");
}

// While Döngüsü
int counter = 0;
while (counter < 5 )
{
    Console.WriteLine("C# Atolye");
    counter++;
}

// Do-While Döngüsü
int counter2 = 0;
do
{
    Console.WriteLine("Do-While Döngüsü");
    counter2++;
}while (counter2 < 5);

// Örnek: Do-While döngüsünün en az bir kez çalıştığını gösteren örnek
int counter3 = 10;
do
{
    Console.WriteLine("Do-While Döngüsü");
    counter2++;
} while (counter3 < 5);


// Foreach Döngüsü
string str = "Dögüler";
foreach (char ch in str)
{
    Console.WriteLine(ch);
}

Console.WriteLine("Çarpım Tablosu:");

for (int i = 0; i <= 10; i++)
{
    for(int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}

Console.WriteLine("Break Örneği:");

for (int i = 0; i < 5; i++)
{
    if(i ==3)
    {
        break; // Döngüyü sonlandırır
    }
    Console.WriteLine(i);
}

Console.WriteLine("Continue Örneği:");

for (int i = 0; i < 5; i++)
{
    if (i == 3)
    {
        continue; // O anki iterasyonu atlar
    }
    Console.WriteLine(i);
}

//Asala Sayı Bulma 

Console.WriteLine("Asal Sayı Programı...");

//Console.WriteLine("Bir Sayi Giriniz:");
//int number = Convert.ToInt32(Console.ReadLine());
//bool isPrime = true;

//for (int i = 2; i < number; i++)
//{
//    if (number % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}

//if (isPrime)
//{
//    Console.WriteLine("Girdiğiniz Sayi Asaldır.");
//}
//else
//{
//    Console.WriteLine("Girdiğiniz Sayi Asal Değildir.");
//}




//while (true)
//{
//    Console.WriteLine("Bir Sayi Giriniz:");
//    int number = Convert.ToInt32(Console.ReadLine());
//    if (number == 0)
//    {
//        break;
//    }
//    bool isPrime = true;

//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.WriteLine("Girdiğiniz Sayi Asaldır.");
//    }
//    else
//    {
//        Console.WriteLine("Girdiğiniz Sayi Asal Değildir.");
//    }


//}





Console.WriteLine("Bir Sayi Giriniz:");
int number = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;

if(number < 2)
{
    Console.WriteLine("Girdiğiniz Sayi Asal Değildir.");
    return;
}
else
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine("Girdiğiniz Sayi Asaldır.");
    }
    else
    {
        Console.WriteLine("Girdiğiniz Sayi Asal Değildir.");
    }
}


//Diziler ve Koleksiyonlar
int[] ints = {1,2,3,4};
string[] strings = {"C#","Java","Python"};
foreach (var item in ints)
{
    Console.WriteLine(item);
}
foreach (var item in strings)
{
    Console.WriteLine(item);
}
