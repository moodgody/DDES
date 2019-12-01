/********************************************************************************************
* Copyright (c) Global Engineering Management by Invensys (refer to readme.txt for details)
* 
* Purpose           :  DDE client class
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
namespace DDEClient
{
    class DDEClient
    {
        DdeAppClient _ddeAppClient;
        string _serverName;
        public DDEClient(System.Windows.Forms.Form form,string serverName)
        {
            _ddeAppClient = new DdeAppClient();
            _serverName = serverName;
            _serverName = _ddeAppClient.Add(serverName, true);
            _ddeAppClient.Connect(_serverName);
        }

        internal bool[] ReadCoiles()
        {
            bool[] resval = new bool[4];
            FunctionResult res = new FunctionResult();
           
            //_ddeAppClient.FunctionCall(_serverName, "GetCoiles", res);
            
            VariableResult result = new VariableResult("coile0", DdeVariableType.Integer);
            _ddeAppClient.VariableRead(_serverName, "coile0", result);
            resval[0] = bool.Parse(result.Value);
            _ddeAppClient.VariableRead(_serverName, "coile1", result);
            resval[1] = bool.Parse(result.Value);
            _ddeAppClient.VariableRead(_serverName, "coile2", result);
            resval[2] = bool.Parse(result.Value);
            _ddeAppClient.VariableRead(_serverName, "coile3", result);
            resval[3] = bool.Parse(result.Value);
            
            return resval;
        }
    }
}
