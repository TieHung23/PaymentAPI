using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Model;

namespace PaymentAPI.Services
{
    public class PaypalServices :  IPaymentServices
    {
        public Task<string> CreatePaymentURL(OrderInfoModel orderInfo, HttpContext context)
        {
            throw new NotImplementedException();
        }

        public Task<RespondModel> GetPaymentStatus(IQueryCollection collection)
        {
            throw new NotImplementedException();
        }

        public string PaymentName()
        {
            return "paypal";
        }
    }
}