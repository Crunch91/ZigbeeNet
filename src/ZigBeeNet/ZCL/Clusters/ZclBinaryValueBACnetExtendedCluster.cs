﻿// License text here

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZigBeeNet.DAO;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;

/// <summary>
 /// Binary Value (BACnet Extended)cluster implementation (Cluster ID 0x060D).
 ///
 /// Code is auto-generated. Modifications may be overwritten!
 /// </summary>
namespace ZigBeeNet.ZCL.Clusters
{
   public class ZclBinaryValueBACnetExtendedCluster : ZclCluster
   {
       /// <summary>
       /// The ZigBee Cluster Library Cluster ID
       /// </summary>
       public static ushort CLUSTER_ID = 0x060D;

       /// <summary>
       /// The ZigBee Cluster Library Cluster Name
       /// </summary>
       public static string CLUSTER_NAME = "Binary Value (BACnet Extended)";

       // Attribute initialisation
       protected override Dictionary<ushort, ZclAttribute> InitializeAttributes()
       {
           Dictionary<ushort, ZclAttribute> attributeMap = new Dictionary<ushort, ZclAttribute>(0);

           return attributeMap;
       }

       /// <summary>
       /// Default constructor to create a Binary Value (BACnet Extended) cluster.
       ///
       /// @param zigbeeEndpoint the {@link ZigBeeEndpoint}
       /// </summary>
       public ZclBinaryValueBACnetExtendedCluster(ZigBeeEndpoint zigbeeEndpoint)
           : base(zigbeeEndpoint, CLUSTER_ID, CLUSTER_NAME)
       {
       }

   }
}
