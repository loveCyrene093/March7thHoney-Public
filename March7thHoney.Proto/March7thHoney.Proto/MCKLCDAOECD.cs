using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MCKLCDAOECD : IMessage<MCKLCDAOECD>, IMessage, IEquatable<MCKLCDAOECD>, IDeepCloneable<MCKLCDAOECD>, IBufferMessage
{
	private static readonly MessageParser<MCKLCDAOECD> _parser = new MessageParser<MCKLCDAOECD>(() => new MCKLCDAOECD());

	private UnknownFieldSet _unknownFields;

	public const int KHCJONFAPMKFieldNumber = 1;

	private bool kHCJONFAPMK_;

	public const int FJIKIPDJOPKFieldNumber = 2;

	private uint fJIKIPDJOPK_;

	public const int JIODDAHNMELFieldNumber = 3;

	private bool jIODDAHNMEL_;

	public const int BPDJGGBGMMMFieldNumber = 4;

	private string bPDJGGBGMMM_ = "";

	public const int JOOCDKJFDBAFieldNumber = 5;

	private bool jOOCDKJFDBA_;

	public const int PCCOGCPBFLLFieldNumber = 6;

	private bool pCCOGCPBFLL_;

	public const int CKHIFLBFFLCFieldNumber = 7;

	private uint cKHIFLBFFLC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MCKLCDAOECD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MCKLCDAOECDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KHCJONFAPMK
	{
		get
		{
			return kHCJONFAPMK_;
		}
		set
		{
			kHCJONFAPMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJIKIPDJOPK
	{
		get
		{
			return fJIKIPDJOPK_;
		}
		set
		{
			fJIKIPDJOPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JIODDAHNMEL
	{
		get
		{
			return jIODDAHNMEL_;
		}
		set
		{
			jIODDAHNMEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BPDJGGBGMMM
	{
		get
		{
			return bPDJGGBGMMM_;
		}
		set
		{
			bPDJGGBGMMM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JOOCDKJFDBA
	{
		get
		{
			return jOOCDKJFDBA_;
		}
		set
		{
			jOOCDKJFDBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PCCOGCPBFLL
	{
		get
		{
			return pCCOGCPBFLL_;
		}
		set
		{
			pCCOGCPBFLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CKHIFLBFFLC
	{
		get
		{
			return cKHIFLBFFLC_;
		}
		set
		{
			cKHIFLBFFLC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCKLCDAOECD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCKLCDAOECD(MCKLCDAOECD other)
		: this()
	{
		kHCJONFAPMK_ = other.kHCJONFAPMK_;
		fJIKIPDJOPK_ = other.fJIKIPDJOPK_;
		jIODDAHNMEL_ = other.jIODDAHNMEL_;
		bPDJGGBGMMM_ = other.bPDJGGBGMMM_;
		jOOCDKJFDBA_ = other.jOOCDKJFDBA_;
		pCCOGCPBFLL_ = other.pCCOGCPBFLL_;
		cKHIFLBFFLC_ = other.cKHIFLBFFLC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCKLCDAOECD Clone()
	{
		return new MCKLCDAOECD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MCKLCDAOECD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MCKLCDAOECD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHCJONFAPMK != other.KHCJONFAPMK)
		{
			return false;
		}
		if (FJIKIPDJOPK != other.FJIKIPDJOPK)
		{
			return false;
		}
		if (JIODDAHNMEL != other.JIODDAHNMEL)
		{
			return false;
		}
		if (BPDJGGBGMMM != other.BPDJGGBGMMM)
		{
			return false;
		}
		if (JOOCDKJFDBA != other.JOOCDKJFDBA)
		{
			return false;
		}
		if (PCCOGCPBFLL != other.PCCOGCPBFLL)
		{
			return false;
		}
		if (CKHIFLBFFLC != other.CKHIFLBFFLC)
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
		if (KHCJONFAPMK)
		{
			num ^= KHCJONFAPMK.GetHashCode();
		}
		if (FJIKIPDJOPK != 0)
		{
			num ^= FJIKIPDJOPK.GetHashCode();
		}
		if (JIODDAHNMEL)
		{
			num ^= JIODDAHNMEL.GetHashCode();
		}
		if (BPDJGGBGMMM.Length != 0)
		{
			num ^= BPDJGGBGMMM.GetHashCode();
		}
		if (JOOCDKJFDBA)
		{
			num ^= JOOCDKJFDBA.GetHashCode();
		}
		if (PCCOGCPBFLL)
		{
			num ^= PCCOGCPBFLL.GetHashCode();
		}
		if (CKHIFLBFFLC != 0)
		{
			num ^= CKHIFLBFFLC.GetHashCode();
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
		if (KHCJONFAPMK)
		{
			output.WriteRawTag(8);
			output.WriteBool(KHCJONFAPMK);
		}
		if (FJIKIPDJOPK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FJIKIPDJOPK);
		}
		if (JIODDAHNMEL)
		{
			output.WriteRawTag(24);
			output.WriteBool(JIODDAHNMEL);
		}
		if (BPDJGGBGMMM.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BPDJGGBGMMM);
		}
		if (JOOCDKJFDBA)
		{
			output.WriteRawTag(40);
			output.WriteBool(JOOCDKJFDBA);
		}
		if (PCCOGCPBFLL)
		{
			output.WriteRawTag(48);
			output.WriteBool(PCCOGCPBFLL);
		}
		if (CKHIFLBFFLC != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(CKHIFLBFFLC);
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
		if (KHCJONFAPMK)
		{
			num += 2;
		}
		if (FJIKIPDJOPK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJIKIPDJOPK);
		}
		if (JIODDAHNMEL)
		{
			num += 2;
		}
		if (BPDJGGBGMMM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BPDJGGBGMMM);
		}
		if (JOOCDKJFDBA)
		{
			num += 2;
		}
		if (PCCOGCPBFLL)
		{
			num += 2;
		}
		if (CKHIFLBFFLC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CKHIFLBFFLC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MCKLCDAOECD other)
	{
		if (other != null)
		{
			if (other.KHCJONFAPMK)
			{
				KHCJONFAPMK = other.KHCJONFAPMK;
			}
			if (other.FJIKIPDJOPK != 0)
			{
				FJIKIPDJOPK = other.FJIKIPDJOPK;
			}
			if (other.JIODDAHNMEL)
			{
				JIODDAHNMEL = other.JIODDAHNMEL;
			}
			if (other.BPDJGGBGMMM.Length != 0)
			{
				BPDJGGBGMMM = other.BPDJGGBGMMM;
			}
			if (other.JOOCDKJFDBA)
			{
				JOOCDKJFDBA = other.JOOCDKJFDBA;
			}
			if (other.PCCOGCPBFLL)
			{
				PCCOGCPBFLL = other.PCCOGCPBFLL;
			}
			if (other.CKHIFLBFFLC != 0)
			{
				CKHIFLBFFLC = other.CKHIFLBFFLC;
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
			case 8u:
				KHCJONFAPMK = input.ReadBool();
				break;
			case 16u:
				FJIKIPDJOPK = input.ReadUInt32();
				break;
			case 24u:
				JIODDAHNMEL = input.ReadBool();
				break;
			case 34u:
				BPDJGGBGMMM = input.ReadString();
				break;
			case 40u:
				JOOCDKJFDBA = input.ReadBool();
				break;
			case 48u:
				PCCOGCPBFLL = input.ReadBool();
				break;
			case 56u:
				CKHIFLBFFLC = input.ReadUInt32();
				break;
			}
		}
	}
}
