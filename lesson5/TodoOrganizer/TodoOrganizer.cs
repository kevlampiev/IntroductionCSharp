using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson5;
using System.Text.Json;
using System.IO;

namespace lesson5.TodoOrganizer
{
    internal class TodoOrganizer : TerminalApp
    {
        /// <summary>
        /// Имя файла с "базой данных" задач
        /// </summary>
        public string DBFileName { get; }

        /// <summary>
        /// Список задач
        /// </summary>
        public ToDo[] ToDoList { get; set; }

        /// <summary>
        /// Номер текущей задачи в списке ToDoList
        /// </summary>
        public int CurrentTask { get; set; }
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="taskNo">Номер задачи из ДЗ geekbrains</param>
        /// <param name="dbFileName">Имя файла с базой данных</param>
        public TodoOrganizer(int taskNo, string dbFileName = "todos.json") : base(taskNo)
        {
            dbFileName = dbFileName ?? "tasks.json"; //Ну, мало ли
            DBFileName = dbFileName;
            CurrentTask = -1;
        }

        //Загружает из файла список задач в память
        protected void LoadTodoList() 
        { 
            string json = File.ReadAllText(DBFileName)??"[]";
            json = (json != "") ? json : "[]";
            try
            {
                
                ToDoList = JsonSerializer.Deserialize<ToDo[]>(json);
                CurrentTask = 0;
            } catch (Exception ex) { 
                DisplayError(ex.Message);
                ToDoList = new ToDo[0]; 
                CurrentTask = -1;
            }
        }

        //Сохраняет список задач в файл
        protected void SaveTodoList()
        { 
            string json = JsonSerializer.Serialize(ToDoList);
            File.WriteAllText(DBFileName, json);
        }

        //Отображает список задач на экране
        protected void DisplayTodoList() 
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            DisplayHeader("--------------Список задач-------------");
            for (int i=0; i<ToDoList.Length; i++) {

                DisplayToDo(ToDoList[i], i);
            }
 
        }

        //Отображает меню
        private void DisplayMenu()
        {
            Console.SetCursorPosition(60, 1);
            Console.WriteLine("Выберите действие: ");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("Стрелки вверх и вниз - перемещение по списку");
            Console.SetCursorPosition(60, 3);
            Console.WriteLine("<ins> -добавить новую задачу");
            Console.SetCursorPosition(60, 4);
            Console.WriteLine("<space> -пометить как выполненную/невыполненную");
            Console.SetCursorPosition(60, 5);
            Console.WriteLine("<esc> -выход");
        }

        //Форматирует вывод одной записи
        private void DisplayToDo(ToDo toDo, int listNo)
        {
            if (listNo == CurrentTask)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine((toDo.IsDone?"[X]":"[ ]") + toDo.Title);
            Console.ResetColor();
        }

        //Вся перерисовка в одном месте
        private void Repaint() 
        {
            DisplayTodoList();
            DisplayMenu();
        }

        //Вспомогательная функция запрос имени задачи
        private string? GetNewTaskTitle()
        {
            Console.SetCursorPosition(60, 15);
            DisplayHeader("Введите название задачи");
            Console.SetCursorPosition(60, 16);
            return Console.ReadLine();
        }

        //Вспомогательная функция добавления новой задачи в массив
        private ToDo[] AppendNewToDo(string title)
        { 
            ToDo[] toDoList = new ToDo[ToDoList.Length+1];
            for (int i=0;i<ToDoList.Length; i++) {
                toDoList[i] = ToDoList[i];
            }
            toDoList[ToDoList.Length] = new ToDo(title??"Новая задача"); ;
            return toDoList;
        }

        /// <summary>
        /// Запрашивает название задачи и добавляет ее в список задач
        /// </summary>
        public void AddToDo() 
        {
            ToDoList = AppendNewToDo(GetNewTaskTitle());
        }

        /// <summary>
        /// Выделяет предыдущую задачу
        /// </summary>
        public void SelectPrevious()
        {
            Console.Write(CurrentTask);
            if (ToDoList.Length > 1) {
                if (CurrentTask > 0)
                {
                    CurrentTask--;
                }
                else { 
                    CurrentTask = ToDoList.Length-1;
                }
            }
        }

        /// <summary>
        /// Выделяет следующую задачу
        /// </summary>
        public void SelectNext()
        {
            Console.Write(CurrentTask);
            if (ToDoList.Length > 1)
            {
                if (CurrentTask >= ToDoList.Length-1)
                {
                    CurrentTask = 0;
                }
                else
                {
                    CurrentTask ++;
                }
            }
        }

        public void MarkAsDone() 
        {
            ToDoList[CurrentTask].IsDone = !ToDoList[CurrentTask].IsDone;
        }

        

        public override void Execute()
        {
            LoadTodoList();
            Repaint();
            while(true) {
                Console.SetCursorPosition(60, 6);
                //Console.Write("Выбрана команда: ");
                ConsoleKey k = Console.ReadKey().Key;
                switch (k) {
                    case ConsoleKey.Insert: 
                        AddToDo();
                        break;
                    case ConsoleKey.Spacebar:
                        MarkAsDone();
                        break;
                    case ConsoleKey.UpArrow:
                        SelectPrevious();
                        break;
                    case ConsoleKey.DownArrow:
                        SelectNext();
                        break;
                    case ConsoleKey.Escape: 
                        SaveTodoList();
                        return;    
                }
                Repaint();
            }
            
            
        }


    }
}
