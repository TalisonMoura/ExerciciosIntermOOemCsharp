using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioOO08_InterfaceContract.Services;

namespace ExercicioOO08_InterfaceContract.Entities
{
    internal class Installment
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return ($"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("f2", ci)}");
        }
    }
}
