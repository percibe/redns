﻿/**
 * 
 * This file is part of redns. A simple, regex-ready and scriptable
 * authoritatibe DNS server for toying, testing and red teaming.
 * 
 * Written by Luis Medel, Percibe Information Security.
 * 
 * Copyright 2021, Percibe S.L.
 * https://percibe.net
 * 
 */

using System;
using System.Net;

namespace redns.Protocol.Records
{
    abstract class AddressRecord
        : Record<IPAddress>
    {
        public string Address
        {
            get => base.Data.ToString ();
            set => base.Data = IPAddress.Parse (value);
        }

        public AddressRecord (Zone zone, string name, RecordClass @class, RecordType type, UInt32 ttl)
            : base (zone, name, @class, type, ttl)
        {
        }
    }
}