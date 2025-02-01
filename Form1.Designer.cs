namespace Machine
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
            Button1 = new Button();
            Button2 = new Button();
            Button3 = new Button();
            textBox1 = new TextBox();
            Button4 = new Button();
            Button5 = new Button();
            Button6 = new Button();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(204, 150);
            Button1.Name = "Button1";
            Button1.Size = new Size(171, 65);
            Button1.TabIndex = 0;
            Button1.Text = "ลาเต้";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(395, 150);
            Button2.Name = "Button2";
            Button2.Size = new Size(171, 65);
            Button2.TabIndex = 1;
            Button2.Text = "กาแฟดำ";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(395, 359);
            Button3.Name = "Button3";
            Button3.Size = new Size(157, 54);
            Button3.TabIndex = 2;
            Button3.Text = "แสดงสต็อก";
            Button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 27);
            textBox1.TabIndex = 3;
            // 
            // Button4
            // 
            Button4.Location = new Point(218, 359);
            Button4.Name = "Button4";
            Button4.Size = new Size(157, 54);
            Button4.TabIndex = 4;
            Button4.Text = "เติมสต็อก";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.Location = new Point(204, 235);
            Button5.Name = "Button5";
            Button5.Size = new Size(171, 65);
            Button5.TabIndex = 5;
            Button5.Text = "น้ำเปล่า";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.Location = new Point(395, 235);
            Button6.Name = "Button6";
            Button6.Size = new Size(171, 65);
            Button6.TabIndex = 6;
            Button6.Text = "นมเปล่า";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(textBox1);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button1;
        private Button Button2;
        private Button Button3;
        private TextBox textBox1;
        private Button Button4;
        private Button Button5;
        private Button Button6;
    }
}
