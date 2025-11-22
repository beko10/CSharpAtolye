# C# Eğitim Rehberi - GENİŞLETİLMİŞ TAM SÜRÜM

## Programcılığa Giriş ve C# Temelleri

Bu kapsamlı C# eğitim rehberi, programlamaya yeni başlayanlardan orta seviye geliştiricilere kadar geniş bir kitleye hitap eden, detaylı ve pratik odaklı bir kaynak olarak hazırlanmıştır. C# dilinin temel yapı taşlarından ileri seviye konulara kadar geniş bir yelpazede bilgi sunmaktadır.

### 📚 Doküman İçeriği
- **Temel C# Konuları**: Değişkenler, veri tipleri, operatörler
- **Kontrol Yapıları**: Koşullu ifadeler, döngüler
- **Veri Yapıları**: Diziler, string işlemleri, collections
- **Metotlar ve Fonksiyonlar**: Metot tanımlama, parametreler, overloading
- **Gelişmiş Konular**: DateTime, Math, Exception Handling
- **Algoritma Soruları**: 80+ pratik problem çözümü
- **3 Saatlik Eğitim Planı**: Hızlandırılmış öğrenme programı

### 🎯 Öğrenme Hedefleri
Bu rehberi tamamladığınızda:
1. C# dilinde temel programlama becerilerini kazanacaksınız
2. Gerçek dünya problemlerini çözebilecek algoritma yeteneği geliştireceksiniz
3. Temel nesne yönelimli programlama kavramlarını anlayacaksınız
4. 80+ algoritma sorusuyla pratik deneyim kazanacaksınız
5. Profesyonel yazılım geliştirme için sağlam bir temel oluşturacaksınız

---

## İÇİNDEKİLER

