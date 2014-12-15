namespace CellPhone.UI.Inheritable {
    partial class PhoneInstance {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.Rejectbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(11, 12);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(75, 23);
            this.AnswerBtn.TabIndex = 0;
            this.AnswerBtn.Text = "Answer";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            // 
            // Rejectbtn
            // 
            this.Rejectbtn.Location = new System.Drawing.Point(92, 12);
            this.Rejectbtn.Name = "Rejectbtn";
            this.Rejectbtn.Size = new System.Drawing.Size(75, 23);
            this.Rejectbtn.TabIndex = 1;
            this.Rejectbtn.Text = "Reject";
            this.Rejectbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rejectbtn);
            this.panel1.Controls.Add(this.AnswerBtn);
            this.panel1.Location = new System.Drawing.Point(12, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 48);
            this.panel1.TabIndex = 2;
            // 
            // PhoneInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 388);
            this.Controls.Add(this.panel1);
            this.Name = "PhoneInstance";
            this.Text = "PhoneInstance";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Button Rejectbtn;
        private System.Windows.Forms.Panel panel1;
    }
}