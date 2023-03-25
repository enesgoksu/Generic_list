namespace Generic_list.Generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count -> Bu listelerde kaç tane eleman var?Onu öğrenmek istiyorum o yüzden count'u kullandım.

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            Console.WriteLine("*****Foreach ve List.ForEach ile elemanlara erişim.*****");

            // sayiListesi listesinin elemanlarını tek tek yazdırmak istedim o yüzden foreach kullandım
            foreach (var sayi in sayiListesi)  
            {
                Console.WriteLine(sayi);
            }

            // renkListesi listesinin elemanlarını tek tek yazdırmak istedim o yüzden foreach kullandım    
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); // Yukarıda kullandığımız foreach ile aynı görevi gören foreach döngüsünün bir başka türlü kullanımı.Aynı şekilde sayiListesinin bütün elemanlarını tek tek yazdırmak için kullandım.

            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma

            sayiListesi.Remove(4); //sayiListesi listesinden 4 ü çıkart.
            renkListesi.Remove("Yeşil"); //renkListesi listesinden "Yeşil" i çıkart

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // İndex numarasına göre diziden eleman çıkarma
            sayiListesi.RemoveAt(0); //sayiListesi listesinden 0.indeksi çıkar.Yani 23 sayısına karşılık gelir.
            renkListesi.RemoveAt(1); //renkListesi listesinden 1.indeksi çıkar.Yani 'Mavi'ye karşılık gelir.
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama

            if (sayiListesi.Contains(10)) //sayiListesi listesinin içerisinde 10 sayısı varmı
            {
                Console.WriteLine("10 liste içerisinde bulundu.");
            }

            // Eleman ile index'e erişme

            Console.WriteLine(renkListesi.BinarySearch("Sarı")); // renkListesi listesinin içerisinde 'Sarı' elemanı kaçıncı index'te bana göster.

            // Diziyi list tipinde bir listeye çevirme

            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);
            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));

            // Listeyi nasıl temizlerim.

            hayvanListesi.Clear();  // hayvanListesi listesinin bütün elemanlarını sildik,listeyi temizledik.
            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));

            // Liste içerisinde nesne tutmak istiyorsam
            List<Kullanicilar> kullanıcıListesi = new List<Kullanicilar>();

            Kullanicilar kullanıcı1 = new Kullanicilar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;

            Kullanicilar kullanıcı2 = new Kullanicilar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 24;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 22

            });

            foreach (Kullanicilar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı: "+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: "+kullanıcı.Yas);
            }


        }
    }
    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}