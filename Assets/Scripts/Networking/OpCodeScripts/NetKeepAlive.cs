using System.Collections;
using System.Collections.Generic;
using Unity.Networking.Transport;
using UnityEngine;

public class NetKeepAlive : NetworkMessage
{
    public NetKeepAlive() // <-- Making the box
    {
        Code = OpCode.KEEP_ALIVE;
    }
    public NetKeepAlive(DataStreamReader reader) // <-- Receiveing the box
    {
        Code = OpCode.KEEP_ALIVE;
        Deserialize(reader);
    }
    public override void Serialize(ref DataStreamWriter writer)
    {
        writer.WriteByte((byte)Code);
    }
    public override void Deserialize(DataStreamReader reader)
    {
        //reader.ReadByte();
    }
    public override void ReceivedOnClient()
    {
        NetworkUtility.C_KEEP_ALIVE?.Invoke(this);
    }
    public override void ReceivedOnServer(NetworkConnection cnn)
    {
        NetworkUtility.S_KEEP_ALIVE?.Invoke(this, cnn);
    }
}
