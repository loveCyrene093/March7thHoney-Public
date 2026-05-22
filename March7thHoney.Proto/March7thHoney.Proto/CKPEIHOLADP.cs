using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CKPEIHOLADP : IMessage<CKPEIHOLADP>, IMessage, IEquatable<CKPEIHOLADP>, IDeepCloneable<CKPEIHOLADP>, IBufferMessage
{
	private static readonly MessageParser<CKPEIHOLADP> _parser = new MessageParser<CKPEIHOLADP>(() => new CKPEIHOLADP());

	private UnknownFieldSet _unknownFields;

	public const int KBMMGOJKAPFFieldNumber = 11;

	private uint kBMMGOJKAPF_;

	public const int LevelFieldNumber = 15;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CKPEIHOLADP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CKPEIHOLADPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBMMGOJKAPF
	{
		get
		{
			return kBMMGOJKAPF_;
		}
		set
		{
			kBMMGOJKAPF_ = value;
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
	public CKPEIHOLADP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKPEIHOLADP(CKPEIHOLADP other)
		: this()
	{
		kBMMGOJKAPF_ = other.kBMMGOJKAPF_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKPEIHOLADP Clone()
	{
		return new CKPEIHOLADP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CKPEIHOLADP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CKPEIHOLADP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBMMGOJKAPF != other.KBMMGOJKAPF)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (KBMMGOJKAPF != 0)
		{
			num ^= KBMMGOJKAPF.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (KBMMGOJKAPF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KBMMGOJKAPF);
		}
		if (Level != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Level);
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
		if (KBMMGOJKAPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBMMGOJKAPF);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CKPEIHOLADP other)
	{
		if (other != null)
		{
			if (other.KBMMGOJKAPF != 0)
			{
				KBMMGOJKAPF = other.KBMMGOJKAPF;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 88u:
				KBMMGOJKAPF = input.ReadUInt32();
				break;
			case 120u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
