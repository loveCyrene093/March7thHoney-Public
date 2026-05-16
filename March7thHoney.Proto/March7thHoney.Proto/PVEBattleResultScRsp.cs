using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PVEBattleResultScRsp : IMessage<PVEBattleResultScRsp>, IMessage, IEquatable<PVEBattleResultScRsp>, IDeepCloneable<PVEBattleResultScRsp>, IBufferMessage
{
	private static readonly MessageParser<PVEBattleResultScRsp> _parser = new MessageParser<PVEBattleResultScRsp>(() => new PVEBattleResultScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GGDBPDDAPDGFieldNumber = 1;

	private uint gGDBPDDAPDG_;

	public const int ResVersionFieldNumber = 2;

	private string resVersion_ = "";

	public const int StageIdFieldNumber = 3;

	private uint stageId_;

	public const int EndStatusFieldNumber = 4;

	private BattleEndStatus endStatus_;

	public const int MultipleDropDataFieldNumber = 5;

	private ItemList multipleDropData_;

	public const int DropDataFieldNumber = 6;

	private ItemList dropData_;

	public const int ItemListUnk1FieldNumber = 7;

	private ItemList itemListUnk1_;

	public const int CheckIdenticalFieldNumber = 8;

	private bool checkIdentical_;

	public const int BattleAvatarListFieldNumber = 9;

	private static readonly FieldCodec<BattleAvatar> _repeated_battleAvatarList_codec = FieldCodec.ForMessage(74u, BattleAvatar.Parser);

	private readonly RepeatedField<BattleAvatar> battleAvatarList_ = new RepeatedField<BattleAvatar>();

	public const int CJAJBMAJNJPFieldNumber = 10;

	private uint cJAJBMAJNJP_;

	public const int NDEJJDHJBIMFieldNumber = 11;

	private uint nDEJJDHJBIM_;

	public const int EventIdFieldNumber = 12;

	private uint eventId_;

	public const int BattleIdFieldNumber = 13;

	private uint battleId_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int BinVersionFieldNumber = 15;

	private string binVersion_ = "";

	public const int ItemListUnk2FieldNumber = 460;

	private ItemList itemListUnk2_;

	public const int HICNFJDGGGLFieldNumber = 1582;

	private NNOIJJNCHJB hICNFJDGGGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PVEBattleResultScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PVEBattleResultScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGDBPDDAPDG
	{
		get
		{
			return gGDBPDDAPDG_;
		}
		set
		{
			gGDBPDDAPDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ResVersion
	{
		get
		{
			return resVersion_;
		}
		set
		{
			resVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndStatus EndStatus
	{
		get
		{
			return endStatus_;
		}
		set
		{
			endStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList MultipleDropData
	{
		get
		{
			return multipleDropData_;
		}
		set
		{
			multipleDropData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList DropData
	{
		get
		{
			return dropData_;
		}
		set
		{
			dropData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList ItemListUnk1
	{
		get
		{
			return itemListUnk1_;
		}
		set
		{
			itemListUnk1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CheckIdentical
	{
		get
		{
			return checkIdentical_;
		}
		set
		{
			checkIdentical_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleAvatar> BattleAvatarList => battleAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJAJBMAJNJP
	{
		get
		{
			return cJAJBMAJNJP_;
		}
		set
		{
			cJAJBMAJNJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDEJJDHJBIM
	{
		get
		{
			return nDEJJDHJBIM_;
		}
		set
		{
			nDEJJDHJBIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
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
	public string BinVersion
	{
		get
		{
			return binVersion_;
		}
		set
		{
			binVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList ItemListUnk2
	{
		get
		{
			return itemListUnk2_;
		}
		set
		{
			itemListUnk2_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNOIJJNCHJB HICNFJDGGGL
	{
		get
		{
			return hICNFJDGGGL_;
		}
		set
		{
			hICNFJDGGGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PVEBattleResultScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PVEBattleResultScRsp(PVEBattleResultScRsp other)
		: this()
	{
		gGDBPDDAPDG_ = other.gGDBPDDAPDG_;
		resVersion_ = other.resVersion_;
		stageId_ = other.stageId_;
		endStatus_ = other.endStatus_;
		multipleDropData_ = ((other.multipleDropData_ != null) ? other.multipleDropData_.Clone() : null);
		dropData_ = ((other.dropData_ != null) ? other.dropData_.Clone() : null);
		itemListUnk1_ = ((other.itemListUnk1_ != null) ? other.itemListUnk1_.Clone() : null);
		checkIdentical_ = other.checkIdentical_;
		battleAvatarList_ = other.battleAvatarList_.Clone();
		cJAJBMAJNJP_ = other.cJAJBMAJNJP_;
		nDEJJDHJBIM_ = other.nDEJJDHJBIM_;
		eventId_ = other.eventId_;
		battleId_ = other.battleId_;
		retcode_ = other.retcode_;
		binVersion_ = other.binVersion_;
		itemListUnk2_ = ((other.itemListUnk2_ != null) ? other.itemListUnk2_.Clone() : null);
		hICNFJDGGGL_ = ((other.hICNFJDGGGL_ != null) ? other.hICNFJDGGGL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PVEBattleResultScRsp Clone()
	{
		return new PVEBattleResultScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PVEBattleResultScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PVEBattleResultScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GGDBPDDAPDG != other.GGDBPDDAPDG)
		{
			return false;
		}
		if (ResVersion != other.ResVersion)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (EndStatus != other.EndStatus)
		{
			return false;
		}
		if (!object.Equals(MultipleDropData, other.MultipleDropData))
		{
			return false;
		}
		if (!object.Equals(DropData, other.DropData))
		{
			return false;
		}
		if (!object.Equals(ItemListUnk1, other.ItemListUnk1))
		{
			return false;
		}
		if (CheckIdentical != other.CheckIdentical)
		{
			return false;
		}
		if (!battleAvatarList_.Equals(other.battleAvatarList_))
		{
			return false;
		}
		if (CJAJBMAJNJP != other.CJAJBMAJNJP)
		{
			return false;
		}
		if (NDEJJDHJBIM != other.NDEJJDHJBIM)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (BattleId != other.BattleId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (BinVersion != other.BinVersion)
		{
			return false;
		}
		if (!object.Equals(ItemListUnk2, other.ItemListUnk2))
		{
			return false;
		}
		if (!object.Equals(HICNFJDGGGL, other.HICNFJDGGGL))
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
		if (GGDBPDDAPDG != 0)
		{
			num ^= GGDBPDDAPDG.GetHashCode();
		}
		if (ResVersion.Length != 0)
		{
			num ^= ResVersion.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num ^= EndStatus.GetHashCode();
		}
		if (multipleDropData_ != null)
		{
			num ^= MultipleDropData.GetHashCode();
		}
		if (dropData_ != null)
		{
			num ^= DropData.GetHashCode();
		}
		if (itemListUnk1_ != null)
		{
			num ^= ItemListUnk1.GetHashCode();
		}
		if (CheckIdentical)
		{
			num ^= CheckIdentical.GetHashCode();
		}
		num ^= battleAvatarList_.GetHashCode();
		if (CJAJBMAJNJP != 0)
		{
			num ^= CJAJBMAJNJP.GetHashCode();
		}
		if (NDEJJDHJBIM != 0)
		{
			num ^= NDEJJDHJBIM.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (BinVersion.Length != 0)
		{
			num ^= BinVersion.GetHashCode();
		}
		if (itemListUnk2_ != null)
		{
			num ^= ItemListUnk2.GetHashCode();
		}
		if (hICNFJDGGGL_ != null)
		{
			num ^= HICNFJDGGGL.GetHashCode();
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
		if (GGDBPDDAPDG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GGDBPDDAPDG);
		}
		if (ResVersion.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ResVersion);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(StageId);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)EndStatus);
		}
		if (multipleDropData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MultipleDropData);
		}
		if (dropData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(DropData);
		}
		if (itemListUnk1_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ItemListUnk1);
		}
		if (CheckIdentical)
		{
			output.WriteRawTag(64);
			output.WriteBool(CheckIdentical);
		}
		battleAvatarList_.WriteTo(ref output, _repeated_battleAvatarList_codec);
		if (CJAJBMAJNJP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CJAJBMAJNJP);
		}
		if (NDEJJDHJBIM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NDEJJDHJBIM);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EventId);
		}
		if (BattleId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BattleId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (BinVersion.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(BinVersion);
		}
		if (itemListUnk2_ != null)
		{
			output.WriteRawTag(226, 28);
			output.WriteMessage(ItemListUnk2);
		}
		if (hICNFJDGGGL_ != null)
		{
			output.WriteRawTag(242, 98);
			output.WriteMessage(HICNFJDGGGL);
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
		if (GGDBPDDAPDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGDBPDDAPDG);
		}
		if (ResVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResVersion);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndStatus);
		}
		if (multipleDropData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MultipleDropData);
		}
		if (dropData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DropData);
		}
		if (itemListUnk1_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemListUnk1);
		}
		if (CheckIdentical)
		{
			num += 2;
		}
		num += battleAvatarList_.CalculateSize(_repeated_battleAvatarList_codec);
		if (CJAJBMAJNJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJAJBMAJNJP);
		}
		if (NDEJJDHJBIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDEJJDHJBIM);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (BinVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BinVersion);
		}
		if (itemListUnk2_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ItemListUnk2);
		}
		if (hICNFJDGGGL_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HICNFJDGGGL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PVEBattleResultScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GGDBPDDAPDG != 0)
		{
			GGDBPDDAPDG = other.GGDBPDDAPDG;
		}
		if (other.ResVersion.Length != 0)
		{
			ResVersion = other.ResVersion;
		}
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.EndStatus != BattleEndStatus.BattleEndNone)
		{
			EndStatus = other.EndStatus;
		}
		if (other.multipleDropData_ != null)
		{
			if (multipleDropData_ == null)
			{
				MultipleDropData = new ItemList();
			}
			MultipleDropData.MergeFrom(other.MultipleDropData);
		}
		if (other.dropData_ != null)
		{
			if (dropData_ == null)
			{
				DropData = new ItemList();
			}
			DropData.MergeFrom(other.DropData);
		}
		if (other.itemListUnk1_ != null)
		{
			if (itemListUnk1_ == null)
			{
				ItemListUnk1 = new ItemList();
			}
			ItemListUnk1.MergeFrom(other.ItemListUnk1);
		}
		if (other.CheckIdentical)
		{
			CheckIdentical = other.CheckIdentical;
		}
		battleAvatarList_.Add(other.battleAvatarList_);
		if (other.CJAJBMAJNJP != 0)
		{
			CJAJBMAJNJP = other.CJAJBMAJNJP;
		}
		if (other.NDEJJDHJBIM != 0)
		{
			NDEJJDHJBIM = other.NDEJJDHJBIM;
		}
		if (other.EventId != 0)
		{
			EventId = other.EventId;
		}
		if (other.BattleId != 0)
		{
			BattleId = other.BattleId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.BinVersion.Length != 0)
		{
			BinVersion = other.BinVersion;
		}
		if (other.itemListUnk2_ != null)
		{
			if (itemListUnk2_ == null)
			{
				ItemListUnk2 = new ItemList();
			}
			ItemListUnk2.MergeFrom(other.ItemListUnk2);
		}
		if (other.hICNFJDGGGL_ != null)
		{
			if (hICNFJDGGGL_ == null)
			{
				HICNFJDGGGL = new NNOIJJNCHJB();
			}
			HICNFJDGGGL.MergeFrom(other.HICNFJDGGGL);
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
				GGDBPDDAPDG = input.ReadUInt32();
				break;
			case 18u:
				ResVersion = input.ReadString();
				break;
			case 24u:
				StageId = input.ReadUInt32();
				break;
			case 32u:
				EndStatus = (BattleEndStatus)input.ReadEnum();
				break;
			case 42u:
				if (multipleDropData_ == null)
				{
					MultipleDropData = new ItemList();
				}
				input.ReadMessage(MultipleDropData);
				break;
			case 50u:
				if (dropData_ == null)
				{
					DropData = new ItemList();
				}
				input.ReadMessage(DropData);
				break;
			case 58u:
				if (itemListUnk1_ == null)
				{
					ItemListUnk1 = new ItemList();
				}
				input.ReadMessage(ItemListUnk1);
				break;
			case 64u:
				CheckIdentical = input.ReadBool();
				break;
			case 74u:
				battleAvatarList_.AddEntriesFrom(ref input, _repeated_battleAvatarList_codec);
				break;
			case 80u:
				CJAJBMAJNJP = input.ReadUInt32();
				break;
			case 88u:
				NDEJJDHJBIM = input.ReadUInt32();
				break;
			case 96u:
				EventId = input.ReadUInt32();
				break;
			case 104u:
				BattleId = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				BinVersion = input.ReadString();
				break;
			case 3682u:
				if (itemListUnk2_ == null)
				{
					ItemListUnk2 = new ItemList();
				}
				input.ReadMessage(ItemListUnk2);
				break;
			case 12658u:
				if (hICNFJDGGGL_ == null)
				{
					HICNFJDGGGL = new NNOIJJNCHJB();
				}
				input.ReadMessage(HICNFJDGGGL);
				break;
			}
		}
	}
}
