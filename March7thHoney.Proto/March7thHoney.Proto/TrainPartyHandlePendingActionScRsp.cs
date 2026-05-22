using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyHandlePendingActionScRsp : IMessage<TrainPartyHandlePendingActionScRsp>, IMessage, IEquatable<TrainPartyHandlePendingActionScRsp>, IDeepCloneable<TrainPartyHandlePendingActionScRsp>, IBufferMessage
{
	public enum PNKPCPFBHAAOneofCase
	{
		None = 0,
		DCCFHPBBKMD = 723,
		MDKNHBDNBPP = 1271,
		BNIHEKOJMND = 1357,
		LOOFPCPJPHN = 1836
	}

	private static readonly MessageParser<TrainPartyHandlePendingActionScRsp> _parser = new MessageParser<TrainPartyHandlePendingActionScRsp>(() => new TrainPartyHandlePendingActionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OFCKHGLINAGFieldNumber = 1;

	private MAGFKFCMLJM oFCKHGLINAG_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int QueuePositionFieldNumber = 11;

	private uint queuePosition_;

	public const int KEJOPPIDNPPFieldNumber = 14;

	private bool kEJOPPIDNPP_;

	public const int DCCFHPBBKMDFieldNumber = 723;

	public const int MDKNHBDNBPPFieldNumber = 1271;

	public const int BNIHEKOJMNDFieldNumber = 1357;

	public const int LOOFPCPJPHNFieldNumber = 1836;

	private object pNKPCPFBHAA_;

	private PNKPCPFBHAAOneofCase pNKPCPFBHAACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyHandlePendingActionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyHandlePendingActionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGFKFCMLJM OFCKHGLINAG
	{
		get
		{
			return oFCKHGLINAG_;
		}
		set
		{
			oFCKHGLINAG_ = value;
		}
	}

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
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KEJOPPIDNPP
	{
		get
		{
			return kEJOPPIDNPP_;
		}
		set
		{
			kEJOPPIDNPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOAICPAMNDN DCCFHPBBKMD
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.DCCFHPBBKMD)
			{
				return null;
			}
			return (DOAICPAMNDN)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.DCCFHPBBKMD : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJADKLIBEH MDKNHBDNBPP
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.MDKNHBDNBPP)
			{
				return null;
			}
			return (HKJADKLIBEH)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.MDKNHBDNBPP : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONAMJANOBOM BNIHEKOJMND
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.BNIHEKOJMND)
			{
				return null;
			}
			return (ONAMJANOBOM)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.BNIHEKOJMND : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBDKEHLCDF LOOFPCPJPHN
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.LOOFPCPJPHN)
			{
				return null;
			}
			return (EFBDKEHLCDF)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.LOOFPCPJPHN : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNKPCPFBHAAOneofCase PNKPCPFBHAACase => pNKPCPFBHAACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyHandlePendingActionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyHandlePendingActionScRsp(TrainPartyHandlePendingActionScRsp other)
		: this()
	{
		oFCKHGLINAG_ = ((other.oFCKHGLINAG_ != null) ? other.oFCKHGLINAG_.Clone() : null);
		retcode_ = other.retcode_;
		queuePosition_ = other.queuePosition_;
		kEJOPPIDNPP_ = other.kEJOPPIDNPP_;
		switch (other.PNKPCPFBHAACase)
		{
		case PNKPCPFBHAAOneofCase.DCCFHPBBKMD:
			DCCFHPBBKMD = other.DCCFHPBBKMD.Clone();
			break;
		case PNKPCPFBHAAOneofCase.MDKNHBDNBPP:
			MDKNHBDNBPP = other.MDKNHBDNBPP.Clone();
			break;
		case PNKPCPFBHAAOneofCase.BNIHEKOJMND:
			BNIHEKOJMND = other.BNIHEKOJMND.Clone();
			break;
		case PNKPCPFBHAAOneofCase.LOOFPCPJPHN:
			LOOFPCPJPHN = other.LOOFPCPJPHN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyHandlePendingActionScRsp Clone()
	{
		return new TrainPartyHandlePendingActionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPNKPCPFBHAA()
	{
		pNKPCPFBHAACase_ = PNKPCPFBHAAOneofCase.None;
		pNKPCPFBHAA_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyHandlePendingActionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyHandlePendingActionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OFCKHGLINAG, other.OFCKHGLINAG))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (KEJOPPIDNPP != other.KEJOPPIDNPP)
		{
			return false;
		}
		if (!object.Equals(DCCFHPBBKMD, other.DCCFHPBBKMD))
		{
			return false;
		}
		if (!object.Equals(MDKNHBDNBPP, other.MDKNHBDNBPP))
		{
			return false;
		}
		if (!object.Equals(BNIHEKOJMND, other.BNIHEKOJMND))
		{
			return false;
		}
		if (!object.Equals(LOOFPCPJPHN, other.LOOFPCPJPHN))
		{
			return false;
		}
		if (PNKPCPFBHAACase != other.PNKPCPFBHAACase)
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
		if (oFCKHGLINAG_ != null)
		{
			num ^= OFCKHGLINAG.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (KEJOPPIDNPP)
		{
			num ^= KEJOPPIDNPP.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DCCFHPBBKMD)
		{
			num ^= DCCFHPBBKMD.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MDKNHBDNBPP)
		{
			num ^= MDKNHBDNBPP.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.BNIHEKOJMND)
		{
			num ^= BNIHEKOJMND.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.LOOFPCPJPHN)
		{
			num ^= LOOFPCPJPHN.GetHashCode();
		}
		num ^= (int)pNKPCPFBHAACase_;
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
		if (oFCKHGLINAG_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(OFCKHGLINAG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(QueuePosition);
		}
		if (KEJOPPIDNPP)
		{
			output.WriteRawTag(112);
			output.WriteBool(KEJOPPIDNPP);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DCCFHPBBKMD)
		{
			output.WriteRawTag(154, 45);
			output.WriteMessage(DCCFHPBBKMD);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MDKNHBDNBPP)
		{
			output.WriteRawTag(186, 79);
			output.WriteMessage(MDKNHBDNBPP);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.BNIHEKOJMND)
		{
			output.WriteRawTag(234, 84);
			output.WriteMessage(BNIHEKOJMND);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.LOOFPCPJPHN)
		{
			output.WriteRawTag(226, 114);
			output.WriteMessage(LOOFPCPJPHN);
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
		if (oFCKHGLINAG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFCKHGLINAG);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (KEJOPPIDNPP)
		{
			num += 2;
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DCCFHPBBKMD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DCCFHPBBKMD);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MDKNHBDNBPP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MDKNHBDNBPP);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.BNIHEKOJMND)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BNIHEKOJMND);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.LOOFPCPJPHN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LOOFPCPJPHN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyHandlePendingActionScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oFCKHGLINAG_ != null)
		{
			if (oFCKHGLINAG_ == null)
			{
				OFCKHGLINAG = new MAGFKFCMLJM();
			}
			OFCKHGLINAG.MergeFrom(other.OFCKHGLINAG);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		if (other.KEJOPPIDNPP)
		{
			KEJOPPIDNPP = other.KEJOPPIDNPP;
		}
		switch (other.PNKPCPFBHAACase)
		{
		case PNKPCPFBHAAOneofCase.DCCFHPBBKMD:
			if (DCCFHPBBKMD == null)
			{
				DCCFHPBBKMD = new DOAICPAMNDN();
			}
			DCCFHPBBKMD.MergeFrom(other.DCCFHPBBKMD);
			break;
		case PNKPCPFBHAAOneofCase.MDKNHBDNBPP:
			if (MDKNHBDNBPP == null)
			{
				MDKNHBDNBPP = new HKJADKLIBEH();
			}
			MDKNHBDNBPP.MergeFrom(other.MDKNHBDNBPP);
			break;
		case PNKPCPFBHAAOneofCase.BNIHEKOJMND:
			if (BNIHEKOJMND == null)
			{
				BNIHEKOJMND = new ONAMJANOBOM();
			}
			BNIHEKOJMND.MergeFrom(other.BNIHEKOJMND);
			break;
		case PNKPCPFBHAAOneofCase.LOOFPCPJPHN:
			if (LOOFPCPJPHN == null)
			{
				LOOFPCPJPHN = new EFBDKEHLCDF();
			}
			LOOFPCPJPHN.MergeFrom(other.LOOFPCPJPHN);
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
			case 10u:
				if (oFCKHGLINAG_ == null)
				{
					OFCKHGLINAG = new MAGFKFCMLJM();
				}
				input.ReadMessage(OFCKHGLINAG);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				QueuePosition = input.ReadUInt32();
				break;
			case 112u:
				KEJOPPIDNPP = input.ReadBool();
				break;
			case 5786u:
			{
				DOAICPAMNDN dOAICPAMNDN = new DOAICPAMNDN();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DCCFHPBBKMD)
				{
					dOAICPAMNDN.MergeFrom(DCCFHPBBKMD);
				}
				input.ReadMessage(dOAICPAMNDN);
				DCCFHPBBKMD = dOAICPAMNDN;
				break;
			}
			case 10170u:
			{
				HKJADKLIBEH hKJADKLIBEH = new HKJADKLIBEH();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MDKNHBDNBPP)
				{
					hKJADKLIBEH.MergeFrom(MDKNHBDNBPP);
				}
				input.ReadMessage(hKJADKLIBEH);
				MDKNHBDNBPP = hKJADKLIBEH;
				break;
			}
			case 10858u:
			{
				ONAMJANOBOM oNAMJANOBOM = new ONAMJANOBOM();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.BNIHEKOJMND)
				{
					oNAMJANOBOM.MergeFrom(BNIHEKOJMND);
				}
				input.ReadMessage(oNAMJANOBOM);
				BNIHEKOJMND = oNAMJANOBOM;
				break;
			}
			case 14690u:
			{
				EFBDKEHLCDF eFBDKEHLCDF = new EFBDKEHLCDF();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.LOOFPCPJPHN)
				{
					eFBDKEHLCDF.MergeFrom(LOOFPCPJPHN);
				}
				input.ReadMessage(eFBDKEHLCDF);
				LOOFPCPJPHN = eFBDKEHLCDF;
				break;
			}
			}
		}
	}
}
