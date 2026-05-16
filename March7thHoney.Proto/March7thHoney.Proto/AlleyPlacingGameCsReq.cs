using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlleyPlacingGameCsReq : IMessage<AlleyPlacingGameCsReq>, IMessage, IEquatable<AlleyPlacingGameCsReq>, IDeepCloneable<AlleyPlacingGameCsReq>, IBufferMessage
{
	private static readonly MessageParser<AlleyPlacingGameCsReq> _parser = new MessageParser<AlleyPlacingGameCsReq>(() => new AlleyPlacingGameCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MAMGGFKGKCEFieldNumber = 3;

	private uint mAMGGFKGKCE_;

	public const int CostTimeFieldNumber = 5;

	private uint costTime_;

	public const int FCDCFAMOHAEFieldNumber = 8;

	private AlleyPlacingShip fCDCFAMOHAE_;

	public const int ONEPNPGPMNOFieldNumber = 9;

	private uint oNEPNPGPMNO_;

	public const int PBDJOIIAKHKFieldNumber = 10;

	private uint pBDJOIIAKHK_;

	public const int KEBODNOMNDJFieldNumber = 11;

	private uint kEBODNOMNDJ_;

	public const int FOBGBGCOKAEFieldNumber = 13;

	private uint fOBGBGCOKAE_;

	public const int BHJPEAABOGPFieldNumber = 14;

	private uint bHJPEAABOGP_;

	public const int OBPNDKPPFGGFieldNumber = 15;

	private uint oBPNDKPPFGG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlleyPlacingGameCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AlleyPlacingGameCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAMGGFKGKCE
	{
		get
		{
			return mAMGGFKGKCE_;
		}
		set
		{
			mAMGGFKGKCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingShip FCDCFAMOHAE
	{
		get
		{
			return fCDCFAMOHAE_;
		}
		set
		{
			fCDCFAMOHAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ONEPNPGPMNO
	{
		get
		{
			return oNEPNPGPMNO_;
		}
		set
		{
			oNEPNPGPMNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBDJOIIAKHK
	{
		get
		{
			return pBDJOIIAKHK_;
		}
		set
		{
			pBDJOIIAKHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEBODNOMNDJ
	{
		get
		{
			return kEBODNOMNDJ_;
		}
		set
		{
			kEBODNOMNDJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOBGBGCOKAE
	{
		get
		{
			return fOBGBGCOKAE_;
		}
		set
		{
			fOBGBGCOKAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHJPEAABOGP
	{
		get
		{
			return bHJPEAABOGP_;
		}
		set
		{
			bHJPEAABOGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OBPNDKPPFGG
	{
		get
		{
			return oBPNDKPPFGG_;
		}
		set
		{
			oBPNDKPPFGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingGameCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingGameCsReq(AlleyPlacingGameCsReq other)
		: this()
	{
		mAMGGFKGKCE_ = other.mAMGGFKGKCE_;
		costTime_ = other.costTime_;
		fCDCFAMOHAE_ = ((other.fCDCFAMOHAE_ != null) ? other.fCDCFAMOHAE_.Clone() : null);
		oNEPNPGPMNO_ = other.oNEPNPGPMNO_;
		pBDJOIIAKHK_ = other.pBDJOIIAKHK_;
		kEBODNOMNDJ_ = other.kEBODNOMNDJ_;
		fOBGBGCOKAE_ = other.fOBGBGCOKAE_;
		bHJPEAABOGP_ = other.bHJPEAABOGP_;
		oBPNDKPPFGG_ = other.oBPNDKPPFGG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingGameCsReq Clone()
	{
		return new AlleyPlacingGameCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AlleyPlacingGameCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlleyPlacingGameCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MAMGGFKGKCE != other.MAMGGFKGKCE)
		{
			return false;
		}
		if (CostTime != other.CostTime)
		{
			return false;
		}
		if (!object.Equals(FCDCFAMOHAE, other.FCDCFAMOHAE))
		{
			return false;
		}
		if (ONEPNPGPMNO != other.ONEPNPGPMNO)
		{
			return false;
		}
		if (PBDJOIIAKHK != other.PBDJOIIAKHK)
		{
			return false;
		}
		if (KEBODNOMNDJ != other.KEBODNOMNDJ)
		{
			return false;
		}
		if (FOBGBGCOKAE != other.FOBGBGCOKAE)
		{
			return false;
		}
		if (BHJPEAABOGP != other.BHJPEAABOGP)
		{
			return false;
		}
		if (OBPNDKPPFGG != other.OBPNDKPPFGG)
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
		if (MAMGGFKGKCE != 0)
		{
			num ^= MAMGGFKGKCE.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
		if (fCDCFAMOHAE_ != null)
		{
			num ^= FCDCFAMOHAE.GetHashCode();
		}
		if (ONEPNPGPMNO != 0)
		{
			num ^= ONEPNPGPMNO.GetHashCode();
		}
		if (PBDJOIIAKHK != 0)
		{
			num ^= PBDJOIIAKHK.GetHashCode();
		}
		if (KEBODNOMNDJ != 0)
		{
			num ^= KEBODNOMNDJ.GetHashCode();
		}
		if (FOBGBGCOKAE != 0)
		{
			num ^= FOBGBGCOKAE.GetHashCode();
		}
		if (BHJPEAABOGP != 0)
		{
			num ^= BHJPEAABOGP.GetHashCode();
		}
		if (OBPNDKPPFGG != 0)
		{
			num ^= OBPNDKPPFGG.GetHashCode();
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
		if (MAMGGFKGKCE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MAMGGFKGKCE);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CostTime);
		}
		if (fCDCFAMOHAE_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FCDCFAMOHAE);
		}
		if (ONEPNPGPMNO != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ONEPNPGPMNO);
		}
		if (PBDJOIIAKHK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PBDJOIIAKHK);
		}
		if (KEBODNOMNDJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KEBODNOMNDJ);
		}
		if (FOBGBGCOKAE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FOBGBGCOKAE);
		}
		if (BHJPEAABOGP != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BHJPEAABOGP);
		}
		if (OBPNDKPPFGG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OBPNDKPPFGG);
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
		if (MAMGGFKGKCE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAMGGFKGKCE);
		}
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (fCDCFAMOHAE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCDCFAMOHAE);
		}
		if (ONEPNPGPMNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ONEPNPGPMNO);
		}
		if (PBDJOIIAKHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBDJOIIAKHK);
		}
		if (KEBODNOMNDJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEBODNOMNDJ);
		}
		if (FOBGBGCOKAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOBGBGCOKAE);
		}
		if (BHJPEAABOGP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHJPEAABOGP);
		}
		if (OBPNDKPPFGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OBPNDKPPFGG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlleyPlacingGameCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MAMGGFKGKCE != 0)
		{
			MAMGGFKGKCE = other.MAMGGFKGKCE;
		}
		if (other.CostTime != 0)
		{
			CostTime = other.CostTime;
		}
		if (other.fCDCFAMOHAE_ != null)
		{
			if (fCDCFAMOHAE_ == null)
			{
				FCDCFAMOHAE = new AlleyPlacingShip();
			}
			FCDCFAMOHAE.MergeFrom(other.FCDCFAMOHAE);
		}
		if (other.ONEPNPGPMNO != 0)
		{
			ONEPNPGPMNO = other.ONEPNPGPMNO;
		}
		if (other.PBDJOIIAKHK != 0)
		{
			PBDJOIIAKHK = other.PBDJOIIAKHK;
		}
		if (other.KEBODNOMNDJ != 0)
		{
			KEBODNOMNDJ = other.KEBODNOMNDJ;
		}
		if (other.FOBGBGCOKAE != 0)
		{
			FOBGBGCOKAE = other.FOBGBGCOKAE;
		}
		if (other.BHJPEAABOGP != 0)
		{
			BHJPEAABOGP = other.BHJPEAABOGP;
		}
		if (other.OBPNDKPPFGG != 0)
		{
			OBPNDKPPFGG = other.OBPNDKPPFGG;
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
			case 24u:
				MAMGGFKGKCE = input.ReadUInt32();
				break;
			case 40u:
				CostTime = input.ReadUInt32();
				break;
			case 66u:
				if (fCDCFAMOHAE_ == null)
				{
					FCDCFAMOHAE = new AlleyPlacingShip();
				}
				input.ReadMessage(FCDCFAMOHAE);
				break;
			case 72u:
				ONEPNPGPMNO = input.ReadUInt32();
				break;
			case 80u:
				PBDJOIIAKHK = input.ReadUInt32();
				break;
			case 88u:
				KEBODNOMNDJ = input.ReadUInt32();
				break;
			case 104u:
				FOBGBGCOKAE = input.ReadUInt32();
				break;
			case 112u:
				BHJPEAABOGP = input.ReadUInt32();
				break;
			case 120u:
				OBPNDKPPFGG = input.ReadUInt32();
				break;
			}
		}
	}
}
