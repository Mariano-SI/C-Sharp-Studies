﻿using Services;

namespace Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            return amount <= 100 ? amount * 0.2 : amount * 0.15;
        }
    }
}
