string degisken = "Csharp String Metodlar";
string degisken2 = "Csharp";

//Length; değişken uzunluğunu hesaplama
System.Console.WriteLine(degisken.Length);

//ToUpper- ToLower değişken harflerini büyütme ve küçültme 
System.Console.WriteLine(degisken.ToUpper());
System.Console.WriteLine(degisken2.ToLower());

//Concat değişkene ekleme yapar
System.Console.WriteLine(degisken,"Merhaba ");

//Compare, CompareTo değişken karşılaştırması yapar
System.Console.WriteLine(degisken.CompareTo(degisken2));
System.Console.WriteLine(String.Compare(degisken,degisken2,true));
System.Console.WriteLine(String.Compare(degisken,degisken2,false));

//Contains değişken içerisinde var mı yok mu ?
System.Console.WriteLine(degisken.Contains(degisken2));
System.Console.WriteLine(degisken.EndsWith("Metotlar"));
System.Console.WriteLine(degisken.StartsWith("Merhaba"));

//IndexOf  belirtilen harf ilk hangi index ise onu yazar (kelime verilmiş ise kelimenin ilk harfin indexini yazar)
System.Console.WriteLine(degisken.IndexOf("CS"));
System.Console.WriteLine("Asd"); // yoksa -1 döner
System.Console.WriteLine("i");

// Insert şu indexten başla şunu ekle
System.Console.WriteLine(degisken.Insert(0,"Hoşgeldiniz "));

//PadLeft, PadRight sağdan soldan index tamamlama
System.Console.WriteLine(degisken + degisken2.PadLeft(30));
System.Console.WriteLine(degisken + degisken2.PadRight(50,'-'));

//Replace Belirtilen değeri verilen değerle değiştir.
System.Console.WriteLine(degisken.Replace(" ","*"));

//Split  boşluklardan bölerek diziye aktar
System.Console.WriteLine(degisken.Split(' ')[1]);

//Substring belirtilen indexten belirtilen index sayısı kadar getir
System.Console.WriteLine(degisken.Substring(4));//4. indexten sonra getir
System.Console.WriteLine(degisken.Substring(4,6));// 4. indexten sonra 6 index getir



