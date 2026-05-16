using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KPBGMOCCMLA : IMessage<KPBGMOCCMLA>, IMessage, IEquatable<KPBGMOCCMLA>, IDeepCloneable<KPBGMOCCMLA>, IBufferMessage
{
	private static readonly MessageParser<KPBGMOCCMLA> _parser = new MessageParser<KPBGMOCCMLA>(() => new KPBGMOCCMLA());

	private UnknownFieldSet _unknownFields;

	public const int IMBCJKHMOABFieldNumber = 1;

	private static readonly FieldCodec<JCEEENOLDIF> _repeated_iMBCJKHMOAB_codec = FieldCodec.ForMessage(10u, JCEEENOLDIF.Parser);

	private readonly RepeatedField<JCEEENOLDIF> iMBCJKHMOAB_ = new RepeatedField<JCEEENOLDIF>();

	public const int DCKEEAKEOLCFieldNumber = 3;

	private uint dCKEEAKEOLC_;

	public const int MapIdFieldNumber = 4;

	private uint mapId_;

	public const int NLBGEBPPDJOFieldNumber = 7;

	private uint nLBGEBPPDJO_;

	public const int NPHLEPECMAHFieldNumber = 8;

	private uint nPHLEPECMAH_;

	public const int TargetSideFieldNumber = 10;

	private uint targetSide_;

	public const int JBOCOPNEJLBFieldNumber = 11;

	private static readonly FieldCodec<PGNAFAEAIDN> _repeated_jBOCOPNEJLB_codec = FieldCodec.ForMessage(90u, PGNAFAEAIDN.Parser);

	private readonly RepeatedField<PGNAFAEAIDN> jBOCOPNEJLB_ = new RepeatedField<PGNAFAEAIDN>();

	public const int MGIHLOHMOJCFieldNumber = 13;

	private uint mGIHLOHMOJC_;

	public const int JDFDJACPCKCFieldNumber = 14;

	private uint jDFDJACPCKC_;

	public const int AvatarListFieldNumber = 94;

	private static readonly FieldCodec<AOMPLKEILJD> _repeated_avatarList_codec = FieldCodec.ForMessage(754u, AOMPLKEILJD.Parser);

	private readonly RepeatedField<AOMPLKEILJD> avatarList_ = new RepeatedField<AOMPLKEILJD>();

	public const int EOPNFAAPPIOFieldNumber = 150;

	private static readonly FieldCodec<ILDFFLCOFCN> _repeated_eOPNFAAPPIO_codec = FieldCodec.ForMessage(1202u, ILDFFLCOFCN.Parser);

	private readonly RepeatedField<ILDFFLCOFCN> eOPNFAAPPIO_ = new RepeatedField<ILDFFLCOFCN>();

	public const int OPDAJBALNEKFieldNumber = 398;

	private bool oPDAJBALNEK_;

	public const int OJPCGMHCEBNFieldNumber = 861;

	private bool oJPCGMHCEBN_;

	public const int AHAAPPCDLFFFieldNumber = 869;

	private uint aHAAPPCDLFF_;

	public const int BuffListFieldNumber = 1030;

	private static readonly FieldCodec<IKJOFCNBMKF> _repeated_buffList_codec = FieldCodec.ForMessage(8242u, IKJOFCNBMKF.Parser);

	private readonly RepeatedField<IKJOFCNBMKF> buffList_ = new RepeatedField<IKJOFCNBMKF>();

	public const int ItemListFieldNumber = 1070;

	private static readonly FieldCodec<HMKMGAGPAKA> _repeated_itemList_codec = FieldCodec.ForMessage(8562u, HMKMGAGPAKA.Parser);

	private readonly RepeatedField<HMKMGAGPAKA> itemList_ = new RepeatedField<HMKMGAGPAKA>();

	public const int MGMPPOJIGBCFieldNumber = 1500;

	private static readonly FieldCodec<AOMPLKEILJD> _repeated_mGMPPOJIGBC_codec = FieldCodec.ForMessage(12002u, AOMPLKEILJD.Parser);

	private readonly RepeatedField<AOMPLKEILJD> mGMPPOJIGBC_ = new RepeatedField<AOMPLKEILJD>();

	public const int ADMJNJKCDFNFieldNumber = 2046;

	private bool aDMJNJKCDFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KPBGMOCCMLA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KPBGMOCCMLAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCEEENOLDIF> IMBCJKHMOAB => iMBCJKHMOAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCKEEAKEOLC
	{
		get
		{
			return dCKEEAKEOLC_;
		}
		set
		{
			dCKEEAKEOLC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLBGEBPPDJO
	{
		get
		{
			return nLBGEBPPDJO_;
		}
		set
		{
			nLBGEBPPDJO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPHLEPECMAH
	{
		get
		{
			return nPHLEPECMAH_;
		}
		set
		{
			nPHLEPECMAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PGNAFAEAIDN> JBOCOPNEJLB => jBOCOPNEJLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGIHLOHMOJC
	{
		get
		{
			return mGIHLOHMOJC_;
		}
		set
		{
			mGIHLOHMOJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JDFDJACPCKC
	{
		get
		{
			return jDFDJACPCKC_;
		}
		set
		{
			jDFDJACPCKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AOMPLKEILJD> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ILDFFLCOFCN> EOPNFAAPPIO => eOPNFAAPPIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OPDAJBALNEK
	{
		get
		{
			return oPDAJBALNEK_;
		}
		set
		{
			oPDAJBALNEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OJPCGMHCEBN
	{
		get
		{
			return oJPCGMHCEBN_;
		}
		set
		{
			oJPCGMHCEBN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHAAPPCDLFF
	{
		get
		{
			return aHAAPPCDLFF_;
		}
		set
		{
			aHAAPPCDLFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IKJOFCNBMKF> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HMKMGAGPAKA> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AOMPLKEILJD> MGMPPOJIGBC => mGMPPOJIGBC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ADMJNJKCDFN
	{
		get
		{
			return aDMJNJKCDFN_;
		}
		set
		{
			aDMJNJKCDFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPBGMOCCMLA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPBGMOCCMLA(KPBGMOCCMLA other)
		: this()
	{
		iMBCJKHMOAB_ = other.iMBCJKHMOAB_.Clone();
		dCKEEAKEOLC_ = other.dCKEEAKEOLC_;
		mapId_ = other.mapId_;
		nLBGEBPPDJO_ = other.nLBGEBPPDJO_;
		nPHLEPECMAH_ = other.nPHLEPECMAH_;
		targetSide_ = other.targetSide_;
		jBOCOPNEJLB_ = other.jBOCOPNEJLB_.Clone();
		mGIHLOHMOJC_ = other.mGIHLOHMOJC_;
		jDFDJACPCKC_ = other.jDFDJACPCKC_;
		avatarList_ = other.avatarList_.Clone();
		eOPNFAAPPIO_ = other.eOPNFAAPPIO_.Clone();
		oPDAJBALNEK_ = other.oPDAJBALNEK_;
		oJPCGMHCEBN_ = other.oJPCGMHCEBN_;
		aHAAPPCDLFF_ = other.aHAAPPCDLFF_;
		buffList_ = other.buffList_.Clone();
		itemList_ = other.itemList_.Clone();
		mGMPPOJIGBC_ = other.mGMPPOJIGBC_.Clone();
		aDMJNJKCDFN_ = other.aDMJNJKCDFN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPBGMOCCMLA Clone()
	{
		return new KPBGMOCCMLA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KPBGMOCCMLA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KPBGMOCCMLA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iMBCJKHMOAB_.Equals(other.iMBCJKHMOAB_))
		{
			return false;
		}
		if (DCKEEAKEOLC != other.DCKEEAKEOLC)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (NLBGEBPPDJO != other.NLBGEBPPDJO)
		{
			return false;
		}
		if (NPHLEPECMAH != other.NPHLEPECMAH)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (!jBOCOPNEJLB_.Equals(other.jBOCOPNEJLB_))
		{
			return false;
		}
		if (MGIHLOHMOJC != other.MGIHLOHMOJC)
		{
			return false;
		}
		if (JDFDJACPCKC != other.JDFDJACPCKC)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!eOPNFAAPPIO_.Equals(other.eOPNFAAPPIO_))
		{
			return false;
		}
		if (OPDAJBALNEK != other.OPDAJBALNEK)
		{
			return false;
		}
		if (OJPCGMHCEBN != other.OJPCGMHCEBN)
		{
			return false;
		}
		if (AHAAPPCDLFF != other.AHAAPPCDLFF)
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (!mGMPPOJIGBC_.Equals(other.mGMPPOJIGBC_))
		{
			return false;
		}
		if (ADMJNJKCDFN != other.ADMJNJKCDFN)
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
		num ^= iMBCJKHMOAB_.GetHashCode();
		if (DCKEEAKEOLC != 0)
		{
			num ^= DCKEEAKEOLC.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (NLBGEBPPDJO != 0)
		{
			num ^= NLBGEBPPDJO.GetHashCode();
		}
		if (NPHLEPECMAH != 0)
		{
			num ^= NPHLEPECMAH.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		num ^= jBOCOPNEJLB_.GetHashCode();
		if (MGIHLOHMOJC != 0)
		{
			num ^= MGIHLOHMOJC.GetHashCode();
		}
		if (JDFDJACPCKC != 0)
		{
			num ^= JDFDJACPCKC.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		num ^= eOPNFAAPPIO_.GetHashCode();
		if (OPDAJBALNEK)
		{
			num ^= OPDAJBALNEK.GetHashCode();
		}
		if (OJPCGMHCEBN)
		{
			num ^= OJPCGMHCEBN.GetHashCode();
		}
		if (AHAAPPCDLFF != 0)
		{
			num ^= AHAAPPCDLFF.GetHashCode();
		}
		num ^= buffList_.GetHashCode();
		num ^= itemList_.GetHashCode();
		num ^= mGMPPOJIGBC_.GetHashCode();
		if (ADMJNJKCDFN)
		{
			num ^= ADMJNJKCDFN.GetHashCode();
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
		iMBCJKHMOAB_.WriteTo(ref output, _repeated_iMBCJKHMOAB_codec);
		if (DCKEEAKEOLC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DCKEEAKEOLC);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MapId);
		}
		if (NLBGEBPPDJO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NLBGEBPPDJO);
		}
		if (NPHLEPECMAH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NPHLEPECMAH);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(TargetSide);
		}
		jBOCOPNEJLB_.WriteTo(ref output, _repeated_jBOCOPNEJLB_codec);
		if (MGIHLOHMOJC != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MGIHLOHMOJC);
		}
		if (JDFDJACPCKC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JDFDJACPCKC);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		eOPNFAAPPIO_.WriteTo(ref output, _repeated_eOPNFAAPPIO_codec);
		if (OPDAJBALNEK)
		{
			output.WriteRawTag(240, 24);
			output.WriteBool(OPDAJBALNEK);
		}
		if (OJPCGMHCEBN)
		{
			output.WriteRawTag(232, 53);
			output.WriteBool(OJPCGMHCEBN);
		}
		if (AHAAPPCDLFF != 0)
		{
			output.WriteRawTag(168, 54);
			output.WriteUInt32(AHAAPPCDLFF);
		}
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		mGMPPOJIGBC_.WriteTo(ref output, _repeated_mGMPPOJIGBC_codec);
		if (ADMJNJKCDFN)
		{
			output.WriteRawTag(240, 127);
			output.WriteBool(ADMJNJKCDFN);
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
		num += iMBCJKHMOAB_.CalculateSize(_repeated_iMBCJKHMOAB_codec);
		if (DCKEEAKEOLC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCKEEAKEOLC);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (NLBGEBPPDJO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLBGEBPPDJO);
		}
		if (NPHLEPECMAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPHLEPECMAH);
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		num += jBOCOPNEJLB_.CalculateSize(_repeated_jBOCOPNEJLB_codec);
		if (MGIHLOHMOJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGIHLOHMOJC);
		}
		if (JDFDJACPCKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JDFDJACPCKC);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += eOPNFAAPPIO_.CalculateSize(_repeated_eOPNFAAPPIO_codec);
		if (OPDAJBALNEK)
		{
			num += 3;
		}
		if (OJPCGMHCEBN)
		{
			num += 3;
		}
		if (AHAAPPCDLFF != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AHAAPPCDLFF);
		}
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		num += mGMPPOJIGBC_.CalculateSize(_repeated_mGMPPOJIGBC_codec);
		if (ADMJNJKCDFN)
		{
			num += 3;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KPBGMOCCMLA other)
	{
		if (other != null)
		{
			iMBCJKHMOAB_.Add(other.iMBCJKHMOAB_);
			if (other.DCKEEAKEOLC != 0)
			{
				DCKEEAKEOLC = other.DCKEEAKEOLC;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.NLBGEBPPDJO != 0)
			{
				NLBGEBPPDJO = other.NLBGEBPPDJO;
			}
			if (other.NPHLEPECMAH != 0)
			{
				NPHLEPECMAH = other.NPHLEPECMAH;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			jBOCOPNEJLB_.Add(other.jBOCOPNEJLB_);
			if (other.MGIHLOHMOJC != 0)
			{
				MGIHLOHMOJC = other.MGIHLOHMOJC;
			}
			if (other.JDFDJACPCKC != 0)
			{
				JDFDJACPCKC = other.JDFDJACPCKC;
			}
			avatarList_.Add(other.avatarList_);
			eOPNFAAPPIO_.Add(other.eOPNFAAPPIO_);
			if (other.OPDAJBALNEK)
			{
				OPDAJBALNEK = other.OPDAJBALNEK;
			}
			if (other.OJPCGMHCEBN)
			{
				OJPCGMHCEBN = other.OJPCGMHCEBN;
			}
			if (other.AHAAPPCDLFF != 0)
			{
				AHAAPPCDLFF = other.AHAAPPCDLFF;
			}
			buffList_.Add(other.buffList_);
			itemList_.Add(other.itemList_);
			mGMPPOJIGBC_.Add(other.mGMPPOJIGBC_);
			if (other.ADMJNJKCDFN)
			{
				ADMJNJKCDFN = other.ADMJNJKCDFN;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				iMBCJKHMOAB_.AddEntriesFrom(ref input, _repeated_iMBCJKHMOAB_codec);
				break;
			case 24u:
				DCKEEAKEOLC = input.ReadUInt32();
				break;
			case 32u:
				MapId = input.ReadUInt32();
				break;
			case 56u:
				NLBGEBPPDJO = input.ReadUInt32();
				break;
			case 64u:
				NPHLEPECMAH = input.ReadUInt32();
				break;
			case 80u:
				TargetSide = input.ReadUInt32();
				break;
			case 90u:
				jBOCOPNEJLB_.AddEntriesFrom(ref input, _repeated_jBOCOPNEJLB_codec);
				break;
			case 104u:
				MGIHLOHMOJC = input.ReadUInt32();
				break;
			case 112u:
				JDFDJACPCKC = input.ReadUInt32();
				break;
			case 754u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 1202u:
				eOPNFAAPPIO_.AddEntriesFrom(ref input, _repeated_eOPNFAAPPIO_codec);
				break;
			case 3184u:
				OPDAJBALNEK = input.ReadBool();
				break;
			case 6888u:
				OJPCGMHCEBN = input.ReadBool();
				break;
			case 6952u:
				AHAAPPCDLFF = input.ReadUInt32();
				break;
			case 8242u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 8562u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 12002u:
				mGMPPOJIGBC_.AddEntriesFrom(ref input, _repeated_mGMPPOJIGBC_codec);
				break;
			case 16368u:
				ADMJNJKCDFN = input.ReadBool();
				break;
			}
		}
	}
}
