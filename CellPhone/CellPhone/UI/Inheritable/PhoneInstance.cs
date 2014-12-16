using System;
using System.Drawing;
using System.Windows.Forms;
using CellPhone.CellPhonePattern.BluePrints;

namespace CellPhone.UI.Inheritable {
    public partial class PhoneInstance : Form {
        private int _ringCounter;

        public PhoneInstance(Phone currentPhone) {
            Phone = currentPhone;
            InitializeComponent();
            TimesShouldRing = 10;

        }

        public PhoneInstance(Phone currentPhone, int defRing) {
            Phone = currentPhone;
            InitializeComponent();
            TimesShouldRing = defRing;
        }

        public Phone Phone { get; set; }
        public Phone InCommingPhone { get; set; }
        public int TimesShouldRing { get; set; }
        public bool ShouldWaitForResponse { get; set; }
        public bool InResponseOfCall { get; set; }

        public void StartRinging(Phone incommingFrom) {
            _ringCounter = 0;
            TimerToRing.Enabled = true;
            TimerToRing.Start();
            IncommingPhoneNumberLabel.Text = "Incoming call from : " + incommingFrom.PhoneNumber.ToString();
            IncommingPhoneNumberLabel.Visible = true;
            IncommingCallPanel.Visible = true;
            this.InCommingPhone = incommingFrom;
            ShouldWaitForResponse = true;
        }

        public void Answer() {
            InResponseOfCall = true;
            StopIncommingProcessing();
        }

        public void Reject() {
            StopIncommingProcessing();
            InResponseOfCall = false;

        }

        private void StopIncommingProcessing() {
            this.IncommingCallPanel.Visible = false;
            ShouldWaitForResponse = false;
            TimerToRing.Enabled = false;
            IncommingCallPanel.Visible = false;
            TimerToRing.Stop();
            Phone.IsOnDialing = false;
            if (InCommingPhone != null) {
                InCommingPhone.IsOnDialing = false;
            }
            this.IncommingPhoneNumberLabel.Visible = false;
            fixTitleLabel();
        }

        private void LabelColorRed(Label label) {
            label.BackColor = Color.Red;
            label.ForeColor = Color.White;
        }
        private void TextColorRed(TextBox t) {
            t.BackColor = Color.Red;
            t.ForeColor = Color.White;
        }

        private void TextColorNormal(TextBox t) {
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void LabelColorBlue(Label label) {
            label.BackColor = Color.DodgerBlue;
            label.ForeColor = Color.Black;
        }

        public void StartRinging_Tick(object sender, EventArgs e) {
            if (_ringCounter >= TimesShouldRing) {
                ShouldWaitForResponse = false;
                TimerToRing.Enabled = false;
                TimerToRing.Stop();
                StopIncommingProcessing();
                //stop ringing
            }
            //MessageBox.Show("ase");
            if (Phone.IsFlashingOnWhenRinging) {
                if (_ringCounter % 2 == 0) {
                    LabelColorRed(IncommingPhoneNumberLabel);
                } else {
                    LabelColorBlue(IncommingPhoneNumberLabel);
                }
            }

            _ringCounter++;
        }

        void errorMsgShow(Exception ex) {
            MessageBox.Show(ex.Message, "Error can't procede more.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void DialNumber() {
            long phoneNumber;
            if (long.TryParse(this.DialingPad.Text, out phoneNumber)) {
                try {
                    Phone.MakeCall(phoneNumber);
                } catch (Exception ex) {
                    errorMsgShow(ex);
                }
            } else {
                MessageBox.Show("Phone is not a valid number");
            }
        }
        public void DialBtn_Click(object sender, EventArgs e) {
            DialNumber();
        }

        private void DialingPad_TextChanged(object sender, EventArgs e) {

        }

        private void DialingPad_Validated(object sender, EventArgs e) {
            long l;
            if (!long.TryParse(this.DialingPad.Text, out l)) {
                TextColorRed(this.DialingPad);
            } else {
                TextColorNormal(this.DialingPad);

            }
        }

        private void IsFlashWhenCall_CheckedChanged(object sender, EventArgs e) {
            this.Phone.IsFlashingOnWhenRinging = this.IsFlashWhenCall.Checked;
        }

        private void PhoneInstance_Load(object sender, EventArgs e) {
            StopIncommingProcessing();
            this.PhoneNumberLabel.Text = Phone.PhoneNumber.ToString();

            fixTitleLabel();
        }

        private void fixTitleLabel() {
            this.Text = "Phone number :" + this.PhoneNumberLabel.Text;
        }

        private void PhoneInstance_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void AnswerBtn_Click(object sender, EventArgs e) {
            Answer();
        }

        private void Rejectbtn_Click(object sender, EventArgs e) {
            Reject();
        }
    }
}