using System;

namespace Phone
{
    public abstract class Phone
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        public abstract void DisplayInfo();
        public virtual string VersionNumber { get { return _versionNumber; } set { _versionNumber = value; } }
        public virtual int BatteryPercentage { get { return _batteryPercentage; } set { _batteryPercentage = value; } }
        public virtual string Carrier { get { return _carrier; } set { _carrier = value; } }
        public virtual string RingTone { get { return _ringTone; } set { _ringTone = value; } }
    }
}