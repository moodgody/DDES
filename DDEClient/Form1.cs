using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDEClient
{
    public partial class Form1 : Form
    {
        DDEClient _ddeclient;
        public Form1()
        {
            InitializeComponent();
            _ddeclient = new DDEClient(this, "DDEServer");
        }

        private void BTN_ReadCoiles_Click(object sender, EventArgs e)
        {
           bool[] coiles =   _ddeclient.ReadCoiles();
            CHB_Coile0.Checked = coiles[0];
            CHB_Coile1.Checked = coiles[1];
            CHB_Coile2.Checked = coiles[2];
            CHB_Coile3.Checked = coiles[3];
        }
    }
}
