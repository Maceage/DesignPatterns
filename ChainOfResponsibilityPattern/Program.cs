using System;
using ChainOfResponsibilityPattern.Domain;
using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Handlers.Interfaces;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = CreateReportingChain();

            RequestCheapExpense(manager);
            RequestMildlyCheapExpense(manager);
            RequestRatherExpensiveExpense(manager);
            RequestStupidlyExpensiveExpense(manager);

            Console.ReadKey();
        }

        private static void RequestStupidlyExpensiveExpense(ExpenseHandler manager)
        {
            IExpenseReport stupidlyExpensiveExpenseReport = new ExpenseReport(25000);
            ApprovalResponse stupidlyExpensiveResponse = manager.Approve(stupidlyExpensiveExpenseReport);
            Console.WriteLine("The request for {0} was {1}.", stupidlyExpensiveExpenseReport.Total, stupidlyExpensiveResponse);
        }

        private static void RequestRatherExpensiveExpense(ExpenseHandler manager)
        {
            IExpenseReport ratherExpensiveExpenseReport = new ExpenseReport(5500);
            ApprovalResponse ratherExpensiveResponse = manager.Approve(ratherExpensiveExpenseReport);
            Console.WriteLine("The request for {0} was {1}.", ratherExpensiveExpenseReport.Total, ratherExpensiveResponse);
        }

        private static void RequestMildlyCheapExpense(ExpenseHandler manager)
        {
            IExpenseReport mildlyCheapExpenseReport = new ExpenseReport(1250);
            ApprovalResponse mildlyCheapExpenseReponse = manager.Approve(mildlyCheapExpenseReport);
            Console.WriteLine("The request for {0} was {1}.", mildlyCheapExpenseReport.Total, mildlyCheapExpenseReponse);
        }

        private static void RequestCheapExpense(ExpenseHandler manager)
        {
            IExpenseReport cheapExpenseReport = new ExpenseReport(500);
            ApprovalResponse cheapExpenseResponse = manager.Approve(cheapExpenseReport);
            Console.WriteLine("The request for {0} was {1}.", cheapExpenseReport.Total, cheapExpenseResponse);
        }

        private static ExpenseHandler CreateReportingChain()
        {
            ExpenseHandler manager = new ExpenseHandler(new Employee("Manager", decimal.Zero));
            ExpenseHandler director = new ExpenseHandler(new Employee("Director", new decimal(1000)));
            ExpenseHandler vicePresident = new ExpenseHandler(new Employee("Vice President", new decimal(5000)));
            ExpenseHandler president = new ExpenseHandler(new Employee("President", new decimal(20000)));

            manager.RegisterNext(director);
            director.RegisterNext(vicePresident);
            vicePresident.RegisterNext(president);

            return manager;
        }
    }
}
