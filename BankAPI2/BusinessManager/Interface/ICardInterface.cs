using BankAPI2.Model;

namespace BankAPI2.BusinessManager.Interface
{
    public interface ICardInterface
    {
        CardRequest Create(CardRequest cardRequest);
        CardRequest GetStatusbyAccount(int Id);
    }
}
