using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class QueryProductInfoScRsp : IMessage<QueryProductInfoScRsp>, IMessage, IEquatable<QueryProductInfoScRsp>, IDeepCloneable<QueryProductInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<QueryProductInfoScRsp> _parser = new MessageParser<QueryProductInfoScRsp>(() => new QueryProductInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MonthCardOutDateTimeFieldNumber = 6;

	private ulong monthCardOutDateTime_;

	public const int ProductListFieldNumber = 8;

	private static readonly FieldCodec<Product> _repeated_productList_codec = FieldCodec.ForMessage(66u, Product.Parser);

	private readonly RepeatedField<Product> productList_ = new RepeatedField<Product>();

	public const int IFKKKLCFOBKFieldNumber = 10;

	private uint iFKKKLCFOBK_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int BAMOOGPNJEHFieldNumber = 15;

	private uint bAMOOGPNJEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QueryProductInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QueryProductInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong MonthCardOutDateTime
	{
		get
		{
			return monthCardOutDateTime_;
		}
		set
		{
			monthCardOutDateTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Product> ProductList => productList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IFKKKLCFOBK
	{
		get
		{
			return iFKKKLCFOBK_;
		}
		set
		{
			iFKKKLCFOBK_ = value;
		}
	}

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
	public uint BAMOOGPNJEH
	{
		get
		{
			return bAMOOGPNJEH_;
		}
		set
		{
			bAMOOGPNJEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QueryProductInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QueryProductInfoScRsp(QueryProductInfoScRsp other)
		: this()
	{
		monthCardOutDateTime_ = other.monthCardOutDateTime_;
		productList_ = other.productList_.Clone();
		iFKKKLCFOBK_ = other.iFKKKLCFOBK_;
		retcode_ = other.retcode_;
		bAMOOGPNJEH_ = other.bAMOOGPNJEH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QueryProductInfoScRsp Clone()
	{
		return new QueryProductInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QueryProductInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QueryProductInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MonthCardOutDateTime != other.MonthCardOutDateTime)
		{
			return false;
		}
		if (!productList_.Equals(other.productList_))
		{
			return false;
		}
		if (IFKKKLCFOBK != other.IFKKKLCFOBK)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (BAMOOGPNJEH != other.BAMOOGPNJEH)
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
		if (MonthCardOutDateTime != 0L)
		{
			num ^= MonthCardOutDateTime.GetHashCode();
		}
		num ^= productList_.GetHashCode();
		if (IFKKKLCFOBK != 0)
		{
			num ^= IFKKKLCFOBK.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (BAMOOGPNJEH != 0)
		{
			num ^= BAMOOGPNJEH.GetHashCode();
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
		if (MonthCardOutDateTime != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(MonthCardOutDateTime);
		}
		productList_.WriteTo(ref output, _repeated_productList_codec);
		if (IFKKKLCFOBK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IFKKKLCFOBK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (BAMOOGPNJEH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BAMOOGPNJEH);
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
		if (MonthCardOutDateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MonthCardOutDateTime);
		}
		num += productList_.CalculateSize(_repeated_productList_codec);
		if (IFKKKLCFOBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IFKKKLCFOBK);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (BAMOOGPNJEH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BAMOOGPNJEH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QueryProductInfoScRsp other)
	{
		if (other != null)
		{
			if (other.MonthCardOutDateTime != 0L)
			{
				MonthCardOutDateTime = other.MonthCardOutDateTime;
			}
			productList_.Add(other.productList_);
			if (other.IFKKKLCFOBK != 0)
			{
				IFKKKLCFOBK = other.IFKKKLCFOBK;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.BAMOOGPNJEH != 0)
			{
				BAMOOGPNJEH = other.BAMOOGPNJEH;
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
				MonthCardOutDateTime = input.ReadUInt64();
				break;
			case 66u:
				productList_.AddEntriesFrom(ref input, _repeated_productList_codec);
				break;
			case 80u:
				IFKKKLCFOBK = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				BAMOOGPNJEH = input.ReadUInt32();
				break;
			}
		}
	}
}
