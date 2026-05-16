using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGEOMDJIAGI : IMessage<OGEOMDJIAGI>, IMessage, IEquatable<OGEOMDJIAGI>, IDeepCloneable<OGEOMDJIAGI>, IBufferMessage
{
	private static readonly MessageParser<OGEOMDJIAGI> _parser = new MessageParser<OGEOMDJIAGI>(() => new OGEOMDJIAGI());

	private UnknownFieldSet _unknownFields;

	public const int PIDIGFGKAMKFieldNumber = 1;

	private static readonly FieldCodec<BattleAvatar> _repeated_pIDIGFGKAMK_codec = FieldCodec.ForMessage(10u, BattleAvatar.Parser);

	private readonly RepeatedField<BattleAvatar> pIDIGFGKAMK_ = new RepeatedField<BattleAvatar>();

	public const int BattleWaveIdFieldNumber = 2;

	private uint battleWaveId_;

	public const int GridFightLineupHpFieldNumber = 3;

	private uint gridFightLineupHp_;

	public const int ANBBPPHBCJHFieldNumber = 4;

	private uint aNBBPPHBCJH_;

	public const int GridFightTraitInfoFieldNumber = 7;

	private static readonly FieldCodec<IENNMHMOONM> _repeated_gridFightTraitInfo_codec = FieldCodec.ForMessage(58u, IENNMHMOONM.Parser);

	private readonly RepeatedField<IENNMHMOONM> gridFightTraitInfo_ = new RepeatedField<IENNMHMOONM>();

	public const int GridGameRoleListFieldNumber = 8;

	private static readonly FieldCodec<JAJOBJJPINN> _repeated_gridGameRoleList_codec = FieldCodec.ForMessage(66u, JAJOBJJPINN.Parser);

	private readonly RepeatedField<JAJOBJJPINN> gridGameRoleList_ = new RepeatedField<JAJOBJJPINN>();

	public const int LFKBMDHKPFIFieldNumber = 9;

	private uint lFKBMDHKPFI_;

	public const int SyncAugmentInfoFieldNumber = 10;

	private static readonly FieldCodec<HLPCOGPKBFJ> _repeated_syncAugmentInfo_codec = FieldCodec.ForMessage(82u, HLPCOGPKBFJ.Parser);

	private readonly RepeatedField<HLPCOGPKBFJ> syncAugmentInfo_ = new RepeatedField<HLPCOGPKBFJ>();

	public const int OIHHKOJFHFGFieldNumber = 11;

	private OMBNHGAJANJ oIHHKOJFHFG_;

	public const int OOPPKDAFFDGFieldNumber = 12;

	private uint oOPPKDAFFDG_;

	public const int SeasonFieldNumber = 13;

	private uint season_;

	public const int GridFightPortalBuffListFieldNumber = 14;

	private static readonly FieldCodec<MMDJJDEJMMN> _repeated_gridFightPortalBuffList_codec = FieldCodec.ForMessage(114u, MMDJJDEJMMN.Parser);

	private readonly RepeatedField<MMDJJDEJMMN> gridFightPortalBuffList_ = new RepeatedField<MMDJJDEJMMN>();

	public const int IsOverlockFieldNumber = 15;

	private bool isOverlock_;

	public const int BBDOCJGAEEJFieldNumber = 16;

	private uint bBDOCJGAEEJ_;

	public const int GridGameNpcListFieldNumber = 17;

	private static readonly FieldCodec<LMMBMIKBKMB> _repeated_gridGameNpcList_codec = FieldCodec.ForMessage(138u, LMMBMIKBKMB.Parser);

	private readonly RepeatedField<LMMBMIKBKMB> gridGameNpcList_ = new RepeatedField<LMMBMIKBKMB>();

	public const int MMAJCLACOBNFieldNumber = 18;

	private static readonly FieldCodec<CCGEOHGFAFD> _repeated_mMAJCLACOBN_codec = FieldCodec.ForMessage(146u, CCGEOHGFAFD.Parser);

	private readonly RepeatedField<CCGEOHGFAFD> mMAJCLACOBN_ = new RepeatedField<CCGEOHGFAFD>();

	public const int HDCAEIKAPNDFieldNumber = 19;

	private uint hDCAEIKAPND_;

	public const int OGHGLMGJGEMFieldNumber = 20;

	private static readonly MapField<string, uint>.Codec _map_oGHGLMGJGEM_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 162u);

	private readonly MapField<string, uint> oGHGLMGJGEM_ = new MapField<string, uint>();

	public const int KACDGAJHNBIFieldNumber = 21;

	private uint kACDGAJHNBI_;

	public const int FMOJNJIFKENFieldNumber = 22;

	private bool fMOJNJIFKEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGEOMDJIAGI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGEOMDJIAGIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleAvatar> PIDIGFGKAMK => pIDIGFGKAMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleWaveId
	{
		get
		{
			return battleWaveId_;
		}
		set
		{
			battleWaveId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightLineupHp
	{
		get
		{
			return gridFightLineupHp_;
		}
		set
		{
			gridFightLineupHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANBBPPHBCJH
	{
		get
		{
			return aNBBPPHBCJH_;
		}
		set
		{
			aNBBPPHBCJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IENNMHMOONM> GridFightTraitInfo => gridFightTraitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JAJOBJJPINN> GridGameRoleList => gridGameRoleList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFKBMDHKPFI
	{
		get
		{
			return lFKBMDHKPFI_;
		}
		set
		{
			lFKBMDHKPFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HLPCOGPKBFJ> SyncAugmentInfo => syncAugmentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMBNHGAJANJ OIHHKOJFHFG
	{
		get
		{
			return oIHHKOJFHFG_;
		}
		set
		{
			oIHHKOJFHFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OOPPKDAFFDG
	{
		get
		{
			return oOPPKDAFFDG_;
		}
		set
		{
			oOPPKDAFFDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MMDJJDEJMMN> GridFightPortalBuffList => gridFightPortalBuffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOverlock
	{
		get
		{
			return isOverlock_;
		}
		set
		{
			isOverlock_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BBDOCJGAEEJ
	{
		get
		{
			return bBDOCJGAEEJ_;
		}
		set
		{
			bBDOCJGAEEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LMMBMIKBKMB> GridGameNpcList => gridGameNpcList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCGEOHGFAFD> MMAJCLACOBN => mMAJCLACOBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HDCAEIKAPND
	{
		get
		{
			return hDCAEIKAPND_;
		}
		set
		{
			hDCAEIKAPND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> OGHGLMGJGEM => oGHGLMGJGEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KACDGAJHNBI
	{
		get
		{
			return kACDGAJHNBI_;
		}
		set
		{
			kACDGAJHNBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FMOJNJIFKEN
	{
		get
		{
			return fMOJNJIFKEN_;
		}
		set
		{
			fMOJNJIFKEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGEOMDJIAGI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGEOMDJIAGI(OGEOMDJIAGI other)
		: this()
	{
		pIDIGFGKAMK_ = other.pIDIGFGKAMK_.Clone();
		battleWaveId_ = other.battleWaveId_;
		gridFightLineupHp_ = other.gridFightLineupHp_;
		aNBBPPHBCJH_ = other.aNBBPPHBCJH_;
		gridFightTraitInfo_ = other.gridFightTraitInfo_.Clone();
		gridGameRoleList_ = other.gridGameRoleList_.Clone();
		lFKBMDHKPFI_ = other.lFKBMDHKPFI_;
		syncAugmentInfo_ = other.syncAugmentInfo_.Clone();
		oIHHKOJFHFG_ = ((other.oIHHKOJFHFG_ != null) ? other.oIHHKOJFHFG_.Clone() : null);
		oOPPKDAFFDG_ = other.oOPPKDAFFDG_;
		season_ = other.season_;
		gridFightPortalBuffList_ = other.gridFightPortalBuffList_.Clone();
		isOverlock_ = other.isOverlock_;
		bBDOCJGAEEJ_ = other.bBDOCJGAEEJ_;
		gridGameNpcList_ = other.gridGameNpcList_.Clone();
		mMAJCLACOBN_ = other.mMAJCLACOBN_.Clone();
		hDCAEIKAPND_ = other.hDCAEIKAPND_;
		oGHGLMGJGEM_ = other.oGHGLMGJGEM_.Clone();
		kACDGAJHNBI_ = other.kACDGAJHNBI_;
		fMOJNJIFKEN_ = other.fMOJNJIFKEN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGEOMDJIAGI Clone()
	{
		return new OGEOMDJIAGI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGEOMDJIAGI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGEOMDJIAGI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pIDIGFGKAMK_.Equals(other.pIDIGFGKAMK_))
		{
			return false;
		}
		if (BattleWaveId != other.BattleWaveId)
		{
			return false;
		}
		if (GridFightLineupHp != other.GridFightLineupHp)
		{
			return false;
		}
		if (ANBBPPHBCJH != other.ANBBPPHBCJH)
		{
			return false;
		}
		if (!gridFightTraitInfo_.Equals(other.gridFightTraitInfo_))
		{
			return false;
		}
		if (!gridGameRoleList_.Equals(other.gridGameRoleList_))
		{
			return false;
		}
		if (LFKBMDHKPFI != other.LFKBMDHKPFI)
		{
			return false;
		}
		if (!syncAugmentInfo_.Equals(other.syncAugmentInfo_))
		{
			return false;
		}
		if (!object.Equals(OIHHKOJFHFG, other.OIHHKOJFHFG))
		{
			return false;
		}
		if (OOPPKDAFFDG != other.OOPPKDAFFDG)
		{
			return false;
		}
		if (Season != other.Season)
		{
			return false;
		}
		if (!gridFightPortalBuffList_.Equals(other.gridFightPortalBuffList_))
		{
			return false;
		}
		if (IsOverlock != other.IsOverlock)
		{
			return false;
		}
		if (BBDOCJGAEEJ != other.BBDOCJGAEEJ)
		{
			return false;
		}
		if (!gridGameNpcList_.Equals(other.gridGameNpcList_))
		{
			return false;
		}
		if (!mMAJCLACOBN_.Equals(other.mMAJCLACOBN_))
		{
			return false;
		}
		if (HDCAEIKAPND != other.HDCAEIKAPND)
		{
			return false;
		}
		if (!OGHGLMGJGEM.Equals(other.OGHGLMGJGEM))
		{
			return false;
		}
		if (KACDGAJHNBI != other.KACDGAJHNBI)
		{
			return false;
		}
		if (FMOJNJIFKEN != other.FMOJNJIFKEN)
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
		num ^= pIDIGFGKAMK_.GetHashCode();
		if (BattleWaveId != 0)
		{
			num ^= BattleWaveId.GetHashCode();
		}
		if (GridFightLineupHp != 0)
		{
			num ^= GridFightLineupHp.GetHashCode();
		}
		if (ANBBPPHBCJH != 0)
		{
			num ^= ANBBPPHBCJH.GetHashCode();
		}
		num ^= gridFightTraitInfo_.GetHashCode();
		num ^= gridGameRoleList_.GetHashCode();
		if (LFKBMDHKPFI != 0)
		{
			num ^= LFKBMDHKPFI.GetHashCode();
		}
		num ^= syncAugmentInfo_.GetHashCode();
		if (oIHHKOJFHFG_ != null)
		{
			num ^= OIHHKOJFHFG.GetHashCode();
		}
		if (OOPPKDAFFDG != 0)
		{
			num ^= OOPPKDAFFDG.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		num ^= gridFightPortalBuffList_.GetHashCode();
		if (IsOverlock)
		{
			num ^= IsOverlock.GetHashCode();
		}
		if (BBDOCJGAEEJ != 0)
		{
			num ^= BBDOCJGAEEJ.GetHashCode();
		}
		num ^= gridGameNpcList_.GetHashCode();
		num ^= mMAJCLACOBN_.GetHashCode();
		if (HDCAEIKAPND != 0)
		{
			num ^= HDCAEIKAPND.GetHashCode();
		}
		num ^= OGHGLMGJGEM.GetHashCode();
		if (KACDGAJHNBI != 0)
		{
			num ^= KACDGAJHNBI.GetHashCode();
		}
		if (FMOJNJIFKEN)
		{
			num ^= FMOJNJIFKEN.GetHashCode();
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
		pIDIGFGKAMK_.WriteTo(ref output, _repeated_pIDIGFGKAMK_codec);
		if (BattleWaveId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BattleWaveId);
		}
		if (GridFightLineupHp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GridFightLineupHp);
		}
		if (ANBBPPHBCJH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ANBBPPHBCJH);
		}
		gridFightTraitInfo_.WriteTo(ref output, _repeated_gridFightTraitInfo_codec);
		gridGameRoleList_.WriteTo(ref output, _repeated_gridGameRoleList_codec);
		if (LFKBMDHKPFI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LFKBMDHKPFI);
		}
		syncAugmentInfo_.WriteTo(ref output, _repeated_syncAugmentInfo_codec);
		if (oIHHKOJFHFG_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(OIHHKOJFHFG);
		}
		if (OOPPKDAFFDG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OOPPKDAFFDG);
		}
		if (Season != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Season);
		}
		gridFightPortalBuffList_.WriteTo(ref output, _repeated_gridFightPortalBuffList_codec);
		if (IsOverlock)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsOverlock);
		}
		if (BBDOCJGAEEJ != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(BBDOCJGAEEJ);
		}
		gridGameNpcList_.WriteTo(ref output, _repeated_gridGameNpcList_codec);
		mMAJCLACOBN_.WriteTo(ref output, _repeated_mMAJCLACOBN_codec);
		if (HDCAEIKAPND != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteUInt32(HDCAEIKAPND);
		}
		oGHGLMGJGEM_.WriteTo(ref output, _map_oGHGLMGJGEM_codec);
		if (KACDGAJHNBI != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteUInt32(KACDGAJHNBI);
		}
		if (FMOJNJIFKEN)
		{
			output.WriteRawTag(176, 1);
			output.WriteBool(FMOJNJIFKEN);
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
		num += pIDIGFGKAMK_.CalculateSize(_repeated_pIDIGFGKAMK_codec);
		if (BattleWaveId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleWaveId);
		}
		if (GridFightLineupHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightLineupHp);
		}
		if (ANBBPPHBCJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANBBPPHBCJH);
		}
		num += gridFightTraitInfo_.CalculateSize(_repeated_gridFightTraitInfo_codec);
		num += gridGameRoleList_.CalculateSize(_repeated_gridGameRoleList_codec);
		if (LFKBMDHKPFI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFKBMDHKPFI);
		}
		num += syncAugmentInfo_.CalculateSize(_repeated_syncAugmentInfo_codec);
		if (oIHHKOJFHFG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OIHHKOJFHFG);
		}
		if (OOPPKDAFFDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OOPPKDAFFDG);
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Season);
		}
		num += gridFightPortalBuffList_.CalculateSize(_repeated_gridFightPortalBuffList_codec);
		if (IsOverlock)
		{
			num += 2;
		}
		if (BBDOCJGAEEJ != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BBDOCJGAEEJ);
		}
		num += gridGameNpcList_.CalculateSize(_repeated_gridGameNpcList_codec);
		num += mMAJCLACOBN_.CalculateSize(_repeated_mMAJCLACOBN_codec);
		if (HDCAEIKAPND != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HDCAEIKAPND);
		}
		num += oGHGLMGJGEM_.CalculateSize(_map_oGHGLMGJGEM_codec);
		if (KACDGAJHNBI != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(KACDGAJHNBI);
		}
		if (FMOJNJIFKEN)
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
	public void MergeFrom(OGEOMDJIAGI other)
	{
		if (other == null)
		{
			return;
		}
		pIDIGFGKAMK_.Add(other.pIDIGFGKAMK_);
		if (other.BattleWaveId != 0)
		{
			BattleWaveId = other.BattleWaveId;
		}
		if (other.GridFightLineupHp != 0)
		{
			GridFightLineupHp = other.GridFightLineupHp;
		}
		if (other.ANBBPPHBCJH != 0)
		{
			ANBBPPHBCJH = other.ANBBPPHBCJH;
		}
		gridFightTraitInfo_.Add(other.gridFightTraitInfo_);
		gridGameRoleList_.Add(other.gridGameRoleList_);
		if (other.LFKBMDHKPFI != 0)
		{
			LFKBMDHKPFI = other.LFKBMDHKPFI;
		}
		syncAugmentInfo_.Add(other.syncAugmentInfo_);
		if (other.oIHHKOJFHFG_ != null)
		{
			if (oIHHKOJFHFG_ == null)
			{
				OIHHKOJFHFG = new OMBNHGAJANJ();
			}
			OIHHKOJFHFG.MergeFrom(other.OIHHKOJFHFG);
		}
		if (other.OOPPKDAFFDG != 0)
		{
			OOPPKDAFFDG = other.OOPPKDAFFDG;
		}
		if (other.Season != 0)
		{
			Season = other.Season;
		}
		gridFightPortalBuffList_.Add(other.gridFightPortalBuffList_);
		if (other.IsOverlock)
		{
			IsOverlock = other.IsOverlock;
		}
		if (other.BBDOCJGAEEJ != 0)
		{
			BBDOCJGAEEJ = other.BBDOCJGAEEJ;
		}
		gridGameNpcList_.Add(other.gridGameNpcList_);
		mMAJCLACOBN_.Add(other.mMAJCLACOBN_);
		if (other.HDCAEIKAPND != 0)
		{
			HDCAEIKAPND = other.HDCAEIKAPND;
		}
		oGHGLMGJGEM_.MergeFrom(other.oGHGLMGJGEM_);
		if (other.KACDGAJHNBI != 0)
		{
			KACDGAJHNBI = other.KACDGAJHNBI;
		}
		if (other.FMOJNJIFKEN)
		{
			FMOJNJIFKEN = other.FMOJNJIFKEN;
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
				pIDIGFGKAMK_.AddEntriesFrom(ref input, _repeated_pIDIGFGKAMK_codec);
				break;
			case 16u:
				BattleWaveId = input.ReadUInt32();
				break;
			case 24u:
				GridFightLineupHp = input.ReadUInt32();
				break;
			case 32u:
				ANBBPPHBCJH = input.ReadUInt32();
				break;
			case 58u:
				gridFightTraitInfo_.AddEntriesFrom(ref input, _repeated_gridFightTraitInfo_codec);
				break;
			case 66u:
				gridGameRoleList_.AddEntriesFrom(ref input, _repeated_gridGameRoleList_codec);
				break;
			case 72u:
				LFKBMDHKPFI = input.ReadUInt32();
				break;
			case 82u:
				syncAugmentInfo_.AddEntriesFrom(ref input, _repeated_syncAugmentInfo_codec);
				break;
			case 90u:
				if (oIHHKOJFHFG_ == null)
				{
					OIHHKOJFHFG = new OMBNHGAJANJ();
				}
				input.ReadMessage(OIHHKOJFHFG);
				break;
			case 96u:
				OOPPKDAFFDG = input.ReadUInt32();
				break;
			case 104u:
				Season = input.ReadUInt32();
				break;
			case 114u:
				gridFightPortalBuffList_.AddEntriesFrom(ref input, _repeated_gridFightPortalBuffList_codec);
				break;
			case 120u:
				IsOverlock = input.ReadBool();
				break;
			case 128u:
				BBDOCJGAEEJ = input.ReadUInt32();
				break;
			case 138u:
				gridGameNpcList_.AddEntriesFrom(ref input, _repeated_gridGameNpcList_codec);
				break;
			case 146u:
				mMAJCLACOBN_.AddEntriesFrom(ref input, _repeated_mMAJCLACOBN_codec);
				break;
			case 152u:
				HDCAEIKAPND = input.ReadUInt32();
				break;
			case 162u:
				oGHGLMGJGEM_.AddEntriesFrom(ref input, _map_oGHGLMGJGEM_codec);
				break;
			case 168u:
				KACDGAJHNBI = input.ReadUInt32();
				break;
			case 176u:
				FMOJNJIFKEN = input.ReadBool();
				break;
			}
		}
	}
}