### 1. Giriş ve Temel Bilgiler
- [1.1 C# ve .NET Nedir?](#11-c-ve-net-nedir)
- [1.2 Visual Studio Kurulumu](#12-visual-studio-kurulumu)
- [1.3 İlk C# Projesi](#13-ilk-c-projesi)

### 2. Veri Tipleri ve Değişkenler
- [2.1 Değişken Kavramı](#21-değişken-kavramı)
- [2.2 Temel Veri Tipleri](#22-temel-veri-tipleri)
- [2.3 Tür Dönüşümleri](#23-tür-dönüşümleri)
- [2.4 Değişken Kapsamı (Scope)](#24-değişken-kapsamı-scope)
- [2.5 Const ve Readonly](#25-const-ve-readonly)

### 3. Operatörler
- [3.1 Aritmetik Operatörler](#31-aritmetik-operatörler)
- [3.2 Atama Operatörleri](#32-atama-operatörleri)
- [3.3 Karşılaştırma Operatörleri](#33-karşılaştırma-operatörleri)
- [3.4 Mantıksal Operatörler](#34-mantıksal-operatörler)
- [3.5 Diğer Operatörler](#35-diğer-operatörler)

### 4. Kontrol Yapıları
- [4.1 If-Else Koşullu İfadeleri](#41-if-else-koşullu-ifadeleri)
- [4.2 Switch-Case Yapısı](#42-switch-case-yapısı)
- [4.3 Döngüler (Loops)](#43-döngüler-loops)
- [4.4 Break ve Continue](#44-break-ve-continue)

### 5. String İşlemleri
- [5.1 Temel String Operasyonları](#51-temel-string-operasyonları)
- [5.2 Gelişmiş String Metotları](#52-gelişmiş-string-metotları)
- [5.3 String Formatlama](#53-string-formatlama)
- [5.4 Regex (Regular Expressions)](#54-regex-regular-expressions)

### 6. Diziler ve Metotlar
- [6.1 Dizi (Array) Kullanımı](#61-dizi-array-kullanımı)
- [6.2 Çok Boyutlu Diziler](#62-çok-boyutlu-diziler)
- [6.3 Dizi Metotları](#63-dizi-metotları)
- [6.4 Metot (Method) Tanımlama](#64-metot-method-tanımlama)
- [6.5 Metot Parametreleri](#65-metot-parametreleri)
- [6.6 Metot Overloading](#66-metot-overloading)
- [6.7 Recursion (Özyineleme)](#67-recursion-öz-yineleme)

### 7. Ek Konular
- [7.1 DateTime Kullanımı](#71-datetime-kullanımı)
- [7.2 Math Sınıfı Metotları](#72-math-sınıfı-metotları)
- [7.3 Exception Handling](#73-exception-handling)
- [7.4 Collections Giriş](#74-collections-giriş)

### 8. Algoritma Soruları ve Çözümler
- [8.1 Başlangıç Seviyesi (30 Soru)](#81-başlangıç-seviyesi-30-soru)
- [8.2 Orta Seviye (30 Soru)](#82-orta-seviye-30-soru)
- [8.3 İleri Seviye (20 Soru)](#83-ileri-seviye-20-soru)


---

## 1. GİRİŞ VE TEMEL BİLGİLER

### 1.1 C# ve .NET Nedir?

C# (pronounced "C Sharp"), Microsoft tarafından geliştirilen modern, nesne yönelimli bir programlama dilidir. .NET platformu üzerinde çalışır ve Windows uygulamaları, web uygulamaları, mobil uygulamalar ve oyunlar geliştirmek için kullanılır.

#### C#'ın Özellikleri:
- **Nesne Yönelimli**: Her şey bir sınıf (class) içinde tanımlanır
- **Tip Güvenliği**: Değişkenlerin tipleri derleme zamanında kontrol edilir
- **Modern Söz Dizimi**: Diğer dillerden alınan en iyi özellikler
- **Zengin Kütüphane**: Hazır sınıflar ve metotlar
- **Cross-Platform**: .NET Core ile Linux ve Mac'te de çalışır

#### .NET Platformu:
.NET, C# kodunun çalıştığı sanal makinedir. Ana bileşenleri:
- **CLR (Common Language Runtime)**: Kodu yöneten motor
- **BCL (Base Class Library)**: Hazır sınıf kütüphanesi
- **JIT Compiler**: C# kodunu makine koduna çeviren derleyici

### 1.2 Visual Studio Kurulumu

Visual Studio, C# ile program geliştirmek için en popüler IDE'dir (Integrated Development Environment).

#### Kurulum Adımları:
1. **visualstudio.microsoft.com** adresine gidin
2. "Visual Studio Community" (ücretsiz sürümü) indirin
3. ".NET desktop development" workload'unu seçin
4. Kurulumu başlatın ve gerekli bileşenleri yükleyin

#### Visual Studio'da Proje Oluşturma:
1. File → New → Project seçin
2. "Console App (.NET)" şablonunu seçin
3. Proje adını girin ve konumunu belirleyin
4. "Create" butonuna tıklayın

### 1.3 İlk C# Projesi

Visual Studio'yu açtıktan sonra, ilk C# programınızı oluşturalım:

```csharp
using System;

namespace MerhabaDunya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya!");
            Console.WriteLine("İlk C# programım.");
        }
    }
}
```

#### Kod Açıklaması:
- `using System;`: System kütüphanesini kullanmamızı sağlar
- `namespace MerhabaDunya`: Kodumuzu bir namespace içinde organize eder
- `class Program`: Ana program sınıfımız
- `static void Main()`: Programın başladığı ana metot
- `Console.WriteLine()`: Ekrana metin yazdırır

#### Programı Çalıştırma:
- **F5** tuşu ile debug modunda çalıştırın
- **Ctrl+F5** tuşu ile debug olmadan çalıştırın
- Veya Debug → Start Debugging menüsünü kullanın

Bu temel yapı, tüm C# programlarımızda kullanacağımız iskelettir. 

Genişletilmiş veri tipleri ve değişkenler konusuna geçmeden önce, C#'ın temel yapı taşlarını sağlam bir şekilde anlamış olmanız çok önemlidir. Değişkenler, programlamanın temel bileşenleridir ve farklı veri tiplerini anlamak, etkili programlar yazmanın anahtarıdır.

## 2. GENİŞLETİLMİŞ VERİ TİPLERİ VE DEĞİŞKENLER

### 2.1 Değişken Kavramı

Değişken, program içinde değer saklamak için kullanılan isimli bellek alanlarıdır. Her değişkenin bir tipi, adı ve değeri vardır.

#### Değişken Tanımlama:
```csharp
// Tip değişkenAdı = başlangıçDeğeri;
int yas = 25;
string isim = "Ahmet";
double maas = 3500.50;
bool aktif = true;
```

#### Değişken Adlandırma Kuralları:
- Harf, rakam ve alt çizgi (_) içerebilir
- Rakamla başlayamaz
- C#'ın anahtar kelimeleri (if, for, int vb.) kullanılamaz
- Büyük/küçük harf duyarlıdır
- Anlamlı isimler seçilmeli (yas, toplam, kullaniciAdi)

### 2.2 Temel Veri Tipleri

#### Sayısal Veri Tipleri:

**Tam Sayı Tipleri:**
```csharp
byte minDeger = 0;           // 0-255 arası (1 byte)
sbyte signedByte = -128;     // -128 ile 127 arası (1 byte)
short kisaSayi = -32768;     // -32768 ile 32767 arası (2 byte)
ushort unsignedShort = 65535; // 0-65535 arası (2 byte)
int tamsayi = -2147483648;   // -2^31 ile 2^31-1 arası (4 byte)
uint unsignedInt = 4294967295; // 0 ile 2^32-1 arası (4 byte)
long uzunSayi = -9223372036854775808; // -2^63 ile 2^63-1 arası (8 byte)
ulong unsignedLong = 18446744073709551615; // 0 ile 2^64-1 arası (8 byte)
```

**Ondalıklı Sayı Tipleri:**
```csharp
float ondalik = 3.14159f;           // Tek hassasiyet (4 byte)
double ciftHassasiyet = 3.14159265359; // Çift hassasiyet (8 byte)
decimal paraMiktari = 1234.56m;     // Mali işlemler için (16 byte)
```

#### Metin Veri Tipleri:
```csharp
char karakter = 'A';                // Tek karakter (2 byte)
string metin = "Merhaba Dünya!";    // Karakter dizisi
```

#### Mantıksal Veri Tipi:
```csharp
bool dogruVeyaYanlis = true;        // true veya false değeri alır
```

### 2.3 Tür Dönüşümleri

#### Implicit (Örtük) Dönüşüm:
Küçük tipten büyük tipe otomatik dönüşüm:
```csharp
int tamsayi = 42;
double ondalik = tamsayi;  // Otomatik dönüşüm: 42.0
long uzun = tamsayi;       // Otomatik dönüşüm: 42
```

#### Explicit (Açık) Dönüşüm:
Büyük tipten küçük tipe manuel dönüşüm (casting):
```csharp
double ondalik = 42.7;
int tamsayi = (int)ondalik;  // Manuel dönüşüm: 42 (kesme)
```

#### Convert Sınıfı ile Dönüşüm:
```csharp
string metin = "42";
int sayi = Convert.ToInt32(metin);     // String'den int'e
string sayiMetni = sayi.ToString();    // Int'den string'e

double pi = 3.14159;
int tamsayi = Convert.ToInt32(pi);     // 3 olur (yuvarlama değil!)
```

#### TryParse ile Güvenli Dönüşüm:
```csharp
string giris = "42";
if (int.TryParse(giris, out int sonuc))
{
    Console.WriteLine($"Başarılı: {sonuc}");
}
else
{
    Console.WriteLine("Dönüşüm başarısız!");
}
```

### 2.4 Değişken Kapsamı (Scope)

Değişkenlerin erişilebilir olduğu kod bölgesi. C#'ta kapsam (scope) süslü parantezler {} ile belirlenir.

```csharp
class Program
{
    // Class seviyesinde değişken (field)
    static string classSeviyesi = "Class seviyesinde";
    
    static void Main()
    {
        // Method seviyesinde değişken (local variable)
        string methodSeviyesi = "Method seviyesinde";
        
        if (true)
        {
            // If bloğu seviyesinde değişken
            string blockSeviyesi = "Block seviyesinde";
            
            // Tüm değişkenlere erişim mümkün
            Console.WriteLine(classSeviyesi);
            Console.WriteLine(methodSeviyesi);
            Console.WriteLine(blockSeviyesi);
        }
        
        // blockSeviyesi burada erişilemez (scope dışında)
        // Console.WriteLine(blockSeviyesi); // HATA!
    }
    
    static void BaskaMethod()
    {
        // methodSeviyesi burada erişilemez
        Console.WriteLine(classSeviyesi); // Hala erişilebilir
    }
}
```

### 2.5 Const ve Readonly

#### Const (Sabit):
Derleme zamanında belirlenen, değiştirilemez değerler:
```csharp
const double PI = 3.14159;
const int MAX_DEGER = 100;
const string APP_NAME = "C# Eğitim Uygulaması";

// const değişkenlerini başlangıçta tanımlanmalı
// PI = 3.14; // HATA: const değiştirilemez!
```

#### Readonly:
Çalışma zamanında belirlenen, sadece constructor'da değiştirilebilir değerler:
```csharp
class Ogrenci
{
    public readonly int OGRENCI_NO;
    public readonly string AD;
    
    public Ogrenci(int no, string ad)
    {
        OGRENCI_NO = no;   // Constructor'da değiştirilebilir
        AD = ad;
    }
    
    public void BilgiYazdir()
    {
        // OGRENCI_NO = 123; // HATA: Constructor dışında değiştirilemez!
        Console.WriteLine($"No: {OGRENCI_NO}, Ad: {AD}");
    }
}
```

Veri tipleri konusunu tamamladık. Artık operatörler dünyasına adım atarak, C#'ın hesaplama ve mantık operatörlerini detaylı bir şekilde inceleyeceğiz.

## 3. GENİŞLETİLMİŞ OPERATÖRLER

Operatörler, değişkenler ve değerler üzerinde işlem yapmamızı sağlayan özel sembollerdir.

### 3.1 Aritmetik Operatörler

Temel matematik işlemleri için kullanılır:

```csharp
int a = 10, b = 3;

int toplama = a + b;      // 13
int cikarma = a - b;      // 7
int carpma = a * b;       // 30
int bolme = a / b;        // 3 (tam bölme)
int mod = a % b;          // 1 (kalan)

Console.WriteLine($"Toplama: {a} + {b} = {toplama}");
Console.WriteLine($"Çıkarma: {a} - {b} = {cikarma}");
Console.WriteLine($"Çarpma: {a} * {b} = {carpma}");
Console.WriteLine($"Bölme: {a} / {b} = {bolme}");
Console.WriteLine($"Mod: {a} % {b} = {mod}");
```

#### Operatör Önceliği:
1. Parantez ()
2. Çarpma *, Bölme /, Mod %
3. Toplama +, Çıkarma -

```csharp
int sonuc1 = 2 + 3 * 4;        // 14 (önce 3*4, sonra 2+12)
int sonuc2 = (2 + 3) * 4;      // 20 (önce 2+3, sonra 5*4)
int sonuc3 = 10 % 3 + 2;       // 3 (önce 10%3=1, sonra 1+2)
```

### 3.2 Atama Operatörleri

Değişkenlere değer atamak için kullanılır:

```csharp
int x = 10;          // Basit atama

// Birleşik atama operatörleri
x += 5;              // x = x + 5;  (x = 15)
x -= 3;              // x = x - 3;  (x = 12)
x *= 2;              // x = x * 2;  (x = 24)
x /= 4;              // x = x / 4;  (x = 6)
x %= 4;              // x = x % 4;  (x = 2)

// Artırma ve azaltma operatörleri
x++;                 // x = x + 1;  (post-increment)
++x;                 // x = x + 1;  (pre-increment)
x--;                 // x = x - 1;  (post-decrement)
--x;                 // x = x - 1;  (pre-decrement)
```

#### Post vs Pre İncrement:
```csharp
int a = 5;
int b = a++;         // b = 5, sonra a = 6
int c = ++a;         // a = 7, sonra c = 7

Console.WriteLine($"a = {a}");  // 7
Console.WriteLine($"b = {b}");  // 5
Console.WriteLine($"c = {c}");  // 7
```

### 3.3 Karşılaştırma Operatörleri

İki değeri karşılaştırmak için kullanılır, sonucu bool (true/false) döner:

```csharp
int a = 10, b = 5;

bool esitMi = (a == b);          // false
bool esitDegilMi = (a != b);     // true
bool buyukMu = (a > b);          // true
bool kucukMu = (a < b);          // false
bool buyukEsitMi = (a >= b);     // true
bool kucukEsitMi = (a <= b);     // false

Console.WriteLine($"{a} == {b}: {esitMi}");
Console.WriteLine($"{a} != {b}: {esitDegilMi}");
Console.WriteLine($"{a} > {b}: {buyukMu}");
Console.WriteLine($"{a} < {b}: {kucukMu}");
Console.WriteLine($"{a} >= {b}: {buyukEsitMi}");
Console.WriteLine($"{a} <= {b}: {kucukEsitMi}");
```

### 3.4 Mantıksal Operatörler

Bool değerler üzerinde mantık işlemleri yapar:

```csharp
bool x = true, y = false;

bool veOperatörü = x && y;       // false (AND)
bool veyaOperatörü = x || y;     // true (OR)
bool degilOperatörü = !x;        // false (NOT)

// De Morgan kuralları
bool kural1 = !(x && y) == (!x || !y);  // true
bool kural2 = !(x || y) == (!x && !y);  // true

Console.WriteLine($"x && y: {veOperatörü}");
Console.WriteLine($"x || y: {veyaOperatörü}");
Console.WriteLine($"!x: {degilOperatörü}");
```

#### Short-Circuit Evaluation:
```csharp
bool Sonuc1 = false && Metot1(); // Metot1() çağrılmaz!
bool Sonuc2 = true || Metot2();  // Metot2() çağrılmaz!

static bool Metot1()
{
    Console.WriteLine("Metot1 çalıştı");
    return true;
}

static bool Metot2()
{
    Console.WriteLine("Metot2 çalıştı");
    return false;
}
```

### 3.5 Diğer Operatörler

#### Üçlü (Ternary) Operatör:
```csharp
// koşul ? doğruİfadesi : yanlışİfadesi
int yas = 18;
string kategori = (yas >= 18) ? "Yetişkin" : "Çocuk";

Console.WriteLine($"Kategori: {kategori}");
```

#### Null Coalescing Operatörü:
```csharp
string isim = null;
string sonuc = isim ?? "Varsayılan İsim";

Console.WriteLine(sonuc);  // "Varsayılan İsim"

// Birden fazla null kontrolü
string isim1 = null;
string isim2 = null;
string tamIsim = isim1 ?? isim2 ?? "İsim Yok";

Console.WriteLine(tamIsim);  // "İsim Yok"
```

#### sizeof Operatörü:
```csharp
Console.WriteLine($"int boyutu: {sizeof(int)} byte");  // 4
Console.WriteLine($"double boyutu: {sizeof(double)} byte"); // 8
Console.WriteLine($"char boyutu: {sizeof(char)} byte");  // 2
```

Operatörler konusunu başarıyla tamamladık. Artık koşullu ifadeler ve döngüler gibi kontrol yapılarına geçerek, programlarımızda karar verme mekanizmalarını kurmayı öğreneceğiz.

## 4. GENİŞLETİLMİŞ KONTROL YAPILARI

Kontrol yapıları, program akışını yönlendiren ve karar verme mekanizması sağlayan yapılardır.

### 4.1 If-Else Koşullu İfadeleri

#### Basit If Yapısı:
```csharp
int yas = 20;

if (yas >= 18)
{
    Console.WriteLine("Yetişkinsiniz.");
}
```

#### If-Else Yapısı:
```csharp
int yas = 16;

if (yas >= 18)
{
    Console.WriteLine("Yetişkinsiniz.");
}
else
{
    Console.WriteLine("Henüz yetişkin değilsiniz.");
}
```

#### If-Else-If Ladder:
```csharp
int not = 85;

if (not >= 90)
{
    Console.WriteLine("A+");
}
else if (not >= 80)
{
    Console.WriteLine("A");
}
else if (not >= 70)
{
    Console.WriteLine("B");
}
else if (not >= 60)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("F");
}
```

#### Nested If (İç İçe If):
```csharp
int yas = 25;
bool ogrenci = true;

if (yas >= 18)
{
    if (ogrenci)
    {
        Console.WriteLine("Öğrenci yetişkin");
    }
    else
    {
        Console.WriteLine("Çalışan yetişkin");
    }
}
else
{
    Console.WriteLine("Çocuk");
}
```

#### Mantıksal Operatörler ile Koşullar:
```csharp
int yas = 25;
double gelir = 5000;

if (yas >= 18 && gelir >= 3000)
{
    Console.WriteLine("Krediye uygun");
}
else
{
    Console.WriteLine("Krediye uygun değil");
}

if (yas < 18 || gelir < 1000)
{
    Console.WriteLine("Ek gelir desteği gerekli");
}
```

#### String Karşılaştırmaları:
```csharp
string kullaniciAdi = "admin";
string sifre = "12345";

if (kullaniciAdi == "admin" && sifre == "12345")
{
    Console.WriteLine("Giriş başarılı");
}
else
{
    Console.WriteLine("Giriş başarısız");
}

// Case-insensitive karşılaştırma
string girilenIsim = "AHMET";
if (girilenIsim.Equals("ahmet", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("İsim eşleşti");
}
```

### 4.2 Switch-Case Yapısı

#### Temel Switch-Case:
```csharp
int gun = 3;

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
        Console.WriteLine("Geçersiz gün");
        break;
}
```

#### Multiple Cases (Birden Fazla Case):
```csharp
char grade = 'B';

switch (grade)
{
    case 'A':
    case 'B':
    case 'C':
        Console.WriteLine("Başarılı");
        break;
    case 'D':
    case 'F':
        Console.WriteLine("Başarısız");
        break;
    default:
        Console.WriteLine("Geçersiz not");
        break;
}
```

#### Switch Expressions (C# 8.0+):
```csharp
char grade = 'B';
string result = grade switch
{
    'A' => "Mükemmel",
    'B' => "İyi",
    'C' => "Orta",
    'D' or 'F' => "Başarısız",
    _ => "Geçersiz not"
};

Console.WriteLine(result);
```

#### Pattern Matching in Switch:
```csharp
object value = 42;

string message = value switch
{
    int i when i > 0 => "Pozitif sayı",
    int i when i < 0 => "Negatif sayı",
    int i => "Sıfır",
    string s => $"Metin: {s}",
    null => "Null değer",
    _ => "Bilinmeyen tip"
};

Console.WriteLine(message);
```

### 4.3 Döngüler (Loops)

#### For Döngüsü:
```csharp
// Temel for döngüsü
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Döngü sayısı: {i}");
}

// Tersten sayım
for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"Sayım: {i}");
}

// İkişer artış
for (int i = 0; i <= 10; i += 2)
{
    Console.WriteLine($"Çift sayı: {i}");
}
```

#### While Döngüsü:
```csharp
int sayac = 0;

while (sayac < 5)
{
    Console.WriteLine($"Sayac: {sayac}");
    sayac++;
}

// Kullanıcı girişi ile while döngüsü
string input;
while (true)
{
    Console.Write("Çıkış için 'exit' yazın: ");
    input = Console.ReadLine();
    
    if (input == "exit")
        break;
        
    Console.WriteLine($"Girdiğiniz: {input}");
}
```

#### Do-While Döngüsü:
```csharp
int sayac = 0;

do
{
    Console.WriteLine($"Sayac: {sayac}");
    sayac++;
} while (sayac < 5);

// Kullanıcı girişi - en az bir kez çalışır
string password;
do
{
    Console.Write("Şifre girin: ");
    password = Console.ReadLine();
} while (password != "12345");

Console.WriteLine("Giriş başarılı!");
```

#### Foreach Döngüsü:
```csharp
string[] isimler = { "Ahmet", "Ayşe", "Mehmet", "Fatma" };

foreach (string isim in isimler)
{
    Console.WriteLine($"İsim: {isim}");
}

// Dizi elemanlarını toplama
int[] sayilar = { 1, 2, 3, 4, 5 };
int toplam = 0;

foreach (int sayi in sayilar)
{
    toplam += sayi;
}

Console.WriteLine($"Toplam: {toplam}");
```

#### İç İçe Döngüler:
```csharp
// Çarpım tablosu
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(); // Boş satır
}

// Yıldız piramidi
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
```

### 4.4 Break ve Continue

#### Break (Döngüyü Tamamen Bitir):
```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Döngü durduruldu!");
        break;
    }
    Console.WriteLine($"Sayı: {i}");
}
```

#### Continue (İterasyonu Atla):
```csharp
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)  // Çift sayıları atla
    {
        continue;
    }
    Console.WriteLine($"Tek sayı: {i}");
}
```

#### Break ile İç İçe Döngüler:
```csharp
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"i={i}, j={j}");
        if (i == 2 && j == 2)
        {
            Console.WriteLine("Her iki döngüyü de bitir!");
            goto etiket; // Label ile çıkış
        }
    }
}

etiket:
Console.WriteLine("Döngüler sonlandırıldı");
```

Kontrol yapıları konusunu tamamladık. Artık string işlemlerine geçerek, metin verilerle çalışma tekniklerini öğreneceğiz.

## 5. STRING İŞLEMLERİ

String sınıfı, metin verilerle çalışmak için zengin metotlar sunar.

### 5.1 Temel String Operasyonları

#### String Tanımlama:
```csharp
// Farklı string tanımlama yöntemleri
string isim = "Ahmet";
string soyisim = new string("Yılmaz");
string bosMetin = "";
string nullMetin = null;

// String interpolation (C# 6.0+)
int yas = 25;
string tamMetin = $"Merhaba, ben {isim} {soyisim}, {yas} yaşındayım.";

// String format
string formatMetin = String.Format("Merhaba, ben {0} {1}, {2} yaşındayım.", isim, soyisim, yas);

// String concatenation
string birlesikMetin = isim + " " + soyisim + " (" + yas + ")";

// String.Join ile birleştirme
string[] kelimeler = { "Merhaba", "dünya", "!" };
string birlesik = String.Join(" ", kelimeler);
```

#### String Özellikleri:
```csharp
string metin = "Merhaba Dünya";

Console.WriteLine($"Uzunluk: {metin.Length}");           // 13
Console.WriteLine($"İlk karakter: {metin[0]}");          // 'M'
Console.WriteLine($"Son karakter: {metin[metin.Length-1]}"); // 'a'

// Character indexing
for (int i = 0; i < metin.Length; i++)
{
    Console.WriteLine($"Index {i}: {metin[i]}");
}
```

### 5.2 Gelişmiş String Metotları

#### Karşılaştırma Metotları:
```csharp
string metin1 = "Merhaba";
string metin2 = "merhaba";

bool esitMi = metin1.Equals(metin2);                              // false
bool esitMiIgnoreCase = metin1.Equals(metin2, StringComparison.OrdinalIgnoreCase); // true
bool buyukMu = metin1.CompareTo(metin2);                         // Negatifse metin1 küçük
bool contains = metin1.Contains("mer");                          // false (case sensitive)

// StartsWith ve EndsWith
bool startsWith = metin1.StartsWith("Mer");                      // true
bool endsWith = metin1.EndsWith("ba");                           // true
```

#### Arama ve Bulma Metotları:
```csharp
string metin = "C# programlama dilini öğreniyorum";

int index = metin.IndexOf("programlama");       // 3
int lastIndex = metin.LastIndexOf("ö");         // 27
int notFound = metin.IndexOf("xyz");            // -1

// Belirli bir pozisyondan arama
int searchIndex = metin.IndexOf("l", 10);       // 10. pozisyondan sonra 'l' ara

// IndexOfAny - herhangi bir karakter ara
char[] aranacak = { 'a', 'e', 'ı' };
int anyIndex = metin.IndexOfAny(aranacak);      // İlk a, e veya ı'nın indexi
```

#### Düzenleme Metotları:
```csharp
string metin = "  Merhaba Dünya  ";

// Trim - baş ve sondaki boşlukları temizle
string trimmed = metin.Trim();                  // "Merhaba Dünya"

// Trim başka karakterlerle
string ozelMetin = "***Merhaba***";
string temizlenmis = ozelMetin.Trim('*');       // "Merhaba"

// ToUpper, ToLower
string buyukHarf = metin.ToUpper();             // "MERHABA DÜNYA"
string kucukHarf = metin.ToLower();             // "merhaba dünya"

// Replace
string degistirilmis = metin.Replace("Dünya", "Türkiye"); // "Merhaba Türkiye"

// Remove - belirli kısmı sil
string silinmis = metin.Remove(0, 5);           // 0. indexten itibaren 5 karakter sil

// Insert - belirli pozisyona ekle
string eklenmis = metin.Insert(8, "Güzel ");    // "Merhaba Güzel Dünya"
```

#### Alt String (Substring) İşlemleri:
```csharp
string metin = "C# programlama dilini öğreniyorum";

// Substring - alt dizi çıkarma
string ilkBes = metin.Substring(0, 5);          // "C# pr"
string belirliPozisyondan = metin.Substring(10); // "lama dilini öğreniyorum"

// Sadece baştan belirli uzunluğa kadar
if (metin.Length >= 10)
{
    string ilk10 = metin.Substring(0, Math.Min(10, metin.Length));
    Console.WriteLine($"İlk 10 karakter: {ilk10}");
}
```

### 5.3 String Formatlama

#### String.Format ile Formatlama:
```csharp
string isim = "Ahmet";
int yas = 25;
double maas = 3500.50;
DateTime tarih = DateTime.Now;

// Temel formatlama
string formatted = String.Format("İsim: {0}, Yaş: {1}, Maaş: {2:C}, Tarih: {3:dd/MM/yyyy}", 
                                 isim, yas, maas, tarih);
Console.WriteLine(formatted);

// Adlandırılmış parametrelerle
string namedFormatted = String.Format("İsim: {isim}, Yaş: {yas}, Maaş: {maas:C}");
Console.WriteLine(namedFormatted);
```

#### String Interpolation ile Formatlama:
```csharp
// Modern C# string interpolation
string interpolated = $"İsim: {isim}, Yaş: {yas}, Maaş: {maas:C}, Tarih: {tarih:dd MMMM yyyy}";
Console.WriteLine(interpolated);

// İfadeler içinde
int toplam = 10 + 15;
string hesaplama = $"10 + 15 = {toplam}";
Console.WriteLine(hesaplama);

// Format spesifikasyonları
double sayi = 1234.567;
string formatted1 = $"{sayi:F2}";        // 1234.57
string formatted2 = $"{sayi:C}";         // ₺1,234.57
string formatted3 = $"{sayi:P}";         // 123,456.70%
string formatted4 = $"{sayi:X}";         // 4D2 (hexadecimal)
```

#### Sayısal Formatlama:
```csharp
double pi = Math.PI;

// Farklı sayı formatları
string[] formats = {
    $"Pi normal: {pi}",
    $"Pi 2 ondalık: {pi:F2}",
    $"Pi bilimsel: {pi:E2}",
    $"Pi genel: {pi:G4}",
    $"Pi para birimi: {pi:C}"
};

foreach (string format in formats)
{
    Console.WriteLine(format);
}

// Tarih formatları
DateTime suAn = DateTime.Now;
string[] tarihFormats = {
    $"Kısa tarih: {suAn:d}",
    $"Uzun tarih: {suAn:D}",
    $"Kısa saat: {suAn:t}",
    $"Uzun saat: {suAn:T}",
    $"Tam tarih saat: {suAn:f}",
    $"yyyy-MM-dd HH:mm:ss: {suAn:yyyy-MM-dd HH:mm:ss}"
};

foreach (string tarihFormat in tarihFormats)
{
    Console.WriteLine(tarihFormat);
}
```

### 5.4 Regex (Regular Expressions)

#### Regex Temelleri:
```csharp
using System.Text.RegularExpressions;

string email = "kullanici@example.com";
string telefon = "+90 532 123 45 67";
string tcNo = "12345678901";

// Email kontrolü
Regex emailRegex = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
bool emailDogruMu = emailRegex.IsMatch(email);

// Telefon kontrolü
Regex telefonRegex = new Regex(@"^[\+]?[\d\s\(\)\-]+$");
bool telefonDogruMu = telefonRegex.IsMatch(telefon);

Console.WriteLine($"Email doğru: {emailDogruMu}");
Console.WriteLine($"Telefon doğru: {telefonDogruMu}");
```

#### Regex Metotları:
```csharp
string metin = "C# programlama çok güçlü bir dil. C# ile web, desktop ve mobil uygulama geliştirebiliriz.";

// Matches - tüm eşleşmeleri bul
Regex csharpRegex = new Regex("C#");
MatchCollection eşleşmeler = csharpRegex.Matches(metin);

Console.WriteLine($"C# {eşleşmeler.Count} kez geçiyor:");
foreach (Match eşleşme in eşleşmeler)
{
    Console.WriteLine($"Pozisyon: {eşleşme.Index}, Metin: {eşleşme.Value}");
}

// Replace - eşleşenleri değiştir
string degistirilmis = csharpRegex.Replace(metin, "C Sharp");
Console.WriteLine($"Değiştirilen: {degistirilmis}");

// Split - regex'e göre böl
string rakamlarMetin = "1,2,3,4,5,6,7";
string[] rakamlar = Regex.Split(rakamlarMetin, @",");
foreach (string rakam in rakamlar)
{
    Console.Write(rakam + " ");
}
Console.WriteLine();

// Escape - özel karakterleri escape et
string orijinal = @"C:\Program Files\MyApp";
string escaped = Regex.Escape(orijinal);
Console.WriteLine($"Orijinal: {orijinal}");
Console.WriteLine($"Escaped: {escaped}");
```

#### Yaygın Regex Patterns:
```csharp
// Email pattern
Regex emailPattern = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

// Türk telefon numarası pattern
Regex turkTelefonPattern = new Regex(@"^[\+]?90[\s\-]?5\d{2}[\s\-]?\d{3}[\s\-]?\d{2}[\s\-]?\d{2}$");

// Türk TC kimlik no pattern
Regex tcKimlikPattern = new Regex(@"^\d{11}$");

// IP adresi pattern
Regex ipPattern = new Regex(@"^(\d{1,3}\.){3}\d{1,3}$");

// Tarih pattern (dd/mm/yyyy)
Regex tarihPattern = new Regex(@"^\d{1,2}[\/\-]\d{1,2}[\/\-]\d{4}$");

Console.WriteLine("Regex patterns tanımlandı.");
```

String işlemleri konusunu tamamladık. Artık diziler ve metotlar konusuna geçerek, veri yapıları ve fonksiyonel programlama tekniklerini öğreneceğiz.

## 6. GENİŞLETİLMİŞ DİZİLER VE METOTLAR

Diziler aynı tipte birden fazla değeri saklamak için kullanılan veri yapılarıdır. Metotlar ise kodları organize etmek ve tekrar kullanım için kullanılan temel yapı taşlarıdır.

### 6.1 Dizi (Array) Kullanımı

#### Dizi Tanımlama ve Başlatma:
```csharp
// 1. Boş dizi tanımlama ve sonra değer atama
int[] sayilar = new int[5];
sayilar[0] = 10;
sayilar[1] = 20;
sayilar[2] = 30;
sayilar[3] = 40;
sayilar[4] = 50;

// 2. Başlangıç değerleri ile tanımlama
int[] kisaDizi = { 1, 2, 3, 4, 5 };

// 3. new anahtar kelimesi ile
string[] isimler = new string[] { "Ahmet", "Ayşe", "Mehmet" };

// 4. Farklı veri tiplerinde diziler
double[] ondalikSayilar = new double[] { 3.14, 2.71, 1.41 };
char[] karakterler = { 'a', 'b', 'c', 'd' };
bool[] dogruYanlis = { true, false, true };
```

#### Dizi Elemanlarına Erişim:
```csharp
int[] sayilar = { 10, 20, 30, 40, 50 };

// Eleman okuma
Console.WriteLine($"İlk eleman: {sayilar[0]}");    // 10
Console.WriteLine($"Son eleman: {sayilar[4]}");    // 50

// Eleman değiştirme
sayilar[2] = 35;
Console.WriteLine($"Değiştirilmiş eleman: {sayilar[2]}"); // 35

// Dizi boyutu
Console.WriteLine($"Dizi boyutu: {sayilar.Length}");      // 5

// Döngü ile elemanlara erişim
Console.WriteLine("Tüm elemanlar:");
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine($"sayilar[{i}] = {sayilar[i]}");
}

// Foreach ile elemanlara erişim
Console.WriteLine("Foreach ile:");
foreach (int sayi in sayilar)
{
    Console.Write($"{sayi} ");
}
Console.WriteLine();
```

#### Dizi Sıralama:
```csharp
int[] sayilar = { 64, 34, 25, 12, 22, 11, 90 };

Console.WriteLine("Sıralanmadan önce:");
foreach (int sayi in sayilar)
{
    Console.Write($"{sayi} ");
}

Array.Sort(sayilar);  // Küçükten büyüğe sırala

Console.WriteLine("\nSıralandıktan sonra:");
foreach (int sayi in sayilar)
{
    Console.Write($"{sayi} ");
}

// Tersten sıralama
Array.Reverse(sayilar);
Console.WriteLine("\nTersten sıralandı:");
foreach (int sayi in sayilar)
{
    Console.Write($"{sayi} ");
}
```

#### Dizi Kopyalama:
```csharp
int[] orijinal = { 1, 2, 3, 4, 5 };
int[] kopya = new int[orijinal.Length];

// 1. Array.Copy ile
Array.Copy(orijinal, kopya, orijinal.Length);

// 2. Clone ile (object döndürür, cast gerekli)
int[] kopya2 = (int[])orijinal.Clone();

// 3. foreach ile eleman eleman
int[] kopya3 = new int[orijinal.Length];
for (int i = 0; i < orijinal.Length; i++)
{
    kopya3[i] = orijinal[i];
}

Console.WriteLine("Orijinal ve kopyalar:");
Console.WriteLine($"Orijinal: {string.Join(", ", orijinal)}");
Console.WriteLine($"Kopya: {string.Join(", ", kopya)}");
Console.WriteLine($"Kopya2: {string.Join(", ", kopya2)}");
Console.WriteLine($"Kopya3: {string.Join(", ", kopya3)}");
```

### 6.2 Çok Boyutlu Diziler

#### İki Boyutlu Diziler:
```csharp
// 3x3 matris tanımlama
int[,] matris = new int[3, 3];

// Değer atama
matris[0, 0] = 1; matris[0, 1] = 2; matris[0, 2] = 3;
matris[1, 0] = 4; matris[1, 1] = 5; matris[1, 2] = 6;
matris[2, 0] = 7; matris[2, 1] = 8; matris[2, 2] = 9;

// Başlangıç değerleri ile
int[,] baslangicMatrisi = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

// İki boyutlu dizi yazdırma
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matris[i, j],2} ");
    }
    Console.WriteLine();
}

// Eleman sayıları
Console.WriteLine($"Toplam eleman: {matris.Length}");
Console.WriteLine($"1. boyut uzunluğu: {matris.GetLength(0)}");
Console.WriteLine($"2. boyut uzunluğu: {matris.GetLength(1)}");
```

#### Düzensiz Diziler (Jagged Arrays):
```csharp
// Her satırı farklı uzunlukta olabilir
int[][] duzensizDizi = new int[3][];

duzensizDizi[0] = new int[] { 1, 2, 3 };     // 3 eleman
duzensizDizi[1] = new int[] { 4, 5 };        // 2 eleman
duzensizDizi[2] = new int[] { 6, 7, 8, 9 };  // 4 eleman

// Düzensiz dizi yazdırma
for (int i = 0; i < duzensizDizi.Length; i++)
{
    Console.Write($"Satır {i}: ");
    for (int j = 0; j < duzensizDizi[i].Length; j++)
    {
        Console.Write($"{duzensizDizi[i][j]} ");
    }
    Console.WriteLine();
}
```

### 6.3 Dizi Metotları

#### Array Sınıfı Metotları:
```csharp
int[] sayilar = { 5, 2, 8, 1, 9, 3, 7 };

// Sıralama
Array.Sort(sayilar);
Console.WriteLine($"Sıralı: {string.Join(", ", sayilar)}");

// Ters çevirme
Array.Reverse(sayilar);
Console.WriteLine($"Ters çevrilmiş: {string.Join(", ", sayilar)}");

// Index bulma
int index = Array.IndexOf(sayilar, 5);
Console.WriteLine($"5'in indexi: {index}");

// Belirli koşula uyan eleman var mı?
bool hepsiPozitif = Array.TrueForAll(sayilar, x => x > 0);
Console.WriteLine($"Hepsi pozitif: {hepsiPozitif}");

// Koşula uyan elemanları bulma
int[] buyukOlanlar = Array.FindAll(sayilar, x => x > 5);
Console.WriteLine($"5'ten büyük olanlar: {string.Join(", ", buyukOlanlar)}");

// İlk uygun elemanı bul
int ilkBuyuk = Array.Find(sayilar, x => x > 5);
Console.WriteLine($"İlk 5'ten büyük: {ilkBuyuk}");
```

#### Array.ForEach ile Elemanları İşleme:
```csharp
string[] isimler = { "Ahmet", "Ayşe", "Mehmet", "Fatma" };

Console.WriteLine("İsimler:");
Array.ForEach(isimler, isim => Console.WriteLine($"Merhaba, {isim}!"));

// Dizi elemanlarını büyük harfe çevirme
Array.ForEach(isimler, isim => Console.WriteLine(isim.ToUpper()));

// Kendi action'ımızı tanımlama
Console.WriteLine("Yaş toplamı:");
int[] yaslar = { 25, 30, 35, 40 };
int toplam = 0;
Array.ForEach(yaslar, yas => {
    toplam += yas;
    Console.WriteLine($"Eklendi: {yas}, Toplam: {toplam}");
});
```

### 6.4 Metot (Method) Tanımlama

#### Temel Metot Yapısı:
```csharp
// Void metot (değer döndürmez)
static void SelamVer()
{
    Console.WriteLine("Merhaba!");
}

// Değer döndüren metot
static int IkiyleCarp(int sayi)
{
    return sayi * 2;
}

// Parametreli metot
static void KisiBilgisi(string isim, int yas)
{
    Console.WriteLine($"Ad: {isim}, Yaş: {yas}");
}

// Çoklu return değeri (tuple ile)
static (int toplam, int carpim) Hesapla(int a, int b)
{
    return (a + b, a * b);
}

// Main metot
static void Main()
{
    // Metotları çağırma
    SelamVer();
    
    int sonuc = IkiyleCarp(5);
    Console.WriteLine($"Sonuç: {sonuc}");
    
    KisiBilgisi("Ahmet", 25);
    
    var hesap = Hesapla(10, 3);
    Console.WriteLine($"Toplam: {hesap.toplam}, Çarpım: {hesap.carpim}");
}
```

#### Metot İmzası ve Overloading:
```csharp
// Aynı isimde farklı parametrelerle metotlar
static int Topla(int a, int b)
{
    Console.WriteLine("2 parametreli Topla çağrıldı");
    return a + b;
}

static int Topla(int a, int b, int c)
{
    Console.WriteLine("3 parametreli Topla çağrıldı");
    return a + b + c;
}

static double Topla(double a, double b)
{
    Console.WriteLine("Double Topla çağrıldı");
    return a + b;
}

static void Main()
{
    // Overload resolution - derleyici en uygun metotu seçer
    Console.WriteLine(Topla(5, 3));        // İkili int toplama
    Console.WriteLine(Topla(5, 3, 2));     // Üçlü int toplama
    Console.WriteLine(Topla(5.5, 3.2));    // Double toplama
}
```

### 6.5 Metot Parametreleri

#### Değer Parametreleri (By Value):
```csharp
static void DegerParametresi(int sayi)
{
    sayi = 100;  // Bu değişiklik çağıran metoda yansımaz
    Console.WriteLine($"Metot içi: {sayi}"); // 100
}

static void Main()
{
    int x = 5;
    Console.WriteLine($"Çağırmadan önce: {x}"); // 5
    DegerParametresi(x);
    Console.WriteLine($"Çağırdıktan sonra: {x}"); // 5 (değişmedi)
}
```

#### Ref Parametreleri (By Reference):
```csharp
static void RefParametresi(ref int sayi)
{
    sayi = 100;  // Bu değişiklik çağıran metoda yansıyor
    Console.WriteLine($"Metot içi: {sayi}"); // 100
}

static void Main()
{
    int x = 5;
    Console.WriteLine($"Çağırmadan önce: {x}"); // 5
    RefParametresi(ref x);
    Console.WriteLine($"Çağırdıktan sonra: {x}"); // 100 (değişti!)
}
```

#### Out Parametreleri:
```csharp
static void IkiDegerDondur(int a, int b, out int toplam, out int fark)
{
    toplam = a + b;
    fark = a - b;
}

static void Main()
{
    int x = 10, y = 5;
    IkiDegerDondur(x, y, out int sonucToplam, out int sonucFark);
    
    Console.WriteLine($"Toplam: {sonucToplam}");  // 15
    Console.WriteLine($"Fark: {sonucFark}");      // 5
}
```

#### Params Parametresi:
```csharp
static int Topla(params int[] sayilar)
{
    int toplam = 0;
    foreach (int sayi in sayilar)
    {
        toplam += sayi;
    }
    return toplam;
}

static void Main()
{
    // Farklı sayıda argümanla çağırma
    Console.WriteLine(Topla(1, 2, 3));        // 6
    Console.WriteLine(Topla(1, 2, 3, 4, 5));  // 15
    
    int[] dizi = { 10, 20, 30 };
    Console.WriteLine(Topla(dizi));          // 60
}
```

#### Named Parameters (Adlandırılmış Parametreler):
```csharp
static void KisiBilgisi(string ad, string soyad, int yas, string sehir)
{
    Console.WriteLine($"{ad} {soyad}, {yas} yaşında, {sehir}'da yaşıyor.");
}

static void Main()
{
    // Positional arguments
    KisiBilgisi("Ahmet", "Yılmaz", 25, "İstanbul");
    
    // Named arguments (sıra önemli değil)
    KisiBilgisi(soyad: "Kaya", sehir: "Ankara", ad: "Ayşe", yas: 30);
    
    // Mixed (karma) arguments
    KisiBilgisi("Mehmet", "Demir", sehir: "İzmir", yas: 28);
}
```

### 6.6 Metot Overloading

#### Overloading Kuralları:
```csharp
// 1. Farklı parametre sayısı
static void Yazdir(string mesaj) { }
static void Yazdir(string mesaj, int tekrar) { }

// 2. Farklı parametre tipleri
static int Topla(int a, int b) { return 0; }
static double Topla(double a, double b) { return 0.0; }

// 3. Farklı parametre sırası (farklı tiplerle)
static void Islem(string ad, int yas) { }
static void Islem(int yas, string ad) { }

// 4. ref/out parametrelerle overloading
static void DegerGoster(int sayi) { }
static void DegerGoster(ref int sayi) { }

// Overloading kuralları:
// - Aynı metot adı ve parametre tipleri olamaz
// - Sadece return type ile overload yapılamaz
// - ref/out ile overload yapılabilir
```

#### Gerçek Hayat Overloading Örneği:
```csharp
class HesapMakinesi
{
    // Toplama işlemi overloadları
    public int Topla(int a, int b)
    {
        Console.WriteLine("İki int toplama");
        return a + b;
    }
    
    public double Topla(double a, double b)
    {
        Console.WriteLine("İki double toplama");
        return a + b;
    }
    
    public int Topla(int[] sayilar)
    {
        Console.WriteLine("Dizi toplama");
        int toplam = 0;
        foreach (int sayi in sayilar)
            toplam += sayi;
        return toplam;
    }
    
    public string Topla(string a, string b)
    {
        Console.WriteLine("String birleştirme");
        return a + b;
    }
}

static void Main()
{
    HesapMakinesi hesap = new HesapMakinesi();
    
    Console.WriteLine(hesap.Topla(5, 3));           // 8
    Console.WriteLine(hesap.Topla(5.5, 3.2));       // 8.7
    Console.WriteLine(hesap.Topla(new int[] {1,2,3,4,5})); // 15
    Console.WriteLine(hesap.Topla("Merhaba", "Dünya")); // "MerhabaDünya"
}
```

### 6.7 Recursion (Özyineleme)

#### Temel Recursion:
```csharp
// Faktöriyel hesaplama (recursive)
static long Faktoriyel(int n)
{
    if (n <= 1)
        return 1;
    return n * Faktoriyel(n - 1);
}

// Fibonacci dizisi (recursive)
static long Fibonacci(int n)
{
    if (n <= 1)
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void Main()
{
    // Faktöriyel
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i}! = {Faktoriyel(i)}");
    }
    
    // Fibonacci
    Console.WriteLine("Fibonacci dizisi:");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{Fibonacci(i)} ");
    }
    Console.WriteLine();
}
```

#### İterative vs Recursive:
```csharp
// İterative Fibonacci
static long FibonacciIterative(int n)
{
    if (n <= 1) return n;
    
    long a = 0, b = 1;
    for (int i = 2; i <= n; i++)
    {
        long temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}

// Recursive Fibonacci (daha yavaş)
static long FibonacciRecursive(int n)
{
    if (n <= 1) return n;
    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}

static void Main()
{
    int n = 10;
    
    // Performance karşılaştırması
    DateTime start = DateTime.Now;
    long recursive = FibonacciRecursive(n);
    DateTime end = DateTime.Now;
    Console.WriteLine($"Recursive: {recursive}, Süre: {(end-start).TotalMilliseconds}ms");
    
    start = DateTime.Now;
    long iterative = FibonacciIterative(n);
    end = DateTime.Now;
    Console.WriteLine($"Iterative: {iterative}, Süre: {(end-start).TotalMilliseconds}ms");
}
```

#### Recursion ile Pratik Örnekler:
```csharp
// Array toplamı (recursive)
static int ArrayToplam(int[] dizi, int index = 0)
{
    if (index >= dizi.Length)
        return 0;
    return dizi[index] + ArrayToplam(dizi, index + 1);
}

// String ters çevirme (recursive)
static string TersCevir(string metin)
{
    if (metin.Length <= 1)
        return metin;
    return metin[metin.Length - 1] + TersCevir(metin.Substring(0, metin.Length - 1));
}

// Digit toplama
static int DigitToplam(int sayi)
{
    if (sayi == 0)
        return 0;
    return sayi % 10 + DigitToplam(sayi / 10);
}

static void Main()
{
    int[] sayilar = { 1, 2, 3, 4, 5 };
    Console.WriteLine($"Array toplamı: {ArrayToplam(sayilar)}"); // 15
    
    Console.WriteLine($"Ters çevrilmiş: {TersCevir("Merhaba")}"); // "abahreM"
    
    Console.WriteLine($"12345'in rakamları toplamı: {DigitToplam(12345)}"); // 15
}
```

Diziler ve metotlar konusunu tamamladık. Artık yeni konulara geçerek DateTime, Math sınıfı ve exception handling gibi önemli konuları öğreneceğiz.

## 7. YENİ KONULAR

### 7.1 DateTime Kullanımı

DateTime sınıfı, tarih ve saat işlemleri için kullanılır. TimeSpan ise iki tarih arasındaki farkı temsil eder.

#### Temel DateTime Kullanımı:
```csharp
// Mevcut tarih ve saat
DateTime suAn = DateTime.Now;
Console.WriteLine($"Şu anki tarih ve saat: {suAn}");

// Sadece tarih
DateTime bugun = DateTime.Today;
Console.WriteLine($"Bugün: {bugun}");

// Belirli bir tarih oluşturma
DateTime ozelTarih = new DateTime(2025, 12, 25, 15, 30, 0);
Console.WriteLine($"Özel tarih: {ozelTarih}");
```

#### DateTime Formatları:
```csharp
DateTime tarih = new DateTime(2025, 11, 22, 14, 30, 45);

Console.WriteLine($"Tam tarih: {tarih}");
Console.WriteLine($"Sadece tarih: {tarih:d}");
Console.WriteLine($"dd/MM/yyyy format: {tarih:dd/MM/yyyy}");
Console.WriteLine($"dd MMMM yyyy format: {tarih:dd MMMM yyyy}");
Console.WriteLine($"Saat: {tarih:HH:mm}");
Console.WriteLine($"Yıl: {tarih:yyyy}");
Console.WriteLine($"Günün adı: {tarih:dddd}");
Console.WriteLine($"Ayın adı: {tarih:MMMM}");

// ToString ile özel formatlar
Console.WriteLine(tarih.ToString("yyyy-MM-dd"));           // 2025-11-22
Console.WriteLine(tarih.ToString("dd MMMM yyyy"));         // 22 Kasım 2025
Console.WriteLine(tarih.ToString("dddd, dd MMMM yyyy"));   // Cumartesi, 22 Kasım 2025
```

#### DateTime Metotları:
```csharp
DateTime bugun = DateTime.Today;

Console.WriteLine($"Bugün: {bugun:dd/MM/yyyy}");
Console.WriteLine($"Yarın: {bugun.AddDays(1):dd/MM/yyyy}");
Console.WriteLine($"1 hafta sonra: {bugun.AddDays(7):dd/MM/yyyy}");
Console.WriteLine($"1 ay sonra: {bugun.AddMonths(1):dd/MM/yyyy}");
Console.WriteLine($"2 yıl önce: {bugun.AddYears(-2):dd/MM/yyyy}");

// Saat ekleme
DateTime saatliTarih = DateTime.Now;
Console.WriteLine($"2 saat sonra: {saatliTarih.AddHours(2):dd/MM/yyyy HH:mm}");
Console.WriteLine($"30 dakika sonra: {saatliTarih.AddMinutes(30):dd/MM/yyyy HH:mm}");
```

#### Yaş Hesaplama:
```csharp
Console.Write("Doğum tarihinizi girin (dd/MM/yyyy): ");
DateTime dogumTarihi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

DateTime bugun = DateTime.Today;
int yas = bugun.Year - dogumTarihi.Year;

if (bugun < dogumTarihi.AddYears(yas))
{
    yas--;
}

Console.WriteLine($"Yaşınız: {yas}");

// Detaylı yaş hesaplama
int yil = bugun.Year - dogumTarihi.Year;
int ay = bugun.Month - dogumTarihi.Month;
int gun = bugun.Day - dogumTarihi.Day;

if (gun < 0)
{
    ay--;
    gun += DateTime.DaysInMonth(bugun.Year, bugun.Month - 1);
}

if (ay < 0)
{
    yil--;
    ay += 12;
}

Console.WriteLine($"Detaylı yaş: {yil} yıl, {ay} ay, {gun} gün");
```

#### Tarih Farkı Hesaplama:
```csharp
DateTime baslangic = new DateTime(2025, 1, 1);
DateTime bitis = new DateTime(2025, 12, 31);

TimeSpan fark = bitis - baslangic;
Console.WriteLine($"İki tarih arasındaki gün farkı: {fark.Days}");
Console.WriteLine($"İki tarih arasındaki toplam gün: {fark.TotalDays}");
Console.WriteLine($"İki tarih arasındaki saat farkı: {fark.Hours}");
Console.WriteLine($"İki tarih arasındaki toplam saat: {fark.TotalHours}");

// Hafta sonu kontrolü
DateTime[] testTarihleri = {
    new DateTime(2025, 11, 22), // Cumartesi
    new DateTime(2025, 11, 24), // Pazartesi
    new DateTime(2025, 12, 25)  // Yılbaşı
};

foreach (DateTime tarih in testTarihleri)
{
    bool haftaSonu = (tarih.DayOfWeek == DayOfWeek.Saturday) || 
                     (tarih.DayOfWeek == DayOfWeek.Sunday);
    
    string gunTuru = haftaSonu ? "Hafta Sonu" : "Hafta İçi";
    Console.WriteLine($"{tarih:dd MMMM yyyy dddd} - {gunTuru}");
}
```

### 7.2 Math Sınıfı Metodları

Math sınıfı, matematiksel işlemler için kullanılır ve tüm metotları static'tir.

#### Temel Matematik Metotları:
```csharp
// Abs - Mutlak değer
int negatifSayi = -15;
Console.WriteLine($"Mutlak değer: |{negatifSayi}| = {Math.Abs(negatifSayi)}");

// Pow - Üs alma
double taban = 2.0;
double us = 3.0;
Console.WriteLine($"{taban}^{us} = {Math.Pow(taban, us)}"); // 8

// Sqrt - Karekök
int sayi = 16;
Console.WriteLine($"√{sayi} = {Math.Sqrt(sayi)}");

// Round - Yuvarlama
double kesirli = 7.8;
Console.WriteLine($"Round({kesirli}) = {Math.Round(kesirli)}"); // 8

// Belirli ondalık basamağa yuvarlama
double hassasSayi = 3.14159;
Console.WriteLine($"Pi değeri 2 ondalık: {Math.Round(hassasSayi, 2)}");

// Ceiling ve Floor
double sayi1 = 7.2;
Console.WriteLine($"Ceiling({sayi1}) = {Math.Ceiling(sayi1)}"); // 8
Console.WriteLine($"Floor({sayi1}) = {Math.Floor(sayi1)}"); // 7
```

#### Trigonometrik Fonksiyonlar:
```csharp
// Sin, Cos, Tan - Trigonometrik fonksiyonlar
double aci = Math.PI / 4; // 45 derece
Console.WriteLine($"45° için:");
Console.WriteLine($"Sin(45°) = {Math.Sin(aci):F4}");
Console.WriteLine($"Cos(45°) = {Math.Cos(aci):F4}");
Console.WriteLine($"Tan(45°) = {Math.Tan(aci):F4}");

// Derece cinsinden hesaplama
double dereceCinsinden(double aciDerece)
{
    return aciDerece * Math.PI / 180;
}

double[] aciDegerleri = { 0, 30, 45, 60, 90 };
Console.WriteLine("\nTrigonometrik değerler:");
foreach (double derece in aciDegerleri)
{
    double radyan = dereceCinsinden(derece);
    Console.WriteLine($"{derece}°: Sin={Math.Sin(radyan):F3}, Cos={Math.Cos(radyan):F3}");
}
```

#### Logaritma ve Üs Fonksiyonları:
```csharp
// Log - Doğal logaritma
double sayi = Math.E; // Euler sayısı
Console.WriteLine($"Ln(e) = {Math.Log(sayi)}"); // 1

double sayi2 = 10;
Console.WriteLine($"Ln({sayi2}) = {Math.Log(sayi2):F4}");

// Log10 - 10 tabanında logaritma
double sayi3 = 100;
Console.WriteLine($"Log10({sayi3}) = {Math.Log10(sayi3)}"); // 2

// Exp - e^x hesaplaması
double x = 2.0;
Console.WriteLine($"e^{x} = {Math.Exp(x):F4}");
```

#### Minimum, Maksimum ve Random:
```csharp
// Min ve Max
int sayi1 = 15, sayi2 = 8;
Console.WriteLine($"Min({sayi1}, {sayi2}) = {Math.Min(sayi1, sayi2)}");
Console.WriteLine($"Max({sayi1}, {sayi2}) = {Math.Max(sayi1, sayi2)}");

// Rastgele sayı üretimi
Random rastgele = new Random();

int rastgeleSayi1 = rastgele.Next(100);
Console.WriteLine($"Rastgele sayı (0-99): {rastgeleSayi1}");

int rastgeleSayi2 = rastgele.Next(10, 20);
Console.WriteLine($"Rastgele sayı (10-19): {rastgeleSayi2}");

// Ondalık rastgele sayı
double rastgeleOndalik = rastgele.NextDouble();
Console.WriteLine($"Rastgele ondalık (0-1): {rastgeleOndalik:F4}");

// Belirli aralıkta ondalık sayı
double min = 5.0, max = 15.0;
double rastgeleAralik = min + (max - min) * rastgele.NextDouble();
Console.WriteLine($"Rastgele ondalık ({min}-{max}): {rastgeleAralik:F2}");
```

### 7.3 Exception Handling

Exception handling, programda oluşan hataları yakalamak ve yönetmek için kullanılır.

#### Temel Try-Catch-Finally:
```csharp
Console.WriteLine("Temel Exception Handling Örneği");

try
{
    Console.Write("Bir sayı girin: ");
    int sayi = int.Parse(Console.ReadLine());
    Console.WriteLine($"Girdiğiniz sayı: {sayi}");
    
    int sonuc = 100 / sayi;
    Console.WriteLine($"100 / {sayi} = {sonuc}");
}
catch (FormatException)
{
    Console.WriteLine("Hata: Lütfen geçerli bir sayı girin!");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Hata: Sıfıra bölünemez!");
}
catch (Exception ex)
{
    Console.WriteLine($"Beklenmeyen hata: {ex.Message}");
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}
```

#### Farklı Exception Türleri:
```csharp
// FormatException - Tip dönüşüm hataları
Console.Write("\nSayı dönüşümü - Geçerli sayı: ");
string sayiGirisi1 = Console.ReadLine();
try
{
    int sayi1 = int.Parse(sayiGirisi1);
    Console.WriteLine($"Başarılı: {sayi1}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Geçersiz sayı formatı!");
}

// OverflowException - Taşma hataları
try
{
    int maxInt = int.MaxValue;
    int tasma = checked(maxInt + 1); // checked ile overflow kontrolü
    Console.WriteLine($"Max + 1: {tasma}");
}
catch (OverflowException)
{
    Console.WriteLine("OverflowException: Değer aralığını aştı!");
}

// DivideByZeroException - Sıfıra bölme
Console.Write("Bölünecek sayıyı girin: ");
int bolunen = Convert.ToInt32(Console.ReadLine());
Console.Write("Bölen sayıyı girin: ");
int bolen = Convert.ToInt32(Console.ReadLine());

try
{
    if (bolen == 0)
    {
        throw new DivideByZeroException("Bölen sıfır olamaz!");
    }
    
    double sonuc = (double)bolunen / bolen;
    Console.WriteLine($"{bolunen} / {bolen} = {sonuc}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"DivideByZeroException: {ex.Message}");
}
```

#### Custom Exception:
```csharp
public class YasGecersizException : Exception
{
    public YasGecersizException() : base("Yaş değeri geçersiz!") { }
    public YasGecersizException(string mesaj) : base(mesaj) { }
    public YasGecersizException(string mesaj, Exception icHata) : base(mesaj, icHata) { }
}

public class BankaHesabi
{
    private double bakiye;
    
    public BankaHesabi(double baslangicBakiye)
    {
        if (baslangicBakiye < 0)
        {
            throw new ArgumentException("Başlangıç bakiyesi negatif olamaz!");
        }
        bakiye = baslangicBakiye;
    }
    
    public void ParaCek(double miktar)
    {
        if (miktar < 0)
        {
            throw new ArgumentException("Çekilecek miktar negatif olamaz!");
        }
        
        if (miktar > bakiye)
        {
            throw new InvalidOperationException("Yetersiz bakiye!");
        }
        
        bakiye -= miktar;
        Console.WriteLine($"{miktar:C} çekildi. Yeni bakiye: {bakiye:C}");
    }
}

// Custom exception kullanımı
try
{
    BankaHesabi hesap = new BankaHesabi(1000);
    hesap.ParaCek(500);
    hesap.ParaCek(1000); // Bu satır hata verecek
}
catch (ArgumentException ex)
{
    Console.WriteLine($"ArgumentException: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"InvalidOperationException: {ex.Message}");
}
```

#### Exception Chaining:
```csharp
public class VeriTabaniBaglanti
{
    public void VeriGetir()
    {
        try
        {
            // Simüle edilmiş veri tabanı hatası
            throw new InvalidOperationException("Veri tabanı bağlantısı başarısız!");
        }
        catch (InvalidOperationException ex)
        {
            // Inner exception ile zincirleme hata
            throw new Exception("Veri alınırken hata oluştu!", ex);
        }
    }
}

// Exception chaining kullanımı
try
{
    VeriTabaniBaglanti db = new VeriTabaniBaglanti();
    db.VeriGetir();
}
catch (Exception ex)
{
    Console.WriteLine($"Ana hata: {ex.Message}");
    
    if (ex.InnerException != null)
    {
        Console.WriteLine($"İç hata: {ex.InnerException.Message}");
    }
    
    // Tüm exception chain'i gösterme
    Exception current = ex;
    int seviye = 1;
    while (current != null)
    {
        Console.WriteLine($"Seviye {seviye}: {current.GetType().Name} - {current.Message}");
        current = current.InnerException;
        seviye++;
    }
}
```

### 7.4 Collections Giriş

Collections, birden fazla veriyi saklamak ve yönetmek için kullanılan özel veri yapılarıdır.

#### List<T> Sınıfı:
```csharp
using System.Collections.Generic;

// String listesi oluşturma
List<string> isimler = new List<string>();

// Eleman ekleme
isimler.Add("Ahmet");
isimler.Add("Ayşe");
isimler.Add("Mehmet");
isimler.Add("Fatma");

Console.WriteLine("İsimler listesi:");
foreach (string isim in isimler)
{
    Console.WriteLine($"- {isim}");
}

Console.WriteLine($"\nListe boyutu: {isimler.Count}");
Console.WriteLine($"Liste kapasitesi: {isimler.Capacity}");

// Belirli pozisyona ekleme
isimler.Insert(1, "Ali"); // 1. indexe ekle

// Eleman arama
if (isimler.Contains("Ayşe"))
{
    int index = isimler.IndexOf("Ayşe");
    Console.WriteLine($"\nAyşe bulundu. Index: {index}");
}

// Listeyi sıralama
isimler.Sort();
Console.WriteLine("\nSıralanmış liste:");
foreach (string isim in isimler)
{
    Console.WriteLine($"- {isim}");
}
```

#### List<T> ile Nesne Saklama:
```csharp
public class Ogrenci
{
    public int No { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public double Not { get; set; }
    
    public override string ToString()
    {
        return $"{No}: {Ad} {Soyad} - Not: {Not}";
    }
}

// Öğrenci listesi
List<Ogrenci> ogrenciler = new List<Ogrenci>();

// Öğrenci ekleme
ogrenciler.Add(new Ogrenci(1001, "Ahmet", "Yılmaz", 85.5));
ogrenciler.Add(new Ogrenci(1002, "Ayşe", "Kaya", 92.0));
ogrenciler.Add(new Ogrenci(1003, "Mehmet", "Demir", 78.5));
ogrenciler.Add(new Ogrenci(1004, "Fatma", "Özkan", 96.5));

Console.WriteLine("Öğrenci listesi:");
foreach (Ogrenci ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}

// Not ortalaması hesaplama
double ortalama = ogrenciler.Average(o => o.Not);
Console.WriteLine($"\nSınıf ortalaması: {ortalama:F2}");

// En yüksek notu bulma
Ogrenci enYuksekNot = ogrenciler.OrderByDescending(o => o.Not).First();
Console.WriteLine($"En yüksek not: {enYuksekNot}");
```

#### Dictionary<TKey, TValue>:
```csharp
Dictionary<string, int> yaslar = new Dictionary<string, int>();

// Eleman ekleme
yaslar.Add("Ahmet", 25);
yaslar.Add("Ayşe", 30);
yaslar.Add("Mehmet", 28);
yaslar.Add("Fatma", 22);

Console.WriteLine("İsim-Yaş sözlüğü:");
foreach (KeyValuePair<string, int> kvp in yaslar)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value} yaşında");
}

// Eleman okuma
Console.WriteLine($"\nAyşe'nin yaşı: {yaslar["Ayşe"]}");

// ContainsKey kontrolü
if (yaslar.ContainsKey("Ali"))
{
    Console.WriteLine("Ali listede var");
}
else
{
    Console.WriteLine("Ali listede yok");
}

// TryGetValue güvenli okuma
if (yaslar.TryGetValue("Mehmet", out int mehmetYasi))
{
    Console.WriteLine($"Mehmet'in yaşı: {mehmetYasi}");
}
else
{
    Console.WriteLine("Mehmet bulunamadı");
}
```

#### Dictionary ile Kelime Sayacı:
```csharp
Dictionary<string, int> kelimeSayaci = new Dictionary<string, int>();

string cumle = "C# programlama dili güçlü bir dildir. C# öğrenmesi kolaydır.";
string[] kelimeler = cumle.Split(' ');

foreach (string kelime in kelimeler)
{
    // Noktalama işaretlerini temizle
    string temizKelime = kelime.Trim(',', '.');
    
    if (kelimeSayaci.ContainsKey(temizKelime))
    {
        kelimeSayaci[temizKelime]++;
    }
    else
    {
        kelimeSayaci.Add(temizKelime, 1);
    }
}

Console.WriteLine("Kelime sayıları:");
foreach (var kvp in kelimeSayaci)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value} kez");
}

// En çok tekrar eden kelime
var enCokKelime = kelimeSayaci.OrderByDescending(kvp => kvp.Value).First();
Console.WriteLine($"\nEn çok tekrar eden kelime: {enCokKelime.Key} ({enCokKelime.Value} kez)");
```

#### Stack, Queue, HashSet:
```csharp
// Stack - LIFO (Last In First Out)
Stack<string> yigin = new Stack<string>();
yigin.Push("İlk");
yigin.Push("İkinci");
yigin.Push("Üçüncü");

Console.WriteLine("Stack:");
while (yigin.Count > 0)
{
    Console.WriteLine(yigin.Pop());
}

// Queue - FIFO (First In First Out)
Queue<string> kuyruk = new Queue<string>();
kuyruk.Enqueue("İlk");
kuyruk.Enqueue("İkinci");
kuyruk.Enqueue("Üçüncü");

Console.WriteLine("\nQueue:");
while (kuyruk.Count > 0)
{
    Console.WriteLine(kuyruk.Dequeue());
}

// HashSet - Benzersiz elemanlar
HashSet<int> benzersizSayilar = new HashSet<int>();
benzersizSayilar.Add(1);
benzersizSayilar.Add(2);
benzersizSayilar.Add(2); // Aynı eleman tekrar eklenmez
benzersizSayilar.Add(3);

Console.WriteLine("\nHashSet:");
foreach (int sayi in benzersizSayilar)
{
    Console.WriteLine(sayi);
}
```

Yeni konular bölümünü tamamladık. Artık algoritma soruları ve çözümlerine geçerek, öğrendiklerimizi pratiğe dökeceğiz.

## 8. ALGORİTMA SORULARI VE ÇÖZÜMLERİ

Bu bölümde, başlangıçtan ileri seviyeye kadar 80 adet algoritma sorusu ve çözümleri bulunmaktadır.

### 8.1 Başlangıç Seviyesi (30 Soru)

#### 1. İki Sayının Toplamı
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        int toplam = sayi1 + sayi2;
        
        Console.WriteLine($"Sonuç: {toplam}");
    }
}
```

#### 2. Sayının Pozitif/Negatif Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (sayi > 0)
        {
            Console.WriteLine("Sayı POZİTİF");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("Sayı NEGATİF");
        }
        else
        {
            Console.WriteLine("Sayı SIFIR");
        }
    }
}
```

#### 3. Çift/Tek Sayı Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayıdır");
        }
        else
        {
            Console.WriteLine($"{sayi} tek bir sayıdır");
        }
    }
}
```

#### 4. Üç Sayıdan En Büyüğünü Bulma
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayı: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("İkinci sayı: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Üçüncü sayı: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());
        
        int enBuyuk = sayi1;
        
        if (sayi2 > enBuyuk)
            enBuyuk = sayi2;
            
        if (sayi3 > enBuyuk)
            enBuyuk = sayi3;
            
        Console.WriteLine($"En büyük sayı: {enBuyuk}");
    }
}
```

#### 5. Faktöriyel Hesaplama
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        long faktoriyel = 1;
        
        for (int i = 1; i <= sayi; i++)
        {
            faktoriyel *= i;
        }
        
        Console.WriteLine($"{sayi}! = {faktoriyel}");
    }
}
```

#### 6. Basit Hesap Makinesi
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayı: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("İkinci sayı: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("İşlem (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());
        
        double sonuc = 0;
        
        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
                else
                    Console.WriteLine("Sıfıra bölme hatası!");
                break;
        }
        
        if (islem == '/' && sayi2 == 0)
        {
            // Hata durumu zaten yazdırıldı
        }
        else
        {
            Console.WriteLine($"Sonuç: {sonuc}");
        }
    }
}
```

#### 7. Sayının Üs Hesabı
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Taban değeri: ");
        int taban = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Üs değeri: ");
        int us = Convert.ToInt32(Console.ReadLine());
        
        int sonuc = 1;
        
        for (int i = 1; i <= us; i++)
        {
            sonuc *= taban;
        }
        
        Console.WriteLine($"{taban}^{us} = {sonuc}");
    }
}
```

#### 8. Dikdörtgen Alanı ve Çevresi
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Uzun kenar: ");
        double uzun = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Kısa kenar: ");
        double kisa = Convert.ToDouble(Console.ReadLine());
        
        double alan = uzun * kisa;
        double cevre = 2 * (uzun + kisa);
        
        Console.WriteLine($"Alan: {alan}");
        Console.WriteLine($"Çevre: {cevre}");
    }
}
```

#### 9. Yaş Kategorisi Belirleme
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Yaşınızı girin: ");
        int yas = Convert.ToInt32(Console.ReadLine());
        
        if (yas < 0)
        {
            Console.WriteLine("Geçersiz yaş!");
        }
        else if (yas <= 12)
        {
            Console.WriteLine("Çocuk kategorisindesiniz");
        }
        else if (yas <= 17)
        {
            Console.WriteLine("Genç kategorisindesiniz");
        }
        else if (yas <= 64)
        {
            Console.WriteLine("Yetişkin kategorisindesiniz");
        }
        else
        {
            Console.WriteLine("Yaşlı kategorisindesiniz");
        }
    }
}
```

#### 10. Not Ortalaması Hesaplama
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("1. Not: ");
        double not1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("2. Not: ");
        double not2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("3. Not: ");
        double not3 = Convert.ToDouble(Console.ReadLine());
        
        double ortalama = (not1 + not2 + not3) / 3;
        
        Console.WriteLine($"Ortalama: {ortalama:F2}");
        
        if (ortalama >= 50)
        {
            Console.WriteLine("Geçme Durumu: GEÇTİ");
        }
        else
        {
            Console.WriteLine("Geçme Durumu: KALDI");
        }
    }
}
```

#### 11. String Birleştirme
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Adınız: ");
        string ad = Console.ReadLine();
        
        Console.Write("Soyadınız: ");
        string soyad = Console.ReadLine();
        
        string tamAd = $"{ad} {soyad}";
        
        Console.WriteLine($"Tam adınız: {tamAd}");
    }
}
```

#### 12. String Uzunluğu Bulma
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir kelime girin: ");
        string kelime = Console.ReadLine();
        
        int uzunluk = kelime.Length;
        
        Console.WriteLine($"\"{kelime}\" kelimesi {uzunluk} harften oluşuyor");
    }
}
```

#### 13. Kelime Sayacı
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();
        
        string[] kelimeler = cumle.Split(' ');
        int kelimeSayisi = kelimeler.Length;
        
        Console.WriteLine($"Cümlede {kelimeSayisi} kelime var");
    }
}
```

#### 14. Harf Arama
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Kelime: ");
        string kelime = Console.ReadLine();
        
        Console.Write("Aranan harf: ");
        char arananHarf = Convert.ToChar(Console.ReadLine());
        
        int sayac = 0;
        
        for (int i = 0; i < kelime.Length; i++)
        {
            if (kelime[i] == arananHarf)
            {
                sayac++;
            }
        }
        
        Console.WriteLine($"\"{arananHarf}\" harfi {sayac} kez geçiyor");
    }
}
```

#### 15. Dizi Toplamı
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = new int[5];
        int toplam = 0;
        
        Console.WriteLine("5 sayı girin:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
            toplam += dizi[i];
        }
        
        Console.WriteLine($"Dizi toplamı: {toplam}");
    }
}
```

#### 16. Dizi Ortalaması
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = new int[4];
        int toplam = 0;
        
        Console.WriteLine("4 sayı girin:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
            toplam += dizi[i];
        }
        
        double ortalama = (double)toplam / dizi.Length;
        
        Console.WriteLine($"Dizi ortalaması: {ortalama:F2}");
    }
}
```

#### 17. Dizi En Büyük Eleman
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = new int[6];
        
        Console.WriteLine("6 sayı girin:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int enBuyuk = dizi[0];
        int pozisyon = 0;
        
        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
                pozisyon = i;
            }
        }
        
        Console.WriteLine($"En büyük eleman: {enBuyuk} ({pozisyon + 1}. pozisyonda)");
    }
}
```

#### 18. Dizi Çift Sayıları
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = new int[8];
        
        Console.WriteLine("8 sayı girin:");
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Çift sayılar: ");
        bool ilkEleman = true;
        
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 == 0)
            {
                if (!ilkEleman)
                    Console.Write(", ");
                    
                Console.Write(dizi[i]);
                ilkEleman = false;
            }
        }
        
        Console.WriteLine();
    }
}
```

#### 19. Dizi Eleman Sayısı
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Dizi boyutu: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        
        int[] dizi = new int[boyut];
        
        for (int i = 0; i < boyut; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Aranan değer: ");
        int aranan = Convert.ToInt32(Console.ReadLine());
        
        int sayac = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] == aranan)
            {
                sayac++;
            }
        }
        
        Console.WriteLine($"{aranan} değeri {sayac} kez geçiyor");
    }
}
```

#### 20. Dizi Sıralama
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = new int[5];
        
        Console.WriteLine("5 sayı girin:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        // Bubble Sort
        for (int i = 0; i < dizi.Length - 1; i++)
        {
            for (int j = 0; j < dizi.Length - 1 - i; j++)
            {
                if (dizi[j] > dizi[j + 1])
                {
                    int gecici = dizi[j];
                    dizi[j] = dizi[j + 1];
                    dizi[j + 1] = gecici;
                }
            }
        }
        
        Console.Write("Sıralanmış dizi: ");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i]);
            if (i < dizi.Length - 1)
                Console.Write(", ");
        }
        
        Console.WriteLine();
    }
}
```

### 8.2 Orta Seviye (30 Soru)

#### 21. Çarpım Tablosu
```csharp
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} x {j} = {i * j,4}");
                if (j < 10)
                    Console.Write("\t");
            }
            Console.WriteLine();
        }
    }
}
```

#### 22. Fibonacci Dizisi
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç terim gösterilsin: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n <= 0)
        {
            Console.WriteLine("Geçersiz sayı!");
            return;
        }
        
        int[] fibonacci = new int[n];
        
        if (n >= 1)
            fibonacci[0] = 0;
        if (n >= 2)
            fibonacci[1] = 1;
            
        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        
        Console.Write("Fibonacci dizisi: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(fibonacci[i]);
            if (i < n - 1)
                Console.Write(", ");
        }
        
        Console.WriteLine();
    }
}
```

#### 23. Asal Sayı Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (sayi <= 1)
        {
            Console.WriteLine($"{sayi} asal bir sayı değildir");
            return;
        }
        
        bool asal = true;
        for (int i = 2; i <= sayi / 2; i++)
        {
            if (sayi % i == 0)
            {
                asal = false;
                break;
            }
        }
        
        if (asal)
            Console.WriteLine($"{sayi} asal bir sayıdır");
        else
            Console.WriteLine($"{sayi} asal bir sayı değildir");
    }
}
```

#### 24. İç İçe Döngü - Piramit
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Piramit yüksekliği: ");
        int yukseklik = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= yukseklik; i++)
        {
            // Boşluklar
            for (int j = 1; j <= yukseklik - i; j++)
            {
                Console.Write(" ");
            }
            
            // Yıldızlar
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}
```

#### 25. İki Boyutlu Dizi Toplamı
```csharp
using System;

class Program
{
    static void Main()
    {
        int[,] matris = new int[3, 3];
        int toplam = 0;
        
        Console.WriteLine("3x3 matrisi girin:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"[{i},{j}]: ");
                matris[i, j] = Convert.ToInt32(Console.ReadLine());
                toplam += matris[i, j];
            }
        }
        
        Console.WriteLine($"Matris toplamı: {toplam}");
    }
}
```

#### 26. Dizi Elemanlarını Kopyalama
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaynak dizi boyutu: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        
        int[] kaynakDizi = new int[boyut];
        int[] hedefDizi = new int[boyut];
        
        for (int i = 0; i < boyut; i++)
        {
            Console.Write($"{i + 1}. eleman: ");
            kaynakDizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        // Elemanları kopyala
        for (int i = 0; i < boyut; i++)
        {
            hedefDizi[i] = kaynakDizi[i];
        }
        
        // Orijinal dizi yazdır
        Console.Write("Orijinal dizi: ");
        for (int i = 0; i < boyut; i++)
        {
            Console.Write(kaynakDizi[i]);
            if (i < boyut - 1)
                Console.Write(", ");
        }
        
        // Kopyalanan dizi yazdır
        Console.Write("\nKopyalanan dizi: ");
        for (int i = 0; i < boyut; i++)
        {
            Console.Write(hedefDizi[i]);
            if (i < boyut - 1)
                Console.Write(", ");
        }
        
        Console.WriteLine();
    }
}
```

#### 27. Metot ile Hesap Makinesi
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayı: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("İkinci sayı: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("İşlem (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());
        
        double sonuc = Hesapla(sayi1, sayi2, islem);
        Console.WriteLine($"Sonuç: {sonuc}");
    }
    
    static double Hesapla(double a, double b, char op)
    {
        switch (op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/': return b != 0 ? a / b : 0;
            default: return 0;
        }
    }
}
```

#### 28. Recursive Faktöriyel
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"{sayi}! = {Faktoriyel(sayi)}");
    }
    
    static long Faktoriyel(int n)
    {
        if (n <= 1)
            return 1;
        return n * Faktoriyel(n - 1);
    }
}
```

#### 29. Palindrome Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir kelime girin: ");
        string kelime = Console.ReadLine();
        
        if (PalindromeMi(kelime))
        {
            Console.WriteLine($"\"{kelime}\" bir palindromdur");
        }
        else
        {
            Console.WriteLine($"\"{kelime}\" bir palindrom değildir");
        }
    }
    
    static bool PalindromeMi(string metin)
    {
        metin = metin.ToLower().Replace(" ", "");
        
        for (int i = 0; i < metin.Length / 2; i++)
        {
            if (metin[i] != metin[metin.Length - 1 - i])
                return false;
        }
        
        return true;
    }
}
```

#### 30. Armstrong Sayısı
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (ArmstrongMi(sayi))
        {
            Console.WriteLine($"{sayi} bir Armstrong sayısıdır");
        }
        else
        {
            Console.WriteLine($"{sayi} bir Armstrong sayısı değildir");
        }
    }
    
    static bool ArmstrongMi(int sayi)
    {
        int orijinalSayi = sayi;
        int toplam = 0;
        int basamakSayisi = sayi.ToString().Length;
        
        while (sayi > 0)
        {
            int basamak = sayi % 10;
            toplam += (int)Math.Pow(basamak, basamakSayisi);
            sayi /= 10;
        }
        
        return toplam == orijinalSayi;
    }
}
```

### 8.3 İleri Seviye (20 Soru)

#### 31. Quick Sort Algoritması
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Sıralanmadan önce: " + string.Join(", ", dizi));
        
        QuickSort(dizi, 0, dizi.Length - 1);
        
        Console.WriteLine("Sıralandıktan sonra: " + string.Join(", ", dizi));
    }
    
    static void QuickSort(int[] dizi, int sol, int sag)
    {
        if (sol < sag)
        {
            int pivot = Partition(dizi, sol, sag);
            QuickSort(dizi, sol, pivot - 1);
            QuickSort(dizi, pivot + 1, sag);
        }
    }
    
    static int Partition(int[] dizi, int sol, int sag)
    {
        int pivot = dizi[sag];
        int i = sol - 1;
        
        for (int j = sol; j < sag; j++)
        {
            if (dizi[j] < pivot)
            {
                i++;
                Swap(dizi, i, j);
            }
        }
        
        Swap(dizi, i + 1, sag);
        return i + 1;
    }
    
    static void Swap(int[] dizi, int i, int j)
    {
        int temp = dizi[i];
        dizi[i] = dizi[j];
        dizi[j] = temp;
    }
}
```

#### 32. Binary Search
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        
        Console.Write("Aranacak sayı: ");
        int aranan = Convert.ToInt32(Console.ReadLine());
        
        int pozisyon = BinarySearch(dizi, aranan);
        
        if (pozisyon != -1)
        {
            Console.WriteLine($"{aranan} bulundu. Pozisyon: {pozisyon}");
        }
        else
        {
            Console.WriteLine($"{aranan} bulunamadı.");
        }
    }
    
    static int BinarySearch(int[] dizi, int aranan)
    {
        int sol = 0;
        int sag = dizi.Length - 1;
        
        while (sol <= sag)
        {
            int orta = (sol + sag) / 2;
            
            if (dizi[orta] == aranan)
                return orta;
            else if (dizi[orta] < aranan)
                sol = orta + 1;
            else
                sag = orta - 1;
        }
        
        return -1;
    }
}
```

#### 33. Heap Sort
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 12, 11, 13, 5, 6, 7 };
        
        Console.WriteLine("Sıralanmadan önce: " + string.Join(", ", dizi));
        
        HeapSort(dizi);
        
        Console.WriteLine("Sıralandıktan sonra: " + string.Join(", ", dizi));
    }
    
    static void HeapSort(int[] dizi)
    {
        int n = dizi.Length;
        
        // Max heap oluştur
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(dizi, n, i);
        
        // Heap'ten tek tek eleman çıkar
        for (int i = n - 1; i > 0; i--)
        {
            // Maksimum elemanı sona taşı
            Swap(dizi, 0, i);
            
            // Azaltılmış heap'te heapify uygula
            Heapify(dizi, i, 0);
        }
    }
    
    static void Heapify(int[] dizi, int n, int i)
    {
        int enBuyuk = i;
        int sol = 2 * i + 1;
        int sag = 2 * i + 2;
        
        if (sol < n && dizi[sol] > dizi[enBuyuk])
            enBuyuk = sol;
            
        if (sag < n && dizi[sag] > dizi[enBuyuk])
            enBuyuk = sag;
            
        if (enBuyuk != i)
        {
            Swap(dizi, i, enBuyuk);
            Heapify(dizi, n, enBuyuk);
        }
    }
    
    static void Swap(int[] dizi, int i, int j)
    {
        int temp = dizi[i];
        dizi[i] = dizi[j];
        dizi[j] = temp;
    }
}
```

#### 34. Merge Sort
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 12, 11, 13, 5, 6, 7 };
        
        Console.WriteLine("Sıralanmadan önce: " + string.Join(", ", dizi));
        
        MergeSort(dizi, 0, dizi.Length - 1);
        
        Console.WriteLine("Sıralandıktan sonra: " + string.Join(", ", dizi));
    }
    
    static void MergeSort(int[] dizi, int sol, int sag)
    {
        if (sol < sag)
        {
            int orta = sol + (sag - sol) / 2;
            
            MergeSort(dizi, sol, orta);
            MergeSort(dizi, orta + 1, sag);
            
            Merge(dizi, sol, orta, sag);
        }
    }
    
    static void Merge(int[] dizi, int sol, int orta, int sag)
    {
        int n1 = orta - sol + 1;
        int n2 = sag - orta;
        
        int[] solDizi = new int[n1];
        int[] sagDizi = new int[n2];
        
        for (int i = 0; i < n1; i++)
            solDizi[i] = dizi[sol + i];
            
        for (int j = 0; j < n2; j++)
            sagDizi[j] = dizi[orta + 1 + j];
        
        int i = 0, j = 0, k = sol;
        
        while (i < n1 && j < n2)
        {
            if (solDizi[i] <= sagDizi[j])
            {
                dizi[k] = solDizi[i];
                i++;
            }
            else
            {
                dizi[k] = sagDizi[j];
                j++;
            }
            k++;
        }
        
        while (i < n1)
        {
            dizi[k] = solDizi[i];
            i++;
            k++;
        }
        
        while (j < n2)
        {
            dizi[k] = sagDizi[j];
            j++;
            k++;
        }
    }
}
```

