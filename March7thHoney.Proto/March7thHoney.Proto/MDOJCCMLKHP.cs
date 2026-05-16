using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MDOJCCMLKHP : IMessage<MDOJCCMLKHP>, IMessage, IEquatable<MDOJCCMLKHP>, IDeepCloneable<MDOJCCMLKHP>, IBufferMessage
{
	public enum MOBGECPCNKJOneofCase
	{
		None = 0,
		GLEMHECLMGP = 10,
		StopDesc = 11,
		JHBIKCPLFFJ = 12,
		BCDHOFNMPNG = 13,
		HGNFPBMEAAD = 14
	}

	private static readonly MessageParser<MDOJCCMLKHP> _parser = new MessageParser<MDOJCCMLKHP>(() => new MDOJCCMLKHP());

	private UnknownFieldSet _unknownFields;

	public const int PHKAHAHLDAEFieldNumber = 1;

	private LGNEOKBPPEO pHKAHAHLDAE_;

	public const int AIPBFEOFNDOFieldNumber = 2;

	private string aIPBFEOFNDO_ = "";

	public const int ECIAGLJNPMMFieldNumber = 3;

	private uint eCIAGLJNPMM_;

	public const int GLEMHECLMGPFieldNumber = 10;

	public const int StopDescFieldNumber = 11;

	public const int JHBIKCPLFFJFieldNumber = 12;

	public const int BCDHOFNMPNGFieldNumber = 13;

	public const int HGNFPBMEAADFieldNumber = 14;

	private object mOBGECPCNKJ_;

	private MOBGECPCNKJOneofCase mOBGECPCNKJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MDOJCCMLKHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MDOJCCMLKHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGNEOKBPPEO PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AIPBFEOFNDO
	{
		get
		{
			return aIPBFEOFNDO_;
		}
		set
		{
			aIPBFEOFNDO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ECIAGLJNPMM
	{
		get
		{
			return eCIAGLJNPMM_;
		}
		set
		{
			eCIAGLJNPMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFNMCOIKCNL GLEMHECLMGP
	{
		get
		{
			if (mOBGECPCNKJCase_ != MOBGECPCNKJOneofCase.GLEMHECLMGP)
			{
				return null;
			}
			return (PFNMCOIKCNL)mOBGECPCNKJ_;
		}
		set
		{
			mOBGECPCNKJ_ = value;
			mOBGECPCNKJCase_ = ((value != null) ? MOBGECPCNKJOneofCase.GLEMHECLMGP : MOBGECPCNKJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGBLCLCHHIO StopDesc
	{
		get
		{
			if (mOBGECPCNKJCase_ != MOBGECPCNKJOneofCase.StopDesc)
			{
				return null;
			}
			return (JGBLCLCHHIO)mOBGECPCNKJ_;
		}
		set
		{
			mOBGECPCNKJ_ = value;
			mOBGECPCNKJCase_ = ((value != null) ? MOBGECPCNKJOneofCase.StopDesc : MOBGECPCNKJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAKDPHMIPDL JHBIKCPLFFJ
	{
		get
		{
			if (mOBGECPCNKJCase_ != MOBGECPCNKJOneofCase.JHBIKCPLFFJ)
			{
				return null;
			}
			return (DAKDPHMIPDL)mOBGECPCNKJ_;
		}
		set
		{
			mOBGECPCNKJ_ = value;
			mOBGECPCNKJCase_ = ((value != null) ? MOBGECPCNKJOneofCase.JHBIKCPLFFJ : MOBGECPCNKJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHEACEDGADM BCDHOFNMPNG
	{
		get
		{
			if (mOBGECPCNKJCase_ != MOBGECPCNKJOneofCase.BCDHOFNMPNG)
			{
				return null;
			}
			return (IHEACEDGADM)mOBGECPCNKJ_;
		}
		set
		{
			mOBGECPCNKJ_ = value;
			mOBGECPCNKJCase_ = ((value != null) ? MOBGECPCNKJOneofCase.BCDHOFNMPNG : MOBGECPCNKJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKNNLBGJMGP HGNFPBMEAAD
	{
		get
		{
			if (mOBGECPCNKJCase_ != MOBGECPCNKJOneofCase.HGNFPBMEAAD)
			{
				return null;
			}
			return (MKNNLBGJMGP)mOBGECPCNKJ_;
		}
		set
		{
			mOBGECPCNKJ_ = value;
			mOBGECPCNKJCase_ = ((value != null) ? MOBGECPCNKJOneofCase.HGNFPBMEAAD : MOBGECPCNKJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOBGECPCNKJOneofCase MOBGECPCNKJCase => mOBGECPCNKJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDOJCCMLKHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDOJCCMLKHP(MDOJCCMLKHP other)
		: this()
	{
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		aIPBFEOFNDO_ = other.aIPBFEOFNDO_;
		eCIAGLJNPMM_ = other.eCIAGLJNPMM_;
		switch (other.MOBGECPCNKJCase)
		{
		case MOBGECPCNKJOneofCase.GLEMHECLMGP:
			GLEMHECLMGP = other.GLEMHECLMGP.Clone();
			break;
		case MOBGECPCNKJOneofCase.StopDesc:
			StopDesc = other.StopDesc.Clone();
			break;
		case MOBGECPCNKJOneofCase.JHBIKCPLFFJ:
			JHBIKCPLFFJ = other.JHBIKCPLFFJ.Clone();
			break;
		case MOBGECPCNKJOneofCase.BCDHOFNMPNG:
			BCDHOFNMPNG = other.BCDHOFNMPNG.Clone();
			break;
		case MOBGECPCNKJOneofCase.HGNFPBMEAAD:
			HGNFPBMEAAD = other.HGNFPBMEAAD.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDOJCCMLKHP Clone()
	{
		return new MDOJCCMLKHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMOBGECPCNKJ()
	{
		mOBGECPCNKJCase_ = MOBGECPCNKJOneofCase.None;
		mOBGECPCNKJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MDOJCCMLKHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MDOJCCMLKHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
		{
			return false;
		}
		if (AIPBFEOFNDO != other.AIPBFEOFNDO)
		{
			return false;
		}
		if (ECIAGLJNPMM != other.ECIAGLJNPMM)
		{
			return false;
		}
		if (!object.Equals(GLEMHECLMGP, other.GLEMHECLMGP))
		{
			return false;
		}
		if (!object.Equals(StopDesc, other.StopDesc))
		{
			return false;
		}
		if (!object.Equals(JHBIKCPLFFJ, other.JHBIKCPLFFJ))
		{
			return false;
		}
		if (!object.Equals(BCDHOFNMPNG, other.BCDHOFNMPNG))
		{
			return false;
		}
		if (!object.Equals(HGNFPBMEAAD, other.HGNFPBMEAAD))
		{
			return false;
		}
		if (MOBGECPCNKJCase != other.MOBGECPCNKJCase)
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
		if (PHKAHAHLDAE != LGNEOKBPPEO.Pcpdhelpkem)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
		}
		if (AIPBFEOFNDO.Length != 0)
		{
			num ^= AIPBFEOFNDO.GetHashCode();
		}
		if (ECIAGLJNPMM != 0)
		{
			num ^= ECIAGLJNPMM.GetHashCode();
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.GLEMHECLMGP)
		{
			num ^= GLEMHECLMGP.GetHashCode();
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.StopDesc)
		{
			num ^= StopDesc.GetHashCode();
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.JHBIKCPLFFJ)
		{
			num ^= JHBIKCPLFFJ.GetHashCode();
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.BCDHOFNMPNG)
		{
			num ^= BCDHOFNMPNG.GetHashCode();
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.HGNFPBMEAAD)
		{
			num ^= HGNFPBMEAAD.GetHashCode();
		}
		num ^= (int)mOBGECPCNKJCase_;
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
		if (PHKAHAHLDAE != LGNEOKBPPEO.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)PHKAHAHLDAE);
		}
		if (AIPBFEOFNDO.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AIPBFEOFNDO);
		}
		if (ECIAGLJNPMM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ECIAGLJNPMM);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.GLEMHECLMGP)
		{
			output.WriteRawTag(82);
			output.WriteMessage(GLEMHECLMGP);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.StopDesc)
		{
			output.WriteRawTag(90);
			output.WriteMessage(StopDesc);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.JHBIKCPLFFJ)
		{
			output.WriteRawTag(98);
			output.WriteMessage(JHBIKCPLFFJ);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.BCDHOFNMPNG)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BCDHOFNMPNG);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.HGNFPBMEAAD)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HGNFPBMEAAD);
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
		if (PHKAHAHLDAE != LGNEOKBPPEO.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PHKAHAHLDAE);
		}
		if (AIPBFEOFNDO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AIPBFEOFNDO);
		}
		if (ECIAGLJNPMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ECIAGLJNPMM);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.GLEMHECLMGP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GLEMHECLMGP);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.StopDesc)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StopDesc);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.JHBIKCPLFFJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHBIKCPLFFJ);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.BCDHOFNMPNG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BCDHOFNMPNG);
		}
		if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.HGNFPBMEAAD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HGNFPBMEAAD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MDOJCCMLKHP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PHKAHAHLDAE != LGNEOKBPPEO.Pcpdhelpkem)
		{
			PHKAHAHLDAE = other.PHKAHAHLDAE;
		}
		if (other.AIPBFEOFNDO.Length != 0)
		{
			AIPBFEOFNDO = other.AIPBFEOFNDO;
		}
		if (other.ECIAGLJNPMM != 0)
		{
			ECIAGLJNPMM = other.ECIAGLJNPMM;
		}
		switch (other.MOBGECPCNKJCase)
		{
		case MOBGECPCNKJOneofCase.GLEMHECLMGP:
			if (GLEMHECLMGP == null)
			{
				GLEMHECLMGP = new PFNMCOIKCNL();
			}
			GLEMHECLMGP.MergeFrom(other.GLEMHECLMGP);
			break;
		case MOBGECPCNKJOneofCase.StopDesc:
			if (StopDesc == null)
			{
				StopDesc = new JGBLCLCHHIO();
			}
			StopDesc.MergeFrom(other.StopDesc);
			break;
		case MOBGECPCNKJOneofCase.JHBIKCPLFFJ:
			if (JHBIKCPLFFJ == null)
			{
				JHBIKCPLFFJ = new DAKDPHMIPDL();
			}
			JHBIKCPLFFJ.MergeFrom(other.JHBIKCPLFFJ);
			break;
		case MOBGECPCNKJOneofCase.BCDHOFNMPNG:
			if (BCDHOFNMPNG == null)
			{
				BCDHOFNMPNG = new IHEACEDGADM();
			}
			BCDHOFNMPNG.MergeFrom(other.BCDHOFNMPNG);
			break;
		case MOBGECPCNKJOneofCase.HGNFPBMEAAD:
			if (HGNFPBMEAAD == null)
			{
				HGNFPBMEAAD = new MKNNLBGJMGP();
			}
			HGNFPBMEAAD.MergeFrom(other.HGNFPBMEAAD);
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
				PHKAHAHLDAE = (LGNEOKBPPEO)input.ReadEnum();
				break;
			case 18u:
				AIPBFEOFNDO = input.ReadString();
				break;
			case 24u:
				ECIAGLJNPMM = input.ReadUInt32();
				break;
			case 82u:
			{
				PFNMCOIKCNL pFNMCOIKCNL = new PFNMCOIKCNL();
				if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.GLEMHECLMGP)
				{
					pFNMCOIKCNL.MergeFrom(GLEMHECLMGP);
				}
				input.ReadMessage(pFNMCOIKCNL);
				GLEMHECLMGP = pFNMCOIKCNL;
				break;
			}
			case 90u:
			{
				JGBLCLCHHIO jGBLCLCHHIO = new JGBLCLCHHIO();
				if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.StopDesc)
				{
					jGBLCLCHHIO.MergeFrom(StopDesc);
				}
				input.ReadMessage(jGBLCLCHHIO);
				StopDesc = jGBLCLCHHIO;
				break;
			}
			case 98u:
			{
				DAKDPHMIPDL dAKDPHMIPDL = new DAKDPHMIPDL();
				if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.JHBIKCPLFFJ)
				{
					dAKDPHMIPDL.MergeFrom(JHBIKCPLFFJ);
				}
				input.ReadMessage(dAKDPHMIPDL);
				JHBIKCPLFFJ = dAKDPHMIPDL;
				break;
			}
			case 106u:
			{
				IHEACEDGADM iHEACEDGADM = new IHEACEDGADM();
				if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.BCDHOFNMPNG)
				{
					iHEACEDGADM.MergeFrom(BCDHOFNMPNG);
				}
				input.ReadMessage(iHEACEDGADM);
				BCDHOFNMPNG = iHEACEDGADM;
				break;
			}
			case 114u:
			{
				MKNNLBGJMGP mKNNLBGJMGP = new MKNNLBGJMGP();
				if (mOBGECPCNKJCase_ == MOBGECPCNKJOneofCase.HGNFPBMEAAD)
				{
					mKNNLBGJMGP.MergeFrom(HGNFPBMEAAD);
				}
				input.ReadMessage(mKNNLBGJMGP);
				HGNFPBMEAAD = mKNNLBGJMGP;
				break;
			}
			}
		}
	}
}
