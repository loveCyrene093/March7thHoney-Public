using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightLevelInfo : IMessage<GridFightLevelInfo>, IMessage, IEquatable<GridFightLevelInfo>, IDeepCloneable<GridFightLevelInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightLevelInfo> _parser = new MessageParser<GridFightLevelInfo>(() => new GridFightLevelInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightAffixListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_gridFightAffixList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> gridFightAffixList_ = new RepeatedField<uint>();

	public const int BossInfoFieldNumber = 2;

	private GridFightBossInfo bossInfo_;

	public const int DCPKPNLKGMMFieldNumber = 3;

	private uint dCPKPNLKGMM_;

	public const int HGAHMIPIBLOFieldNumber = 4;

	private static readonly FieldCodec<OPBCCOLPDPC> _repeated_hGAHMIPIBLO_codec = FieldCodec.ForMessage(34u, OPBCCOLPDPC.Parser);

	private readonly RepeatedField<OPBCCOLPDPC> hGAHMIPIBLO_ = new RepeatedField<OPBCCOLPDPC>();

	public const int CMHBDMOJJENFieldNumber = 5;

	private IKFEDFBLOOG cMHBDMOJJEN_;

	public const int ECCGJDMOGANFieldNumber = 6;

	private DDJIOFONKME eCCGJDMOGAN_;

	public const int GridFightPortalBuffListFieldNumber = 7;

	private static readonly FieldCodec<GridFightGamePortalBuffInfo> _repeated_gridFightPortalBuffList_codec = FieldCodec.ForMessage(58u, GridFightGamePortalBuffInfo.Parser);

	private readonly RepeatedField<GridFightGamePortalBuffInfo> gridFightPortalBuffList_ = new RepeatedField<GridFightGamePortalBuffInfo>();

	public const int SectionIdFieldNumber = 9;

	private uint sectionId_;

	public const int IAKFPMOEJLFFieldNumber = 11;

	private static readonly FieldCodec<DIBJGAKOCLO> _repeated_iAKFPMOEJLF_codec = FieldCodec.ForMessage(90u, DIBJGAKOCLO.Parser);

	private readonly RepeatedField<DIBJGAKOCLO> iAKFPMOEJLF_ = new RepeatedField<DIBJGAKOCLO>();

	public const int GridFightLayerInfoFieldNumber = 12;

	private GridFightLayerInfo gridFightLayerInfo_;

	public const int NDOCIKPLKIFFieldNumber = 13;

	private uint nDOCIKPLKIF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightLevelInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightLevelInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightAffixList => gridFightAffixList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBossInfo BossInfo
	{
		get
		{
			return bossInfo_;
		}
		set
		{
			bossInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OPBCCOLPDPC> HGAHMIPIBLO => hGAHMIPIBLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKFEDFBLOOG CMHBDMOJJEN
	{
		get
		{
			return cMHBDMOJJEN_;
		}
		set
		{
			cMHBDMOJJEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJIOFONKME ECCGJDMOGAN
	{
		get
		{
			return eCCGJDMOGAN_;
		}
		set
		{
			eCCGJDMOGAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightGamePortalBuffInfo> GridFightPortalBuffList => gridFightPortalBuffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DIBJGAKOCLO> IAKFPMOEJLF => iAKFPMOEJLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLayerInfo GridFightLayerInfo
	{
		get
		{
			return gridFightLayerInfo_;
		}
		set
		{
			gridFightLayerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDOCIKPLKIF
	{
		get
		{
			return nDOCIKPLKIF_;
		}
		set
		{
			nDOCIKPLKIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelInfo(GridFightLevelInfo other)
		: this()
	{
		gridFightAffixList_ = other.gridFightAffixList_.Clone();
		bossInfo_ = ((other.bossInfo_ != null) ? other.bossInfo_.Clone() : null);
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		hGAHMIPIBLO_ = other.hGAHMIPIBLO_.Clone();
		cMHBDMOJJEN_ = ((other.cMHBDMOJJEN_ != null) ? other.cMHBDMOJJEN_.Clone() : null);
		eCCGJDMOGAN_ = ((other.eCCGJDMOGAN_ != null) ? other.eCCGJDMOGAN_.Clone() : null);
		gridFightPortalBuffList_ = other.gridFightPortalBuffList_.Clone();
		sectionId_ = other.sectionId_;
		iAKFPMOEJLF_ = other.iAKFPMOEJLF_.Clone();
		gridFightLayerInfo_ = ((other.gridFightLayerInfo_ != null) ? other.gridFightLayerInfo_.Clone() : null);
		nDOCIKPLKIF_ = other.nDOCIKPLKIF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelInfo Clone()
	{
		return new GridFightLevelInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightLevelInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightLevelInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightAffixList_.Equals(other.gridFightAffixList_))
		{
			return false;
		}
		if (!object.Equals(BossInfo, other.BossInfo))
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (!hGAHMIPIBLO_.Equals(other.hGAHMIPIBLO_))
		{
			return false;
		}
		if (!object.Equals(CMHBDMOJJEN, other.CMHBDMOJJEN))
		{
			return false;
		}
		if (!object.Equals(ECCGJDMOGAN, other.ECCGJDMOGAN))
		{
			return false;
		}
		if (!gridFightPortalBuffList_.Equals(other.gridFightPortalBuffList_))
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (!iAKFPMOEJLF_.Equals(other.iAKFPMOEJLF_))
		{
			return false;
		}
		if (!object.Equals(GridFightLayerInfo, other.GridFightLayerInfo))
		{
			return false;
		}
		if (NDOCIKPLKIF != other.NDOCIKPLKIF)
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
		num ^= gridFightAffixList_.GetHashCode();
		if (bossInfo_ != null)
		{
			num ^= BossInfo.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		num ^= hGAHMIPIBLO_.GetHashCode();
		if (cMHBDMOJJEN_ != null)
		{
			num ^= CMHBDMOJJEN.GetHashCode();
		}
		if (eCCGJDMOGAN_ != null)
		{
			num ^= ECCGJDMOGAN.GetHashCode();
		}
		num ^= gridFightPortalBuffList_.GetHashCode();
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		num ^= iAKFPMOEJLF_.GetHashCode();
		if (gridFightLayerInfo_ != null)
		{
			num ^= GridFightLayerInfo.GetHashCode();
		}
		if (NDOCIKPLKIF != 0)
		{
			num ^= NDOCIKPLKIF.GetHashCode();
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
		gridFightAffixList_.WriteTo(ref output, _repeated_gridFightAffixList_codec);
		if (bossInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BossInfo);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		hGAHMIPIBLO_.WriteTo(ref output, _repeated_hGAHMIPIBLO_codec);
		if (cMHBDMOJJEN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CMHBDMOJJEN);
		}
		if (eCCGJDMOGAN_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ECCGJDMOGAN);
		}
		gridFightPortalBuffList_.WriteTo(ref output, _repeated_gridFightPortalBuffList_codec);
		if (SectionId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(SectionId);
		}
		iAKFPMOEJLF_.WriteTo(ref output, _repeated_iAKFPMOEJLF_codec);
		if (gridFightLayerInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(GridFightLayerInfo);
		}
		if (NDOCIKPLKIF != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NDOCIKPLKIF);
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
		num += gridFightAffixList_.CalculateSize(_repeated_gridFightAffixList_codec);
		if (bossInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BossInfo);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		num += hGAHMIPIBLO_.CalculateSize(_repeated_hGAHMIPIBLO_codec);
		if (cMHBDMOJJEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CMHBDMOJJEN);
		}
		if (eCCGJDMOGAN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECCGJDMOGAN);
		}
		num += gridFightPortalBuffList_.CalculateSize(_repeated_gridFightPortalBuffList_codec);
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		num += iAKFPMOEJLF_.CalculateSize(_repeated_iAKFPMOEJLF_codec);
		if (gridFightLayerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightLayerInfo);
		}
		if (NDOCIKPLKIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDOCIKPLKIF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightLevelInfo other)
	{
		if (other == null)
		{
			return;
		}
		gridFightAffixList_.Add(other.gridFightAffixList_);
		if (other.bossInfo_ != null)
		{
			if (bossInfo_ == null)
			{
				BossInfo = new GridFightBossInfo();
			}
			BossInfo.MergeFrom(other.BossInfo);
		}
		if (other.DCPKPNLKGMM != 0)
		{
			DCPKPNLKGMM = other.DCPKPNLKGMM;
		}
		hGAHMIPIBLO_.Add(other.hGAHMIPIBLO_);
		if (other.cMHBDMOJJEN_ != null)
		{
			if (cMHBDMOJJEN_ == null)
			{
				CMHBDMOJJEN = new IKFEDFBLOOG();
			}
			CMHBDMOJJEN.MergeFrom(other.CMHBDMOJJEN);
		}
		if (other.eCCGJDMOGAN_ != null)
		{
			if (eCCGJDMOGAN_ == null)
			{
				ECCGJDMOGAN = new DDJIOFONKME();
			}
			ECCGJDMOGAN.MergeFrom(other.ECCGJDMOGAN);
		}
		gridFightPortalBuffList_.Add(other.gridFightPortalBuffList_);
		if (other.SectionId != 0)
		{
			SectionId = other.SectionId;
		}
		iAKFPMOEJLF_.Add(other.iAKFPMOEJLF_);
		if (other.gridFightLayerInfo_ != null)
		{
			if (gridFightLayerInfo_ == null)
			{
				GridFightLayerInfo = new GridFightLayerInfo();
			}
			GridFightLayerInfo.MergeFrom(other.GridFightLayerInfo);
		}
		if (other.NDOCIKPLKIF != 0)
		{
			NDOCIKPLKIF = other.NDOCIKPLKIF;
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
			case 10u:
				gridFightAffixList_.AddEntriesFrom(ref input, _repeated_gridFightAffixList_codec);
				break;
			case 18u:
				if (bossInfo_ == null)
				{
					BossInfo = new GridFightBossInfo();
				}
				input.ReadMessage(BossInfo);
				break;
			case 24u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 34u:
				hGAHMIPIBLO_.AddEntriesFrom(ref input, _repeated_hGAHMIPIBLO_codec);
				break;
			case 42u:
				if (cMHBDMOJJEN_ == null)
				{
					CMHBDMOJJEN = new IKFEDFBLOOG();
				}
				input.ReadMessage(CMHBDMOJJEN);
				break;
			case 50u:
				if (eCCGJDMOGAN_ == null)
				{
					ECCGJDMOGAN = new DDJIOFONKME();
				}
				input.ReadMessage(ECCGJDMOGAN);
				break;
			case 58u:
				gridFightPortalBuffList_.AddEntriesFrom(ref input, _repeated_gridFightPortalBuffList_codec);
				break;
			case 72u:
				SectionId = input.ReadUInt32();
				break;
			case 90u:
				iAKFPMOEJLF_.AddEntriesFrom(ref input, _repeated_iAKFPMOEJLF_codec);
				break;
			case 98u:
				if (gridFightLayerInfo_ == null)
				{
					GridFightLayerInfo = new GridFightLayerInfo();
				}
				input.ReadMessage(GridFightLayerInfo);
				break;
			case 104u:
				NDOCIKPLKIF = input.ReadUInt32();
				break;
			}
		}
	}
}