#### 35. Linear Search
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 3, 7, 1, 9, 2, 8, 5 };
        
        Console.Write("Aranacak sayı: ");
        int aranan = Convert.ToInt32(Console.ReadLine());
        
        int pozisyon = LinearSearch(dizi, aranan);
        
        if (pozisyon != -1)
        {
            Console.WriteLine($"{aranan} bulundu. Pozisyon: {pozisyon}");
        }
        else
        {
            Console.WriteLine($"{aranan} bulunamadı.");
        }
    }
    
    static int LinearSearch(int[] dizi, int aranan)
    {
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] == aranan)
                return i;
        }
        return -1;
    }
}
```

#### 36. Selection Sort
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Sıralanmadan önce: " + string.Join(", ", dizi));
        
        SelectionSort(dizi);
        
        Console.WriteLine("Sıralandıktan sonra: " + string.Join(", ", dizi));
    }
    
    static void SelectionSort(int[] dizi)
    {
        int n = dizi.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            
            for (int j = i + 1; j < n; j++)
            {
                if (dizi[j] < dizi[minIndex])
                    minIndex = j;
            }
            
            Swap(dizi, minIndex, i);
        }
    }
    
    static void Swap(int[] dizi, int i, int j)
    {
        int temp = dizi[i];
        dizi[i] = dizi[j];
        dizi[j] = temp;
    }
}
```

