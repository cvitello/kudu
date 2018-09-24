// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: fs.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Kudu.Client.Protocol
{

    [global::ProtoBuf.ProtoContract()]
    public partial class InstanceMetadataPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"uuid", IsRequired = true)]
        public byte[] Uuid { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"format_stamp", IsRequired = true)]
        public string FormatStamp { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PathSetPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"uuid", IsRequired = true)]
        public byte[] Uuid { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"all_uuids")]
        public global::System.Collections.Generic.List<byte[]> AllUuids { get; } = new global::System.Collections.Generic.List<byte[]>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PathInstanceMetadataPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path_set", IsRequired = true)]
        public PathSetPB PathSet { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"block_manager_type", IsRequired = true)]
        public string BlockManagerType { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"filesystem_block_size_bytes", IsRequired = true)]
        public ulong FilesystemBlockSizeBytes { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BlockIdPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public ulong Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BlockRecordPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_id", IsRequired = true)]
        public BlockIdPB BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"op_type", IsRequired = true)]
        public BlockRecordType OpType { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"timestamp_us", IsRequired = true)]
        public ulong TimestampUs { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"offset")]
        public long Offset
        {
            get { return __pbn__Offset.GetValueOrDefault(); }
            set { __pbn__Offset = value; }
        }
        public bool ShouldSerializeOffset() => __pbn__Offset != null;
        public void ResetOffset() => __pbn__Offset = null;
        private long? __pbn__Offset;

        [global::ProtoBuf.ProtoMember(5, Name = @"length")]
        public long Length
        {
            get { return __pbn__Length.GetValueOrDefault(); }
            set { __pbn__Length = value; }
        }
        public bool ShouldSerializeLength() => __pbn__Length != null;
        public void ResetLength() => __pbn__Length = null;
        private long? __pbn__Length;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DataDirGroupPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"uuids")]
        public global::System.Collections.Generic.List<byte[]> Uuids { get; } = new global::System.Collections.Generic.List<byte[]>();

    }

    [global::ProtoBuf.ProtoContract()]
    public enum BlockRecordType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
        Unknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"CREATE")]
        Create = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"DELETE")]
        Delete = 2,
    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
