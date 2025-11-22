
Console.WriteLine("Hello, World!");   
Console.Write("Welcome to C# 14.0 features demonstration.");
Console.WriteLine(" Let's explore some new features!");

//Değişken tanımlama ve atama
int number = 40;
string message = "C# 14.0 is awesome!";
double pi = 3.14159;
bool isLearning = true;

var val = 100;
var text = "Learning C# 14.0";
//dynamic 

Console.WriteLine($"Number: {number}\n, Message: {message}\n, Pi: {pi}\n, Is Learning: {isLearning} , val : {val} , Text : {text}" );

Console.WriteLine(number.GetType());
Console.WriteLine(message.GetType());


//Tip dönüşümü
int intNumber = 100;
double doubleNumber = intNumber;
Console.WriteLine($"Converted int to double: {doubleNumber}");
Console.WriteLine(doubleNumber.GetType());

double valDouble = 92.255;
int valInt = Convert.ToInt32(valDouble);
Console.WriteLine($"Converted double to int: {valInt}");

//Operatörler
/*
 + => Toplama
 - => Çıkarma
 * => Çarpma
 /  => Bölme
 % => Mod alma
 */

int a = 17;
int b = 5;

Console.WriteLine("======Operatörler=========");

Console.WriteLine($"Toplama: {a + b}");
Console.WriteLine($"Çıkarma: {a - b}");
Console.WriteLine($"Çarpma: {a * b}");
Console.WriteLine($"Bölme: {a / b}");
Console.WriteLine($"Mod Alma: {a % b}");


int x = 10;

x += 5;// x = x + 5
Console.WriteLine(x);
x -= 3;// x = x - 3
Console.WriteLine(x);
x *= 2;// x = x * 2
Console.WriteLine(x);
x /= 4;// x = x / 4
Console.WriteLine(x);
x %= 3;// x = x % 3
Console.WriteLine(x);

//Karşılaştırma operatörleri
/*
== => Eşit mi
!= => Eşit değil mi
>  => Büyük mü
<  => Küçük mü
>= => Büyük eşit mi
<= => Küçük eşit mi
 */

int val1 = 25;
int val2 = 30;

Console.WriteLine("======Karşılaştırma Operatörleri=========");
Console.WriteLine($"Eşit mi: {val1 == val2}");
Console.WriteLine($"Eşit değil mi: {val1 != val2}");
Console.WriteLine($"Büyük mü: {val1 > val2}");
Console.WriteLine($"Küçük mü: {val1 < val2}");
Console.WriteLine($"Büyük eşit mi: {val1 >= val2}");
Console.WriteLine($"Küçük eşit mi: {val1 <= val2}");

//Mantıksal operatörler
/*
 and operatörü: &&
 or operatörü: ||
 */

bool condition1 = true;
bool condition2 = false;

Console.WriteLine("======Mantıksal Operatörler=========");
Console.WriteLine($"AND Operatörü: {condition1 && condition2}");

Console.WriteLine($"OR Operatörü: {condition1 || condition2}");

//Kullanıcıdan veri alma
Console.WriteLine("Lütfen bir sayi giriniz:");
var str = Convert.ToInt32(Console.ReadLine());