#### 37. Insertion Sort
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 12, 11, 13, 5, 6 };
        
        Console.WriteLine("Sıralanmadan önce: " + string.Join(", ", dizi));
        
        InsertionSort(dizi);
        
        Console.WriteLine("Sıralandıktan sonra: " + string.Join(", ", dizi));
    }
    
    static void InsertionSort(int[] dizi)
    {
        int n = dizi.Length;
        
        for (int i = 1; i < n; i++)
        {
            int key = dizi[i];
            int j = i - 1;
            
            while (j >= 0 && dizi[j] > key)
            {
                dizi[j + 1] = dizi[j];
                j--;
            }
            
            dizi[j + 1] = key;
        }
    }
}
```

#### 38. Bubble Sort
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Sıralanmadan önce: " + string.Join(", ", dizi));
        
        BubbleSort(dizi);
        
        Console.WriteLine("Sıralandıktan sonra: " + string.Join(", ", dizi));
    }
    
    static void BubbleSort(int[] dizi)
    {
        int n = dizi.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            
            for (int j = 0; j < n - i - 1; j++)
            {
                if (dizi[j] > dizi[j + 1])
                {
                    Swap(dizi, j, j + 1);
                    swapped = true;
                }
            }
            
            // Eğer bu turda swap yapılmadıysa dizi sıralıdır
            if (!swapped)
                break;
        }
    }
    
    static void Swap(int[] dizi, int i, int j)
    {
        int temp = dizi[i];
        dizi[i] = dizi[j];
        dizi[j] = temp;
    }
}
```

