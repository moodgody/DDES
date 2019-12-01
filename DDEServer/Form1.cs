using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDEServer
{
    public partial class Form1 : Form
    {
        DDEServer _dDEServer;
        bool _coileControlStatus;
        public Form1()
        {
            InitializeComponent();
            ConfigureGUI();
            _dDEServer = new DDEServer(this);


        }

        private void ConfigureGUI()
        {
            CHB_Coile0.BackColor = CHB_Coile0.Checked ? Color.Green : Color.Red;
            CHB_Coile0.ForeColor = CHB_Coile0.Checked ? Color.Yellow : Color.White;
            CHB_Coile1.BackColor = CHB_Coile1.Checked ? Color.Green : Color.Red;
            CHB_Coile1.ForeColor = CHB_Coile1.Checked ? Color.Yellow : Color.White;
            CHB_Coile2.BackColor = CHB_Coile2.Checked ? Color.Green : Color.Red;
            CHB_Coile2.ForeColor = CHB_Coile2.Checked ? Color.Yellow : Color.White;
            CHB_Coile3.BackColor = CHB_Coile3.Checked ? Color.Green : Color.Red;
            CHB_Coile3.ForeColor = CHB_Coile3.Checked ? Color.Yellow : Color.White;
        }

        private void BTN_CoileOn_Click(object sender, EventArgs e)
        {
            _dDEServer.SetCoil(int.Parse( TXT_CoileReference.Text));
        }

        private void BTN_CoileOff_Click(object sender, EventArgs e)
        {
            _dDEServer.ResetCoil(int.Parse( TXT_CoileReference.Text));
        }

        private void CHB_Coile0_CheckedChanged(object sender, EventArgs e)
        {
            CHB_Coile0.BackColor = CHB_Coile0.Checked ? Color.Green : Color.Red;
            var res = CHB_Coile0.Checked? _dDEServer.SetCoil(0): _dDEServer.ResetCoil(0);
           
        }

        private void CHB_Coile1_CheckedChanged(object sender, EventArgs e)
        {
            CHB_Coile1.BackColor = CHB_Coile1.Checked ? Color.Green : Color.Red;
            var res = CHB_Coile0.Checked ? _dDEServer.SetCoil(1) : _dDEServer.ResetCoil(1);
        }

        private void CHB_Coile2_CheckedChanged(object sender, EventArgs e)
        {
            CHB_Coile2.BackColor = CHB_Coile2.Checked ? Color.Green : Color.Red;
            var res = CHB_Coile0.Checked ? _dDEServer.SetCoil(2) : _dDEServer.ResetCoil(2);
        }

        private void CHB_Coile3_CheckedChanged(object sender, EventArgs e)
        {
            CHB_Coile3.BackColor = CHB_Coile3.Checked ? Color.Green : Color.Red;
            var res = CHB_Coile0.Checked ? _dDEServer.SetCoil(3) : _dDEServer.ResetCoil(3);
        }
    }
}
