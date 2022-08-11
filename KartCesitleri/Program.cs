using KartCesitleri;

class Program
{
    static void Main(string[] args)
    {

        string KartNo = Console.ReadLine();
        Console.WriteLine(" KartNo : " + KartNo);
        KartTipi tip = KartTipi.Ogrenci;
        Console.WriteLine(" KartTipi : " + tip);
        string Name = Console.ReadLine();
        Console.WriteLine(" Name : " + Name);
        string Surname = Console.ReadLine();
        Console.WriteLine(" Surname : " + Surname);
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