#### 39. Prime Number Generator
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Kaça kadar asal sayılar listelensin: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        
        List<int> asalSayilar = AsalSayilarListele(limit);
        
        Console.WriteLine($"1-{limit} arası asal sayılar:");
        foreach (int sayi in asalSayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
    }
    
    static List<int> AsalSayilarListele(int limit)
    {
        List<int> asalSayilar = new List<int>();
        
        for (int sayi = 2; sayi <= limit; sayi++)
        {
            if (AsalMi(sayi))
            {
                asalSayilar.Add(sayi);
            }
        }
        
        return asalSayilar;
    }
    
    static bool AsalMi(int sayi)
    {
        if (sayi < 2) return false;
        if (sayi == 2) return true;
        if (sayi % 2 == 0) return false;
        
        int sinir = (int)Math.Sqrt(sayi);
        for (int i = 3; i <= sinir; i += 2)
        {
            if (sayi % i == 0) return false;
        }
        
        return true;
    }
}
```

#### 40. GCD ve LCM Hesaplama
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("İlk sayı: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("İkinci sayı: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        int obeb = OBEB(sayi1, sayi2);
        int okek = OKEK(sayi1, sayi2);
        
        Console.WriteLine($"OBEB({sayi1}, {sayi2}) = {obeb}");
        Console.WriteLine($"OKEK({sayi1}, {sayi2}) = {okek}");
    }
    
    static int OBEB(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
    
    static int OKEK(int a, int b)
    {
        return Math.Abs(a * b) / OBEB(a, b);
    }
}
```

#### 41. Perfect Number Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (MukemmelMi(sayi))
        {
            Console.WriteLine($"{sayi} bir mükemmel sayıdır");
        }
        else
        {
            Console.WriteLine($"{sayi} bir mükemmel sayı değildir");
        }
    }
    
    static bool MukemmelMi(int sayi)
    {
        int toplam = 0;
        
        for (int i = 1; i <= sayi / 2; i++)
        {
            if (sayi % i == 0)
                toplam += i;
        }
        
        return toplam == sayi;
    }
}
```

#### 42. Strong Number Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (GucKuvvetiSayiMi(sayi))
        {
            Console.WriteLine($"{sayi} bir güçlü sayıdır");
        }
        else
        {
            Console.WriteLine($"{sayi} bir güçlü sayı değildir");
        }
    }
    
    static bool GucKuvvetiSayiMi(int sayi)
    {
        int orijinalSayi = sayi;
        int toplam = 0;
        
        while (sayi > 0)
        {
            int basamak = sayi % 10;
            toplam += Faktoriyel(basamak);
            sayi /= 10;
        }
        
        return toplam == orijinalSayi;
    }
    
    static int Faktoriyel(int n)
    {
        if (n <= 1) return 1;
        return n * Faktoriyel(n - 1);
    }
}
```

#### 43. Sparse Matrix İşlemleri
```csharp
using System;

class Program
{
    static void Main()
    {
        // 5x5 sparse matrix
        int[,] matris = {
            {0, 0, 3, 0, 4},
            {0, 0, 0, 0, 0},
            {1, 0, 0, 2, 0},
            {0, 0, 0, 0, 0},
            {0, 5, 0, 0, 0}
        };
        
        Console.WriteLine("Sparse Matrix:");
        MatrisYazdir(matris);
        
        Console.WriteLine($"\nSıfır olmayan eleman sayısı: {SifirOlmayanSayisi(matris)}");
        Console.WriteLine($"Sparsity: {SparsityHesapla(matris):F2}");
        
        // Sparse matrix'i tuple formatında yazdır
        Tuple<int, int, int>[] sparseTuple = SparseYap(matris);
        Console.WriteLine("\nSparse Tuple Format:");
        foreach (var tuple in sparseTuple)
        {
            Console.WriteLine($"({tuple.Item1}, {tuple.Item2}, {tuple.Item3})");
        }
    }
    
    static void MatrisYazdir(int[,] matris)
    {
        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                Console.Write(matris[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    static int SifirOlmayanSayisi(int[,] matris)
    {
        int sayac = 0;
        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                if (matris[i, j] != 0)
                    sayac++;
            }
        }
        return sayac;
    }
    
    static double SparsityHesapla(int[,] matris)
    {
        int toplamEleman = matris.GetLength(0) * matris.GetLength(1);
        int sifirOlmayan = SifirOlmayanSayisi(matris);
        return (double)(toplamEleman - sifirOlmayan) / toplamEleman;
    }
    
    static Tuple<int, int, int>[] SparseYap(int[,] matris)
    {
        int sifirOlmayan = SifirOlmayanSayisi(matris);
        Tuple<int, int, int>[] sparse = new Tuple<int, int, int>[sifirOlmayan];
        int index = 0;
        
        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                if (matris[i, j] != 0)
                {
                    sparse[index] = Tuple.Create(i, j, matris[i, j]);
                    index++;
                }
            }
        }
        
        return sparse;
    }
}
```

#### 44. Graph BFS (Breadth-First Search)
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 6 düğümlü graph
        int[,] adjMatrix = {
            {0, 1, 1, 0, 0, 0},
            {1, 0, 0, 1, 1, 0},
            {1, 0, 0, 0, 1, 1},
            {0, 1, 0, 0, 0, 0},
            {0, 1, 1, 0, 0, 1},
            {0, 0, 1, 0, 1, 0}
        };
        
        Console.Write("Başlangıç düğümü: ");
        int baslangic = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Hedef düğümü: ");
        int hedef = Convert.ToInt32(Console.ReadLine());
        
        BFS(adjMatrix, baslangic, hedef);
    }
    
    static void BFS(int[,] adjMatrix, int baslangic, int hedef)
    {
        int dugumSayisi = adjMatrix.GetLength(0);
        bool[] ziyaretEdildi = new bool[dugumSayisi];
        Queue<int> kuyruk = new Queue<int>();
        
        kuyruk.Enqueue(baslangic);
        ziyaretEdildi[baslangic] = true;
        
        Console.WriteLine("BFS Sırası:");
        
        while (kuyruk.Count > 0)
        {
            int mevcut = kuyruk.Dequeue();
            Console.Write(mevcut + " ");
            
            if (mevcut == hedef)
            {
                Console.WriteLine($"\nHedef {hedef} bulundu!");
                return;
            }
            
            for (int i = 0; i < dugumSayisi; i++)
            {
                if (adjMatrix[mevcut, i] == 1 && !ziyaretEdildi[i])
                {
                    kuyruk.Enqueue(i);
                    ziyaretEdildi[i] = true;
                }
            }
        }
        
        Console.WriteLine($"\nHedef {hedef} bulunamadı!");
    }
}
```

#### 45. Graph DFS (Depth-First Search)
```csharp
using System;

class Program
{
    static void Main()
    {
        // 6 düğümlü graph
        int[,] adjMatrix = {
            {0, 1, 1, 0, 0, 0},
            {1, 0, 0, 1, 1, 0},
            {1, 0, 0, 0, 1, 1},
            {0, 1, 0, 0, 0, 0},
            {0, 1, 1, 0, 0, 1},
            {0, 0, 1, 0, 1, 0}
        };
        
        bool[] ziyaretEdildi = new bool[6];
        
        Console.WriteLine("DFS Sırası:");
        for (int i = 0; i < 6; i++)
        {
            if (!ziyaretEdildi[i])
            {
                DFS(adjMatrix, i, ziyaretEdildi);
            }
        }
    }
    
    static void DFS(int[,] adjMatrix, int dugum, bool[] ziyaretEdildi)
    {
        ziyaretEdildi[dugum] = true;
        Console.Write(dugum + " ");
        
        int dugumSayisi = adjMatrix.GetLength(0);
        
        for (int i = 0; i < dugumSayisi; i++)
        {
            if (adjMatrix[dugum, i] == 1 && !ziyaretEdildi[i])
            {
                DFS(adjMatrix, i, ziyaretEdildi);
            }
        }
    }
}
```

#### 46. Dynamic Programming - Fibonacci
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Fibonacci terim sayısı: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"\nFibonacci({n}) = {FibonacciDP(n)}");
        
        // İlk 10 Fibonacci sayısını yazdır
        Console.WriteLine("\nİlk 10 Fibonacci sayısı:");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"Fibonacci({i}) = {FibonacciDP(i)}");
            Console.WriteLine();
        }
    }
    
    static long FibonacciDP(int n)
    {
        if (n <= 1)
            return n;
        
        long[] dp = new long[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        
        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        
        return dp[n];
    }
}
```

