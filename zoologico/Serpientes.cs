namespace zoologico
{
    public class Serpientes:Animal
    {
        public string Veneno { get; set; }
        public int Longitud {  get; set; }

        public Serpientes()
        {
            Longitud = 0;
            Veneno=string.Empty;
        }
        
    }
}
