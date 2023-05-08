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
            Label manageprojects_label;
            createproject_button = new Button();
            updateproject_button = new Button();
            deleteproject_button = new Button();
            duckling_label = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            log_label = new Label();
            colorDialog1 = new ColorDialog();
            ch = new ColumnHeader();
            refreshButton = new Button();
            projects_listview = new ListView();
            name_column = new ColumnHeader();
            Startdate = new ColumnHeader();
            FinishDate = new ColumnHeader();
            Manager = new ColumnHeader();
            groupBox1 = new GroupBox();
            toolTip1 = new ToolTip(components);
            manageprojects_label = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // manageprojects_label
            // 
            manageprojects_label.AutoSize = true;
            manageprojects_label.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            manageprojects_label.ForeColor = Color.FromArgb(255, 122, 0);
            manageprojects_label.Location = new Point(524, 71);
            manageprojects_label.Name = "manageprojects_label";
            manageprojects_label.Size = new Size(214, 37);
            manageprojects_label.TabIndex = 15;
            manageprojects_label.Text = "Manage Projects";
            // 
            // createproject_button
            // 
            createproject_button.BackColor = Color.FromArgb(59, 0, 106);
            createproject_button.ForeColor = Color.White;
            createproject_button.Location = new Point(524, 120);
            createproject_button.Name = "createproject_button";
            createproject_button.Size = new Size(126, 47);
            createproject_button.TabIndex = 0;
            createproject_button.Text = "Create Project";
            createproject_button.UseVisualStyleBackColor = false;
            createproject_button.Click += createproject_button_Click;
            // 
            // updateproject_button
            // 
            updateproject_button.BackColor = Color.FromArgb(59, 0, 106);
            updateproject_button.ForeColor = Color.White;
            updateproject_button.Location = new Point(656, 120);
            updateproject_button.Name = "updateproject_button";
            updateproject_button.Size = new Size(126, 46);
            updateproject_button.TabIndex = 1;
            updateproject_button.Text = "Update Project";
            updateproject_button.UseVisualStyleBackColor = false;
            updateproject_button.Click += updateproject_button_Click;
            // 
            // deleteproject_button
            // 
            deleteproject_button.BackColor = Color.FromArgb(59, 0, 106);
            deleteproject_button.ForeColor = Color.White;
            deleteproject_button.Location = new Point(788, 120);
            deleteproject_button.Name = "deleteproject_button";
            deleteproject_button.Size = new Size(126, 46);
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
            duckling_label.Location = new Point(26, 9);
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
            // log_label
            // 
            log_label.AutoSize = true;
            log_label.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            log_label.ForeColor = Color.FromArgb(255, 122, 0);
            log_label.Location = new Point(26, 129);
            log_label.Name = "log_label";
            log_label.Size = new Size(162, 37);
            log_label.TabIndex = 8;
            log_label.Text = "Projects Log";
            // 
            // ch
            // 
            ch.Text = "Tela_principal";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(194, 143);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(110, 23);
            refreshButton.TabIndex = 11;
            refreshButton.Text = "Refresh Projects";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // projects_listview
            // 
            projects_listview.Alignment = ListViewAlignment.Default;
            projects_listview.AllowColumnReorder = true;
            projects_listview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projects_listview.BackColor = Color.Black;
            projects_listview.BorderStyle = BorderStyle.None;
            projects_listview.CheckBoxes = true;
            projects_listview.Columns.AddRange(new ColumnHeader[] { name_column, Startdate, FinishDate, Manager });
            projects_listview.ContextMenuStrip = contextMenuStrip1;
            projects_listview.ForeColor = Color.DarkOrange;
            projects_listview.FullRowSelect = true;
            projects_listview.LabelEdit = true;
            projects_listview.Location = new Point(13, 22);
            projects_listview.Margin = new Padding(10, 25, 10, 10);
            projects_listview.Name = "projects_listview";
            projects_listview.Size = new Size(862, 281);
            projects_listview.TabIndex = 11;
            projects_listview.UseCompatibleStateImageBehavior = false;
            projects_listview.View = View.Details;
            projects_listview.SelectedIndexChanged += ProjectsLog_SelectedIndexChanged;
            // 
            // name_column
            // 
            name_column.Name = "TelaPrincipal";
            name_column.Text = "Name";
            name_column.Width = 200;
            // 
            // Startdate
            // 
            Startdate.Text = "StartDate";
            Startdate.Width = 200;
            // 
            // FinishDate
            // 
            FinishDate.Text = "FinishDate";
            FinishDate.Width = 200;
            // 
            // Manager
            // 
            Manager.Text = "Manager";
            Manager.Width = 250;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(projects_listview);
            groupBox1.Location = new Point(26, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 322);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(944, 501);
            Controls.Add(manageprojects_label);
            Controls.Add(refreshButton);
            Controls.Add(groupBox1);
            Controls.Add(log_label);
            Controls.Add(duckling_label);
            Controls.Add(deleteproject_button);
            Controls.Add(updateproject_button);
            Controls.Add(createproject_button);
            //Name = "TelaPrincipal";
            ShowIcon = false;
            Text = "Duckling";
            Load += TelaPrincipal_Load;
            groupBox1.ResumeLayout(false);
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
        private Label log_label;
        private ColumnHeader Name;
        private ColorDialog colorDialog1;
        private ColumnHeader ch;
        private Button refreshButton;
        private ListView projects_listview;
        private ColumnHeader name_column;
        private ColumnHeader Startdate;
        private ColumnHeader FinishDate;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private ColumnHeader Manager;
    }
}