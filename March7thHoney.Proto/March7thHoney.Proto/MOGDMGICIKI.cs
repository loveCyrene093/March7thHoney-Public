using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MOGDMGICIKI : IMessage<MOGDMGICIKI>, IMessage, IEquatable<MOGDMGICIKI>, IDeepCloneable<MOGDMGICIKI>, IBufferMessage
{
	private static readonly MessageParser<MOGDMGICIKI> _parser = new MessageParser<MOGDMGICIKI>(() => new MOGDMGICIKI());

	private UnknownFieldSet _unknownFields;

	public const int CHDPNCOHAGHFieldNumber = 1;

	private uint cHDPNCOHAGH_;

	public const int HHOHNCNFAEDFieldNumber = 2;

	private static readonly FieldCodec<MJLLPAAOPMP> _repeated_hHOHNCNFAED_codec = FieldCodec.ForMessage(18u, MJLLPAAOPMP.Parser);

	private readonly RepeatedField<MJLLPAAOPMP> hHOHNCNFAED_ = new RepeatedField<MJLLPAAOPMP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MOGDMGICIKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MOGDMGICIKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHDPNCOHAGH
	{
		get
		{
			return cHDPNCOHAGH_;
		}
		set
		{
			cHDPNCOHAGH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MJLLPAAOPMP> HHOHNCNFAED => hHOHNCNFAED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOGDMGICIKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOGDMGICIKI(MOGDMGICIKI other)
		: this()
	{
		cHDPNCOHAGH_ = other.cHDPNCOHAGH_;
		hHOHNCNFAED_ = other.hHOHNCNFAED_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOGDMGICIKI Clone()
	{
		return new MOGDMGICIKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MOGDMGICIKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MOGDMGICIKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHDPNCOHAGH != other.CHDPNCOHAGH)
		{
			return false;
		}
		if (!hHOHNCNFAED_.Equals(other.hHOHNCNFAED_))
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
		if (CHDPNCOHAGH != 0)
		{
			num ^= CHDPNCOHAGH.GetHashCode();
		}
		num ^= hHOHNCNFAED_.GetHashCode();
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
		if (CHDPNCOHAGH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CHDPNCOHAGH);
		}
		hHOHNCNFAED_.WriteTo(ref output, _repeated_hHOHNCNFAED_codec);
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
		if (CHDPNCOHAGH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHDPNCOHAGH);
		}
		num += hHOHNCNFAED_.CalculateSize(_repeated_hHOHNCNFAED_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MOGDMGICIKI other)
	{
		if (other != null)
		{
			if (other.CHDPNCOHAGH != 0)
			{
				CHDPNCOHAGH = other.CHDPNCOHAGH;
			}
			hHOHNCNFAED_.Add(other.hHOHNCNFAED_);
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
				CHDPNCOHAGH = input.ReadUInt32();
				break;
			case 18u:
				hHOHNCNFAED_.AddEntriesFrom(ref input, _repeated_hHOHNCNFAED_codec);
				break;
			}
		}
	}
}
