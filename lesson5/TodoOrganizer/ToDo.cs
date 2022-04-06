using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson5;

namespace lesson5.TodoOrganizer
{
    internal class ToDo
    {
        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Признак выполнения
        /// </summary>
        public bool IsDone { get; set; }

        public ToDo(string title, bool isDone)
        { 
            Title = title;
            IsDone = isDone;
        }

        public ToDo(string title) 
        {
            Title = title;
            IsDone = false;
        }

        public ToDo() 
        {
            Title = "Новая задача";
            IsDone = false;
        }


    }
}
