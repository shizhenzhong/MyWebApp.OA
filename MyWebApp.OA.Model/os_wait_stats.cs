//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebApp.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class os_wait_stats
    {
        public string wait_type { get; set; }
        public long waiting_tasks_count { get; set; }
        public long wait_time_ms { get; set; }
        public long signal_wait_time_ms { get; set; }
        public System.DateTimeOffset collection_time { get; set; }
        public int snapshot_id { get; set; }
    
        public virtual snapshots_internal snapshots_internal { get; set; }
    }
}
