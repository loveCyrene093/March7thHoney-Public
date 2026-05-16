using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetBagScRsp : IMessage<GetBagScRsp>, IMessage, IEquatable<GetBagScRsp>, IDeepCloneable<GetBagScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetBagScRsp> _parser = new MessageParser<GetBagScRsp>(() => new GetBagScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EquipmentListFieldNumber = 1;

	private static readonly FieldCodec<Equipment> _repeated_equipmentList_codec = FieldCodec.ForMessage(10u, Equipment.Parser);

	private readonly RepeatedField<Equipment> equipmentList_ = new RepeatedField<Equipment>();

	public const int MKKDFNDEGABFieldNumber = 2;

	private static readonly FieldCodec<JLAEDKMBGEK> _repeated_mKKDFNDEGAB_codec = FieldCodec.ForMessage(18u, JLAEDKMBGEK.Parser);

	private readonly RepeatedField<JLAEDKMBGEK> mKKDFNDEGAB_ = new RepeatedField<JLAEDKMBGEK>();

	public const int IFNAOGAKHPNFieldNumber = 3;

	private uint iFNAOGAKHPN_;

	public const int WaitDelResourceListFieldNumber = 4;

	private static readonly FieldCodec<WaitDelResource> _repeated_waitDelResourceList_codec = FieldCodec.ForMessage(34u, WaitDelResource.Parser);

	private readonly RepeatedField<WaitDelResource> waitDelResourceList_ = new RepeatedField<WaitDelResource>();

	public const int MAODNHNHLIJFieldNumber = 5;

	private static readonly FieldCodec<TurnFoodSwitch> _repeated_mAODNHNHLIJ_codec = FieldCodec.ForEnum(42u, (TurnFoodSwitch x) => (int)x, (int x) => (TurnFoodSwitch)x);

	private readonly RepeatedField<TurnFoodSwitch> mAODNHNHLIJ_ = new RepeatedField<TurnFoodSwitch>();

	public const int HGHIIKNLJKHFieldNumber = 6;

	private static readonly FieldCodec<PileItem> _repeated_hGHIIKNLJKH_codec = FieldCodec.ForMessage(50u, PileItem.Parser);

	private readonly RepeatedField<PileItem> hGHIIKNLJKH_ = new RepeatedField<PileItem>();

	public const int CBANAKKOMOFFieldNumber = 7;

	private static readonly FieldCodec<Material> _repeated_cBANAKKOMOF_codec = FieldCodec.ForMessage(58u, Material.Parser);

	private readonly RepeatedField<Material> cBANAKKOMOF_ = new RepeatedField<Material>();

	public const int DBPDPHIMBDJFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_dBPDPHIMBDJ_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> dBPDPHIMBDJ_ = new RepeatedField<uint>();

	public const int GHGKCFIFMBBFieldNumber = 9;

	private static readonly FieldCodec<JLAEDKMBGEK> _repeated_gHGKCFIFMBB_codec = FieldCodec.ForMessage(74u, JLAEDKMBGEK.Parser);

	private readonly RepeatedField<JLAEDKMBGEK> gHGKCFIFMBB_ = new RepeatedField<JLAEDKMBGEK>();

	public const int FGEKLBMLHEKFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_fGEKLBMLHEK_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> fGEKLBMLHEK_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int RelicListFieldNumber = 12;

	private static readonly FieldCodec<Relic> _repeated_relicList_codec = FieldCodec.ForMessage(98u, Relic.Parser);

	private readonly RepeatedField<Relic> relicList_ = new RepeatedField<Relic>();

	public const int OKGCGMCMPJJFieldNumber = 13;

	private static readonly FieldCodec<ANDMLIEGPKE> _repeated_oKGCGMCMPJJ_codec = FieldCodec.ForMessage(106u, ANDMLIEGPKE.Parser);

	private readonly RepeatedField<ANDMLIEGPKE> oKGCGMCMPJJ_ = new RepeatedField<ANDMLIEGPKE>();

	public const int IKEAFGCPECKFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_iKEAFGCPECK_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> iKEAFGCPECK_ = new RepeatedField<uint>();

	public const int MaterialListFieldNumber = 15;

	private static readonly FieldCodec<Material> _repeated_materialList_codec = FieldCodec.ForMessage(122u, Material.Parser);

	private readonly RepeatedField<Material> materialList_ = new RepeatedField<Material>();

	public const int PEFMKLKKCFJFieldNumber = 417;

	private static readonly FieldCodec<PFFDAFJLNOO> _repeated_pEFMKLKKCFJ_codec = FieldCodec.ForMessage(3338u, PFFDAFJLNOO.Parser);

	private readonly RepeatedField<PFFDAFJLNOO> pEFMKLKKCFJ_ = new RepeatedField<PFFDAFJLNOO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetBagScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetBagScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Equipment> EquipmentList => equipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JLAEDKMBGEK> MKKDFNDEGAB => mKKDFNDEGAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IFNAOGAKHPN
	{
		get
		{
			return iFNAOGAKHPN_;
		}
		set
		{
			iFNAOGAKHPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<WaitDelResource> WaitDelResourceList => waitDelResourceList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TurnFoodSwitch> MAODNHNHLIJ => mAODNHNHLIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PileItem> HGHIIKNLJKH => hGHIIKNLJKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Material> CBANAKKOMOF => cBANAKKOMOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DBPDPHIMBDJ => dBPDPHIMBDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JLAEDKMBGEK> GHGKCFIFMBB => gHGKCFIFMBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FGEKLBMLHEK => fGEKLBMLHEK_;

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
	public RepeatedField<Relic> RelicList => relicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ANDMLIEGPKE> OKGCGMCMPJJ => oKGCGMCMPJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IKEAFGCPECK => iKEAFGCPECK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Material> MaterialList => materialList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PFFDAFJLNOO> PEFMKLKKCFJ => pEFMKLKKCFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBagScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBagScRsp(GetBagScRsp other)
		: this()
	{
		equipmentList_ = other.equipmentList_.Clone();
		mKKDFNDEGAB_ = other.mKKDFNDEGAB_.Clone();
		iFNAOGAKHPN_ = other.iFNAOGAKHPN_;
		waitDelResourceList_ = other.waitDelResourceList_.Clone();
		mAODNHNHLIJ_ = other.mAODNHNHLIJ_.Clone();
		hGHIIKNLJKH_ = other.hGHIIKNLJKH_.Clone();
		cBANAKKOMOF_ = other.cBANAKKOMOF_.Clone();
		dBPDPHIMBDJ_ = other.dBPDPHIMBDJ_.Clone();
		gHGKCFIFMBB_ = other.gHGKCFIFMBB_.Clone();
		fGEKLBMLHEK_ = other.fGEKLBMLHEK_.Clone();
		retcode_ = other.retcode_;
		relicList_ = other.relicList_.Clone();
		oKGCGMCMPJJ_ = other.oKGCGMCMPJJ_.Clone();
		iKEAFGCPECK_ = other.iKEAFGCPECK_.Clone();
		materialList_ = other.materialList_.Clone();
		pEFMKLKKCFJ_ = other.pEFMKLKKCFJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBagScRsp Clone()
	{
		return new GetBagScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetBagScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetBagScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!equipmentList_.Equals(other.equipmentList_))
		{
			return false;
		}
		if (!mKKDFNDEGAB_.Equals(other.mKKDFNDEGAB_))
		{
			return false;
		}
		if (IFNAOGAKHPN != other.IFNAOGAKHPN)
		{
			return false;
		}
		if (!waitDelResourceList_.Equals(other.waitDelResourceList_))
		{
			return false;
		}
		if (!mAODNHNHLIJ_.Equals(other.mAODNHNHLIJ_))
		{
			return false;
		}
		if (!hGHIIKNLJKH_.Equals(other.hGHIIKNLJKH_))
		{
			return false;
		}
		if (!cBANAKKOMOF_.Equals(other.cBANAKKOMOF_))
		{
			return false;
		}
		if (!dBPDPHIMBDJ_.Equals(other.dBPDPHIMBDJ_))
		{
			return false;
		}
		if (!gHGKCFIFMBB_.Equals(other.gHGKCFIFMBB_))
		{
			return false;
		}
		if (!fGEKLBMLHEK_.Equals(other.fGEKLBMLHEK_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!relicList_.Equals(other.relicList_))
		{
			return false;
		}
		if (!oKGCGMCMPJJ_.Equals(other.oKGCGMCMPJJ_))
		{
			return false;
		}
		if (!iKEAFGCPECK_.Equals(other.iKEAFGCPECK_))
		{
			return false;
		}
		if (!materialList_.Equals(other.materialList_))
		{
			return false;
		}
		if (!pEFMKLKKCFJ_.Equals(other.pEFMKLKKCFJ_))
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
		num ^= equipmentList_.GetHashCode();
		num ^= mKKDFNDEGAB_.GetHashCode();
		if (IFNAOGAKHPN != 0)
		{
			num ^= IFNAOGAKHPN.GetHashCode();
		}
		num ^= waitDelResourceList_.GetHashCode();
		num ^= mAODNHNHLIJ_.GetHashCode();
		num ^= hGHIIKNLJKH_.GetHashCode();
		num ^= cBANAKKOMOF_.GetHashCode();
		num ^= dBPDPHIMBDJ_.GetHashCode();
		num ^= gHGKCFIFMBB_.GetHashCode();
		num ^= fGEKLBMLHEK_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= relicList_.GetHashCode();
		num ^= oKGCGMCMPJJ_.GetHashCode();
		num ^= iKEAFGCPECK_.GetHashCode();
		num ^= materialList_.GetHashCode();
		num ^= pEFMKLKKCFJ_.GetHashCode();
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
		equipmentList_.WriteTo(ref output, _repeated_equipmentList_codec);
		mKKDFNDEGAB_.WriteTo(ref output, _repeated_mKKDFNDEGAB_codec);
		if (IFNAOGAKHPN != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IFNAOGAKHPN);
		}
		waitDelResourceList_.WriteTo(ref output, _repeated_waitDelResourceList_codec);
		mAODNHNHLIJ_.WriteTo(ref output, _repeated_mAODNHNHLIJ_codec);
		hGHIIKNLJKH_.WriteTo(ref output, _repeated_hGHIIKNLJKH_codec);
		cBANAKKOMOF_.WriteTo(ref output, _repeated_cBANAKKOMOF_codec);
		dBPDPHIMBDJ_.WriteTo(ref output, _repeated_dBPDPHIMBDJ_codec);
		gHGKCFIFMBB_.WriteTo(ref output, _repeated_gHGKCFIFMBB_codec);
		fGEKLBMLHEK_.WriteTo(ref output, _repeated_fGEKLBMLHEK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		relicList_.WriteTo(ref output, _repeated_relicList_codec);
		oKGCGMCMPJJ_.WriteTo(ref output, _repeated_oKGCGMCMPJJ_codec);
		iKEAFGCPECK_.WriteTo(ref output, _repeated_iKEAFGCPECK_codec);
		materialList_.WriteTo(ref output, _repeated_materialList_codec);
		pEFMKLKKCFJ_.WriteTo(ref output, _repeated_pEFMKLKKCFJ_codec);
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
		num += equipmentList_.CalculateSize(_repeated_equipmentList_codec);
		num += mKKDFNDEGAB_.CalculateSize(_repeated_mKKDFNDEGAB_codec);
		if (IFNAOGAKHPN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IFNAOGAKHPN);
		}
		num += waitDelResourceList_.CalculateSize(_repeated_waitDelResourceList_codec);
		num += mAODNHNHLIJ_.CalculateSize(_repeated_mAODNHNHLIJ_codec);
		num += hGHIIKNLJKH_.CalculateSize(_repeated_hGHIIKNLJKH_codec);
		num += cBANAKKOMOF_.CalculateSize(_repeated_cBANAKKOMOF_codec);
		num += dBPDPHIMBDJ_.CalculateSize(_repeated_dBPDPHIMBDJ_codec);
		num += gHGKCFIFMBB_.CalculateSize(_repeated_gHGKCFIFMBB_codec);
		num += fGEKLBMLHEK_.CalculateSize(_repeated_fGEKLBMLHEK_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += relicList_.CalculateSize(_repeated_relicList_codec);
		num += oKGCGMCMPJJ_.CalculateSize(_repeated_oKGCGMCMPJJ_codec);
		num += iKEAFGCPECK_.CalculateSize(_repeated_iKEAFGCPECK_codec);
		num += materialList_.CalculateSize(_repeated_materialList_codec);
		num += pEFMKLKKCFJ_.CalculateSize(_repeated_pEFMKLKKCFJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetBagScRsp other)
	{
		if (other != null)
		{
			equipmentList_.Add(other.equipmentList_);
			mKKDFNDEGAB_.Add(other.mKKDFNDEGAB_);
			if (other.IFNAOGAKHPN != 0)
			{
				IFNAOGAKHPN = other.IFNAOGAKHPN;
			}
			waitDelResourceList_.Add(other.waitDelResourceList_);
			mAODNHNHLIJ_.Add(other.mAODNHNHLIJ_);
			hGHIIKNLJKH_.Add(other.hGHIIKNLJKH_);
			cBANAKKOMOF_.Add(other.cBANAKKOMOF_);
			dBPDPHIMBDJ_.Add(other.dBPDPHIMBDJ_);
			gHGKCFIFMBB_.Add(other.gHGKCFIFMBB_);
			fGEKLBMLHEK_.Add(other.fGEKLBMLHEK_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			relicList_.Add(other.relicList_);
			oKGCGMCMPJJ_.Add(other.oKGCGMCMPJJ_);
			iKEAFGCPECK_.Add(other.iKEAFGCPECK_);
			materialList_.Add(other.materialList_);
			pEFMKLKKCFJ_.Add(other.pEFMKLKKCFJ_);
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
				equipmentList_.AddEntriesFrom(ref input, _repeated_equipmentList_codec);
				break;
			case 18u:
				mKKDFNDEGAB_.AddEntriesFrom(ref input, _repeated_mKKDFNDEGAB_codec);
				break;
			case 24u:
				IFNAOGAKHPN = input.ReadUInt32();
				break;
			case 34u:
				waitDelResourceList_.AddEntriesFrom(ref input, _repeated_waitDelResourceList_codec);
				break;
			case 40u:
			case 42u:
				mAODNHNHLIJ_.AddEntriesFrom(ref input, _repeated_mAODNHNHLIJ_codec);
				break;
			case 50u:
				hGHIIKNLJKH_.AddEntriesFrom(ref input, _repeated_hGHIIKNLJKH_codec);
				break;
			case 58u:
				cBANAKKOMOF_.AddEntriesFrom(ref input, _repeated_cBANAKKOMOF_codec);
				break;
			case 64u:
			case 66u:
				dBPDPHIMBDJ_.AddEntriesFrom(ref input, _repeated_dBPDPHIMBDJ_codec);
				break;
			case 74u:
				gHGKCFIFMBB_.AddEntriesFrom(ref input, _repeated_gHGKCFIFMBB_codec);
				break;
			case 80u:
			case 82u:
				fGEKLBMLHEK_.AddEntriesFrom(ref input, _repeated_fGEKLBMLHEK_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
				break;
			case 106u:
				oKGCGMCMPJJ_.AddEntriesFrom(ref input, _repeated_oKGCGMCMPJJ_codec);
				break;
			case 112u:
			case 114u:
				iKEAFGCPECK_.AddEntriesFrom(ref input, _repeated_iKEAFGCPECK_codec);
				break;
			case 122u:
				materialList_.AddEntriesFrom(ref input, _repeated_materialList_codec);
				break;
			case 3338u:
				pEFMKLKKCFJ_.AddEntriesFrom(ref input, _repeated_pEFMKLKKCFJ_codec);
				break;
			}
		}
	}
}
