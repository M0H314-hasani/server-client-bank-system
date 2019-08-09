using Newtonsoft.Json;
using Server.Models;
using System.Dynamic;

namespace Server.Controllers
{
    class UserController
    {
        public string Register(string payload)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject<ExpandoObject>(payload);

            User user = new User();

            user.First_name = jsonObject.First_name;
            user.Last_name = jsonObject.Last_name;
            user.National_id = jsonObject.National_id;
            user.Address = jsonObject.Address;
            user.Phone = jsonObject.Phone;
            user.Postal_code = jsonObject.Postal_code;
            user.Email = jsonObject.Email;

            user.save();

            return "success";
        }

        public string CheckProfile(string nationalCode)
        {
            User user = User.findByNationalCode(nationalCode);

            if (user.Id == null)
                return "user_not_found";

            string userJsonString = JsonConvert.SerializeObject(user);

            return userJsonString;
        }

       public string UpdateProfile(string id, string payload)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject<ExpandoObject>(payload);

            User user = User.findById(id);

            user.First_name = jsonObject.First_name;
            user.Last_name = jsonObject.Last_name;
            user.National_id = jsonObject.National_id;
            user.Address = jsonObject.Address;
            user.Phone = jsonObject.Phone;
            user.Postal_code = jsonObject.Postal_code;
            user.Email = jsonObject.Email;
            user.Avatar = jsonObject.Avatar;

            user.save();

            string userJsonString = JsonConvert.SerializeObject(user);

            return userJsonString;
        }
    }
}
