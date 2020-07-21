namespace Aula_HerancaPolimorfismo_Encapsulamento.Entities
{
    class TaxPayerCompany : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public TaxPayerCompany(string name, double annualIncome, int numberEmployees) : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxCalculate()
        {
            double tax = 0.0;

            if (NumberEmployees <= 10)
            {
                tax = AnnualIncome * 0.16;
            }
            else
            {
                tax = AnnualIncome * 0.14;
            }

            return tax;
        }
    }
}
