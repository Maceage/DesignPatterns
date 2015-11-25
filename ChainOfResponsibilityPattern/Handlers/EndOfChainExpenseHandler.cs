using System;
using ChainOfResponsibilityPattern.Domain;
using ChainOfResponsibilityPattern.Handlers.Interfaces;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        public static EndOfChainExpenseHandler Instance { get; } = new EndOfChainExpenseHandler();

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            return ApprovalResponse.Denied;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }
    }
}