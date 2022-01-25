

namespace Projeto_A194.Services
{
    class BrazilianTaxService
    {
        public double Tax(double ammount)
        {
            if(ammount <= 100.0)
            {
                return ammount * 0.2;
            }
            else
            {
                return ammount * 0.15;
            }
        }
    }
}
