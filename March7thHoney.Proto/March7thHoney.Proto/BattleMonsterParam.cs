using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleMonsterParam : IMessage<BattleMonsterParam>, IMessage, IEquatable<BattleMonsterParam>, IDeepCloneable<BattleMonsterParam>, IBufferMessage
{
	private static readonly MessageParser<BattleMonsterParam> _parser = new MessageParser<BattleMonsterParam>(() => new BattleMonsterParam());

	private UnknownFieldSet _unknownFields;

	public const int HardLevelGroupFieldNumber = 1;

	private uint hardLevelGroup_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int EliteGroupFieldNumber = 3;

	private uint eliteGroup_;

	public const int OPJAFNEFJDCFieldNumber = 4;

	private uint oPJAFNEFJDC_;

	public const int BDCCEFHMFHOFieldNumber = 5;

	private uint bDCCEFHMFHO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleMonsterParam> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleMonsterParamReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HardLevelGroup
	{
		get
		{
			return hardLevelGroup_;
		}
		set
		{
			hardLevelGroup_ = value;
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
	public uint EliteGroup
	{
		get
		{
			return eliteGroup_;
		}
		set
		{
			eliteGroup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPJAFNEFJDC
	{
		get
		{
			return oPJAFNEFJDC_;
		}
		set
		{
			oPJAFNEFJDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BDCCEFHMFHO
	{
		get
		{
			return bDCCEFHMFHO_;
		}
		set
		{
			bDCCEFHMFHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonsterParam()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonsterParam(BattleMonsterParam other)
		: this()
	{
		hardLevelGroup_ = other.hardLevelGroup_;
		level_ = other.level_;
		eliteGroup_ = other.eliteGroup_;
		oPJAFNEFJDC_ = other.oPJAFNEFJDC_;
		bDCCEFHMFHO_ = other.bDCCEFHMFHO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonsterParam Clone()
	{
		return new BattleMonsterParam(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleMonsterParam);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleMonsterParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HardLevelGroup != other.HardLevelGroup)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (EliteGroup != other.EliteGroup)
		{
			return false;
		}
		if (OPJAFNEFJDC != other.OPJAFNEFJDC)
		{
			return false;
		}
		if (BDCCEFHMFHO != other.BDCCEFHMFHO)
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
		if (HardLevelGroup != 0)
		{
			num ^= HardLevelGroup.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (EliteGroup != 0)
		{
			num ^= EliteGroup.GetHashCode();
		}
		if (OPJAFNEFJDC != 0)
		{
			num ^= OPJAFNEFJDC.GetHashCode();
		}
		if (BDCCEFHMFHO != 0)
		{
			num ^= BDCCEFHMFHO.GetHashCode();
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
		if (HardLevelGroup != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HardLevelGroup);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (EliteGroup != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EliteGroup);
		}
		if (OPJAFNEFJDC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OPJAFNEFJDC);
		}
		if (BDCCEFHMFHO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BDCCEFHMFHO);
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
		if (HardLevelGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HardLevelGroup);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (EliteGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EliteGroup);
		}
		if (OPJAFNEFJDC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPJAFNEFJDC);
		}
		if (BDCCEFHMFHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BDCCEFHMFHO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleMonsterParam other)
	{
		if (other != null)
		{
			if (other.HardLevelGroup != 0)
			{
				HardLevelGroup = other.HardLevelGroup;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.EliteGroup != 0)
			{
				EliteGroup = other.EliteGroup;
			}
			if (other.OPJAFNEFJDC != 0)
			{
				OPJAFNEFJDC = other.OPJAFNEFJDC;
			}
			if (other.BDCCEFHMFHO != 0)
			{
				BDCCEFHMFHO = other.BDCCEFHMFHO;
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
				HardLevelGroup = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
				EliteGroup = input.ReadUInt32();
				break;
			case 32u:
				OPJAFNEFJDC = input.ReadUInt32();
				break;
			case 40u:
				BDCCEFHMFHO = input.ReadUInt32();
				break;
			}
		}
	}
}
