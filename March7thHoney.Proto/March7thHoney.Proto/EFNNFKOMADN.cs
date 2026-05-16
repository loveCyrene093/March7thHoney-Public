using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EFNNFKOMADN : IMessage<EFNNFKOMADN>, IMessage, IEquatable<EFNNFKOMADN>, IDeepCloneable<EFNNFKOMADN>, IBufferMessage
{
	private static readonly MessageParser<EFNNFKOMADN> _parser = new MessageParser<EFNNFKOMADN>(() => new EFNNFKOMADN());

	private UnknownFieldSet _unknownFields;

	public const int OBAMHCIFFOCFieldNumber = 11;

	private uint oBAMHCIFFOC_;

	public const int ALODJFPDKAMFieldNumber = 15;

	private uint aLODJFPDKAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EFNNFKOMADN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EFNNFKOMADNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OBAMHCIFFOC
	{
		get
		{
			return oBAMHCIFFOC_;
		}
		set
		{
			oBAMHCIFFOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ALODJFPDKAM
	{
		get
		{
			return aLODJFPDKAM_;
		}
		set
		{
			aLODJFPDKAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFNNFKOMADN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFNNFKOMADN(EFNNFKOMADN other)
		: this()
	{
		oBAMHCIFFOC_ = other.oBAMHCIFFOC_;
		aLODJFPDKAM_ = other.aLODJFPDKAM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFNNFKOMADN Clone()
	{
		return new EFNNFKOMADN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EFNNFKOMADN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EFNNFKOMADN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OBAMHCIFFOC != other.OBAMHCIFFOC)
		{
			return false;
		}
		if (ALODJFPDKAM != other.ALODJFPDKAM)
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
		if (OBAMHCIFFOC != 0)
		{
			num ^= OBAMHCIFFOC.GetHashCode();
		}
		if (ALODJFPDKAM != 0)
		{
			num ^= ALODJFPDKAM.GetHashCode();
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
		if (OBAMHCIFFOC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(OBAMHCIFFOC);
		}
		if (ALODJFPDKAM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ALODJFPDKAM);
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
		if (OBAMHCIFFOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OBAMHCIFFOC);
		}
		if (ALODJFPDKAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ALODJFPDKAM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EFNNFKOMADN other)
	{
		if (other != null)
		{
			if (other.OBAMHCIFFOC != 0)
			{
				OBAMHCIFFOC = other.OBAMHCIFFOC;
			}
			if (other.ALODJFPDKAM != 0)
			{
				ALODJFPDKAM = other.ALODJFPDKAM;
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
				OBAMHCIFFOC = input.ReadUInt32();
				break;
			case 120u:
				ALODJFPDKAM = input.ReadUInt32();
				break;
			}
		}
	}
}
