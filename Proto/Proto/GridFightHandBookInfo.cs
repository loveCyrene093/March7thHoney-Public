using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightHandBookInfo : IMessage<GridFightHandBookInfo>, IMessage, IEquatable<GridFightHandBookInfo>, IDeepCloneable<GridFightHandBookInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightHandBookInfo> _parser = new MessageParser<GridFightHandBookInfo>(() => new GridFightHandBookInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightMonsterInfoFieldNumber = 2;

	private GridFightHandBookMonsterInfo gridFightMonsterInfo_;

	public const int GridFightRoleInfoFieldNumber = 4;

	private GridFightHandBookRoleInfo gridFightRoleInfo_;

	public const int GridFightPortalInfoFieldNumber = 5;

	private GridFightHandBookPortalInfo gridFightPortalInfo_;

	public const int GridFightEquipInfoFieldNumber = 7;

	private GridFightHandBookEquipInfo gridFightEquipInfo_;

	public const int GridFightAugmentInfoFieldNumber = 9;

	private GridFightHandBookAugmentInfo gridFightAugmentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightHandBookInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightHandBookInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookMonsterInfo GridFightMonsterInfo
	{
		get
		{
			return gridFightMonsterInfo_;
		}
		set
		{
			gridFightMonsterInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookRoleInfo GridFightRoleInfo
	{
		get
		{
			return gridFightRoleInfo_;
		}
		set
		{
			gridFightRoleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookPortalInfo GridFightPortalInfo
	{
		get
		{
			return gridFightPortalInfo_;
		}
		set
		{
			gridFightPortalInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookEquipInfo GridFightEquipInfo
	{
		get
		{
			return gridFightEquipInfo_;
		}
		set
		{
			gridFightEquipInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookAugmentInfo GridFightAugmentInfo
	{
		get
		{
			return gridFightAugmentInfo_;
		}
		set
		{
			gridFightAugmentInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookInfo(GridFightHandBookInfo other)
		: this()
	{
		gridFightMonsterInfo_ = ((other.gridFightMonsterInfo_ != null) ? other.gridFightMonsterInfo_.Clone() : null);
		gridFightRoleInfo_ = ((other.gridFightRoleInfo_ != null) ? other.gridFightRoleInfo_.Clone() : null);
		gridFightPortalInfo_ = ((other.gridFightPortalInfo_ != null) ? other.gridFightPortalInfo_.Clone() : null);
		gridFightEquipInfo_ = ((other.gridFightEquipInfo_ != null) ? other.gridFightEquipInfo_.Clone() : null);
		gridFightAugmentInfo_ = ((other.gridFightAugmentInfo_ != null) ? other.gridFightAugmentInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookInfo Clone()
	{
		return new GridFightHandBookInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightHandBookInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightHandBookInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GridFightMonsterInfo, other.GridFightMonsterInfo))
		{
			return false;
		}
		if (!object.Equals(GridFightRoleInfo, other.GridFightRoleInfo))
		{
			return false;
		}
		if (!object.Equals(GridFightPortalInfo, other.GridFightPortalInfo))
		{
			return false;
		}
		if (!object.Equals(GridFightEquipInfo, other.GridFightEquipInfo))
		{
			return false;
		}
		if (!object.Equals(GridFightAugmentInfo, other.GridFightAugmentInfo))
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
		if (gridFightMonsterInfo_ != null)
		{
			num ^= GridFightMonsterInfo.GetHashCode();
		}
		if (gridFightRoleInfo_ != null)
		{
			num ^= GridFightRoleInfo.GetHashCode();
		}
		if (gridFightPortalInfo_ != null)
		{
			num ^= GridFightPortalInfo.GetHashCode();
		}
		if (gridFightEquipInfo_ != null)
		{
			num ^= GridFightEquipInfo.GetHashCode();
		}
		if (gridFightAugmentInfo_ != null)
		{
			num ^= GridFightAugmentInfo.GetHashCode();
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
		if (gridFightMonsterInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(GridFightMonsterInfo);
		}
		if (gridFightRoleInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(GridFightRoleInfo);
		}
		if (gridFightPortalInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GridFightPortalInfo);
		}
		if (gridFightEquipInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(GridFightEquipInfo);
		}
		if (gridFightAugmentInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GridFightAugmentInfo);
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
		if (gridFightMonsterInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightMonsterInfo);
		}
		if (gridFightRoleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightRoleInfo);
		}
		if (gridFightPortalInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightPortalInfo);
		}
		if (gridFightEquipInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightEquipInfo);
		}
		if (gridFightAugmentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightAugmentInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightHandBookInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gridFightMonsterInfo_ != null)
		{
			if (gridFightMonsterInfo_ == null)
			{
				GridFightMonsterInfo = new GridFightHandBookMonsterInfo();
			}
			GridFightMonsterInfo.MergeFrom(other.GridFightMonsterInfo);
		}
		if (other.gridFightRoleInfo_ != null)
		{
			if (gridFightRoleInfo_ == null)
			{
				GridFightRoleInfo = new GridFightHandBookRoleInfo();
			}
			GridFightRoleInfo.MergeFrom(other.GridFightRoleInfo);
		}
		if (other.gridFightPortalInfo_ != null)
		{
			if (gridFightPortalInfo_ == null)
			{
				GridFightPortalInfo = new GridFightHandBookPortalInfo();
			}
			GridFightPortalInfo.MergeFrom(other.GridFightPortalInfo);
		}
		if (other.gridFightEquipInfo_ != null)
		{
			if (gridFightEquipInfo_ == null)
			{
				GridFightEquipInfo = new GridFightHandBookEquipInfo();
			}
			GridFightEquipInfo.MergeFrom(other.GridFightEquipInfo);
		}
		if (other.gridFightAugmentInfo_ != null)
		{
			if (gridFightAugmentInfo_ == null)
			{
				GridFightAugmentInfo = new GridFightHandBookAugmentInfo();
			}
			GridFightAugmentInfo.MergeFrom(other.GridFightAugmentInfo);
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
			case 18u:
				if (gridFightMonsterInfo_ == null)
				{
					GridFightMonsterInfo = new GridFightHandBookMonsterInfo();
				}
				input.ReadMessage(GridFightMonsterInfo);
				break;
			case 34u:
				if (gridFightRoleInfo_ == null)
				{
					GridFightRoleInfo = new GridFightHandBookRoleInfo();
				}
				input.ReadMessage(GridFightRoleInfo);
				break;
			case 42u:
				if (gridFightPortalInfo_ == null)
				{
					GridFightPortalInfo = new GridFightHandBookPortalInfo();
				}
				input.ReadMessage(GridFightPortalInfo);
				break;
			case 58u:
				if (gridFightEquipInfo_ == null)
				{
					GridFightEquipInfo = new GridFightHandBookEquipInfo();
				}
				input.ReadMessage(GridFightEquipInfo);
				break;
			case 74u:
				if (gridFightAugmentInfo_ == null)
				{
					GridFightAugmentInfo = new GridFightHandBookAugmentInfo();
				}
				input.ReadMessage(GridFightAugmentInfo);
				break;
			}
		}
	}
}
