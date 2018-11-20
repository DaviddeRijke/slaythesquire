using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packet {

    private string function;
    private string[] args;
    
    public string Function
    {
        get
        {
            return function;
        }
    }
    public string[] Args
    {
        get
        {
            return args;
        }
    }
    public string Message
    {
        get
        {
            string message = function;
            if (args != null)
                foreach (string arg in args)
                {
                    message += "/" + arg;
                }
            return message;
        }
    }

    public Packet(string message)
    {
        string[] packet = message.Split('/');
        function = packet[0].ToUpper().Trim();
        if (packet.Length > 1)
        {
            args = new string[packet.Length - 1];
            for (int i = 0; i < packet.Length - 1; i++)
            {
                args[i] = packet[i + 1];
            }
        }
    }
}
