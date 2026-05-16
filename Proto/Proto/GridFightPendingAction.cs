using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightPendingAction : IMessage<GridFightPendingAction>, IMessage, IEquatable<GridFightPendingAction>, IDeepCloneable<GridFightPendingAction>, IBufferMessage
{
	public enum BGGBIMBKHEIOneofCase
	{
		None = 0,
		SupplyAction = 21,
		ReturnPreparationAction = 38,
		DJEJJKADBCI = 164,
		HPMNOGGMKKH = 284,
		AugmentAction = 482,
		RoundBeginAction = 872,
		RecommendEquipmentAction = 980,
		UpgradeEquipAction = 1063,
		ForgeRoleActionInfo = 1151,
		KACDGAJHNBI = 1211,
		APLEGHKNFOK = 1446,
		PKCONHLNMIJ = 1540,
		TraitAction = 1800,
		PortalBuffAction = 1843,
		EliteBranchAction = 1893
	}

	private static readonly MessageParser<GridFightPendingAction> _parser = new MessageParser<GridFightPendingAction>(() => new GridFightPendingAction());

	private UnknownFieldSet _unknownFields;

	public const int QueuePositionFieldNumber = 5;

	private uint queuePosition_;

	public const int SupplyActionFieldNumber = 21;

	public const int ReturnPreparationActionFieldNumber = 38;

	public const int DJEJJKADBCIFieldNumber = 164;

	public const int HPMNOGGMKKHFieldNumber = 284;

	public const int AugmentActionFieldNumber = 482;

	public const int RoundBeginActionFieldNumber = 872;

	public const int RecommendEquipmentActionFieldNumber = 980;

	public const int UpgradeEquipActionFieldNumber = 1063;

	public const int ForgeRoleActionInfoFieldNumber = 1151;

	public const int KACDGAJHNBIFieldNumber = 1211;

	public const int APLEGHKNFOKFieldNumber = 1446;

	public const int PKCONHLNMIJFieldNumber = 1540;

	public const int TraitActionFieldNumber = 1800;

	public const int PortalBuffActionFieldNumber = 1843;

	public const int EliteBranchActionFieldNumber = 1893;

	private object bGGBIMBKHEI_;

	private BGGBIMBKHEIOneofCase bGGBIMBKHEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightPendingAction> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightPendingActionReflection.Descriptor.MessageTypes[0];

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
	public GridFightSupplyActionInfo SupplyAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.SupplyAction)
			{
				return null;
			}
			return (GridFightSupplyActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.SupplyAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightReturnPreparationActionInfo ReturnPreparationAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.ReturnPreparationAction)
			{
				return null;
			}
			return (GridFightReturnPreparationActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.ReturnPreparationAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIKMJKNHJGA DJEJJKADBCI
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.DJEJJKADBCI)
			{
				return null;
			}
			return (KIKMJKNHJGA)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.DJEJJKADBCI : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHJCELBCFNF HPMNOGGMKKH
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
			{
				return null;
			}
			return (NHJCELBCFNF)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.HPMNOGGMKKH : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightAugmentActionInfo AugmentAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.AugmentAction)
			{
				return null;
			}
			return (GridFightAugmentActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.AugmentAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoundBeginActionInfo RoundBeginAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.RoundBeginAction)
			{
				return null;
			}
			return (GridFightRoundBeginActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.RoundBeginAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRecommendEquipmentActionInfo RecommendEquipmentAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
			{
				return null;
			}
			return (GridFightRecommendEquipmentActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.RecommendEquipmentAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpgradeEquipActionInfo UpgradeEquipAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.UpgradeEquipAction)
			{
				return null;
			}
			return (GridFightUpgradeEquipActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.UpgradeEquipAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleActionInfo ForgeRoleActionInfo
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
			{
				return null;
			}
			return (GridFightForgeRoleActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.ForgeRoleActionInfo : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJJFPLFEEFC KACDGAJHNBI
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.KACDGAJHNBI)
			{
				return null;
			}
			return (NJJFPLFEEFC)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.KACDGAJHNBI : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEPFIAFJAHL APLEGHKNFOK
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.APLEGHKNFOK)
			{
				return null;
			}
			return (HEPFIAFJAHL)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.APLEGHKNFOK : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEJAJMNKAMI PKCONHLNMIJ
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
			{
				return null;
			}
			return (EEJAJMNKAMI)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.PKCONHLNMIJ : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitActionInfo TraitAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.TraitAction)
			{
				return null;
			}
			return (GridFightTraitActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.TraitAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionInfo PortalBuffAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.PortalBuffAction)
			{
				return null;
			}
			return (GridFightPortalBuffActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.PortalBuffAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEliteBranchActionInfo EliteBranchAction
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.EliteBranchAction)
			{
				return null;
			}
			return (GridFightEliteBranchActionInfo)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.EliteBranchAction : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGGBIMBKHEIOneofCase BGGBIMBKHEICase => bGGBIMBKHEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAction()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAction(GridFightPendingAction other)
		: this()
	{
		queuePosition_ = other.queuePosition_;
		switch (other.BGGBIMBKHEICase)
		{
		case BGGBIMBKHEIOneofCase.SupplyAction:
			SupplyAction = other.SupplyAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.ReturnPreparationAction:
			ReturnPreparationAction = other.ReturnPreparationAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.DJEJJKADBCI:
			DJEJJKADBCI = other.DJEJJKADBCI.Clone();
			break;
		case BGGBIMBKHEIOneofCase.HPMNOGGMKKH:
			HPMNOGGMKKH = other.HPMNOGGMKKH.Clone();
			break;
		case BGGBIMBKHEIOneofCase.AugmentAction:
			AugmentAction = other.AugmentAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.RoundBeginAction:
			RoundBeginAction = other.RoundBeginAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.RecommendEquipmentAction:
			RecommendEquipmentAction = other.RecommendEquipmentAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.UpgradeEquipAction:
			UpgradeEquipAction = other.UpgradeEquipAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.ForgeRoleActionInfo:
			ForgeRoleActionInfo = other.ForgeRoleActionInfo.Clone();
			break;
		case BGGBIMBKHEIOneofCase.KACDGAJHNBI:
			KACDGAJHNBI = other.KACDGAJHNBI.Clone();
			break;
		case BGGBIMBKHEIOneofCase.APLEGHKNFOK:
			APLEGHKNFOK = other.APLEGHKNFOK.Clone();
			break;
		case BGGBIMBKHEIOneofCase.PKCONHLNMIJ:
			PKCONHLNMIJ = other.PKCONHLNMIJ.Clone();
			break;
		case BGGBIMBKHEIOneofCase.TraitAction:
			TraitAction = other.TraitAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.PortalBuffAction:
			PortalBuffAction = other.PortalBuffAction.Clone();
			break;
		case BGGBIMBKHEIOneofCase.EliteBranchAction:
			EliteBranchAction = other.EliteBranchAction.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAction Clone()
	{
		return new GridFightPendingAction(this);
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
		return Equals(other as GridFightPendingAction);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightPendingAction other)
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
		if (!object.Equals(SupplyAction, other.SupplyAction))
		{
			return false;
		}
		if (!object.Equals(ReturnPreparationAction, other.ReturnPreparationAction))
		{
			return false;
		}
		if (!object.Equals(DJEJJKADBCI, other.DJEJJKADBCI))
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
		if (!object.Equals(RoundBeginAction, other.RoundBeginAction))
		{
			return false;
		}
		if (!object.Equals(RecommendEquipmentAction, other.RecommendEquipmentAction))
		{
			return false;
		}
		if (!object.Equals(UpgradeEquipAction, other.UpgradeEquipAction))
		{
			return false;
		}
		if (!object.Equals(ForgeRoleActionInfo, other.ForgeRoleActionInfo))
		{
			return false;
		}
		if (!object.Equals(KACDGAJHNBI, other.KACDGAJHNBI))
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
		if (!object.Equals(TraitAction, other.TraitAction))
		{
			return false;
		}
		if (!object.Equals(PortalBuffAction, other.PortalBuffAction))
		{
			return false;
		}
		if (!object.Equals(EliteBranchAction, other.EliteBranchAction))
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
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
		{
			num ^= SupplyAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
		{
			num ^= ReturnPreparationAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
		{
			num ^= DJEJJKADBCI.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
		{
			num ^= HPMNOGGMKKH.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
		{
			num ^= AugmentAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
		{
			num ^= RoundBeginAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
		{
			num ^= RecommendEquipmentAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
		{
			num ^= UpgradeEquipAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
		{
			num ^= ForgeRoleActionInfo.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
		{
			num ^= KACDGAJHNBI.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
		{
			num ^= APLEGHKNFOK.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
		{
			num ^= PKCONHLNMIJ.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
		{
			num ^= TraitAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
		{
			num ^= PortalBuffAction.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
		{
			num ^= EliteBranchAction.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(QueuePosition);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
		{
			output.WriteRawTag(170, 1);
			output.WriteMessage(SupplyAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
		{
			output.WriteRawTag(178, 2);
			output.WriteMessage(ReturnPreparationAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
		{
			output.WriteRawTag(162, 10);
			output.WriteMessage(DJEJJKADBCI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
		{
			output.WriteRawTag(226, 17);
			output.WriteMessage(HPMNOGGMKKH);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
		{
			output.WriteRawTag(146, 30);
			output.WriteMessage(AugmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
		{
			output.WriteRawTag(194, 54);
			output.WriteMessage(RoundBeginAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
		{
			output.WriteRawTag(162, 61);
			output.WriteMessage(RecommendEquipmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
		{
			output.WriteRawTag(186, 66);
			output.WriteMessage(UpgradeEquipAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
		{
			output.WriteRawTag(250, 71);
			output.WriteMessage(ForgeRoleActionInfo);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
		{
			output.WriteRawTag(218, 75);
			output.WriteMessage(KACDGAJHNBI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
		{
			output.WriteRawTag(178, 90);
			output.WriteMessage(APLEGHKNFOK);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
		{
			output.WriteRawTag(162, 96);
			output.WriteMessage(PKCONHLNMIJ);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
		{
			output.WriteRawTag(194, 112);
			output.WriteMessage(TraitAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
		{
			output.WriteRawTag(154, 115);
			output.WriteMessage(PortalBuffAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
		{
			output.WriteRawTag(170, 118);
			output.WriteMessage(EliteBranchAction);
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
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SupplyAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ReturnPreparationAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DJEJJKADBCI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HPMNOGGMKKH);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AugmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoundBeginAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RecommendEquipmentAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(UpgradeEquipAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ForgeRoleActionInfo);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KACDGAJHNBI);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(APLEGHKNFOK);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PKCONHLNMIJ);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TraitAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PortalBuffAction);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EliteBranchAction);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightPendingAction other)
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
		case BGGBIMBKHEIOneofCase.SupplyAction:
			if (SupplyAction == null)
			{
				SupplyAction = new GridFightSupplyActionInfo();
			}
			SupplyAction.MergeFrom(other.SupplyAction);
			break;
		case BGGBIMBKHEIOneofCase.ReturnPreparationAction:
			if (ReturnPreparationAction == null)
			{
				ReturnPreparationAction = new GridFightReturnPreparationActionInfo();
			}
			ReturnPreparationAction.MergeFrom(other.ReturnPreparationAction);
			break;
		case BGGBIMBKHEIOneofCase.DJEJJKADBCI:
			if (DJEJJKADBCI == null)
			{
				DJEJJKADBCI = new KIKMJKNHJGA();
			}
			DJEJJKADBCI.MergeFrom(other.DJEJJKADBCI);
			break;
		case BGGBIMBKHEIOneofCase.HPMNOGGMKKH:
			if (HPMNOGGMKKH == null)
			{
				HPMNOGGMKKH = new NHJCELBCFNF();
			}
			HPMNOGGMKKH.MergeFrom(other.HPMNOGGMKKH);
			break;
		case BGGBIMBKHEIOneofCase.AugmentAction:
			if (AugmentAction == null)
			{
				AugmentAction = new GridFightAugmentActionInfo();
			}
			AugmentAction.MergeFrom(other.AugmentAction);
			break;
		case BGGBIMBKHEIOneofCase.RoundBeginAction:
			if (RoundBeginAction == null)
			{
				RoundBeginAction = new GridFightRoundBeginActionInfo();
			}
			RoundBeginAction.MergeFrom(other.RoundBeginAction);
			break;
		case BGGBIMBKHEIOneofCase.RecommendEquipmentAction:
			if (RecommendEquipmentAction == null)
			{
				RecommendEquipmentAction = new GridFightRecommendEquipmentActionInfo();
			}
			RecommendEquipmentAction.MergeFrom(other.RecommendEquipmentAction);
			break;
		case BGGBIMBKHEIOneofCase.UpgradeEquipAction:
			if (UpgradeEquipAction == null)
			{
				UpgradeEquipAction = new GridFightUpgradeEquipActionInfo();
			}
			UpgradeEquipAction.MergeFrom(other.UpgradeEquipAction);
			break;
		case BGGBIMBKHEIOneofCase.ForgeRoleActionInfo:
			if (ForgeRoleActionInfo == null)
			{
				ForgeRoleActionInfo = new GridFightForgeRoleActionInfo();
			}
			ForgeRoleActionInfo.MergeFrom(other.ForgeRoleActionInfo);
			break;
		case BGGBIMBKHEIOneofCase.KACDGAJHNBI:
			if (KACDGAJHNBI == null)
			{
				KACDGAJHNBI = new NJJFPLFEEFC();
			}
			KACDGAJHNBI.MergeFrom(other.KACDGAJHNBI);
			break;
		case BGGBIMBKHEIOneofCase.APLEGHKNFOK:
			if (APLEGHKNFOK == null)
			{
				APLEGHKNFOK = new HEPFIAFJAHL();
			}
			APLEGHKNFOK.MergeFrom(other.APLEGHKNFOK);
			break;
		case BGGBIMBKHEIOneofCase.PKCONHLNMIJ:
			if (PKCONHLNMIJ == null)
			{
				PKCONHLNMIJ = new EEJAJMNKAMI();
			}
			PKCONHLNMIJ.MergeFrom(other.PKCONHLNMIJ);
			break;
		case BGGBIMBKHEIOneofCase.TraitAction:
			if (TraitAction == null)
			{
				TraitAction = new GridFightTraitActionInfo();
			}
			TraitAction.MergeFrom(other.TraitAction);
			break;
		case BGGBIMBKHEIOneofCase.PortalBuffAction:
			if (PortalBuffAction == null)
			{
				PortalBuffAction = new GridFightPortalBuffActionInfo();
			}
			PortalBuffAction.MergeFrom(other.PortalBuffAction);
			break;
		case BGGBIMBKHEIOneofCase.EliteBranchAction:
			if (EliteBranchAction == null)
			{
				EliteBranchAction = new GridFightEliteBranchActionInfo();
			}
			EliteBranchAction.MergeFrom(other.EliteBranchAction);
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
			case 40u:
				QueuePosition = input.ReadUInt32();
				break;
			case 170u:
			{
				GridFightSupplyActionInfo gridFightSupplyActionInfo = new GridFightSupplyActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.SupplyAction)
				{
					gridFightSupplyActionInfo.MergeFrom(SupplyAction);
				}
				input.ReadMessage(gridFightSupplyActionInfo);
				SupplyAction = gridFightSupplyActionInfo;
				break;
			}
			case 306u:
			{
				GridFightReturnPreparationActionInfo gridFightReturnPreparationActionInfo = new GridFightReturnPreparationActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ReturnPreparationAction)
				{
					gridFightReturnPreparationActionInfo.MergeFrom(ReturnPreparationAction);
				}
				input.ReadMessage(gridFightReturnPreparationActionInfo);
				ReturnPreparationAction = gridFightReturnPreparationActionInfo;
				break;
			}
			case 1314u:
			{
				KIKMJKNHJGA kIKMJKNHJGA = new KIKMJKNHJGA();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJEJJKADBCI)
				{
					kIKMJKNHJGA.MergeFrom(DJEJJKADBCI);
				}
				input.ReadMessage(kIKMJKNHJGA);
				DJEJJKADBCI = kIKMJKNHJGA;
				break;
			}
			case 2274u:
			{
				NHJCELBCFNF nHJCELBCFNF = new NHJCELBCFNF();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.HPMNOGGMKKH)
				{
					nHJCELBCFNF.MergeFrom(HPMNOGGMKKH);
				}
				input.ReadMessage(nHJCELBCFNF);
				HPMNOGGMKKH = nHJCELBCFNF;
				break;
			}
			case 3858u:
			{
				GridFightAugmentActionInfo gridFightAugmentActionInfo = new GridFightAugmentActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.AugmentAction)
				{
					gridFightAugmentActionInfo.MergeFrom(AugmentAction);
				}
				input.ReadMessage(gridFightAugmentActionInfo);
				AugmentAction = gridFightAugmentActionInfo;
				break;
			}
			case 6978u:
			{
				GridFightRoundBeginActionInfo gridFightRoundBeginActionInfo = new GridFightRoundBeginActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RoundBeginAction)
				{
					gridFightRoundBeginActionInfo.MergeFrom(RoundBeginAction);
				}
				input.ReadMessage(gridFightRoundBeginActionInfo);
				RoundBeginAction = gridFightRoundBeginActionInfo;
				break;
			}
			case 7842u:
			{
				GridFightRecommendEquipmentActionInfo gridFightRecommendEquipmentActionInfo = new GridFightRecommendEquipmentActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.RecommendEquipmentAction)
				{
					gridFightRecommendEquipmentActionInfo.MergeFrom(RecommendEquipmentAction);
				}
				input.ReadMessage(gridFightRecommendEquipmentActionInfo);
				RecommendEquipmentAction = gridFightRecommendEquipmentActionInfo;
				break;
			}
			case 8506u:
			{
				GridFightUpgradeEquipActionInfo gridFightUpgradeEquipActionInfo = new GridFightUpgradeEquipActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.UpgradeEquipAction)
				{
					gridFightUpgradeEquipActionInfo.MergeFrom(UpgradeEquipAction);
				}
				input.ReadMessage(gridFightUpgradeEquipActionInfo);
				UpgradeEquipAction = gridFightUpgradeEquipActionInfo;
				break;
			}
			case 9210u:
			{
				GridFightForgeRoleActionInfo gridFightForgeRoleActionInfo = new GridFightForgeRoleActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ForgeRoleActionInfo)
				{
					gridFightForgeRoleActionInfo.MergeFrom(ForgeRoleActionInfo);
				}
				input.ReadMessage(gridFightForgeRoleActionInfo);
				ForgeRoleActionInfo = gridFightForgeRoleActionInfo;
				break;
			}
			case 9690u:
			{
				NJJFPLFEEFC nJJFPLFEEFC = new NJJFPLFEEFC();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.KACDGAJHNBI)
				{
					nJJFPLFEEFC.MergeFrom(KACDGAJHNBI);
				}
				input.ReadMessage(nJJFPLFEEFC);
				KACDGAJHNBI = nJJFPLFEEFC;
				break;
			}
			case 11570u:
			{
				HEPFIAFJAHL hEPFIAFJAHL = new HEPFIAFJAHL();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.APLEGHKNFOK)
				{
					hEPFIAFJAHL.MergeFrom(APLEGHKNFOK);
				}
				input.ReadMessage(hEPFIAFJAHL);
				APLEGHKNFOK = hEPFIAFJAHL;
				break;
			}
			case 12322u:
			{
				EEJAJMNKAMI eEJAJMNKAMI = new EEJAJMNKAMI();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PKCONHLNMIJ)
				{
					eEJAJMNKAMI.MergeFrom(PKCONHLNMIJ);
				}
				input.ReadMessage(eEJAJMNKAMI);
				PKCONHLNMIJ = eEJAJMNKAMI;
				break;
			}
			case 14402u:
			{
				GridFightTraitActionInfo gridFightTraitActionInfo = new GridFightTraitActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.TraitAction)
				{
					gridFightTraitActionInfo.MergeFrom(TraitAction);
				}
				input.ReadMessage(gridFightTraitActionInfo);
				TraitAction = gridFightTraitActionInfo;
				break;
			}
			case 14746u:
			{
				GridFightPortalBuffActionInfo gridFightPortalBuffActionInfo = new GridFightPortalBuffActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.PortalBuffAction)
				{
					gridFightPortalBuffActionInfo.MergeFrom(PortalBuffAction);
				}
				input.ReadMessage(gridFightPortalBuffActionInfo);
				PortalBuffAction = gridFightPortalBuffActionInfo;
				break;
			}
			case 15146u:
			{
				GridFightEliteBranchActionInfo gridFightEliteBranchActionInfo = new GridFightEliteBranchActionInfo();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.EliteBranchAction)
				{
					gridFightEliteBranchActionInfo.MergeFrom(EliteBranchAction);
				}
				input.ReadMessage(gridFightEliteBranchActionInfo);
				EliteBranchAction = gridFightEliteBranchActionInfo;
				break;
			}
			}
		}
	}
}
