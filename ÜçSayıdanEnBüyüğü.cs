        static void Main(string[] args)
        {
            int sayi=0, adet, büyüksayi=0;//Değişkenler tanımlanır.
               
            Console.WriteLine("Kaç adet sayı girilecek ?"); //Kullanıcıya kaç sayı girileceği sorulur
            adet = int.Parse(Console.ReadLine()); //Klavyeden okunur ve adet değişkenine atanır.
            

            for (int i = 0; i < adet ; i++) //Girilen adet kadar dönecek bir döngü başlatılır.
            {
                Console.WriteLine($"{i + 1}.Sayıyı giriniz");//Kullanıcıdan sayı girmesi istenir.
                sayi = int.Parse(Console.ReadLine());//Sayı klavyeden okunur ve sayi değişkenine atanır.

                if(i==0) //i tur sayısını simgeler bu yüzden eğer i==0 ise döngü daha ilk turunda demektir.
                    //eğer döngü ilk turundaysa sadece bir sayı girilmiştir ve bu sayı o an için en büyük sayıdır.
                {
                    büyüksayi = sayi; // girilen sayı büyüksayi değişkenine atanır.
                }
                else //eğer ilk tur değilse en az bir sayi girilmiş olmalıdır.
                {
                    if(büyüksayi<sayi) //ve girilen sayı mevcut büyüksayi değerinden büyük ise
                    {
                        büyüksayi = sayi; //girilen sayı yeni büyüksayi değeri olmalıdır.
                    }

                }    
            }
            Console.WriteLine($"En büyük sayı = {büyüksayi}"); //Döngü bittiğinde büyüksayi değişkeninin içindeki değer girilmiş en büyük sayıdır.
        }
