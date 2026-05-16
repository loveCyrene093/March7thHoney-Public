using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateShopSellBuffScRsp : IMessage<FateShopSellBuffScRsp>, IMessage, IEquatable<FateShopSellBuffScRsp>, IDeepCloneable<FateShopSellBuffScRsp>, IBufferMessage
{
	private static readonly MessageParser<FateShopSellBuffScRsp> _parser = new MessageParser<FateShopSellBuffScRsp>(() => new FateShopSellBuffScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int NPMAANOOCOJFieldNumber = 8;

	private uint nPMAANOOCOJ_;

	public const int PHGCDAOHLDAFieldNumber = 13;

	private bool pHGCDAOHLDA_;

	public const int OIBPLMKKGGLFieldNumber = 15;

	private uint oIBPLMKKGGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateShopSellBuffScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateShopSellBuffScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FateShopSellBuffScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopSellBuffScRsp(FateShopSellBuffScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		nPMAANOOCOJ_ = other.nPMAANOOCOJ_;
		pHGCDAOHLDA_ = other.pHGCDAOHLDA_;
		oIBPLMKKGGL_ = other.oIBPLMKKGGL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateShopSellBuffScRsp Clone()
	{
		return new FateShopSellBuffScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateShopSellBuffScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateShopSellBuffScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (NPMAANOOCOJ != other.NPMAANOOCOJ)
		{
			return false;
		}
		if (PHGCDAOHLDA != other.PHGCDAOHLDA)
		{
			return false;
		}
		if (OIBPLMKKGGL != other.OIBPLMKKGGL)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (NPMAANOOCOJ != 0)
		{
			num ^= NPMAANOOCOJ.GetHashCode();
		}
		if (PHGCDAOHLDA)
		{
			num ^= PHGCDAOHLDA.GetHashCode();
		}
		if (OIBPLMKKGGL != 0)
		{
			num ^= OIBPLMKKGGL.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (NPMAANOOCOJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NPMAANOOCOJ);
		}
		if (PHGCDAOHLDA)
		{
			output.WriteRawTag(104);
			output.WriteBool(PHGCDAOHLDA);
		}
		if (OIBPLMKKGGL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OIBPLMKKGGL);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (NPMAANOOCOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPMAANOOCOJ);
		}
		if (PHGCDAOHLDA)
		{
			num += 2;
		}
		if (OIBPLMKKGGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIBPLMKKGGL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateShopSellBuffScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.NPMAANOOCOJ != 0)
			{
				NPMAANOOCOJ = other.NPMAANOOCOJ;
			}
			if (other.PHGCDAOHLDA)
			{
				PHGCDAOHLDA = other.PHGCDAOHLDA;
			}
			if (other.OIBPLMKKGGL != 0)
			{
				OIBPLMKKGGL = other.OIBPLMKKGGL;
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
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				NPMAANOOCOJ = input.ReadUInt32();
				break;
			case 104u:
				PHGCDAOHLDA = input.ReadBool();
				break;
			case 120u:
				OIBPLMKKGGL = input.ReadUInt32();
				break;
			}
		}
	}
}
