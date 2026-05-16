using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelShopBuyItemCsReq : IMessage<ChimeraDuelShopBuyItemCsReq>, IMessage, IEquatable<ChimeraDuelShopBuyItemCsReq>, IDeepCloneable<ChimeraDuelShopBuyItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelShopBuyItemCsReq> _parser = new MessageParser<ChimeraDuelShopBuyItemCsReq>(() => new ChimeraDuelShopBuyItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GCENPLKCCBAFieldNumber = 3;

	private uint gCENPLKCCBA_;

	public const int HCNKAJNKGFHFieldNumber = 10;

	private uint hCNKAJNKGFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelShopBuyItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelShopBuyItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCENPLKCCBA
	{
		get
		{
			return gCENPLKCCBA_;
		}
		set
		{
			gCENPLKCCBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCNKAJNKGFH
	{
		get
		{
			return hCNKAJNKGFH_;
		}
		set
		{
			hCNKAJNKGFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopBuyItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopBuyItemCsReq(ChimeraDuelShopBuyItemCsReq other)
		: this()
	{
		gCENPLKCCBA_ = other.gCENPLKCCBA_;
		hCNKAJNKGFH_ = other.hCNKAJNKGFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopBuyItemCsReq Clone()
	{
		return new ChimeraDuelShopBuyItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelShopBuyItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelShopBuyItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GCENPLKCCBA != other.GCENPLKCCBA)
		{
			return false;
		}
		if (HCNKAJNKGFH != other.HCNKAJNKGFH)
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
		if (GCENPLKCCBA != 0)
		{
			num ^= GCENPLKCCBA.GetHashCode();
		}
		if (HCNKAJNKGFH != 0)
		{
			num ^= HCNKAJNKGFH.GetHashCode();
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
		if (GCENPLKCCBA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GCENPLKCCBA);
		}
		if (HCNKAJNKGFH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(HCNKAJNKGFH);
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
		if (GCENPLKCCBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCENPLKCCBA);
		}
		if (HCNKAJNKGFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCNKAJNKGFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelShopBuyItemCsReq other)
	{
		if (other != null)
		{
			if (other.GCENPLKCCBA != 0)
			{
				GCENPLKCCBA = other.GCENPLKCCBA;
			}
			if (other.HCNKAJNKGFH != 0)
			{
				HCNKAJNKGFH = other.HCNKAJNKGFH;
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
			case 24u:
				GCENPLKCCBA = input.ReadUInt32();
				break;
			case 80u:
				HCNKAJNKGFH = input.ReadUInt32();
				break;
			}
		}
	}
}
