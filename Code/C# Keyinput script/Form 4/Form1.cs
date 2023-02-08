using System.Diagnostics;
using System.IO.Ports;

namespace Form_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SerialPort? _serialPort;

        private void Form1_Load(object sender, EventArgs e)
        {

            _serialPort = new SerialPort();
            _serialPort.PortName = "COM6";
            _serialPort.BaudRate = 115200;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Parity = Parity.None;
            _serialPort.Handshake = Handshake.None;



           // _serialPort.DataReceived += new SerialDataReceivedEventHandler(MyDataReceivedHandler);
            _serialPort.Open();
            while (true)
            {
                // if(_serialPort.)
                string a = _serialPort.ReadLine();
                Debug.WriteLine(a);
                System.Threading.Thread.Sleep(500);
                SendKeys.SendWait("{RIGHT}");
                Thread.Sleep(1000);
            }
        }
    }
}