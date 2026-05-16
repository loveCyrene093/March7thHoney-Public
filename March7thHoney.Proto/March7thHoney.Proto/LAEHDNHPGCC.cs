using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LAEHDNHPGCC : IMessage<LAEHDNHPGCC>, IMessage, IEquatable<LAEHDNHPGCC>, IDeepCloneable<LAEHDNHPGCC>, IBufferMessage
{
	private static readonly MessageParser<LAEHDNHPGCC> _parser = new MessageParser<LAEHDNHPGCC>(() => new LAEHDNHPGCC());

	private UnknownFieldSet _unknownFields;

	public const int FBNIOHPDCILFieldNumber = 3;

	private uint fBNIOHPDCIL_;

	public const int NumFieldNumber = 11;

	private uint num_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LAEHDNHPGCC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LAEHDNHPGCCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBNIOHPDCIL
	{
		get
		{
			return fBNIOHPDCIL_;
		}
		set
		{
			fBNIOHPDCIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAEHDNHPGCC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAEHDNHPGCC(LAEHDNHPGCC other)
		: this()
	{
		fBNIOHPDCIL_ = other.fBNIOHPDCIL_;
		num_ = other.num_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAEHDNHPGCC Clone()
	{
		return new LAEHDNHPGCC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LAEHDNHPGCC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LAEHDNHPGCC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FBNIOHPDCIL != other.FBNIOHPDCIL)
		{
			return false;
		}
		if (Num != other.Num)
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
		if (FBNIOHPDCIL != 0)
		{
			num ^= FBNIOHPDCIL.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
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
		if (FBNIOHPDCIL != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FBNIOHPDCIL);
		}
		if (Num != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Num);
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
		if (FBNIOHPDCIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBNIOHPDCIL);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LAEHDNHPGCC other)
	{
		if (other != null)
		{
			if (other.FBNIOHPDCIL != 0)
			{
				FBNIOHPDCIL = other.FBNIOHPDCIL;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
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
				FBNIOHPDCIL = input.ReadUInt32();
				break;
			case 88u:
				Num = input.ReadUInt32();
				break;
			}
		}
	}
}
