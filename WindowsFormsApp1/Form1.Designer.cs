namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ToLowerButton = new System.Windows.Forms.Button();
            this.ToUpperButtion = new System.Windows.Forms.Button();
            this.SymBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.split = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(710, 138);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 294);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(710, 138);
            this.textBox2.TabIndex = 0;
            // 
            // ToLowerButton
            // 
            this.ToLowerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToLowerButton.Location = new System.Drawing.Point(188, 243);
            this.ToLowerButton.Name = "ToLowerButton";
            this.ToLowerButton.Size = new System.Drawing.Size(75, 23);
            this.ToLowerButton.TabIndex = 1;
            this.ToLowerButton.Text = "To lower";
            this.ToLowerButton.UseVisualStyleBackColor = true;
            this.ToLowerButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ToUpperButtion
            // 
            this.ToUpperButtion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToUpperButtion.Location = new System.Drawing.Point(553, 243);
            this.ToUpperButtion.Name = "ToUpperButtion";
            this.ToUpperButtion.Size = new System.Drawing.Size(75, 23);
            this.ToUpperButtion.TabIndex = 2;
            this.ToUpperButtion.Text = "To upper";
            this.ToUpperButtion.UseVisualStyleBackColor = true;
            this.ToUpperButtion.Click += new System.EventHandler(this.button2_Click);
            // 
            // SymBox
            // 
            this.SymBox.Location = new System.Drawing.Point(405, 227);
            this.SymBox.Name = "SymBox";
            this.SymBox.Size = new System.Drawing.Size(61, 20);
            this.SymBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(358, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Symbol";
            // 
            // split
            // 
            this.split.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.split.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.split.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.split.Location = new System.Drawing.Point(373, 253);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(75, 35);
            this.split.TabIndex = 5;
            this.split.Text = "Remove line split";
            this.split.UseVisualStyleBackColor = false;
            this.split.Click += new System.EventHandler(this.split_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.split);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SymBox);
            this.Controls.Add(this.ToUpperButtion);
            this.Controls.Add(this.ToLowerButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TextLoup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ToLowerButton;
        private System.Windows.Forms.Button ToUpperButtion;
        private System.Windows.Forms.TextBox SymBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button split;
    }
}

