using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightConsumableTargetInfo : IMessage<GridFightConsumableTargetInfo>, IMessage, IEquatable<GridFightConsumableTargetInfo>, IDeepCloneable<GridFightConsumableTargetInfo>, IBufferMessage
{
	public enum HDACCIEIJFOOneofCase
	{
		None = 0,
		UpgradeTypeTargetInfo = 186,
		CopyTypeTargetInfo = 391,
		GainRecommendEquipTypeTargetInfo = 654,
		RemoveTypeTargetInfo = 1308,
		RollTypeTargetInfo = 1501
	}

	private static readonly MessageParser<GridFightConsumableTargetInfo> _parser = new MessageParser<GridFightConsumableTargetInfo>(() => new GridFightConsumableTargetInfo());

	private UnknownFieldSet _unknownFields;

	public const int UpgradeTypeTargetInfoFieldNumber = 186;

	public const int CopyTypeTargetInfoFieldNumber = 391;

	public const int GainRecommendEquipTypeTargetInfoFieldNumber = 654;

	public const int RemoveTypeTargetInfoFieldNumber = 1308;

	public const int RollTypeTargetInfoFieldNumber = 1501;

	private object hDACCIEIJFO_;

	private HDACCIEIJFOOneofCase hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightConsumableTargetInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightConsumableTargetInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpgradeTypeTargetInfo UpgradeTypeTargetInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo)
			{
				return null;
			}
			return (GridFightUpgradeTypeTargetInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightCopyTypeTargetInfo CopyTypeTargetInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.CopyTypeTargetInfo)
			{
				return null;
			}
			return (GridFightCopyTypeTargetInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.CopyTypeTargetInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGainRecommendEquipTypeTargetInfo GainRecommendEquipTypeTargetInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo)
			{
				return null;
			}
			return (GridFightGainRecommendEquipTypeTargetInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRemoveTypeTargetInfo RemoveTypeTargetInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.RemoveTypeTargetInfo)
			{
				return null;
			}
			return (GridFightRemoveTypeTargetInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.RemoveTypeTargetInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRollTypeTargetInfo RollTypeTargetInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.RollTypeTargetInfo)
			{
				return null;
			}
			return (GridFightRollTypeTargetInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.RollTypeTargetInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDACCIEIJFOOneofCase HDACCIEIJFOCase => hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightConsumableTargetInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightConsumableTargetInfo(GridFightConsumableTargetInfo other)
		: this()
	{
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo:
			UpgradeTypeTargetInfo = other.UpgradeTypeTargetInfo.Clone();
			break;
		case HDACCIEIJFOOneofCase.CopyTypeTargetInfo:
			CopyTypeTargetInfo = other.CopyTypeTargetInfo.Clone();
			break;
		case HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo:
			GainRecommendEquipTypeTargetInfo = other.GainRecommendEquipTypeTargetInfo.Clone();
			break;
		case HDACCIEIJFOOneofCase.RemoveTypeTargetInfo:
			RemoveTypeTargetInfo = other.RemoveTypeTargetInfo.Clone();
			break;
		case HDACCIEIJFOOneofCase.RollTypeTargetInfo:
			RollTypeTargetInfo = other.RollTypeTargetInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightConsumableTargetInfo Clone()
	{
		return new GridFightConsumableTargetInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHDACCIEIJFO()
	{
		hDACCIEIJFOCase_ = HDACCIEIJFOOneofCase.None;
		hDACCIEIJFO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightConsumableTargetInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightConsumableTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(UpgradeTypeTargetInfo, other.UpgradeTypeTargetInfo))
		{
			return false;
		}
		if (!object.Equals(CopyTypeTargetInfo, other.CopyTypeTargetInfo))
		{
			return false;
		}
		if (!object.Equals(GainRecommendEquipTypeTargetInfo, other.GainRecommendEquipTypeTargetInfo))
		{
			return false;
		}
		if (!object.Equals(RemoveTypeTargetInfo, other.RemoveTypeTargetInfo))
		{
			return false;
		}
		if (!object.Equals(RollTypeTargetInfo, other.RollTypeTargetInfo))
		{
			return false;
		}
		if (HDACCIEIJFOCase != other.HDACCIEIJFOCase)
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo)
		{
			num ^= UpgradeTypeTargetInfo.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.CopyTypeTargetInfo)
		{
			num ^= CopyTypeTargetInfo.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo)
		{
			num ^= GainRecommendEquipTypeTargetInfo.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RemoveTypeTargetInfo)
		{
			num ^= RemoveTypeTargetInfo.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RollTypeTargetInfo)
		{
			num ^= RollTypeTargetInfo.GetHashCode();
		}
		num ^= (int)hDACCIEIJFOCase_;
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo)
		{
			output.WriteRawTag(210, 11);
			output.WriteMessage(UpgradeTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.CopyTypeTargetInfo)
		{
			output.WriteRawTag(186, 24);
			output.WriteMessage(CopyTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo)
		{
			output.WriteRawTag(242, 40);
			output.WriteMessage(GainRecommendEquipTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RemoveTypeTargetInfo)
		{
			output.WriteRawTag(226, 81);
			output.WriteMessage(RemoveTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RollTypeTargetInfo)
		{
			output.WriteRawTag(234, 93);
			output.WriteMessage(RollTypeTargetInfo);
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(UpgradeTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.CopyTypeTargetInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CopyTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GainRecommendEquipTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RemoveTypeTargetInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RemoveTypeTargetInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RollTypeTargetInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RollTypeTargetInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightConsumableTargetInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo:
			if (UpgradeTypeTargetInfo == null)
			{
				UpgradeTypeTargetInfo = new GridFightUpgradeTypeTargetInfo();
			}
			UpgradeTypeTargetInfo.MergeFrom(other.UpgradeTypeTargetInfo);
			break;
		case HDACCIEIJFOOneofCase.CopyTypeTargetInfo:
			if (CopyTypeTargetInfo == null)
			{
				CopyTypeTargetInfo = new GridFightCopyTypeTargetInfo();
			}
			CopyTypeTargetInfo.MergeFrom(other.CopyTypeTargetInfo);
			break;
		case HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo:
			if (GainRecommendEquipTypeTargetInfo == null)
			{
				GainRecommendEquipTypeTargetInfo = new GridFightGainRecommendEquipTypeTargetInfo();
			}
			GainRecommendEquipTypeTargetInfo.MergeFrom(other.GainRecommendEquipTypeTargetInfo);
			break;
		case HDACCIEIJFOOneofCase.RemoveTypeTargetInfo:
			if (RemoveTypeTargetInfo == null)
			{
				RemoveTypeTargetInfo = new GridFightRemoveTypeTargetInfo();
			}
			RemoveTypeTargetInfo.MergeFrom(other.RemoveTypeTargetInfo);
			break;
		case HDACCIEIJFOOneofCase.RollTypeTargetInfo:
			if (RollTypeTargetInfo == null)
			{
				RollTypeTargetInfo = new GridFightRollTypeTargetInfo();
			}
			RollTypeTargetInfo.MergeFrom(other.RollTypeTargetInfo);
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
			case 1490u:
			{
				GridFightUpgradeTypeTargetInfo gridFightUpgradeTypeTargetInfo = new GridFightUpgradeTypeTargetInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.UpgradeTypeTargetInfo)
				{
					gridFightUpgradeTypeTargetInfo.MergeFrom(UpgradeTypeTargetInfo);
				}
				input.ReadMessage(gridFightUpgradeTypeTargetInfo);
				UpgradeTypeTargetInfo = gridFightUpgradeTypeTargetInfo;
				break;
			}
			case 3130u:
			{
				GridFightCopyTypeTargetInfo gridFightCopyTypeTargetInfo = new GridFightCopyTypeTargetInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.CopyTypeTargetInfo)
				{
					gridFightCopyTypeTargetInfo.MergeFrom(CopyTypeTargetInfo);
				}
				input.ReadMessage(gridFightCopyTypeTargetInfo);
				CopyTypeTargetInfo = gridFightCopyTypeTargetInfo;
				break;
			}
			case 5234u:
			{
				GridFightGainRecommendEquipTypeTargetInfo gridFightGainRecommendEquipTypeTargetInfo = new GridFightGainRecommendEquipTypeTargetInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.GainRecommendEquipTypeTargetInfo)
				{
					gridFightGainRecommendEquipTypeTargetInfo.MergeFrom(GainRecommendEquipTypeTargetInfo);
				}
				input.ReadMessage(gridFightGainRecommendEquipTypeTargetInfo);
				GainRecommendEquipTypeTargetInfo = gridFightGainRecommendEquipTypeTargetInfo;
				break;
			}
			case 10466u:
			{
				GridFightRemoveTypeTargetInfo gridFightRemoveTypeTargetInfo = new GridFightRemoveTypeTargetInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RemoveTypeTargetInfo)
				{
					gridFightRemoveTypeTargetInfo.MergeFrom(RemoveTypeTargetInfo);
				}
				input.ReadMessage(gridFightRemoveTypeTargetInfo);
				RemoveTypeTargetInfo = gridFightRemoveTypeTargetInfo;
				break;
			}
			case 12010u:
			{
				GridFightRollTypeTargetInfo gridFightRollTypeTargetInfo = new GridFightRollTypeTargetInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.RollTypeTargetInfo)
				{
					gridFightRollTypeTargetInfo.MergeFrom(RollTypeTargetInfo);
				}
				input.ReadMessage(gridFightRollTypeTargetInfo);
				RollTypeTargetInfo = gridFightRollTypeTargetInfo;
				break;
			}
			}
		}
	}
}
