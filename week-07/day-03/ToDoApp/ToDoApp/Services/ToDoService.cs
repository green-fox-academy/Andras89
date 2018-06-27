using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class ToDoService : IToDo
    {
        private List<ToDo> database = new List<ToDo>();
        private int id = 0;

        public List<ToDo> GetToDoDatabase()
        {
            return database;
        }

        public void LoadFromFile()
        {
            string json = File.ReadAllText(@"SavedFiles/path.json");
            database = JsonConvert.DeserializeObject<List<ToDo>>(json);
        }

        public void RemoveToDo(int input)
        {
            List<ToDo> temp = database.Where(x => x.Id != input).ToList();
            database = temp;
        }

        public void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(database.ToArray());

            File.WriteAllText(@"SavedFiles/path.json", json);
        }

        public void SetCompleteToDo(int input)
        {
            database.Where(x => x.Id == input).ToArray()[0].Complete = true;
        }

        public void SetId()
        {
            id++;
        }

        public void SetToDo(ToDo input)
        {
            SetId();
            input.Id = id;
            database.Add(input);
        }

        public void SetUrgentToDo(int input)
        {
            database.Where(x => x.Id == input).ToArray()[0].IsUrgent = true;
        }
    }
}
