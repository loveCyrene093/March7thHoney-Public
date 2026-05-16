using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SkillUseProperty : IMessage<SkillUseProperty>, IMessage, IEquatable<SkillUseProperty>, IDeepCloneable<SkillUseProperty>, IBufferMessage
{
	private static readonly MessageParser<SkillUseProperty> _parser = new MessageParser<SkillUseProperty>(() => new SkillUseProperty());

	private UnknownFieldSet _unknownFields;

	public const int SkillIdFieldNumber = 1;

	private uint skillId_;

	public const int SkillTypeFieldNumber = 2;

	private string skillType_ = "";

	public const int SkillLevelFieldNumber = 3;

	private uint skillLevel_;

	public const int SkillUseCountFieldNumber = 4;

	private uint skillUseCount_;

	public const int KEAFAMICBKDFieldNumber = 5;

	private uint kEAFAMICBKD_;

	public const int NCKHFMCMBECFieldNumber = 6;

	private uint nCKHFMCMBEC_;

	public const int DAMLLHHOMHHFieldNumber = 7;

	private uint dAMLLHHOMHH_;

	public const int ENJENFOOHMDFieldNumber = 8;

	private uint eNJENFOOHMD_;

	public const int ILFLKKLMBOIFieldNumber = 9;

	private uint iLFLKKLMBOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SkillUseProperty> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SkillUsePropertyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SkillType
	{
		get
		{
			return skillType_;
		}
		set
		{
			skillType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillLevel
	{
		get
		{
			return skillLevel_;
		}
		set
		{
			skillLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillUseCount
	{
		get
		{
			return skillUseCount_;
		}
		set
		{
			skillUseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEAFAMICBKD
	{
		get
		{
			return kEAFAMICBKD_;
		}
		set
		{
			kEAFAMICBKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCKHFMCMBEC
	{
		get
		{
			return nCKHFMCMBEC_;
		}
		set
		{
			nCKHFMCMBEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DAMLLHHOMHH
	{
		get
		{
			return dAMLLHHOMHH_;
		}
		set
		{
			dAMLLHHOMHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ENJENFOOHMD
	{
		get
		{
			return eNJENFOOHMD_;
		}
		set
		{
			eNJENFOOHMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILFLKKLMBOI
	{
		get
		{
			return iLFLKKLMBOI_;
		}
		set
		{
			iLFLKKLMBOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillUseProperty()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillUseProperty(SkillUseProperty other)
		: this()
	{
		skillId_ = other.skillId_;
		skillType_ = other.skillType_;
		skillLevel_ = other.skillLevel_;
		skillUseCount_ = other.skillUseCount_;
		kEAFAMICBKD_ = other.kEAFAMICBKD_;
		nCKHFMCMBEC_ = other.nCKHFMCMBEC_;
		dAMLLHHOMHH_ = other.dAMLLHHOMHH_;
		eNJENFOOHMD_ = other.eNJENFOOHMD_;
		iLFLKKLMBOI_ = other.iLFLKKLMBOI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillUseProperty Clone()
	{
		return new SkillUseProperty(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkillUseProperty);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SkillUseProperty other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (SkillType != other.SkillType)
		{
			return false;
		}
		if (SkillLevel != other.SkillLevel)
		{
			return false;
		}
		if (SkillUseCount != other.SkillUseCount)
		{
			return false;
		}
		if (KEAFAMICBKD != other.KEAFAMICBKD)
		{
			return false;
		}
		if (NCKHFMCMBEC != other.NCKHFMCMBEC)
		{
			return false;
		}
		if (DAMLLHHOMHH != other.DAMLLHHOMHH)
		{
			return false;
		}
		if (ENJENFOOHMD != other.ENJENFOOHMD)
		{
			return false;
		}
		if (ILFLKKLMBOI != other.ILFLKKLMBOI)
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
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (SkillType.Length != 0)
		{
			num ^= SkillType.GetHashCode();
		}
		if (SkillLevel != 0)
		{
			num ^= SkillLevel.GetHashCode();
		}
		if (SkillUseCount != 0)
		{
			num ^= SkillUseCount.GetHashCode();
		}
		if (KEAFAMICBKD != 0)
		{
			num ^= KEAFAMICBKD.GetHashCode();
		}
		if (NCKHFMCMBEC != 0)
		{
			num ^= NCKHFMCMBEC.GetHashCode();
		}
		if (DAMLLHHOMHH != 0)
		{
			num ^= DAMLLHHOMHH.GetHashCode();
		}
		if (ENJENFOOHMD != 0)
		{
			num ^= ENJENFOOHMD.GetHashCode();
		}
		if (ILFLKKLMBOI != 0)
		{
			num ^= ILFLKKLMBOI.GetHashCode();
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
		if (SkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(SkillId);
		}
		if (SkillType.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SkillType);
		}
		if (SkillLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(SkillLevel);
		}
		if (SkillUseCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(SkillUseCount);
		}
		if (KEAFAMICBKD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(KEAFAMICBKD);
		}
		if (NCKHFMCMBEC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NCKHFMCMBEC);
		}
		if (DAMLLHHOMHH != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DAMLLHHOMHH);
		}
		if (ENJENFOOHMD != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ENJENFOOHMD);
		}
		if (ILFLKKLMBOI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ILFLKKLMBOI);
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
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (SkillType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkillType);
		}
		if (SkillLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillLevel);
		}
		if (SkillUseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillUseCount);
		}
		if (KEAFAMICBKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEAFAMICBKD);
		}
		if (NCKHFMCMBEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCKHFMCMBEC);
		}
		if (DAMLLHHOMHH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DAMLLHHOMHH);
		}
		if (ENJENFOOHMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ENJENFOOHMD);
		}
		if (ILFLKKLMBOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILFLKKLMBOI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SkillUseProperty other)
	{
		if (other != null)
		{
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.SkillType.Length != 0)
			{
				SkillType = other.SkillType;
			}
			if (other.SkillLevel != 0)
			{
				SkillLevel = other.SkillLevel;
			}
			if (other.SkillUseCount != 0)
			{
				SkillUseCount = other.SkillUseCount;
			}
			if (other.KEAFAMICBKD != 0)
			{
				KEAFAMICBKD = other.KEAFAMICBKD;
			}
			if (other.NCKHFMCMBEC != 0)
			{
				NCKHFMCMBEC = other.NCKHFMCMBEC;
			}
			if (other.DAMLLHHOMHH != 0)
			{
				DAMLLHHOMHH = other.DAMLLHHOMHH;
			}
			if (other.ENJENFOOHMD != 0)
			{
				ENJENFOOHMD = other.ENJENFOOHMD;
			}
			if (other.ILFLKKLMBOI != 0)
			{
				ILFLKKLMBOI = other.ILFLKKLMBOI;
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
				SkillId = input.ReadUInt32();
				break;
			case 18u:
				SkillType = input.ReadString();
				break;
			case 24u:
				SkillLevel = input.ReadUInt32();
				break;
			case 32u:
				SkillUseCount = input.ReadUInt32();
				break;
			case 40u:
				KEAFAMICBKD = input.ReadUInt32();
				break;
			case 48u:
				NCKHFMCMBEC = input.ReadUInt32();
				break;
			case 56u:
				DAMLLHHOMHH = input.ReadUInt32();
				break;
			case 64u:
				ENJENFOOHMD = input.ReadUInt32();
				break;
			case 72u:
				ILFLKKLMBOI = input.ReadUInt32();
				break;
			}
		}
	}
}
