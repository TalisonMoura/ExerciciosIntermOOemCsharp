using ExercicioOO08_InterfaceContract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioOO08_InterfaceContract.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService() { }
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ContractProcess(Contract contract, int months)
        {
            double SimpleQuota = contract.TotalValue / months;
            int n = months;
            for (int i = 1; i <= n; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double UpdateQuota = SimpleQuota + _onlinePaymentService.Interest(SimpleQuota, i);
                double fullQuota = UpdateQuota + _onlinePaymentService.PaymentFee(UpdateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
