using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateShopRefreshGoodsScRsp : IMessage<FateShopRefreshGoodsScRsp>, IMessage, IEquatable<FateShopRefreshGoodsScRsp>, IDeepCloneable<FateShopRefreshGoodsScRsp>, IBufferMessage
{
	private static readonly MessageParser<FateShopRefreshGoodsScRsp> _parser = new MessageParser<FateShopRefreshGoodsScRsp>(() => new FateShopRefreshGoodsScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EBKLPKNANLNFieldNumber = 2;

	private bool eBKLPKNANLN_;

	public const int ShopGoodsListFieldNumber = 11;

	private static readonly FieldCodec<JCFDCEKLBFH> _repeated_shopGoodsList_codec = FieldCodec.ForMessage(90u, JCFDCEKLBFH.Parser);

	private readonly RepeatedField<JCFDCEKLBFH> shopGoodsList_ = new RepeatedField<JCFDCEKLBFH>();

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateShopRefreshGoodsScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateShopRefreshGoodsScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EBKLPKNANLN
	{
		get
		{
			return eBKLPKNANLN_;
		}
		set
		{
			eBKLPKNANLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCFDCEKLBFH> ShopGoodsList => shopGoodsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopRefreshGoodsScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopRefreshGoodsScRsp(FateShopRefreshGoodsScRsp other)
		: this()
	{
		eBKLPKNANLN_ = other.eBKLPKNANLN_;
		shopGoodsList_ = other.shopGoodsList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopRefreshGoodsScRsp Clone()
	{
		return new FateShopRefreshGoodsScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateShopRefreshGoodsScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateShopRefreshGoodsScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EBKLPKNANLN != other.EBKLPKNANLN)
		{
			return false;
		}
		if (!shopGoodsList_.Equals(other.shopGoodsList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (EBKLPKNANLN)
		{
			num ^= EBKLPKNANLN.GetHashCode();
		}
		num ^= shopGoodsList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (EBKLPKNANLN)
		{
			output.WriteRawTag(16);
			output.WriteBool(EBKLPKNANLN);
		}
		shopGoodsList_.WriteTo(ref output, _repeated_shopGoodsList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
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
		if (EBKLPKNANLN)
		{
			num += 2;
		}
		num += shopGoodsList_.CalculateSize(_repeated_shopGoodsList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateShopRefreshGoodsScRsp other)
	{
		if (other != null)
		{
			if (other.EBKLPKNANLN)
			{
				EBKLPKNANLN = other.EBKLPKNANLN;
			}
			shopGoodsList_.Add(other.shopGoodsList_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				EBKLPKNANLN = input.ReadBool();
				break;
			case 90u:
				shopGoodsList_.AddEntriesFrom(ref input, _repeated_shopGoodsList_codec);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
