using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList
{
    public partial class TodoApp : Form
    {
        public TodoApp()
        {
            InitializeComponent();

            this.Load += TodoApp_Load;

            dgvShowTask.CellEndEdit += dgvShowTask_CellEndEdit;
            dgvShowTask.CellContentClick += dgvShowTask_CellContentClick;
            dgvShowTask.RowLeave += dgvShowTask_RowLeave;
        }

        private void TodoApp_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadTasks()
        {
            var db = new AppDbContext();
            var taskList = db.Tasks.ToList();
            dgvShowTask.DataSource = taskList;

            dgvShowTask.Columns["Id"].Visible = false;
            dgvShowTask.Columns["IsCompleted"].HeaderText = "Done";
            dgvShowTask.Columns["DueDate"].HeaderText = "Due Date";

            dgvShowTask.Columns["IsCompleted"].ReadOnly = false;


            if (dgvShowTask.Columns["DeleteButton"] == null)
            {
                var deleteButton = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    HeaderText = "",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgvShowTask.Columns.Add(deleteButton);
            }


            foreach (DataGridViewRow row in dgvShowTask.Rows)
            {
                if (!row.IsNewRow)
                {
                    DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
                    bool isCompleted = Convert.ToBoolean(row.Cells["IsCompleted"].Value);

                    if (dueDate < DateTime.UtcNow && !isCompleted)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red; 
                    }
                }
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hello");

            if (string.IsNullOrWhiteSpace(titleText.Text)) return;

            var db = new AppDbContext();
            var newTask = new TodoTasks
            {
                Title = titleText.Text.Trim(),
                IsCompleted = false,
                dueDate = dateDatePicker.Value.ToUniversalTime()
            };

            db.Tasks.Add(newTask);
            db.SaveChanges();
            titleText.Clear();
            db.Dispose();

            LoadTasks();

        }


        private void dgvShowTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvShowTask.Columns[e.ColumnIndex].Name;
            int taskId = (int)dgvShowTask.Rows[e.RowIndex].Cells["id"].Value;

            if (columnName == "DeleteButton")
                DeleteTask(taskId);
        }



        private void DeleteTask(int taskId)
        {
            using var db = new AppDbContext();
            var task = db.Tasks.Find(taskId);
            if (task != null)
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
            }
            LoadTasks();
        }

        private void SaveRowIfChanged(int rowIndex)
        {
            var row = dgvShowTask.Rows[rowIndex];
            if (row.IsNewRow) return;

            int id = (int)row.Cells["Id"].Value;
            string newTitle = row.Cells["Title"].Value?.ToString();
            DateTime newDueDate;
            bool validDate = DateTime.TryParse(row.Cells["DueDate"].Value?.ToString(), out newDueDate);
            bool newIsCompleted = Convert.ToBoolean(row.Cells["IsCompleted"].Value);

            if (!validDate)
            {
                MessageBox.Show("Invalid date.");
                LoadTasks(); 
                return;
            }

            newDueDate = newDueDate.ToUniversalTime(); 

            using var db = new AppDbContext();
            var task = db.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return;

            bool changed = false;

            if (task.Title != newTitle)
            {
                task.Title = newTitle;
                changed = true;
            }

            if (task.dueDate != newDueDate)
            {
                task.dueDate = newDueDate;
                changed = true;
            }

            if (task.IsCompleted != newIsCompleted)
            {
                task.IsCompleted = newIsCompleted;
                changed = true;
            }

            if (changed)
            {
                db.SaveChanges();
                this.BeginInvoke(new Action(() => LoadTasks()));

            }
        }


        private void dgvShowTask_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveRowIfChanged(e.RowIndex);
        }


        private void dgvShowTask_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvShowTask.EndEdit();
        }

    }
}
