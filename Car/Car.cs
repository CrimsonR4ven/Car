namespace Car
{
    public class CarOb
    {
        
        string Marka;
        string Model;
        int Rocznik;
        int Przebieg;

        public CarOb(string marka, string model, int rocznik, int przebieg)
        {
            Marka = marka;
            Model = model;
            Rocznik = rocznik;
            Przebieg = przebieg;
        }

        public void Wypisz()
        {
            Console.WriteLine($"Marka: {Marka} \nModel: {Model} \nRocznik: {Rocznik} \nPrzebieg: {Przebieg}");
        }
    }
}
