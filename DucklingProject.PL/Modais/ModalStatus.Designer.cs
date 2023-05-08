namespace DucklingProject.PL
{
    partial class ModalStatus
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
            inserirStatusBox = new TextBox();
            inserirStatus_label = new Label();
            criaStatusButton = new Button();
            SuspendLayout();
            // 
            // inserirStatusBox
            // 
            inserirStatusBox.Location = new Point(12, 53);
            inserirStatusBox.Name = "inserirStatusBox";
            inserirStatusBox.Size = new Size(100, 23);
            inserirStatusBox.TabIndex = 0;
            // 
            // inserirStatus_label
            // 
            inserirStatus_label.AutoSize = true;
            inserirStatus_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            inserirStatus_label.ForeColor = Color.DarkOrange;
            inserirStatus_label.Location = new Point(12, 9);
            inserirStatus_label.Name = "inserirStatus_label";
            inserirStatus_label.Size = new Size(169, 28);
            inserirStatus_label.TabIndex = 1;
            inserirStatus_label.Text = "Insert status name";
            // 
            // criaStatusButton
            // 
            criaStatusButton.Location = new Point(119, 104);
            criaStatusButton.Name = "criaStatusButton";
            criaStatusButton.Size = new Size(90, 23);
            criaStatusButton.TabIndex = 2;
            criaStatusButton.Text = "Create status";
            criaStatusButton.UseVisualStyleBackColor = true;
            criaStatusButton.Click += criaStatusButton_Click;
            // 
            // ModalStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(221, 139);
            Controls.Add(criaStatusButton);
            Controls.Add(inserirStatus_label);
            Controls.Add(inserirStatusBox);
            Name = "ModalStatus";
            ShowIcon = false;
            Text = "Create status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inserirStatusBox;
        private Label inserirStatus_label;
        private Button criaStatusButton;
    }
}