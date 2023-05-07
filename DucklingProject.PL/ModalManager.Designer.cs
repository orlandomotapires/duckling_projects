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
            nomeManagerLabel = new Label();
            criaManagerButton = new Button();
            SuspendLayout();
            // 
            // managerNameBox
            // 
            managerNameBox.Location = new Point(22, 48);
            managerNameBox.Name = "managerNameBox";
            managerNameBox.Size = new Size(100, 23);
            managerNameBox.TabIndex = 0;
            // 
            // nomeManagerLabel
            // 
            nomeManagerLabel.AutoSize = true;
            nomeManagerLabel.Location = new Point(22, 21);
            nomeManagerLabel.Name = "nomeManagerLabel";
            nomeManagerLabel.Size = new Size(146, 15);
            nomeManagerLabel.TabIndex = 1;
            nomeManagerLabel.Text = "Insira o nome do manager";
            // 
            // criaManagerButton
            // 
            criaManagerButton.Location = new Point(96, 93);
            criaManagerButton.Name = "criaManagerButton";
            criaManagerButton.Size = new Size(95, 23);
            criaManagerButton.TabIndex = 2;
            criaManagerButton.Text = "Criar manager";
            criaManagerButton.UseVisualStyleBackColor = true;
            criaManagerButton.Click += criaManagerButton_Click;
            // 
            // ModalManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 135);
            Controls.Add(criaManagerButton);
            Controls.Add(nomeManagerLabel);
            Controls.Add(managerNameBox);
            Name = "ModalManager";
            Text = "ModalManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox managerNameBox;
        private Label nomeManagerLabel;
        private Button criaManagerButton;
    }
}