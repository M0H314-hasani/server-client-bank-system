using Newtonsoft.Json;
using Server.Lib;
using Server.Models;
using System;

namespace Server.Controllers
{
    class BankAccountController
    {
        
        public string createAccount(string userId)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.User_id = int.Parse(userId);
            bankAccount.Account_number = Helper.GenerateRandomNumber(12);
            bankAccount.Balance = 0;

            bankAccount.save();

            return "success";
        }
        public string getBankAccountsByUserId(string userId)
        {
            BankAccount[] bankAccounts = BankAccount.findByUserId(userId);

            string bankAccountsJsonString = JsonConvert.SerializeObject(bankAccounts);

            return bankAccountsJsonString;
        }

        public string deposit(string bankAccountId, string amount)
        {
            BankAccount bankAccount = BankAccount.findById(bankAccountId);

            bankAccount.Balance += int.Parse(amount);

            bankAccount.save();

            Bill bill = new Bill();

            bill.Account_id = bankAccount.Id.GetValueOrDefault(0);
            bill.Type = "deposit";
            bill.Amount = int.Parse(amount);
            bill.Created_at = DateTime.Now;

            bill.save();

            return "success";
        }

        public string withdrawal(string bankAccountId, string amount)
        {
            BankAccount bankAccount = BankAccount.findById(bankAccountId);

            bankAccount.Balance -= int.Parse(amount);

            bankAccount.save();

            Bill bill = new Bill();

            bill.Account_id = bankAccount.Id.GetValueOrDefault(0);
            bill.Type = "withdrawal";
            bill.Amount = int.Parse(amount);
            bill.Created_at = DateTime.Now;

            bill.save();

            return "success";
        }
    }

    
}
