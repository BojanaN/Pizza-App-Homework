using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using ToDo_App.Models.DomainModels;

namespace ToDo_App
{
    public static class TempDataExtensions
    {
        public static void Put<User>(this ITempDataDictionary TempData,string keyName, User value) where User:class
        {
            TempData[keyName] = JsonConvert.SerializeObject(value);
        }
        public static User Get<User>(this ITempDataDictionary TempData,string keyName) where User: class
        {
            object user;
            TempData.TryGetValue(keyName, out user);
            return user == null ? null : JsonConvert.DeserializeObject<User>((string)user);
        }
    }
}
