using System.ComponentModel.Design;
internal class Program
{
    private static void Main(string[] args)
    {


        string cevap1 = "";
        string cevap2 = "";
        string cevap3 = "";

        Console.WriteLine("YARIŞMAYA HOŞGELDİNİZ!");
        Console.WriteLine("Yarışmacı 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik büyük ödülü kazanacak!");

        int correctCounter = 0;
        Console.WriteLine();

        Console.WriteLine("1.SORU) Dünyanın en büyük okyanusu hangisidir?");
        Console.WriteLine("a)Pasifik Okyanusu  \n b)Atlantik Okyanusu");
        cevap1 = Console.ReadLine().ToLower();
        {
            if (cevap1 == "a")
            {
                correctCounter++;
                Console.WriteLine($"tebrikler doğru bildiniz");
                Console.WriteLine(correctCounter);
            }
            else
            {
                Console.WriteLine($"maalesef yanlış bildiniz sonraki iki soruyu bilmeniz lazım");

            }
            Console.WriteLine("2.SORU) İlk yazılı kanunlar hangi uygarlık tarafından yapılmıştır?");
            Console.WriteLine();
            Console.WriteLine("a) Sümerler \n b)Mısırlılar ");
            cevap2 = Console.ReadLine().ToLower();
            if ((cevap2 == "a") && (correctCounter == 1))
            {
                 correctCounter++ ; 
                Console.WriteLine($"tebrikler ikinci soruya da doğru cevap vererek büyük ödülü kazandın!");
                Console.WriteLine("1.000.000.000 TL");
            }
             
              else
            {
                Console.WriteLine();
                correctCounter++ ;
                Console.WriteLine("Yanlış cevap verdiniz");
             }
           
            Console.WriteLine("3.SORU)Hangi gezegen Güneş Sistemi'nde en büyük çaplı gezegendir?");
            Console.WriteLine();
            Console.WriteLine("a)Mars \n b)Jüpiter ");
            cevap3 = Console.ReadLine().ToLower();
            if ((cevap3 == "b") && (correctCounter >= 1))
            {
                correctCounter++;
                Console.WriteLine($"Tebrikler ikinci doğru cevabı vererek ödülü kazandın !");
                Console.WriteLine("1.000.000.000");
            }
            else 
            {
            
                Console.WriteLine("maalesef elendiniz");


            }

            
        }
        Console.Read();
    }

}
    
   



