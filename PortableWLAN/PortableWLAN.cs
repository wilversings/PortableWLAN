using PortableWLAN.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableWLAN {
    public partial class PortableWLAN : Form {

        HostedNetworkService wlan;
        public PortableWLAN () {

            InitializeComponent ();
            wlan = new HostedNetworkService ();
            wlan.GetDriverInfo ();

        }

        ~PortableWLAN () {

            wlan.StopBroadcast ();

        }

        private void ToggleBroadcast () {

        }

        private void toggleBroadcastButton_Click (object sender, EventArgs e) {

            if (!wlan.IsBroadcasting) {
                // Starting broadcast
                string errorMessages = "";

                wlan.SSID = SSIDTextBox.Text;
                try {
                    wlan.Key = KeyTextBox.Text;
                }
                catch (ApplicationException ex) {
                    if (ex.Message == "ERR_INVALID_WPA2") 
                        MessageBox.Show ("Password must have at least 8 characters", "Broadcasting", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                wlan.StartBroadcast ();

                //Changing UI
                toggleBroadcastButton.Text = "Stop";
                SSIDTextBox.Enabled = false;
                KeyTextBox.Enabled = false;
            } else {
                // Stoping broadcast
                wlan.StopBroadcast ();

                //Changing UI
                toggleBroadcastButton.Text = "Broadcast";
                SSIDTextBox.Enabled = true;
                KeyTextBox.Enabled = true;

            }
            
        }

        private void PortableWLAN_Load (object sender, EventArgs e) {

        }

        private void showKeyCheckBox_CheckedChanged (object sender, EventArgs e) {
            
            if (showKeyCheckBox.Checked) {
                KeyTextBox.UseSystemPasswordChar = false;
            }
            else {
                KeyTextBox.UseSystemPasswordChar = true;
            }

        }

        private void SSIDTextBox_TextChanged (object sender, EventArgs e) {
            if (SSIDTextBox.Text.Count () > 32) {
                SSIDTextBox.Text = SSIDTextBox.Text.Substring (0, 32);
                MessageBox.Show ("SSID must have a maximum of 32 characters", "SSID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
