namespace KassaApparaten
{
    partial class AdminForm
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
            addVaraButton = new Button();
            namnBox = new ListBox();
            varaNameTextBox = new TextBox();
            varaPriceTextBox = new TextBox();
            nameVaraLabel = new Label();
            label1 = new Label();
            removeVaraButton = new Button();
            label2 = new Label();
            saveButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            priceBox = new ListBox();
            amountBox = new ListBox();
            moneyBox = new ListBox();
            label9 = new Label();
            label10 = new Label();
            amountLabel = new Label();
            moneyLabel = new Label();
            label11 = new Label();
            label12 = new Label();
            panel = new Panel();
            loginButton = new Button();
            label13 = new Label();
            loginBox = new TextBox();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // addVaraButton
            // 
            addVaraButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addVaraButton.Location = new Point(20, 408);
            addVaraButton.Name = "addVaraButton";
            addVaraButton.Size = new Size(161, 41);
            addVaraButton.TabIndex = 0;
            addVaraButton.Text = "Lägg till ny vara";
            addVaraButton.UseVisualStyleBackColor = true;
            addVaraButton.Click += addVaraButton_Click;
            // 
            // namnBox
            // 
            namnBox.FormattingEnabled = true;
            namnBox.ItemHeight = 15;
            namnBox.Location = new Point(187, 75);
            namnBox.Name = "namnBox";
            namnBox.Size = new Size(138, 289);
            namnBox.TabIndex = 1;
            namnBox.SelectedIndexChanged += namnBox_SelectedIndexChanged;
            // 
            // varaNameTextBox
            // 
            varaNameTextBox.Location = new Point(20, 164);
            varaNameTextBox.Name = "varaNameTextBox";
            varaNameTextBox.Size = new Size(154, 23);
            varaNameTextBox.TabIndex = 2;
            // 
            // varaPriceTextBox
            // 
            varaPriceTextBox.Location = new Point(20, 239);
            varaPriceTextBox.Name = "varaPriceTextBox";
            varaPriceTextBox.Size = new Size(154, 23);
            varaPriceTextBox.TabIndex = 3;
            // 
            // nameVaraLabel
            // 
            nameVaraLabel.AutoSize = true;
            nameVaraLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameVaraLabel.Location = new Point(47, 140);
            nameVaraLabel.Name = "nameVaraLabel";
            nameVaraLabel.Size = new Size(108, 21);
            nameVaraLabel.TabIndex = 4;
            nameVaraLabel.Text = "Namn på vara";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 200);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 5;
            label1.Text = "Pris på vara";
            // 
            // removeVaraButton
            // 
            removeVaraButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeVaraButton.Location = new Point(187, 408);
            removeVaraButton.Name = "removeVaraButton";
            removeVaraButton.Size = new Size(161, 41);
            removeVaraButton.TabIndex = 6;
            removeVaraButton.Text = "Ta bort  vald vara";
            removeVaraButton.UseVisualStyleBackColor = true;
            removeVaraButton.Click += removeVaraButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 221);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 7;
            label2.Text = "( Skriv in nummer på pris )";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(634, 408);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(154, 41);
            saveButton.TabIndex = 8;
            saveButton.Text = "Spara och stäng";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(210, 44);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 12;
            label3.Text = "Namn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(354, 44);
            label4.Name = "label4";
            label4.Size = new Size(43, 28);
            label4.TabIndex = 13;
            label4.Text = "Pris";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(438, 44);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 14;
            label5.Text = "Antal sålda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(210, 9);
            label6.Name = "label6";
            label6.Size = new Size(341, 28);
            label6.TabIndex = 15;
            label6.Text = "Här kan du lägga till och ta bort varor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(592, 44);
            label7.Name = "label7";
            label7.Size = new Size(151, 28);
            label7.TabIndex = 17;
            label7.Text = "Inkomst på vara";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(634, 25);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 18;
            label8.Text = "Total";
            // 
            // priceBox
            // 
            priceBox.FormattingEnabled = true;
            priceBox.ItemHeight = 15;
            priceBox.Location = new Point(320, 75);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(113, 289);
            priceBox.TabIndex = 20;
            // 
            // amountBox
            // 
            amountBox.FormattingEnabled = true;
            amountBox.ItemHeight = 15;
            amountBox.Location = new Point(426, 75);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(132, 289);
            amountBox.TabIndex = 21;
            // 
            // moneyBox
            // 
            moneyBox.FormattingEnabled = true;
            moneyBox.ItemHeight = 15;
            moneyBox.Location = new Point(552, 75);
            moneyBox.Name = "moneyBox";
            moneyBox.Size = new Size(191, 289);
            moneyBox.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 74);
            label9.Name = "label9";
            label9.Size = new Size(171, 21);
            label9.TabIndex = 23;
            label9.Text = "Skriv in den nya varans";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(21, 95);
            label10.Name = "label10";
            label10.Size = new Size(145, 21);
            label10.TabIndex = 24;
            label10.Text = "namn samt pris här";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountLabel.Location = new Point(449, 372);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(79, 21);
            amountLabel.TabIndex = 25;
            amountLabel.Text = "Totalt: 0 st";
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moneyLabel.Location = new Point(607, 372);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(81, 21);
            moneyLabel.TabIndex = 26;
            moneyLabel.Text = "Totalt: 0 kr";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(189, 367);
            label11.Name = "label11";
            label11.Size = new Size(159, 15);
            label11.TabIndex = 27;
            label11.Text = "För att välja varor och ta bort";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(187, 382);
            label12.Name = "label12";
            label12.Size = new Size(168, 15);
            label12.TabIndex = 28;
            label12.Text = "Var vänlig att klicka på namnet";
            // 
            // panel
            // 
            panel.Controls.Add(loginButton);
            panel.Controls.Add(label13);
            panel.Controls.Add(loginBox);
            panel.Location = new Point(1, 9);
            panel.Name = "panel";
            panel.Size = new Size(800, 440);
            panel.TabIndex = 29;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(344, 196);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 31);
            loginButton.TabIndex = 2;
            loginButton.Text = "Logga in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(300, 86);
            label13.Name = "label13";
            label13.Size = new Size(175, 28);
            label13.TabIndex = 1;
            label13.Text = "Skriv in admin kod";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(332, 155);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(100, 23);
            loginBox.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(moneyLabel);
            Controls.Add(amountLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(moneyBox);
            Controls.Add(amountBox);
            Controls.Add(priceBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(saveButton);
            Controls.Add(label2);
            Controls.Add(removeVaraButton);
            Controls.Add(label1);
            Controls.Add(nameVaraLabel);
            Controls.Add(varaPriceTextBox);
            Controls.Add(varaNameTextBox);
            Controls.Add(namnBox);
            Controls.Add(addVaraButton);
            Name = "AdminForm";
            Text = "AdminForm";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addVaraButton;
        private ListBox namnBox;
        private TextBox varaNameTextBox;
        private TextBox varaPriceTextBox;
        private Label nameVaraLabel;
        private Label label1;
        private Button removeVaraButton;
        private Label label2;
        private Button saveButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox priceBox;
        private ListBox amountBox;
        private ListBox moneyBox;
        private Label label9;
        private Label label10;
        private Label amountLabel;
        private Label moneyLabel;
        private Label label11;
        private Label label12;
        private Panel panel;
        private Button loginButton;
        private Label label13;
        private TextBox loginBox;
    }
}