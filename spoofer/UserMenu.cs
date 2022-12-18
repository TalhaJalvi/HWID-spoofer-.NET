using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Management;

namespace spoofer
{
    public partial class UserMenu : Form
    {
        public string GUID001="";
        public string GUIDS = "";
        public UserMenu()
        {
            InitializeComponent();
            //For darkmode
            darkbar.UseImmersiveDarkMode(Handle, true);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Here panel will be changed to HWID spoofer
            panel1.Show();
            /*  GUID001 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null).ToString();
              //MessageBox.Show(hwid);
              textBox4.Text = GUID001;
              GUIDS = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", null).ToString();

             */

            //For HWID Spoofer" https://guidedhacking.com/threads/hwid-spoofers.18261/


            //Getting CPU ID
            string cpuid = "";
            var mbs = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
            var mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                cpuid = mo["ProcessorID"].ToString();
            }
            MessageBox.Show(cpuid);

            //Getting BIOS info 
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");

            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                    MessageBox.Show(data.Value.ToString());
  
            }
            searcher.Dispose();

            //Getting GPU ID
            var gpusearcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            {
                foreach (ManagementObject obj in gpusearcher.Get())
                {
                    MessageBox.Show("Name  -  " + obj["Name"]);
                    MessageBox.Show("PNPDeviceID  -  " + obj["PNPDeviceID"]);
                }
            }

            //Getting Hard disk ID
            //https://www.makeuseof.com/find-hard-disk-model-serial-number-windows-10/
            //https://www.codeproject.com/Articles/6077/How-to-Retrieve-the-REAL-Hard-Drive-Serial-Number#xx3754341xx
            var HDsearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject wmi_HD in HDsearcher.Get())
            {
                // get the hardware serial no.
                if (wmi_HD["SerialNumber"] != null)
                {
                    MessageBox.Show("Hard disk serian Number :" + wmi_HD["SerialNumber"].ToString());
                }
            }

            //Getting each volume serial Number
            //https://www.lifewire.com/how-to-find-a-drives-volume-label-or-serial-number-2624494
            //https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-logicaldisk

            var Localsearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            foreach (ManagementObject wmi_HD in Localsearcher.Get())
            {
                if (wmi_HD["VolumeSerialNumber"]!=null && wmi_HD["Name"] != null)
                { 
                        MessageBox.Show(wmi_HD["Name"].ToString() + ": " + wmi_HD["VolumeSerialNumber"].ToString());
                    }
            }

            //Getting RAM ID
            //https://www.windowscentral.com/how-get-full-memory-specs-speed-size-type-part-number-form-factor-windows-10
            //https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-physicalmemory

            var Ramsearcher = new
           ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject wmi_RD in Ramsearcher.Get())
            {
                if (wmi_RD["SerialNumber"] != null && wmi_RD["Name"] != null)
                {
                    MessageBox.Show(wmi_RD["Name"].ToString() + ": " + wmi_RD["SerialNumber"].ToString());
                }
            }


            //Getting BIOS information
            //
            //https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-bios

            var Biossearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            foreach (ManagementObject wmi_BD in Biossearcher.Get())
            {
                if (wmi_BD["SerialNumber"] != null && wmi_BD["Version"] != null && wmi_BD["SMBIOSBIOSVersion"] != null)
                {
                    MessageBox.Show(wmi_BD["Version"].ToString() + ": " + wmi_BD["SerialNumber"].ToString()+":" + wmi_BD["SMBIOSBIOSVersion"].ToString());
                }
            }

            //Getting mac address
            //https://www.laptopmag.com/articles/find-mac-address-windows-10
            //https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-networkadapter

            var Macsearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
            foreach (ManagementObject wmi_MCS in Macsearcher.Get())
            {
                if (wmi_MCS["MacAddress"] != null )
                {
                    MessageBox.Show(wmi_MCS["MacAddress"].ToString()+wmi_MCS["ProductName"].ToString());
                }
            }

        }

        private void UserMenu_Load(object sender, EventArgs e)
{

this.FormBorderStyle = FormBorderStyle.FixedSingle;
panel1.Hide();
}


private void loadCheat_Click(object sender, EventArgs e)
{
//Generating new HWID or GUI
Guid myUUId = Guid.NewGuid();
string convertedUUID = myUUId.ToString();
/*
RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", true);
if (myKey != null)
{
    myKey.SetValue("HwProfileGuid", convertedUUID, RegistryValueKind.String);
    myKey.Close();
}
//And also 
RegistryKey myKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true);
if (myKey != null)
{

    myKey2.SetValue("MachineGuid", convertedUUID, RegistryValueKind.String);
    myKey2.Close();
}

//setting new HWID in textbox
string GUID002 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null).ToString();
textBox4.Text = GUID002;
*/
            //Now changing disk serial numbers 
            //first getting drives partition
            /*DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                MessageBox.Show("Drive {0}"+d.Name);

            }
            */
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", true);
            if (myKey != null)
            {
                myKey.SetValue("HwProfileGuid", GUID001, RegistryValueKind.String);
                myKey.Close();
            }
            //And also 
            RegistryKey myKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true);
            if (myKey != null)
            {

                myKey2.SetValue("MachineGuid", GUIDS, RegistryValueKind.String);
                myKey2.Close();
            }

            string GUID002 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null).ToString();
            textBox4.Text = GUID002;
            */
        }
    }
    }

