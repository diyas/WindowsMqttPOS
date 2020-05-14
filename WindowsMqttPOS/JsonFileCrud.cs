using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMqttPOS
{
    class JsonFileCrud
    {

        private string jsonFile = Path.GetDirectoryName(Application.ExecutablePath)+"\\user.json";


        public JObject ReadJson(string key)
        {
            //var newCompanyMember = "{ 'username': " + username + ", 'password': '" + password + "'}";
            try
            {
                var json = File.ReadAllText(jsonFile);
                var jsonObj = JObject.Parse(json);
                var useObj = jsonObj.GetValue(key) as JObject;
                return useObj;
                //var newCompany = JObject.Parse(newCompanyMember);
                //experienceArrary.Add(newCompany);

                //jsonObj["experiences"] = experienceArrary;
                //string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                       //Newtonsoft.Json.Formatting.Indented);
                //File.WriteAllText(jsonFile, newJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Error : " + ex.Message.ToString());
            }
            return null;
        }

        private void AddUser(string username, string password)
        {
            var newCompanyMember = "{ 'username': " + username + ", 'password': '" + password + "'}";  
            try  
            {  
                var json = File.ReadAllText(jsonFile);
                var jsonObj = JObject.Parse(json);
                var experienceArrary = jsonObj.GetValue("experiences") as JArray;
                var newCompany = JObject.Parse(newCompanyMember);
                experienceArrary.Add(newCompany);  
  
                jsonObj["experiences"] = experienceArrary;  
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                       Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFile, newJsonResult);  
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine("Add Error : " + ex.Message.ToString());  
            }  
        }   


        public void UpdateConfig(string deviceId, string description, string username, string password)
        {
            string json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JObject loginObject = (JObject) jObject["login"];
                JObject clientObject = (JObject)jObject["client"];
                loginObject["username"] = !string.IsNullOrEmpty(username) ? username : "";
                loginObject["password"] = !string.IsNullOrEmpty(password) ? password : "";
                clientObject["deviceId"] = !string.IsNullOrEmpty(deviceId) ? deviceId : "";
                clientObject["description"] = !string.IsNullOrEmpty(description) ? description : "";
                jObject["login"] = loginObject;
                jObject["client"] = clientObject;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFile, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }
        }

        private void DeleteCompany()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["experiences"];
                Console.Write("Enter Company ID to Delete Company : ");
                var companyId = Convert.ToInt32(Console.ReadLine());

                if (companyId > 0)
                {
                    var companyName = string.Empty;
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["companyid"].Value<int>() == companyId);

                    experiencesArrary.Remove(companyToDeleted);

                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
                else
                {
                    Console.Write("Invalid Company ID, Try Again!");
                    //UpdateCompany(user);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetUserDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    Console.WriteLine("ID :" + jObject["id"].ToString());
                    Console.WriteLine("Name :" + jObject["name"].ToString());

                    var address = jObject["address"];
                    Console.WriteLine("Street :" + address["street"].ToString());
                    Console.WriteLine("City :" + address["city"].ToString());
                    Console.WriteLine("Zipcode :" + address["zipcode"]);
                    JArray experiencesArrary = (JArray)jObject["experiences"];
                    if (experiencesArrary != null)
                    {
                        foreach (var item in experiencesArrary)
                        {
                            Console.WriteLine("company Id :" + item["companyid"]);
                            Console.WriteLine("company Name :" + item["companyname"].ToString());
                        }

                    }
                    Console.WriteLine("Phone Number :" + jObject["phoneNumber"].ToString());
                    Console.WriteLine("Role :" + jObject["role"].ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
