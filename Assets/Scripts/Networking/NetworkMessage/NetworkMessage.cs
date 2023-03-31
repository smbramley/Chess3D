using System.Collections;
using System.Collections.Generic;
using Unity.Networking.Transport;
using UnityEngine;

public class NetworkMessage
{
    public OpCode Code { set; get; }

    public NetworkMessage()
    {

    }

    public NetworkMessage(OpCode code)
    {
        Code = code;
    }
    public virtual void Serialize(ref DataStreamWriter writer)
    {
        writer.WriteByte((byte)Code);
    }
    public virtual void Deserialize(DataStreamReader reader)
    {

    }
    public virtual void ReceivedOnClient()
    {

    }
    public virtual void ReceivedOnServer(NetworkConnection cnn)
    {

    }
}
