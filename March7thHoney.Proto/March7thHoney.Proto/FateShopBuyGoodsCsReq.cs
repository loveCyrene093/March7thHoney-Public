using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateShopBuyGoodsCsReq : IMessage<FateShopBuyGoodsCsReq>, IMessage, IEquatable<FateShopBuyGoodsCsReq>, IDeepCloneable<FateShopBuyGoodsCsReq>, IBufferMessage
{
	private static readonly MessageParser<FateShopBuyGoodsCsReq> _parser = new MessageParser<FateShopBuyGoodsCsReq>(() => new FateShopBuyGoodsCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CAPNNEGFGBPFieldNumber = 13;

	private uint cAPNNEGFGBP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateShopBuyGoodsCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateShopBuyGoodsCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CAPNNEGFGBP
	{
		get
		{
			return cAPNNEGFGBP_;
		}
		set
		{
			cAPNNEGFGBP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopBuyGoodsCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopBuyGoodsCsReq(FateShopBuyGoodsCsReq other)
		: this()
	{
		cAPNNEGFGBP_ = other.cAPNNEGFGBP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopBuyGoodsCsReq Clone()
	{
		return new FateShopBuyGoodsCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateShopBuyGoodsCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateShopBuyGoodsCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CAPNNEGFGBP != other.CAPNNEGFGBP)
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
		if (CAPNNEGFGBP != 0)
		{
			num ^= CAPNNEGFGBP.GetHashCode();
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
		if (CAPNNEGFGBP != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CAPNNEGFGBP);
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
		if (CAPNNEGFGBP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CAPNNEGFGBP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateShopBuyGoodsCsReq other)
	{
		if (other != null)
		{
			if (other.CAPNNEGFGBP != 0)
			{
				CAPNNEGFGBP = other.CAPNNEGFGBP;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CAPNNEGFGBP = input.ReadUInt32();
			}
		}
	}
}
