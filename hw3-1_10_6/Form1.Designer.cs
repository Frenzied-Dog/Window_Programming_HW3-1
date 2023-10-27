namespace hw3_1_10_6 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Title = new Label();
            NameLabel = new Label();
            Button = new Button();
            NameTextBox = new TextBox();
            NameLabel2 = new Label();
            GenderLabel2 = new Label();
            GenderTextBox = new TextBox();
            GenderLabel = new Label();
            BirthLabel = new Label();
            BirthTextBox = new TextBox();
            BirthLabel2 = new Label();
            DateLabel = new Label();
            DateTextBox = new TextBox();
            DateLabel2 = new Label();
            CdLabel = new Label();
            CdTextBox = new TextBox();
            CdLabel2 = new Label();
            AnaLabel = new Label();
            SugLabel = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Microsoft JhengHei UI", 19.5F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(437, 13);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(154, 34);
            Title.TabIndex = 0;
            Title.Text = "資料輸入";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(154, 101);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(154, 38);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "姓名";
            // 
            // Button
            // 
            Button.Location = new Point(321, 532);
            Button.Margin = new Padding(4, 4, 4, 4);
            Button.Name = "Button";
            Button.Size = new Size(386, 38);
            Button.TabIndex = 5;
            Button.Text = "AI大神請告訴我答案吧";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(321, 101);
            NameTextBox.Margin = new Padding(4, 4, 4, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(385, 27);
            NameTextBox.TabIndex = 0;
            // 
            // NameLabel2
            // 
            NameLabel2.Location = new Point(746, 101);
            NameLabel2.Margin = new Padding(4, 0, 4, 0);
            NameLabel2.Name = "NameLabel2";
            NameLabel2.Size = new Size(154, 38);
            NameLabel2.TabIndex = 12;
            // 
            // GenderLabel2
            // 
            GenderLabel2.BackColor = SystemColors.Control;
            GenderLabel2.Location = new Point(746, 177);
            GenderLabel2.Margin = new Padding(4, 0, 4, 0);
            GenderLabel2.Name = "GenderLabel2";
            GenderLabel2.Size = new Size(154, 38);
            GenderLabel2.TabIndex = 15;
            // 
            // GenderTextBox
            // 
            GenderTextBox.Location = new Point(321, 177);
            GenderTextBox.Margin = new Padding(4, 4, 4, 4);
            GenderTextBox.Name = "GenderTextBox";
            GenderTextBox.Size = new Size(385, 27);
            GenderTextBox.TabIndex = 1;
            // 
            // GenderLabel
            // 
            GenderLabel.Location = new Point(154, 177);
            GenderLabel.Margin = new Padding(4, 0, 4, 0);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(154, 38);
            GenderLabel.TabIndex = 13;
            GenderLabel.Text = "性別";
            // 
            // BirthLabel
            // 
            BirthLabel.Location = new Point(154, 253);
            BirthLabel.Margin = new Padding(4, 0, 4, 0);
            BirthLabel.Name = "BirthLabel";
            BirthLabel.Size = new Size(154, 38);
            BirthLabel.TabIndex = 13;
            BirthLabel.Text = "出生年月日";
            // 
            // BirthTextBox
            // 
            BirthTextBox.Location = new Point(321, 253);
            BirthTextBox.Margin = new Padding(4, 4, 4, 4);
            BirthTextBox.Name = "BirthTextBox";
            BirthTextBox.Size = new Size(385, 27);
            BirthTextBox.TabIndex = 2;
            // 
            // BirthLabel2
            // 
            BirthLabel2.BackColor = SystemColors.Control;
            BirthLabel2.Location = new Point(746, 253);
            BirthLabel2.Margin = new Padding(4, 0, 4, 0);
            BirthLabel2.Name = "BirthLabel2";
            BirthLabel2.Size = new Size(154, 38);
            BirthLabel2.TabIndex = 15;
            // 
            // DateLabel
            // 
            DateLabel.Location = new Point(154, 329);
            DateLabel.Margin = new Padding(4, 0, 4, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(154, 38);
            DateLabel.TabIndex = 13;
            DateLabel.Text = "今天日期";
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(321, 329);
            DateTextBox.Margin = new Padding(4, 4, 4, 4);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(385, 27);
            DateTextBox.TabIndex = 3;
            // 
            // DateLabel2
            // 
            DateLabel2.BackColor = SystemColors.Control;
            DateLabel2.Location = new Point(746, 329);
            DateLabel2.Margin = new Padding(4, 0, 4, 0);
            DateLabel2.Name = "DateLabel2";
            DateLabel2.Size = new Size(154, 38);
            DateLabel2.TabIndex = 15;
            // 
            // CdLabel
            // 
            CdLabel.Location = new Point(154, 405);
            CdLabel.Margin = new Padding(4, 0, 4, 0);
            CdLabel.Name = "CdLabel";
            CdLabel.Size = new Size(154, 38);
            CdLabel.TabIndex = 13;
            CdLabel.Text = "貓派or狗派";
            // 
            // CdTextBox
            // 
            CdTextBox.Location = new Point(321, 405);
            CdTextBox.Margin = new Padding(4, 4, 4, 4);
            CdTextBox.Name = "CdTextBox";
            CdTextBox.Size = new Size(385, 27);
            CdTextBox.TabIndex = 4;
            // 
            // CdLabel2
            // 
            CdLabel2.BackColor = SystemColors.Control;
            CdLabel2.Location = new Point(746, 405);
            CdLabel2.Margin = new Padding(4, 0, 4, 0);
            CdLabel2.Name = "CdLabel2";
            CdLabel2.Size = new Size(154, 38);
            CdLabel2.TabIndex = 15;
            // 
            // AnaLabel
            // 
            AnaLabel.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            AnaLabel.Location = new Point(129, 329);
            AnaLabel.Margin = new Padding(4, 0, 4, 0);
            AnaLabel.Name = "AnaLabel";
            AnaLabel.Size = new Size(900, 38);
            AnaLabel.TabIndex = 16;
            AnaLabel.Visible = false;
            // 
            // SugLabel
            // 
            SugLabel.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            SugLabel.Location = new Point(129, 405);
            SugLabel.Margin = new Padding(4, 0, 4, 0);
            SugLabel.Name = "SugLabel";
            SugLabel.Size = new Size(900, 38);
            SugLabel.TabIndex = 17;
            SugLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 584);
            Controls.Add(CdLabel2);
            Controls.Add(DateLabel2);
            Controls.Add(BirthLabel2);
            Controls.Add(CdTextBox);
            Controls.Add(GenderLabel2);
            Controls.Add(CdLabel);
            Controls.Add(DateTextBox);
            Controls.Add(DateLabel);
            Controls.Add(BirthTextBox);
            Controls.Add(BirthLabel);
            Controls.Add(GenderTextBox);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel2);
            Controls.Add(NameTextBox);
            Controls.Add(Button);
            Controls.Add(NameLabel);
            Controls.Add(Title);
            Controls.Add(SugLabel);
            Controls.Add(AnaLabel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "AI算命系統";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label NameLabel;
        private Label BirthLabel;
        private Label BirthLabel2;
        private Label label5;
        private Label label6;
        private Button Button;
        private TextBox NameTextBox;
        private TextBox BirthTextBox;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label NameLabel2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label GenderLabel2;
        private TextBox GenderTextBox;
        private Label GenderLabel;
        private Label DateLabel;
        private TextBox DateTextBox;
        private Label DateLabel2;
        private Label CdLabel;
        private TextBox CdTextBox;
        private Label CdLabel2;
        private Label AnaLabel;
        private Label SugLabel;
    }
}