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
            search_button = new Button();
            manageradd_button = new Button();
            stausadd_button = new Button();
            finishdate_picker = new DateTimePicker();
            startdate_picker = new DateTimePicker();
            manager_combobox = new ComboBox();
            status_combobox = new ComboBox();
            status_label = new Label();
            name_textbox = new TextBox();
            update_button = new Button();
            description_textbox = new TextBox();
            descripition_label = new Label();
            finish_date_label = new Label();
            startdate_label = new Label();
            manager_label = new Label();
            name_label = new Label();
            ProjectList = new GroupBox();
            ProjectList.SuspendLayout();
            SuspendLayout();
            // 
            // updateproject_label
            // 
            updateproject_label.AutoSize = true;
            updateproject_label.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            updateproject_label.ForeColor = Color.DarkOrange;
            updateproject_label.Location = new Point(23, 19);
            updateproject_label.Name = "updateproject_label";
            updateproject_label.Size = new Size(152, 25);
            updateproject_label.TabIndex = 11;
            updateproject_label.Text = "Update project";
            // 
            // search_button
            // 
            search_button.Location = new Point(236, 71);
            search_button.Name = "search_button";
            search_button.Size = new Size(75, 23);
            search_button.TabIndex = 27;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // manageradd_button
            // 
            manageradd_button.Location = new Point(248, 113);
            manageradd_button.Name = "manageradd_button";
            manageradd_button.Size = new Size(30, 22);
            manageradd_button.TabIndex = 26;
            manageradd_button.Text = "+";
            manageradd_button.UseVisualStyleBackColor = true;
            manageradd_button.Click += manageradd_button_Click_1;
            // 
            // stausadd_button
            // 
            stausadd_button.Location = new Point(248, 186);
            stausadd_button.Name = "stausadd_button";
            stausadd_button.Size = new Size(30, 22);
            stausadd_button.TabIndex = 25;
            stausadd_button.Text = "+";
            stausadd_button.UseVisualStyleBackColor = true;
            stausadd_button.Click += stausadd_button_Click;
            // 
            // finishdate_picker
            // 
            finishdate_picker.Location = new Point(445, 147);
            finishdate_picker.Name = "finishdate_picker";
            finishdate_picker.Size = new Size(200, 23);
            finishdate_picker.TabIndex = 24;
            // 
            // startdate_picker
            // 
            startdate_picker.Location = new Point(121, 149);
            startdate_picker.Name = "startdate_picker";
            startdate_picker.Size = new Size(200, 23);
            startdate_picker.TabIndex = 13;
            // 
            // manager_combobox
            // 
            manager_combobox.FormattingEnabled = true;
            manager_combobox.Location = new Point(121, 112);
            manager_combobox.Name = "manager_combobox";
            manager_combobox.Size = new Size(121, 23);
            manager_combobox.TabIndex = 23;
            manager_combobox.SelectedIndexChanged += managersComboBox_SelectedIndexChanged;
            manager_combobox.Click += managersComboBox_SelectedIndexChanged;
            // 
            // status_combobox
            // 
            status_combobox.FormattingEnabled = true;
            status_combobox.Location = new Point(121, 185);
            status_combobox.Name = "status_combobox";
            status_combobox.Size = new Size(121, 23);
            status_combobox.TabIndex = 13;
            status_combobox.Click += statusBox_SelectedIndexChanged_1;
            // 
            // status_label
            // 
            status_label.AutoSize = true;
            status_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            status_label.ForeColor = Color.DarkOrange;
            status_label.Location = new Point(23, 183);
            status_label.Name = "status_label";
            status_label.Size = new Size(55, 21);
            status_label.TabIndex = 22;
            status_label.Text = "Status:";
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(121, 75);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(100, 23);
            name_textbox.TabIndex = 18;
            // 
            // update_button
            // 
            update_button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            update_button.ForeColor = Color.Black;
            update_button.Location = new Point(550, 355);
            update_button.Name = "update_button";
            update_button.Size = new Size(119, 55);
            update_button.TabIndex = 17;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // description_textbox
            // 
            description_textbox.BackColor = SystemColors.InfoText;
            description_textbox.ForeColor = Color.White;
            description_textbox.Location = new Point(23, 286);
            description_textbox.Multiline = true;
            description_textbox.Name = "description_textbox";
            description_textbox.Size = new Size(322, 115);
            description_textbox.TabIndex = 16;
            // 
            // descripition_label
            // 
            descripition_label.AutoSize = true;
            descripition_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            descripition_label.ForeColor = Color.DarkOrange;
            descripition_label.Location = new Point(23, 255);
            descripition_label.Name = "descripition_label";
            descripition_label.Size = new Size(116, 28);
            descripition_label.TabIndex = 15;
            descripition_label.Text = "Description:";
            // 
            // finish_date_label
            // 
            finish_date_label.AutoSize = true;
            finish_date_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finish_date_label.ForeColor = Color.DarkOrange;
            finish_date_label.Location = new Point(349, 149);
            finish_date_label.Name = "finish_date_label";
            finish_date_label.Size = new Size(90, 21);
            finish_date_label.TabIndex = 14;
            finish_date_label.Text = "Finish Date:";
            // 
            // startdate_label
            // 
            startdate_label.AutoSize = true;
            startdate_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startdate_label.ForeColor = Color.DarkOrange;
            startdate_label.Location = new Point(23, 149);
            startdate_label.Name = "startdate_label";
            startdate_label.Size = new Size(81, 21);
            startdate_label.TabIndex = 13;
            startdate_label.Text = "Start Date:";
            // 
            // manager_label
            // 
            manager_label.AutoSize = true;
            manager_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            manager_label.ForeColor = Color.DarkOrange;
            manager_label.Location = new Point(23, 110);
            manager_label.Name = "manager_label";
            manager_label.Size = new Size(75, 21);
            manager_label.TabIndex = 12;
            manager_label.Text = "Manager:";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.ForeColor = Color.DarkOrange;
            name_label.Location = new Point(23, 73);
            name_label.Name = "name_label";
            name_label.Size = new Size(55, 21);
            name_label.TabIndex = 11;
            name_label.Text = "Name:";
            // 
            // ProjectList
            // 
            ProjectList.Controls.Add(search_button);
            ProjectList.Controls.Add(manageradd_button);
            ProjectList.Controls.Add(stausadd_button);
            ProjectList.Controls.Add(finishdate_picker);
            ProjectList.Controls.Add(startdate_picker);
            ProjectList.Controls.Add(manager_combobox);
            ProjectList.Controls.Add(status_combobox);
            ProjectList.Controls.Add(status_label);
            ProjectList.Controls.Add(name_textbox);
            ProjectList.Controls.Add(update_button);
            ProjectList.Controls.Add(updateproject_label);
            ProjectList.Controls.Add(description_textbox);
            ProjectList.Controls.Add(descripition_label);
            ProjectList.Controls.Add(finish_date_label);
            ProjectList.Controls.Add(startdate_label);
            ProjectList.Controls.Add(manager_label);
            ProjectList.Controls.Add(name_label);
            ProjectList.Location = new Point(12, 13);
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(680, 416);
            ProjectList.TabIndex = 12;
            ProjectList.TabStop = false;
            // 
            // ModalUpdateProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(706, 443);
            Controls.Add(ProjectList);
            Name = "ModalUpdateProject";
            ShowIcon = false;
            Text = "Update Project";
            ProjectList.ResumeLayout(false);
            ProjectList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label updateproject_label;
        public Label startdate_label;
        public Label manager_label;
        public Label name_label;
        public Label descripition_label;
        public Label finish_date_label;
        public TextBox description_textbox;
        public Button update_button;
        public TextBox name_textbox;
        public DateTimePicker finishdate_picker;
        public DateTimePicker startdate_picker;
        public ComboBox manager_combobox;
        public ComboBox status_combobox;
        public Label status_label;
        private Button stausadd_button;
        private Button manageradd_button;
        private Button search_button;
        public GroupBox ProjectList;
    }
}