#### 47. Longest Common Subsequence (LCS)
```csharp
using System;

class Program
{
    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";
        
        int lcsLength = LCS(str1, str2, str1.Length, str2.Length);
        Console.WriteLine($"LCS Uzunluğu: {lcsLength}");
        
        string lcsString = LCSString(str1, str2, str1.Length, str2.Length);
        Console.WriteLine($"LCS String: {lcsString}");
    }
    
    static int LCS(string str1, string str2, int m, int n)
    {
        if (m == 0 || n == 0)
            return 0;
            
        if (str1[m - 1] == str2[n - 1])
            return 1 + LCS(str1, str2, m - 1, n - 1);
        else
            return Math.Max(LCS(str1, str2, m - 1, n), 
                           LCS(str1, str2, m, n - 1));
    }
    
    static string LCSString(string str1, string str2, int m, int n)
    {
        int[,] dp = new int[m + 1, n + 1];
        
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
        
        // LCS string'ini reconstruct et
        int i = m, j = n;
        string lcs = "";
        
        while (i > 0 && j > 0)
        {
            if (str1[i - 1] == str2[j - 1])
            {
                lcs = str1[i - 1] + lcs;
                i--;
                j--;
            }
            else if (dp[i - 1, j] > dp[i, j - 1])
            {
                i--;
            }
            else
            {
                j--;
            }
        }
        
        return lcs;
    }
}
```

---

## 📚 EĞİTİM REHBERİ VE METODOLOJİ

### 3 Saatlik Kapsamlı C# Eğitim Planı

Bu eğitim planı, genişletilmiş C# dokümanımız için özel olarak hazırlanmış 3 saatlik (10:00-13:00) kapsamlı bir eğitim programıdır.

#### **⏰ EĞİTİM ZAMAN PLANI**

##### **10:00-10:25: TEMEL KAVRAMLAR (25 dakika)**
- **10:00-10:10**: Açılış ve Tanışma (10 dk)
  - Programlama nedir?
  - C# ve .NET tanıtımı
  - Eğitim hedefleri

- **10:10-10:25**: Development Environment (15 dk)
  - Visual Studio kurulumu
  - İlk proje oluşturma
  - "Merhaba Dünya" uygulaması

##### **10:25-11:05: VERİ VE DEĞİŞKENLER (40 dakika)**
- **10:25-10:40**: Veri Tipleri (15 dk)
  - int, string, bool, double tipleri
  - Değişken tanımlama
  - Örnek: Yaş hesaplama programı

- **10:40-10:55**: Operatörler (15 dk)
  - Aritmetik operatörler
  - Basit hesap makinesi
  - Pratik egzersiz

- **10:55-11:05**: Tip Dönüşümleri (10 dk)
  - Parse ve Convert metodları
  - TryParse kullanımı

##### **11:05-11:15: ARA (10 dakika)**

##### **11:15-12:00: KONTROL YAPILARI (45 dakika)**
- **11:15-11:30**: Karar Yapıları (15 dk)
  - if-else yapıları
  - Gerçek örnek: Not sistemi
  - Switch-case giriş

- **11:30-11:50**: Döngüler (20 dk)
  - for döngüsü
  - while döngüsü
  - Pratik: Sayı tahmin oyunu

- **11:50-12:00**: Kontrol İfadeleri (10 dk)
  - break ve continue
  - Nested yapılar

##### **12:00-12:35: DİZİLER VE METOTLAR (35 dakika)**
- **12:00-12:20**: Diziler (20 dk)
  - Dizi tanımlama ve kullanım
  - Dizi metodları
  - Pratik: Öğrenci not sistemi

- **12:20-12:35**: Metotlar (15 dk)
  - Metot tanımlama
  - Parametreler ve return değerleri
  - Gerçek örnek: Hesap makinesi

##### **12:35-12:45: YENİ KONULAR (10 dakika)**
- String işlemleri tanıtımı
- DateTime kullanımı
- Try-catch mantığı

##### **12:45-12:55: ALGORİTMA PRATİĞİ (10 dakika)**
- Kolay seviye algoritma çözümü
- Öğrenci katılımı
- Q&A oturumu

##### **12:55-13:00: KAPANIŞ (5 dakika)**
- Eğitim özeti
- Kaynaklar ve sonraki adımlar
- Değerlendirme formu

---

#### **🎯 ÖĞRETİM STRATEJİLERİ**

##### **1. Problem Çözme Metodolojisi**
- **Adım 1**: Problemi anlama ve parçalara ayırma
- **Adım 2**: Çözüm yolu planlama
- **Adım 3**: Kod yazma ve test etme
- **Adım 4**: Hata ayıklama ve optimizasyon

##### **2. Interactive Learning Teknikleri**
- **Soru-Cevap**: Her bölüm sonunda öğrenci soruları
- **Live Coding**: Canlı kod yazma gösterimleri
- **Grup Çalışması**: 2-3 kişilik mini takımlar
- **Code Review**: Öğrencilerin kodlarını birlikte inceleme

##### **3. Common Mistakes ve Çözümleri**
- **Hata**: Null reference exceptions
  - **Çözüm**: Null kontrollerini öğretme
- **Hata**: Array index out of bounds
  - **Çözüm**: Index kontrolleri ve safe coding
- **Hata**: Type conversion errors
  - **Çözüm**: TryParse ve validation

##### **4. Best Practices ve İpuçları**
- **Naming Conventions**: Anlamlı değişken isimleri kullanma
- **Code Structure**: Metotları küçük ve odaklanmış tutma
- **Error Handling**: Try-catch bloklarını öğrenme
- **Comments**: Açıklayıcı yorumlar yazma

---

#### **📊 DEĞERLENDİRME KRİTERLERİ**

##### **Başlangıç Seviyesi Değerlendirmesi (40 puan)**
- **Veri Tipleri** (10 puan): Temel tipleri doğru kullanma
- **Değişkenler** (10 puan): Doğru tanımlama ve atama
- **Operatörler** (10 puan): Temel matematik işlemleri
- **Basit Giriş/Çıkış** (10 puan): Console.WriteLine ve ReadLine

##### **Orta Seviye Değerlendirmesi (40 puan)**
- **Kontrol Yapıları** (15 puan): if-else, switch-case doğru kullanımı
- **Döngüler** (15 puan): for, while, do-while döngüleri
- **Metotlar** (10 puan): Temel metot yazma ve kullanma

##### **İleri Seviye Değerlendirmesi (20 puan)**
- **Diziler** (10 puan): Dizi işlemleri ve algoritmalar
- **Problem Çözme** (10 puan): Karmaşık problemlere yaklaşım

##### **Rubrik ve Geri Bildirim**
- **Mükemmel (90-100)**: Tüm gereksinimleri eksiksiz karşılar
- **İyi (80-89)**: Küçük hatalarla genel doğru çözüm
- **Orta (70-79)**: Temel gereksinimler karşılanmış
- **Gelişmeli (60-69)**: Ek çalışma gerekli
- **Yetersiz (<60)**: Temel konular tekrar edilmeli

---

#### **🔗 EK KAYNAKLAR**

##### **Online Platformlar**
- **Microsoft Learn**: Resmi C# dokümantasyonu
- **C# Corner**: Topluluk ve örnekler
- **GitHub**: Açık kaynak C# projeleri
- **Stack Overflow**: Programlama soru-cevap platformu

##### **Kitap Önerileri**
- "C# 8.0 in a Nutshell" - Joseph Albahari
- "Head First C#" - Jennifer Greene & Andrew Stellman
- "Pro C# 9 with .NET 5" - Andrew Troelsen & Phil Japikse

##### **Video Eğitimleri**
- **Microsoft Virtual Academy**: Ücretsiz C# kursları
- **YouTube**: Ücretsiz C# eğitim videoları
- **Pluralsight**: Ücretli kapsamlı kurslar

##### **Pratik Proje Önerileri**
1. **Basit Hesap Makinesi**: Temel operatör kullanımı
2. **Öğrenci Not Sistemi**: Dizi ve metot pratiği
3. **ATM Simülasyonu**: Kontrol yapıları pratiği
4. **Todo List Uygulaması**: Koleksiyonlar ve string işlemleri
5. **Web API Projesi**: İleri seviye C# kullanımı

---

#### **📈 EĞİTİM BAŞARISINI ARTIRMA**

##### **Ön Hazırlık**
- Bilgisayar ve Visual Studio kurulumu
- Temel bilgisayar kullanım becerileri
- Matematik temel bilgiler

##### **Eğitim Sırasında**
- Aktif katılım ve soru sorma
- Kod yazma pratiği yapma
- Arkadaşlarla işbirliği
- Not alma ve tekrar

##### **Eğitim Sonrası**
- Günlük 30 dakika pratik kod yazma
- Küçük projeler geliştirme
- Online kaynaklardan öğrenme
- Topluluklara katılım

Bu kapsamlı eğitim planı ile öğrencilerin C# programlamada sağlam bir temel kazanması ve ileri seviye konulara hazırlanması hedeflenmektedir.

---

**🎉 EĞİTİM TAMAMLANDI! 🎉**

**Toplam İçerik Özeti:**
- **📚 15 Ana Bölüm** - Temel ve ileri konular
- **⚙️ 100+ Kod Örneği** - Detaylı açıklamalarla
- **🎯 80+ Algoritma Sorusu** - Kolay, orta, zor seviyelerde
- **📖 4000+ Satır** - Kapsamlı eğitim materyali
- **⏰ 3 Saatlik Eğitim Planı** - Optimize edilmiş program
- **🎓 Sertifika Değerlendirme** - Başarı kriterleri ve rubrik


##  EK ALGORİTMA SORULARI (Bonus)

### 48. Armstrong Sayısı Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (ArmstrongMi(sayi))
            Console.WriteLine($"{sayi} Armstrong sayısıdır.");
        else
            Console.WriteLine($"{sayi} Armstrong sayısı değildir.");
    }
    
    static bool ArmstrongMi(int sayi)
    {
        int orijinalSayi = sayi;
        int toplam = 0;
        int basamakSayisi = BasamakSayisi(sayi);
        
        while (sayi > 0)
        {
            int basamak = sayi % 10;
            toplam += (int)Math.Pow(basamak, basamakSayisi);
            sayi /= 10;
        }
        
        return toplam == orijinalSayi;
    }
    
    static int BasamakSayisi(int sayi)
    {
        int sayac = 0;
        while (sayi > 0)
        {
            sayac++;
            sayi /= 10;
        }
        return sayac;
    }
}
```

### 49. Palindrom Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir kelime girin: ");
        string kelime = Console.ReadLine();
        
        if (PalindromMu(kelime))
            Console.WriteLine($"{kelime} palindromdur.");
        else
            Console.WriteLine($"{kelime} palindrom değildir.");
    }
    
    static bool PalindromMu(string metin)
    {
        metin = metin.ToLower();
        
        for (int i = 0; i < metin.Length / 2; i++)
        {
            if (metin[i] != metin[metin.Length - 1 - i])
                return false;
        }
        
        return true;
    }
}
```

### 50. Perfect Number (Mükemmel Sayı) Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (PerfectMi(sayi))
            Console.WriteLine($"{sayi} mükemmel sayıdır.");
        else
            Console.WriteLine($"{sayi} mükemmel sayı değildir.");
    }
    
    static bool PerfectMi(int sayi)
    {
        int toplam = 0;
        
        for (int i = 1; i <= sayi / 2; i++)
        {
            if (sayi % i == 0)
                toplam += i;
        }
        
        return toplam == sayi;
    }
}
```

### 51. Harshad Sayısı (Niven Number) Kontrolü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (HarshadMi(sayi))
            Console.WriteLine($"{sayi} Harshad sayısıdır.");
        else
            Console.WriteLine($"{sayi} Harshad sayısı değildir.");
    }
    
    static bool HarshadMi(int sayi)
    {
        int toplam = BasamakToplami(sayi);
        return sayi % toplam == 0;
    }
    
    static int BasamakToplami(int sayi)
    {
        int toplam = 0;
        while (sayi > 0)
        {
            toplam += sayi % 10;
            sayi /= 10;
        }
        return toplam;
    }
}
```

### 52. Fibonacci Serisinde Sayı Var Mı?
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Aranacak sayıyı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (FibonacciVarMi(sayi))
            Console.WriteLine($"{sayi} Fibonacci serisinde vardır.");
        else
            Console.WriteLine($"{sayi} Fibonacci serisinde yoktur.");
    }
    
    static bool FibonacciVarMi(int sayi)
    {
        int a = 0, b = 1, c = 1;
        
        while (a <= sayi)
        {
            if (a == sayi)
                return true;
            
            c = a + b;
            a = b;
            b = c;
        }
        
        return false;
    }
}
```

### 53. Goldbach Sanısı (Çift Sayılar İçin)
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Çift bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (sayi % 2 != 0)
        {
            Console.WriteLine("Lütfen çift bir sayı girin.");
            return;
        }
        
        GoldbachSanisi(sayi);
    }
    
    static void GoldbachSanisi(int sayi)
    {
        Console.WriteLine($"\n{sayi} sayısı için Goldbach kombinasyonları:");
        
        for (int p1 = 2; p1 <= sayi / 2; p1++)
        {
            if (AsalMi(p1) && AsalMi(sayi - p1))
            {
                Console.WriteLine($"{sayi} = {p1} + {sayi - p1}");
            }
        }
    }
    
    static bool AsalMi(int sayi)
    {
        if (sayi < 2) return false;
        
        for (int i = 2; i * i <= sayi; i++)
        {
            if (sayi % i == 0)
                return false;
        }
        
        return true;
    }
}
```

### 54. Çoktan Seçmeli Sınav Sistemi
```csharp
using System;

class Program
{
    static void Main()
    {
        string[] sorular = {
            "C# hangi şirket tarafından geliştirilmiştir?",
            "Hangi operatör toplama yapar?",
            "Console.WriteLine() ne yapar?"
        };
        
        string[,] secenekler = {
            {"A) Google", "B) Microsoft", "C) Apple", "D) Facebook"},
            {"A) -", "B) +", "C) *", "D) /"},
            {"A) Veri okur", "B) Veri yazar", "C) Veri siler", "D) Veri kaydeder"}
        };
        
        int[] dogruCevaplar = {1, 1, 1}; // B, B, B
        int puan = 0;
        
        Console.WriteLine("=== ÇOKTAN SEÇMELİ SINAV ===\n");
        
        for (int i = 0; i < sorular.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + sorular[i]);
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("   " + secenekler[i, j]);
            }
            
            Console.Write("\nCevabınızı seçin (A/B/C/D): ");
            string cevap = Console.ReadLine().ToUpper();
            
            int cevapIndexi = CevapHarfiIndex(cevap);
            
            if (cevapIndexi == dogruCevaplar[i])
            {
                Console.WriteLine(" Doğru!\n");
                puan += 25;
            }
            else
            {
                Console.WriteLine(" Yanlış!\n");
            }
        }
        
        Console.WriteLine($"=== SINAV SONUCU ===");
        Console.WriteLine($"Toplam Puan: {puan}/100");
        
        if (puan >= 70)
            Console.WriteLine(" Başarılı!");
        else
            Console.WriteLine(" Daha çalışmanız gerekiyor.");
    }
    
    static int CevapHarfiIndex(string harf)
    {
        switch (harf)
        {
            case "A": return 0;
            case "B": return 1;
            case "C": return 2;
            case "D": return 3;
            default: return -1;
        }
    }
}
```

### 55. Basit Öğrenci Takip Sistemi
```csharp
using System;

class Program
{
    static void Main()
    {
        string[] ogrenciler = new string[100];
        int[] notlar = new int[100];
        int ogrenciSayisi = 0;
        int secim;
        
        do
        {
            Console.WriteLine("\n=== ÖĞRENCİ TAKİP SİSTEMİ ===");
            Console.WriteLine("1. Öğrenci Ekle");
            Console.WriteLine("2. Not Ekle");
            Console.WriteLine("3. Tüm Öğrencileri Listele");
            Console.WriteLine("4. En Yüksek Not");
            Console.WriteLine("5. Ortalama Hesapla");
            Console.WriteLine("6. Çıkış");
            Console.Write("Seçiminiz: ");
            
            secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    Console.Write("Öğrenci adı: ");
                    ogrenciler[ogrenciSayisi] = Console.ReadLine();
                    ogrenciSayisi++;
                    Console.WriteLine("Öğrenci eklendi!");
                    break;
                    
                case 2:
                    Console.Write("Öğrenci numarası (1-" + ogrenciSayisi + "): ");
                    int no = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (no >= 0 && no < ogrenciSayisi)
                    {
                        Console.Write("Not: ");
                        notlar[no] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Not eklendi!");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz öğrenci numarası!");
                    }
                    break;
                    
                case 3:
                    Console.WriteLine("\n=== ÖĞRENCİ LİSTESİ ===");
                    for (int i = 0; i < ogrenciSayisi; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + ogrenciler[i] + " - Not: " + notlar[i]);
                    }
                    break;
                    
                case 4:
                    int maxNot = 0;
                    string enIyiOgrenci = "";
                    for (int i = 0; i < ogrenciSayisi; i++)
                    {
                        if (notlar[i] > maxNot)
                        {
                            maxNot = notlar[i];
                            enIyiOgrenci = ogrenciler[i];
                        }
                    }
                    Console.WriteLine($"En yüksek not: {maxNot} ({enIyiOgrenci})");
                    break;
                    
                case 5:
                    if (ogrenciSayisi > 0)
                    {
                        double toplam = 0;
                        for (int i = 0; i < ogrenciSayisi; i++)
                        {
                            toplam += notlar[i];
                        }
                        double ortalama = toplam / ogrenciSayisi;
                        Console.WriteLine($"Ortalama: {ortalama:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Henüz öğrenci eklenmedi!");
                    }
                    break;
                    
                case 6:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                    
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
            
        } while (secim != 6);
    }
}
```

### 56. ATM Simülasyonu
```csharp
using System;

class Program
{
    static void Main()
    {
        double bakiye = 1000.0;
        int kullaniciKodu = 1234;
        int girisHakki = 3;
        
        Console.WriteLine("=== ATM SİSTEMİ ===");
        
        while (girisHakki > 0)
        {
            Console.Write("Kullanıcı kodunuzu girin: ");
            int kod = Convert.ToInt32(Console.ReadLine());
            
            if (kod == kullaniciKodu)
            {
                Console.WriteLine($"Hoş geldiniz! Mevcut bakiyeniz: {bakiye:C}");
                ATMMenusu(ref bakiye);
                break;
            }
            else
            {
                girisHakki--;
                Console.WriteLine($"Yanlış kod! Kalan hak: {girisHakki}");
            }
        }
        
        if (girisHakki == 0)
        {
            Console.WriteLine("Kartınız bloke edildi!");
        }
    }
    
    static void ATMMenusu(ref double bakiye)
    {
        int secim;
        
        do
        {
            Console.WriteLine("\n=== ATM MENÜSÜ ===");
            Console.WriteLine("1. Bakiye Sorgula");
            Console.WriteLine("2. Para Çek");
            Console.WriteLine("3. Para Yatır");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");
            
            secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    Console.WriteLine($"Mevcut bakiyeniz: {bakiye:C}");
                    break;
                    
                case 2:
                    Console.Write("Çekmek istediğiniz tutar: ");
                    double cekilen = Convert.ToDouble(Console.ReadLine());
                    
                    if (cekilen <= bakiye && cekilen > 0)
                    {
                        bakiye -= cekilen;
                        Console.WriteLine($"{cekilen:C} çekildi. Yeni bakiye: {bakiye:C}");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye veya geçersiz tutar!");
                    }
                    break;
                    
                case 3:
                    Console.Write("Yatırmak istediğiniz tutar: ");
                    double yatirilan = Convert.ToDouble(Console.ReadLine());
                    
                    if (yatirilan > 0)
                    {
                        bakiye += yatirilan;
                        Console.WriteLine($"{yatirilan:C} yatırıldı. Yeni bakiye: {bakiye:C}");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz tutar!");
                    }
                    break;
                    
                case 4:
                    Console.WriteLine("İyi günler!");
                    break;
                    
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
            
        } while (secim != 4);
    }
}
```

