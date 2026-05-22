using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGLANHAMOMM : IMessage<CGLANHAMOMM>, IMessage, IEquatable<CGLANHAMOMM>, IDeepCloneable<CGLANHAMOMM>, IBufferMessage
{
	private static readonly MessageParser<CGLANHAMOMM> _parser = new MessageParser<CGLANHAMOMM>(() => new CGLANHAMOMM());

	private UnknownFieldSet _unknownFields;

	public const int MOOOPAMBOFKFieldNumber = 3;

	private uint mOOOPAMBOFK_;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int SkillIdFieldNumber = 13;

	private uint skillId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGLANHAMOMM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGLANHAMOMMReflection.Descriptor.MessageTypes[0];

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
	public CGLANHAMOMM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGLANHAMOMM(CGLANHAMOMM other)
		: this()
	{
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		level_ = other.level_;
		skillId_ = other.skillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGLANHAMOMM Clone()
	{
		return new CGLANHAMOMM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGLANHAMOMM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGLANHAMOMM other)
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
		if (Level != other.Level)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(MOOOPAMBOFK);
		}
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(104);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
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
	public void MergeFrom(CGLANHAMOMM other)
	{
		if (other != null)
		{
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 24u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 104u:
				SkillId = input.ReadUInt32();
				break;
			}
		}
	}
}
