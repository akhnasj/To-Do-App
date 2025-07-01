namespace ToDoList
{
    partial class TodoApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            todoLabel = new Label();
            titleText = new TextBox();
            addTaskButton = new Button();
            dgvShowTask = new DataGridView();
            saveButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowTask).BeginInit();
            SuspendLayout();
            // 
            // todoLabel
            // 
            todoLabel.AutoSize = true;
            todoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            todoLabel.Location = new Point(361, 9);
            todoLabel.Name = "todoLabel";
            todoLabel.Size = new Size(142, 32);
            todoLabel.TabIndex = 1;
            todoLabel.Text = "TO DO LIST";
            // 
            // titleText
            // 
            titleText.BorderStyle = BorderStyle.FixedSingle;
            titleText.Location = new Point(38, 82);
            titleText.Multiline = true;
            titleText.Name = "titleText";
            titleText.Size = new Size(351, 44);
            titleText.TabIndex = 2;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(160, 147);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(112, 51);
            addTaskButton.TabIndex = 3;
            addTaskButton.Text = "Add";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // dgvShowTask
            // 
            dgvShowTask.AllowUserToAddRows = false;
            dgvShowTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowTask.Location = new Point(422, 82);
            dgvShowTask.Name = "dgvShowTask";
            dgvShowTask.RowHeadersWidth = 62;
            dgvShowTask.Size = new Size(402, 348);
            dgvShowTask.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(160, 283);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 51);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(160, 352);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 51);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // TodoApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 510);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(dgvShowTask);
            Controls.Add(addTaskButton);
            Controls.Add(titleText);
            Controls.Add(todoLabel);
            Name = "TodoApp";
            Text = "Todo App";
            Load += TodoApp_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label todoLabel;
        private TextBox titleText;
        private Button addTaskButton;
        private DataGridView dgvShowTask;
        private Button saveButton;
        private Button deleteButton;
    }
}
