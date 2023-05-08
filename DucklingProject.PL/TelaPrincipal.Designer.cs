namespace DucklingProject.PL
{
    partial class TelaPrincipal
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
            components = new System.ComponentModel.Container();
            createproject_button = new Button();
            updateproject_button = new Button();
            deleteproject_button = new Button();
            duckling_label = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            ProjectList = new GroupBox();
            finishdate_label = new Label();
            startdate_label = new Label();
            namelog_label = new Label();
            ProjectsLog = new ListView();
            Abacaxi = new ColumnHeader();
            Startdate = new ColumnHeader();
            FinishDate = new ColumnHeader();
            log_label = new Label();
            colorDialog1 = new ColorDialog();
            ch = new ColumnHeader();
            refreshButton = new Button();
            delete_box = new TextBox();
            ProjectList.SuspendLayout();
            SuspendLayout();
            // 
            // createproject_button
            // 
            createproject_button.BackColor = Color.FromArgb(59, 0, 106);
            createproject_button.FlatAppearance.BorderSize = 15;
            createproject_button.FlatStyle = FlatStyle.Flat;
            createproject_button.ForeColor = Color.FromArgb(255, 122, 0);
            createproject_button.Location = new Point(65, 96);
            createproject_button.Name = "createproject_button";
            createproject_button.Size = new Size(169, 99);
            createproject_button.TabIndex = 0;
            createproject_button.Text = "Create Project";
            createproject_button.UseVisualStyleBackColor = false;
            createproject_button.Click += createproject_button_Click;
            // 
            // updateproject_button
            // 
            updateproject_button.BackColor = Color.FromArgb(59, 0, 106);
            updateproject_button.ForeColor = Color.FromArgb(255, 122, 0);
            updateproject_button.Location = new Point(65, 328);
            updateproject_button.Name = "updateproject_button";
            updateproject_button.Size = new Size(169, 99);
            updateproject_button.TabIndex = 1;
            updateproject_button.Text = "Update Project";
            updateproject_button.UseVisualStyleBackColor = false;
            updateproject_button.Click += updateproject_button_Click;
            // 
            // deleteproject_button
            // 
            deleteproject_button.BackColor = Color.FromArgb(59, 0, 106);
            deleteproject_button.ForeColor = Color.FromArgb(255, 122, 0);
            deleteproject_button.Location = new Point(65, 210);
            deleteproject_button.Name = "deleteproject_button";
            deleteproject_button.Size = new Size(169, 99);
            deleteproject_button.TabIndex = 2;
            deleteproject_button.Text = "Delete Project";
            deleteproject_button.UseVisualStyleBackColor = false;
            deleteproject_button.Click += deleteproject_button_Click;
            // 
            // duckling_label
            // 
            duckling_label.AutoSize = true;
            duckling_label.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            duckling_label.ForeColor = Color.FromArgb(255, 122, 0);
            duckling_label.Location = new Point(299, 9);
            duckling_label.Name = "duckling_label";
            duckling_label.Size = new Size(329, 54);
            duckling_label.TabIndex = 4;
            duckling_label.Text = "Duckling Projects";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ProjectList
            // 
            ProjectList.Controls.Add(finishdate_label);
            ProjectList.Controls.Add(startdate_label);
            ProjectList.Controls.Add(namelog_label);
            ProjectList.Controls.Add(ProjectsLog);
            ProjectList.Location = new Point(548, 119);
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(366, 339);
            ProjectList.TabIndex = 10;
            ProjectList.TabStop = false;
            // 
            // finishdate_label
            // 
            finishdate_label.AutoSize = true;
            finishdate_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finishdate_label.ForeColor = Color.FromArgb(255, 122, 0);
            finishdate_label.Location = new Point(260, 12);
            finishdate_label.Name = "finishdate_label";
            finishdate_label.Size = new Size(87, 21);
            finishdate_label.TabIndex = 13;
            finishdate_label.Text = "Finish Date";
            // 
            // startdate_label
            // 
            startdate_label.AutoSize = true;
            startdate_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startdate_label.ForeColor = Color.FromArgb(255, 122, 0);
            startdate_label.Location = new Point(148, 12);
            startdate_label.Name = "startdate_label";
            startdate_label.Size = new Size(78, 21);
            startdate_label.TabIndex = 12;
            startdate_label.Text = "Start Date";
            // 
            // namelog_label
            // 
            namelog_label.AutoSize = true;
            namelog_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            namelog_label.ForeColor = Color.FromArgb(255, 122, 0);
            namelog_label.Location = new Point(30, 12);
            namelog_label.Name = "namelog_label";
            namelog_label.Size = new Size(52, 21);
            namelog_label.TabIndex = 11;
            namelog_label.Text = "Name";
            // 
            // ProjectsLog
            // 
            ProjectsLog.BackColor = SystemColors.HighlightText;
            ProjectsLog.Columns.AddRange(new ColumnHeader[] { Abacaxi, Startdate, FinishDate });
            ProjectsLog.Location = new Point(6, 36);
            ProjectsLog.Name = "ProjectsLog";
            ProjectsLog.Size = new Size(354, 295);
            ProjectsLog.TabIndex = 11;
            ProjectsLog.UseCompatibleStateImageBehavior = false;
            ProjectsLog.View = View.Details;
            ProjectsLog.SelectedIndexChanged += ProjectsLog_SelectedIndexChanged;
            // 
            // Abacaxi
            // 
            Abacaxi.Name = "TelaPrincipal";
            Abacaxi.Text = "Name";
            Abacaxi.Width = 140;
            // 
            // Startdate
            // 
            Startdate.Text = "StartDate";
            Startdate.Width = 110;
            // 
            // FinishDate
            // 
            FinishDate.Text = "FinishDate";
            FinishDate.Width = 120;
            // 
            // log_label
            // 
            log_label.AutoSize = true;
            log_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            log_label.ForeColor = Color.FromArgb(255, 122, 0);
            log_label.Location = new Point(682, 88);
            log_label.Name = "log_label";
            log_label.Size = new Size(119, 28);
            log_label.TabIndex = 8;
            log_label.Text = "Projects Log";
            // 
            // ch
            // 
            ch.Text = "Tela_principal";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(548, 464);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(99, 23);
            refreshButton.TabIndex = 11;
            refreshButton.Text = "Refresh Projects";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // delete_box
            // 
            delete_box.Location = new Point(251, 249);
            delete_box.Name = "delete_box";
            delete_box.Size = new Size(100, 23);
            delete_box.TabIndex = 12;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(944, 501);
            Controls.Add(delete_box);
            Controls.Add(refreshButton);
            Controls.Add(log_label);
            Controls.Add(ProjectList);
            Controls.Add(duckling_label);
            Controls.Add(deleteproject_button);
            Controls.Add(updateproject_button);
            Controls.Add(createproject_button);
            //Name = "TelaPrincipal";
            Text = "Tela principal";
            Load += TelaPrincipal_Load;
            ProjectList.ResumeLayout(false);
            ProjectList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createproject_button;
        private Button updateproject_button;
        private Button deleteproject_button;
        private Label duckling_label;
        private ImageList imageList1;
        private ImageList imageList2;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox ProjectList;
        private Label log_label;
        private ListView ProjectsLog;
        private ColumnHeader Name;
        private ColumnHeader Startdate;
        private ColumnHeader FinishDate;
        private Label finishdate_label;
        private Label startdate_label;
        private Label namelog_label;
        private ColorDialog colorDialog1;
        private ColumnHeader ch;
        private ColumnHeader Abacaxi;
        private Button refreshButton;
        private TextBox delete_box;
    }
}