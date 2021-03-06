﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceManagerFacade
{
﻿    [Serializable]
    public class PublicResultObjectWaitAuditTask : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("resultErrorMsg")]
        public String ResultErrorMsg
        {
            get;
            set;
        }

        [JsonProperty("waitAudit")]
        public PageWaitAuditTask WaitAudit
        {
            get;
            set;
        }

    }

}
