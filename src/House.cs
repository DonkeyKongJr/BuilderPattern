namespace src
{
    public class House
    {
        public string PaintingColor { get; }
        public string RoofType { get; }
        public int NumbersOfFloors { get; }
        public bool HasCellar { get; }

        public House(string paintingColor, string roofType, int numbersOfFloors, bool hasCellar)
        {
            PaintingColor = paintingColor;
            RoofType = roofType;
            NumbersOfFloors = numbersOfFloors;
            HasCellar = hasCellar;
        }
    }
}