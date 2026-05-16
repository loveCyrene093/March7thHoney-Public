using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PNKEBBADONJ : IMessage<PNKEBBADONJ>, IMessage, IEquatable<PNKEBBADONJ>, IDeepCloneable<PNKEBBADONJ>, IBufferMessage
{
	private static readonly MessageParser<PNKEBBADONJ> _parser = new MessageParser<PNKEBBADONJ>(() => new PNKEBBADONJ());

	private UnknownFieldSet _unknownFields;

	public const int ABIJBGENKHAFieldNumber = 2;

	private PBMHMEADLEC aBIJBGENKHA_;

	public const int EMFDMIKFIBFFieldNumber = 3;

	private POIFGDAHJCJ eMFDMIKFIBF_;

	public const int OGAFLPPJIOBFieldNumber = 4;

	private JDJODLAJBKP oGAFLPPJIOB_;

	public const int LineupFieldNumber = 6;

	private MICOMIBPIOA lineup_;

	public const int MMAOONPAPDPFieldNumber = 7;

	private KKFANGIJAOF mMAOONPAPDP_;

	public const int ItemValueFieldNumber = 9;

	private PGJNBNANDEE itemValue_;

	public const int LevelFieldNumber = 10;

	private AOIKKHJLKJF level_;

	public const int MKPEBDAJAJNFieldNumber = 11;

	private NALJFANPFMA mKPEBDAJAJN_;

	public const int BAAANBEIPBGFieldNumber = 13;

	private CNJHCICPAIC bAAANBEIPBG_;

	public const int HKKIJABGCNAFieldNumber = 14;

	private GCHIOMAJIPI hKKIJABGCNA_;

	public const int BDGOOPLHFAGFieldNumber = 15;

	private AJAEJNHDNFD bDGOOPLHFAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PNKEBBADONJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PNKEBBADONJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBMHMEADLEC ABIJBGENKHA
	{
		get
		{
			return aBIJBGENKHA_;
		}
		set
		{
			aBIJBGENKHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POIFGDAHJCJ EMFDMIKFIBF
	{
		get
		{
			return eMFDMIKFIBF_;
		}
		set
		{
			eMFDMIKFIBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDJODLAJBKP OGAFLPPJIOB
	{
		get
		{
			return oGAFLPPJIOB_;
		}
		set
		{
			oGAFLPPJIOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MICOMIBPIOA Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKFANGIJAOF MMAOONPAPDP
	{
		get
		{
			return mMAOONPAPDP_;
		}
		set
		{
			mMAOONPAPDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGJNBNANDEE ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKKHJLKJF Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NALJFANPFMA MKPEBDAJAJN
	{
		get
		{
			return mKPEBDAJAJN_;
		}
		set
		{
			mKPEBDAJAJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNJHCICPAIC BAAANBEIPBG
	{
		get
		{
			return bAAANBEIPBG_;
		}
		set
		{
			bAAANBEIPBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCHIOMAJIPI HKKIJABGCNA
	{
		get
		{
			return hKKIJABGCNA_;
		}
		set
		{
			hKKIJABGCNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJAEJNHDNFD BDGOOPLHFAG
	{
		get
		{
			return bDGOOPLHFAG_;
		}
		set
		{
			bDGOOPLHFAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNKEBBADONJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNKEBBADONJ(PNKEBBADONJ other)
		: this()
	{
		aBIJBGENKHA_ = ((other.aBIJBGENKHA_ != null) ? other.aBIJBGENKHA_.Clone() : null);
		eMFDMIKFIBF_ = ((other.eMFDMIKFIBF_ != null) ? other.eMFDMIKFIBF_.Clone() : null);
		oGAFLPPJIOB_ = ((other.oGAFLPPJIOB_ != null) ? other.oGAFLPPJIOB_.Clone() : null);
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		mMAOONPAPDP_ = ((other.mMAOONPAPDP_ != null) ? other.mMAOONPAPDP_.Clone() : null);
		itemValue_ = ((other.itemValue_ != null) ? other.itemValue_.Clone() : null);
		level_ = ((other.level_ != null) ? other.level_.Clone() : null);
		mKPEBDAJAJN_ = ((other.mKPEBDAJAJN_ != null) ? other.mKPEBDAJAJN_.Clone() : null);
		bAAANBEIPBG_ = ((other.bAAANBEIPBG_ != null) ? other.bAAANBEIPBG_.Clone() : null);
		hKKIJABGCNA_ = ((other.hKKIJABGCNA_ != null) ? other.hKKIJABGCNA_.Clone() : null);
		bDGOOPLHFAG_ = ((other.bDGOOPLHFAG_ != null) ? other.bDGOOPLHFAG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNKEBBADONJ Clone()
	{
		return new PNKEBBADONJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PNKEBBADONJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PNKEBBADONJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ABIJBGENKHA, other.ABIJBGENKHA))
		{
			return false;
		}
		if (!object.Equals(EMFDMIKFIBF, other.EMFDMIKFIBF))
		{
			return false;
		}
		if (!object.Equals(OGAFLPPJIOB, other.OGAFLPPJIOB))
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!object.Equals(MMAOONPAPDP, other.MMAOONPAPDP))
		{
			return false;
		}
		if (!object.Equals(ItemValue, other.ItemValue))
		{
			return false;
		}
		if (!object.Equals(Level, other.Level))
		{
			return false;
		}
		if (!object.Equals(MKPEBDAJAJN, other.MKPEBDAJAJN))
		{
			return false;
		}
		if (!object.Equals(BAAANBEIPBG, other.BAAANBEIPBG))
		{
			return false;
		}
		if (!object.Equals(HKKIJABGCNA, other.HKKIJABGCNA))
		{
			return false;
		}
		if (!object.Equals(BDGOOPLHFAG, other.BDGOOPLHFAG))
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
		if (aBIJBGENKHA_ != null)
		{
			num ^= ABIJBGENKHA.GetHashCode();
		}
		if (eMFDMIKFIBF_ != null)
		{
			num ^= EMFDMIKFIBF.GetHashCode();
		}
		if (oGAFLPPJIOB_ != null)
		{
			num ^= OGAFLPPJIOB.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (mMAOONPAPDP_ != null)
		{
			num ^= MMAOONPAPDP.GetHashCode();
		}
		if (itemValue_ != null)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (level_ != null)
		{
			num ^= Level.GetHashCode();
		}
		if (mKPEBDAJAJN_ != null)
		{
			num ^= MKPEBDAJAJN.GetHashCode();
		}
		if (bAAANBEIPBG_ != null)
		{
			num ^= BAAANBEIPBG.GetHashCode();
		}
		if (hKKIJABGCNA_ != null)
		{
			num ^= HKKIJABGCNA.GetHashCode();
		}
		if (bDGOOPLHFAG_ != null)
		{
			num ^= BDGOOPLHFAG.GetHashCode();
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
		if (aBIJBGENKHA_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ABIJBGENKHA);
		}
		if (eMFDMIKFIBF_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EMFDMIKFIBF);
		}
		if (oGAFLPPJIOB_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OGAFLPPJIOB);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Lineup);
		}
		if (mMAOONPAPDP_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(MMAOONPAPDP);
		}
		if (itemValue_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ItemValue);
		}
		if (level_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Level);
		}
		if (mKPEBDAJAJN_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(MKPEBDAJAJN);
		}
		if (bAAANBEIPBG_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BAAANBEIPBG);
		}
		if (hKKIJABGCNA_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HKKIJABGCNA);
		}
		if (bDGOOPLHFAG_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BDGOOPLHFAG);
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
		if (aBIJBGENKHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ABIJBGENKHA);
		}
		if (eMFDMIKFIBF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EMFDMIKFIBF);
		}
		if (oGAFLPPJIOB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OGAFLPPJIOB);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (mMAOONPAPDP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MMAOONPAPDP);
		}
		if (itemValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemValue);
		}
		if (level_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Level);
		}
		if (mKPEBDAJAJN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MKPEBDAJAJN);
		}
		if (bAAANBEIPBG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BAAANBEIPBG);
		}
		if (hKKIJABGCNA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKKIJABGCNA);
		}
		if (bDGOOPLHFAG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDGOOPLHFAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PNKEBBADONJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aBIJBGENKHA_ != null)
		{
			if (aBIJBGENKHA_ == null)
			{
				ABIJBGENKHA = new PBMHMEADLEC();
			}
			ABIJBGENKHA.MergeFrom(other.ABIJBGENKHA);
		}
		if (other.eMFDMIKFIBF_ != null)
		{
			if (eMFDMIKFIBF_ == null)
			{
				EMFDMIKFIBF = new POIFGDAHJCJ();
			}
			EMFDMIKFIBF.MergeFrom(other.EMFDMIKFIBF);
		}
		if (other.oGAFLPPJIOB_ != null)
		{
			if (oGAFLPPJIOB_ == null)
			{
				OGAFLPPJIOB = new JDJODLAJBKP();
			}
			OGAFLPPJIOB.MergeFrom(other.OGAFLPPJIOB);
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new MICOMIBPIOA();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.mMAOONPAPDP_ != null)
		{
			if (mMAOONPAPDP_ == null)
			{
				MMAOONPAPDP = new KKFANGIJAOF();
			}
			MMAOONPAPDP.MergeFrom(other.MMAOONPAPDP);
		}
		if (other.itemValue_ != null)
		{
			if (itemValue_ == null)
			{
				ItemValue = new PGJNBNANDEE();
			}
			ItemValue.MergeFrom(other.ItemValue);
		}
		if (other.level_ != null)
		{
			if (level_ == null)
			{
				Level = new AOIKKHJLKJF();
			}
			Level.MergeFrom(other.Level);
		}
		if (other.mKPEBDAJAJN_ != null)
		{
			if (mKPEBDAJAJN_ == null)
			{
				MKPEBDAJAJN = new NALJFANPFMA();
			}
			MKPEBDAJAJN.MergeFrom(other.MKPEBDAJAJN);
		}
		if (other.bAAANBEIPBG_ != null)
		{
			if (bAAANBEIPBG_ == null)
			{
				BAAANBEIPBG = new CNJHCICPAIC();
			}
			BAAANBEIPBG.MergeFrom(other.BAAANBEIPBG);
		}
		if (other.hKKIJABGCNA_ != null)
		{
			if (hKKIJABGCNA_ == null)
			{
				HKKIJABGCNA = new GCHIOMAJIPI();
			}
			HKKIJABGCNA.MergeFrom(other.HKKIJABGCNA);
		}
		if (other.bDGOOPLHFAG_ != null)
		{
			if (bDGOOPLHFAG_ == null)
			{
				BDGOOPLHFAG = new AJAEJNHDNFD();
			}
			BDGOOPLHFAG.MergeFrom(other.BDGOOPLHFAG);
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
			case 18u:
				if (aBIJBGENKHA_ == null)
				{
					ABIJBGENKHA = new PBMHMEADLEC();
				}
				input.ReadMessage(ABIJBGENKHA);
				break;
			case 26u:
				if (eMFDMIKFIBF_ == null)
				{
					EMFDMIKFIBF = new POIFGDAHJCJ();
				}
				input.ReadMessage(EMFDMIKFIBF);
				break;
			case 34u:
				if (oGAFLPPJIOB_ == null)
				{
					OGAFLPPJIOB = new JDJODLAJBKP();
				}
				input.ReadMessage(OGAFLPPJIOB);
				break;
			case 50u:
				if (lineup_ == null)
				{
					Lineup = new MICOMIBPIOA();
				}
				input.ReadMessage(Lineup);
				break;
			case 58u:
				if (mMAOONPAPDP_ == null)
				{
					MMAOONPAPDP = new KKFANGIJAOF();
				}
				input.ReadMessage(MMAOONPAPDP);
				break;
			case 74u:
				if (itemValue_ == null)
				{
					ItemValue = new PGJNBNANDEE();
				}
				input.ReadMessage(ItemValue);
				break;
			case 82u:
				if (level_ == null)
				{
					Level = new AOIKKHJLKJF();
				}
				input.ReadMessage(Level);
				break;
			case 90u:
				if (mKPEBDAJAJN_ == null)
				{
					MKPEBDAJAJN = new NALJFANPFMA();
				}
				input.ReadMessage(MKPEBDAJAJN);
				break;
			case 106u:
				if (bAAANBEIPBG_ == null)
				{
					BAAANBEIPBG = new CNJHCICPAIC();
				}
				input.ReadMessage(BAAANBEIPBG);
				break;
			case 114u:
				if (hKKIJABGCNA_ == null)
				{
					HKKIJABGCNA = new GCHIOMAJIPI();
				}
				input.ReadMessage(HKKIJABGCNA);
				break;
			case 122u:
				if (bDGOOPLHFAG_ == null)
				{
					BDGOOPLHFAG = new AJAEJNHDNFD();
				}
				input.ReadMessage(BDGOOPLHFAG);
				break;
			}
		}
	}
}
