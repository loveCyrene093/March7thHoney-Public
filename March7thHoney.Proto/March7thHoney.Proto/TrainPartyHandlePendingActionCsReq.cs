using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyHandlePendingActionCsReq : IMessage<TrainPartyHandlePendingActionCsReq>, IMessage, IEquatable<TrainPartyHandlePendingActionCsReq>, IDeepCloneable<TrainPartyHandlePendingActionCsReq>, IBufferMessage
{
	public enum PNKPCPFBHAAOneofCase
	{
		None = 0,
		MBOGNPKAMIF = 86,
		NJCHJPPFAJO = 1078,
		DJGAPFPHFII = 1185,
		HBKGJOAPOKB = 1601
	}

	private static readonly MessageParser<TrainPartyHandlePendingActionCsReq> _parser = new MessageParser<TrainPartyHandlePendingActionCsReq>(() => new TrainPartyHandlePendingActionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int QueuePositionFieldNumber = 6;

	private uint queuePosition_;

	public const int MBOGNPKAMIFFieldNumber = 86;

	public const int NJCHJPPFAJOFieldNumber = 1078;

	public const int DJGAPFPHFIIFieldNumber = 1185;

	public const int HBKGJOAPOKBFieldNumber = 1601;

	private object pNKPCPFBHAA_;

	private PNKPCPFBHAAOneofCase pNKPCPFBHAACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyHandlePendingActionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyHandlePendingActionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public HLJLGPIFMJD MBOGNPKAMIF
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.MBOGNPKAMIF)
			{
				return null;
			}
			return (HLJLGPIFMJD)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.MBOGNPKAMIF : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOBDIHNLPK NJCHJPPFAJO
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.NJCHJPPFAJO)
			{
				return null;
			}
			return (BJOBDIHNLPK)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.NJCHJPPFAJO : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDAAOJFMALO DJGAPFPHFII
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.DJGAPFPHFII)
			{
				return null;
			}
			return (CDAAOJFMALO)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.DJGAPFPHFII : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BOCNCJANBOM HBKGJOAPOKB
	{
		get
		{
			if (pNKPCPFBHAACase_ != PNKPCPFBHAAOneofCase.HBKGJOAPOKB)
			{
				return null;
			}
			return (BOCNCJANBOM)pNKPCPFBHAA_;
		}
		set
		{
			pNKPCPFBHAA_ = value;
			pNKPCPFBHAACase_ = ((value != null) ? PNKPCPFBHAAOneofCase.HBKGJOAPOKB : PNKPCPFBHAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNKPCPFBHAAOneofCase PNKPCPFBHAACase => pNKPCPFBHAACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyHandlePendingActionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyHandlePendingActionCsReq(TrainPartyHandlePendingActionCsReq other)
		: this()
	{
		queuePosition_ = other.queuePosition_;
		switch (other.PNKPCPFBHAACase)
		{
		case PNKPCPFBHAAOneofCase.MBOGNPKAMIF:
			MBOGNPKAMIF = other.MBOGNPKAMIF.Clone();
			break;
		case PNKPCPFBHAAOneofCase.NJCHJPPFAJO:
			NJCHJPPFAJO = other.NJCHJPPFAJO.Clone();
			break;
		case PNKPCPFBHAAOneofCase.DJGAPFPHFII:
			DJGAPFPHFII = other.DJGAPFPHFII.Clone();
			break;
		case PNKPCPFBHAAOneofCase.HBKGJOAPOKB:
			HBKGJOAPOKB = other.HBKGJOAPOKB.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyHandlePendingActionCsReq Clone()
	{
		return new TrainPartyHandlePendingActionCsReq(this);
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
		return Equals(other as TrainPartyHandlePendingActionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyHandlePendingActionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (!object.Equals(MBOGNPKAMIF, other.MBOGNPKAMIF))
		{
			return false;
		}
		if (!object.Equals(NJCHJPPFAJO, other.NJCHJPPFAJO))
		{
			return false;
		}
		if (!object.Equals(DJGAPFPHFII, other.DJGAPFPHFII))
		{
			return false;
		}
		if (!object.Equals(HBKGJOAPOKB, other.HBKGJOAPOKB))
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MBOGNPKAMIF)
		{
			num ^= MBOGNPKAMIF.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.NJCHJPPFAJO)
		{
			num ^= NJCHJPPFAJO.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DJGAPFPHFII)
		{
			num ^= DJGAPFPHFII.GetHashCode();
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.HBKGJOAPOKB)
		{
			num ^= HBKGJOAPOKB.GetHashCode();
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
		if (QueuePosition != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(QueuePosition);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MBOGNPKAMIF)
		{
			output.WriteRawTag(178, 5);
			output.WriteMessage(MBOGNPKAMIF);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.NJCHJPPFAJO)
		{
			output.WriteRawTag(178, 67);
			output.WriteMessage(NJCHJPPFAJO);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DJGAPFPHFII)
		{
			output.WriteRawTag(138, 74);
			output.WriteMessage(DJGAPFPHFII);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.HBKGJOAPOKB)
		{
			output.WriteRawTag(138, 100);
			output.WriteMessage(HBKGJOAPOKB);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MBOGNPKAMIF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MBOGNPKAMIF);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.NJCHJPPFAJO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NJCHJPPFAJO);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DJGAPFPHFII)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DJGAPFPHFII);
		}
		if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.HBKGJOAPOKB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HBKGJOAPOKB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyHandlePendingActionCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		switch (other.PNKPCPFBHAACase)
		{
		case PNKPCPFBHAAOneofCase.MBOGNPKAMIF:
			if (MBOGNPKAMIF == null)
			{
				MBOGNPKAMIF = new HLJLGPIFMJD();
			}
			MBOGNPKAMIF.MergeFrom(other.MBOGNPKAMIF);
			break;
		case PNKPCPFBHAAOneofCase.NJCHJPPFAJO:
			if (NJCHJPPFAJO == null)
			{
				NJCHJPPFAJO = new BJOBDIHNLPK();
			}
			NJCHJPPFAJO.MergeFrom(other.NJCHJPPFAJO);
			break;
		case PNKPCPFBHAAOneofCase.DJGAPFPHFII:
			if (DJGAPFPHFII == null)
			{
				DJGAPFPHFII = new CDAAOJFMALO();
			}
			DJGAPFPHFII.MergeFrom(other.DJGAPFPHFII);
			break;
		case PNKPCPFBHAAOneofCase.HBKGJOAPOKB:
			if (HBKGJOAPOKB == null)
			{
				HBKGJOAPOKB = new BOCNCJANBOM();
			}
			HBKGJOAPOKB.MergeFrom(other.HBKGJOAPOKB);
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
			case 48u:
				QueuePosition = input.ReadUInt32();
				break;
			case 690u:
			{
				HLJLGPIFMJD hLJLGPIFMJD = new HLJLGPIFMJD();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.MBOGNPKAMIF)
				{
					hLJLGPIFMJD.MergeFrom(MBOGNPKAMIF);
				}
				input.ReadMessage(hLJLGPIFMJD);
				MBOGNPKAMIF = hLJLGPIFMJD;
				break;
			}
			case 8626u:
			{
				BJOBDIHNLPK bJOBDIHNLPK = new BJOBDIHNLPK();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.NJCHJPPFAJO)
				{
					bJOBDIHNLPK.MergeFrom(NJCHJPPFAJO);
				}
				input.ReadMessage(bJOBDIHNLPK);
				NJCHJPPFAJO = bJOBDIHNLPK;
				break;
			}
			case 9482u:
			{
				CDAAOJFMALO cDAAOJFMALO = new CDAAOJFMALO();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.DJGAPFPHFII)
				{
					cDAAOJFMALO.MergeFrom(DJGAPFPHFII);
				}
				input.ReadMessage(cDAAOJFMALO);
				DJGAPFPHFII = cDAAOJFMALO;
				break;
			}
			case 12810u:
			{
				BOCNCJANBOM bOCNCJANBOM = new BOCNCJANBOM();
				if (pNKPCPFBHAACase_ == PNKPCPFBHAAOneofCase.HBKGJOAPOKB)
				{
					bOCNCJANBOM.MergeFrom(HBKGJOAPOKB);
				}
				input.ReadMessage(bOCNCJANBOM);
				HBKGJOAPOKB = bOCNCJANBOM;
				break;
			}
			}
		}
	}
}
