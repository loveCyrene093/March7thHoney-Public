using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PunkLordBattleResultScNotify : IMessage<PunkLordBattleResultScNotify>, IMessage, IEquatable<PunkLordBattleResultScNotify>, IDeepCloneable<PunkLordBattleResultScNotify>, IBufferMessage
{
	private static readonly MessageParser<PunkLordBattleResultScNotify> _parser = new MessageParser<PunkLordBattleResultScNotify>(() => new PunkLordBattleResultScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FFCDPHMJJKGFieldNumber = 2;

	private PunkLordMonsterBasicInfo fFCDPHMJJKG_;

	public const int FHPOILIMKIIFieldNumber = 8;

	private PHOCECJOBHH fHPOILIMKII_;

	public const int PDBNGNABDJIFieldNumber = 11;

	private uint pDBNGNABDJI_;

	public const int GGHCFMOLDNIFieldNumber = 12;

	private uint gGHCFMOLDNI_;

	public const int MHDJJDNHILKFieldNumber = 15;

	private uint mHDJJDNHILK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PunkLordBattleResultScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PunkLordBattleResultScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterBasicInfo FFCDPHMJJKG
	{
		get
		{
			return fFCDPHMJJKG_;
		}
		set
		{
			fFCDPHMJJKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHOCECJOBHH FHPOILIMKII
	{
		get
		{
			return fHPOILIMKII_;
		}
		set
		{
			fHPOILIMKII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDBNGNABDJI
	{
		get
		{
			return pDBNGNABDJI_;
		}
		set
		{
			pDBNGNABDJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGHCFMOLDNI
	{
		get
		{
			return gGHCFMOLDNI_;
		}
		set
		{
			gGHCFMOLDNI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHDJJDNHILK
	{
		get
		{
			return mHDJJDNHILK_;
		}
		set
		{
			mHDJJDNHILK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordBattleResultScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordBattleResultScNotify(PunkLordBattleResultScNotify other)
		: this()
	{
		fFCDPHMJJKG_ = ((other.fFCDPHMJJKG_ != null) ? other.fFCDPHMJJKG_.Clone() : null);
		fHPOILIMKII_ = ((other.fHPOILIMKII_ != null) ? other.fHPOILIMKII_.Clone() : null);
		pDBNGNABDJI_ = other.pDBNGNABDJI_;
		gGHCFMOLDNI_ = other.gGHCFMOLDNI_;
		mHDJJDNHILK_ = other.mHDJJDNHILK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordBattleResultScNotify Clone()
	{
		return new PunkLordBattleResultScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PunkLordBattleResultScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PunkLordBattleResultScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FFCDPHMJJKG, other.FFCDPHMJJKG))
		{
			return false;
		}
		if (!object.Equals(FHPOILIMKII, other.FHPOILIMKII))
		{
			return false;
		}
		if (PDBNGNABDJI != other.PDBNGNABDJI)
		{
			return false;
		}
		if (GGHCFMOLDNI != other.GGHCFMOLDNI)
		{
			return false;
		}
		if (MHDJJDNHILK != other.MHDJJDNHILK)
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
		if (fFCDPHMJJKG_ != null)
		{
			num ^= FFCDPHMJJKG.GetHashCode();
		}
		if (fHPOILIMKII_ != null)
		{
			num ^= FHPOILIMKII.GetHashCode();
		}
		if (PDBNGNABDJI != 0)
		{
			num ^= PDBNGNABDJI.GetHashCode();
		}
		if (GGHCFMOLDNI != 0)
		{
			num ^= GGHCFMOLDNI.GetHashCode();
		}
		if (MHDJJDNHILK != 0)
		{
			num ^= MHDJJDNHILK.GetHashCode();
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
		if (fFCDPHMJJKG_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(FFCDPHMJJKG);
		}
		if (fHPOILIMKII_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FHPOILIMKII);
		}
		if (PDBNGNABDJI != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PDBNGNABDJI);
		}
		if (GGHCFMOLDNI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GGHCFMOLDNI);
		}
		if (MHDJJDNHILK != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MHDJJDNHILK);
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
		if (fFCDPHMJJKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFCDPHMJJKG);
		}
		if (fHPOILIMKII_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHPOILIMKII);
		}
		if (PDBNGNABDJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDBNGNABDJI);
		}
		if (GGHCFMOLDNI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGHCFMOLDNI);
		}
		if (MHDJJDNHILK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHDJJDNHILK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PunkLordBattleResultScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fFCDPHMJJKG_ != null)
		{
			if (fFCDPHMJJKG_ == null)
			{
				FFCDPHMJJKG = new PunkLordMonsterBasicInfo();
			}
			FFCDPHMJJKG.MergeFrom(other.FFCDPHMJJKG);
		}
		if (other.fHPOILIMKII_ != null)
		{
			if (fHPOILIMKII_ == null)
			{
				FHPOILIMKII = new PHOCECJOBHH();
			}
			FHPOILIMKII.MergeFrom(other.FHPOILIMKII);
		}
		if (other.PDBNGNABDJI != 0)
		{
			PDBNGNABDJI = other.PDBNGNABDJI;
		}
		if (other.GGHCFMOLDNI != 0)
		{
			GGHCFMOLDNI = other.GGHCFMOLDNI;
		}
		if (other.MHDJJDNHILK != 0)
		{
			MHDJJDNHILK = other.MHDJJDNHILK;
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
				if (fFCDPHMJJKG_ == null)
				{
					FFCDPHMJJKG = new PunkLordMonsterBasicInfo();
				}
				input.ReadMessage(FFCDPHMJJKG);
				break;
			case 66u:
				if (fHPOILIMKII_ == null)
				{
					FHPOILIMKII = new PHOCECJOBHH();
				}
				input.ReadMessage(FHPOILIMKII);
				break;
			case 88u:
				PDBNGNABDJI = input.ReadUInt32();
				break;
			case 96u:
				GGHCFMOLDNI = input.ReadUInt32();
				break;
			case 120u:
				MHDJJDNHILK = input.ReadUInt32();
				break;
			}
		}
	}
}
