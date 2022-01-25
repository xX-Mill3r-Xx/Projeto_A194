using System;

namespace Projeto_A194.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Veiculo { get; set; }
        public Involce Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle veiculo)
        {
            Start = start;
            Finish = finish;
            Veiculo = veiculo;
        }
    }
}
