using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KACOOFIKHOG : IMessage<KACOOFIKHOG>, IMessage, IEquatable<KACOOFIKHOG>, IDeepCloneable<KACOOFIKHOG>, IBufferMessage
{
	private static readonly MessageParser<KACOOFIKHOG> _parser = new MessageParser<KACOOFIKHOG>(() => new KACOOFIKHOG());

	private UnknownFieldSet _unknownFields;

	public const int SkillTypeFieldNumber = 8;

	private TrainPartyMtSkillBriefType skillType_;

	public const int SkillIdFieldNumber = 11;

	private uint skillId_;

	public const int ENOOEFLJIFHFieldNumber = 13;

	private uint eNOOEFLJIFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KACOOFIKHOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KACOOFIKHOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyMtSkillBriefType SkillType
	{
		get
		{
			return skillType_;
		}
		set
		{
			skillType_ = value;
		}
	}

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
	public uint ENOOEFLJIFH
	{
		get
		{
			return eNOOEFLJIFH_;
		}
		set
		{
			eNOOEFLJIFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KACOOFIKHOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KACOOFIKHOG(KACOOFIKHOG other)
		: this()
	{
		skillType_ = other.skillType_;
		skillId_ = other.skillId_;
		eNOOEFLJIFH_ = other.eNOOEFLJIFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KACOOFIKHOG Clone()
	{
		return new KACOOFIKHOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KACOOFIKHOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KACOOFIKHOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillType != other.SkillType)
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (ENOOEFLJIFH != other.ENOOEFLJIFH)
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
		if (SkillType != TrainPartyMtSkillBriefType.HjbfkhgaajiHibophohgdl)
		{
			num ^= SkillType.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (ENOOEFLJIFH != 0)
		{
			num ^= ENOOEFLJIFH.GetHashCode();
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
		if (SkillType != TrainPartyMtSkillBriefType.HjbfkhgaajiHibophohgdl)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)SkillType);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(SkillId);
		}
		if (ENOOEFLJIFH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ENOOEFLJIFH);
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
		if (SkillType != TrainPartyMtSkillBriefType.HjbfkhgaajiHibophohgdl)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillType);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (ENOOEFLJIFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ENOOEFLJIFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KACOOFIKHOG other)
	{
		if (other != null)
		{
			if (other.SkillType != TrainPartyMtSkillBriefType.HjbfkhgaajiHibophohgdl)
			{
				SkillType = other.SkillType;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.ENOOEFLJIFH != 0)
			{
				ENOOEFLJIFH = other.ENOOEFLJIFH;
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
			case 64u:
				SkillType = (TrainPartyMtSkillBriefType)input.ReadEnum();
				break;
			case 88u:
				SkillId = input.ReadUInt32();
				break;
			case 104u:
				ENOOEFLJIFH = input.ReadUInt32();
				break;
			}
		}
	}
}
