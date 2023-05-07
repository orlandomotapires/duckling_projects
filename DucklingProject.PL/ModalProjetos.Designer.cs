namespace DucklingProject.PL
{
    partial class ModalProjetos
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
            newproject_label = new Label();
            ProjectList = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            status_box = new Label();
            name_textbox = new TextBox();
            create_button = new Button();
            description_textbox = new TextBox();
            descripition_label = new Label();
            finish_date_label = new Label();
            start_date_label = new Label();
            manager_label = new Label();
            name_label = new Label();
            ProjectList.SuspendLayout();
            SuspendLayout();
            // 
            // newproject_label
            // 
            newproject_label.AutoSize = true;
            newproject_label.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            newproject_label.Location = new Point(296, 19);
            newproject_label.Name = "newproject_label";
            newproject_label.Size = new Size(127, 25);
            newproject_label.TabIndex = 11;
            newproject_label.Text = "New Project";
            // 
            // ProjectList
            // 
            ProjectList.Controls.Add(dateTimePicker2);
            ProjectList.Controls.Add(dateTimePicker1);
            ProjectList.Controls.Add(comboBox2);
            ProjectList.Controls.Add(comboBox1);
            ProjectList.Controls.Add(status_box);
            ProjectList.Controls.Add(name_textbox);
            ProjectList.Controls.Add(create_button);
            ProjectList.Controls.Add(newproject_label);
            ProjectList.Controls.Add(description_textbox);
            ProjectList.Controls.Add(descripition_label);
            ProjectList.Controls.Add(finish_date_label);
            ProjectList.Controls.Add(start_date_label);
            ProjectList.Controls.Add(manager_label);
            ProjectList.Controls.Add(name_label);
            ProjectList.Location = new Point(209, 22);
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(680, 416);
            ProjectList.TabIndex = 12;
            ProjectList.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(450, 151);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(126, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Não iniciado", "Em andamento", "Concluído" });
            comboBox1.Location = new Point(126, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
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
            // create_button
            // 
            create_button.Location = new Point(555, 355);
            create_button.Name = "create_button";
            create_button.Size = new Size(119, 55);
            create_button.TabIndex = 17;
            create_button.Text = "Create";
            create_button.UseVisualStyleBackColor = true;
            // 
            // description_textbox
            // 
            description_textbox.Location = new Point(28, 286);
            description_textbox.Multiline = true;
            description_textbox.Name = "description_textbox";
            description_textbox.Size = new Size(322, 115);
            description_textbox.TabIndex = 16;
            description_textbox.TextChanged += description_textbox_TextChanged;
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
            // ModalProjetos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(ProjectList);
            Name = "ModalProjetos";
            Text = "Tela secundária";
            ProjectList.ResumeLayout(false);
            ProjectList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label newproject_label;
        public GroupBox ProjectList;
        public Label start_date_label;
        public Label manager_label;
        public Label name_label;
        public Label descripition_label;
        public Label finish_date_label;
        public TextBox description_textbox;
        public Button create_button;
        public TextBox name_textbox;
        public DateTimePicker dateTimePicker2;
        public DateTimePicker dateTimePicker1;
        public ComboBox comboBox2;
        public ComboBox comboBox1;
        public Label status_box;

    }
}