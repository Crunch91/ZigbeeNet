﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.DoorLock;

/**
 * Unlock Door Response value object class.
 *
 * Cluster: Door Lock. Command is sentFROM the server.
 * This command is a specific command used for the Door Lock cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 13.02.2019 - 21:42 */
namespace ZigBeeNet.ZCL.Clusters.DoorLock
{
   public class UnlockDoorResponse : ZclCommand
   {
           /**
           * Status command message field.
           */
           public byte Status { get; set; }


           /**
           * Default constructor.
           */
           public UnlockDoorResponse()
           {
               GenericCommand = false;
               ClusterId = 257;
               CommandId = 1;
               CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
    }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(Status, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        Status = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("UnlockDoorResponse [");
           builder.Append(base.ToString());
           builder.Append(", Status=");
           builder.Append(Status);
           builder.Append(']');

           return builder.ToString();
       }

   }
}