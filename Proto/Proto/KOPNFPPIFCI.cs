using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KOPNFPPIFCI : IMessage<KOPNFPPIFCI>, IMessage, IEquatable<KOPNFPPIFCI>, IDeepCloneable<KOPNFPPIFCI>, IBufferMessage
{
	private static readonly MessageParser<KOPNFPPIFCI> _parser = new MessageParser<KOPNFPPIFCI>(() => new KOPNFPPIFCI());

	private UnknownFieldSet _unknownFields;

	public const int PIACACNNBNHFieldNumber = 2;

	private uint pIACACNNBNH_;

	public const int ICOGAHFFCLDFieldNumber = 15;

	private bool iCOGAHFFCLD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KOPNFPPIFCI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KOPNFPPIFCIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PIACACNNBNH
	{
		get
		{
			return pIACACNNBNH_;
		}
		set
		{
			pIACACNNBNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICOGAHFFCLD
	{
		get
		{
			return iCOGAHFFCLD_;
		}
		set
		{
			iCOGAHFFCLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOPNFPPIFCI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOPNFPPIFCI(KOPNFPPIFCI other)
		: this()
	{
		pIACACNNBNH_ = other.pIACACNNBNH_;
		iCOGAHFFCLD_ = other.iCOGAHFFCLD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOPNFPPIFCI Clone()
	{
		return new KOPNFPPIFCI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KOPNFPPIFCI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KOPNFPPIFCI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PIACACNNBNH != other.PIACACNNBNH)
		{
			return false;
		}
		if (ICOGAHFFCLD != other.ICOGAHFFCLD)
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
		if (PIACACNNBNH != 0)
		{
			num ^= PIACACNNBNH.GetHashCode();
		}
		if (ICOGAHFFCLD)
		{
			num ^= ICOGAHFFCLD.GetHashCode();
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
		if (PIACACNNBNH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PIACACNNBNH);
		}
		if (ICOGAHFFCLD)
		{
			output.WriteRawTag(120);
			output.WriteBool(ICOGAHFFCLD);
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
		if (PIACACNNBNH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PIACACNNBNH);
		}
		if (ICOGAHFFCLD)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KOPNFPPIFCI other)
	{
		if (other != null)
		{
			if (other.PIACACNNBNH != 0)
			{
				PIACACNNBNH = other.PIACACNNBNH;
			}
			if (other.ICOGAHFFCLD)
			{
				ICOGAHFFCLD = other.ICOGAHFFCLD;
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
			case 16u:
				PIACACNNBNH = input.ReadUInt32();
				break;
			case 120u:
				ICOGAHFFCLD = input.ReadBool();
				break;
			}
		}
	}
}
