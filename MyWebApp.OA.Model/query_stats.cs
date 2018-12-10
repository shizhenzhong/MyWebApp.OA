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
    
    public partial class query_stats
    {
        public byte[] sql_handle { get; set; }
        public int statement_start_offset { get; set; }
        public int statement_end_offset { get; set; }
        public long plan_generation_num { get; set; }
        public byte[] plan_handle { get; set; }
        public System.DateTimeOffset creation_time { get; set; }
        public System.DateTimeOffset last_execution_time { get; set; }
        public long execution_count { get; set; }
        public Nullable<long> snapshot_execution_count { get; set; }
        public long total_worker_time { get; set; }
        public long snapshot_worker_time { get; set; }
        public Nullable<long> min_worker_time { get; set; }
        public long max_worker_time { get; set; }
        public long total_physical_reads { get; set; }
        public long snapshot_physical_reads { get; set; }
        public Nullable<long> min_physical_reads { get; set; }
        public long max_physical_reads { get; set; }
        public long total_logical_writes { get; set; }
        public long snapshot_logical_writes { get; set; }
        public Nullable<long> min_logical_writes { get; set; }
        public long max_logical_writes { get; set; }
        public long total_logical_reads { get; set; }
        public long snapshot_logical_reads { get; set; }
        public Nullable<long> min_logical_reads { get; set; }
        public long max_logical_reads { get; set; }
        public Nullable<long> total_clr_time { get; set; }
        public Nullable<long> snapshot_clr_time { get; set; }
        public Nullable<long> min_clr_time { get; set; }
        public Nullable<long> max_clr_time { get; set; }
        public long total_elapsed_time { get; set; }
        public long snapshot_elapsed_time { get; set; }
        public Nullable<long> min_elapsed_time { get; set; }
        public long max_elapsed_time { get; set; }
        public System.DateTimeOffset collection_time { get; set; }
        public int snapshot_id { get; set; }
    
        public virtual snapshots_internal snapshots_internal { get; set; }
    }
}
