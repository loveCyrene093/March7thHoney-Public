using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelShopBuyChimeraCsReq : IMessage<ChimeraDuelShopBuyChimeraCsReq>, IMessage, IEquatable<ChimeraDuelShopBuyChimeraCsReq>, IDeepCloneable<ChimeraDuelShopBuyChimeraCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelShopBuyChimeraCsReq> _parser = new MessageParser<ChimeraDuelShopBuyChimeraCsReq>(() => new ChimeraDuelShopBuyChimeraCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LNBILCHBHADFieldNumber = 2;

	private uint lNBILCHBHAD_;

	public const int AICHBBIODJCFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_aICHBBIODJC_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> aICHBBIODJC_ = new RepeatedField<uint>();

	public const int FJGLPCIJICJFieldNumber = 8;

	private uint fJGLPCIJICJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelShopBuyChimeraCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelShopBuyChimeraCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LNBILCHBHAD
	{
		get
		{
			return lNBILCHBHAD_;
		}
		set
		{
			lNBILCHBHAD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AICHBBIODJC => aICHBBIODJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJGLPCIJICJ
	{
		get
		{
			return fJGLPCIJICJ_;
		}
		set
		{
			fJGLPCIJICJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopBuyChimeraCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopBuyChimeraCsReq(ChimeraDuelShopBuyChimeraCsReq other)
		: this()
	{
		lNBILCHBHAD_ = other.lNBILCHBHAD_;
		aICHBBIODJC_ = other.aICHBBIODJC_.Clone();
		fJGLPCIJICJ_ = other.fJGLPCIJICJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopBuyChimeraCsReq Clone()
	{
		return new ChimeraDuelShopBuyChimeraCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelShopBuyChimeraCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelShopBuyChimeraCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LNBILCHBHAD != other.LNBILCHBHAD)
		{
			return false;
		}
		if (!aICHBBIODJC_.Equals(other.aICHBBIODJC_))
		{
			return false;
		}
		if (FJGLPCIJICJ != other.FJGLPCIJICJ)
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
		if (LNBILCHBHAD != 0)
		{
			num ^= LNBILCHBHAD.GetHashCode();
		}
		num ^= aICHBBIODJC_.GetHashCode();
		if (FJGLPCIJICJ != 0)
		{
			num ^= FJGLPCIJICJ.GetHashCode();
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
		if (LNBILCHBHAD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LNBILCHBHAD);
		}
		aICHBBIODJC_.WriteTo(ref output, _repeated_aICHBBIODJC_codec);
		if (FJGLPCIJICJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FJGLPCIJICJ);
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
		if (LNBILCHBHAD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNBILCHBHAD);
		}
		num += aICHBBIODJC_.CalculateSize(_repeated_aICHBBIODJC_codec);
		if (FJGLPCIJICJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJGLPCIJICJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelShopBuyChimeraCsReq other)
	{
		if (other != null)
		{
			if (other.LNBILCHBHAD != 0)
			{
				LNBILCHBHAD = other.LNBILCHBHAD;
			}
			aICHBBIODJC_.Add(other.aICHBBIODJC_);
			if (other.FJGLPCIJICJ != 0)
			{
				FJGLPCIJICJ = other.FJGLPCIJICJ;
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
				LNBILCHBHAD = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				aICHBBIODJC_.AddEntriesFrom(ref input, _repeated_aICHBBIODJC_codec);
				break;
			case 64u:
				FJGLPCIJICJ = input.ReadUInt32();
				break;
			}
		}
	}
}
