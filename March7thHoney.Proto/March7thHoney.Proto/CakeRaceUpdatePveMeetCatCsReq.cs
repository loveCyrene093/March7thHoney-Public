using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CakeRaceUpdatePveMeetCatCsReq : IMessage<CakeRaceUpdatePveMeetCatCsReq>, IMessage, IEquatable<CakeRaceUpdatePveMeetCatCsReq>, IDeepCloneable<CakeRaceUpdatePveMeetCatCsReq>, IBufferMessage
{
	public enum BJDOCJKICJLOneofCase
	{
		None = 0,
		PPKFLBCMDMO = 3,
		DCFKBEOHNME = 5,
		HPHGIFPKMEL = 8,
		PGHEODJNAFF = 11,
		JNLFICHNLEL = 15
	}

	private static readonly MessageParser<CakeRaceUpdatePveMeetCatCsReq> _parser = new MessageParser<CakeRaceUpdatePveMeetCatCsReq>(() => new CakeRaceUpdatePveMeetCatCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JAFNCOMGABGFieldNumber = 1;

	private uint jAFNCOMGABG_;

	public const int KBALDGNLAKIFieldNumber = 9;

	private uint kBALDGNLAKI_;

	public const int PPKFLBCMDMOFieldNumber = 3;

	public const int DCFKBEOHNMEFieldNumber = 5;

	public const int HPHGIFPKMELFieldNumber = 8;

	public const int PGHEODJNAFFFieldNumber = 11;

	public const int JNLFICHNLELFieldNumber = 15;

	private object bJDOCJKICJL_;

	private BJDOCJKICJLOneofCase bJDOCJKICJLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CakeRaceUpdatePveMeetCatCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CakeRaceUpdatePveMeetCatCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBALDGNLAKI
	{
		get
		{
			return kBALDGNLAKI_;
		}
		set
		{
			kBALDGNLAKI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCFBJAMCNKJ PPKFLBCMDMO
	{
		get
		{
			if (bJDOCJKICJLCase_ != BJDOCJKICJLOneofCase.PPKFLBCMDMO)
			{
				return null;
			}
			return (PCFBJAMCNKJ)bJDOCJKICJL_;
		}
		set
		{
			bJDOCJKICJL_ = value;
			bJDOCJKICJLCase_ = ((value != null) ? BJDOCJKICJLOneofCase.PPKFLBCMDMO : BJDOCJKICJLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DCFKBEOHNME
	{
		get
		{
			if (!HasDCFKBEOHNME)
			{
				return false;
			}
			return (bool)bJDOCJKICJL_;
		}
		set
		{
			bJDOCJKICJL_ = value;
			bJDOCJKICJLCase_ = BJDOCJKICJLOneofCase.DCFKBEOHNME;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDCFKBEOHNME => bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.DCFKBEOHNME;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HPHGIFPKMEL
	{
		get
		{
			if (!HasHPHGIFPKMEL)
			{
				return 0u;
			}
			return (uint)bJDOCJKICJL_;
		}
		set
		{
			bJDOCJKICJL_ = value;
			bJDOCJKICJLCase_ = BJDOCJKICJLOneofCase.HPHGIFPKMEL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHPHGIFPKMEL => bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.HPHGIFPKMEL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PGHEODJNAFF
	{
		get
		{
			if (!HasPGHEODJNAFF)
			{
				return false;
			}
			return (bool)bJDOCJKICJL_;
		}
		set
		{
			bJDOCJKICJL_ = value;
			bJDOCJKICJLCase_ = BJDOCJKICJLOneofCase.PGHEODJNAFF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPGHEODJNAFF => bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.PGHEODJNAFF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOHBHMJCLM JNLFICHNLEL
	{
		get
		{
			if (bJDOCJKICJLCase_ != BJDOCJKICJLOneofCase.JNLFICHNLEL)
			{
				return null;
			}
			return (GEOHBHMJCLM)bJDOCJKICJL_;
		}
		set
		{
			bJDOCJKICJL_ = value;
			bJDOCJKICJLCase_ = ((value != null) ? BJDOCJKICJLOneofCase.JNLFICHNLEL : BJDOCJKICJLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJDOCJKICJLOneofCase BJDOCJKICJLCase => bJDOCJKICJLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceUpdatePveMeetCatCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceUpdatePveMeetCatCsReq(CakeRaceUpdatePveMeetCatCsReq other)
		: this()
	{
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		kBALDGNLAKI_ = other.kBALDGNLAKI_;
		switch (other.BJDOCJKICJLCase)
		{
		case BJDOCJKICJLOneofCase.PPKFLBCMDMO:
			PPKFLBCMDMO = other.PPKFLBCMDMO.Clone();
			break;
		case BJDOCJKICJLOneofCase.DCFKBEOHNME:
			DCFKBEOHNME = other.DCFKBEOHNME;
			break;
		case BJDOCJKICJLOneofCase.HPHGIFPKMEL:
			HPHGIFPKMEL = other.HPHGIFPKMEL;
			break;
		case BJDOCJKICJLOneofCase.PGHEODJNAFF:
			PGHEODJNAFF = other.PGHEODJNAFF;
			break;
		case BJDOCJKICJLOneofCase.JNLFICHNLEL:
			JNLFICHNLEL = other.JNLFICHNLEL.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceUpdatePveMeetCatCsReq Clone()
	{
		return new CakeRaceUpdatePveMeetCatCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDCFKBEOHNME()
	{
		if (HasDCFKBEOHNME)
		{
			ClearBJDOCJKICJL();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHPHGIFPKMEL()
	{
		if (HasHPHGIFPKMEL)
		{
			ClearBJDOCJKICJL();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPGHEODJNAFF()
	{
		if (HasPGHEODJNAFF)
		{
			ClearBJDOCJKICJL();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBJDOCJKICJL()
	{
		bJDOCJKICJLCase_ = BJDOCJKICJLOneofCase.None;
		bJDOCJKICJL_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CakeRaceUpdatePveMeetCatCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CakeRaceUpdatePveMeetCatCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
		{
			return false;
		}
		if (KBALDGNLAKI != other.KBALDGNLAKI)
		{
			return false;
		}
		if (!object.Equals(PPKFLBCMDMO, other.PPKFLBCMDMO))
		{
			return false;
		}
		if (DCFKBEOHNME != other.DCFKBEOHNME)
		{
			return false;
		}
		if (HPHGIFPKMEL != other.HPHGIFPKMEL)
		{
			return false;
		}
		if (PGHEODJNAFF != other.PGHEODJNAFF)
		{
			return false;
		}
		if (!object.Equals(JNLFICHNLEL, other.JNLFICHNLEL))
		{
			return false;
		}
		if (BJDOCJKICJLCase != other.BJDOCJKICJLCase)
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
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
		}
		if (KBALDGNLAKI != 0)
		{
			num ^= KBALDGNLAKI.GetHashCode();
		}
		if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.PPKFLBCMDMO)
		{
			num ^= PPKFLBCMDMO.GetHashCode();
		}
		if (HasDCFKBEOHNME)
		{
			num ^= DCFKBEOHNME.GetHashCode();
		}
		if (HasHPHGIFPKMEL)
		{
			num ^= HPHGIFPKMEL.GetHashCode();
		}
		if (HasPGHEODJNAFF)
		{
			num ^= PGHEODJNAFF.GetHashCode();
		}
		if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.JNLFICHNLEL)
		{
			num ^= JNLFICHNLEL.GetHashCode();
		}
		num ^= (int)bJDOCJKICJLCase_;
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
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JAFNCOMGABG);
		}
		if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.PPKFLBCMDMO)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PPKFLBCMDMO);
		}
		if (HasDCFKBEOHNME)
		{
			output.WriteRawTag(40);
			output.WriteBool(DCFKBEOHNME);
		}
		if (HasHPHGIFPKMEL)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(HPHGIFPKMEL);
		}
		if (KBALDGNLAKI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KBALDGNLAKI);
		}
		if (HasPGHEODJNAFF)
		{
			output.WriteRawTag(88);
			output.WriteBool(PGHEODJNAFF);
		}
		if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.JNLFICHNLEL)
		{
			output.WriteRawTag(122);
			output.WriteMessage(JNLFICHNLEL);
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
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (KBALDGNLAKI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBALDGNLAKI);
		}
		if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.PPKFLBCMDMO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPKFLBCMDMO);
		}
		if (HasDCFKBEOHNME)
		{
			num += 2;
		}
		if (HasHPHGIFPKMEL)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HPHGIFPKMEL);
		}
		if (HasPGHEODJNAFF)
		{
			num += 2;
		}
		if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.JNLFICHNLEL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JNLFICHNLEL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CakeRaceUpdatePveMeetCatCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JAFNCOMGABG != 0)
		{
			JAFNCOMGABG = other.JAFNCOMGABG;
		}
		if (other.KBALDGNLAKI != 0)
		{
			KBALDGNLAKI = other.KBALDGNLAKI;
		}
		switch (other.BJDOCJKICJLCase)
		{
		case BJDOCJKICJLOneofCase.PPKFLBCMDMO:
			if (PPKFLBCMDMO == null)
			{
				PPKFLBCMDMO = new PCFBJAMCNKJ();
			}
			PPKFLBCMDMO.MergeFrom(other.PPKFLBCMDMO);
			break;
		case BJDOCJKICJLOneofCase.DCFKBEOHNME:
			DCFKBEOHNME = other.DCFKBEOHNME;
			break;
		case BJDOCJKICJLOneofCase.HPHGIFPKMEL:
			HPHGIFPKMEL = other.HPHGIFPKMEL;
			break;
		case BJDOCJKICJLOneofCase.PGHEODJNAFF:
			PGHEODJNAFF = other.PGHEODJNAFF;
			break;
		case BJDOCJKICJLOneofCase.JNLFICHNLEL:
			if (JNLFICHNLEL == null)
			{
				JNLFICHNLEL = new GEOHBHMJCLM();
			}
			JNLFICHNLEL.MergeFrom(other.JNLFICHNLEL);
			break;
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
			case 8u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			case 26u:
			{
				PCFBJAMCNKJ pCFBJAMCNKJ = new PCFBJAMCNKJ();
				if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.PPKFLBCMDMO)
				{
					pCFBJAMCNKJ.MergeFrom(PPKFLBCMDMO);
				}
				input.ReadMessage(pCFBJAMCNKJ);
				PPKFLBCMDMO = pCFBJAMCNKJ;
				break;
			}
			case 40u:
				DCFKBEOHNME = input.ReadBool();
				break;
			case 64u:
				HPHGIFPKMEL = input.ReadUInt32();
				break;
			case 72u:
				KBALDGNLAKI = input.ReadUInt32();
				break;
			case 88u:
				PGHEODJNAFF = input.ReadBool();
				break;
			case 122u:
			{
				GEOHBHMJCLM gEOHBHMJCLM = new GEOHBHMJCLM();
				if (bJDOCJKICJLCase_ == BJDOCJKICJLOneofCase.JNLFICHNLEL)
				{
					gEOHBHMJCLM.MergeFrom(JNLFICHNLEL);
				}
				input.ReadMessage(gEOHBHMJCLM);
				JNLFICHNLEL = gEOHBHMJCLM;
				break;
			}
			}
		}
	}
}
