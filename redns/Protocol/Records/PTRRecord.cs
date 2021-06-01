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
using System.Collections.Generic;
using redns.Protocol.ResourceRecords;

namespace redns.Protocol.Records
{
    class PTRRecord
        : HostnameRecord
    {
        public PTRRecord (Zone zone, string name, RecordClass @class, UInt32 ttl)
            : base (zone, name, @class, RecordType.PTR, ttl)
        {
        }

        public override IEnumerable<ResourceRecordBase> GetResourceRecordsForQuery (Query query)
        {
            yield return new PTRResourceRecord { Data = this.Data };
        }
    }
}
