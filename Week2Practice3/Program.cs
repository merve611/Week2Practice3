
    //While

    //int sayac = 0;

    //Console.WriteLine("Limit bir değer belirleyin : ");
    //int limit = int.Parse(Console.ReadLine());
    //if (limit < 0) { Console.WriteLine("0 dan az bir değer girilemez "); }

    //while (sayac <= limit)
    //    {
    //        Console.WriteLine("Ben bir patika'lıyım");

    //        sayac++;


    //    }

    //Do-While

    int sayac = 0;
    Console.WriteLine("Limit bir değer belirleyin : ");
    int limit = int.Parse(Console.ReadLine());
    if (limit < 0) { Console.WriteLine("0 dan az bir değer girilemez "); }

    do
    {
          Console.WriteLine("Ben bir patika'lıyım");
          sayac++;


    } while (sayac <= limit);


    //Bu örnekteki while koşulunda -5 inputunu girdiğimizde döngüye girmez fakat do-while döngüsünde -5 inputuda girsek koşulu sağlamasa bile döngüyü bir kere çalıştırır ve ekrana Ben bir patikalıyım yazar

