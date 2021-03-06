using System;
using System.Text;
using ZigBeeNet.Transaction;
using ZigBeeNet.ZCL;
using ZigBeeNet.ZCL.Protocol;

namespace ZigBeeNet.ZDO.Command
{
    /// <summary>
    /// Extended Simple Descriptor Response value object class.
    /// 
    /// The Extended_Simple_Desc_rsp is generated by a remote device in response to an
    /// Extended_Simple_Desc_req directed to the remote device. This command shall
    /// be unicast to the originator of the Extended_Simple_Desc_req command.
    /// 
    /// </summary>
    public class ExtendedSimpleDescriptorResponse : ZdoResponse
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ExtendedSimpleDescriptorResponse()
        {
            ClusterId = 0x801D;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("ExtendedSimpleDescriptorResponse [")
                   .Append(base.ToString())
                   .Append(']');

            return builder.ToString();
        }

    }
}
