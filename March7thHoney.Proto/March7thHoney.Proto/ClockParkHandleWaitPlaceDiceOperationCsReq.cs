using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkHandleWaitPlaceDiceOperationCsReq : IMessage<ClockParkHandleWaitPlaceDiceOperationCsReq>, IMessage, IEquatable<ClockParkHandleWaitPlaceDiceOperationCsReq>, IDeepCloneable<ClockParkHandleWaitPlaceDiceOperationCsReq>, IBufferMessage
{
	public enum ENMNAMOIEEPOneofCase
	{
		None = 0,
		KILGAJCFIME = 2,
		IKOMEFMEKMC = 3,
		GNMMEFKMHHD = 4,
		HBPAIJHIGOL = 6,
		FAHDMHFECMK = 7,
		DGANABKPHAI = 8,
		BLEFCAFOIBG = 10,
		HJAPLMGAMCO = 14
	}

	private static readonly MessageParser<ClockParkHandleWaitPlaceDiceOperationCsReq> _parser = new MessageParser<ClockParkHandleWaitPlaceDiceOperationCsReq>(() => new ClockParkHandleWaitPlaceDiceOperationCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ScriptIdFieldNumber = 1;

	private uint scriptId_;

	public const int NNFAMOJAHCHFieldNumber = 5;

	private uint nNFAMOJAHCH_;

	public const int KILGAJCFIMEFieldNumber = 2;

	public const int IKOMEFMEKMCFieldNumber = 3;

	public const int GNMMEFKMHHDFieldNumber = 4;

	public const int HBPAIJHIGOLFieldNumber = 6;

	public const int FAHDMHFECMKFieldNumber = 7;

	public const int DGANABKPHAIFieldNumber = 8;

	public const int BLEFCAFOIBGFieldNumber = 10;

	public const int HJAPLMGAMCOFieldNumber = 14;

	private object eNMNAMOIEEP_;

	private ENMNAMOIEEPOneofCase eNMNAMOIEEPCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkHandleWaitPlaceDiceOperationCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkHandleWaitPlaceDiceOperationCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNFAMOJAHCH
	{
		get
		{
			return nNFAMOJAHCH_;
		}
		set
		{
			nNFAMOJAHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMBDHODLE KILGAJCFIME
	{
		get
		{
			if (eNMNAMOIEEPCase_ != ENMNAMOIEEPOneofCase.KILGAJCFIME)
			{
				return null;
			}
			return (EPJMBDHODLE)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ((value != null) ? ENMNAMOIEEPOneofCase.KILGAJCFIME : ENMNAMOIEEPOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INLBCJHIPCI IKOMEFMEKMC
	{
		get
		{
			if (eNMNAMOIEEPCase_ != ENMNAMOIEEPOneofCase.IKOMEFMEKMC)
			{
				return null;
			}
			return (INLBCJHIPCI)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ((value != null) ? ENMNAMOIEEPOneofCase.IKOMEFMEKMC : ENMNAMOIEEPOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBLOIHLJGML GNMMEFKMHHD
	{
		get
		{
			if (eNMNAMOIEEPCase_ != ENMNAMOIEEPOneofCase.GNMMEFKMHHD)
			{
				return null;
			}
			return (MBLOIHLJGML)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ((value != null) ? ENMNAMOIEEPOneofCase.GNMMEFKMHHD : ENMNAMOIEEPOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HADCALJHOFI HBPAIJHIGOL
	{
		get
		{
			if (eNMNAMOIEEPCase_ != ENMNAMOIEEPOneofCase.HBPAIJHIGOL)
			{
				return null;
			}
			return (HADCALJHOFI)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ((value != null) ? ENMNAMOIEEPOneofCase.HBPAIJHIGOL : ENMNAMOIEEPOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FAHDMHFECMK
	{
		get
		{
			if (!HasFAHDMHFECMK)
			{
				return 0u;
			}
			return (uint)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ENMNAMOIEEPOneofCase.FAHDMHFECMK;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFAHDMHFECMK => eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.FAHDMHFECMK;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOCLMGMNEB DGANABKPHAI
	{
		get
		{
			if (eNMNAMOIEEPCase_ != ENMNAMOIEEPOneofCase.DGANABKPHAI)
			{
				return null;
			}
			return (BBOCLMGMNEB)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ((value != null) ? ENMNAMOIEEPOneofCase.DGANABKPHAI : ENMNAMOIEEPOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAPBNLELOBI BLEFCAFOIBG
	{
		get
		{
			if (eNMNAMOIEEPCase_ != ENMNAMOIEEPOneofCase.BLEFCAFOIBG)
			{
				return null;
			}
			return (HAPBNLELOBI)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ((value != null) ? ENMNAMOIEEPOneofCase.BLEFCAFOIBG : ENMNAMOIEEPOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POPPEFJIAJC HJAPLMGAMCO
	{
		get
		{
			if (eNMNAMOIEEPCase_ != ENMNAMOIEEPOneofCase.HJAPLMGAMCO)
			{
				return null;
			}
			return (POPPEFJIAJC)eNMNAMOIEEP_;
		}
		set
		{
			eNMNAMOIEEP_ = value;
			eNMNAMOIEEPCase_ = ((value != null) ? ENMNAMOIEEPOneofCase.HJAPLMGAMCO : ENMNAMOIEEPOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENMNAMOIEEPOneofCase ENMNAMOIEEPCase => eNMNAMOIEEPCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkHandleWaitPlaceDiceOperationCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkHandleWaitPlaceDiceOperationCsReq(ClockParkHandleWaitPlaceDiceOperationCsReq other)
		: this()
	{
		scriptId_ = other.scriptId_;
		nNFAMOJAHCH_ = other.nNFAMOJAHCH_;
		switch (other.ENMNAMOIEEPCase)
		{
		case ENMNAMOIEEPOneofCase.KILGAJCFIME:
			KILGAJCFIME = other.KILGAJCFIME.Clone();
			break;
		case ENMNAMOIEEPOneofCase.IKOMEFMEKMC:
			IKOMEFMEKMC = other.IKOMEFMEKMC.Clone();
			break;
		case ENMNAMOIEEPOneofCase.GNMMEFKMHHD:
			GNMMEFKMHHD = other.GNMMEFKMHHD.Clone();
			break;
		case ENMNAMOIEEPOneofCase.HBPAIJHIGOL:
			HBPAIJHIGOL = other.HBPAIJHIGOL.Clone();
			break;
		case ENMNAMOIEEPOneofCase.FAHDMHFECMK:
			FAHDMHFECMK = other.FAHDMHFECMK;
			break;
		case ENMNAMOIEEPOneofCase.DGANABKPHAI:
			DGANABKPHAI = other.DGANABKPHAI.Clone();
			break;
		case ENMNAMOIEEPOneofCase.BLEFCAFOIBG:
			BLEFCAFOIBG = other.BLEFCAFOIBG.Clone();
			break;
		case ENMNAMOIEEPOneofCase.HJAPLMGAMCO:
			HJAPLMGAMCO = other.HJAPLMGAMCO.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkHandleWaitPlaceDiceOperationCsReq Clone()
	{
		return new ClockParkHandleWaitPlaceDiceOperationCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFAHDMHFECMK()
	{
		if (HasFAHDMHFECMK)
		{
			ClearENMNAMOIEEP();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearENMNAMOIEEP()
	{
		eNMNAMOIEEPCase_ = ENMNAMOIEEPOneofCase.None;
		eNMNAMOIEEP_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkHandleWaitPlaceDiceOperationCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkHandleWaitPlaceDiceOperationCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (NNFAMOJAHCH != other.NNFAMOJAHCH)
		{
			return false;
		}
		if (!object.Equals(KILGAJCFIME, other.KILGAJCFIME))
		{
			return false;
		}
		if (!object.Equals(IKOMEFMEKMC, other.IKOMEFMEKMC))
		{
			return false;
		}
		if (!object.Equals(GNMMEFKMHHD, other.GNMMEFKMHHD))
		{
			return false;
		}
		if (!object.Equals(HBPAIJHIGOL, other.HBPAIJHIGOL))
		{
			return false;
		}
		if (FAHDMHFECMK != other.FAHDMHFECMK)
		{
			return false;
		}
		if (!object.Equals(DGANABKPHAI, other.DGANABKPHAI))
		{
			return false;
		}
		if (!object.Equals(BLEFCAFOIBG, other.BLEFCAFOIBG))
		{
			return false;
		}
		if (!object.Equals(HJAPLMGAMCO, other.HJAPLMGAMCO))
		{
			return false;
		}
		if (ENMNAMOIEEPCase != other.ENMNAMOIEEPCase)
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
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		if (NNFAMOJAHCH != 0)
		{
			num ^= NNFAMOJAHCH.GetHashCode();
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.KILGAJCFIME)
		{
			num ^= KILGAJCFIME.GetHashCode();
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.IKOMEFMEKMC)
		{
			num ^= IKOMEFMEKMC.GetHashCode();
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.GNMMEFKMHHD)
		{
			num ^= GNMMEFKMHHD.GetHashCode();
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HBPAIJHIGOL)
		{
			num ^= HBPAIJHIGOL.GetHashCode();
		}
		if (HasFAHDMHFECMK)
		{
			num ^= FAHDMHFECMK.GetHashCode();
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.DGANABKPHAI)
		{
			num ^= DGANABKPHAI.GetHashCode();
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.BLEFCAFOIBG)
		{
			num ^= BLEFCAFOIBG.GetHashCode();
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HJAPLMGAMCO)
		{
			num ^= HJAPLMGAMCO.GetHashCode();
		}
		num ^= (int)eNMNAMOIEEPCase_;
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
		if (ScriptId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ScriptId);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.KILGAJCFIME)
		{
			output.WriteRawTag(18);
			output.WriteMessage(KILGAJCFIME);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.IKOMEFMEKMC)
		{
			output.WriteRawTag(26);
			output.WriteMessage(IKOMEFMEKMC);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.GNMMEFKMHHD)
		{
			output.WriteRawTag(34);
			output.WriteMessage(GNMMEFKMHHD);
		}
		if (NNFAMOJAHCH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NNFAMOJAHCH);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HBPAIJHIGOL)
		{
			output.WriteRawTag(50);
			output.WriteMessage(HBPAIJHIGOL);
		}
		if (HasFAHDMHFECMK)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FAHDMHFECMK);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.DGANABKPHAI)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DGANABKPHAI);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.BLEFCAFOIBG)
		{
			output.WriteRawTag(82);
			output.WriteMessage(BLEFCAFOIBG);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HJAPLMGAMCO)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HJAPLMGAMCO);
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
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (NNFAMOJAHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNFAMOJAHCH);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.KILGAJCFIME)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KILGAJCFIME);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.IKOMEFMEKMC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IKOMEFMEKMC);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.GNMMEFKMHHD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GNMMEFKMHHD);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HBPAIJHIGOL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HBPAIJHIGOL);
		}
		if (HasFAHDMHFECMK)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAHDMHFECMK);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.DGANABKPHAI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DGANABKPHAI);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.BLEFCAFOIBG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BLEFCAFOIBG);
		}
		if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HJAPLMGAMCO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HJAPLMGAMCO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClockParkHandleWaitPlaceDiceOperationCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ScriptId != 0)
		{
			ScriptId = other.ScriptId;
		}
		if (other.NNFAMOJAHCH != 0)
		{
			NNFAMOJAHCH = other.NNFAMOJAHCH;
		}
		switch (other.ENMNAMOIEEPCase)
		{
		case ENMNAMOIEEPOneofCase.KILGAJCFIME:
			if (KILGAJCFIME == null)
			{
				KILGAJCFIME = new EPJMBDHODLE();
			}
			KILGAJCFIME.MergeFrom(other.KILGAJCFIME);
			break;
		case ENMNAMOIEEPOneofCase.IKOMEFMEKMC:
			if (IKOMEFMEKMC == null)
			{
				IKOMEFMEKMC = new INLBCJHIPCI();
			}
			IKOMEFMEKMC.MergeFrom(other.IKOMEFMEKMC);
			break;
		case ENMNAMOIEEPOneofCase.GNMMEFKMHHD:
			if (GNMMEFKMHHD == null)
			{
				GNMMEFKMHHD = new MBLOIHLJGML();
			}
			GNMMEFKMHHD.MergeFrom(other.GNMMEFKMHHD);
			break;
		case ENMNAMOIEEPOneofCase.HBPAIJHIGOL:
			if (HBPAIJHIGOL == null)
			{
				HBPAIJHIGOL = new HADCALJHOFI();
			}
			HBPAIJHIGOL.MergeFrom(other.HBPAIJHIGOL);
			break;
		case ENMNAMOIEEPOneofCase.FAHDMHFECMK:
			FAHDMHFECMK = other.FAHDMHFECMK;
			break;
		case ENMNAMOIEEPOneofCase.DGANABKPHAI:
			if (DGANABKPHAI == null)
			{
				DGANABKPHAI = new BBOCLMGMNEB();
			}
			DGANABKPHAI.MergeFrom(other.DGANABKPHAI);
			break;
		case ENMNAMOIEEPOneofCase.BLEFCAFOIBG:
			if (BLEFCAFOIBG == null)
			{
				BLEFCAFOIBG = new HAPBNLELOBI();
			}
			BLEFCAFOIBG.MergeFrom(other.BLEFCAFOIBG);
			break;
		case ENMNAMOIEEPOneofCase.HJAPLMGAMCO:
			if (HJAPLMGAMCO == null)
			{
				HJAPLMGAMCO = new POPPEFJIAJC();
			}
			HJAPLMGAMCO.MergeFrom(other.HJAPLMGAMCO);
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
				ScriptId = input.ReadUInt32();
				break;
			case 18u:
			{
				EPJMBDHODLE ePJMBDHODLE = new EPJMBDHODLE();
				if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.KILGAJCFIME)
				{
					ePJMBDHODLE.MergeFrom(KILGAJCFIME);
				}
				input.ReadMessage(ePJMBDHODLE);
				KILGAJCFIME = ePJMBDHODLE;
				break;
			}
			case 26u:
			{
				INLBCJHIPCI iNLBCJHIPCI = new INLBCJHIPCI();
				if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.IKOMEFMEKMC)
				{
					iNLBCJHIPCI.MergeFrom(IKOMEFMEKMC);
				}
				input.ReadMessage(iNLBCJHIPCI);
				IKOMEFMEKMC = iNLBCJHIPCI;
				break;
			}
			case 34u:
			{
				MBLOIHLJGML mBLOIHLJGML = new MBLOIHLJGML();
				if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.GNMMEFKMHHD)
				{
					mBLOIHLJGML.MergeFrom(GNMMEFKMHHD);
				}
				input.ReadMessage(mBLOIHLJGML);
				GNMMEFKMHHD = mBLOIHLJGML;
				break;
			}
			case 40u:
				NNFAMOJAHCH = input.ReadUInt32();
				break;
			case 50u:
			{
				HADCALJHOFI hADCALJHOFI = new HADCALJHOFI();
				if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HBPAIJHIGOL)
				{
					hADCALJHOFI.MergeFrom(HBPAIJHIGOL);
				}
				input.ReadMessage(hADCALJHOFI);
				HBPAIJHIGOL = hADCALJHOFI;
				break;
			}
			case 56u:
				FAHDMHFECMK = input.ReadUInt32();
				break;
			case 66u:
			{
				BBOCLMGMNEB bBOCLMGMNEB = new BBOCLMGMNEB();
				if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.DGANABKPHAI)
				{
					bBOCLMGMNEB.MergeFrom(DGANABKPHAI);
				}
				input.ReadMessage(bBOCLMGMNEB);
				DGANABKPHAI = bBOCLMGMNEB;
				break;
			}
			case 82u:
			{
				HAPBNLELOBI hAPBNLELOBI = new HAPBNLELOBI();
				if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.BLEFCAFOIBG)
				{
					hAPBNLELOBI.MergeFrom(BLEFCAFOIBG);
				}
				input.ReadMessage(hAPBNLELOBI);
				BLEFCAFOIBG = hAPBNLELOBI;
				break;
			}
			case 114u:
			{
				POPPEFJIAJC pOPPEFJIAJC = new POPPEFJIAJC();
				if (eNMNAMOIEEPCase_ == ENMNAMOIEEPOneofCase.HJAPLMGAMCO)
				{
					pOPPEFJIAJC.MergeFrom(HJAPLMGAMCO);
				}
				input.ReadMessage(pOPPEFJIAJC);
				HJAPLMGAMCO = pOPPEFJIAJC;
				break;
			}
			}
		}
	}
}
