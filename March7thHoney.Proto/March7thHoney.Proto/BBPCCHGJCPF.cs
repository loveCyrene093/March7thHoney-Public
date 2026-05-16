using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBPCCHGJCPF : IMessage<BBPCCHGJCPF>, IMessage, IEquatable<BBPCCHGJCPF>, IDeepCloneable<BBPCCHGJCPF>, IBufferMessage
{
	private static readonly MessageParser<BBPCCHGJCPF> _parser = new MessageParser<BBPCCHGJCPF>(() => new BBPCCHGJCPF());

	private UnknownFieldSet _unknownFields;

	public const int BNGODBNJBCOFieldNumber = 1;

	private uint bNGODBNJBCO_;

	public const int NNIFJPLBDKCFieldNumber = 2;

	private uint nNIFJPLBDKC_;

	public const int IFKKGMFLFJKFieldNumber = 3;

	private uint iFKKGMFLFJK_;

	public const int IJDKOIAAILGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_iJDKOIAAILG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> iJDKOIAAILG_ = new RepeatedField<uint>();

	public const int ADIICGEBJOGFieldNumber = 5;

	private static readonly FieldCodec<EIBOBKEJAKM> _repeated_aDIICGEBJOG_codec = FieldCodec.ForMessage(42u, EIBOBKEJAKM.Parser);

	private readonly RepeatedField<EIBOBKEJAKM> aDIICGEBJOG_ = new RepeatedField<EIBOBKEJAKM>();

	public const int POJFLLOOPLFFieldNumber = 6;

	private uint pOJFLLOOPLF_;

	public const int NJELMEOOIGNFieldNumber = 7;

	private uint nJELMEOOIGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBPCCHGJCPF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBPCCHGJCPFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BNGODBNJBCO
	{
		get
		{
			return bNGODBNJBCO_;
		}
		set
		{
			bNGODBNJBCO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNIFJPLBDKC
	{
		get
		{
			return nNIFJPLBDKC_;
		}
		set
		{
			nNIFJPLBDKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IFKKGMFLFJK
	{
		get
		{
			return iFKKGMFLFJK_;
		}
		set
		{
			iFKKGMFLFJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IJDKOIAAILG => iJDKOIAAILG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EIBOBKEJAKM> ADIICGEBJOG => aDIICGEBJOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint POJFLLOOPLF
	{
		get
		{
			return pOJFLLOOPLF_;
		}
		set
		{
			pOJFLLOOPLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJELMEOOIGN
	{
		get
		{
			return nJELMEOOIGN_;
		}
		set
		{
			nJELMEOOIGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBPCCHGJCPF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBPCCHGJCPF(BBPCCHGJCPF other)
		: this()
	{
		bNGODBNJBCO_ = other.bNGODBNJBCO_;
		nNIFJPLBDKC_ = other.nNIFJPLBDKC_;
		iFKKGMFLFJK_ = other.iFKKGMFLFJK_;
		iJDKOIAAILG_ = other.iJDKOIAAILG_.Clone();
		aDIICGEBJOG_ = other.aDIICGEBJOG_.Clone();
		pOJFLLOOPLF_ = other.pOJFLLOOPLF_;
		nJELMEOOIGN_ = other.nJELMEOOIGN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBPCCHGJCPF Clone()
	{
		return new BBPCCHGJCPF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBPCCHGJCPF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBPCCHGJCPF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BNGODBNJBCO != other.BNGODBNJBCO)
		{
			return false;
		}
		if (NNIFJPLBDKC != other.NNIFJPLBDKC)
		{
			return false;
		}
		if (IFKKGMFLFJK != other.IFKKGMFLFJK)
		{
			return false;
		}
		if (!iJDKOIAAILG_.Equals(other.iJDKOIAAILG_))
		{
			return false;
		}
		if (!aDIICGEBJOG_.Equals(other.aDIICGEBJOG_))
		{
			return false;
		}
		if (POJFLLOOPLF != other.POJFLLOOPLF)
		{
			return false;
		}
		if (NJELMEOOIGN != other.NJELMEOOIGN)
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
		if (BNGODBNJBCO != 0)
		{
			num ^= BNGODBNJBCO.GetHashCode();
		}
		if (NNIFJPLBDKC != 0)
		{
			num ^= NNIFJPLBDKC.GetHashCode();
		}
		if (IFKKGMFLFJK != 0)
		{
			num ^= IFKKGMFLFJK.GetHashCode();
		}
		num ^= iJDKOIAAILG_.GetHashCode();
		num ^= aDIICGEBJOG_.GetHashCode();
		if (POJFLLOOPLF != 0)
		{
			num ^= POJFLLOOPLF.GetHashCode();
		}
		if (NJELMEOOIGN != 0)
		{
			num ^= NJELMEOOIGN.GetHashCode();
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
		if (BNGODBNJBCO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BNGODBNJBCO);
		}
		if (NNIFJPLBDKC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NNIFJPLBDKC);
		}
		if (IFKKGMFLFJK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IFKKGMFLFJK);
		}
		iJDKOIAAILG_.WriteTo(ref output, _repeated_iJDKOIAAILG_codec);
		aDIICGEBJOG_.WriteTo(ref output, _repeated_aDIICGEBJOG_codec);
		if (POJFLLOOPLF != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(POJFLLOOPLF);
		}
		if (NJELMEOOIGN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NJELMEOOIGN);
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
		if (BNGODBNJBCO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNGODBNJBCO);
		}
		if (NNIFJPLBDKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNIFJPLBDKC);
		}
		if (IFKKGMFLFJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IFKKGMFLFJK);
		}
		num += iJDKOIAAILG_.CalculateSize(_repeated_iJDKOIAAILG_codec);
		num += aDIICGEBJOG_.CalculateSize(_repeated_aDIICGEBJOG_codec);
		if (POJFLLOOPLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(POJFLLOOPLF);
		}
		if (NJELMEOOIGN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJELMEOOIGN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBPCCHGJCPF other)
	{
		if (other != null)
		{
			if (other.BNGODBNJBCO != 0)
			{
				BNGODBNJBCO = other.BNGODBNJBCO;
			}
			if (other.NNIFJPLBDKC != 0)
			{
				NNIFJPLBDKC = other.NNIFJPLBDKC;
			}
			if (other.IFKKGMFLFJK != 0)
			{
				IFKKGMFLFJK = other.IFKKGMFLFJK;
			}
			iJDKOIAAILG_.Add(other.iJDKOIAAILG_);
			aDIICGEBJOG_.Add(other.aDIICGEBJOG_);
			if (other.POJFLLOOPLF != 0)
			{
				POJFLLOOPLF = other.POJFLLOOPLF;
			}
			if (other.NJELMEOOIGN != 0)
			{
				NJELMEOOIGN = other.NJELMEOOIGN;
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
				BNGODBNJBCO = input.ReadUInt32();
				break;
			case 16u:
				NNIFJPLBDKC = input.ReadUInt32();
				break;
			case 24u:
				IFKKGMFLFJK = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				iJDKOIAAILG_.AddEntriesFrom(ref input, _repeated_iJDKOIAAILG_codec);
				break;
			case 42u:
				aDIICGEBJOG_.AddEntriesFrom(ref input, _repeated_aDIICGEBJOG_codec);
				break;
			case 48u:
				POJFLLOOPLF = input.ReadUInt32();
				break;
			case 56u:
				NJELMEOOIGN = input.ReadUInt32();
				break;
			}
		}
	}
}
