using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingBuyShopItemCsReq : IMessage<ChenLingBuyShopItemCsReq>, IMessage, IEquatable<ChenLingBuyShopItemCsReq>, IDeepCloneable<ChenLingBuyShopItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingBuyShopItemCsReq> _parser = new MessageParser<ChenLingBuyShopItemCsReq>(() => new ChenLingBuyShopItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AOAANEOMOOOFieldNumber = 3;

	private uint aOAANEOMOOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingBuyShopItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingBuyShopItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOAANEOMOOO
	{
		get
		{
			return aOAANEOMOOO_;
		}
		set
		{
			aOAANEOMOOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingBuyShopItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingBuyShopItemCsReq(ChenLingBuyShopItemCsReq other)
		: this()
	{
		aOAANEOMOOO_ = other.aOAANEOMOOO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingBuyShopItemCsReq Clone()
	{
		return new ChenLingBuyShopItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingBuyShopItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingBuyShopItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOAANEOMOOO != other.AOAANEOMOOO)
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
		if (AOAANEOMOOO != 0)
		{
			num ^= AOAANEOMOOO.GetHashCode();
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
		if (AOAANEOMOOO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AOAANEOMOOO);
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
		if (AOAANEOMOOO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOAANEOMOOO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingBuyShopItemCsReq other)
	{
		if (other != null)
		{
			if (other.AOAANEOMOOO != 0)
			{
				AOAANEOMOOO = other.AOAANEOMOOO;
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
			if (num != 24)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				AOAANEOMOOO = input.ReadUInt32();
			}
		}
	}
}
