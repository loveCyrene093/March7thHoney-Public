using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpgradeAreaStatCsReq : IMessage<UpgradeAreaStatCsReq>, IMessage, IEquatable<UpgradeAreaStatCsReq>, IDeepCloneable<UpgradeAreaStatCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpgradeAreaStatCsReq> _parser = new MessageParser<UpgradeAreaStatCsReq>(() => new UpgradeAreaStatCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int DGFGNMJALGJFieldNumber = 12;

	private StatType dGFGNMJALGJ_;

	public const int AreaIdFieldNumber = 14;

	private uint areaId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpgradeAreaStatCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpgradeAreaStatCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatType DGFGNMJALGJ
	{
		get
		{
			return dGFGNMJALGJ_;
		}
		set
		{
			dGFGNMJALGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpgradeAreaStatCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpgradeAreaStatCsReq(UpgradeAreaStatCsReq other)
		: this()
	{
		level_ = other.level_;
		dGFGNMJALGJ_ = other.dGFGNMJALGJ_;
		areaId_ = other.areaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpgradeAreaStatCsReq Clone()
	{
		return new UpgradeAreaStatCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpgradeAreaStatCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpgradeAreaStatCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (DGFGNMJALGJ != other.DGFGNMJALGJ)
		{
			return false;
		}
		if (AreaId != other.AreaId)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
		{
			num ^= DGFGNMJALGJ.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)DGFGNMJALGJ);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AreaId);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DGFGNMJALGJ);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpgradeAreaStatCsReq other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
			{
				DGFGNMJALGJ = other.DGFGNMJALGJ;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
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
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 96u:
				DGFGNMJALGJ = (StatType)input.ReadEnum();
				break;
			case 112u:
				AreaId = input.ReadUInt32();
				break;
			}
		}
	}
}
