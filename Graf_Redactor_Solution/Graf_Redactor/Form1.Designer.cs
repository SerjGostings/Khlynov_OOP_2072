
namespace Graf_Redactor
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
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.TrainCountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrainCCountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrainSCountBox = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.figCountBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // GraphPanel
            // 
            this.GraphPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GraphPanel.Location = new System.Drawing.Point(12, 23);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(1159, 682);
            this.GraphPanel.TabIndex = 0;
            this.GraphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPanel_Paint);
            this.GraphPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphPanel_MouseDown);
            this.GraphPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphPanel_MouseMove);
            this.GraphPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphPanel_MouseUp);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(1181, 160);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Wagon";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1181, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "CoalWagon";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1181, 220);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "SandWagon";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1182, 252);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 24);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Train";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // TrainCountBox
            // 
            this.TrainCountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrainCountBox.Location = new System.Drawing.Point(1198, 302);
            this.TrainCountBox.Name = "TrainCountBox";
            this.TrainCountBox.Size = new System.Drawing.Size(100, 26);
            this.TrainCountBox.TabIndex = 5;
            this.TrainCountBox.Text = "0";
            this.TrainCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1181, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во вагонов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1181, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кол-во вагонов \r\nс углём";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainCCountBox
            // 
            this.TrainCCountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrainCCountBox.Location = new System.Drawing.Point(1198, 374);
            this.TrainCCountBox.Name = "TrainCCountBox";
            this.TrainCCountBox.Size = new System.Drawing.Size(100, 26);
            this.TrainCCountBox.TabIndex = 7;
            this.TrainCCountBox.Text = "0";
            this.TrainCCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1181, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кол-во вагонов \r\nс песком";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainSCountBox
            // 
            this.TrainSCountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrainSCountBox.Location = new System.Drawing.Point(1198, 446);
            this.TrainSCountBox.Name = "TrainSCountBox";
            this.TrainSCountBox.Size = new System.Drawing.Size(100, 26);
            this.TrainSCountBox.TabIndex = 9;
            this.TrainSCountBox.Text = "0";
            this.TrainSCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1182, 70);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(107, 24);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.Text = "Rectangle";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(1182, 100);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(73, 24);
            this.radioButton6.TabIndex = 12;
            this.radioButton6.Text = "Circle";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(1182, 130);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(90, 24);
            this.radioButton7.TabIndex = 13;
            this.radioButton7.Text = "Triangle";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(1185, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Get all weight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightBox
            // 
            this.weightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightBox.BackColor = System.Drawing.SystemColors.Menu;
            this.weightBox.Location = new System.Drawing.Point(1198, 529);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 26);
            this.weightBox.TabIndex = 15;
            // 
            // figCountBox
            // 
            this.figCountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.figCountBox.BackColor = System.Drawing.SystemColors.Menu;
            this.figCountBox.Location = new System.Drawing.Point(1198, 616);
            this.figCountBox.Name = "figCountBox";
            this.figCountBox.Size = new System.Drawing.Size(100, 26);
            this.figCountBox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(1185, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Count all fig";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(1185, 660);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 45);
            this.button3.TabIndex = 18;
            this.button3.Text = "Clean";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(1185, 23);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(72, 24);
            this.radioButton8.TabIndex = 19;
            this.radioButton8.Text = "Move";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 726);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.figCountBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrainSCountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrainCCountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainCountBox);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.GraphPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox TrainCountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TrainCCountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TrainSCountBox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox figCountBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton8;
    }
}

