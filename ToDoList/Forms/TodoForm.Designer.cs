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
            titleLabel = new Label();
            duedateLabel = new Label();
            dateDatePicker = new DateTimePicker();
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
            titleText.Location = new Point(68, 76);
            titleText.Multiline = true;
            titleText.Name = "titleText";
            titleText.Size = new Size(351, 44);
            titleText.TabIndex = 2;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(723, 72);
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
            dgvShowTask.Location = new Point(90, 140);
            dgvShowTask.Name = "dgvShowTask";
            dgvShowTask.RowHeadersWidth = 62;
            dgvShowTask.Size = new Size(665, 342);
            dgvShowTask.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(9, 85);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(53, 25);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Title :";
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new Point(425, 85);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new Size(95, 25);
            duedateLabel.TabIndex = 7;
            duedateLabel.Text = "Due Date :";
            // 
            // dateDatePicker
            // 
            dateDatePicker.Location = new Point(515, 85);
            dateDatePicker.Name = "dateDatePicker";
            dateDatePicker.Size = new Size(192, 31);
            dateDatePicker.TabIndex = 8;
            // 
            // TodoApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 510);
            Controls.Add(dateDatePicker);
            Controls.Add(duedateLabel);
            Controls.Add(titleLabel);
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
        private Label titleLabel;
        private Label duedateLabel;
        private DateTimePicker dateDatePicker;
    }
}
