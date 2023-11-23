using System;

namespace CarRentalExercise.Domain
{
    internal class Invoice
    {
        public double BasicPaymente { get; set; }
        public double Tax { get; set; }

        //Construtores
        public Invoice()
        {
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPaymente = basicPayment;
            Tax = tax;
        }

        public double TotalPayment()
        {
            return BasicPaymente + Tax;
        }

        //Imprimir os dados
        public override string ToString()
        {
            return $"Basic Payment: {BasicPaymente:c}\nTax: {Tax:c}\nTotal Payment: {TotalPayment():c}";
        }
    }
}
