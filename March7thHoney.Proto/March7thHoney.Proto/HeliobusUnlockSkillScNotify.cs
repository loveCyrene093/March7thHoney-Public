using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusUnlockSkillScNotify : IMessage<HeliobusUnlockSkillScNotify>, IMessage, IEquatable<HeliobusUnlockSkillScNotify>, IDeepCloneable<HeliobusUnlockSkillScNotify>, IBufferMessage
{
	private static readonly MessageParser<HeliobusUnlockSkillScNotify> _parser = new MessageParser<HeliobusUnlockSkillScNotify>(() => new HeliobusUnlockSkillScNotify());

	private UnknownFieldSet _unknownFields;

	public const int JGKIBPDAEFEFieldNumber = 4;

	private uint jGKIBPDAEFE_;

	public const int SkillIdFieldNumber = 14;

	private uint skillId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusUnlockSkillScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusUnlockSkillScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGKIBPDAEFE
	{
		get
		{
			return jGKIBPDAEFE_;
		}
		set
		{
			jGKIBPDAEFE_ = value;
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
	public HeliobusUnlockSkillScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusUnlockSkillScNotify(HeliobusUnlockSkillScNotify other)
		: this()
	{
		jGKIBPDAEFE_ = other.jGKIBPDAEFE_;
		skillId_ = other.skillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusUnlockSkillScNotify Clone()
	{
		return new HeliobusUnlockSkillScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusUnlockSkillScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusUnlockSkillScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JGKIBPDAEFE != other.JGKIBPDAEFE)
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
		if (JGKIBPDAEFE != 0)
		{
			num ^= JGKIBPDAEFE.GetHashCode();
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
		if (JGKIBPDAEFE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(JGKIBPDAEFE);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(112);
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
		if (JGKIBPDAEFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGKIBPDAEFE);
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
	public void MergeFrom(HeliobusUnlockSkillScNotify other)
	{
		if (other != null)
		{
			if (other.JGKIBPDAEFE != 0)
			{
				JGKIBPDAEFE = other.JGKIBPDAEFE;
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
			case 32u:
				JGKIBPDAEFE = input.ReadUInt32();
				break;
			case 112u:
				SkillId = input.ReadUInt32();
				break;
			}
		}
	}
}