### 57. Sayı Tahmin Oyunu
```csharp
using System;

class Program
{
    static void Main()
    {
        Random rastgele = new Random();
        int gizliSayi = rastgele.Next(1, 101);
        int tahminSayisi = 0;
        int tahmin;
        int maxTahmin = 7;
        
        Console.WriteLine("=== SAYI TAHMİN OYUNU ===");
        Console.WriteLine("1-100 arasında bir sayı tuttum. Tahmin edin!");
        Console.WriteLine($"En fazla {maxTahmin} hakkınız var.");
        
        do
        {
            Console.Write($"\nTahmininiz ({maxTahmin - tahminSayisi} hak kaldı): ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            tahminSayisi++;
            
            if (tahmin == gizliSayi)
            {
                Console.WriteLine($" Tebrikler! {tahminSayisi}. denemede buldunuz!");
                break;
            }
            else if (tahmin < gizliSayi)
            {
                Console.WriteLine(" Daha büyük bir sayı deneyin!");
            }
            else
            {
                Console.WriteLine(" Daha küçük bir sayı deneyin!");
            }
            
            if (tahminSayisi >= maxTahmin)
            {
                Console.WriteLine($" Haklarınız bitti! Gizli sayı {gizliSayi} idi.");
            }
            
        } while (tahminSayisi < maxTahmin);
    }
}
```

### 58. Basit Kelime Sayacı
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== KELİME SAYICI ===");
        Console.WriteLine("Bir metin girin (çıkmak için 'bitir' yazın):");
        
        int kelimeSayisi = 0;
        int karakterSayisi = 0;
        int cumleSayisi = 0;
        int satirSayisi = 1;
        
        string metin;
        
        while (true)
        {
            Console.Write($"Satır {satirSayisi}: ");
            metin = Console.ReadLine();
            
            if (metin.ToLower() == "bitir")
                break;
            
            // Kelime sayma
            string[] kelimeler = metin.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            kelimeSayisi += kelimeler.Length;
            
            // Karakter sayma (boşluklar hariç)
            karakterSayisi += metin.Replace(" ", "").Length;
            
            // Cümle sayma
            cumleSayisi += metin.Split('.').Length - 1;
            
            satirSayisi++;
        }
        
        Console.WriteLine("\n=== İSTATİSTİKLER ===");
        Console.WriteLine($"Toplam Satır: {satirSayisi - 1}");
        Console.WriteLine($"Toplam Kelime: {kelimeSayisi}");
        Console.WriteLine($"Toplam Karakter: {karakterSayisi}");
        Console.WriteLine($"Toplam Cümle: {cumleSayisi}");
        Console.WriteLine($"Ortalama Kelime/Satır: {(double)kelimeSayisi / (satirSayisi - 1):F1}");
    }
}
```

### 59. Çok Satırlı Çarpım Tablosu
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç sayıya kadar çarpım tablosu oluşturalım? ");
        int limit = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"\n=== {limit}x{limit} ÇARPIM TABLOSU ===");
        
        // Başlık
        Console.Write("     ");
        for (int i = 1; i <= limit; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine();
        
        // Çarpım tablosu
        for (int i = 1; i <= limit; i++)
        {
            Console.Write($"{i,4} ");
            for (int j = 1; j <= limit; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
        
        // Özel istekler
        Console.WriteLine("\n=== ÖZEL İSTEKLER ===");
        Console.Write("Hangi sayının çarpım tablosunu görmek istiyorsunuz? ");
        int ozelSayi = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"\n{ozelSayi} Sayısının Çarpım Tablosu:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{ozelSayi} x {i} = {ozelSayi * i}");
        }
    }
}
```

### 60. Geometrik Şekiller Hesaplayıcısı
```csharp
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== GEOMETRİK ŞEKİLLER ===");
            Console.WriteLine("1. Daire");
            Console.WriteLine("2. Dikdörtgen");
            Console.WriteLine("3. Üçgen");
            Console.WriteLine("4. Kare");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    DaireHesaplari();
                    break;
                case 2:
                    DikdortgenHesaplari();
                    break;
                case 3:
                    UcgenHesaplari();
                    break;
                case 4:
                    KareHesaplari();
                    break;
                case 5:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
    
    static void DaireHesaplari()
    {
        Console.Write("Yarıçap: ");
        double r = Convert.ToDouble(Console.ReadLine());
        
        double alan = Math.PI * r * r;
        double cevre = 2 * Math.PI * r;
        
        Console.WriteLine($"Daire Alanı: {alan:F2}");
        Console.WriteLine($"Daire Çevresi: {cevre:F2}");
    }
    
    static void DikdortgenHesaplari()
    {
        Console.Write("Uzun kenar: ");
        double uzun = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Kısa kenar: ");
        double kisa = Convert.ToDouble(Console.ReadLine());
        
        double alan = uzun * kisa;
        double cevre = 2 * (uzun + kisa);
        
        Console.WriteLine($"Dikdörtgen Alanı: {alan:F2}");
        Console.WriteLine($"Dikdörtgen Çevresi: {cevre:F2}");
    }
    
    static void UcgenHesaplari()
    {
        Console.Write("Taban uzunluğu: ");
        double taban = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Yükseklik: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("1. Kenar: ");
        double kenar1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("2. Kenar: ");
        double kenar2 = Convert.ToDouble(Console.ReadLine());
        
        double alan = 0.5 * taban * yukseklik;
        double cevre = taban + kenar1 + kenar2;
        
        Console.WriteLine($"Üçgen Alanı: {alan:F2}");
        Console.WriteLine($"Üçgen Çevresi: {cevre:F2}");
    }
    
    static void KareHesaplari()
    {
        Console.Write("Kenar uzunluğu: ");
        double kenar = Convert.ToDouble(Console.ReadLine());
        
        double alan = kenar * kenar;
        double cevre = 4 * kenar;
        
        Console.WriteLine($"Kare Alanı: {alan:F2}");
        Console.WriteLine($"Kare Çevresi: {cevre:F2}");
    }
}
```

