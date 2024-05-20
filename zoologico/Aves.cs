namespace zoologico
{
    public class Aves:Animal
    {
        public string Volar {  get; set; }
        public int Incubacion { get; set; }
        public Aves()
        {   
            Volar = string.Empty;
            Incubacion = 0; 
        }
    }
}
