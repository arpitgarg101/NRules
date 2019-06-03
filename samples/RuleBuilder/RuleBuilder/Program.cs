using System;
using System.Collections.Generic;
using NRules.Samples.RuleBuilder.Domain;

namespace NRules.Samples.RuleBuilder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repository = new CustomRuleRepository();
            repository.LoadRules();

            Console.WriteLine("Loaded rules:");
            foreach (var rule in repository.GetRules())
            {
                Console.WriteLine(rule.Name);
            }
            Console.WriteLine();
            
            ISessionFactory factory = repository.Compile();
            ISession session = factory.CreateSession();

            var customer1 = new Customer("John Do");
            var customer2 = new Customer("Jean Do") {IsPreferred = true};
            var transaction = new Transaction
            {
                TransactionGuid = Guid.NewGuid().ToString(),
                UserId = "abc@abc.abc",
                UserIdType = UserIdType.Email,
                OrganizationId = 1,
                Purchases = new List<Purchase>
                {
                    new Purchase {
                        Id = "1",
                        Type = PurchaseType.Product,
                        CurrencyValue = 100,
                    }
                },
                TransactionTime = default(DateTime),
                TransactionValue = 100,
                TransactionType = TransactionType.Credit,
                SubmittedBy = "aba@abc.abc",
                SubmittedAt = default(DateTime),
            };
            session.Insert(customer1);
            session.Insert(customer2);
            session.Insert(new Order(1, customer1, 2, 90.00));
            session.Insert(new Order(2, customer1, 1, 110.00));
            session.Insert(new Order(3, customer1, 1, 1000.00));
            session.Insert(new Order(4, customer2, 1, 120.00));
            session.Insert(new Order(5, customer2, 1, 10.00));
            session.Insert(new Order(6, customer2, 1, 12.50));
            session.Insert(new Order(7, customer2, 1, 400.00));
            session.Insert(transaction);

            Console.WriteLine("Running rules:");
            session.Fire();
            Console.WriteLine(transaction.PointsValue);
        }
    }
}