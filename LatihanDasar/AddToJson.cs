using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace LatihanDasar
{
    class AddToJson
    {
        class Employee
        {
            public string FirtsName { get; set; }
            public string LastsName { get; set; }
        }
        public static void Main(string[] args)
        {
            string folder = @"C:\DANIAR\LATE01\DANIAR N\JobSeeker\C# Latihan\Latihan Dasar\LatihanDasar\";
            string fileName = "JsonEmp.json";
            string fullPath = folder + fileName;
            Console.WriteLine("Learn Add Data In JSON");

            //Add To Json remember add [] in File Json [START]
            List<Employee> users = new List<Employee>();
            //users.Add(new Employee
            //{
            //    FirtsName = "Daniar",
            //    LastsName = "Nur Amin"
            //});
            //var JSONResult = JsonConvert.SerializeObject(users);
            //File.WriteAllText(fullPath, JSONResult);
            //Console.WriteLine(JSONResult);
            //Add To Json remember add [] in File Json [END]

            //Read adn Update Json [START]
            var jsonData = File.ReadAllText(fullPath);
            var employeeList = JsonConvert.DeserializeObject<List<Employee>>(jsonData) ?? new List<Employee>();
            File.WriteAllText(fullPath, "[]");
            foreach (var employee in employeeList)
            {
                users.Add(new Employee
                {
                    FirtsName = employee.FirtsName,
                    LastsName = "Ganteng"
                });
                var JSONResult = JsonConvert.SerializeObject(users);
                File.WriteAllText(fullPath, JSONResult);
            }
            
            //Read adn Update Json [END]

            // Add any new employees
            //employeeList.Add(new Employee()
            //{
            //    FirtsName = "Dwi Nugroho",
            //    LastsName = "Nur Amin"
            //});
            //employeeList.Add(new Employee()
            //{
            //    FirtsName = "Saeful",
            //    LastsName = "Sarif"
            //});

            //jsonData = JsonConvert.SerializeObject(employeeList);
            //File.WriteAllText(fullPath, jsonData);
            //Console.WriteLine(jsonData);
            Console.ReadLine();
        }
    }
}
