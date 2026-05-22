using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGOENENKKCG : IMessage<CGOENENKKCG>, IMessage, IEquatable<CGOENENKKCG>, IDeepCloneable<CGOENENKKCG>, IBufferMessage
{
	public enum GIBNHMDHIJKOneofCase
	{
		None = 0,
		OFAOIMCDHPN = 1,
		LMHACIOCIHE = 2,
		AMKNINAOAHB = 6,
		IAKFBGEHOFN = 10,
		OGNANLCFNPD = 13,
		DONHDAPCJNN = 15
	}

	private static readonly MessageParser<CGOENENKKCG> _parser = new MessageParser<CGOENENKKCG>(() => new CGOENENKKCG());

	private UnknownFieldSet _unknownFields;

	public const int OFAOIMCDHPNFieldNumber = 1;

	public const int LMHACIOCIHEFieldNumber = 2;

	public const int AMKNINAOAHBFieldNumber = 6;

	public const int IAKFBGEHOFNFieldNumber = 10;

	public const int OGNANLCFNPDFieldNumber = 13;

	public const int DONHDAPCJNNFieldNumber = 15;

	private object gIBNHMDHIJK_;

	private GIBNHMDHIJKOneofCase gIBNHMDHIJKCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGOENENKKCG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGOENENKKCGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLCIAECKFJ OFAOIMCDHPN
	{
		get
		{
			if (gIBNHMDHIJKCase_ != GIBNHMDHIJKOneofCase.OFAOIMCDHPN)
			{
				return null;
			}
			return (DMLCIAECKFJ)gIBNHMDHIJK_;
		}
		set
		{
			gIBNHMDHIJK_ = value;
			gIBNHMDHIJKCase_ = ((value != null) ? GIBNHMDHIJKOneofCase.OFAOIMCDHPN : GIBNHMDHIJKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGALGNELBKM LMHACIOCIHE
	{
		get
		{
			if (gIBNHMDHIJKCase_ != GIBNHMDHIJKOneofCase.LMHACIOCIHE)
			{
				return null;
			}
			return (DGALGNELBKM)gIBNHMDHIJK_;
		}
		set
		{
			gIBNHMDHIJK_ = value;
			gIBNHMDHIJKCase_ = ((value != null) ? GIBNHMDHIJKOneofCase.LMHACIOCIHE : GIBNHMDHIJKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBIKLIPBJNO AMKNINAOAHB
	{
		get
		{
			if (gIBNHMDHIJKCase_ != GIBNHMDHIJKOneofCase.AMKNINAOAHB)
			{
				return null;
			}
			return (HBIKLIPBJNO)gIBNHMDHIJK_;
		}
		set
		{
			gIBNHMDHIJK_ = value;
			gIBNHMDHIJKCase_ = ((value != null) ? GIBNHMDHIJKOneofCase.AMKNINAOAHB : GIBNHMDHIJKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLAJKALOBMJ IAKFBGEHOFN
	{
		get
		{
			if (gIBNHMDHIJKCase_ != GIBNHMDHIJKOneofCase.IAKFBGEHOFN)
			{
				return null;
			}
			return (JLAJKALOBMJ)gIBNHMDHIJK_;
		}
		set
		{
			gIBNHMDHIJK_ = value;
			gIBNHMDHIJKCase_ = ((value != null) ? GIBNHMDHIJKOneofCase.IAKFBGEHOFN : GIBNHMDHIJKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBICOFINMIK OGNANLCFNPD
	{
		get
		{
			if (gIBNHMDHIJKCase_ != GIBNHMDHIJKOneofCase.OGNANLCFNPD)
			{
				return null;
			}
			return (GBICOFINMIK)gIBNHMDHIJK_;
		}
		set
		{
			gIBNHMDHIJK_ = value;
			gIBNHMDHIJKCase_ = ((value != null) ? GIBNHMDHIJKOneofCase.OGNANLCFNPD : GIBNHMDHIJKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEFPNAMECCO DONHDAPCJNN
	{
		get
		{
			if (gIBNHMDHIJKCase_ != GIBNHMDHIJKOneofCase.DONHDAPCJNN)
			{
				return null;
			}
			return (AEFPNAMECCO)gIBNHMDHIJK_;
		}
		set
		{
			gIBNHMDHIJK_ = value;
			gIBNHMDHIJKCase_ = ((value != null) ? GIBNHMDHIJKOneofCase.DONHDAPCJNN : GIBNHMDHIJKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GIBNHMDHIJKOneofCase GIBNHMDHIJKCase => gIBNHMDHIJKCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGOENENKKCG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGOENENKKCG(CGOENENKKCG other)
		: this()
	{
		switch (other.GIBNHMDHIJKCase)
		{
		case GIBNHMDHIJKOneofCase.OFAOIMCDHPN:
			OFAOIMCDHPN = other.OFAOIMCDHPN.Clone();
			break;
		case GIBNHMDHIJKOneofCase.LMHACIOCIHE:
			LMHACIOCIHE = other.LMHACIOCIHE.Clone();
			break;
		case GIBNHMDHIJKOneofCase.AMKNINAOAHB:
			AMKNINAOAHB = other.AMKNINAOAHB.Clone();
			break;
		case GIBNHMDHIJKOneofCase.IAKFBGEHOFN:
			IAKFBGEHOFN = other.IAKFBGEHOFN.Clone();
			break;
		case GIBNHMDHIJKOneofCase.OGNANLCFNPD:
			OGNANLCFNPD = other.OGNANLCFNPD.Clone();
			break;
		case GIBNHMDHIJKOneofCase.DONHDAPCJNN:
			DONHDAPCJNN = other.DONHDAPCJNN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGOENENKKCG Clone()
	{
		return new CGOENENKKCG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGIBNHMDHIJK()
	{
		gIBNHMDHIJKCase_ = GIBNHMDHIJKOneofCase.None;
		gIBNHMDHIJK_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGOENENKKCG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGOENENKKCG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OFAOIMCDHPN, other.OFAOIMCDHPN))
		{
			return false;
		}
		if (!object.Equals(LMHACIOCIHE, other.LMHACIOCIHE))
		{
			return false;
		}
		if (!object.Equals(AMKNINAOAHB, other.AMKNINAOAHB))
		{
			return false;
		}
		if (!object.Equals(IAKFBGEHOFN, other.IAKFBGEHOFN))
		{
			return false;
		}
		if (!object.Equals(OGNANLCFNPD, other.OGNANLCFNPD))
		{
			return false;
		}
		if (!object.Equals(DONHDAPCJNN, other.DONHDAPCJNN))
		{
			return false;
		}
		if (GIBNHMDHIJKCase != other.GIBNHMDHIJKCase)
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
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OFAOIMCDHPN)
		{
			num ^= OFAOIMCDHPN.GetHashCode();
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.LMHACIOCIHE)
		{
			num ^= LMHACIOCIHE.GetHashCode();
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.AMKNINAOAHB)
		{
			num ^= AMKNINAOAHB.GetHashCode();
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.IAKFBGEHOFN)
		{
			num ^= IAKFBGEHOFN.GetHashCode();
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OGNANLCFNPD)
		{
			num ^= OGNANLCFNPD.GetHashCode();
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.DONHDAPCJNN)
		{
			num ^= DONHDAPCJNN.GetHashCode();
		}
		num ^= (int)gIBNHMDHIJKCase_;
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
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OFAOIMCDHPN)
		{
			output.WriteRawTag(10);
			output.WriteMessage(OFAOIMCDHPN);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.LMHACIOCIHE)
		{
			output.WriteRawTag(18);
			output.WriteMessage(LMHACIOCIHE);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.AMKNINAOAHB)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AMKNINAOAHB);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.IAKFBGEHOFN)
		{
			output.WriteRawTag(82);
			output.WriteMessage(IAKFBGEHOFN);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OGNANLCFNPD)
		{
			output.WriteRawTag(106);
			output.WriteMessage(OGNANLCFNPD);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.DONHDAPCJNN)
		{
			output.WriteRawTag(122);
			output.WriteMessage(DONHDAPCJNN);
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
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OFAOIMCDHPN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFAOIMCDHPN);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.LMHACIOCIHE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LMHACIOCIHE);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.AMKNINAOAHB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AMKNINAOAHB);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.IAKFBGEHOFN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IAKFBGEHOFN);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OGNANLCFNPD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OGNANLCFNPD);
		}
		if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.DONHDAPCJNN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DONHDAPCJNN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGOENENKKCG other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.GIBNHMDHIJKCase)
		{
		case GIBNHMDHIJKOneofCase.OFAOIMCDHPN:
			if (OFAOIMCDHPN == null)
			{
				OFAOIMCDHPN = new DMLCIAECKFJ();
			}
			OFAOIMCDHPN.MergeFrom(other.OFAOIMCDHPN);
			break;
		case GIBNHMDHIJKOneofCase.LMHACIOCIHE:
			if (LMHACIOCIHE == null)
			{
				LMHACIOCIHE = new DGALGNELBKM();
			}
			LMHACIOCIHE.MergeFrom(other.LMHACIOCIHE);
			break;
		case GIBNHMDHIJKOneofCase.AMKNINAOAHB:
			if (AMKNINAOAHB == null)
			{
				AMKNINAOAHB = new HBIKLIPBJNO();
			}
			AMKNINAOAHB.MergeFrom(other.AMKNINAOAHB);
			break;
		case GIBNHMDHIJKOneofCase.IAKFBGEHOFN:
			if (IAKFBGEHOFN == null)
			{
				IAKFBGEHOFN = new JLAJKALOBMJ();
			}
			IAKFBGEHOFN.MergeFrom(other.IAKFBGEHOFN);
			break;
		case GIBNHMDHIJKOneofCase.OGNANLCFNPD:
			if (OGNANLCFNPD == null)
			{
				OGNANLCFNPD = new GBICOFINMIK();
			}
			OGNANLCFNPD.MergeFrom(other.OGNANLCFNPD);
			break;
		case GIBNHMDHIJKOneofCase.DONHDAPCJNN:
			if (DONHDAPCJNN == null)
			{
				DONHDAPCJNN = new AEFPNAMECCO();
			}
			DONHDAPCJNN.MergeFrom(other.DONHDAPCJNN);
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
			{
				DMLCIAECKFJ dMLCIAECKFJ = new DMLCIAECKFJ();
				if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OFAOIMCDHPN)
				{
					dMLCIAECKFJ.MergeFrom(OFAOIMCDHPN);
				}
				input.ReadMessage(dMLCIAECKFJ);
				OFAOIMCDHPN = dMLCIAECKFJ;
				break;
			}
			case 18u:
			{
				DGALGNELBKM dGALGNELBKM = new DGALGNELBKM();
				if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.LMHACIOCIHE)
				{
					dGALGNELBKM.MergeFrom(LMHACIOCIHE);
				}
				input.ReadMessage(dGALGNELBKM);
				LMHACIOCIHE = dGALGNELBKM;
				break;
			}
			case 50u:
			{
				HBIKLIPBJNO hBIKLIPBJNO = new HBIKLIPBJNO();
				if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.AMKNINAOAHB)
				{
					hBIKLIPBJNO.MergeFrom(AMKNINAOAHB);
				}
				input.ReadMessage(hBIKLIPBJNO);
				AMKNINAOAHB = hBIKLIPBJNO;
				break;
			}
			case 82u:
			{
				JLAJKALOBMJ jLAJKALOBMJ = new JLAJKALOBMJ();
				if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.IAKFBGEHOFN)
				{
					jLAJKALOBMJ.MergeFrom(IAKFBGEHOFN);
				}
				input.ReadMessage(jLAJKALOBMJ);
				IAKFBGEHOFN = jLAJKALOBMJ;
				break;
			}
			case 106u:
			{
				GBICOFINMIK gBICOFINMIK = new GBICOFINMIK();
				if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.OGNANLCFNPD)
				{
					gBICOFINMIK.MergeFrom(OGNANLCFNPD);
				}
				input.ReadMessage(gBICOFINMIK);
				OGNANLCFNPD = gBICOFINMIK;
				break;
			}
			case 122u:
			{
				AEFPNAMECCO aEFPNAMECCO = new AEFPNAMECCO();
				if (gIBNHMDHIJKCase_ == GIBNHMDHIJKOneofCase.DONHDAPCJNN)
				{
					aEFPNAMECCO.MergeFrom(DONHDAPCJNN);
				}
				input.ReadMessage(aEFPNAMECCO);
				DONHDAPCJNN = aEFPNAMECCO;
				break;
			}
			}
		}
	}
}
