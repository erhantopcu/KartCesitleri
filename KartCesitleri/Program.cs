using KartCesitleri;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kart No Giriniz");
        string KartNo = Console.ReadLine();
        Console.WriteLine(" KartNo : " + KartNo);

        Console.WriteLine("Kart Tipi Giriniz");
        KartTipi tip = KartTipi.Yasli;
        Console.WriteLine(" KartTipi : " + tip);

        Console.WriteLine("İsim Giriniz");
        string Name = Console.ReadLine();
        Console.WriteLine(" Name : " + Name);

        Console.WriteLine("Soyisim Giriniz");
        string Surname = Console.ReadLine();
        Console.WriteLine(" Surname : " + Surname);

        Console.WriteLine("TC Giriniz");
        string ID = Console.ReadLine();
        Console.WriteLine(" ID : " + ID);



        KisiyeOzelFizikselKart newKisiFiz = new KisiyeOzelFizikselKart(KartNo, tip, Name, Surname, ID);
        Console.WriteLine(" newKisiFiz.KartNo :" + newKisiFiz.KartNo);
        Console.WriteLine(" newKisiFiz.KartTipi :" + newKisiFiz.Tip);
        Console.WriteLine(" newKisiFiz.Name :" + newKisiFiz.Name);
        Console.WriteLine(" newKisiFiz.Surname :" + newKisiFiz.Surname);
        Console.WriteLine(" newKisiFiz.ID :" + newKisiFiz.ID);

        newKisiFiz.ParaYatır(50.20M);
        Console.WriteLine("Bakiye: " + newKisiFiz.Bakiye);

        newKisiFiz.ParaCek(20.10M);
        Console.WriteLine("Bakiye: " + newKisiFiz.Bakiye);
    }
}