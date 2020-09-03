namespace test_forms_aoo
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.start_option1 = new System.Windows.Forms.Button();
            this.start_option2 = new System.Windows.Forms.Button();
            this.start_option3 = new System.Windows.Forms.Button();
            this.start_option4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // start_option1
            // 
            this.start_option1.Location = new System.Drawing.Point(83, 135);
            this.start_option1.Name = "start_option1";
            this.start_option1.Size = new System.Drawing.Size(130, 69);
            this.start_option1.TabIndex = 2;
            this.start_option1.Text = "To the best beach I can find";
            this.start_option1.UseVisualStyleBackColor = true;
            this.start_option1.Click += new System.EventHandler(this.start_option1_Click);
            // 
            // start_option2
            // 
            this.start_option2.Location = new System.Drawing.Point(311, 135);
            this.start_option2.Name = "start_option2";
            this.start_option2.Size = new System.Drawing.Size(125, 69);
            this.start_option2.TabIndex = 3;
            this.start_option2.Text = "To the best mountain resort I can find";
            this.start_option2.UseVisualStyleBackColor = true;
            this.start_option2.Click += new System.EventHandler(this.start_option2_Click);
            // 
            // start_option3
            // 
            this.start_option3.Location = new System.Drawing.Point(83, 249);
            this.start_option3.Name = "start_option3";
            this.start_option3.Size = new System.Drawing.Size(130, 69);
            this.start_option3.TabIndex = 4;
            this.start_option3.Text = "To the best ski lodge I can find";
            this.start_option3.UseVisualStyleBackColor = true;
            this.start_option3.Click += new System.EventHandler(this.start_option3_Click);
            // 
            // start_option4
            // 
            this.start_option4.Location = new System.Drawing.Point(311, 249);
            this.start_option4.Name = "start_option4";
            this.start_option4.Size = new System.Drawing.Size(125, 69);
            this.start_option4.TabIndex = 5;
            this.start_option4.Text = "Nowhere, I stay at home";
            this.start_option4.UseVisualStyleBackColor = true;
            this.start_option4.Click += new System.EventHandler(this.start_option4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 95);
            this.label1.TabIndex = 6;
            this.label1.Text = "You\'ve won a free all-expense paid trip to any place of your choosing, where do y" +
    "ou go?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(514, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_option4);
            this.Controls.Add(this.start_option3);
            this.Controls.Add(this.start_option2);
            this.Controls.Add(this.start_option1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question 1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button start_option1;
        private System.Windows.Forms.Button start_option2;
        private System.Windows.Forms.Button start_option3;
        private System.Windows.Forms.Button start_option4;
        private System.Windows.Forms.Label label1;
    }
}