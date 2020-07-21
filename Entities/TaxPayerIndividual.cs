namespace Aula_HerancaPolimorfismo_Encapsulamento.Entities
{
    class TaxPayerIndividual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public TaxPayerIndividual(string name, double annualIncome, double healthExpeditures) : base(name, annualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double TaxCalculate()
        {
            double tax = 0.0;

            if (AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
            }
            else if (AnnualIncome >= 20000.00)
            {
                tax = AnnualIncome * 0.25;
            }

            if (HealthExpeditures > 0)
            {
                tax -= HealthExpeditures * 0.50;
            }

            return tax;
        }
    }
}
