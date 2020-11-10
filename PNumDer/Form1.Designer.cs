namespace PNumDer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.UD_baseValue = new System.Windows.Forms.NumericUpDown();
            this.ValueNumber = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UD_accuracy = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.UD_needBaseValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UD_baseValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_accuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_needBaseValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackspace.Location = new System.Drawing.Point(362, 52);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(174, 47);
            this.btnBackspace.TabIndex = 18;
            this.btnBackspace.Tag = "edit";
            this.btnBackspace.Text = "BackSpace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeSign.Location = new System.Drawing.Point(362, 158);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(94, 47);
            this.btnChangeSign.TabIndex = 17;
            this.btnChangeSign.Tag = "edit";
            this.btnChangeSign.Text = "+/-";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPoint.Location = new System.Drawing.Point(362, 211);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 47);
            this.btnAddPoint.TabIndex = 16;
            this.btnAddPoint.Tag = "edit";
            this.btnAddPoint.Text = ".";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(362, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 47);
            this.btnClear.TabIndex = 19;
            this.btnClear.Tag = "edit";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnB.Location = new System.Drawing.Point(255, 317);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 47);
            this.btnB.TabIndex = 11;
            this.btnB.Tag = "number";
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(12, 370);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 47);
            this.btnC.TabIndex = 12;
            this.btnC.Tag = "number";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnD.Location = new System.Drawing.Point(93, 370);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 47);
            this.btnD.TabIndex = 13;
            this.btnD.Tag = "number";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnE.Location = new System.Drawing.Point(174, 370);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 47);
            this.btnE.TabIndex = 14;
            this.btnE.Tag = "number";
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF.Location = new System.Drawing.Point(255, 370);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 47);
            this.btnF.TabIndex = 15;
            this.btnF.Tag = "number";
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(93, 210);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 47);
            this.btn1.TabIndex = 1;
            this.btn1.Tag = "number";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(174, 210);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 47);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "number";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(255, 210);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 47);
            this.btn3.TabIndex = 3;
            this.btn3.Tag = "number";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(13, 264);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 47);
            this.btn4.TabIndex = 4;
            this.btn4.Tag = "number";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(94, 264);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 47);
            this.btn5.TabIndex = 5;
            this.btn5.Tag = "number";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(175, 264);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 47);
            this.btn6.TabIndex = 6;
            this.btn6.Tag = "number";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(256, 264);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 47);
            this.btn7.TabIndex = 7;
            this.btn7.Tag = "number";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(12, 317);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 47);
            this.btn8.TabIndex = 8;
            this.btn8.Tag = "number";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(93, 317);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 47);
            this.btn9.TabIndex = 9;
            this.btn9.Tag = "number";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnA.Location = new System.Drawing.Point(174, 317);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 47);
            this.btnA.TabIndex = 10;
            this.btnA.Tag = "number";
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(12, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 47);
            this.btn0.TabIndex = 0;
            this.btn0.Tag = "number";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // UD_baseValue
            // 
            this.UD_baseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UD_baseValue.Location = new System.Drawing.Point(589, 60);
            this.UD_baseValue.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.UD_baseValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UD_baseValue.Name = "UD_baseValue";
            this.UD_baseValue.Size = new System.Drawing.Size(120, 39);
            this.UD_baseValue.TabIndex = 26;
            this.UD_baseValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UD_baseValue.ValueChanged += new System.EventHandler(this.UD_baseValue_ValueChanged);
            // 
            // ValueNumber
            // 
            this.ValueNumber.Enabled = false;
            this.ValueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueNumber.Location = new System.Drawing.Point(12, 153);
            this.ValueNumber.Name = "ValueNumber";
            this.ValueNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValueNumber.Size = new System.Drawing.Size(318, 39);
            this.ValueNumber.TabIndex = 46;
            // 
            // tb_result
            // 
            this.tb_result.Enabled = false;
            this.tb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_result.Location = new System.Drawing.Point(12, 54);
            this.tb_result.Name = "tb_result";
            this.tb_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_result.Size = new System.Drawing.Size(318, 39);
            this.tb_result.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Исходное число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(585, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "с.с.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(584, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Точность представления";
            // 
            // UD_accuracy
            // 
            this.UD_accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UD_accuracy.Location = new System.Drawing.Point(588, 264);
            this.UD_accuracy.Name = "UD_accuracy";
            this.UD_accuracy.Size = new System.Drawing.Size(120, 39);
            this.UD_accuracy.TabIndex = 52;
            this.UD_accuracy.ValueChanged += new System.EventHandler(this.UD_accuracy_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(583, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Нужная с.с";
            // 
            // UD_needBaseValue
            // 
            this.UD_needBaseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UD_needBaseValue.Location = new System.Drawing.Point(588, 153);
            this.UD_needBaseValue.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.UD_needBaseValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UD_needBaseValue.Name = "UD_needBaseValue";
            this.UD_needBaseValue.Size = new System.Drawing.Size(120, 39);
            this.UD_needBaseValue.TabIndex = 54;
            this.UD_needBaseValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UD_needBaseValue.ValueChanged += new System.EventHandler(this.UD_needBaseValue_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 468);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UD_needBaseValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UD_accuracy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.UD_baseValue);
            this.Controls.Add(this.ValueNumber);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UD_baseValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_accuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_needBaseValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.NumericUpDown UD_baseValue;
        private System.Windows.Forms.TextBox ValueNumber;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown UD_accuracy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UD_needBaseValue;
    }
}

