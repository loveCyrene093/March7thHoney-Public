using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcMonsterRogueInfo : IMessage<NpcMonsterRogueInfo>, IMessage, IEquatable<NpcMonsterRogueInfo>, IDeepCloneable<NpcMonsterRogueInfo>, IBufferMessage
{
	private static readonly MessageParser<NpcMonsterRogueInfo> _parser = new MessageParser<NpcMonsterRogueInfo>(() => new NpcMonsterRogueInfo());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 1;

	private uint level_;

	public const int EliteGroupFieldNumber = 5;

	private uint eliteGroup_;

	public const int MCBPLGAEGDJFieldNumber = 8;

	private HDKDHKPLBJC mCBPLGAEGDJ_;

	public const int OPJAFNEFJDCFieldNumber = 10;

	private uint oPJAFNEFJDC_;

	public const int RogueMonsterIdFieldNumber = 12;

	private uint rogueMonsterId_;

	public const int HardLevelGroupFieldNumber = 15;

	private uint hardLevelGroup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcMonsterRogueInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NpcMonsterRogueInfoReflection.Descriptor.MessageTypes[0];

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
	public HDKDHKPLBJC MCBPLGAEGDJ
	{
		get
		{
			return mCBPLGAEGDJ_;
		}
		set
		{
			mCBPLGAEGDJ_ = value;
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
	public uint RogueMonsterId
	{
		get
		{
			return rogueMonsterId_;
		}
		set
		{
			rogueMonsterId_ = value;
		}
	}

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
	public NpcMonsterRogueInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMonsterRogueInfo(NpcMonsterRogueInfo other)
		: this()
	{
		level_ = other.level_;
		eliteGroup_ = other.eliteGroup_;
		mCBPLGAEGDJ_ = other.mCBPLGAEGDJ_;
		oPJAFNEFJDC_ = other.oPJAFNEFJDC_;
		rogueMonsterId_ = other.rogueMonsterId_;
		hardLevelGroup_ = other.hardLevelGroup_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMonsterRogueInfo Clone()
	{
		return new NpcMonsterRogueInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NpcMonsterRogueInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcMonsterRogueInfo other)
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
		if (EliteGroup != other.EliteGroup)
		{
			return false;
		}
		if (MCBPLGAEGDJ != other.MCBPLGAEGDJ)
		{
			return false;
		}
		if (OPJAFNEFJDC != other.OPJAFNEFJDC)
		{
			return false;
		}
		if (RogueMonsterId != other.RogueMonsterId)
		{
			return false;
		}
		if (HardLevelGroup != other.HardLevelGroup)
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
		if (EliteGroup != 0)
		{
			num ^= EliteGroup.GetHashCode();
		}
		if (MCBPLGAEGDJ != HDKDHKPLBJC.Ofghjkihmib)
		{
			num ^= MCBPLGAEGDJ.GetHashCode();
		}
		if (OPJAFNEFJDC != 0)
		{
			num ^= OPJAFNEFJDC.GetHashCode();
		}
		if (RogueMonsterId != 0)
		{
			num ^= RogueMonsterId.GetHashCode();
		}
		if (HardLevelGroup != 0)
		{
			num ^= HardLevelGroup.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Level);
		}
		if (EliteGroup != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EliteGroup);
		}
		if (MCBPLGAEGDJ != HDKDHKPLBJC.Ofghjkihmib)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)MCBPLGAEGDJ);
		}
		if (OPJAFNEFJDC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OPJAFNEFJDC);
		}
		if (RogueMonsterId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(RogueMonsterId);
		}
		if (HardLevelGroup != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HardLevelGroup);
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
		if (EliteGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EliteGroup);
		}
		if (MCBPLGAEGDJ != HDKDHKPLBJC.Ofghjkihmib)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MCBPLGAEGDJ);
		}
		if (OPJAFNEFJDC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPJAFNEFJDC);
		}
		if (RogueMonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueMonsterId);
		}
		if (HardLevelGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HardLevelGroup);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcMonsterRogueInfo other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.EliteGroup != 0)
			{
				EliteGroup = other.EliteGroup;
			}
			if (other.MCBPLGAEGDJ != HDKDHKPLBJC.Ofghjkihmib)
			{
				MCBPLGAEGDJ = other.MCBPLGAEGDJ;
			}
			if (other.OPJAFNEFJDC != 0)
			{
				OPJAFNEFJDC = other.OPJAFNEFJDC;
			}
			if (other.RogueMonsterId != 0)
			{
				RogueMonsterId = other.RogueMonsterId;
			}
			if (other.HardLevelGroup != 0)
			{
				HardLevelGroup = other.HardLevelGroup;
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
				Level = input.ReadUInt32();
				break;
			case 40u:
				EliteGroup = input.ReadUInt32();
				break;
			case 64u:
				MCBPLGAEGDJ = (HDKDHKPLBJC)input.ReadEnum();
				break;
			case 80u:
				OPJAFNEFJDC = input.ReadUInt32();
				break;
			case 96u:
				RogueMonsterId = input.ReadUInt32();
				break;
			case 120u:
				HardLevelGroup = input.ReadUInt32();
				break;
			}
		}
	}
}
