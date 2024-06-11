using System;
using System.Globalization;
using System.Windows.Forms;
using BR.AN.PviServices;

namespace Pluto_PVI_trial_01
{
    public partial class Form1 : Form
    {
        private const string ServiceName = "service";
        private const string IpAddress = "192.168.12.10";
        private const short Port = 11159;

        private const short SourcePort = 26575;
        private const byte SourceStation = 1;

        private Service _service;
        private Cpu _cpu;
        private Variable _variable;
        // Logger log;

        public Form1()
        {
            InitializeComponent();
            // Enum.TryParse(Properties.Settings.Default.logLevel, out Logger.logLevelT logLevelProperty);
            // log = new Logger(tbLog, Properties.Settings.Default.logPath, logLevelProperty);
            // tbLog.AppendText(@"Log file path: C:\Users\perrje\OneDrive - Comet\My Documents\work\pluto-pvi.log" + "\r\n");
            // log.logMsg(Logger.logLevelT.INFO, "System started");
        }

        private void btnConnectPLC_Click(object sender, EventArgs e)
        {
            if (_service == null)
            {
                _service = new Service(ServiceName);
                _service.Connected += service_Connected;
                _service.Error += service_Error;
            }

            _service.Connect();
            // log.logMsg(Logger.logLevelT.INFO, "Service connection request");            
        }

        /// <summary> 
        /// Connect CPU object if service object connection successful 
        ///</summary> 
        private void service_Connected(object sender, PviEventArgs e)
        {
            grpVariables.Enabled = true;
            // log.logMsg(Logger.logLevelT.INFO, "Service connected");
            if (_cpu == null)
            {
                // Create CPU object and add the event handler 
                _cpu = new Cpu(_service, "cpu");
                _cpu.Connected += cpu_Connected;
                _cpu.DateTimeRead += cpu_DateTimeRead;
                // Set the connection properties for a TCP/IP connection 
                _cpu.Connection.DeviceType = DeviceType.TcpIp;
                _cpu.Connection.TcpIp.DestinationIpAddress = IpAddress;
                _cpu.Connection.TcpIp.DestinationPort = Port;
                //if the Destination Station is not specified, it looks like the system automatically determines it.
                //cpu.Connection.TcpIp.DestinationStation = Properties.Settings.Default.destination_station;
                _cpu.Connection.TcpIp.SourcePort = SourcePort;
                _cpu.Connection.TcpIp.SourceStation = SourceStation;
            }

            // Connect CPU
            _cpu.Connect();
        }

        /// <summary> 
        /// Handles service connection errors 
        ///</summary>
        private void service_Error(object sender, PviEventArgs e)
        {
            int errorCode = _service.ErrorCode;
            if (errorCode != 0)
            {
                // log.logMsg(Logger.logLevelT.ERROR, String.Format("Service connection error (error code: {0})!", errorCode));
                MessageBox.Show(_service.GetErrorText(_service.ErrorCode));
            }
        }

        /// <summary> 
        /// Output text when connection to CPU successful and   
        /// enable Variable Connect button. Additionnaly reads the PLC date and time.
        /// </summary> 
        private void cpu_Connected(object sender, PviEventArgs e)
        {
            // log.logMsg(Logger.logLevelT.INFO, string.Format("{0} connected", ((Cpu)sender).Name));
            panelVariableRead.Enabled = true;
            _cpu.ReadDateTime();
        }

        /// <summary>
        /// Output the PLC date and time in the log
        /// </summary>
        private void cpu_DateTimeRead(object sender, CpuEventArgs e)
        {
            // log.logMsg(Logger.logLevelT.INFO, e.DateTime.ToString());
        }


        /// <summary>
        /// Create and connect variable object
        /// </summary>
        private void btnConnectVariable_Click(object sender, EventArgs e)
        {
            ConnectVariable();
        }

        private void ConnectVariable()
        {
            // Create new (global) variable object -> global
            // variable "count" must be on the controller and should
            // cyclically count up
            // log.logMsg(Logger.logLevelT.INFO, String.Format("Connection to {0} variable requested", tbVarNameRead.Text));
            _variable = new Variable(_cpu, tbVarNameRead.Text);
            // Activate and connect variable object
            _variable.Active = true;
            _variable.Connect();
            // Add event handler for value changes
            _variable.ValueChanged += variable_ValueChanged;
            _variable.ValueWritten += variable_ValueWritten;
            panelVariableRead.Enabled = false;
            panelVariableWrite.Enabled = true;
            btnDisconnectVariable.Focus();
        }

        /// <summary> 
        /// Output value changes in status field
        /// </summary> 
        private void variable_ValueChanged(object sender, VariableEventArgs e)
        {
            Variable tmpVariable = (Variable)sender;
            tbVarValue.Text = tmpVariable.Value.ToString(new CultureInfo("RU-ru"));
            // log.logMsg(Logger.logLevelT.INFO, tmpVariable.Name + ": " + tmpVariable.Value.ToString());
        }

        private void variable_Disconnected(object sender, PviEventArgs e)
        {
            // log.logMsg(Logger.logLevelT.INFO, "Variable disconnected");
            _variable.Dispose();
            panelVariableRead.Enabled = true;
            tbVarValue.Text = "";
            panelVariableWrite.Enabled = false;
            tbVarNameRead.Focus();
        }

        private void variable_ValueWritten(object sender, PviEventArgs e)
        {
            // log.logMsg(Logger.logLevelT.INFO, "Variable written");
            tbVarNameRead.Focus();
        }

        private void btnDisconnectVariable_Click(object sender, EventArgs e)
        {
            // log.logMsg(Logger.logLevelT.INFO, "Variable disconnection requested");
            _variable.Active = false;
            // Add event handler for value changes
            _variable.Disconnected += variable_Disconnected;
            _variable.Disconnect();
        }

        private void tbVarNameRead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            ConnectVariable();
            e.Handled = true;
        }

        private void btnVariableWrite_Click(object sender, EventArgs e)
        {
            VariableWrite();
        }

        private void VariableWrite()
        {
            // log.logMsg(Logger.logLevelT.INFO, "Variable write requested");
            _variable.Value = tbVarValue.Text;
            _variable.WriteValue();
        }

        private void tbVarValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            VariableWrite();
            e.Handled = true;
        }
    }
}