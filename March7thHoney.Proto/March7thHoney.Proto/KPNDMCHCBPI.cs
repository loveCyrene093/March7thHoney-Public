using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KPNDMCHCBPI : IMessage<KPNDMCHCBPI>, IMessage, IEquatable<KPNDMCHCBPI>, IDeepCloneable<KPNDMCHCBPI>, IBufferMessage
{
	private static readonly MessageParser<KPNDMCHCBPI> _parser = new MessageParser<KPNDMCHCBPI>(() => new KPNDMCHCBPI());

	private UnknownFieldSet _unknownFields;

	public const int CINMPHLJDEMFieldNumber = 1;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_cINMPHLJDEM_codec = FieldCodec.ForMessage(10u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> cINMPHLJDEM_ = new RepeatedField<GKDEKJKOIJN>();

	public const int POINEKIEFPEFieldNumber = 4;

	private uint pOINEKIEFPE_;

	public const int APDABNGDMPMFieldNumber = 6;

	private uint aPDABNGDMPM_;

	public const int DPBEENBPDIPFieldNumber = 9;

	private uint dPBEENBPDIP_;

	public const int BJADHCOFLGIFieldNumber = 11;

	private bool bJADHCOFLGI_;

	public const int OAIBCCNAAHFFieldNumber = 12;

	private uint oAIBCCNAAHF_;

	public const int EMFHLBBOCFKFieldNumber = 13;

	private uint eMFHLBBOCFK_;

	public const int DONOJAEMJDBFieldNumber = 15;

	private bool dONOJAEMJDB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KPNDMCHCBPI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KPNDMCHCBPIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> CINMPHLJDEM => cINMPHLJDEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint POINEKIEFPE
	{
		get
		{
			return pOINEKIEFPE_;
		}
		set
		{
			pOINEKIEFPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APDABNGDMPM
	{
		get
		{
			return aPDABNGDMPM_;
		}
		set
		{
			aPDABNGDMPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DPBEENBPDIP
	{
		get
		{
			return dPBEENBPDIP_;
		}
		set
		{
			dPBEENBPDIP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BJADHCOFLGI
	{
		get
		{
			return bJADHCOFLGI_;
		}
		set
		{
			bJADHCOFLGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OAIBCCNAAHF
	{
		get
		{
			return oAIBCCNAAHF_;
		}
		set
		{
			oAIBCCNAAHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMFHLBBOCFK
	{
		get
		{
			return eMFHLBBOCFK_;
		}
		set
		{
			eMFHLBBOCFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DONOJAEMJDB
	{
		get
		{
			return dONOJAEMJDB_;
		}
		set
		{
			dONOJAEMJDB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPNDMCHCBPI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPNDMCHCBPI(KPNDMCHCBPI other)
		: this()
	{
		cINMPHLJDEM_ = other.cINMPHLJDEM_.Clone();
		pOINEKIEFPE_ = other.pOINEKIEFPE_;
		aPDABNGDMPM_ = other.aPDABNGDMPM_;
		dPBEENBPDIP_ = other.dPBEENBPDIP_;
		bJADHCOFLGI_ = other.bJADHCOFLGI_;
		oAIBCCNAAHF_ = other.oAIBCCNAAHF_;
		eMFHLBBOCFK_ = other.eMFHLBBOCFK_;
		dONOJAEMJDB_ = other.dONOJAEMJDB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPNDMCHCBPI Clone()
	{
		return new KPNDMCHCBPI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KPNDMCHCBPI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KPNDMCHCBPI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cINMPHLJDEM_.Equals(other.cINMPHLJDEM_))
		{
			return false;
		}
		if (POINEKIEFPE != other.POINEKIEFPE)
		{
			return false;
		}
		if (APDABNGDMPM != other.APDABNGDMPM)
		{
			return false;
		}
		if (DPBEENBPDIP != other.DPBEENBPDIP)
		{
			return false;
		}
		if (BJADHCOFLGI != other.BJADHCOFLGI)
		{
			return false;
		}
		if (OAIBCCNAAHF != other.OAIBCCNAAHF)
		{
			return false;
		}
		if (EMFHLBBOCFK != other.EMFHLBBOCFK)
		{
			return false;
		}
		if (DONOJAEMJDB != other.DONOJAEMJDB)
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
		num ^= cINMPHLJDEM_.GetHashCode();
		if (POINEKIEFPE != 0)
		{
			num ^= POINEKIEFPE.GetHashCode();
		}
		if (APDABNGDMPM != 0)
		{
			num ^= APDABNGDMPM.GetHashCode();
		}
		if (DPBEENBPDIP != 0)
		{
			num ^= DPBEENBPDIP.GetHashCode();
		}
		if (BJADHCOFLGI)
		{
			num ^= BJADHCOFLGI.GetHashCode();
		}
		if (OAIBCCNAAHF != 0)
		{
			num ^= OAIBCCNAAHF.GetHashCode();
		}
		if (EMFHLBBOCFK != 0)
		{
			num ^= EMFHLBBOCFK.GetHashCode();
		}
		if (DONOJAEMJDB)
		{
			num ^= DONOJAEMJDB.GetHashCode();
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
		cINMPHLJDEM_.WriteTo(ref output, _repeated_cINMPHLJDEM_codec);
		if (POINEKIEFPE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(POINEKIEFPE);
		}
		if (APDABNGDMPM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(APDABNGDMPM);
		}
		if (DPBEENBPDIP != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DPBEENBPDIP);
		}
		if (BJADHCOFLGI)
		{
			output.WriteRawTag(88);
			output.WriteBool(BJADHCOFLGI);
		}
		if (OAIBCCNAAHF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OAIBCCNAAHF);
		}
		if (EMFHLBBOCFK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EMFHLBBOCFK);
		}
		if (DONOJAEMJDB)
		{
			output.WriteRawTag(120);
			output.WriteBool(DONOJAEMJDB);
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
		num += cINMPHLJDEM_.CalculateSize(_repeated_cINMPHLJDEM_codec);
		if (POINEKIEFPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(POINEKIEFPE);
		}
		if (APDABNGDMPM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APDABNGDMPM);
		}
		if (DPBEENBPDIP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DPBEENBPDIP);
		}
		if (BJADHCOFLGI)
		{
			num += 2;
		}
		if (OAIBCCNAAHF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OAIBCCNAAHF);
		}
		if (EMFHLBBOCFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMFHLBBOCFK);
		}
		if (DONOJAEMJDB)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KPNDMCHCBPI other)
	{
		if (other != null)
		{
			cINMPHLJDEM_.Add(other.cINMPHLJDEM_);
			if (other.POINEKIEFPE != 0)
			{
				POINEKIEFPE = other.POINEKIEFPE;
			}
			if (other.APDABNGDMPM != 0)
			{
				APDABNGDMPM = other.APDABNGDMPM;
			}
			if (other.DPBEENBPDIP != 0)
			{
				DPBEENBPDIP = other.DPBEENBPDIP;
			}
			if (other.BJADHCOFLGI)
			{
				BJADHCOFLGI = other.BJADHCOFLGI;
			}
			if (other.OAIBCCNAAHF != 0)
			{
				OAIBCCNAAHF = other.OAIBCCNAAHF;
			}
			if (other.EMFHLBBOCFK != 0)
			{
				EMFHLBBOCFK = other.EMFHLBBOCFK;
			}
			if (other.DONOJAEMJDB)
			{
				DONOJAEMJDB = other.DONOJAEMJDB;
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
			case 10u:
				cINMPHLJDEM_.AddEntriesFrom(ref input, _repeated_cINMPHLJDEM_codec);
				break;
			case 32u:
				POINEKIEFPE = input.ReadUInt32();
				break;
			case 48u:
				APDABNGDMPM = input.ReadUInt32();
				break;
			case 72u:
				DPBEENBPDIP = input.ReadUInt32();
				break;
			case 88u:
				BJADHCOFLGI = input.ReadBool();
				break;
			case 96u:
				OAIBCCNAAHF = input.ReadUInt32();
				break;
			case 104u:
				EMFHLBBOCFK = input.ReadUInt32();
				break;
			case 120u:
				DONOJAEMJDB = input.ReadBool();
				break;
			}
		}
	}
}
