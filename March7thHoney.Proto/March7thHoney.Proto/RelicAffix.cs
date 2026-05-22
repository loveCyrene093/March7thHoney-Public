using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicAffix : IMessage<RelicAffix>, IMessage, IEquatable<RelicAffix>, IDeepCloneable<RelicAffix>, IBufferMessage
{
	private static readonly MessageParser<RelicAffix> _parser = new MessageParser<RelicAffix>(() => new RelicAffix());

	private UnknownFieldSet _unknownFields;

	public const int AffixIdFieldNumber = 1;

	private uint affixId_;

	public const int CntFieldNumber = 2;

	private uint cnt_;

	public const int StepFieldNumber = 3;

	private uint step_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicAffix> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicAffixReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AffixId
	{
		get
		{
			return affixId_;
		}
		set
		{
			affixId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Cnt
	{
		get
		{
			return cnt_;
		}
		set
		{
			cnt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Step
	{
		get
		{
			return step_;
		}
		set
		{
			step_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicAffix()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicAffix(RelicAffix other)
		: this()
	{
		affixId_ = other.affixId_;
		cnt_ = other.cnt_;
		step_ = other.step_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicAffix Clone()
	{
		return new RelicAffix(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicAffix);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicAffix other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AffixId != other.AffixId)
		{
			return false;
		}
		if (Cnt != other.Cnt)
		{
			return false;
		}
		if (Step != other.Step)
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
		if (AffixId != 0)
		{
			num ^= AffixId.GetHashCode();
		}
		if (Cnt != 0)
		{
			num ^= Cnt.GetHashCode();
		}
		if (Step != 0)
		{
			num ^= Step.GetHashCode();
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
		if (AffixId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AffixId);
		}
		if (Cnt != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Cnt);
		}
		if (Step != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Step);
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
		if (AffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AffixId);
		}
		if (Cnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Cnt);
		}
		if (Step != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Step);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicAffix other)
	{
		if (other != null)
		{
			if (other.AffixId != 0)
			{
				AffixId = other.AffixId;
			}
			if (other.Cnt != 0)
			{
				Cnt = other.Cnt;
			}
			if (other.Step != 0)
			{
				Step = other.Step;
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
				AffixId = input.ReadUInt32();
				break;
			case 16u:
				Cnt = input.ReadUInt32();
				break;
			case 24u:
				Step = input.ReadUInt32();
				break;
			}
		}
	}
}
