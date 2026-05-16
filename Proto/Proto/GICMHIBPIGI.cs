using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GICMHIBPIGI : IMessage<GICMHIBPIGI>, IMessage, IEquatable<GICMHIBPIGI>, IDeepCloneable<GICMHIBPIGI>, IBufferMessage
{
	public enum OGJDIOHNFDEOneofCase
	{
		None = 0,
		LLCHEAMGFBN = 147,
		LCHAOHEJBOC = 570,
		KHHKJKADACB = 1245,
		FinishInfo = 1537,
		KGKOHNAACEN = 1654
	}

	private static readonly MessageParser<GICMHIBPIGI> _parser = new MessageParser<GICMHIBPIGI>(() => new GICMHIBPIGI());

	private UnknownFieldSet _unknownFields;

	public const int PFCMBDCFFMGFieldNumber = 12;

	private uint pFCMBDCFFMG_;

	public const int LLCHEAMGFBNFieldNumber = 147;

	public const int LCHAOHEJBOCFieldNumber = 570;

	public const int KHHKJKADACBFieldNumber = 1245;

	public const int FinishInfoFieldNumber = 1537;

	public const int KGKOHNAACENFieldNumber = 1654;

	private object oGJDIOHNFDE_;

	private OGJDIOHNFDEOneofCase oGJDIOHNFDECase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GICMHIBPIGI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GICMHIBPIGIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PFCMBDCFFMG
	{
		get
		{
			return pFCMBDCFFMG_;
		}
		set
		{
			pFCMBDCFFMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPBEDFKINJ LLCHEAMGFBN
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.LLCHEAMGFBN)
			{
				return null;
			}
			return (JFPBEDFKINJ)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.LLCHEAMGFBN : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEHBJPIAKE LCHAOHEJBOC
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.LCHAOHEJBOC)
			{
				return null;
			}
			return (JEEHBJPIAKE)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.LCHAOHEJBOC : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPGJPLKHLKJ KHHKJKADACB
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.KHHKJKADACB)
			{
				return null;
			}
			return (OPGJPLKHLKJ)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.KHHKJKADACB : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIKDCCPDJPG FinishInfo
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.FinishInfo)
			{
				return null;
			}
			return (JIKDCCPDJPG)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.FinishInfo : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLKBKNNKFEA KGKOHNAACEN
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.KGKOHNAACEN)
			{
				return null;
			}
			return (MLKBKNNKFEA)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.KGKOHNAACEN : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGJDIOHNFDEOneofCase OGJDIOHNFDECase => oGJDIOHNFDECase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GICMHIBPIGI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GICMHIBPIGI(GICMHIBPIGI other)
		: this()
	{
		pFCMBDCFFMG_ = other.pFCMBDCFFMG_;
		switch (other.OGJDIOHNFDECase)
		{
		case OGJDIOHNFDEOneofCase.LLCHEAMGFBN:
			LLCHEAMGFBN = other.LLCHEAMGFBN.Clone();
			break;
		case OGJDIOHNFDEOneofCase.LCHAOHEJBOC:
			LCHAOHEJBOC = other.LCHAOHEJBOC.Clone();
			break;
		case OGJDIOHNFDEOneofCase.KHHKJKADACB:
			KHHKJKADACB = other.KHHKJKADACB.Clone();
			break;
		case OGJDIOHNFDEOneofCase.FinishInfo:
			FinishInfo = other.FinishInfo.Clone();
			break;
		case OGJDIOHNFDEOneofCase.KGKOHNAACEN:
			KGKOHNAACEN = other.KGKOHNAACEN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GICMHIBPIGI Clone()
	{
		return new GICMHIBPIGI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOGJDIOHNFDE()
	{
		oGJDIOHNFDECase_ = OGJDIOHNFDEOneofCase.None;
		oGJDIOHNFDE_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GICMHIBPIGI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GICMHIBPIGI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PFCMBDCFFMG != other.PFCMBDCFFMG)
		{
			return false;
		}
		if (!object.Equals(LLCHEAMGFBN, other.LLCHEAMGFBN))
		{
			return false;
		}
		if (!object.Equals(LCHAOHEJBOC, other.LCHAOHEJBOC))
		{
			return false;
		}
		if (!object.Equals(KHHKJKADACB, other.KHHKJKADACB))
		{
			return false;
		}
		if (!object.Equals(FinishInfo, other.FinishInfo))
		{
			return false;
		}
		if (!object.Equals(KGKOHNAACEN, other.KGKOHNAACEN))
		{
			return false;
		}
		if (OGJDIOHNFDECase != other.OGJDIOHNFDECase)
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
		if (PFCMBDCFFMG != 0)
		{
			num ^= PFCMBDCFFMG.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LLCHEAMGFBN)
		{
			num ^= LLCHEAMGFBN.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LCHAOHEJBOC)
		{
			num ^= LCHAOHEJBOC.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KHHKJKADACB)
		{
			num ^= KHHKJKADACB.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FinishInfo)
		{
			num ^= FinishInfo.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
		{
			num ^= KGKOHNAACEN.GetHashCode();
		}
		num ^= (int)oGJDIOHNFDECase_;
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
		if (PFCMBDCFFMG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PFCMBDCFFMG);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LLCHEAMGFBN)
		{
			output.WriteRawTag(154, 9);
			output.WriteMessage(LLCHEAMGFBN);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LCHAOHEJBOC)
		{
			output.WriteRawTag(210, 35);
			output.WriteMessage(LCHAOHEJBOC);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KHHKJKADACB)
		{
			output.WriteRawTag(234, 77);
			output.WriteMessage(KHHKJKADACB);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FinishInfo)
		{
			output.WriteRawTag(138, 96);
			output.WriteMessage(FinishInfo);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
		{
			output.WriteRawTag(178, 103);
			output.WriteMessage(KGKOHNAACEN);
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
		if (PFCMBDCFFMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PFCMBDCFFMG);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LLCHEAMGFBN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LLCHEAMGFBN);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LCHAOHEJBOC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LCHAOHEJBOC);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KHHKJKADACB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KHHKJKADACB);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FinishInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FinishInfo);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KGKOHNAACEN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GICMHIBPIGI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PFCMBDCFFMG != 0)
		{
			PFCMBDCFFMG = other.PFCMBDCFFMG;
		}
		switch (other.OGJDIOHNFDECase)
		{
		case OGJDIOHNFDEOneofCase.LLCHEAMGFBN:
			if (LLCHEAMGFBN == null)
			{
				LLCHEAMGFBN = new JFPBEDFKINJ();
			}
			LLCHEAMGFBN.MergeFrom(other.LLCHEAMGFBN);
			break;
		case OGJDIOHNFDEOneofCase.LCHAOHEJBOC:
			if (LCHAOHEJBOC == null)
			{
				LCHAOHEJBOC = new JEEHBJPIAKE();
			}
			LCHAOHEJBOC.MergeFrom(other.LCHAOHEJBOC);
			break;
		case OGJDIOHNFDEOneofCase.KHHKJKADACB:
			if (KHHKJKADACB == null)
			{
				KHHKJKADACB = new OPGJPLKHLKJ();
			}
			KHHKJKADACB.MergeFrom(other.KHHKJKADACB);
			break;
		case OGJDIOHNFDEOneofCase.FinishInfo:
			if (FinishInfo == null)
			{
				FinishInfo = new JIKDCCPDJPG();
			}
			FinishInfo.MergeFrom(other.FinishInfo);
			break;
		case OGJDIOHNFDEOneofCase.KGKOHNAACEN:
			if (KGKOHNAACEN == null)
			{
				KGKOHNAACEN = new MLKBKNNKFEA();
			}
			KGKOHNAACEN.MergeFrom(other.KGKOHNAACEN);
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
			case 96u:
				PFCMBDCFFMG = input.ReadUInt32();
				break;
			case 1178u:
			{
				JFPBEDFKINJ jFPBEDFKINJ = new JFPBEDFKINJ();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LLCHEAMGFBN)
				{
					jFPBEDFKINJ.MergeFrom(LLCHEAMGFBN);
				}
				input.ReadMessage(jFPBEDFKINJ);
				LLCHEAMGFBN = jFPBEDFKINJ;
				break;
			}
			case 4562u:
			{
				JEEHBJPIAKE jEEHBJPIAKE = new JEEHBJPIAKE();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LCHAOHEJBOC)
				{
					jEEHBJPIAKE.MergeFrom(LCHAOHEJBOC);
				}
				input.ReadMessage(jEEHBJPIAKE);
				LCHAOHEJBOC = jEEHBJPIAKE;
				break;
			}
			case 9962u:
			{
				OPGJPLKHLKJ oPGJPLKHLKJ = new OPGJPLKHLKJ();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KHHKJKADACB)
				{
					oPGJPLKHLKJ.MergeFrom(KHHKJKADACB);
				}
				input.ReadMessage(oPGJPLKHLKJ);
				KHHKJKADACB = oPGJPLKHLKJ;
				break;
			}
			case 12298u:
			{
				JIKDCCPDJPG jIKDCCPDJPG = new JIKDCCPDJPG();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FinishInfo)
				{
					jIKDCCPDJPG.MergeFrom(FinishInfo);
				}
				input.ReadMessage(jIKDCCPDJPG);
				FinishInfo = jIKDCCPDJPG;
				break;
			}
			case 13234u:
			{
				MLKBKNNKFEA mLKBKNNKFEA = new MLKBKNNKFEA();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
				{
					mLKBKNNKFEA.MergeFrom(KGKOHNAACEN);
				}
				input.ReadMessage(mLKBKNNKFEA);
				KGKOHNAACEN = mLKBKNNKFEA;
				break;
			}
			}
		}
	}
}
