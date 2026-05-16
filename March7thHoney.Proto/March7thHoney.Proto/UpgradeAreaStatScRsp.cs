using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpgradeAreaStatScRsp : IMessage<UpgradeAreaStatScRsp>, IMessage, IEquatable<UpgradeAreaStatScRsp>, IDeepCloneable<UpgradeAreaStatScRsp>, IBufferMessage
{
	private static readonly MessageParser<UpgradeAreaStatScRsp> _parser = new MessageParser<UpgradeAreaStatScRsp>(() => new UpgradeAreaStatScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AreaIdFieldNumber = 1;

	private uint areaId_;

	public const int DGFGNMJALGJFieldNumber = 4;

	private StatType dGFGNMJALGJ_;

	public const int LevelFieldNumber = 12;

	private uint level_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpgradeAreaStatScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpgradeAreaStatScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpgradeAreaStatScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpgradeAreaStatScRsp(UpgradeAreaStatScRsp other)
		: this()
	{
		areaId_ = other.areaId_;
		dGFGNMJALGJ_ = other.dGFGNMJALGJ_;
		level_ = other.level_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpgradeAreaStatScRsp Clone()
	{
		return new UpgradeAreaStatScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpgradeAreaStatScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpgradeAreaStatScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (DGFGNMJALGJ != other.DGFGNMJALGJ)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
		{
			num ^= DGFGNMJALGJ.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AreaId);
		}
		if (DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)DGFGNMJALGJ);
		}
		if (Level != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Level);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DGFGNMJALGJ);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpgradeAreaStatScRsp other)
	{
		if (other != null)
		{
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.DGFGNMJALGJ != StatType.PohdibangefPcpdhelpkem)
			{
				DGFGNMJALGJ = other.DGFGNMJALGJ;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				AreaId = input.ReadUInt32();
				break;
			case 32u:
				DGFGNMJALGJ = (StatType)input.ReadEnum();
				break;
			case 96u:
				Level = input.ReadUInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
