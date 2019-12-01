/********************************************************************************************
* Copyright (c) Global Engineering Management by Invensys (refer to readme.txt for details)
* 
* Purpose           :  DDE Server class
* 
* Rev  Date         By      Purpose
* ---- ------------ ------------------------------------------------------------------
* 01   2019-12-01   AG     the initial version.
* 
*  ********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeArtEng.DdeApp;
namespace DDEServer
{
    class DDEServer
    {
        DdeAppServer _ddeAppServer;
        public bool[] _coile ;
        public DDEServer(System.Windows.Forms.Form form)
        {
            _coile = new bool[30];
             _ddeAppServer = DdeAppServer.SingleInstance(form);
            _ddeAppServer.ClientConnected += _ddeAppServer_ClientConnected;
            _ddeAppServer.SetFunctionCallback(OnFunctionCall);
            _ddeAppServer.SetVariableReadCallback(variableReadCallBack);
            _ddeAppServer.RegisterFunction("GetCoiles", "");
            _ddeAppServer.RegisterVariable("coile0", DdeVariableType.String, true);
            _ddeAppServer.RegisterVariable("coile1", DdeVariableType.String, true);
            _ddeAppServer.RegisterVariable("coile2", DdeVariableType.String, true);
            _ddeAppServer.RegisterVariable("coile3", DdeVariableType.String, true);
            
            _ddeAppServer.Online();
            
        }

        private void variableReadCallBack(VariableResult result)
        {

            result.Value = result.Name.CompareTo("coile0") == 0 ? _coile[0].ToString() :
                           result.Name.CompareTo("coile1") == 0 ? _coile[1].ToString() :
                           result.Name.CompareTo("coile2") == 0 ? _coile[2].ToString() :
                           _coile[3].ToString();

            
        }

        void OnFunctionCall(FunctionResult res)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<_coile.Length;i++)
            {
                sb.AppendLine(_coile[i].ToString());
            }
            res.Message = sb.ToString();
            
        }
        public bool[] GetCoiles()
        {
            return _coile;
        }

        internal bool SetCoil(int reference)
        {
            _coile[reference] = true;
            return _coile[reference] == true;
        }

        private void _ddeAppServer_ClientConnected(object sender, DdeAppEventArgs e)
        {
            var source =  e.Source;
        }

        internal bool ResetCoil(int reference)
        {
            _coile[reference] = false;
            return _coile[reference] == false;
        }
    }
}
