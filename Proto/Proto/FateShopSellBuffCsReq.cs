using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateShopSellBuffCsReq : IMessage<FateShopSellBuffCsReq>, IMessage, IEquatable<FateShopSellBuffCsReq>, IDeepCloneable<FateShopSellBuffCsReq>, IBufferMessage
{
	private static readonly MessageParser<FateShopSellBuffCsReq> _parser = new MessageParser<FateShopSellBuffCsReq>(() => new FateShopSellBuffCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PHGCDAOHLDAFieldNumber = 4;

	private bool pHGCDAOHLDA_;

	public const int OIBPLMKKGGLFieldNumber = 12;

	private uint oIBPLMKKGGL_;

	public const int NPMAANOOCOJFieldNumber = 13;

	private uint nPMAANOOCOJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateShopSellBuffCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateShopSellBuffCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PHGCDAOHLDA
	{
		get
		{
			return pHGCDAOHLDA_;
		}
		set
		{
			pHGCDAOHLDA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIBPLMKKGGL
	{
		get
		{
			return oIBPLMKKGGL_;
		}
		set
		{
			oIBPLMKKGGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPMAANOOCOJ
	{
		get
		{
			return nPMAANOOCOJ_;
		}
		set
		{
			nPMAANOOCOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopSellBuffCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopSellBuffCsReq(FateShopSellBuffCsReq other)
		: this()
	{
		pHGCDAOHLDA_ = other.pHGCDAOHLDA_;
		oIBPLMKKGGL_ = other.oIBPLMKKGGL_;
		nPMAANOOCOJ_ = other.nPMAANOOCOJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopSellBuffCsReq Clone()
	{
		return new FateShopSellBuffCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateShopSellBuffCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateShopSellBuffCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHGCDAOHLDA != other.PHGCDAOHLDA)
		{
			return false;
		}
		if (OIBPLMKKGGL != other.OIBPLMKKGGL)
		{
			return false;
		}
		if (NPMAANOOCOJ != other.NPMAANOOCOJ)
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
		if (PHGCDAOHLDA)
		{
			num ^= PHGCDAOHLDA.GetHashCode();
		}
		if (OIBPLMKKGGL != 0)
		{
			num ^= OIBPLMKKGGL.GetHashCode();
		}
		if (NPMAANOOCOJ != 0)
		{
			num ^= NPMAANOOCOJ.GetHashCode();
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
		if (PHGCDAOHLDA)
		{
			output.WriteRawTag(32);
			output.WriteBool(PHGCDAOHLDA);
		}
		if (OIBPLMKKGGL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OIBPLMKKGGL);
		}
		if (NPMAANOOCOJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NPMAANOOCOJ);
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
		if (PHGCDAOHLDA)
		{
			num += 2;
		}
		if (OIBPLMKKGGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIBPLMKKGGL);
		}
		if (NPMAANOOCOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPMAANOOCOJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateShopSellBuffCsReq other)
	{
		if (other != null)
		{
			if (other.PHGCDAOHLDA)
			{
				PHGCDAOHLDA = other.PHGCDAOHLDA;
			}
			if (other.OIBPLMKKGGL != 0)
			{
				OIBPLMKKGGL = other.OIBPLMKKGGL;
			}
			if (other.NPMAANOOCOJ != 0)
			{
				NPMAANOOCOJ = other.NPMAANOOCOJ;
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
			case 32u:
				PHGCDAOHLDA = input.ReadBool();
				break;
			case 96u:
				OIBPLMKKGGL = input.ReadUInt32();
				break;
			case 104u:
				NPMAANOOCOJ = input.ReadUInt32();
				break;
			}
		}
	}
}
