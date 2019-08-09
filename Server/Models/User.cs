using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Server.Lib;
using System.IO;
using System.Drawing;

namespace Server.Models
{
    
    class User
    {
        private static string[] fields;
        private static string table;

        private int? id;
        private string first_name;
        private string last_name;
        private string national_id;
        private string address;
        private string phone;
        private string postal_code;
        private string email;
        private string avatar;

        public User()
        {
            table = "users";
            fields = new string[] { "first_name", "last_name", "national_id", "address", "phone", "postal_code", "email", "avatar" };
        }

        public static User findById(string id)
        {
            User user = new User();

            DataTable result = new DB().getById(table, id);

            user.Id = result.Rows[0].Field<int>("id");
            user.First_name = result.Rows[0].Field<string>("first_name");
            user.Last_name = result.Rows[0].Field<string>("last_name");
            user.National_id = result.Rows[0].Field<string>("national_id");
            user.Address = result.Rows[0].Field<string>("address");
            user.Phone = result.Rows[0].Field<string>("phone");
            user.Postal_code = result.Rows[0].Field<string>("postal_code");
            user.Email = result.Rows[0].Field<string>("email");
            user.Avatar = result.Rows[0].Field<string>("avatar");

            return user;
        }
        public static User findByNationalCode(string nationalCode)
        {
            User user = new User();

            DataTable result = new DB().query("SELECT * FROM " + table + " WHERE national_id=" + nationalCode);

            if (result.Rows.Count == 0)
                return user;
            user.Id = result.Rows[0].Field<int>("id");
            user.First_name = result.Rows[0].Field<string>("first_name");
            user.Last_name = result.Rows[0].Field<string>("last_name");
            user.National_id = result.Rows[0].Field<string>("national_id");
            user.Address = result.Rows[0].Field<string>("address");
            user.Phone = result.Rows[0].Field<string>("phone");
            user.Postal_code = result.Rows[0].Field<string>("postal_code");
            user.Email = result.Rows[0].Field<string>("email");

            if (result.Rows[0].Field<string>("avatar").Length > 0)
            {


                string base64String;
                using (Image image = Image.FromFile(result.Rows[0].Field<string>("avatar")))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        base64String = Convert.ToBase64String(imageBytes);

                    }
                }

                user.Avatar = base64String;
            }

            return user;
        }
        public void save()
        {
            
            string[] values = new string[] { First_name, Last_name, National_id, Address, Phone, Postal_code, Email, Avatar };

            if ((Id ?? 0) == 0)
            {
                var result = new DB().insert(table, fields, values);
                Id = result;
            }
            else
            {
                values[7] = saveImage(values[7]);
                new DB().update(table, Id.ToString(), fields, values);     
            }
        }

        private string saveImage(string ImgStr)
        {
            String path = System.IO.Directory.GetCurrentDirectory() + "\\images";

            //Check if directory exist
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
            }

            string imageName = Helper.GenerateRandomNumber(15) + ".jpg";

            //set the image path
            string imgPath = Path.Combine(path, imageName);

            byte[] imageBytes = Convert.FromBase64String(ImgStr);

            File.WriteAllBytes(imgPath, imageBytes);

            return path + "\\" + imageName;
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

        public string First_name
        {
            get
            {
                return first_name;
            }

            set
            {
                first_name = value;
            }
        }

        public string Last_name
        {
            get
            {
                return last_name;
            }

            set
            {
                last_name = value;
            }
        }

        public string National_id
        {
            get
            {
                return national_id;
            }

            set
            {
                national_id = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Postal_code
        {
            get
            {
                return postal_code;
            }

            set
            {
                postal_code = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Avatar
        {
            get
            {
                return avatar;
            }

            set
            {
                avatar = value;
            }
        }
    }
}
