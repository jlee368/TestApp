using System;
using System.Xml.Serialization;

namespace TestApp
{
    [XmlRoot("Devices")]
    public class DeviceList
    {
        [XmlElement("Device")]
        public Device[] Devices { get; set; }
    }

    public class Device
    {
        public string HostName { get; set; }
        public string IP { get; set; }
        [XmlIgnore]
        public DateTime ScannedOn { get; set; }
        [XmlElement("ScannedOn")]
        public string ScannedOnUnparsed
        {
            get { return ScannedOn.ToString("MM/dd/yyyy"); }
            set { ScannedOn = DateTime.Parse(value); }
        }
        public Software[] Softwares { get; set; }
    }

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }
        [XmlIgnore]
        public DateTime InstalledOn { get; set; }
        [XmlElement("InstalledOn")]
        public string InstalledOnUnparsed
        {
            get { return InstalledOn.ToString("MM/dd/yyyy"); }
            set { InstalledOn = DateTime.Parse(value); }
        }
        [XmlIgnore]
        public DateTime UpdatedOn { get; set; }
        [XmlElement("UpdatedOn")]
        public string UpdatedOnUnparsed
        {
            get { return UpdatedOn.ToString("MM/dd/yyyy"); }
            set { UpdatedOn = DateTime.Parse(value); }
        }
    }
}
