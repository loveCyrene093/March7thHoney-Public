using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JAFPMLLOGDI : IMessage<JAFPMLLOGDI>, IMessage, IEquatable<JAFPMLLOGDI>, IDeepCloneable<JAFPMLLOGDI>, IBufferMessage
{
	private static readonly MessageParser<JAFPMLLOGDI> _parser = new MessageParser<JAFPMLLOGDI>(() => new JAFPMLLOGDI());

	private UnknownFieldSet _unknownFields;

	public const int MOOOPAMBOFKFieldNumber = 12;

	private uint mOOOPAMBOFK_;

	public const int SkillLevelFieldNumber = 14;

	private uint skillLevel_;

	public const int SkillIdFieldNumber = 15;

	private uint skillId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JAFPMLLOGDI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JAFPMLLOGDIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOOOPAMBOFK
	{
		get
		{
			return mOOOPAMBOFK_;
		}
		set
		{
			mOOOPAMBOFK_ = value;
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
	public JAFPMLLOGDI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAFPMLLOGDI(JAFPMLLOGDI other)
		: this()
	{
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		skillLevel_ = other.skillLevel_;
		skillId_ = other.skillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAFPMLLOGDI Clone()
	{
		return new JAFPMLLOGDI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JAFPMLLOGDI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JAFPMLLOGDI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MOOOPAMBOFK != other.MOOOPAMBOFK)
		{
			return false;
		}
		if (SkillLevel != other.SkillLevel)
		{
			return false;
		}
		if (SkillId != other.SkillId)
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
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
		}
		if (SkillLevel != 0)
		{
			num ^= SkillLevel.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
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
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MOOOPAMBOFK);
		}
		if (SkillLevel != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(SkillLevel);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(SkillId);
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
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (SkillLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillLevel);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JAFPMLLOGDI other)
	{
		if (other != null)
		{
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
			}
			if (other.SkillLevel != 0)
			{
				SkillLevel = other.SkillLevel;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
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
			case 96u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			case 112u:
				SkillLevel = input.ReadUInt32();
				break;
			case 120u:
				SkillId = input.ReadUInt32();
				break;
			}
		}
	}
}
