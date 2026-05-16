using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ICHNLLCNBCC : IMessage<ICHNLLCNBCC>, IMessage, IEquatable<ICHNLLCNBCC>, IDeepCloneable<ICHNLLCNBCC>, IBufferMessage
{
	private static readonly MessageParser<ICHNLLCNBCC> _parser = new MessageParser<ICHNLLCNBCC>(() => new ICHNLLCNBCC());

	private UnknownFieldSet _unknownFields;

	public const int AFEJACMLOLHFieldNumber = 1;

	private static readonly FieldCodec<NPLEDHFMFDM> _repeated_aFEJACMLOLH_codec = FieldCodec.ForMessage(10u, NPLEDHFMFDM.Parser);

	private readonly RepeatedField<NPLEDHFMFDM> aFEJACMLOLH_ = new RepeatedField<NPLEDHFMFDM>();

	public const int GJGAGFEJABCFieldNumber = 2;

	private uint gJGAGFEJABC_;

	public const int DHLGCEGONIBFieldNumber = 3;

	private long dHLGCEGONIB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ICHNLLCNBCC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ICHNLLCNBCCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NPLEDHFMFDM> AFEJACMLOLH => aFEJACMLOLH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJGAGFEJABC
	{
		get
		{
			return gJGAGFEJABC_;
		}
		set
		{
			gJGAGFEJABC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DHLGCEGONIB
	{
		get
		{
			return dHLGCEGONIB_;
		}
		set
		{
			dHLGCEGONIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHNLLCNBCC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHNLLCNBCC(ICHNLLCNBCC other)
		: this()
	{
		aFEJACMLOLH_ = other.aFEJACMLOLH_.Clone();
		gJGAGFEJABC_ = other.gJGAGFEJABC_;
		dHLGCEGONIB_ = other.dHLGCEGONIB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHNLLCNBCC Clone()
	{
		return new ICHNLLCNBCC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ICHNLLCNBCC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ICHNLLCNBCC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aFEJACMLOLH_.Equals(other.aFEJACMLOLH_))
		{
			return false;
		}
		if (GJGAGFEJABC != other.GJGAGFEJABC)
		{
			return false;
		}
		if (DHLGCEGONIB != other.DHLGCEGONIB)
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
		num ^= aFEJACMLOLH_.GetHashCode();
		if (GJGAGFEJABC != 0)
		{
			num ^= GJGAGFEJABC.GetHashCode();
		}
		if (DHLGCEGONIB != 0L)
		{
			num ^= DHLGCEGONIB.GetHashCode();
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
		aFEJACMLOLH_.WriteTo(ref output, _repeated_aFEJACMLOLH_codec);
		if (GJGAGFEJABC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GJGAGFEJABC);
		}
		if (DHLGCEGONIB != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(DHLGCEGONIB);
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
		num += aFEJACMLOLH_.CalculateSize(_repeated_aFEJACMLOLH_codec);
		if (GJGAGFEJABC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJGAGFEJABC);
		}
		if (DHLGCEGONIB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DHLGCEGONIB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ICHNLLCNBCC other)
	{
		if (other != null)
		{
			aFEJACMLOLH_.Add(other.aFEJACMLOLH_);
			if (other.GJGAGFEJABC != 0)
			{
				GJGAGFEJABC = other.GJGAGFEJABC;
			}
			if (other.DHLGCEGONIB != 0L)
			{
				DHLGCEGONIB = other.DHLGCEGONIB;
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
			case 10u:
				aFEJACMLOLH_.AddEntriesFrom(ref input, _repeated_aFEJACMLOLH_codec);
				break;
			case 16u:
				GJGAGFEJABC = input.ReadUInt32();
				break;
			case 24u:
				DHLGCEGONIB = input.ReadInt64();
				break;
			}
		}
	}
}
