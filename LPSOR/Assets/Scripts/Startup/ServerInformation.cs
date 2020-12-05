using System.Collections;
using System.Collections.Generic;
using Game.UI.Startup;
using UnityEngine;

[System.Serializable]
public struct ServerInformation
{
    // variant meant for connecting to the server without a key
    public ServerInformation(string ip, string uName)
    { 
        this.IP = ip;
        this.userName = uName;
        this.keyId = "";
    }
    // variant that contains key
    public ServerInformation(string ip, string uName, string keyId)
    { 
        this.IP = ip;
        this.userName = uName;
        this.keyId = keyId;
    }
    public string userName;
    public string keyId;
    public string IP;
}