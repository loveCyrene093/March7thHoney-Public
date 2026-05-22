using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarkChestInfo : IMessage<MarkChestInfo>, IMessage, IEquatable<MarkChestInfo>, IDeepCloneable<MarkChestInfo>, IBufferMessage
{
	private static readonly MessageParser<MarkChestInfo> _parser = new MessageParser<MarkChestInfo>(() => new MarkChestInfo());

	private UnknownFieldSet _unknownFields;

	public const int ConfigIdFieldNumber = 2;

	private uint configId_;

	public const int FDLMGFJDIPCFieldNumber = 3;

	private uint fDLMGFJDIPC_;

	public const int PlaneIdFieldNumber = 4;

	private uint planeId_;

	public const int FloorIdFieldNumber = 5;

	private uint floorId_;

	public const int GroupIdFieldNumber = 8;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarkChestInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarkChestInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FDLMGFJDIPC
	{
		get
		{
			return fDLMGFJDIPC_;
		}
		set
		{
			fDLMGFJDIPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

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
	public MarkChestInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChestInfo(MarkChestInfo other)
		: this()
	{
		configId_ = other.configId_;
		fDLMGFJDIPC_ = other.fDLMGFJDIPC_;
		planeId_ = other.planeId_;
		floorId_ = other.floorId_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChestInfo Clone()
	{
		return new MarkChestInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarkChestInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarkChestInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (FDLMGFJDIPC != other.FDLMGFJDIPC)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (FloorId != other.FloorId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
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
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (FDLMGFJDIPC != 0)
		{
			num ^= FDLMGFJDIPC.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
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
		if (ConfigId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ConfigId);
		}
		if (FDLMGFJDIPC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FDLMGFJDIPC);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PlaneId);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FloorId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GroupId);
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
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (FDLMGFJDIPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FDLMGFJDIPC);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarkChestInfo other)
	{
		if (other != null)
		{
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
			}
			if (other.FDLMGFJDIPC != 0)
			{
				FDLMGFJDIPC = other.FDLMGFJDIPC;
			}
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			if (other.FloorId != 0)
			{
				FloorId = other.FloorId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
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
			case 16u:
				ConfigId = input.ReadUInt32();
				break;
			case 24u:
				FDLMGFJDIPC = input.ReadUInt32();
				break;
			case 32u:
				PlaneId = input.ReadUInt32();
				break;
			case 40u:
				FloorId = input.ReadUInt32();
				break;
			case 64u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
