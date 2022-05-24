namespace WeBuyCars
{
    partial class CarDetails
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
            this.pictureBox_SelectedCar = new System.Windows.Forms.PictureBox();
            this.label_CarName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_NormalPrice = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_Installment = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.textBox_Deposit = new System.Windows.Forms.TextBox();
            this.textBox_InterestRate = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SelectedCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_SelectedCar
            // 
            this.pictureBox_SelectedCar.Location = new System.Drawing.Point(3, 1);
            this.pictureBox_SelectedCar.Name = "pictureBox_SelectedCar";
            this.pictureBox_SelectedCar.Size = new System.Drawing.Size(532, 455);
            this.pictureBox_SelectedCar.TabIndex = 0;
            this.pictureBox_SelectedCar.TabStop = false;
            // 
            // label_CarName
            // 
            this.label_CarName.AutoSize = true;
            this.label_CarName.Location = new System.Drawing.Point(749, 18);
            this.label_CarName.Name = "label_CarName";
            this.label_CarName.Size = new System.Drawing.Size(75, 23);
            this.label_CarName.TabIndex = 1;
            this.label_CarName.Text = ".............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Normal Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deposit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interest Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(707, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Period:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "The Total Price For The Call Will Be: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Your Monthly Installments Will Be: ";
            // 
            // label_NormalPrice
            // 
            this.label_NormalPrice.AutoSize = true;
            this.label_NormalPrice.Location = new System.Drawing.Point(716, 174);
            this.label_NormalPrice.Name = "label_NormalPrice";
            this.label_NormalPrice.Size = new System.Drawing.Size(75, 23);
            this.label_NormalPrice.TabIndex = 8;
            this.label_NormalPrice.Text = ".............";
            this.label_NormalPrice.Click += new System.EventHandler(this.label_NormalPrice_Click);
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(353, 522);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(75, 23);
            this.label_TotalPrice.TabIndex = 11;
            this.label_TotalPrice.Text = ".............";
            // 
            // label_Installment
            // 
            this.label_Installment.AutoSize = true;
            this.label_Installment.Location = new System.Drawing.Point(351, 595);
            this.label_Installment.Name = "label_Installment";
            this.label_Installment.Size = new System.Drawing.Size(75, 23);
            this.label_Installment.TabIndex = 12;
            this.label_Installment.Text = ".............";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(559, 620);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(482, 39);
            this.button_Calculate.TabIndex = 17;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // textBox_Deposit
            // 
            this.textBox_Deposit.Location = new System.Drawing.Point(716, 232);
            this.textBox_Deposit.Name = "textBox_Deposit";
            this.textBox_Deposit.Size = new System.Drawing.Size(125, 30);
            this.textBox_Deposit.TabIndex = 18;
            // 
            // textBox_InterestRate
            // 
            this.textBox_InterestRate.Location = new System.Drawing.Point(716, 295);
            this.textBox_InterestRate.Name = "textBox_InterestRate";
            this.textBox_InterestRate.Size = new System.Drawing.Size(125, 30);
            this.textBox_InterestRate.TabIndex = 19;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(559, 562);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 27);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "36 Months";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(681, 562);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 27);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "48 Months";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(803, 562);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(116, 27);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "60 Months";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(925, 562);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 27);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "70 Months";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 712);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox_InterestRate);
            this.Controls.Add(this.textBox_Deposit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.label_Installment);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label_NormalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_CarName);
            this.Controls.Add(this.pictureBox_SelectedCar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "CarDetails";
            this.Text = "Car Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SelectedCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_SelectedCar;
        private Label label_CarName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label_NormalPrice;
        private Label label_TotalPrice;
        private Label label_Installment;
        private Button button_Calculate;
        private TextBox textBox_Deposit;
        private TextBox textBox_InterestRate;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}