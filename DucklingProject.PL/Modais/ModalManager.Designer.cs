namespace DucklingProject.PL
{
    partial class ModalManager
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
            managerNameBox = new TextBox();
            nomeManager_label = new Label();
            criaManagerButton = new Button();
            SuspendLayout();
            // 
            // managerNameBox
            // 
            managerNameBox.Location = new Point(18, 48);
            managerNameBox.Name = "managerNameBox";
            managerNameBox.Size = new Size(100, 23);
            managerNameBox.TabIndex = 0;
            // 
            // nomeManager_label
            // 
            nomeManager_label.AutoSize = true;
            nomeManager_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            nomeManager_label.ForeColor = Color.DarkOrange;
            nomeManager_label.Location = new Point(18, 9);
            nomeManager_label.Name = "nomeManager_label";
            nomeManager_label.Size = new Size(228, 28);
            nomeManager_label.TabIndex = 1;
            nomeManager_label.Text = "Insert the manager name";
            // 
            // criaManagerButton
            // 
            criaManagerButton.Location = new Point(147, 112);
            criaManagerButton.Name = "criaManagerButton";
            criaManagerButton.Size = new Size(112, 23);
            criaManagerButton.TabIndex = 2;
            criaManagerButton.Text = "Create manager";
            criaManagerButton.UseVisualStyleBackColor = true;
            criaManagerButton.Click += criaManagerButton_Click;
            // 
            // ModalManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(271, 147);
            Controls.Add(criaManagerButton);
            Controls.Add(nomeManager_label);
            Controls.Add(managerNameBox);
            Name = "ModalManager";
            ShowIcon = false;
            Text = "Create Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox managerNameBox;
        private Label nomeManager_label;
        private Button criaManagerButton;
    }
}