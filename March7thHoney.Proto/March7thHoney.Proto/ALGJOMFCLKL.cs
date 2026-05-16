using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ALGJOMFCLKL : IMessage<ALGJOMFCLKL>, IMessage, IEquatable<ALGJOMFCLKL>, IDeepCloneable<ALGJOMFCLKL>, IBufferMessage
{
	private static readonly MessageParser<ALGJOMFCLKL> _parser = new MessageParser<ALGJOMFCLKL>(() => new ALGJOMFCLKL());

	private UnknownFieldSet _unknownFields;

	public const int NOCNEOMKFIOFieldNumber = 1;

	private KKMPEHIFMNC nOCNEOMKFIO_;

	public const int PBDGFDJHIICFieldNumber = 3;

	private ENEHKONPJNA pBDGFDJHIIC_;

	public const int HHDLEADBJGNFieldNumber = 4;

	private APMHDGPDGNP hHDLEADBJGN_;

	public const int LBNHKPPAJIMFieldNumber = 5;

	private LineupInfo lBNHKPPAJIM_;

	public const int LOIIMDAEMIOFieldNumber = 6;

	private CFOIFABCGAE lOIIMDAEMIO_;

	public const int KOCGKEAFLCBFieldNumber = 13;

	private OKBFGNELFMG kOCGKEAFLCB_;

	public const int AAPIPKPJEFMFieldNumber = 14;

	private NAKPLIGJELP aAPIPKPJEFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ALGJOMFCLKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ALGJOMFCLKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKMPEHIFMNC NOCNEOMKFIO
	{
		get
		{
			return nOCNEOMKFIO_;
		}
		set
		{
			nOCNEOMKFIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEHKONPJNA PBDGFDJHIIC
	{
		get
		{
			return pBDGFDJHIIC_;
		}
		set
		{
			pBDGFDJHIIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APMHDGPDGNP HHDLEADBJGN
	{
		get
		{
			return hHDLEADBJGN_;
		}
		set
		{
			hHDLEADBJGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo LBNHKPPAJIM
	{
		get
		{
			return lBNHKPPAJIM_;
		}
		set
		{
			lBNHKPPAJIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFOIFABCGAE LOIIMDAEMIO
	{
		get
		{
			return lOIIMDAEMIO_;
		}
		set
		{
			lOIIMDAEMIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKBFGNELFMG KOCGKEAFLCB
	{
		get
		{
			return kOCGKEAFLCB_;
		}
		set
		{
			kOCGKEAFLCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKPLIGJELP AAPIPKPJEFM
	{
		get
		{
			return aAPIPKPJEFM_;
		}
		set
		{
			aAPIPKPJEFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALGJOMFCLKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALGJOMFCLKL(ALGJOMFCLKL other)
		: this()
	{
		nOCNEOMKFIO_ = ((other.nOCNEOMKFIO_ != null) ? other.nOCNEOMKFIO_.Clone() : null);
		pBDGFDJHIIC_ = ((other.pBDGFDJHIIC_ != null) ? other.pBDGFDJHIIC_.Clone() : null);
		hHDLEADBJGN_ = ((other.hHDLEADBJGN_ != null) ? other.hHDLEADBJGN_.Clone() : null);
		lBNHKPPAJIM_ = ((other.lBNHKPPAJIM_ != null) ? other.lBNHKPPAJIM_.Clone() : null);
		lOIIMDAEMIO_ = ((other.lOIIMDAEMIO_ != null) ? other.lOIIMDAEMIO_.Clone() : null);
		kOCGKEAFLCB_ = ((other.kOCGKEAFLCB_ != null) ? other.kOCGKEAFLCB_.Clone() : null);
		aAPIPKPJEFM_ = ((other.aAPIPKPJEFM_ != null) ? other.aAPIPKPJEFM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALGJOMFCLKL Clone()
	{
		return new ALGJOMFCLKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ALGJOMFCLKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ALGJOMFCLKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NOCNEOMKFIO, other.NOCNEOMKFIO))
		{
			return false;
		}
		if (!object.Equals(PBDGFDJHIIC, other.PBDGFDJHIIC))
		{
			return false;
		}
		if (!object.Equals(HHDLEADBJGN, other.HHDLEADBJGN))
		{
			return false;
		}
		if (!object.Equals(LBNHKPPAJIM, other.LBNHKPPAJIM))
		{
			return false;
		}
		if (!object.Equals(LOIIMDAEMIO, other.LOIIMDAEMIO))
		{
			return false;
		}
		if (!object.Equals(KOCGKEAFLCB, other.KOCGKEAFLCB))
		{
			return false;
		}
		if (!object.Equals(AAPIPKPJEFM, other.AAPIPKPJEFM))
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
		if (nOCNEOMKFIO_ != null)
		{
			num ^= NOCNEOMKFIO.GetHashCode();
		}
		if (pBDGFDJHIIC_ != null)
		{
			num ^= PBDGFDJHIIC.GetHashCode();
		}
		if (hHDLEADBJGN_ != null)
		{
			num ^= HHDLEADBJGN.GetHashCode();
		}
		if (lBNHKPPAJIM_ != null)
		{
			num ^= LBNHKPPAJIM.GetHashCode();
		}
		if (lOIIMDAEMIO_ != null)
		{
			num ^= LOIIMDAEMIO.GetHashCode();
		}
		if (kOCGKEAFLCB_ != null)
		{
			num ^= KOCGKEAFLCB.GetHashCode();
		}
		if (aAPIPKPJEFM_ != null)
		{
			num ^= AAPIPKPJEFM.GetHashCode();
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
		if (nOCNEOMKFIO_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(NOCNEOMKFIO);
		}
		if (pBDGFDJHIIC_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PBDGFDJHIIC);
		}
		if (hHDLEADBJGN_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(HHDLEADBJGN);
		}
		if (lBNHKPPAJIM_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LBNHKPPAJIM);
		}
		if (lOIIMDAEMIO_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(LOIIMDAEMIO);
		}
		if (kOCGKEAFLCB_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(KOCGKEAFLCB);
		}
		if (aAPIPKPJEFM_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(AAPIPKPJEFM);
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
		if (nOCNEOMKFIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NOCNEOMKFIO);
		}
		if (pBDGFDJHIIC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PBDGFDJHIIC);
		}
		if (hHDLEADBJGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HHDLEADBJGN);
		}
		if (lBNHKPPAJIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LBNHKPPAJIM);
		}
		if (lOIIMDAEMIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LOIIMDAEMIO);
		}
		if (kOCGKEAFLCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KOCGKEAFLCB);
		}
		if (aAPIPKPJEFM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AAPIPKPJEFM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ALGJOMFCLKL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nOCNEOMKFIO_ != null)
		{
			if (nOCNEOMKFIO_ == null)
			{
				NOCNEOMKFIO = new KKMPEHIFMNC();
			}
			NOCNEOMKFIO.MergeFrom(other.NOCNEOMKFIO);
		}
		if (other.pBDGFDJHIIC_ != null)
		{
			if (pBDGFDJHIIC_ == null)
			{
				PBDGFDJHIIC = new ENEHKONPJNA();
			}
			PBDGFDJHIIC.MergeFrom(other.PBDGFDJHIIC);
		}
		if (other.hHDLEADBJGN_ != null)
		{
			if (hHDLEADBJGN_ == null)
			{
				HHDLEADBJGN = new APMHDGPDGNP();
			}
			HHDLEADBJGN.MergeFrom(other.HHDLEADBJGN);
		}
		if (other.lBNHKPPAJIM_ != null)
		{
			if (lBNHKPPAJIM_ == null)
			{
				LBNHKPPAJIM = new LineupInfo();
			}
			LBNHKPPAJIM.MergeFrom(other.LBNHKPPAJIM);
		}
		if (other.lOIIMDAEMIO_ != null)
		{
			if (lOIIMDAEMIO_ == null)
			{
				LOIIMDAEMIO = new CFOIFABCGAE();
			}
			LOIIMDAEMIO.MergeFrom(other.LOIIMDAEMIO);
		}
		if (other.kOCGKEAFLCB_ != null)
		{
			if (kOCGKEAFLCB_ == null)
			{
				KOCGKEAFLCB = new OKBFGNELFMG();
			}
			KOCGKEAFLCB.MergeFrom(other.KOCGKEAFLCB);
		}
		if (other.aAPIPKPJEFM_ != null)
		{
			if (aAPIPKPJEFM_ == null)
			{
				AAPIPKPJEFM = new NAKPLIGJELP();
			}
			AAPIPKPJEFM.MergeFrom(other.AAPIPKPJEFM);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (nOCNEOMKFIO_ == null)
				{
					NOCNEOMKFIO = new KKMPEHIFMNC();
				}
				input.ReadMessage(NOCNEOMKFIO);
				break;
			case 26u:
				if (pBDGFDJHIIC_ == null)
				{
					PBDGFDJHIIC = new ENEHKONPJNA();
				}
				input.ReadMessage(PBDGFDJHIIC);
				break;
			case 34u:
				if (hHDLEADBJGN_ == null)
				{
					HHDLEADBJGN = new APMHDGPDGNP();
				}
				input.ReadMessage(HHDLEADBJGN);
				break;
			case 42u:
				if (lBNHKPPAJIM_ == null)
				{
					LBNHKPPAJIM = new LineupInfo();
				}
				input.ReadMessage(LBNHKPPAJIM);
				break;
			case 50u:
				if (lOIIMDAEMIO_ == null)
				{
					LOIIMDAEMIO = new CFOIFABCGAE();
				}
				input.ReadMessage(LOIIMDAEMIO);
				break;
			case 106u:
				if (kOCGKEAFLCB_ == null)
				{
					KOCGKEAFLCB = new OKBFGNELFMG();
				}
				input.ReadMessage(KOCGKEAFLCB);
				break;
			case 114u:
				if (aAPIPKPJEFM_ == null)
				{
					AAPIPKPJEFM = new NAKPLIGJELP();
				}
				input.ReadMessage(AAPIPKPJEFM);
				break;
			}
		}
	}
}
