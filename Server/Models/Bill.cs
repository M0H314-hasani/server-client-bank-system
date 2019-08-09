using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Server.Lib;

namespace Server.Models
{
    class Bill
    {
        private static string[] fields  = { "account_id", "type", "amount", "created_at" };
        private static string table = "bills";

        private int? id;
        private int account_id;
        private string type;
        private long amount;
        private DateTime created_at;

        public Bill()
        {
      
        }

        public static Bill[] findByAccountId(string id)
        {
            DataTable result = new DB().query("SELECT * FROM " + table + " WHERE account_id=" + id);

            Bill[] bills = new Bill[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                bills[i] = new Bill();
                bills[i].Id = result.Rows[i].Field<int>("id");
                bills[i].Account_id = result.Rows[i].Field<int>("account_id");
                bills[i].Type = result.Rows[i].Field<string>("type");
                bills[i].Amount = result.Rows[i].Field<long>("amount");
                bills[i].Created_at = result.Rows[i].Field<DateTime>("created_at");
            }

            return bills;
        }

        public void save()
        {

            string[] values = new string[] { account_id.ToString(), type, amount.ToString(), created_at.ToString() };


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

        public int Account_id
        {
            get
            {
                return account_id;
            }

            set
            {
                account_id = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public long Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public DateTime Created_at
        {
            get
            {
                return created_at;
            }

            set
            {
                created_at = value;
            }
        }
    }
}
