using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameInfo : IMessage<GridFightGameInfo>, IMessage, IEquatable<GridFightGameInfo>, IDeepCloneable<GridFightGameInfo>, IBufferMessage
{
	public enum FHPJJJDNKIOOneofCase
	{
		None = 0,
		GridDraftInfo = 1,
		GridItemsInfo = 2,
		GridTraitGameInfo = 3,
		GridOrbInfo = 7,
		GridTeamGameInfo = 8,
		GridShopInfo = 10,
		GridAugmentInfo = 12,
		GridLevelInfo = 13,
		GridBasicInfo = 15
	}

	private static readonly MessageParser<GridFightGameInfo> _parser = new MessageParser<GridFightGameInfo>(() => new GridFightGameInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridDraftInfoFieldNumber = 1;

	public const int GridItemsInfoFieldNumber = 2;

	public const int GridTraitGameInfoFieldNumber = 3;

	public const int GridOrbInfoFieldNumber = 7;

	public const int GridTeamGameInfoFieldNumber = 8;

	public const int GridShopInfoFieldNumber = 10;

	public const int GridAugmentInfoFieldNumber = 12;

	public const int GridLevelInfoFieldNumber = 13;

	public const int GridBasicInfoFieldNumber = 15;

	private object fHPJJJDNKIO_;

	private FHPJJJDNKIOOneofCase fHPJJJDNKIOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemsInfo GridDraftInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridDraftInfo)
			{
				return null;
			}
			return (GridFightGameItemsInfo)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridDraftInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameShopInfo GridItemsInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridItemsInfo)
			{
				return null;
			}
			return (GridFightGameShopInfo)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridItemsInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTeamInfo GridTraitGameInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridTraitGameInfo)
			{
				return null;
			}
			return (GridFightGameTeamInfo)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridTraitGameInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentSync GridOrbInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridOrbInfo)
			{
				return null;
			}
			return (GridFightGameAugmentSync)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridOrbInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHFDOPGEOML GridTeamGameInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridTeamGameInfo)
			{
				return null;
			}
			return (LHFDOPGEOML)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridTeamGameInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelInfo GridShopInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridShopInfo)
			{
				return null;
			}
			return (GridFightLevelInfo)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridShopInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitInfo GridAugmentInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridAugmentInfo)
			{
				return null;
			}
			return (GridFightGameTraitInfo)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridAugmentInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameOrbInfo GridLevelInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridLevelInfo)
			{
				return null;
			}
			return (GridFightGameOrbInfo)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridLevelInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameBasicInfo GridBasicInfo
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.GridBasicInfo)
			{
				return null;
			}
			return (GridFightGameBasicInfo)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.GridBasicInfo : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHPJJJDNKIOOneofCase FHPJJJDNKIOCase => fHPJJJDNKIOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameInfo(GridFightGameInfo other)
		: this()
	{
		switch (other.FHPJJJDNKIOCase)
		{
		case FHPJJJDNKIOOneofCase.GridDraftInfo:
			GridDraftInfo = other.GridDraftInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridItemsInfo:
			GridItemsInfo = other.GridItemsInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridTraitGameInfo:
			GridTraitGameInfo = other.GridTraitGameInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridOrbInfo:
			GridOrbInfo = other.GridOrbInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridTeamGameInfo:
			GridTeamGameInfo = other.GridTeamGameInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridShopInfo:
			GridShopInfo = other.GridShopInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridAugmentInfo:
			GridAugmentInfo = other.GridAugmentInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridLevelInfo:
			GridLevelInfo = other.GridLevelInfo.Clone();
			break;
		case FHPJJJDNKIOOneofCase.GridBasicInfo:
			GridBasicInfo = other.GridBasicInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameInfo Clone()
	{
		return new GridFightGameInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFHPJJJDNKIO()
	{
		fHPJJJDNKIOCase_ = FHPJJJDNKIOOneofCase.None;
		fHPJJJDNKIO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GridDraftInfo, other.GridDraftInfo))
		{
			return false;
		}
		if (!object.Equals(GridItemsInfo, other.GridItemsInfo))
		{
			return false;
		}
		if (!object.Equals(GridTraitGameInfo, other.GridTraitGameInfo))
		{
			return false;
		}
		if (!object.Equals(GridOrbInfo, other.GridOrbInfo))
		{
			return false;
		}
		if (!object.Equals(GridTeamGameInfo, other.GridTeamGameInfo))
		{
			return false;
		}
		if (!object.Equals(GridShopInfo, other.GridShopInfo))
		{
			return false;
		}
		if (!object.Equals(GridAugmentInfo, other.GridAugmentInfo))
		{
			return false;
		}
		if (!object.Equals(GridLevelInfo, other.GridLevelInfo))
		{
			return false;
		}
		if (!object.Equals(GridBasicInfo, other.GridBasicInfo))
		{
			return false;
		}
		if (FHPJJJDNKIOCase != other.FHPJJJDNKIOCase)
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
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridDraftInfo)
		{
			num ^= GridDraftInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridItemsInfo)
		{
			num ^= GridItemsInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTraitGameInfo)
		{
			num ^= GridTraitGameInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridOrbInfo)
		{
			num ^= GridOrbInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTeamGameInfo)
		{
			num ^= GridTeamGameInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridShopInfo)
		{
			num ^= GridShopInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridAugmentInfo)
		{
			num ^= GridAugmentInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridLevelInfo)
		{
			num ^= GridLevelInfo.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridBasicInfo)
		{
			num ^= GridBasicInfo.GetHashCode();
		}
		num ^= (int)fHPJJJDNKIOCase_;
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
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridDraftInfo)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GridDraftInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridItemsInfo)
		{
			output.WriteRawTag(18);
			output.WriteMessage(GridItemsInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTraitGameInfo)
		{
			output.WriteRawTag(26);
			output.WriteMessage(GridTraitGameInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridOrbInfo)
		{
			output.WriteRawTag(58);
			output.WriteMessage(GridOrbInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTeamGameInfo)
		{
			output.WriteRawTag(66);
			output.WriteMessage(GridTeamGameInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridShopInfo)
		{
			output.WriteRawTag(82);
			output.WriteMessage(GridShopInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridAugmentInfo)
		{
			output.WriteRawTag(98);
			output.WriteMessage(GridAugmentInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridLevelInfo)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GridLevelInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridBasicInfo)
		{
			output.WriteRawTag(122);
			output.WriteMessage(GridBasicInfo);
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
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridDraftInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridDraftInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridItemsInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridItemsInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTraitGameInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridTraitGameInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridOrbInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridOrbInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTeamGameInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridTeamGameInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridShopInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridShopInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridAugmentInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridAugmentInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridLevelInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridLevelInfo);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridBasicInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridBasicInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.FHPJJJDNKIOCase)
		{
		case FHPJJJDNKIOOneofCase.GridDraftInfo:
			if (GridDraftInfo == null)
			{
				GridDraftInfo = new GridFightGameItemsInfo();
			}
			GridDraftInfo.MergeFrom(other.GridDraftInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridItemsInfo:
			if (GridItemsInfo == null)
			{
				GridItemsInfo = new GridFightGameShopInfo();
			}
			GridItemsInfo.MergeFrom(other.GridItemsInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridTraitGameInfo:
			if (GridTraitGameInfo == null)
			{
				GridTraitGameInfo = new GridFightGameTeamInfo();
			}
			GridTraitGameInfo.MergeFrom(other.GridTraitGameInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridOrbInfo:
			if (GridOrbInfo == null)
			{
				GridOrbInfo = new GridFightGameAugmentSync();
			}
			GridOrbInfo.MergeFrom(other.GridOrbInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridTeamGameInfo:
			if (GridTeamGameInfo == null)
			{
				GridTeamGameInfo = new LHFDOPGEOML();
			}
			GridTeamGameInfo.MergeFrom(other.GridTeamGameInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridShopInfo:
			if (GridShopInfo == null)
			{
				GridShopInfo = new GridFightLevelInfo();
			}
			GridShopInfo.MergeFrom(other.GridShopInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridAugmentInfo:
			if (GridAugmentInfo == null)
			{
				GridAugmentInfo = new GridFightGameTraitInfo();
			}
			GridAugmentInfo.MergeFrom(other.GridAugmentInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridLevelInfo:
			if (GridLevelInfo == null)
			{
				GridLevelInfo = new GridFightGameOrbInfo();
			}
			GridLevelInfo.MergeFrom(other.GridLevelInfo);
			break;
		case FHPJJJDNKIOOneofCase.GridBasicInfo:
			if (GridBasicInfo == null)
			{
				GridBasicInfo = new GridFightGameBasicInfo();
			}
			GridBasicInfo.MergeFrom(other.GridBasicInfo);
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
				GridFightGameItemsInfo gridFightGameItemsInfo = new GridFightGameItemsInfo();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridDraftInfo)
				{
					gridFightGameItemsInfo.MergeFrom(GridDraftInfo);
				}
				input.ReadMessage(gridFightGameItemsInfo);
				GridDraftInfo = gridFightGameItemsInfo;
				break;
			}
			case 18u:
			{
				GridFightGameShopInfo gridFightGameShopInfo = new GridFightGameShopInfo();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridItemsInfo)
				{
					gridFightGameShopInfo.MergeFrom(GridItemsInfo);
				}
				input.ReadMessage(gridFightGameShopInfo);
				GridItemsInfo = gridFightGameShopInfo;
				break;
			}
			case 26u:
			{
				GridFightGameTeamInfo gridFightGameTeamInfo = new GridFightGameTeamInfo();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTraitGameInfo)
				{
					gridFightGameTeamInfo.MergeFrom(GridTraitGameInfo);
				}
				input.ReadMessage(gridFightGameTeamInfo);
				GridTraitGameInfo = gridFightGameTeamInfo;
				break;
			}
			case 58u:
			{
				GridFightGameAugmentSync gridFightGameAugmentSync = new GridFightGameAugmentSync();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridOrbInfo)
				{
					gridFightGameAugmentSync.MergeFrom(GridOrbInfo);
				}
				input.ReadMessage(gridFightGameAugmentSync);
				GridOrbInfo = gridFightGameAugmentSync;
				break;
			}
			case 66u:
			{
				LHFDOPGEOML lHFDOPGEOML = new LHFDOPGEOML();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridTeamGameInfo)
				{
					lHFDOPGEOML.MergeFrom(GridTeamGameInfo);
				}
				input.ReadMessage(lHFDOPGEOML);
				GridTeamGameInfo = lHFDOPGEOML;
				break;
			}
			case 82u:
			{
				GridFightLevelInfo gridFightLevelInfo = new GridFightLevelInfo();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridShopInfo)
				{
					gridFightLevelInfo.MergeFrom(GridShopInfo);
				}
				input.ReadMessage(gridFightLevelInfo);
				GridShopInfo = gridFightLevelInfo;
				break;
			}
			case 98u:
			{
				GridFightGameTraitInfo gridFightGameTraitInfo = new GridFightGameTraitInfo();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridAugmentInfo)
				{
					gridFightGameTraitInfo.MergeFrom(GridAugmentInfo);
				}
				input.ReadMessage(gridFightGameTraitInfo);
				GridAugmentInfo = gridFightGameTraitInfo;
				break;
			}
			case 106u:
			{
				GridFightGameOrbInfo gridFightGameOrbInfo = new GridFightGameOrbInfo();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridLevelInfo)
				{
					gridFightGameOrbInfo.MergeFrom(GridLevelInfo);
				}
				input.ReadMessage(gridFightGameOrbInfo);
				GridLevelInfo = gridFightGameOrbInfo;
				break;
			}
			case 122u:
			{
				GridFightGameBasicInfo gridFightGameBasicInfo = new GridFightGameBasicInfo();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.GridBasicInfo)
				{
					gridFightGameBasicInfo.MergeFrom(GridBasicInfo);
				}
				input.ReadMessage(gridFightGameBasicInfo);
				GridBasicInfo = gridFightGameBasicInfo;
				break;
			}
			}
		}
	}
}
