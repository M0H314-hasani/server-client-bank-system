using Server.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Server.Models
{
    class BankAccount
    {
        private static string[] fields = { "user_id", "account_number", "balance" };
        private static string table = "bank_accounts";

        private int? id;
        private int user_id;
        private string account_number;
        private long balance;

        public BankAccount()
        {
            //table = "bank_accounts";
            //fields = new string[] { "user_id", "account_number", "balance" };
        }
        public static BankAccount[] findByUserId(string id)
        {
            DataTable result = new DB().query("SELECT * FROM " + table + " WHERE user_id=" + id);

            BankAccount[] bankAccounts = new BankAccount[result.Rows.Count];

            for (int i=0; i < result.Rows.Count; i++)
            {
                bankAccounts[i] = new BankAccount();
                bankAccounts[i].Id = result.Rows[i].Field<int>("id");
                bankAccounts[i].User_id = result.Rows[i].Field<int>("user_id");
                bankAccounts[i].Account_number = result.Rows[i].Field<string>("account_number");
                bankAccounts[i].Balance = result.Rows[i].Field<long>("balance");
            }

            return bankAccounts;
        }

        public static BankAccount findById(string id)
        {
            BankAccount bankAccount = new BankAccount();

            DataTable result = new DB().getById(table, id);

            bankAccount.Id = result.Rows[0].Field<int>("id");
            bankAccount.User_id = result.Rows[0].Field<int>("user_id");
            bankAccount.Account_number = result.Rows[0].Field<string>("account_number");
            bankAccount.Balance = result.Rows[0].Field<long>("balance");

            return bankAccount;
        }

        public void save()
        {

            object[] values = new object[] { User_id, Account_number, Balance };


            if ((Id ?? 0) == 0)
            {
                var result = new DB().insert(table, fields, values);
                Id = result;
            }
            else new DB().update(table, Id.ToString(), fields, values);
        }

        public int? Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }

        public string Account_number
        {
            get
            {
                return account_number;
            }

            set
            {
                account_number = value;
            }
        }

        public long Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }
    }
}
