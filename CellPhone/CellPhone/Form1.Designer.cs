namespace CellPhone {
    partial class Form1 {
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
            this.localNetworksList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localNetworksList
            // 
            this.localNetworksList.FormattingEnabled = true;
            this.localNetworksList.ItemHeight = 17;
            this.localNetworksList.Location = new System.Drawing.Point(3, 41);
            this.localNetworksList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.localNetworksList.Name = "localNetworksList";
            this.localNetworksList.Size = new System.Drawing.Size(114, 548);
            this.localNetworksList.TabIndex = 0;
            this.localNetworksList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Global Network";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local Network Phones";
            // 
            // phoneList
            // 
            this.phoneList.FormattingEnabled = true;
            this.phoneList.ItemHeight = 17;
            this.phoneList.Location = new System.Drawing.Point(125, 41);
            this.phoneList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneList.Name = "phoneList";
            this.phoneList.Size = new System.Drawing.Size(220, 548);
            this.phoneList.TabIndex = 2;
            this.phoneList.SelectedIndexChanged += new System.EventHandler(this.phoneList_SelectedIndexChanged);
            this.phoneList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.phoneList_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Create Phone";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(364, 163);
            this.phoneTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(258, 25);
            this.phoneTextbox.TabIndex = 5;
            this.phoneTextbox.Text = "Phone Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create Phone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localNetworksList);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox localNetworksList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox phoneList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Button button1;
    }
}

