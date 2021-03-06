﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZigBeeNet.Transport
{
    public class TransportConfig
    {
        private Dictionary<TransportConfigOption, object> _request;
        private Dictionary<TransportConfigOption, ZigBeeStatus> _response;

        public TransportConfig()
        {
            _request = new Dictionary<TransportConfigOption, object>();
            _response = new Dictionary<TransportConfigOption, ZigBeeStatus>();
        }

        /// <summary>
         /// Creates a configuration and directly adds the option
         ///
         /// @param option
         /// @param value
         /// </summary>
        public TransportConfig(TransportConfigOption option, object value)
        {
            _request[option] = value;
        }

        /// <summary>
         /// Adds a {@link TransportConfigOption} and its value. The same option can't be added to the configuration twice.
         ///
         /// @param option the {@link TransportConfigOption} to set
         /// @return true if the option was added, false if the option already existed
         /// </summary>
        public bool AddOption(TransportConfigOption option, object value)
        {
            if (_request.ContainsKey(option))
            {
                return false;
            }
            _request.Add(option, value);
            return true;
        }

        /// <summary>
         /// Gets the a {@link TransportConfigOption} if it is configured
         ///
         /// @param option the {@link TransportConfigOption} to retrieve
         /// @return the requested {@link TransportConfigOption} value or null if it is not set
         /// </summary>
        public object GetOption(TransportConfigOption option)
        {
            return _request[option];
        }

        /// <summary>
         /// Gets the {@link Set} of {@link TransportConfigOption}s
         ///
         /// @return the {@link Set} of {@link TransportConfigOption}s
         /// </summary>
        public List<TransportConfigOption> GetOptions()
        {
            return _request.Keys.ToList();
        }

        /// <summary>
         /// Gets a value for the specified {@link TransportConfigOption}
         ///
         /// @param option the {@link TransportConfigOption} to retrieve
         /// @return the {@link Object}
         /// </summary>
        public object GetValue(TransportConfigOption option)
        {
            return _request[option];
        }

        /// <summary>
         /// Sets the {@link ZigBeeStatus} for a configuration setting
         ///
         /// @param option the {@link TransportConfigOption} to set the result
         /// @param value the {@link ZigBeeStatus}
         /// @return true if the result was set, false if the option did not exist or the result was already set
         /// </summary>
        public bool SetResult(TransportConfigOption option, ZigBeeStatus value)
        {
            if (_request.ContainsKey(option) == false || _request[option] == null || _response.ContainsKey(option))
            {
                return false;
            }
            _response[option] = value;

            return true;
        }

        /// <summary>
         /// Gets the the {@link TransportConfigResult} for a {@link TransportConfigOption} if it is configured
         ///
         /// @param option the {@link TransportConfigOption} to retrieve the result
         /// @return the result {@link ZigBeeStatus} for the requested {@link TransportConfigOption}
         /// </summary>
        public ZigBeeStatus GetResult(TransportConfigOption option)
        {
            if (_request.ContainsKey(option) == false)
            {
                return ZigBeeStatus.INVALID_ARGUMENTS;
            }
            if (_response.ContainsKey(option) == false)
            {
                return ZigBeeStatus.BAD_RESPONSE;
            }
            return _response[option];
        }
    }
}
