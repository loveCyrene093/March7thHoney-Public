using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NHPKMMDOHIH : IMessage<NHPKMMDOHIH>, IMessage, IEquatable<NHPKMMDOHIH>, IDeepCloneable<NHPKMMDOHIH>, IBufferMessage
{
	private static readonly MessageParser<NHPKMMDOHIH> _parser = new MessageParser<NHPKMMDOHIH>(() => new NHPKMMDOHIH());

	private UnknownFieldSet _unknownFields;

	public const int ShopIdFieldNumber = 3;

	private uint shopId_;

	public const int OFABEGPJBJPFieldNumber = 4;

	private uint oFABEGPJBJP_;

	public const int AAFLJGPKCDHFieldNumber = 8;

	private uint aAFLJGPKCDH_;

	public const int OMGGDMMLBJLFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_oMGGDMMLBJL_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> oMGGDMMLBJL_ = new RepeatedField<uint>();

	public const int NCGEJEEOMFCFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_nCGEJEEOMFC_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> nCGEJEEOMFC_ = new RepeatedField<uint>();

	public const int JDDMHMCHNNNFieldNumber = 13;

	private uint jDDMHMCHNNN_;

	public const int ShopGoodsListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_shopGoodsList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> shopGoodsList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NHPKMMDOHIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NHPKMMDOHIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFABEGPJBJP
	{
		get
		{
			return oFABEGPJBJP_;
		}
		set
		{
			oFABEGPJBJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAFLJGPKCDH
	{
		get
		{
			return aAFLJGPKCDH_;
		}
		set
		{
			aAFLJGPKCDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OMGGDMMLBJL => oMGGDMMLBJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NCGEJEEOMFC => nCGEJEEOMFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JDDMHMCHNNN
	{
		get
		{
			return jDDMHMCHNNN_;
		}
		set
		{
			jDDMHMCHNNN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ShopGoodsList => shopGoodsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHPKMMDOHIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHPKMMDOHIH(NHPKMMDOHIH other)
		: this()
	{
		shopId_ = other.shopId_;
		oFABEGPJBJP_ = other.oFABEGPJBJP_;
		aAFLJGPKCDH_ = other.aAFLJGPKCDH_;
		oMGGDMMLBJL_ = other.oMGGDMMLBJL_.Clone();
		nCGEJEEOMFC_ = other.nCGEJEEOMFC_.Clone();
		jDDMHMCHNNN_ = other.jDDMHMCHNNN_;
		shopGoodsList_ = other.shopGoodsList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHPKMMDOHIH Clone()
	{
		return new NHPKMMDOHIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NHPKMMDOHIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NHPKMMDOHIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShopId != other.ShopId)
		{
			return false;
		}
		if (OFABEGPJBJP != other.OFABEGPJBJP)
		{
			return false;
		}
		if (AAFLJGPKCDH != other.AAFLJGPKCDH)
		{
			return false;
		}
		if (!oMGGDMMLBJL_.Equals(other.oMGGDMMLBJL_))
		{
			return false;
		}
		if (!nCGEJEEOMFC_.Equals(other.nCGEJEEOMFC_))
		{
			return false;
		}
		if (JDDMHMCHNNN != other.JDDMHMCHNNN)
		{
			return false;
		}
		if (!shopGoodsList_.Equals(other.shopGoodsList_))
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
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
		}
		if (OFABEGPJBJP != 0)
		{
			num ^= OFABEGPJBJP.GetHashCode();
		}
		if (AAFLJGPKCDH != 0)
		{
			num ^= AAFLJGPKCDH.GetHashCode();
		}
		num ^= oMGGDMMLBJL_.GetHashCode();
		num ^= nCGEJEEOMFC_.GetHashCode();
		if (JDDMHMCHNNN != 0)
		{
			num ^= JDDMHMCHNNN.GetHashCode();
		}
		num ^= shopGoodsList_.GetHashCode();
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
		if (ShopId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ShopId);
		}
		if (OFABEGPJBJP != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OFABEGPJBJP);
		}
		if (AAFLJGPKCDH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AAFLJGPKCDH);
		}
		oMGGDMMLBJL_.WriteTo(ref output, _repeated_oMGGDMMLBJL_codec);
		nCGEJEEOMFC_.WriteTo(ref output, _repeated_nCGEJEEOMFC_codec);
		if (JDDMHMCHNNN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JDDMHMCHNNN);
		}
		shopGoodsList_.WriteTo(ref output, _repeated_shopGoodsList_codec);
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
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopId);
		}
		if (OFABEGPJBJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFABEGPJBJP);
		}
		if (AAFLJGPKCDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAFLJGPKCDH);
		}
		num += oMGGDMMLBJL_.CalculateSize(_repeated_oMGGDMMLBJL_codec);
		num += nCGEJEEOMFC_.CalculateSize(_repeated_nCGEJEEOMFC_codec);
		if (JDDMHMCHNNN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JDDMHMCHNNN);
		}
		num += shopGoodsList_.CalculateSize(_repeated_shopGoodsList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NHPKMMDOHIH other)
	{
		if (other != null)
		{
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			if (other.OFABEGPJBJP != 0)
			{
				OFABEGPJBJP = other.OFABEGPJBJP;
			}
			if (other.AAFLJGPKCDH != 0)
			{
				AAFLJGPKCDH = other.AAFLJGPKCDH;
			}
			oMGGDMMLBJL_.Add(other.oMGGDMMLBJL_);
			nCGEJEEOMFC_.Add(other.nCGEJEEOMFC_);
			if (other.JDDMHMCHNNN != 0)
			{
				JDDMHMCHNNN = other.JDDMHMCHNNN;
			}
			shopGoodsList_.Add(other.shopGoodsList_);
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
				ShopId = input.ReadUInt32();
				break;
			case 32u:
				OFABEGPJBJP = input.ReadUInt32();
				break;
			case 64u:
				AAFLJGPKCDH = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				oMGGDMMLBJL_.AddEntriesFrom(ref input, _repeated_oMGGDMMLBJL_codec);
				break;
			case 88u:
			case 90u:
				nCGEJEEOMFC_.AddEntriesFrom(ref input, _repeated_nCGEJEEOMFC_codec);
				break;
			case 104u:
				JDDMHMCHNNN = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				shopGoodsList_.AddEntriesFrom(ref input, _repeated_shopGoodsList_codec);
				break;
			}
		}
	}
}
