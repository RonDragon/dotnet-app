using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MyProject.Models;

namespace MyProject.DAL
{
    public class MyDataAccess
    {
        public IEnumerable<MyEntity> GetAllEntities()
        {
            var entities = new List<MyEntity>();
            Random random = new Random();
            for (int i = 0; i < 10; i++) // Generate 10 random numbers
        {
             List<string> firstNames = new List<string>
        {
            "John", "Jane", "Alex", "Emily", "Chris", "Katie", "Michael", "Sarah"
        };
        
        List<string> lastNames = new List<string>
        {
            "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson"
        };        
        // Randomly select a first name and a last name
        string firstName = firstNames[random.Next(firstNames.Count)];
        string lastName = lastNames[random.Next(lastNames.Count)];
            var obj = new MyEntity{Id=random.Next(1, 101),Name=firstName +' ' +lastName};
            entities.Add(obj); // Random number between 1 and 100
        }
            return entities;
        }

        public MyEntity GetEntityById(int id)
        {
            MyEntity entity = null;
            return entity;
        }

        public void AddEntity(MyEntity entity)
        {

        }

        public void UpdateEntity(MyEntity entity)
        {

        }

        public void DeleteEntity(int id)
        {

        }
    }
}