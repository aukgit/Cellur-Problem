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
            this.components = new System.ComponentModel.Container();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.Rejectbtn = new System.Windows.Forms.Button();
            this.IncommingCallPanel = new System.Windows.Forms.Panel();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DialBtn = new System.Windows.Forms.Button();
            this.IncommingPhoneNumberLabel = new System.Windows.Forms.Label();
            this.DialingPad = new System.Windows.Forms.TextBox();
            this.TimerToRing = new System.Windows.Forms.Timer(this.components);
            this.IsFlashWhenCall = new System.Windows.Forms.CheckBox();
            this.IncommingCallPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.AnswerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerBtn.Location = new System.Drawing.Point(6, 7);
            this.AnswerBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(103, 40);
            this.AnswerBtn.TabIndex = 0;
            this.AnswerBtn.Text = "Answer";
            this.AnswerBtn.UseVisualStyleBackColor = false;
            // 
            // Rejectbtn
            // 
            this.Rejectbtn.BackColor = System.Drawing.Color.Crimson;
            this.Rejectbtn.ForeColor = System.Drawing.Color.White;
            this.Rejectbtn.Location = new System.Drawing.Point(121, 7);
            this.Rejectbtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Rejectbtn.Name = "Rejectbtn";
            this.Rejectbtn.Size = new System.Drawing.Size(103, 40);
            this.Rejectbtn.TabIndex = 1;
            this.Rejectbtn.Text = "Reject";
            this.Rejectbtn.UseVisualStyleBackColor = false;
            // 
            // IncommingCallPanel
            // 
            this.IncommingCallPanel.Controls.Add(this.Rejectbtn);
            this.IncommingCallPanel.Controls.Add(this.AnswerBtn);
            this.IncommingCallPanel.Location = new System.Drawing.Point(203, 117);
            this.IncommingCallPanel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.IncommingCallPanel.Name = "IncommingCallPanel";
            this.IncommingCallPanel.Size = new System.Drawing.Size(235, 53);
            this.IncommingCallPanel.TabIndex = 2;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.PhoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(446, 38);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "00";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DialBtn
            // 
            this.DialBtn.Location = new System.Drawing.Point(5, 117);
            this.DialBtn.Name = "DialBtn";
            this.DialBtn.Size = new System.Drawing.Size(97, 44);
            this.DialBtn.TabIndex = 5;
            this.DialBtn.Text = "Dial";
            this.DialBtn.UseVisualStyleBackColor = true;
            this.DialBtn.Click += new System.EventHandler(this.DialBtn_Click);
            // 
            // IncommingPhoneNumberLabel
            // 
            this.IncommingPhoneNumberLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IncommingPhoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IncommingPhoneNumberLabel.Location = new System.Drawing.Point(0, 38);
            this.IncommingPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IncommingPhoneNumberLabel.Name = "IncommingPhoneNumberLabel";
            this.IncommingPhoneNumberLabel.Size = new System.Drawing.Size(446, 38);
            this.IncommingPhoneNumberLabel.TabIndex = 6;
            this.IncommingPhoneNumberLabel.Text = "00";
            this.IncommingPhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IncommingPhoneNumberLabel.Visible = false;
            // 
            // DialingPad
            // 
            this.DialingPad.Dock = System.Windows.Forms.DockStyle.Top;
            this.DialingPad.Location = new System.Drawing.Point(0, 76);
            this.DialingPad.Name = "DialingPad";
            this.DialingPad.Size = new System.Drawing.Size(446, 35);
            this.DialingPad.TabIndex = 7;
            this.DialingPad.TextChanged += new System.EventHandler(this.DialingPad_TextChanged);
            this.DialingPad.Validated += new System.EventHandler(this.DialingPad_Validated);
            // 
            // TimerToRing
            // 
            this.TimerToRing.Interval = 2000;
            this.TimerToRing.Tick += new System.EventHandler(this.StartRinging_Tick);
            // 
            // IsFlashWhenCall
            // 
            this.IsFlashWhenCall.AutoSize = true;
            this.IsFlashWhenCall.Location = new System.Drawing.Point(5, 167);
            this.IsFlashWhenCall.Name = "IsFlashWhenCall";
            this.IsFlashWhenCall.Size = new System.Drawing.Size(190, 34);
            this.IsFlashWhenCall.TabIndex = 8;
            this.IsFlashWhenCall.Text = "Is flash when call";
            this.IsFlashWhenCall.UseVisualStyleBackColor = true;
            this.IsFlashWhenCall.CheckedChanged += new System.EventHandler(this.IsFlashWhenCall_CheckedChanged);
            // 
            // PhoneInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 208);
            this.Controls.Add(this.IsFlashWhenCall);
            this.Controls.Add(this.DialingPad);
            this.Controls.Add(this.IncommingPhoneNumberLabel);
            this.Controls.Add(this.DialBtn);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.IncommingCallPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PhoneInstance";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneInstance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhoneInstance_FormClosing);
            this.Load += new System.EventHandler(this.PhoneInstance_Load);
            this.IncommingCallPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Button Rejectbtn;
        private System.Windows.Forms.Panel IncommingCallPanel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Button DialBtn;
        private System.Windows.Forms.Label IncommingPhoneNumberLabel;
        private System.Windows.Forms.TextBox DialingPad;
        public System.Windows.Forms.Timer TimerToRing;
        private System.Windows.Forms.CheckBox IsFlashWhenCall;
    }
}