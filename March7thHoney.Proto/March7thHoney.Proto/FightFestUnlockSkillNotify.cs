using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightFestUnlockSkillNotify : IMessage<FightFestUnlockSkillNotify>, IMessage, IEquatable<FightFestUnlockSkillNotify>, IDeepCloneable<FightFestUnlockSkillNotify>, IBufferMessage
{
	private static readonly MessageParser<FightFestUnlockSkillNotify> _parser = new MessageParser<FightFestUnlockSkillNotify>(() => new FightFestUnlockSkillNotify());

	private UnknownFieldSet _unknownFields;

	public const int OIBHEKADLLOFieldNumber = 5;

	private uint oIBHEKADLLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightFestUnlockSkillNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FightFestUnlockSkillNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIBHEKADLLO
	{
		get
		{
			return oIBHEKADLLO_;
		}
		set
		{
			oIBHEKADLLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestUnlockSkillNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestUnlockSkillNotify(FightFestUnlockSkillNotify other)
		: this()
	{
		oIBHEKADLLO_ = other.oIBHEKADLLO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestUnlockSkillNotify Clone()
	{
		return new FightFestUnlockSkillNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FightFestUnlockSkillNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightFestUnlockSkillNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OIBHEKADLLO != other.OIBHEKADLLO)
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
		if (OIBHEKADLLO != 0)
		{
			num ^= OIBHEKADLLO.GetHashCode();
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
		if (OIBHEKADLLO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OIBHEKADLLO);
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
		if (OIBHEKADLLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIBHEKADLLO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightFestUnlockSkillNotify other)
	{
		if (other != null)
		{
			if (other.OIBHEKADLLO != 0)
			{
				OIBHEKADLLO = other.OIBHEKADLLO;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				OIBHEKADLLO = input.ReadUInt32();
			}
		}
	}
}
