using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APHOLANKEPN : IMessage<APHOLANKEPN>, IMessage, IEquatable<APHOLANKEPN>, IDeepCloneable<APHOLANKEPN>, IBufferMessage
{
	private static readonly MessageParser<APHOLANKEPN> _parser = new MessageParser<APHOLANKEPN>(() => new APHOLANKEPN());

	private UnknownFieldSet _unknownFields;

	public const int FBNIOHPDCILFieldNumber = 6;

	private uint fBNIOHPDCIL_;

	public const int NumFieldNumber = 12;

	private uint num_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APHOLANKEPN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APHOLANKEPNReflection.Descriptor.MessageTypes[0];

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
	public APHOLANKEPN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APHOLANKEPN(APHOLANKEPN other)
		: this()
	{
		fBNIOHPDCIL_ = other.fBNIOHPDCIL_;
		num_ = other.num_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APHOLANKEPN Clone()
	{
		return new APHOLANKEPN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APHOLANKEPN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APHOLANKEPN other)
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
			output.WriteRawTag(48);
			output.WriteUInt32(FBNIOHPDCIL);
		}
		if (Num != 0)
		{
			output.WriteRawTag(96);
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
	public void MergeFrom(APHOLANKEPN other)
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
			case 48u:
				FBNIOHPDCIL = input.ReadUInt32();
				break;
			case 96u:
				Num = input.ReadUInt32();
				break;
			}
		}
	}
}
