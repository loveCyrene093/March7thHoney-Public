using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BPJDOEMBNMD : IMessage<BPJDOEMBNMD>, IMessage, IEquatable<BPJDOEMBNMD>, IDeepCloneable<BPJDOEMBNMD>, IBufferMessage
{
	public enum FLBCMACPHMJOneofCase
	{
		None = 0,
		JAKFADADNON = 8,
		FHECFHDHFJC = 9,
		JBBACLLCFON = 10
	}

	private static readonly MessageParser<BPJDOEMBNMD> _parser = new MessageParser<BPJDOEMBNMD>(() => new BPJDOEMBNMD());

	private UnknownFieldSet _unknownFields;

	public const int PLOBMBFPNFKFieldNumber = 5;

	private FightGameMode pLOBMBFPNFK_;

	public const int PanelIdFieldNumber = 14;

	private uint panelId_;

	public const int JAKFADADNONFieldNumber = 8;

	public const int FHECFHDHFJCFieldNumber = 9;

	public const int JBBACLLCFONFieldNumber = 10;

	private object fLBCMACPHMJ_;

	private FLBCMACPHMJOneofCase fLBCMACPHMJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BPJDOEMBNMD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BPJDOEMBNMDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLCFNEOJGBB JAKFADADNON
	{
		get
		{
			if (fLBCMACPHMJCase_ != FLBCMACPHMJOneofCase.JAKFADADNON)
			{
				return null;
			}
			return (DLCFNEOJGBB)fLBCMACPHMJ_;
		}
		set
		{
			fLBCMACPHMJ_ = value;
			fLBCMACPHMJCase_ = ((value != null) ? FLBCMACPHMJOneofCase.JAKFADADNON : FLBCMACPHMJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCFAJAMPDKF FHECFHDHFJC
	{
		get
		{
			if (fLBCMACPHMJCase_ != FLBCMACPHMJOneofCase.FHECFHDHFJC)
			{
				return null;
			}
			return (BCFAJAMPDKF)fLBCMACPHMJ_;
		}
		set
		{
			fLBCMACPHMJ_ = value;
			fLBCMACPHMJCase_ = ((value != null) ? FLBCMACPHMJOneofCase.FHECFHDHFJC : FLBCMACPHMJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJJDLOCGCL JBBACLLCFON
	{
		get
		{
			if (fLBCMACPHMJCase_ != FLBCMACPHMJOneofCase.JBBACLLCFON)
			{
				return null;
			}
			return (NEJJDLOCGCL)fLBCMACPHMJ_;
		}
		set
		{
			fLBCMACPHMJ_ = value;
			fLBCMACPHMJCase_ = ((value != null) ? FLBCMACPHMJOneofCase.JBBACLLCFON : FLBCMACPHMJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLBCMACPHMJOneofCase FLBCMACPHMJCase => fLBCMACPHMJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPJDOEMBNMD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPJDOEMBNMD(BPJDOEMBNMD other)
		: this()
	{
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		panelId_ = other.panelId_;
		switch (other.FLBCMACPHMJCase)
		{
		case FLBCMACPHMJOneofCase.JAKFADADNON:
			JAKFADADNON = other.JAKFADADNON.Clone();
			break;
		case FLBCMACPHMJOneofCase.FHECFHDHFJC:
			FHECFHDHFJC = other.FHECFHDHFJC.Clone();
			break;
		case FLBCMACPHMJOneofCase.JBBACLLCFON:
			JBBACLLCFON = other.JBBACLLCFON.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPJDOEMBNMD Clone()
	{
		return new BPJDOEMBNMD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFLBCMACPHMJ()
	{
		fLBCMACPHMJCase_ = FLBCMACPHMJOneofCase.None;
		fLBCMACPHMJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BPJDOEMBNMD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BPJDOEMBNMD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (!object.Equals(JAKFADADNON, other.JAKFADADNON))
		{
			return false;
		}
		if (!object.Equals(FHECFHDHFJC, other.FHECFHDHFJC))
		{
			return false;
		}
		if (!object.Equals(JBBACLLCFON, other.JBBACLLCFON))
		{
			return false;
		}
		if (FLBCMACPHMJCase != other.FLBCMACPHMJCase)
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JAKFADADNON)
		{
			num ^= JAKFADADNON.GetHashCode();
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.FHECFHDHFJC)
		{
			num ^= FHECFHDHFJC.GetHashCode();
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JBBACLLCFON)
		{
			num ^= JBBACLLCFON.GetHashCode();
		}
		num ^= (int)fLBCMACPHMJCase_;
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)PLOBMBFPNFK);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JAKFADADNON)
		{
			output.WriteRawTag(66);
			output.WriteMessage(JAKFADADNON);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.FHECFHDHFJC)
		{
			output.WriteRawTag(74);
			output.WriteMessage(FHECFHDHFJC);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JBBACLLCFON)
		{
			output.WriteRawTag(82);
			output.WriteMessage(JBBACLLCFON);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PanelId);
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JAKFADADNON)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JAKFADADNON);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.FHECFHDHFJC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHECFHDHFJC);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JBBACLLCFON)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JBBACLLCFON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BPJDOEMBNMD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			PLOBMBFPNFK = other.PLOBMBFPNFK;
		}
		if (other.PanelId != 0)
		{
			PanelId = other.PanelId;
		}
		switch (other.FLBCMACPHMJCase)
		{
		case FLBCMACPHMJOneofCase.JAKFADADNON:
			if (JAKFADADNON == null)
			{
				JAKFADADNON = new DLCFNEOJGBB();
			}
			JAKFADADNON.MergeFrom(other.JAKFADADNON);
			break;
		case FLBCMACPHMJOneofCase.FHECFHDHFJC:
			if (FHECFHDHFJC == null)
			{
				FHECFHDHFJC = new BCFAJAMPDKF();
			}
			FHECFHDHFJC.MergeFrom(other.FHECFHDHFJC);
			break;
		case FLBCMACPHMJOneofCase.JBBACLLCFON:
			if (JBBACLLCFON == null)
			{
				JBBACLLCFON = new NEJJDLOCGCL();
			}
			JBBACLLCFON.MergeFrom(other.JBBACLLCFON);
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
			case 40u:
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			case 66u:
			{
				DLCFNEOJGBB dLCFNEOJGBB = new DLCFNEOJGBB();
				if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JAKFADADNON)
				{
					dLCFNEOJGBB.MergeFrom(JAKFADADNON);
				}
				input.ReadMessage(dLCFNEOJGBB);
				JAKFADADNON = dLCFNEOJGBB;
				break;
			}
			case 74u:
			{
				BCFAJAMPDKF bCFAJAMPDKF = new BCFAJAMPDKF();
				if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.FHECFHDHFJC)
				{
					bCFAJAMPDKF.MergeFrom(FHECFHDHFJC);
				}
				input.ReadMessage(bCFAJAMPDKF);
				FHECFHDHFJC = bCFAJAMPDKF;
				break;
			}
			case 82u:
			{
				NEJJDLOCGCL nEJJDLOCGCL = new NEJJDLOCGCL();
				if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.JBBACLLCFON)
				{
					nEJJDLOCGCL.MergeFrom(JBBACLLCFON);
				}
				input.ReadMessage(nEJJDLOCGCL);
				JBBACLLCFON = nEJJDLOCGCL;
				break;
			}
			case 112u:
				PanelId = input.ReadUInt32();
				break;
			}
		}
	}
}
