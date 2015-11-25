using ChainOfResponsibilityPattern.Domain;

namespace ChainOfResponsibilityPattern.Handlers.Interfaces
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }
}