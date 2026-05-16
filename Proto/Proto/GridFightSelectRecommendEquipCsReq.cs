using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSelectRecommendEquipCsReq : IMessage<GridFightSelectRecommendEquipCsReq>, IMessage, IEquatable<GridFightSelectRecommendEquipCsReq>, IDeepCloneable<GridFightSelectRecommendEquipCsReq>, IBufferMessage
{
	public enum BGGBIMBKHEIOneofCase
	{
		None = 0,
		TraitAction = 26,
		ReturnPreparationAction = 230,
		APLEGHKNFOK = 308,
		PKCONHLNMIJ = 384,
		HGKMHOOFNDA = 400,
		RerollSupplyAction = 446,
		SupplyAction = 562,
		PortalBuffRerollAction = 649,
		EliteBranchAction = 768,
		RoundBeginAction = 919,
		PortalBuffAction = 1121,
		RerollAugmentAction = 1263,
		KACDGAJHNBI = 1540,
		RecommendEquipmentAction = 1604,
		DJEJJKADBCI = 1663,
		ForgeRoleActionInfo = 1667,
		UpgradeEquipAction = 1677,
		HPMNOGGMKKH = 1708,
		AugmentAction = 1951
	}

	private static readonly MessageParser<GridFightSelectRecommendEquipCsReq> _parser = new MessageParser<GridFightSelectRecommendEquipCsReq>(() => new GridFightSelectRecommendEquipCsReq());

	private UnknownFieldSet _unknownFields;

	public const int QueuePositionFieldNumber = 13;

	private uint queuePosition_;

	public const int TraitActionFieldNumber = 26;

	public const int ReturnPreparationActionFieldNumber = 230;

	public const int APLEGHKNFOKFieldNumber = 308;

	public const int PKCONHLNMIJFieldNumber = 384;

	public const int HGKMHOOFNDAFieldNumber = 400;

	public const int RerollSupplyActionFieldNumber = 446;

	public const int SupplyActionFieldNumber = 562;

	public const int PortalBuffRerollActionFieldNumber = 649;

	public const int EliteBranchActionFieldNumber = 768;

	public const int RoundBeginActionFieldNumber = 919;

	public const int PortalBuffActionFieldNumber = 1121;

	public const int RerollAugmentActionFieldNumber = 1263;

	public const int KACDGAJHNBIFieldNumber = 1540;

	public const int RecommendEquipmentActionFieldNumber = 1604;

	public const int DJEJJKADBCIFieldNumber = 1663;

	public const int ForgeRoleActionInfoFieldNumber = 1667;

	public const int UpgradeEquipActionFieldNumber = 1677;

	public const int HPMNOGGMKKHFieldNumber = 1708;

	public const int AugmentActionFieldNumber = 1951;

	private object bGGBIMBKHEI_;

	private BGGBIMBKHEIOneofCase bGGBIMBKHEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSelectRecommendEquipCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSelectRecommendEquipCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitActionResult TraitAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.TraitAction)
			{
				return null;
			}
			return (GridFightTraitActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.TraitAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightReturnPreparationActionResult ReturnPreparationAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.ReturnPreparationAction)
			{
				return null;
			}
			return (GridFightReturnPreparationActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.ReturnPreparationAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENIHADNBFFI APLEGHKNFOK
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.APLEGHKNFOK)
			{
				return null;
			}
			return (ENIHADNBFFI)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.APLEGHKNFOK : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFKOCHAJKDG PKCONHLNMIJ
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
			{
				return null;
			}
			return (JFKOCHAJKDG)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.PKCONHLNMIJ : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKIPICBFJPM HGKMHOOFNDA
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.HGKMHOOFNDA)
			{
				return null;
			}
			return (KKIPICBFJPM)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.HGKMHOOFNDA : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyRerollActionResult RerollSupplyAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.RerollSupplyAction)
			{
				return null;
			}
			return (GridFightSupplyRerollActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.RerollSupplyAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyActionResult SupplyAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.SupplyAction)
			{
				return null;
			}
			return (GridFightSupplyActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.SupplyAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffRerollActionResult PortalBuffRerollAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.PortalBuffRerollAction)
			{
				return null;
			}
			return (GridFightPortalBuffRerollActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.PortalBuffRerollAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEliteBranchActionResult EliteBranchAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.EliteBranchAction)
			{
				return null;
			}
			return (GridFightEliteBranchActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.EliteBranchAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoundBeginActionResult RoundBeginAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.RoundBeginAction)
			{
				return null;
			}
			return (GridFightRoundBeginActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.RoundBeginAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionResult PortalBuffAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.PortalBuffAction)
			{
				return null;
			}
			return (GridFightPortalBuffActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.PortalBuffAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightAugmentRerollActionResult RerollAugmentAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.RerollAugmentAction)
			{
				return null;
			}
			return (GridFightAugmentRerollActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.RerollAugmentAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFKEDPPLOKL KACDGAJHNBI
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.KACDGAJHNBI)
			{
				return null;
			}
			return (LFKEDPPLOKL)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.KACDGAJHNBI : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRecommendEquipmentActionResult RecommendEquipmentAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
			{
				return null;
			}
			return (GridFightRecommendEquipmentActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.RecommendEquipmentAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKJGGLLEELK DJEJJKADBCI
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.DJEJJKADBCI)
			{
				return null;
			}
			return (EKJGGLLEELK)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.DJEJJKADBCI : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleActionResult ForgeRoleActionInfo
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
			{
				return null;
			}
			return (GridFightForgeRoleActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.ForgeRoleActionInfo : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpgradeEquipActionResult UpgradeEquipAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.UpgradeEquipAction)
			{
				return null;
			}
			return (GridFightUpgradeEquipActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.UpgradeEquipAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPCJBDHDHLL HPMNOGGMKKH
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
			{
				return null;
			}
			return (PPCJBDHDHLL)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.HPMNOGGMKKH : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightAugmentActionResult AugmentAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.AugmentAction)
			{
				return null;
			}
			return (GridFightAugmentActionResult)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.AugmentAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGGBIMBKHEIOneofCase BGGBIMBKHEICase => bGGBIMBKHEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSelectRecommendEquipCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSelectRecommendEquipCsReq(GridFightSelectRecommendEquipCsReq other)
		: this()
	{
		queuePosition_ = other.queuePosition_;
		switch (other.BGGBIMBKHEICase)
		{
		case BGGBIMBKHEIOneofCase.TraitAction:
			TraitAction = other.TraitAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.ReturnPreparationAction:
			ReturnPreparationAction = other.ReturnPreparationAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.APLEGHKNFOK:
			APLEGHKNFOK = other.APLEGHKNFOK.Clone();
			break;
		case BGGBIMBKHEIOneofCase.PKCONHLNMIJ:
			PKCONHLNMIJ = other.PKCONHLNMIJ.Clone();
			break;
		case BGGBIMBKHEIOneofCase.HGKMHOOFNDA:
			HGKMHOOFNDA = other.HGKMHOOFNDA.Clone();
			break;
		case BGGBIMBKHEIOneofCase.RerollSupplyAction:
			RerollSupplyAction = other.RerollSupplyAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.SupplyAction:
			SupplyAction = other.SupplyAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.PortalBuffRerollAction:
			PortalBuffRerollAction = other.PortalBuffRerollAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.EliteBranchAction:
			EliteBranchAction = other.EliteBranchAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.RoundBeginAction:
			RoundBeginAction = other.RoundBeginAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.PortalBuffAction:
			PortalBuffAction = other.PortalBuffAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.RerollAugmentAction:
			RerollAugmentAction = other.RerollAugmentAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.KACDGAJHNBI:
			KACDGAJHNBI = other.KACDGAJHNBI.Clone();
			break;
		case BGGBIMBKHEIOneofCase.RecommendEquipmentAction:
			RecommendEquipmentAction = other.RecommendEquipmentAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.DJEJJKADBCI:
			DJEJJKADBCI = other.DJEJJKADBCI.Clone();
			break;
		case BGGBIMBKHEIOneofCase.ForgeRoleActionInfo:
			ForgeRoleActionInfo = other.ForgeRoleActionInfo.Clone();
			break;
		case BGGBIMBKHEIOneofCase.UpgradeEquipAction:
			UpgradeEquipAction = other.UpgradeEquipAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.HPMNOGGMKKH:
			HPMNOGGMKKH = other.HPMNOGGMKKH.Clone();
			break;
		case BGGBIMBKHEIOneofCase.AugmentAction:
			AugmentAction = other.AugmentAction.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSelectRecommendEquipCsReq Clone()
	{
		return new GridFightSelectRecommendEquipCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBGGBIMBKHEI()
	{
		bGGBIMBKHEICase_ = BGGBIMBKHEIOneofCase.None;
		bGGBIMBKHEI_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSelectRecommendEquipCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSelectRecommendEquipCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (!object.Equals(TraitAction, other.TraitAction))
		{
			return false;
		}
		if (!object.Equals(ReturnPreparationAction, other.ReturnPreparationAction))
		{
			return false;
		}
		if (!object.Equals(APLEGHKNFOK, other.APLEGHKNFOK))
		{
			return false;
		}
		if (!object.Equals(PKCONHLNMIJ, other.PKCONHLNMIJ))
		{
			return false;
		}
		if (!object.Equals(HGKMHOOFNDA, other.HGKMHOOFNDA))
		{
			return false;
		}
		if (!object.Equals(RerollSupplyAction, other.RerollSupplyAction))
		{
			return false;
		}
		if (!object.Equals(SupplyAction, other.SupplyAction))
		{
			return false;
		}
		if (!object.Equals(PortalBuffRerollAction, other.PortalBuffRerollAction))
		{
			return false;
		}
		if (!object.Equals(EliteBranchAction, other.EliteBranchAction))
		{
			return false;
		}
		if (!object.Equals(RoundBeginAction, other.RoundBeginAction))
		{
			return false;
		}
		if (!object.Equals(PortalBuffAction, other.PortalBuffAction))
		{
			return false;
		}
		if (!object.Equals(RerollAugmentAction, other.RerollAugmentAction))
		{
			return false;
		}
		if (!object.Equals(KACDGAJHNBI, other.KACDGAJHNBI))
		{
			return false;
		}
		if (!object.Equals(RecommendEquipmentAction, other.RecommendEquipmentAction))
		{
			return false;
		}
		if (!object.Equals(DJEJJKADBCI, other.DJEJJKADBCI))
		{
			return false;
		}
		if (!object.Equals(ForgeRoleActionInfo, other.ForgeRoleActionInfo))
		{
			return false;
		}
		if (!object.Equals(UpgradeEquipAction, other.UpgradeEquipAction))
		{
			return false;
		}
		if (!object.Equals(HPMNOGGMKKH, other.HPMNOGGMKKH))
		{
			return false;
		}
		if (!object.Equals(AugmentAction, other.AugmentAction))
		{
			return false;
		}
		if (BGGBIMBKHEICase != other.BGGBIMBKHEICase)
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
		{
			num ^= TraitAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
		{
			num ^= ReturnPreparationAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
		{
			num ^= APLEGHKNFOK.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
		{
			num ^= PKCONHLNMIJ.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HGKMHOOFNDA)
		{
			num ^= HGKMHOOFNDA.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollSupplyAction)
		{
			num ^= RerollSupplyAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
		{
			num ^= SupplyAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffRerollAction)
		{
			num ^= PortalBuffRerollAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
		{
			num ^= EliteBranchAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
		{
			num ^= RoundBeginAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
		{
			num ^= PortalBuffAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollAugmentAction)
		{
			num ^= RerollAugmentAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
		{
			num ^= KACDGAJHNBI.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
		{
			num ^= RecommendEquipmentAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
		{
			num ^= DJEJJKADBCI.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
		{
			num ^= ForgeRoleActionInfo.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
		{
			num ^= UpgradeEquipAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
		{
			num ^= HPMNOGGMKKH.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
		{
			num ^= AugmentAction.GetHashCode();
		}
		num ^= (int)bGGBIMBKHEICase_;
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
		if (QueuePosition != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(QueuePosition);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
		{
			output.WriteRawTag(210, 1);
			output.WriteMessage(TraitAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
		{
			output.WriteRawTag(178, 14);
			output.WriteMessage(ReturnPreparationAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
		{
			output.WriteRawTag(162, 19);
			output.WriteMessage(APLEGHKNFOK);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
		{
			output.WriteRawTag(130, 24);
			output.WriteMessage(PKCONHLNMIJ);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HGKMHOOFNDA)
		{
			output.WriteRawTag(130, 25);
			output.WriteMessage(HGKMHOOFNDA);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollSupplyAction)
		{
			output.WriteRawTag(242, 27);
			output.WriteMessage(RerollSupplyAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
		{
			output.WriteRawTag(146, 35);
			output.WriteMessage(SupplyAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffRerollAction)
		{
			output.WriteRawTag(202, 40);
			output.WriteMessage(PortalBuffRerollAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
		{
			output.WriteRawTag(130, 48);
			output.WriteMessage(EliteBranchAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
		{
			output.WriteRawTag(186, 57);
			output.WriteMessage(RoundBeginAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
		{
			output.WriteRawTag(138, 70);
			output.WriteMessage(PortalBuffAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollAugmentAction)
		{
			output.WriteRawTag(250, 78);
			output.WriteMessage(RerollAugmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
		{
			output.WriteRawTag(162, 96);
			output.WriteMessage(KACDGAJHNBI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
		{
			output.WriteRawTag(162, 100);
			output.WriteMessage(RecommendEquipmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
		{
			output.WriteRawTag(250, 103);
			output.WriteMessage(DJEJJKADBCI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
		{
			output.WriteRawTag(154, 104);
			output.WriteMessage(ForgeRoleActionInfo);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
		{
			output.WriteRawTag(234, 104);
			output.WriteMessage(UpgradeEquipAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
		{
			output.WriteRawTag(226, 106);
			output.WriteMessage(HPMNOGGMKKH);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
		{
			output.WriteRawTag(250, 121);
			output.WriteMessage(AugmentAction);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TraitAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ReturnPreparationAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(APLEGHKNFOK);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PKCONHLNMIJ);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HGKMHOOFNDA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HGKMHOOFNDA);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollSupplyAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RerollSupplyAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SupplyAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffRerollAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PortalBuffRerollAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EliteBranchAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoundBeginAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PortalBuffAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollAugmentAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RerollAugmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KACDGAJHNBI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RecommendEquipmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DJEJJKADBCI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ForgeRoleActionInfo);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(UpgradeEquipAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HPMNOGGMKKH);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AugmentAction);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSelectRecommendEquipCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		switch (other.BGGBIMBKHEICase)
		{
		case BGGBIMBKHEIOneofCase.TraitAction:
			if (TraitAction == null)
			{
				TraitAction = new GridFightTraitActionResult();
			}
			TraitAction.MergeFrom(other.TraitAction);
			break;
		case BGGBIMBKHEIOneofCase.ReturnPreparationAction:
			if (ReturnPreparationAction == null)
			{
				ReturnPreparationAction = new GridFightReturnPreparationActionResult();
			}
			ReturnPreparationAction.MergeFrom(other.ReturnPreparationAction);
			break;
		case BGGBIMBKHEIOneofCase.APLEGHKNFOK:
			if (APLEGHKNFOK == null)
			{
				APLEGHKNFOK = new ENIHADNBFFI();
			}
			APLEGHKNFOK.MergeFrom(other.APLEGHKNFOK);
			break;
		case BGGBIMBKHEIOneofCase.PKCONHLNMIJ:
			if (PKCONHLNMIJ == null)
			{
				PKCONHLNMIJ = new JFKOCHAJKDG();
			}
			PKCONHLNMIJ.MergeFrom(other.PKCONHLNMIJ);
			break;
		case BGGBIMBKHEIOneofCase.HGKMHOOFNDA:
			if (HGKMHOOFNDA == null)
			{
				HGKMHOOFNDA = new KKIPICBFJPM();
			}
			HGKMHOOFNDA.MergeFrom(other.HGKMHOOFNDA);
			break;
		case BGGBIMBKHEIOneofCase.RerollSupplyAction:
			if (RerollSupplyAction == null)
			{
				RerollSupplyAction = new GridFightSupplyRerollActionResult();
			}
			RerollSupplyAction.MergeFrom(other.RerollSupplyAction);
			break;
		case BGGBIMBKHEIOneofCase.SupplyAction:
			if (SupplyAction == null)
			{
				SupplyAction = new GridFightSupplyActionResult();
			}
			SupplyAction.MergeFrom(other.SupplyAction);
			break;
		case BGGBIMBKHEIOneofCase.PortalBuffRerollAction:
			if (PortalBuffRerollAction == null)
			{
				PortalBuffRerollAction = new GridFightPortalBuffRerollActionResult();
			}
			PortalBuffRerollAction.MergeFrom(other.PortalBuffRerollAction);
			break;
		case BGGBIMBKHEIOneofCase.EliteBranchAction:
			if (EliteBranchAction == null)
			{
				EliteBranchAction = new GridFightEliteBranchActionResult();
			}
			EliteBranchAction.MergeFrom(other.EliteBranchAction);
			break;
		case BGGBIMBKHEIOneofCase.RoundBeginAction:
			if (RoundBeginAction == null)
			{
				RoundBeginAction = new GridFightRoundBeginActionResult();
			}
			RoundBeginAction.MergeFrom(other.RoundBeginAction);
			break;
		case BGGBIMBKHEIOneofCase.PortalBuffAction:
			if (PortalBuffAction == null)
			{
				PortalBuffAction = new GridFightPortalBuffActionResult();
			}
			PortalBuffAction.MergeFrom(other.PortalBuffAction);
			break;
		case BGGBIMBKHEIOneofCase.RerollAugmentAction:
			if (RerollAugmentAction == null)
			{
				RerollAugmentAction = new GridFightAugmentRerollActionResult();
			}
			RerollAugmentAction.MergeFrom(other.RerollAugmentAction);
			break;
		case BGGBIMBKHEIOneofCase.KACDGAJHNBI:
			if (KACDGAJHNBI == null)
			{
				KACDGAJHNBI = new LFKEDPPLOKL();
			}
			KACDGAJHNBI.MergeFrom(other.KACDGAJHNBI);
			break;
		case BGGBIMBKHEIOneofCase.RecommendEquipmentAction:
			if (RecommendEquipmentAction == null)
			{
				RecommendEquipmentAction = new GridFightRecommendEquipmentActionResult();
			}
			RecommendEquipmentAction.MergeFrom(other.RecommendEquipmentAction);
			break;
		case BGGBIMBKHEIOneofCase.DJEJJKADBCI:
			if (DJEJJKADBCI == null)
			{
				DJEJJKADBCI = new EKJGGLLEELK();
			}
			DJEJJKADBCI.MergeFrom(other.DJEJJKADBCI);
			break;
		case BGGBIMBKHEIOneofCase.ForgeRoleActionInfo:
			if (ForgeRoleActionInfo == null)
			{
				ForgeRoleActionInfo = new GridFightForgeRoleActionResult();
			}
			ForgeRoleActionInfo.MergeFrom(other.ForgeRoleActionInfo);
			break;
		case BGGBIMBKHEIOneofCase.UpgradeEquipAction:
			if (UpgradeEquipAction == null)
			{
				UpgradeEquipAction = new GridFightUpgradeEquipActionResult();
			}
			UpgradeEquipAction.MergeFrom(other.UpgradeEquipAction);
			break;
		case BGGBIMBKHEIOneofCase.HPMNOGGMKKH:
			if (HPMNOGGMKKH == null)
			{
				HPMNOGGMKKH = new PPCJBDHDHLL();
			}
			HPMNOGGMKKH.MergeFrom(other.HPMNOGGMKKH);
			break;
		case BGGBIMBKHEIOneofCase.AugmentAction:
			if (AugmentAction == null)
			{
				AugmentAction = new GridFightAugmentActionResult();
			}
			AugmentAction.MergeFrom(other.AugmentAction);
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
			case 104u:
				QueuePosition = input.ReadUInt32();
				break;
			case 210u:
			{
				GridFightTraitActionResult gridFightTraitActionResult = new GridFightTraitActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
				{
					gridFightTraitActionResult.MergeFrom(TraitAction);
				}
				input.ReadMessage(gridFightTraitActionResult);
				TraitAction = gridFightTraitActionResult;
				break;
			}
			case 1842u:
			{
				GridFightReturnPreparationActionResult gridFightReturnPreparationActionResult = new GridFightReturnPreparationActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
				{
					gridFightReturnPreparationActionResult.MergeFrom(ReturnPreparationAction);
				}
				input.ReadMessage(gridFightReturnPreparationActionResult);
				ReturnPreparationAction = gridFightReturnPreparationActionResult;
				break;
			}
			case 2466u:
			{
				ENIHADNBFFI eNIHADNBFFI = new ENIHADNBFFI();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
				{
					eNIHADNBFFI.MergeFrom(APLEGHKNFOK);
				}
				input.ReadMessage(eNIHADNBFFI);
				APLEGHKNFOK = eNIHADNBFFI;
				break;
			}
			case 3074u:
			{
				JFKOCHAJKDG jFKOCHAJKDG = new JFKOCHAJKDG();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
				{
					jFKOCHAJKDG.MergeFrom(PKCONHLNMIJ);
				}
				input.ReadMessage(jFKOCHAJKDG);
				PKCONHLNMIJ = jFKOCHAJKDG;
				break;
			}
			case 3202u:
			{
				KKIPICBFJPM kKIPICBFJPM = new KKIPICBFJPM();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HGKMHOOFNDA)
				{
					kKIPICBFJPM.MergeFrom(HGKMHOOFNDA);
				}
				input.ReadMessage(kKIPICBFJPM);
				HGKMHOOFNDA = kKIPICBFJPM;
				break;
			}
			case 3570u:
			{
				GridFightSupplyRerollActionResult gridFightSupplyRerollActionResult = new GridFightSupplyRerollActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollSupplyAction)
				{
					gridFightSupplyRerollActionResult.MergeFrom(RerollSupplyAction);
				}
				input.ReadMessage(gridFightSupplyRerollActionResult);
				RerollSupplyAction = gridFightSupplyRerollActionResult;
				break;
			}
			case 4498u:
			{
				GridFightSupplyActionResult gridFightSupplyActionResult = new GridFightSupplyActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
				{
					gridFightSupplyActionResult.MergeFrom(SupplyAction);
				}
				input.ReadMessage(gridFightSupplyActionResult);
				SupplyAction = gridFightSupplyActionResult;
				break;
			}
			case 5194u:
			{
				GridFightPortalBuffRerollActionResult gridFightPortalBuffRerollActionResult = new GridFightPortalBuffRerollActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffRerollAction)
				{
					gridFightPortalBuffRerollActionResult.MergeFrom(PortalBuffRerollAction);
				}
				input.ReadMessage(gridFightPortalBuffRerollActionResult);
				PortalBuffRerollAction = gridFightPortalBuffRerollActionResult;
				break;
			}
			case 6146u:
			{
				GridFightEliteBranchActionResult gridFightEliteBranchActionResult = new GridFightEliteBranchActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
				{
					gridFightEliteBranchActionResult.MergeFrom(EliteBranchAction);
				}
				input.ReadMessage(gridFightEliteBranchActionResult);
				EliteBranchAction = gridFightEliteBranchActionResult;
				break;
			}
			case 7354u:
			{
				GridFightRoundBeginActionResult gridFightRoundBeginActionResult = new GridFightRoundBeginActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
				{
					gridFightRoundBeginActionResult.MergeFrom(RoundBeginAction);
				}
				input.ReadMessage(gridFightRoundBeginActionResult);
				RoundBeginAction = gridFightRoundBeginActionResult;
				break;
			}
			case 8970u:
			{
				GridFightPortalBuffActionResult gridFightPortalBuffActionResult = new GridFightPortalBuffActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
				{
					gridFightPortalBuffActionResult.MergeFrom(PortalBuffAction);
				}
				input.ReadMessage(gridFightPortalBuffActionResult);
				PortalBuffAction = gridFightPortalBuffActionResult;
				break;
			}
			case 10106u:
			{
				GridFightAugmentRerollActionResult gridFightAugmentRerollActionResult = new GridFightAugmentRerollActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RerollAugmentAction)
				{
					gridFightAugmentRerollActionResult.MergeFrom(RerollAugmentAction);
				}
				input.ReadMessage(gridFightAugmentRerollActionResult);
				RerollAugmentAction = gridFightAugmentRerollActionResult;
				break;
			}
			case 12322u:
			{
				LFKEDPPLOKL lFKEDPPLOKL = new LFKEDPPLOKL();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
				{
					lFKEDPPLOKL.MergeFrom(KACDGAJHNBI);
				}
				input.ReadMessage(lFKEDPPLOKL);
				KACDGAJHNBI = lFKEDPPLOKL;
				break;
			}
			case 12834u:
			{
				GridFightRecommendEquipmentActionResult gridFightRecommendEquipmentActionResult = new GridFightRecommendEquipmentActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
				{
					gridFightRecommendEquipmentActionResult.MergeFrom(RecommendEquipmentAction);
				}
				input.ReadMessage(gridFightRecommendEquipmentActionResult);
				RecommendEquipmentAction = gridFightRecommendEquipmentActionResult;
				break;
			}
			case 13306u:
			{
				EKJGGLLEELK eKJGGLLEELK = new EKJGGLLEELK();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
				{
					eKJGGLLEELK.MergeFrom(DJEJJKADBCI);
				}
				input.ReadMessage(eKJGGLLEELK);
				DJEJJKADBCI = eKJGGLLEELK;
				break;
			}
			case 13338u:
			{
				GridFightForgeRoleActionResult gridFightForgeRoleActionResult = new GridFightForgeRoleActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
				{
					gridFightForgeRoleActionResult.MergeFrom(ForgeRoleActionInfo);
				}
				input.ReadMessage(gridFightForgeRoleActionResult);
				ForgeRoleActionInfo = gridFightForgeRoleActionResult;
				break;
			}
			case 13418u:
			{
				GridFightUpgradeEquipActionResult gridFightUpgradeEquipActionResult = new GridFightUpgradeEquipActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
				{
					gridFightUpgradeEquipActionResult.MergeFrom(UpgradeEquipAction);
				}
				input.ReadMessage(gridFightUpgradeEquipActionResult);
				UpgradeEquipAction = gridFightUpgradeEquipActionResult;
				break;
			}
			case 13666u:
			{
				PPCJBDHDHLL pPCJBDHDHLL = new PPCJBDHDHLL();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
				{
					pPCJBDHDHLL.MergeFrom(HPMNOGGMKKH);
				}
				input.ReadMessage(pPCJBDHDHLL);
				HPMNOGGMKKH = pPCJBDHDHLL;
				break;
			}
			case 15610u:
			{
				GridFightAugmentActionResult gridFightAugmentActionResult = new GridFightAugmentActionResult();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
				{
					gridFightAugmentActionResult.MergeFrom(AugmentAction);
				}
				input.ReadMessage(gridFightAugmentActionResult);
				AugmentAction = gridFightAugmentActionResult;
				break;
			}
			}
		}
	}
}
