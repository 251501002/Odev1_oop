// 1. İsim, bölüm ve yıl bilgileri
Console.WriteLine("Hurşut Alperen Özer");
Console.WriteLine("Bilgisayar Mühendisliği");
Console.WriteLine("2. Sınıf");

// 2. Tarih ve saat
Console.WriteLine($"Şu anki tarih ve saat: {DateTime.Now}");

// 3. Santigrat - Fahrenheit hesaplama
Console.Write("Lütfen sıcaklık değerini Celsius (°C) olarak girin: ");
double c = double.Parse(Console.ReadLine());
double f = c * 9 / 5 + 32;
Console.WriteLine($"{c} derece, {f} Fahrenheit yapar.");