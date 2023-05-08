namespace DucklingProject.PL.Modais
{
    partial class ModalUpdateProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            updateproject_label = new Label();
            ProjectList = new GroupBox();
            search_button = new Button();
            criarManager = new Button();
            addStatus = new Button();
            finishdate_picker = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            managersComboBox = new ComboBox();
            statusBox = new ComboBox();
            status_box = new Label();
            name_textbox = new TextBox();
            update_button = new Button();
            description_textbox = new TextBox();
            descripition_label = new Label();
            finish_date_label = new Label();
            start_date_label = new Label();
            manager_label = new Label();
            name_label = new Label();
            ProjectList.SuspendLayout();
            SuspendLayout();
            // 
            // updateproject_label
            // 
            updateproject_label.AutoSize = true;
            updateproject_label.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            updateproject_label.Location = new Point(296, 19);
            updateproject_label.Name = "updateproject_label";
            updateproject_label.Size = new Size(152, 25);
            updateproject_label.TabIndex = 11;
            updateproject_label.Text = "Update project";
            // 
            // ProjectList
            // 
            ProjectList.Controls.Add(search_button);
            ProjectList.Controls.Add(criarManager);
            ProjectList.Controls.Add(addStatus);
            ProjectList.Controls.Add(finishdate_picker);
            ProjectList.Controls.Add(dateTimePicker1);
            ProjectList.Controls.Add(managersComboBox);
            ProjectList.Controls.Add(statusBox);
            ProjectList.Controls.Add(status_box);
            ProjectList.Controls.Add(name_textbox);
            ProjectList.Controls.Add(update_button);
            ProjectList.Controls.Add(updateproject_label);
            ProjectList.Controls.Add(description_textbox);
            ProjectList.Controls.Add(descripition_label);
            ProjectList.Controls.Add(finish_date_label);
            ProjectList.Controls.Add(start_date_label);
            ProjectList.Controls.Add(manager_label);
            ProjectList.Controls.Add(name_label);
            ProjectList.Location = new Point(12, 12);
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(680, 416);
            ProjectList.TabIndex = 12;
            ProjectList.TabStop = false;
            // 
            // search_button
            // 
            search_button.Location = new Point(241, 62);
            search_button.Name = "search_button";
            search_button.Size = new Size(75, 23);
            search_button.TabIndex = 27;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // criarManager
            // 
            criarManager.Location = new Point(253, 104);
            criarManager.Name = "criarManager";
            criarManager.Size = new Size(30, 22);
            criarManager.TabIndex = 26;
            criarManager.Text = "+";
            criarManager.UseVisualStyleBackColor = true;
            // 
            // addStatus
            // 
            addStatus.Location = new Point(253, 195);
            addStatus.Name = "addStatus";
            addStatus.Size = new Size(30, 22);
            addStatus.TabIndex = 25;
            addStatus.Text = "+";
            addStatus.UseVisualStyleBackColor = true;
            // 
            // finishdate_picker
            // 
            finishdate_picker.Location = new Point(450, 151);
            finishdate_picker.Name = "finishdate_picker";
            finishdate_picker.Size = new Size(200, 23);
            finishdate_picker.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // managersComboBox
            // 
            managersComboBox.FormattingEnabled = true;
            managersComboBox.Location = new Point(126, 105);
            managersComboBox.Name = "managersComboBox";
            managersComboBox.Size = new Size(121, 23);
            managersComboBox.TabIndex = 23;
            managersComboBox.SelectedIndexChanged += managersComboBox_SelectedIndexChanged;
            managersComboBox.Click += managersComboBox_SelectedIndexChanged;
            // 
            // statusBox
            // 
            statusBox.FormattingEnabled = true;
            statusBox.Location = new Point(126, 194);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(121, 23);
            statusBox.TabIndex = 13;
            statusBox.Click += statusBox_SelectedIndexChanged_1;
            // 
            // status_box
            // 
            status_box.AutoSize = true;
            status_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            status_box.Location = new Point(28, 194);
            status_box.Name = "status_box";
            status_box.Size = new Size(55, 21);
            status_box.TabIndex = 22;
            status_box.Text = "Status:";
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(126, 62);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(100, 23);
            name_textbox.TabIndex = 18;
            // 
            // update_button
            // 
            update_button.Location = new Point(555, 355);
            update_button.Name = "update_button";
            update_button.Size = new Size(119, 55);
            update_button.TabIndex = 17;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // description_textbox
            // 
            description_textbox.Location = new Point(28, 286);
            description_textbox.Multiline = true;
            description_textbox.Name = "description_textbox";
            description_textbox.Size = new Size(322, 115);
            description_textbox.TabIndex = 16;
            // 
            // descripition_label
            // 
            descripition_label.AutoSize = true;
            descripition_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descripition_label.Location = new Point(28, 262);
            descripition_label.Name = "descripition_label";
            descripition_label.Size = new Size(92, 21);
            descripition_label.TabIndex = 15;
            descripition_label.Text = "Description:";
            // 
            // finish_date_label
            // 
            finish_date_label.AutoSize = true;
            finish_date_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finish_date_label.Location = new Point(354, 151);
            finish_date_label.Name = "finish_date_label";
            finish_date_label.Size = new Size(90, 21);
            finish_date_label.TabIndex = 14;
            finish_date_label.Text = "Finish Date:";
            // 
            // start_date_label
            // 
            start_date_label.AutoSize = true;
            start_date_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            start_date_label.Location = new Point(28, 151);
            start_date_label.Name = "start_date_label";
            start_date_label.Size = new Size(81, 21);
            start_date_label.TabIndex = 13;
            start_date_label.Text = "Start Date:";
            // 
            // manager_label
            // 
            manager_label.AutoSize = true;
            manager_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            manager_label.Location = new Point(28, 107);
            manager_label.Name = "manager_label";
            manager_label.Size = new Size(75, 21);
            manager_label.TabIndex = 12;
            manager_label.Text = "Manager:";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.Location = new Point(28, 60);
            name_label.Name = "name_label";
            name_label.Size = new Size(55, 21);
            name_label.TabIndex = 11;
            name_label.Text = "Name:";
            // 
            // ModalUpdateProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 441);
            Controls.Add(ProjectList);
            Name = "ModalUpdateProject";
            Text = "Tela secundária";
            ProjectList.ResumeLayout(false);
            ProjectList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label updateproject_label;
        public GroupBox ProjectList;
        public Label start_date_label;
        public Label manager_label;
        public Label name_label;
        public Label descripition_label;
        public Label finish_date_label;
        public TextBox description_textbox;
        public Button update_button;
        public TextBox name_textbox;
        public DateTimePicker finishdate_picker;
        public DateTimePicker dateTimePicker1;
        public ComboBox managersComboBox;
        public ComboBox statusBox;
        public Label status_box;
        private Button addStatus;
        private Button criarManager;
        private Button search_button;
    }
}