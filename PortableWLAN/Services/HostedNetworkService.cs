using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableWLAN.Services {
    class HostedNetworkService {

        private string serviceCommandString;
        private Process cmdProcess;

        public HostedNetworkService () {

            serviceCommandString = "/c netsh wlan ";
            cmdProcess = new Process ();

            IsBroadcasting = false;

            cmdProcess.StartInfo.FileName = "CMD.exe";
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.Arguments = serviceCommandString + "set hostednetwork mode=allow";
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.Start ();

        }

        public Dictionary<string, string> GetDriverInfo () {

            cmdProcess.StartInfo.Arguments = serviceCommandString + "show drivers";
            cmdProcess.Start ();
            cmdProcess.WaitForExit ();


            string output = cmdProcess.StandardOutput.ReadToEnd ();

            return new Dictionary<string, string> ();
            
        }

        public bool IsBroadcasting { get; set; }

        public string SSID {
            set {
                if (value.Count () > 32) {
                    throw new ApplicationException ("ERR_INVALID_SSID");
                }
                cmdProcess.StartInfo.Arguments = serviceCommandString + "set hostednetwork ssid=\"" + value + "\"";
                cmdProcess.Start ();
            }
        }

        public string Key {

            set {
                if (value.Count () < 8) {
                    throw new ApplicationException ("ERR_INVALID_WPA2");
                }
                cmdProcess.StartInfo.Arguments = serviceCommandString + "set hostednetwork keyUsage=persistent key=\"" + value + "\"";
                cmdProcess.Start ();
            }

        }

        public void ToggleBroadcast () {

            cmdProcess.StartInfo.Arguments = serviceCommandString + (IsBroadcasting ? "stop" : "start") + " hostednetwork";
            cmdProcess.Start ();
            IsBroadcasting = !IsBroadcasting;

        }

        public void StartBroadcast () {

            cmdProcess.StartInfo.Arguments = serviceCommandString + "start hostednetwork";
            cmdProcess.Start ();
            IsBroadcasting = true;

        }

        public void StopBroadcast () {

            cmdProcess.StartInfo.Arguments = serviceCommandString + "stop hostednetwork";
            cmdProcess.Start ();
            IsBroadcasting = false;

        }

    }
}
