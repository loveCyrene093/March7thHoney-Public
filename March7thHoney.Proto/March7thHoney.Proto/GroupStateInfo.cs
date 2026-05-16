using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupStateInfo : IMessage<GroupStateInfo>, IMessage, IEquatable<GroupStateInfo>, IDeepCloneable<GroupStateInfo>, IBufferMessage
{
	private static readonly MessageParser<GroupStateInfo> _parser = new MessageParser<GroupStateInfo>(() => new GroupStateInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private uint groupId_;

	public const int GroupStateFieldNumber = 4;

	private uint groupState_;

	public const int PGJCLBCEPBMFieldNumber = 9;

	private uint pGJCLBCEPBM_;

	public const int EntryIdFieldNumber = 15;

	private uint entryId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GroupStateInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GroupStateInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupState
	{
		get
		{
			return groupState_;
		}
		set
		{
			groupState_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGJCLBCEPBM
	{
		get
		{
			return pGJCLBCEPBM_;
		}
		set
		{
			pGJCLBCEPBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntryId
	{
		get
		{
			return entryId_;
		}
		set
		{
			entryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateInfo(GroupStateInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		groupState_ = other.groupState_;
		pGJCLBCEPBM_ = other.pGJCLBCEPBM_;
		entryId_ = other.entryId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateInfo Clone()
	{
		return new GroupStateInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GroupStateInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupStateInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (GroupState != other.GroupState)
		{
			return false;
		}
		if (PGJCLBCEPBM != other.PGJCLBCEPBM)
		{
			return false;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GroupState != 0)
		{
			num ^= GroupState.GetHashCode();
		}
		if (PGJCLBCEPBM != 0)
		{
			num ^= PGJCLBCEPBM.GetHashCode();
		}
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GroupId);
		}
		if (GroupState != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GroupState);
		}
		if (PGJCLBCEPBM != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PGJCLBCEPBM);
		}
		if (EntryId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(EntryId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (GroupState != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupState);
		}
		if (PGJCLBCEPBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGJCLBCEPBM);
		}
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GroupStateInfo other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GroupState != 0)
			{
				GroupState = other.GroupState;
			}
			if (other.PGJCLBCEPBM != 0)
			{
				PGJCLBCEPBM = other.PGJCLBCEPBM;
			}
			if (other.EntryId != 0)
			{
				EntryId = other.EntryId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				GroupId = input.ReadUInt32();
				break;
			case 32u:
				GroupState = input.ReadUInt32();
				break;
			case 72u:
				PGJCLBCEPBM = input.ReadUInt32();
				break;
			case 120u:
				EntryId = input.ReadUInt32();
				break;
			}
		}
	}
}