### 61. ASCII Art Çizer
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ASCII ART ÇİZERİ ===");
        
        Console.Write("1. Kare çiz");
        Console.Write("2. Dikdörtgen çiz");
        Console.Write("3. Üçgen çiz");
        Console.Write("4. Çıkış");
        
        while (true)
        {
            Console.Write("\nSeçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    KareCiz();
                    break;
                case 2:
                    DikdortgenCiz();
                    break;
                case 3:
                    UcgenCiz();
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
    
    static void KareCiz()
    {
        Console.Write("Kare boyutu: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                if (i == 0 || i == boyut - 1 || j == 0 || j == boyut - 1)
                    Console.Write("█");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    
    static void DikdortgenCiz()
    {
        Console.Write("Genişlik: ");
        int genislik = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Yükseklik: ");
        int yukseklik = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < yukseklik; i++)
        {
            for (int j = 0; j < genislik; j++)
            {
                if (i == 0 || i == yukseklik - 1 || j == 0 || j == genislik - 1)
                    Console.Write("█");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    
    static void UcgenCiz()
    {
        Console.Write("Üçgen yüksekliği: ");
        int yukseklik = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < yukseklik; i++)
        {
            for (int j = 0; j < yukseklik - i - 1; j++)
            {
                Console.Write(" ");
            }
            
            for (int j = 0; j <= i; j++)
            {
                Console.Write("█");
            }
            Console.WriteLine();
        }
    }
}
```

### 62. Basit Telefon Rehberi
```csharp
using System;

class Program
{
    static void Main()
    {
        string[] isimler = new string[100];
        string[] telefonlar = new string[100];
        int kisiSayisi = 0;
        
        while (true)
        {
            Console.WriteLine("\n=== TELEFON REHBERİ ===");
            Console.WriteLine("1. Kişi Ekle");
            Console.WriteLine("2. Kişi Ara");
            Console.WriteLine("3. Tümünü Listele");
            Console.WriteLine("4. Kişi Sil");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    if (kisiSayisi < 100)
                    {
                        Console.Write("İsim: ");
                        isimler[kisiSayisi] = Console.ReadLine();
                        Console.Write("Telefon: ");
                        telefonlar[kisiSayisi] = Console.ReadLine();
                        kisiSayisi++;
                        Console.WriteLine("Kişi eklendi!");
                    }
                    else
                    {
                        Console.WriteLine("Rehber dolu!");
                    }
                    break;
                    
                case 2:
                    Console.Write("Aranacak isim: ");
                    string arama = Console.ReadLine();
                    bool bulundu = false;
                    
                    for (int i = 0; i < kisiSayisi; i++)
                    {
                        if (isimler[i].ToLower().Contains(arama.ToLower()))
                        {
                            Console.WriteLine($"{isimler[i]} - {telefonlar[i]}");
                            bulundu = true;
                        }
                    }
                    
                    if (!bulundu)
                    {
                        Console.WriteLine("Kişi bulunamadı!");
                    }
                    break;
                    
                case 3:
                    Console.WriteLine("\n=== KİŞİ LİSTESİ ===");
                    for (int i = 0; i < kisiSayisi; i++)
                    {
                        Console.WriteLine($"{i + 1}. {isimler[i]} - {telefonlar[i]}");
                    }
                    break;
                    
                case 4:
                    Console.Write("Silinecek kişinin sırası: ");
                    int silSira = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    if (silSira >= 0 && silSira < kisiSayisi)
                    {
                        for (int i = silSira; i < kisiSayisi - 1; i++)
                        {
                            isimler[i] = isimler[i + 1];
                            telefonlar[i] = telefonlar[i + 1];
                        }
                        kisiSayisi--;
                        Console.WriteLine("Kişi silindi!");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz sıra!");
                    }
                    break;
                    
                case 5:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                    
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
```

### 63. Roman Sayı Dönüştürücüsü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("1-3999 arası sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (sayi >= 1 && sayi <= 3999)
        {
            string roman = SayiyiRoma(sayi);
            Console.WriteLine($"Roman karşılığı: {roman}");
        }
        else
        {
            Console.WriteLine("Geçersiz sayı! (1-3999 arası)");
        }
    }
    
    static string SayiyiRoma(int sayi)
    {
        string[] binlik = {"", "M", "MM", "MMM"};
        string[] yuzluk = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        string[] onluk = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        string[] birler = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
        
        int bin = sayi / 1000;
        int yuz = (sayi % 1000) / 100;
        int on = (sayi % 100) / 10;
        int bir = sayi % 10;
        
        return binlik[bin] + yuzluk[yuz] + onluk[on] + birler[bir];
    }
}
```

### 64. Basit Dosya Yönetimi
```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string dosyaAdi = "notlar.txt";
        
        while (true)
        {
            Console.WriteLine("\n=== DOSYA YÖNETİMİ ===");
            Console.WriteLine("1. Not Ekle");
            Console.WriteLine("2. Notları Listele");
            Console.WriteLine("3. Not Sil");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    Console.Write("Eklenecek not: ");
                    string not = Console.ReadLine();
                    File.AppendAllText(dosyaAdi, not + Environment.NewLine);
                    Console.WriteLine("Not eklendi!");
                    break;
                    
                case 2:
                    if (File.Exists(dosyaAdi))
                    {
                        Console.WriteLine("\n=== NOTLAR ===");
                        string[] notlar = File.ReadAllLines(dosyaAdi);
                        for (int i = 0; i < notlar.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {notlar[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Henüz not yok!");
                    }
                    break;
                    
                case 3:
                    if (File.Exists(dosyaAdi))
                    {
                        Console.Write("Silinecek not numarası: ");
                        int notNo = Convert.ToInt32(Console.ReadLine()) - 1;
                        
                        string[] notlar = File.ReadAllLines(dosyaAdi);
                        
                        if (notNo >= 0 && notNo < notlar.Length)
                        {
                            File.WriteAllText(dosyaAdi, "");
                            
                            for (int i = 0; i < notlar.Length; i++)
                            {
                                if (i != notNo)
                                {
                                    File.AppendAllText(dosyaAdi, notlar[i] + Environment.NewLine);
                                }
                            }
                            
                            Console.WriteLine("Not silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz not numarası!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Henüz not yok!");
                    }
                    break;
                    
                case 4:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                    
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
```

### 65. Zamanlayıcı ve Kronometre
```csharp
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== ZAMANLAYICI ===");
            Console.WriteLine("1. Kronometre");
            Console.WriteLine("2. Geri Sayım Zamanlayıcısı");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminiz: ");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    Kronometre();
                    break;
                case 2:
                    GeriSayim();
                    break;
                case 3:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
    
    static void Kronometre()
    {
        Console.WriteLine("Kronometre başlatıldı! (Durdurmak için herhangi bir tuşa basın)");
        Console.WriteLine("00:00:00");
        
        DateTime baslangic = DateTime.Now;
        int saniye = 0, dakika = 0, saat = 0;
        
        while (!Console.KeyAvailable)
        {
            Thread.Sleep(1000);
            saniye++;
            
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
                
                if (dakika == 60)
                {
                    dakika = 0;
                    saat++;
                }
            }
            
            Console.Clear();
            Console.WriteLine($"Kronometre: {saat:D2}:{dakika:D2}:{saniye:D2}");
            Console.WriteLine("Durdurmak için herhangi bir tuşa basın");
        }
        
        Console.ReadKey();
    }
    
    static void GeriSayim()
    {
        Console.Write("Dakika: ");
        int dakika = Convert.ToInt32(Console.ReadLine());
        Console.Write("Saniye: ");
        int saniye = Convert.ToInt32(Console.ReadLine());
        
        int toplamSaniye = dakika * 60 + saniye;
        
        Console.WriteLine("\nGeri sayım başladı!");
        
        for (int i = toplamSaniye; i >= 0; i--)
        {
            int kalanDakika = i / 60;
            int kalanSaniye = i % 60;
            
            Console.Write($"\rKalan zaman: {kalanDakika:D2}:{kalanSaniye:D2}");
            
            if (i == 0)
            {
                Console.WriteLine("\n⏰ ZAMAN!");
                break;
            }
            
            Thread.Sleep(1000);
        }
    }
}
```

### 66. Matris Çarpımı
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("İlk matrisin satır sayısı: ");
        int satir1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İlk matrisin sütun sayısı: ");
        int sutun1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("İkinci matrisin satır sayısı: ");
        int satir2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci matrisin sütun sayısı: ");
        int sutun2 = Convert.ToInt32(Console.ReadLine());
        
        if (sutun1 != satir2)
        {
            Console.WriteLine("Matrisler çarpılamaz! İlk matrisin sütun sayısı ikincinin satır sayısına eşit olmalı.");
            return;
        }
        
        int[,] matris1 = new int[satir1, sutun1];
        int[,] matris2 = new int[satir2, sutun2];
        int[,] sonuc = new int[satir1, sutun2];
        
        Console.WriteLine("\nİlk matrisin elemanlarını girin:");
        for (int i = 0; i < satir1; i++)
        {
            for (int j = 0; j < sutun1; j++)
            {
                Console.Write($"[{i},{j}]: ");
                matris1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine("\nİkinci matrisin elemanlarını girin:");
        for (int i = 0; i < satir2; i++)
        {
            for (int j = 0; j < sutun2; j++)
            {
                Console.Write($"[{i},{j}]: ");
                matris2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        // Matris çarpımı
        for (int i = 0; i < satir1; i++)
        {
            for (int j = 0; j < sutun2; j++)
            {
                for (int k = 0; k < sutun1; k++)
                {
                    sonuc[i, j] += matris1[i, k] * matris2[k, j];
                }
            }
        }
        
        Console.WriteLine("\n=== SONUC MATRİSİ ===");
        for (int i = 0; i < satir1; i++)
        {
            for (int j = 0; j < sutun2; j++)
            {
                Console.Write($"{sonuc[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
```

### 67. Basit Şifre Üreticisi
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Şifre uzunluğu: ");
        int uzunluk = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Şifre sayısı: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        string[] sifreler = new string[sayi];
        
        for (int i = 0; i < sayi; i++)
        {
            sifreler[i] = SifreOlustur(uzunluk);
            Console.WriteLine($"Şifre {i + 1}: {sifreler[i]}");
        }
        
        Console.WriteLine("\n=== GÜVENLİK SKORU ===");
        for (int i = 0; i < sayi; i++)
        {
            int guvenlikSkoru = GuvenlikSkoru(sifreler[i]);
            Console.WriteLine($"Şifre {i + 1}: {guvenlikSkoru}/100 - {GuvenlikDurumu(guvenlikSkoru)}");
        }
    }
    
    static string SifreOlustur(int uzunluk)
    {
        string buyukHarfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string kucukHarfler = "abcdefghijklmnopqrstuvwxyz";
        string rakamlar = "0123456789";
        string ozelKarakterler = "!@#$%^&*()_+-=[]{}|;:,.<>?";
        string tumKarakterler = buyukHarfler + kucukHarfler + rakamlar + ozelKarakterler;
        
        Random rastgele = new Random();
        string sifre = "";
        
        // Her kategoriden en az bir karakter
        sifre += buyukHarfler[rastgele.Next(buyukHarfler.Length)];
        sifre += kucukHarfler[rastgele.Next(kucukHarfler.Length)];
        sifre += rakamlar[rastgele.Next(rakamlar.Length)];
        sifre += ozelKarakterler[rastgele.Next(ozelKarakterler.Length)];
        
        // Kalan karakterleri rastgele doldur
        for (int i = 4; i < uzunluk; i++)
        {
            sifre += tumKarakterler[rastgele.Next(tumKarakterler.Length)];
        }
        
        // Şifreyi karıştır
        return SifreKaristir(sifre);
    }
    
    static string SifreKaristir(string sifre)
    {
        char[] karakterler = sifre.ToCharArray();
        Random rastgele = new Random();
        
        for (int i = karakterler.Length - 1; i > 0; i--)
        {
            int j = rastgele.Next(i + 1);
            (karakterler[i], karakterler[j]) = (karakterler[j], karakterler[i]);
        }
        
        return new string(karakterler);
    }
    
    static int GuvenlikSkoru(string sifre)
    {
        int skor = 0;
        
        // Uzunluk skoru
        if (sifre.Length >= 8) skor += 25;
        if (sifre.Length >= 12) skor += 10;
        
        // Karakter çeşitliliği
        if (sifre.Any(char.IsUpper)) skor += 15;
        if (sifre.Any(char.IsLower)) skor += 15;
        if (sifre.Any(char.IsDigit)) skor += 15;
        if (sifre.Any(c => "!@#$%^&*()_+-=[]{}|;:,.<>?".Contains(c))) skor += 20;
        
        return Math.Min(skor, 100);
    }
    
    static string GuvenlikDurumu(int skor)
    {
        if (skor >= 90) return "Çok Güçlü";
        if (skor >= 70) return "Güçlü";
        if (skor >= 50) return "Orta";
        if (skor >= 30) return "Zayıf";
        return "Çok Zayıf";
    }
}
```

### 68. Basit Oyun: Taş-Kağıt-Makas
```csharp
using System;

class Program
{
    static void Main()
    {
        string[] secenekler = { "Taş", "Kağıt", "Makas" };
        int oyuncuSkor = 0, bilgisayarSkor = 0, beraberlik = 0;
        int oyunSayisi;
        
        Console.Write("Kaç oyun oynamak istiyorsunuz? ");
        oyunSayisi = Convert.ToInt32(Console.ReadLine());
        Random rastgele = new Random();
        
        for (int i = 1; i <= oyunSayisi; i++)
        {
            Console.WriteLine($"\n=== {i}. OYUN ===");
            Console.WriteLine("1. Taş");
            Console.WriteLine("2. Kağıt");
            Console.WriteLine("3. Makas");
            Console.Write("Seçiminiz: ");
            
            int oyuncuSecim = Convert.ToInt32(Console.ReadLine()) - 1;
            int bilgisayarSecim = rastgele.Next(3);
            
            Console.WriteLine($"Siz: {secenekler[oyuncuSecim]}");
            Console.WriteLine($"Bilgisayar: {secenekler[bilgisayarSecim]}");
            
            int sonuc = Kazanan(oyuncuSecim, bilgisayarSecim);
            
            if (sonuc == 1)
            {
                Console.WriteLine("🎉 Siz kazandınız!");
                oyuncuSkor++;
            }
            else if (sonuc == -1)
            {
                Console.WriteLine("😔 Bilgisayar kazandı!");
                bilgisayarSkor++;
            }
            else
            {
                Console.WriteLine("🤝 Beraberlik!");
                beraberlik++;
            }
            
            Console.WriteLine($"Skor: Oyuncu {oyuncuSkor} - Bilgisayar {bilgisayarSkor} (Beraberlik: {beraberlik})");
        }
        
        Console.WriteLine("\n=== FİNAL SKORU ===");
        Console.WriteLine($"Oyuncu: {oyuncuSkor} oyun");
        Console.WriteLine($"Bilgisayar: {bilgisayarSkor} oyun");
        Console.WriteLine($"Beraberlik: {beraberlik} oyun");
        
        if (oyuncuSkor > bilgisayarSkor)
            Console.WriteLine("🎉 Genel kazanan: OYUNCU!");
        else if (bilgisayarSkor > oyuncuSkor)
            Console.WriteLine("🤖 Genel kazanan: BİLGİSAYAR!");
        else
            Console.WriteLine("🤝 Berabere kaldınız!");
    }
    
    static int Kazanan(int oyuncu, int bilgisayar)
    {
        // 1: Oyuncu kazandı, -1: Bilgisayar kazandı, 0: Beraberlik
        if (oyuncu == bilgisayar) return 0;
        
        if (oyuncu == 0) // Taş
        {
            return bilgisayar == 2 ? 1 : -1; // Makas'ı yener, Kağıt'ı kaybeder
        }
        else if (oyuncu == 1) // Kağıt
        {
            return bilgisayar == 0 ? 1 : -1; // Taş'ı yener, Makas'ı kaybeder
        }
        else // Makas
        {
            return bilgisayar == 1 ? 1 : -1; // Kağıt'ı yener, Taş'ı kaybeder
        }
    }
}
```

### 69. LCM (En Küçük Ortak Kat) Hesaplama
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("İlk sayı: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("İkinci sayı: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        int lcm = LCM(sayi1, sayi2);
        int gcd = GCD(sayi1, sayi2);
        
        Console.WriteLine($"\nGCD({sayi1}, {sayi2}) = {gcd}");
        Console.WriteLine($"LCM({sayi1}, {sayi2}) = {lcm}");
        
        // GCD ve LCM arasındaki ilişkiyi kontrol et
        long kontrol = (long)sayi1 * sayi2;
        Console.WriteLine($"Kontrol: GCD * LCM = {gcd} * {lcm} = {gcd * lcm}");
        Console.WriteLine($"Sayılar çarpımı: {sayi1} * {sayi2} = {kontrol}");
        Console.WriteLine($"Sonuçlar eşit: {gcd * lcm == kontrol}");
    }
    
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    static int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }
}
```

### 70. Binary (İkili) Dönüştürücü
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BİNARY DÖNÜŞTÜRÜCÜ ===");
        
        while (true)
        {
            Console.WriteLine("\n1. Desimal -> Binary");
            Console.WriteLine("2. Binary -> Desimal");
            Console.WriteLine("3. Hexadecimal -> Desimal");
            Console.WriteLine("4. Desimal -> Hexadecimal");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    DesimalToBinary();
                    break;
                case 2:
                    BinaryToDesimal();
                    break;
                case 3:
                    HexToDesimal();
                    break;
                case 4:
                    DesimalToHex();
                    break;
                case 5:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
    
    static void DesimalToBinary()
    {
        Console.Write("Desimal sayı: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (sayi == 0)
        {
            Console.WriteLine("Binary: 0");
            return;
        }
        
        string binary = "";
        int sayiKopya = sayi;
        
        while (sayiKopya > 0)
        {
            binary = (sayiKopya % 2) + binary;
            sayiKopya /= 2;
        }
        
        Console.WriteLine($"Binary: {binary}");
    }
    
    static void BinaryToDesimal()
    {
        Console.Write("Binary sayı: ");
        string binary = Console.ReadLine();
        
        int desimal = 0;
        int uzunluk = binary.Length;
        
        for (int i = 0; i < uzunluk; i++)
        {
            int basamak = binary[uzunluk - 1 - i] - '0';
            if (basamak == 1)
            {
                desimal += (int)Math.Pow(2, i);
            }
        }
        
        Console.WriteLine($"Desimal: {desimal}");
    }
    
    static void HexToDesimal()
    {
        Console.Write("Hexadecimal sayı: ");
        string hex = Console.ReadLine().ToUpper();
        
        int desimal = 0;
        int uzunluk = hex.Length;
        
        for (int i = 0; i < uzunluk; i++)
        {
            char c = hex[uzunluk - 1 - i];
            int deger;
            
            if (c >= '0' && c <= '9')
                deger = c - '0';
            else
                deger = c - 'A' + 10;
                
            desimal += deger * (int)Math.Pow(16, i);
        }
        
        Console.WriteLine($"Desimal: {desimal}");
    }
    
    static void DesimalToHex()
    {
        Console.Write("Desimal sayı: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if (sayi == 0)
        {
            Console.WriteLine("Hexadecimal: 0");
            return;
        }
        
        string hex = "";
        int sayiKopya = sayi;
        
        while (sayiKopya > 0)
        {
            int kalan = sayiKopya % 16;
            char hexChar = (kalan < 10) ? (char)('0' + kalan) : (char)('A' + kalan - 10);
            hex = hexChar + hex;
            sayiKopya /= 16;
        }
        
        Console.WriteLine($"Hexadecimal: {hex}");
    }
}
```

### 71. Basit Oyun: 2048 (Simpel Versiyon)
```csharp
using System;

class Program
{
    static void Main()
    {
        int[,] oyunAlanı = new int[4, 4] 
        {
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0}
        };
        
        // Başlangıçta 2 tane 2 ekle
        RastgeleSayiEkle(oyunAlanı);
        RastgeleSayiEkle(oyunAlanı);
        
        int skor = 0;
        
        while (true)
        {
            Console.Clear();
            OyunAlaniniGoster(oyunAlanı, skor);
            
            if (OyunBittiMi(oyunAlanı))
            {
                Console.WriteLine("Oyun bitti!");
                break;
            }
            
            Console.WriteLine("\nHareket tuşları: W(↑) A(←) S(↓) D(→)");
            Console.Write("Hamleniz: ");
            string hamle = Console.ReadLine().ToUpper();
            
            int[,] oncekiAlan = (int[,])oyunAlanı.Clone();
            
            switch (hamle)
            {
                case "W":
                    Yukari(oyunAlanı);
                    break;
                case "S":
                    Asagi(oyunAlanı);
                    break;
                case "A":
                    Sola(oyunAlanı);
                    break;
                case "D":
                    Saga(oyunAlanı);
                    break;
                default:
                    Console.WriteLine("Geçersiz hamle!");
                    continue;
            }
            
            if (AlanDegistiMi(oncekiAlan, oyunAlanı))
            {
                RastgeleSayiEkle(oyunAlanı);
            }
        }
    }
    
    static void OyunAlaniniGoster(int[,] oyunAlanı, int skor)
    {
        Console.WriteLine($"Skor: {skor}");
        Console.WriteLine("=== 2048 (Simpel) ===");
        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (oyunAlanı[i, j] == 0)
                    Console.Write("---- ");
                else
                    Console.Write($"{oyunAlanı[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
    
    static void RastgeleSayiEkle(int[,] oyunAlanı)
    {
        Random rastgele = new Random();
        int[] bosPozisyonlar = new int[16];
        int bosSayisi = 0;
        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (oyunAlanı[i, j] == 0)
                {
                    bosPozisyonlar[bosSayisi] = i * 4 + j;
                    bosSayisi++;
                }
            }
        }
        
        if (bosSayisi > 0)
        {
            int pozisyon = bosPozisyonlar[rastgele.Next(bosSayisi)];
            int satir = pozisyon / 4;
            int sutun = pozisyon % 4;
            
            oyunAlanı[satir, sutun] = 2; // Her zaman 2 ekle
        }
    }
    
    static bool OyunBittiMi(int[,] oyunAlanı)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (oyunAlanı[i, j] == 0)
                    return false; // Boş yer varsa oyun devam eder
            }
        }
        return true; // Boş yer yoksa oyun biter
    }
    
    static bool AlanDegistiMi(int[,] onceki, int[,] suanki)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (onceki[i, j] != suanki[i, j])
                    return true;
            }
        }
        return false;
    }
    
    static void Yukari(int[,] oyunAlanı)
    {
        for (int sutun = 0; sutun < 4; sutun++)
        {
            for (int satir = 0; satir < 3; satir++)
            {
                if (oyunAlanı[satir, sutun] == oyunAlanı[satir + 1, sutun])
                {
                    oyunAlanı[satir, sutun] *= 2;
                    oyunAlanı[satir + 1, sutun] = 0;
                }
            }
        }
    }
    
    static void Asagi(int[,] oyunAlanı)
    {
        for (int sutun = 0; sutun < 4; sutun++)
        {
            for (int satir = 3; satir > 0; satir--)
            {
                if (oyunAlanı[satir, sutun] == oyunAlanı[satir - 1, sutun])
                {
                    oyunAlanı[satir, sutun] *= 2;
                    oyunAlanı[satir - 1, sutun] = 0;
                }
            }
        }
    }
    
    static void Sola(int[,] oyunAlanı)
    {
        for (int satir = 0; satir < 4; satir++)
        {
            for (int sutun = 0; sutun < 3; sutun++)
            {
                if (oyunAlanı[satir, sutun] == oyunAlanı[satir, sutun + 1])
                {
                    oyunAlanı[satir, sutun] *= 2;
                    oyunAlanı[satir, sutun + 1] = 0;
                }
            }
        }
    }
    
    static void Saga(int[,] oyunAlanı)
    {
        for (int satir = 0; satir < 4; satir++)
        {
            for (int sutun = 3; sutun > 0; sutun--)
            {
                if (oyunAlanı[satir, sutun] == oyunAlanı[satir, sutun - 1])
                {
                    oyunAlanı[satir, sutun] *= 2;
                    oyunAlanı[satir, sutun - 1] = 0;
                }
            }
        }
    }
}
```

### 72. Çalışma Takvimi Sistemi
```csharp
using System;

class Program
{
    static void Main()
    {
        string[,] takvim = new string[7, 24]; // 7 gün, 24 saat
        
        while (true)
        {
            Console.WriteLine("\n=== ÇALIŞMA TAKVİMİ ===");
            Console.WriteLine("1. Etkinlik Ekle");
            Console.WriteLine("2. Etkinlik Görüntüle");
            Console.WriteLine("3. Günlük Görünüm");
            Console.WriteLine("4. Haftalık Görünüm");
            Console.WriteLine("5. Etkinlik Sil");
            Console.WriteLine("6. Çıkış");
            Console.Write("Seçiminiz: ");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    EtkinlikEkle(takvim);
                    break;
                case 2:
                    EtkinlikGoruntule(takvim);
                    break;
                case 3:
                    GunlukGorunum(takvim);
                    break;
                case 4:
                    HaftalikGorunum(takvim);
                    break;
                case 5:
                    EtkinlikSil(takvim);
                    break;
                case 6:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
    
    static void EtkinlikEkle(string[,] takvim)
    {
        Console.Write("Gün (1-7): ");
        int gun = Convert.ToInt32(Console.ReadLine()) - 1;
        
        Console.Write("Saat (0-23): ");
        int saat = Convert.ToInt32(Console.ReadLine());
        
        if (gun >= 0 && gun < 7 && saat >= 0 && saat < 24)
        {
            Console.Write("Etkinlik adı: ");
            string etkinlik = Console.ReadLine();
            takvim[gun, saat] = etkinlik;
            Console.WriteLine("Etkinlik eklendi!");
        }
        else
        {
            Console.WriteLine("Geçersiz gün veya saat!");
        }
    }
    
    static void EtkinlikGoruntule(string[,] takvim)
    {
        Console.Write("Gün (1-7): ");
        int gun = Convert.ToInt32(Console.ReadLine()) - 1;
        
        Console.Write("Saat (0-23): ");
        int saat = Convert.ToInt32(Console.ReadLine());
        
        if (gun >= 0 && gun < 7 && saat >= 0 && saat < 24)
        {
            if (takvim[gun, saat] != null)
            {
                Console.WriteLine($"Etkinlik: {takvim[gun, saat]}");
            }
            else
            {
                Console.WriteLine("Bu saatte etkinlik yok.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz gün veya saat!");
        }
    }
    
    static void GunlukGorunum(string[,] takvim)
    {
        Console.Write("Gün (1-7): ");
        int gun = Convert.ToInt32(Console.ReadLine()) - 1;
        
        string[] gunIsimleri = {"Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"};
        
        Console.WriteLine($"\n=== {gunIsimleri[gun]} ===");
        
        for (int saat = 0; saat < 24; saat++)
        {
            if (takvim[gun, saat] != null)
            {
                Console.WriteLine($"{saat:D2}:00 - {takvim[gun, saat]}");
            }
        }
    }
    
    static void HaftalikGorunum(string[,] takvim)
    {
        string[] gunIsimleri = {"Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"};
        
        Console.WriteLine("\n=== HAFTALIK TAKVİM ===");
        
        for (int gun = 0; gun < 7; gun++)
        {
            Console.WriteLine($"\n=== {gunIsimleri[gun]} ===");
            for (int saat = 0; saat < 24; saat++)
            {
                if (takvim[gun, saat] != null)
                {
                    Console.WriteLine($"{saat:D2}:00 - {takvim[gun, saat]}");
                }
            }
        }
    }
    
    static void EtkinlikSil(string[,] takvim)
    {
        Console.Write("Gün (1-7): ");
        int gun = Convert.ToInt32(Console.ReadLine()) - 1;
        
        Console.Write("Saat (0-23): ");
        int saat = Convert.ToInt32(Console.ReadLine());
        
        if (gun >= 0 && gun < 7 && saat >= 0 && saat < 24)
        {
            if (takvim[gun, saat] != null)
            {
                takvim[gun, saat] = null;
                Console.WriteLine("Etkinlik silindi!");
            }
            else
            {
                Console.WriteLine("Bu saatte etkinlik yok.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz gün veya saat!");
        }
    }
}
```

### 73. Basit Web Crawler (İnternet Sayacı)
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== WEB CRAWLER (İnternet Sayacı) ===");
        Console.Write("Başlangıç sayfası URL'i: ");
        string baslangicUrl = Console.ReadLine();
        
        Console.Write("Aranacak kelime: ");
        string aranacakKelime = Console.ReadLine();
        
        Console.Write("Maksimum sayfa sayısı: ");
        int maksimumSayfa = Convert.ToInt32(Console.ReadLine());
        
        string[] ziyaretEdilen = new string[maksimumSayfa];
        int sayac = 0;
        
        // Basit örnek - gerçek bir web crawler için System.Net kullanılmalı
        SimulateCrawler(baslangicUrl, aranacakKelime, ziyaretEdilen, ref sayac);
        
        Console.WriteLine($"\nArama tamamlandı!");
        Console.WriteLine($"Toplam {sayac} sayfa ziyaret edildi.");
        Console.WriteLine($"'{aranacakKelime}' kelimesi {sayac} kez bulundu.");
    }
    
    static void SimulateCrawler(string url, string kelime, string[] ziyaretEdilen, ref int sayac)
    {
        // Bu simülasyon örneğidir - gerçek bir crawler yapmak için 
        // HTML parsing, HTTP istekleri ve daha karmaşık algoritmalar gerekir
        
        string[] ornekSayfalar = {
            "https://ornek1.com - Bu sayfada kelime var",
            "https://ornek2.com - Başka bir sayfa",
            "https://ornek3.com - Kelime burada da mevcut",
            "https://ornek4.com - Farklı içerik",
            "https://ornek5.com - Son bir sayfa"
        };
        
        for (int i = 0; i < ornekSayfalar.Length && sayac < ziyaretEdilen.Length; i++)
        {
            ziyaretEdilen[sayac] = ornekSayfalar[i];
            sayac++;
            
            if (ornekSayfalar[i].ToLower().Contains(kelime.ToLower()))
            {
                Console.WriteLine($"✓ Bulundu: {ornekSayfalar[i]}");
            }
            else
            {
                Console.WriteLine($"✗ Yok: {ornekSayfalar[i]}");
            }
        }
    }
}
```

### 74. Algoritma Performans Testi
```csharp
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ALGORİTMA PERFORMANS TESTİ ===");
        Console.Write("Test edilecek sayı: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"\n{sayi} sayısı için test başlatılıyor...\n");
        
        // Faktöriyel Testi
        TestFaktoriyel(sayi);
        
        // Fibonacci Testi
        TestFibonacci(sayi);
        
        // Asal Sayı Kontrolü Testi
        TestAsalKontrol(sayi);
        
        // Palindrom Kontrolü Testi
        TestPalindrom(sayi);
        
        // Hızlı Sıralama Testi
        TestSiralama();
    }
    
    static void TestFaktoriyel(int sayi)
    {
        Stopwatch sw = Stopwatch.StartNew();
        
        long sonuc = FaktoriyelRecursive(sayi);
        
        sw.Stop();
        
        Console.WriteLine($"Faktöriyel({sayi}) = {sonuc}");
        Console.WriteLine($"Süre: {sw.ElapsedMilliseconds} ms\n");
    }
    
    static void TestFibonacci(int n)
    {
        Stopwatch sw = Stopwatch.StartNew();
        
        long fibo = FibonacciIterative(n);
        
        sw.Stop();
        
        Console.WriteLine($"Fibonacci({n}) = {fibo}");
        Console.WriteLine($"Süre: {sw.ElapsedMilliseconds} ms\n");
    }
    
    static void TestAsalKontrol(int sayi)
    {
        Stopwatch sw = Stopwatch.StartNew();
        
        bool asal = AsalKontrol(sayi);
        
        sw.Stop();
        
        Console.WriteLine($"{sayi} sayısı {(asal ? "asal" : "asal değil")}");
        Console.WriteLine($"Süre: {sw.ElapsedMilliseconds} ms\n");
    }
    
    static void TestPalindrom(int sayi)
    {
        string sayiStr = sayi.ToString();
        Stopwatch sw = Stopwatch.StartNew();
        
        bool palindrom = PalindromKontrol(sayiStr);
        
        sw.Stop();
        
        Console.WriteLine($"{sayi} sayısı palindrom: {palindrom}");
        Console.WriteLine($"Süre: {sw.ElapsedMilliseconds} ms\n");
    }
    
    static void TestSiralama()
    {
        int[] dizi = { 64, 34, 25, 12, 22, 11, 90, 5, 77, 30 };
        
        Console.WriteLine("Orijinal dizi: " + string.Join(", ", dizi));
        
        Stopwatch sw = Stopwatch.StartNew();
        
        QuickSort(dizi, 0, dizi.Length - 1);
        
        sw.Stop();
        
        Console.WriteLine("Sıralanmış dizi: " + string.Join(", ", dizi));
        Console.WriteLine($"Süre: {sw.ElapsedMilliseconds} ms\n");
    }
    
    // Yardımcı metodlar
    static long FaktoriyelRecursive(int n)
    {
        if (n <= 1) return 1;
        return n * FaktoriyelRecursive(n - 1);
    }
    
    static long FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
    
    static bool AsalKontrol(int sayi)
    {
        if (sayi < 2) return false;
        
        for (int i = 2; i * i <= sayi; i++)
        {
            if (sayi % i == 0)
                return false;
        }
        return true;
    }
    
    static bool PalindromKontrol(string metin)
    {
        for (int i = 0; i < metin.Length / 2; i++)
        {
            if (metin[i] != metin[metin.Length - 1 - i])
                return false;
        }
        return true;
    }
    
    static void QuickSort(int[] dizi, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(dizi, low, high);
            QuickSort(dizi, low, pivotIndex - 1);
            QuickSort(dizi, pivotIndex + 1, high);
        }
    }
    
    static int Partition(int[] dizi, int low, int high)
    {
        int pivot = dizi[high];
        int i = low - 1;
        
        for (int j = low; j < high; j++)
        {
            if (dizi[j] <= pivot)
            {
                i++;
                (dizi[i], dizi[j]) = (dizi[j], dizi[i]);
            }
        }
        
        (dizi[i + 1], dizi[high]) = (dizi[high], dizi[i + 1]);
        return i + 1;
    }
}
```
