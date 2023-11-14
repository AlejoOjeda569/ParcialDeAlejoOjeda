namespace WinFroms.Entidades
{
    public class Cubo
    {
        public int Arista { get; set; }
        public Borde Borde { get; set; }
        public Relleno Relleno { get; set; }
        public double GetArea()=>6*Math.Pow(Arista, 2);
        public double GetVolumen()=>Math.Pow(Arista, 3);

    }
}