using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;

namespace ToDoAppX.ViewModels
{
    public class ToDoAssignee
    {
        public List<Assignee> Assignees { get; set; }
        public ToDo SelectedToDo { get; set; }
    }
}
