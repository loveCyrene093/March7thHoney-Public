using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSeasonHandBookNotify : IMessage<GridFightSeasonHandBookNotify>, IMessage, IEquatable<GridFightSeasonHandBookNotify>, IDeepCloneable<GridFightSeasonHandBookNotify>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		HandbookGridFightMonsterInfo = 326,
		HandbookGridFightAugmentInfo = 900,
		HandbookGridFightRoleInfo = 944,
		HandbookGridFightEquipInfo = 1614,
		HandbookGridFightPortalInfo = 1914
	}

	private static readonly MessageParser<GridFightSeasonHandBookNotify> _parser = new MessageParser<GridFightSeasonHandBookNotify>(() => new GridFightSeasonHandBookNotify());

	private UnknownFieldSet _unknownFields;

	public const int HandbookGridFightMonsterInfoFieldNumber = 326;

	public const int HandbookGridFightAugmentInfoFieldNumber = 900;

	public const int HandbookGridFightRoleInfoFieldNumber = 944;

	public const int HandbookGridFightEquipInfoFieldNumber = 1614;

	public const int HandbookGridFightPortalInfoFieldNumber = 1914;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSeasonHandBookNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSeasonHandBookNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookMonsterInfo HandbookGridFightMonsterInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo)
			{
				return null;
			}
			return (GridFightHandBookMonsterInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookAugmentInfo HandbookGridFightAugmentInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo)
			{
				return null;
			}
			return (GridFightHandBookAugmentInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookRoleInfo HandbookGridFightRoleInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo)
			{
				return null;
			}
			return (GridFightHandBookRoleInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookEquipInfo HandbookGridFightEquipInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo)
			{
				return null;
			}
			return (GridFightHandBookEquipInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookPortalInfo HandbookGridFightPortalInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo)
			{
				return null;
			}
			return (GridFightHandBookPortalInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSeasonHandBookNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSeasonHandBookNotify(GridFightSeasonHandBookNotify other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo:
			HandbookGridFightMonsterInfo = other.HandbookGridFightMonsterInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo:
			HandbookGridFightAugmentInfo = other.HandbookGridFightAugmentInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo:
			HandbookGridFightRoleInfo = other.HandbookGridFightRoleInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo:
			HandbookGridFightEquipInfo = other.HandbookGridFightEquipInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo:
			HandbookGridFightPortalInfo = other.HandbookGridFightPortalInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSeasonHandBookNotify Clone()
	{
		return new GridFightSeasonHandBookNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSeasonHandBookNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSeasonHandBookNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HandbookGridFightMonsterInfo, other.HandbookGridFightMonsterInfo))
		{
			return false;
		}
		if (!object.Equals(HandbookGridFightAugmentInfo, other.HandbookGridFightAugmentInfo))
		{
			return false;
		}
		if (!object.Equals(HandbookGridFightRoleInfo, other.HandbookGridFightRoleInfo))
		{
			return false;
		}
		if (!object.Equals(HandbookGridFightEquipInfo, other.HandbookGridFightEquipInfo))
		{
			return false;
		}
		if (!object.Equals(HandbookGridFightPortalInfo, other.HandbookGridFightPortalInfo))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo)
		{
			num ^= HandbookGridFightMonsterInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo)
		{
			num ^= HandbookGridFightAugmentInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo)
		{
			num ^= HandbookGridFightRoleInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo)
		{
			num ^= HandbookGridFightEquipInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo)
		{
			num ^= HandbookGridFightPortalInfo.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo)
		{
			output.WriteRawTag(178, 20);
			output.WriteMessage(HandbookGridFightMonsterInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo)
		{
			output.WriteRawTag(162, 56);
			output.WriteMessage(HandbookGridFightAugmentInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo)
		{
			output.WriteRawTag(130, 59);
			output.WriteMessage(HandbookGridFightRoleInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo)
		{
			output.WriteRawTag(242, 100);
			output.WriteMessage(HandbookGridFightEquipInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo)
		{
			output.WriteRawTag(210, 119);
			output.WriteMessage(HandbookGridFightPortalInfo);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HandbookGridFightMonsterInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HandbookGridFightAugmentInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HandbookGridFightRoleInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HandbookGridFightEquipInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HandbookGridFightPortalInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSeasonHandBookNotify other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo:
			if (HandbookGridFightMonsterInfo == null)
			{
				HandbookGridFightMonsterInfo = new GridFightHandBookMonsterInfo();
			}
			HandbookGridFightMonsterInfo.MergeFrom(other.HandbookGridFightMonsterInfo);
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo:
			if (HandbookGridFightAugmentInfo == null)
			{
				HandbookGridFightAugmentInfo = new GridFightHandBookAugmentInfo();
			}
			HandbookGridFightAugmentInfo.MergeFrom(other.HandbookGridFightAugmentInfo);
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo:
			if (HandbookGridFightRoleInfo == null)
			{
				HandbookGridFightRoleInfo = new GridFightHandBookRoleInfo();
			}
			HandbookGridFightRoleInfo.MergeFrom(other.HandbookGridFightRoleInfo);
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo:
			if (HandbookGridFightEquipInfo == null)
			{
				HandbookGridFightEquipInfo = new GridFightHandBookEquipInfo();
			}
			HandbookGridFightEquipInfo.MergeFrom(other.HandbookGridFightEquipInfo);
			break;
		case BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo:
			if (HandbookGridFightPortalInfo == null)
			{
				HandbookGridFightPortalInfo = new GridFightHandBookPortalInfo();
			}
			HandbookGridFightPortalInfo.MergeFrom(other.HandbookGridFightPortalInfo);
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
			case 2610u:
			{
				GridFightHandBookMonsterInfo gridFightHandBookMonsterInfo = new GridFightHandBookMonsterInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightMonsterInfo)
				{
					gridFightHandBookMonsterInfo.MergeFrom(HandbookGridFightMonsterInfo);
				}
				input.ReadMessage(gridFightHandBookMonsterInfo);
				HandbookGridFightMonsterInfo = gridFightHandBookMonsterInfo;
				break;
			}
			case 7202u:
			{
				GridFightHandBookAugmentInfo gridFightHandBookAugmentInfo = new GridFightHandBookAugmentInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightAugmentInfo)
				{
					gridFightHandBookAugmentInfo.MergeFrom(HandbookGridFightAugmentInfo);
				}
				input.ReadMessage(gridFightHandBookAugmentInfo);
				HandbookGridFightAugmentInfo = gridFightHandBookAugmentInfo;
				break;
			}
			case 7554u:
			{
				GridFightHandBookRoleInfo gridFightHandBookRoleInfo = new GridFightHandBookRoleInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightRoleInfo)
				{
					gridFightHandBookRoleInfo.MergeFrom(HandbookGridFightRoleInfo);
				}
				input.ReadMessage(gridFightHandBookRoleInfo);
				HandbookGridFightRoleInfo = gridFightHandBookRoleInfo;
				break;
			}
			case 12914u:
			{
				GridFightHandBookEquipInfo gridFightHandBookEquipInfo = new GridFightHandBookEquipInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightEquipInfo)
				{
					gridFightHandBookEquipInfo.MergeFrom(HandbookGridFightEquipInfo);
				}
				input.ReadMessage(gridFightHandBookEquipInfo);
				HandbookGridFightEquipInfo = gridFightHandBookEquipInfo;
				break;
			}
			case 15314u:
			{
				GridFightHandBookPortalInfo gridFightHandBookPortalInfo = new GridFightHandBookPortalInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HandbookGridFightPortalInfo)
				{
					gridFightHandBookPortalInfo.MergeFrom(HandbookGridFightPortalInfo);
				}
				input.ReadMessage(gridFightHandBookPortalInfo);
				HandbookGridFightPortalInfo = gridFightHandBookPortalInfo;
				break;
			}
			}
		}
	}
}
