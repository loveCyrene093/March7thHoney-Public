using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNMBIPOPOFH : IMessage<CNMBIPOPOFH>, IMessage, IEquatable<CNMBIPOPOFH>, IDeepCloneable<CNMBIPOPOFH>, IBufferMessage
{
	private static readonly MessageParser<CNMBIPOPOFH> _parser = new MessageParser<CNMBIPOPOFH>(() => new CNMBIPOPOFH());

	private UnknownFieldSet _unknownFields;

	public const int FPFIHHBNBANFieldNumber = 3;

	private uint fPFIHHBNBAN_;

	public const int GDNPJLLOHEEFieldNumber = 13;

	private uint gDNPJLLOHEE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNMBIPOPOFH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNMBIPOPOFHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPFIHHBNBAN
	{
		get
		{
			return fPFIHHBNBAN_;
		}
		set
		{
			fPFIHHBNBAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDNPJLLOHEE
	{
		get
		{
			return gDNPJLLOHEE_;
		}
		set
		{
			gDNPJLLOHEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNMBIPOPOFH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNMBIPOPOFH(CNMBIPOPOFH other)
		: this()
	{
		fPFIHHBNBAN_ = other.fPFIHHBNBAN_;
		gDNPJLLOHEE_ = other.gDNPJLLOHEE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNMBIPOPOFH Clone()
	{
		return new CNMBIPOPOFH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNMBIPOPOFH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNMBIPOPOFH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FPFIHHBNBAN != other.FPFIHHBNBAN)
		{
			return false;
		}
		if (GDNPJLLOHEE != other.GDNPJLLOHEE)
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
		if (FPFIHHBNBAN != 0)
		{
			num ^= FPFIHHBNBAN.GetHashCode();
		}
		if (GDNPJLLOHEE != 0)
		{
			num ^= GDNPJLLOHEE.GetHashCode();
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
		if (FPFIHHBNBAN != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FPFIHHBNBAN);
		}
		if (GDNPJLLOHEE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GDNPJLLOHEE);
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
		if (FPFIHHBNBAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPFIHHBNBAN);
		}
		if (GDNPJLLOHEE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDNPJLLOHEE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNMBIPOPOFH other)
	{
		if (other != null)
		{
			if (other.FPFIHHBNBAN != 0)
			{
				FPFIHHBNBAN = other.FPFIHHBNBAN;
			}
			if (other.GDNPJLLOHEE != 0)
			{
				GDNPJLLOHEE = other.GDNPJLLOHEE;
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
				FPFIHHBNBAN = input.ReadUInt32();
				break;
			case 104u:
				GDNPJLLOHEE = input.ReadUInt32();
				break;
			}
		}
	}
}
