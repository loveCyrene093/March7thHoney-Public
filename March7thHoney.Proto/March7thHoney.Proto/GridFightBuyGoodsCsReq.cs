using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightBuyGoodsCsReq : IMessage<GridFightBuyGoodsCsReq>, IMessage, IEquatable<GridFightBuyGoodsCsReq>, IDeepCloneable<GridFightBuyGoodsCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightBuyGoodsCsReq> _parser = new MessageParser<GridFightBuyGoodsCsReq>(() => new GridFightBuyGoodsCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BuyGoodsIndexListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_buyGoodsIndexList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> buyGoodsIndexList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightBuyGoodsCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightBuyGoodsCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BuyGoodsIndexList => buyGoodsIndexList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBuyGoodsCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBuyGoodsCsReq(GridFightBuyGoodsCsReq other)
		: this()
	{
		buyGoodsIndexList_ = other.buyGoodsIndexList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBuyGoodsCsReq Clone()
	{
		return new GridFightBuyGoodsCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightBuyGoodsCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightBuyGoodsCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!buyGoodsIndexList_.Equals(other.buyGoodsIndexList_))
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
		num ^= buyGoodsIndexList_.GetHashCode();
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
		buyGoodsIndexList_.WriteTo(ref output, _repeated_buyGoodsIndexList_codec);
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
		num += buyGoodsIndexList_.CalculateSize(_repeated_buyGoodsIndexList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightBuyGoodsCsReq other)
	{
		if (other != null)
		{
			buyGoodsIndexList_.Add(other.buyGoodsIndexList_);
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
			if (num != 24 && num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				buyGoodsIndexList_.AddEntriesFrom(ref input, _repeated_buyGoodsIndexList_codec);
			}
		}
	}
}
