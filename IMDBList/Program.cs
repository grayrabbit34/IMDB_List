using System.Drawing;
using IMDBList;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Filmlerimizi listeleyelim uygulamasına hoşgeldiniz.");
        bool wishToProceed = true;

        List<Movie> movies = new List<Movie>(); //Movie sınıfından üretilen nesne alabilen liste : movies

        //ilk film girildikten sonra hayır yanıtı verilirse koşulun içi false'a dönecek ve döngü çalışmayacak
        while (wishToProceed)
        {
            Console.WriteLine("Bir film ismi giriniz.");
            Movie movie = new Movie(); // Movie sınıfından  movie isminde yeni bi nesne ürettim 
            movie.Name = Console.ReadLine(); //bu nesnenin isim property'sine kullanıcıdan alınan input'u atıyorum.

            Console.WriteLine("Bu filmin IMDB puanını giriniz.");
            movie.ImdbScore = Convert.ToDouble(Console.ReadLine()); //bu nesnenin puan property'sine kullanıcıdan alınan input'u atıyorum.


            movies.Add(movie);// listeye bu iki property'ye sahip nesneyi ekliyorum


            Console.WriteLine("Listeye başka bir film eklemek ister misiniz? (evet/hayır");

            while (true)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "evet")
                {
                    break; //kullanıcı evet girerse wishToProceed değeri değiştirilmez iç döngüden çıkılır ana döngü devam eder.
                }
                else if (answer == "hayır") //hayır derse aşağıdaki bilgiler ekrana yazdırılır
                {
                    wishToProceed = false; // ana döngü koşulu false değeri alır ve döngüden çıkılır

                    foreach (var item in movies)
                        //girilen tüm filmler ekrana yazdırılır
                        Console.WriteLine($"Filmin adı: {item.Name} filmin IMDB puanı: {item.ImdbScore}");

                    foreach (var item in movies)
                        //imdb puanı 4-9 arasındaki filmler ekrana yazdırılır
                        if (item.ImdbScore >= 4 && item.ImdbScore <= 9)
                            Console.WriteLine($"Filmin adı: {item.Name} filmin IMDB puanı: {item.ImdbScore}");

                    foreach (var item in movies)
                    {
                        //ismi a ile başlayan filmler ekrana yazdırılır.
                        if (item.Name[0] == 'A' || item.Name[0] == 'a') //char olduğu için tek tırnak ile yazdım.
                        {
                            Console.WriteLine($"Filmin adı: {item.Name} filmin IMDB puanı: {item.ImdbScore}");
                        }
                    }

                    break;
                }
                else
                    Console.WriteLine("Geçersiz giriş yaptınız. Lütfen evet veya hayır yazınız.");
            }

        }
    }

}