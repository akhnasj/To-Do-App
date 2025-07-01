using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.Marshalling;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList
{
    public partial class TodoApp : Form
    {
        public TodoApp()
        {
            InitializeComponent();
            // this.Load += TodoApp_Load;
        }

        private void TodoApp_Load(object sender, EventArgs e)
        {
            Load_Tasks();
        }

        private void Load_Tasks()
        {
            var db = new AppDbContext();
            var taskList = db.Tasks.ToList();
            dgvShowTask.DataSource = taskList;

            dgvShowTask.Columns["Id"].Visible = false;
            dgvShowTask.Columns["IsCompleted"].HeaderText = "Done";

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hello");

            if (string.IsNullOrWhiteSpace(titleText.Text)) return;

            var db = new AppDbContext();
            db.Tasks.Add(new TodoTasks { Title = titleText.Text.Trim(), IsCompleted = false });
            db.SaveChanges();
            titleText.Clear();
            db.Dispose();

            Load_Tasks();



        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            var updatedTasks = dgvShowTask.DataSource as List<TodoTasks>;

            if (updatedTasks == null) return;

            using (var db = new AppDbContext())
            {
                foreach (var task in updatedTasks)
                {
                    var existing = db.Tasks.Find(task.Id);
                    if (existing != null)
                    {
                        existing.Title = task.Title;
                        existing.IsCompleted = task.IsCompleted;
                    }
                }

                db.SaveChanges();
            }

            MessageBox.Show("Changes saved to database!");
            Load_Tasks();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvShowTask.SelectedRows.Count == 0) return;

            var selectedRow = dgvShowTask.SelectedRows[0];
            int taskId = (int)selectedRow.Cells["Id"].Value;

            using var db = new AppDbContext();
            var task = db.Tasks.Find(taskId);
            db.Tasks.Remove(task);
            db.SaveChanges();

            Load_Tasks();
        }

    }
}
