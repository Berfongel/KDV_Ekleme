// See https://aka.ms/new-console-template for more information
double fiyat,KDVHesabı,KDVliTutari;
Console.WriteLine("Fiyat giriniz : ");
fiyat = Convert.ToDouble(Console.ReadLine());
KDVHesabı = ((fiyat*18)/100);
KDVHesabı = fiyat + KDVHesabı;
Console.WriteLine("KDVli tutarı : " + KDVHesabı);

