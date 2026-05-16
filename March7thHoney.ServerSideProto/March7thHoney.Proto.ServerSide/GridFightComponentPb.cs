using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightComponentPb : IMessage<GridFightComponentPb>, IMessage, IEquatable<GridFightComponentPb>, IDeepCloneable<GridFightComponentPb>, IBufferMessage
{
	public enum ComponentTypeOneofCase
	{
		None,
		ShopInfo,
		BasicInfo,
		TeamInfo,
		OrbInfo,
		AugmentInfo,
		TraitInfo,
		ItemsInfo
	}

	private static readonly MessageParser<GridFightComponentPb> _parser = new MessageParser<GridFightComponentPb>(() => new GridFightComponentPb());

	private UnknownFieldSet _unknownFields;

	public const int ShopInfoFieldNumber = 1;

	public const int BasicInfoFieldNumber = 2;

	public const int TeamInfoFieldNumber = 3;

	public const int OrbInfoFieldNumber = 4;

	public const int AugmentInfoFieldNumber = 5;

	public const int TraitInfoFieldNumber = 6;

	public const int ItemsInfoFieldNumber = 7;

	private object componentType_;

	private ComponentTypeOneofCase componentTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightComponentPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[22];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopInfoPb ShopInfo
	{
		get
		{
			if (componentTypeCase_ != ComponentTypeOneofCase.ShopInfo)
			{
				return null;
			}
			return (GridFightShopInfoPb)componentType_;
		}
		set
		{
			componentType_ = value;
			componentTypeCase_ = ((value != null) ? ComponentTypeOneofCase.ShopInfo : ComponentTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBasicInfoPb BasicInfo
	{
		get
		{
			if (componentTypeCase_ != ComponentTypeOneofCase.BasicInfo)
			{
				return null;
			}
			return (GridFightBasicInfoPb)componentType_;
		}
		set
		{
			componentType_ = value;
			componentTypeCase_ = ((value != null) ? ComponentTypeOneofCase.BasicInfo : ComponentTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTeamInfoPb TeamInfo
	{
		get
		{
			if (componentTypeCase_ != ComponentTypeOneofCase.TeamInfo)
			{
				return null;
			}
			return (GridFightTeamInfoPb)componentType_;
		}
		set
		{
			componentType_ = value;
			componentTypeCase_ = ((value != null) ? ComponentTypeOneofCase.TeamInfo : ComponentTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightOrbInfoPb OrbInfo
	{
		get
		{
			if (componentTypeCase_ != ComponentTypeOneofCase.OrbInfo)
			{
				return null;
			}
			return (GridFightOrbInfoPb)componentType_;
		}
		set
		{
			componentType_ = value;
			componentTypeCase_ = ((value != null) ? ComponentTypeOneofCase.OrbInfo : ComponentTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightAugmentInfoPb AugmentInfo
	{
		get
		{
			if (componentTypeCase_ != ComponentTypeOneofCase.AugmentInfo)
			{
				return null;
			}
			return (GridFightAugmentInfoPb)componentType_;
		}
		set
		{
			componentType_ = value;
			componentTypeCase_ = ((value != null) ? ComponentTypeOneofCase.AugmentInfo : ComponentTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitInfoPb TraitInfo
	{
		get
		{
			if (componentTypeCase_ != ComponentTypeOneofCase.TraitInfo)
			{
				return null;
			}
			return (GridFightTraitInfoPb)componentType_;
		}
		set
		{
			componentType_ = value;
			componentTypeCase_ = ((value != null) ? ComponentTypeOneofCase.TraitInfo : ComponentTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightItemsInfoPb ItemsInfo
	{
		get
		{
			if (componentTypeCase_ != ComponentTypeOneofCase.ItemsInfo)
			{
				return null;
			}
			return (GridFightItemsInfoPb)componentType_;
		}
		set
		{
			componentType_ = value;
			componentTypeCase_ = ((value != null) ? ComponentTypeOneofCase.ItemsInfo : ComponentTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComponentTypeOneofCase ComponentTypeCase => componentTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightComponentPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightComponentPb(GridFightComponentPb other)
		: this()
	{
		switch (other.ComponentTypeCase)
		{
		case ComponentTypeOneofCase.ShopInfo:
			ShopInfo = other.ShopInfo.Clone();
			break;
		case ComponentTypeOneofCase.BasicInfo:
			BasicInfo = other.BasicInfo.Clone();
			break;
		case ComponentTypeOneofCase.TeamInfo:
			TeamInfo = other.TeamInfo.Clone();
			break;
		case ComponentTypeOneofCase.OrbInfo:
			OrbInfo = other.OrbInfo.Clone();
			break;
		case ComponentTypeOneofCase.AugmentInfo:
			AugmentInfo = other.AugmentInfo.Clone();
			break;
		case ComponentTypeOneofCase.TraitInfo:
			TraitInfo = other.TraitInfo.Clone();
			break;
		case ComponentTypeOneofCase.ItemsInfo:
			ItemsInfo = other.ItemsInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightComponentPb Clone()
	{
		return new GridFightComponentPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComponentType()
	{
		componentTypeCase_ = ComponentTypeOneofCase.None;
		componentType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightComponentPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightComponentPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ShopInfo, other.ShopInfo))
		{
			return false;
		}
		if (!object.Equals(BasicInfo, other.BasicInfo))
		{
			return false;
		}
		if (!object.Equals(TeamInfo, other.TeamInfo))
		{
			return false;
		}
		if (!object.Equals(OrbInfo, other.OrbInfo))
		{
			return false;
		}
		if (!object.Equals(AugmentInfo, other.AugmentInfo))
		{
			return false;
		}
		if (!object.Equals(TraitInfo, other.TraitInfo))
		{
			return false;
		}
		if (!object.Equals(ItemsInfo, other.ItemsInfo))
		{
			return false;
		}
		if (ComponentTypeCase != other.ComponentTypeCase)
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
		if (componentTypeCase_ == ComponentTypeOneofCase.ShopInfo)
		{
			num ^= ShopInfo.GetHashCode();
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.BasicInfo)
		{
			num ^= BasicInfo.GetHashCode();
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.TeamInfo)
		{
			num ^= TeamInfo.GetHashCode();
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.OrbInfo)
		{
			num ^= OrbInfo.GetHashCode();
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.AugmentInfo)
		{
			num ^= AugmentInfo.GetHashCode();
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.TraitInfo)
		{
			num ^= TraitInfo.GetHashCode();
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.ItemsInfo)
		{
			num ^= ItemsInfo.GetHashCode();
		}
		num ^= (int)componentTypeCase_;
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
		if (componentTypeCase_ == ComponentTypeOneofCase.ShopInfo)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ShopInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.BasicInfo)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BasicInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.TeamInfo)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TeamInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.OrbInfo)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OrbInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.AugmentInfo)
		{
			output.WriteRawTag(42);
			output.WriteMessage(AugmentInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.TraitInfo)
		{
			output.WriteRawTag(50);
			output.WriteMessage(TraitInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.ItemsInfo)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ItemsInfo);
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
		if (componentTypeCase_ == ComponentTypeOneofCase.ShopInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShopInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.BasicInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.TeamInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TeamInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.OrbInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OrbInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.AugmentInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AugmentInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.TraitInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TraitInfo);
		}
		if (componentTypeCase_ == ComponentTypeOneofCase.ItemsInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemsInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightComponentPb other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.ComponentTypeCase)
		{
		case ComponentTypeOneofCase.ShopInfo:
			if (ShopInfo == null)
			{
				ShopInfo = new GridFightShopInfoPb();
			}
			ShopInfo.MergeFrom(other.ShopInfo);
			break;
		case ComponentTypeOneofCase.BasicInfo:
			if (BasicInfo == null)
			{
				BasicInfo = new GridFightBasicInfoPb();
			}
			BasicInfo.MergeFrom(other.BasicInfo);
			break;
		case ComponentTypeOneofCase.TeamInfo:
			if (TeamInfo == null)
			{
				TeamInfo = new GridFightTeamInfoPb();
			}
			TeamInfo.MergeFrom(other.TeamInfo);
			break;
		case ComponentTypeOneofCase.OrbInfo:
			if (OrbInfo == null)
			{
				OrbInfo = new GridFightOrbInfoPb();
			}
			OrbInfo.MergeFrom(other.OrbInfo);
			break;
		case ComponentTypeOneofCase.AugmentInfo:
			if (AugmentInfo == null)
			{
				AugmentInfo = new GridFightAugmentInfoPb();
			}
			AugmentInfo.MergeFrom(other.AugmentInfo);
			break;
		case ComponentTypeOneofCase.TraitInfo:
			if (TraitInfo == null)
			{
				TraitInfo = new GridFightTraitInfoPb();
			}
			TraitInfo.MergeFrom(other.TraitInfo);
			break;
		case ComponentTypeOneofCase.ItemsInfo:
			if (ItemsInfo == null)
			{
				ItemsInfo = new GridFightItemsInfoPb();
			}
			ItemsInfo.MergeFrom(other.ItemsInfo);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
			{
				GridFightShopInfoPb gridFightShopInfoPb = new GridFightShopInfoPb();
				if (componentTypeCase_ == ComponentTypeOneofCase.ShopInfo)
				{
					gridFightShopInfoPb.MergeFrom(ShopInfo);
				}
				input.ReadMessage(gridFightShopInfoPb);
				ShopInfo = gridFightShopInfoPb;
				break;
			}
			case 18u:
			{
				GridFightBasicInfoPb gridFightBasicInfoPb = new GridFightBasicInfoPb();
				if (componentTypeCase_ == ComponentTypeOneofCase.BasicInfo)
				{
					gridFightBasicInfoPb.MergeFrom(BasicInfo);
				}
				input.ReadMessage(gridFightBasicInfoPb);
				BasicInfo = gridFightBasicInfoPb;
				break;
			}
			case 26u:
			{
				GridFightTeamInfoPb gridFightTeamInfoPb = new GridFightTeamInfoPb();
				if (componentTypeCase_ == ComponentTypeOneofCase.TeamInfo)
				{
					gridFightTeamInfoPb.MergeFrom(TeamInfo);
				}
				input.ReadMessage(gridFightTeamInfoPb);
				TeamInfo = gridFightTeamInfoPb;
				break;
			}
			case 34u:
			{
				GridFightOrbInfoPb gridFightOrbInfoPb = new GridFightOrbInfoPb();
				if (componentTypeCase_ == ComponentTypeOneofCase.OrbInfo)
				{
					gridFightOrbInfoPb.MergeFrom(OrbInfo);
				}
				input.ReadMessage(gridFightOrbInfoPb);
				OrbInfo = gridFightOrbInfoPb;
				break;
			}
			case 42u:
			{
				GridFightAugmentInfoPb gridFightAugmentInfoPb = new GridFightAugmentInfoPb();
				if (componentTypeCase_ == ComponentTypeOneofCase.AugmentInfo)
				{
					gridFightAugmentInfoPb.MergeFrom(AugmentInfo);
				}
				input.ReadMessage(gridFightAugmentInfoPb);
				AugmentInfo = gridFightAugmentInfoPb;
				break;
			}
			case 50u:
			{
				GridFightTraitInfoPb gridFightTraitInfoPb = new GridFightTraitInfoPb();
				if (componentTypeCase_ == ComponentTypeOneofCase.TraitInfo)
				{
					gridFightTraitInfoPb.MergeFrom(TraitInfo);
				}
				input.ReadMessage(gridFightTraitInfoPb);
				TraitInfo = gridFightTraitInfoPb;
				break;
			}
			case 58u:
			{
				GridFightItemsInfoPb gridFightItemsInfoPb = new GridFightItemsInfoPb();
				if (componentTypeCase_ == ComponentTypeOneofCase.ItemsInfo)
				{
					gridFightItemsInfoPb.MergeFrom(ItemsInfo);
				}
				input.ReadMessage(gridFightItemsInfoPb);
				ItemsInfo = gridFightItemsInfoPb;
				break;
			}
			}
		}
	}
}
