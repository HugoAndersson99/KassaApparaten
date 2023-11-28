namespace KassaApparaten
{
    partial class KassaApparaten
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
            ChooseLabel = new Label();
            varoBox = new ListBox();
            köpBox = new ListBox();
            checkBox1 = new CheckBox();
            ShowCartLabel = new Label();
            label1 = new Label();
            addToCartButton = new Button();
            payButton = new Button();
            kundvagnCostInfoLabel = new Label();
            kundvagnTotalLabel = new Label();
            LeaveShopButton = new Button();
            label2 = new Label();
            kundvagnAmountLabel = new Label();
            RemoveFromCartButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseLabel.Location = new Point(12, 9);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(269, 30);
            ChooseLabel.TabIndex = 0;
            ChooseLabel.Text = "Välj vilka varor du vill köpa";
            // 
            // varoBox
            // 
            varoBox.FormattingEnabled = true;
            varoBox.ItemHeight = 15;
            varoBox.Location = new Point(33, 92);
            varoBox.Name = "varoBox";
            varoBox.Size = new Size(193, 304);
            varoBox.TabIndex = 1;
            // 
            // köpBox
            // 
            köpBox.FormattingEnabled = true;
            köpBox.ItemHeight = 15;
            köpBox.Location = new Point(556, 92);
            köpBox.Name = "köpBox";
            köpBox.Size = new Size(207, 304);
            köpBox.TabIndex = 2;
            köpBox.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(480, 247);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 3;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ShowCartLabel
            // 
            ShowCartLabel.AutoSize = true;
            ShowCartLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ShowCartLabel.Location = new Point(302, 235);
            ShowCartLabel.Name = "ShowCartLabel";
            ShowCartLabel.Size = new Size(172, 28);
            ShowCartLabel.TabIndex = 4;
            ShowCartLabel.Text = "Visa din kundvagn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(396, 25);
            label1.TabIndex = 5;
            label1.Text = "Klicka på varan och sedan lägg till i kundvagn";
            // 
            // addToCartButton
            // 
            addToCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addToCartButton.Location = new Point(33, 402);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(193, 36);
            addToCartButton.TabIndex = 6;
            addToCartButton.Text = "Lägg till i kundvagn";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // payButton
            // 
            payButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            payButton.Location = new Point(302, 342);
            payButton.Name = "payButton";
            payButton.Size = new Size(172, 54);
            payButton.TabIndex = 7;
            payButton.Text = "Betala";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // kundvagnCostInfoLabel
            // 
            kundvagnCostInfoLabel.AutoSize = true;
            kundvagnCostInfoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kundvagnCostInfoLabel.Location = new Point(253, 104);
            kundvagnCostInfoLabel.Name = "kundvagnCostInfoLabel";
            kundvagnCostInfoLabel.Size = new Size(267, 28);
            kundvagnCostInfoLabel.TabIndex = 8;
            kundvagnCostInfoLabel.Text = "Du har just nu varor för totalt";
            // 
            // kundvagnTotalLabel
            // 
            kundvagnTotalLabel.AutoSize = true;
            kundvagnTotalLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kundvagnTotalLabel.Location = new Point(422, 146);
            kundvagnTotalLabel.Name = "kundvagnTotalLabel";
            kundvagnTotalLabel.Size = new Size(52, 28);
            kundvagnTotalLabel.TabIndex = 9;
            kundvagnTotalLabel.Text = "0 KR";
            // 
            // LeaveShopButton
            // 
            LeaveShopButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LeaveShopButton.Location = new Point(648, 12);
            LeaveShopButton.Name = "LeaveShopButton";
            LeaveShopButton.Size = new Size(140, 39);
            LeaveShopButton.TabIndex = 10;
            LeaveShopButton.Text = "Lämna butiken";
            LeaveShopButton.UseVisualStyleBackColor = true;
            LeaveShopButton.Click += LeaveShopButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(321, 308);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 11;
            label2.Text = "Har du köpt klart?";
            // 
            // kundvagnAmountLabel
            // 
            kundvagnAmountLabel.AutoSize = true;
            kundvagnAmountLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kundvagnAmountLabel.Location = new Point(280, 150);
            kundvagnAmountLabel.Name = "kundvagnAmountLabel";
            kundvagnAmountLabel.Size = new Size(49, 28);
            kundvagnAmountLabel.TabIndex = 12;
            kundvagnAmountLabel.Text = "0 ST";
            // 
            // RemoveFromCartButton
            // 
            RemoveFromCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveFromCartButton.Location = new Point(546, 402);
            RemoveFromCartButton.Name = "RemoveFromCartButton";
            RemoveFromCartButton.Size = new Size(207, 36);
            RemoveFromCartButton.TabIndex = 13;
            RemoveFromCartButton.Text = "Ta bort från kundvagnen";
            RemoveFromCartButton.UseVisualStyleBackColor = true;
            RemoveFromCartButton.Visible = false;
            RemoveFromCartButton.Click += RemoveFromCartButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 220);
            label3.Name = "label3";
            label3.Size = new Size(215, 15);
            label3.TabIndex = 14;
            label3.Text = "Vill du se eller ta bort från kundvagnen?";
            // 
            // KassaApparaten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(RemoveFromCartButton);
            Controls.Add(kundvagnAmountLabel);
            Controls.Add(label2);
            Controls.Add(LeaveShopButton);
            Controls.Add(kundvagnTotalLabel);
            Controls.Add(kundvagnCostInfoLabel);
            Controls.Add(payButton);
            Controls.Add(addToCartButton);
            Controls.Add(label1);
            Controls.Add(ShowCartLabel);
            Controls.Add(checkBox1);
            Controls.Add(köpBox);
            Controls.Add(varoBox);
            Controls.Add(ChooseLabel);
            Name = "KassaApparaten";
            Text = "KassaApparaten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseLabel;
        private ListBox varoBox;
        private ListBox köpBox;
        private CheckBox checkBox1;
        private Label ShowCartLabel;
        private Label label1;
        private Button addToCartButton;
        private Button payButton;
        private Label kundvagnCostInfoLabel;
        private Label kundvagnTotalLabel;
        private Button LeaveShopButton;
        private Label label2;
        private Label kundvagnAmountLabel;
        private Button RemoveFromCartButton;
        private Label label3;
    }
}