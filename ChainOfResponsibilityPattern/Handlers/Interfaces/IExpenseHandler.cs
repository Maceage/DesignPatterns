using ChainOfResponsibilityPattern.Domain;

namespace ChainOfResponsibilityPattern.Handlers.Interfaces
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler next);
    }
}