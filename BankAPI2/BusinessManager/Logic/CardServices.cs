using BankAPI2.BusinessManager.Interface;
using BankAPI2.DAL;
using BankAPI2.Model;

namespace BankAPI2.BusinessManager.Logic
{
    public class CardServices : ICardInterface
    {
        private BankDBContext _bankDBContext;

        public CardServices(BankDBContext bankDBContext )
        {
            _bankDBContext = bankDBContext;
        }

        public CardRequest Create(CardRequest cardRequest)
        {

            cardRequest.Status = "Pending";
            _bankDBContext.CardRequests.Add(cardRequest);
            _bankDBContext.SaveChanges();

            return cardRequest;
        }

        public CardRequest GetStatusbyAccount(int Id)
        {
            var cardRequest =  _bankDBContext.CardRequests.Where(x => x.Id == Id).FirstOrDefault();

            if(cardRequest == null)
                return null;

            return cardRequest;
        }
    }
}
