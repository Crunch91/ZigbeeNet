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
 /// Appliance Identificationcluster implementation (Cluster ID 0x0B00).
 ///
 /// Code is auto-generated. Modifications may be overwritten!
 /// </summary>
namespace ZigBeeNet.ZCL.Clusters
{
   public class ZclApplianceIdentificationCluster : ZclCluster
   {
       /// <summary>
       /// The ZigBee Cluster Library Cluster ID
       /// </summary>
       public static ushort CLUSTER_ID = 0x0B00;

       /// <summary>
       /// The ZigBee Cluster Library Cluster Name
       /// </summary>
       public static string CLUSTER_NAME = "Appliance Identification";

       // Attribute initialisation
       protected override Dictionary<ushort, ZclAttribute> InitializeAttributes()
       {
           Dictionary<ushort, ZclAttribute> attributeMap = new Dictionary<ushort, ZclAttribute>(0);

           return attributeMap;
       }

       /// <summary>
       /// Default constructor to create a Appliance Identification cluster.
       ///
       /// @param zigbeeEndpoint the {@link ZigBeeEndpoint}
       /// </summary>
       public ZclApplianceIdentificationCluster(ZigBeeEndpoint zigbeeEndpoint)
           : base(zigbeeEndpoint, CLUSTER_ID, CLUSTER_NAME)
       {
       }

   }
}
