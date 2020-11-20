using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private string selectedFile = "";
        private DeviceList deviceList = null;
        private static int daysBeforeToday = 90;
        private static int daysAfterToday = 90;
        private DateTime scannedAfter = DateTime.Now.Subtract(TimeSpan.FromDays(daysBeforeToday));
        private DateTime scannedBefore = DateTime.Now.AddDays(daysAfterToday);

        public Form1()
        {
            InitializeComponent();
            dtPickerScannedBefore.Value = scannedBefore;
            dtPickerScannedAfter.Value = scannedAfter;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            var filePrompt = new OpenFileDialog();
            filePrompt.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            filePrompt.Multiselect = false;
            if (filePrompt.ShowDialog() == DialogResult.OK)
            {
                selectedFile = filePrompt.FileName;
                tboxDeviceFile.Text = selectedFile;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (selectedFile != "")
            {
                deviceList = parseFile();
                findDevicesBetweenScannedOnDates();
            }
        }

        private void findDevicesBetweenScannedOnDates()
        {
            /*Using the read in device list, scanned after date and scanned before date find the
             * devices with scannedOn dates falling in between the scanned after and scanned before dates.
             * The devices are stored in an array, but it may be useful to use a method in System.Linq to convert it to a list,
             * "FindALL" matches and then convert back to an array. You can also use a method in Syste.Array to "FindAll" the matching devices.
             * Look for devices in deviceList.Devices
             * */
            //This is returning all the devices and not filtering them against the scannedOnAfter and the scannedOnBefore dates.
            //You need to filter deviceList.Devices
            var matchingDevices = deviceList.Devices;
            var matchingDeviceFile = new DeviceList() { Devices = matchingDevices };
            serialize(matchingDeviceFile);
        }

        private DeviceList parseFile()
        {
            var readerSettings = new XmlReaderSettings()
            {
                Async = true,
                IgnoreWhitespace = true,
                IgnoreComments = true
            };
            var serializer = new XmlSerializer(typeof(DeviceList));
            using (XmlReader xmlReader = XmlReader.Create(selectedFile, readerSettings))
            {
                return (DeviceList)serializer.Deserialize(xmlReader);
            }
        }

        private void serialize(DeviceList deviceFile)
        {
            var path = Path.GetDirectoryName(selectedFile);
            var timestamp = DateTime.Now.ToString("MM-dd-yyyy_hh-mm-ss_tt");
            var filePath = path + $@"\MatchingDevices_{timestamp}.xml";
            var serializer = new XmlSerializer(typeof(DeviceList));
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, deviceFile);
            }
            MessageBox.Show("Matching devices saved to: " + filePath);
        }

        private void dtPickerScannedAfter_ValueChanged(object sender, EventArgs e)
        {
            scannedAfter = dtPickerScannedAfter.Value;
        }

        private void dtPickerScannedBefore_ValueChanged(object sender, EventArgs e)
        {
            scannedBefore = dtPickerScannedBefore.Value;
        }
    }
}
