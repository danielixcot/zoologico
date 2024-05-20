namespace zoologico
{
    public class Aves:Animal
    {
        public bool Volar {  get; set; }
        public int Incubacion { get; set; }
        public Aves()
        {   
            Volar = false;
            Incubacion = 0; 
        }
    }
}
