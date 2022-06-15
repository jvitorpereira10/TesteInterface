namespace Interfaces.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
           // Invoice = null; // O objeto Invoice será instanciado apenas quando a nota fiscal for processada.
                            // Sendo assim, não há a necessidade de passar este objeto no construtor como null, pois ele será instanciado como nulo por padrão;
        }
    }
}