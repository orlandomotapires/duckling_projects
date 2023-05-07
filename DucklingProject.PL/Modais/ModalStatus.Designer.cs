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
            inserirStatusLabel = new Label();
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
            // inserirStatusLabel
            // 
            inserirStatusLabel.AutoSize = true;
            inserirStatusLabel.Location = new Point(12, 23);
            inserirStatusLabel.Name = "inserirStatusLabel";
            inserirStatusLabel.Size = new Size(120, 15);
            inserirStatusLabel.TabIndex = 1;
            inserirStatusLabel.Text = "Insira um novo status";
            // 
            // criaStatusButton
            // 
            criaStatusButton.Location = new Point(93, 97);
            criaStatusButton.Name = "criaStatusButton";
            criaStatusButton.Size = new Size(75, 23);
            criaStatusButton.TabIndex = 2;
            criaStatusButton.Text = "Criar Status";
            criaStatusButton.UseVisualStyleBackColor = true;
            criaStatusButton.Click += criaStatusButton_Click;
            // 
            // ModalStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 139);
            Controls.Add(criaStatusButton);
            Controls.Add(inserirStatusLabel);
            Controls.Add(inserirStatusBox);
            Name = "ModalStatus";
            Text = "ModalStatus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inserirStatusBox;
        private Label inserirStatusLabel;
        private Button criaStatusButton;
    }
}