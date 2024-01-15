namespace SectionALab
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
            lstDisplay = new ListBox();
            label1 = new Label();
            btnFillArray = new Button();
            btnSumArray = new Button();
            txtSubscript = new TextBox();
            txtHowManyDisplay = new TextBox();
            btnDisplayRange = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.ItemHeight = 15;
            lstDisplay.Location = new Point(196, 52);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(177, 379);
            lstDisplay.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(196, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 1;
            label1.Text = "Output";
            // 
            // btnFillArray
            // 
            btnFillArray.Location = new Point(14, 52);
            btnFillArray.Name = "btnFillArray";
            btnFillArray.Size = new Size(176, 23);
            btnFillArray.TabIndex = 2;
            btnFillArray.Text = "Fill Array";
            btnFillArray.UseVisualStyleBackColor = true;
            btnFillArray.Click += btnFillArray_Click;
            // 
            // btnSumArray
            // 
            btnSumArray.Location = new Point(16, 85);
            btnSumArray.Name = "btnSumArray";
            btnSumArray.Size = new Size(176, 23);
            btnSumArray.TabIndex = 3;
            btnSumArray.Text = "Sum Array";
            btnSumArray.UseVisualStyleBackColor = true;
            btnSumArray.Click += btnSumArray_Click;
            // 
            // txtSubscript
            // 
            txtSubscript.Location = new Point(41, 172);
            txtSubscript.Name = "txtSubscript";
            txtSubscript.Size = new Size(117, 23);
            txtSubscript.TabIndex = 4;
            txtSubscript.Text = "0";
            // 
            // txtHowManyDisplay
            // 
            txtHowManyDisplay.Location = new Point(41, 222);
            txtHowManyDisplay.Name = "txtHowManyDisplay";
            txtHowManyDisplay.Size = new Size(117, 23);
            txtHowManyDisplay.TabIndex = 5;
            txtHowManyDisplay.Text = "0";
            // 
            // btnDisplayRange
            // 
            btnDisplayRange.Location = new Point(14, 273);
            btnDisplayRange.Name = "btnDisplayRange";
            btnDisplayRange.Size = new Size(176, 23);
            btnDisplayRange.TabIndex = 6;
            btnDisplayRange.Text = "Display Range";
            btnDisplayRange.UseVisualStyleBackColor = true;
            btnDisplayRange.Click += btnDisplayRange_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 151);
            label2.Name = "label2";
            label2.Size = new Size(176, 18);
            label2.TabIndex = 7;
            label2.Text = "Enter Start Subscript";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Code Pro Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(14, 201);
            label3.Name = "label3";
            label3.Size = new Size(160, 18);
            label3.TabIndex = 8;
            label3.Text = "How many to display";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(388, 444);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDisplayRange);
            Controls.Add(txtHowManyDisplay);
            Controls.Add(txtSubscript);
            Controls.Add(btnSumArray);
            Controls.Add(btnFillArray);
            Controls.Add(label1);
            Controls.Add(lstDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDisplay;
        private Label label1;
        private Button btnFillArray;
        private Button btnSumArray;
        private TextBox txtSubscript;
        private TextBox txtHowManyDisplay;
        private Button btnDisplayRange;
        private Label label2;
        private Label label3;
    }
}