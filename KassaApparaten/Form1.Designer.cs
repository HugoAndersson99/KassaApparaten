namespace KassaApparaten
{
    partial class Form1
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
            firstLabel = new Label();
            leaveButton = new Button();
            startButton = new Button();
            secondLabel = new Label();
            adminButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // firstLabel
            // 
            firstLabel.AutoSize = true;
            firstLabel.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
            firstLabel.Location = new Point(145, 9);
            firstLabel.Name = "firstLabel";
            firstLabel.Size = new Size(519, 48);
            firstLabel.TabIndex = 0;
            firstLabel.Text = "Välkommen till kassa apparaten";
            // 
            // leaveButton
            // 
            leaveButton.Location = new Point(210, 391);
            leaveButton.Name = "leaveButton";
            leaveButton.Size = new Size(375, 47);
            leaveButton.TabIndex = 1;
            leaveButton.Text = "Lämna";
            leaveButton.UseVisualStyleBackColor = true;
            leaveButton.Click += leaveButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(210, 153);
            startButton.Name = "startButton";
            startButton.Size = new Size(375, 92);
            startButton.TabIndex = 2;
            startButton.Text = "HANDLA";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // secondLabel
            // 
            secondLabel.AutoSize = true;
            secondLabel.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
            secondLabel.Location = new Point(303, 57);
            secondLabel.Name = "secondLabel";
            secondLabel.Size = new Size(186, 48);
            secondLabel.TabIndex = 3;
            secondLabel.Text = "Gör ett val";
            // 
            // adminButton
            // 
            adminButton.Location = new Point(210, 293);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(375, 92);
            adminButton.TabIndex = 4;
            adminButton.Text = "ADMIN";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(337, 113);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 5;
            label1.Text = "Är du kund?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(320, 265);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 6;
            label2.Text = "Är du butiks chef?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(adminButton);
            Controls.Add(secondLabel);
            Controls.Add(startButton);
            Controls.Add(leaveButton);
            Controls.Add(firstLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstLabel;
        private Button leaveButton;
        private Button startButton;
        private Label secondLabel;
        private Button adminButton;
        private Label label1;
        private Label label2;
    }
}