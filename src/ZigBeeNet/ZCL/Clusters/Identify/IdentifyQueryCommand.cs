﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.Identify;

/**
 * Identify Query Command value object class.
 *
 * Cluster: Identify. Command is sentTO the server.
 * This command is a specific command used for the Identify cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 13.02.2019 - 21:42 */
namespace ZigBeeNet.ZCL.Clusters.Identify
{
   public class IdentifyQueryCommand : ZclCommand
   {

           /**
           * Default constructor.
           */
           public IdentifyQueryCommand()
           {
               GenericCommand = false;
               ClusterId = 3;
               CommandId = 1;
               CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("IdentifyQueryCommand [");
           builder.Append(base.ToString());
           builder.Append(']');

           return builder.ToString();
       }

   }
}