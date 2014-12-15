using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellPhone.CellPhonePattern.BluePrints;
using CellPhone.Implementation;
using CellPhone.UI.Inheritable;

namespace CellPhone {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
         
        }


        public void UpdateList() {
            this.localNetworksList.DataSource = Global.Network.Networks;
            this.localNetworksList.DisplayMember = "NetworkId";

            this.phoneList.DataSource = Global.Network.Networks[this.localNetworksList.SelectedIndex].Phones;
            this.phoneList.DisplayMember = "PhoneNumber";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
          
        }
        void errorMsgShow(Exception ex) {
            MessageBox.Show(ex.Message, "Error can't procede more.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void CreatePhoneAndNetwork() {
            long phoneNumber;
            if (long.TryParse(this.phoneTextbox.Text, out phoneNumber)) {
                try {
                    var phone = new Phone(phoneNumber, null);
                    phone.TryToGetOnline();
                } catch (Exception ex) {
                    errorMsgShow(ex);
                }
   
                UpdateList();
            } else {
                MessageBox.Show("Phone is not a valid number");
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            CreatePhoneAndNetwork();
        }

        private void phoneList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void phoneList_MouseDoubleClick(object sender, MouseEventArgs e) {
            var phonesCollection = (List<Phone>)this.phoneList.DataSource;
            var phone = phonesCollection[phoneList.SelectedIndex];
            phone.DisplayInterface();
        }
    }
}
