using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetBigDataRecommendScRsp : IMessage<GetBigDataRecommendScRsp>, IMessage, IEquatable<GetBigDataRecommendScRsp>, IDeepCloneable<GetBigDataRecommendScRsp>, IBufferMessage
{
	public enum RecommendTypeOneofCase
	{
		None = 0,
		RelicRecommend = 2,
		EquipmentRecommend = 12,
		GIJOGKBMDIP = 14
	}

	private static readonly MessageParser<GetBigDataRecommendScRsp> _parser = new MessageParser<GetBigDataRecommendScRsp>(() => new GetBigDataRecommendScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EquipAvatarFieldNumber = 4;

	private uint equipAvatar_;

	public const int HasRecommandFieldNumber = 6;

	private bool hasRecommand_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int BigDataRecommendTypeFieldNumber = 15;

	private BigDataRecommendType bigDataRecommendType_;

	public const int RelicRecommendFieldNumber = 2;

	public const int EquipmentRecommendFieldNumber = 12;

	public const int GIJOGKBMDIPFieldNumber = 14;

	private object recommendType_;

	private RecommendTypeOneofCase recommendTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetBigDataRecommendScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetBigDataRecommendScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EquipAvatar
	{
		get
		{
			return equipAvatar_;
		}
		set
		{
			equipAvatar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRecommand
	{
		get
		{
			return hasRecommand_;
		}
		set
		{
			hasRecommand_ = value;
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
	public BigDataRecommendType BigDataRecommendType
	{
		get
		{
			return bigDataRecommendType_;
		}
		set
		{
			bigDataRecommendType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicRecommend RelicRecommend
	{
		get
		{
			if (recommendTypeCase_ != RecommendTypeOneofCase.RelicRecommend)
			{
				return null;
			}
			return (RelicRecommend)recommendType_;
		}
		set
		{
			recommendType_ = value;
			recommendTypeCase_ = ((value != null) ? RecommendTypeOneofCase.RelicRecommend : RecommendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentRecommend EquipmentRecommend
	{
		get
		{
			if (recommendTypeCase_ != RecommendTypeOneofCase.EquipmentRecommend)
			{
				return null;
			}
			return (EquipmentRecommend)recommendType_;
		}
		set
		{
			recommendType_ = value;
			recommendTypeCase_ = ((value != null) ? RecommendTypeOneofCase.EquipmentRecommend : RecommendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBJDMKPDCNK GIJOGKBMDIP
	{
		get
		{
			if (recommendTypeCase_ != RecommendTypeOneofCase.GIJOGKBMDIP)
			{
				return null;
			}
			return (EBJDMKPDCNK)recommendType_;
		}
		set
		{
			recommendType_ = value;
			recommendTypeCase_ = ((value != null) ? RecommendTypeOneofCase.GIJOGKBMDIP : RecommendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecommendTypeOneofCase RecommendTypeCase => recommendTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataRecommendScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataRecommendScRsp(GetBigDataRecommendScRsp other)
		: this()
	{
		equipAvatar_ = other.equipAvatar_;
		hasRecommand_ = other.hasRecommand_;
		retcode_ = other.retcode_;
		bigDataRecommendType_ = other.bigDataRecommendType_;
		switch (other.RecommendTypeCase)
		{
		case RecommendTypeOneofCase.RelicRecommend:
			RelicRecommend = other.RelicRecommend.Clone();
			break;
		case RecommendTypeOneofCase.EquipmentRecommend:
			EquipmentRecommend = other.EquipmentRecommend.Clone();
			break;
		case RecommendTypeOneofCase.GIJOGKBMDIP:
			GIJOGKBMDIP = other.GIJOGKBMDIP.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataRecommendScRsp Clone()
	{
		return new GetBigDataRecommendScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRecommendType()
	{
		recommendTypeCase_ = RecommendTypeOneofCase.None;
		recommendType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetBigDataRecommendScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetBigDataRecommendScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EquipAvatar != other.EquipAvatar)
		{
			return false;
		}
		if (HasRecommand != other.HasRecommand)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (BigDataRecommendType != other.BigDataRecommendType)
		{
			return false;
		}
		if (!object.Equals(RelicRecommend, other.RelicRecommend))
		{
			return false;
		}
		if (!object.Equals(EquipmentRecommend, other.EquipmentRecommend))
		{
			return false;
		}
		if (!object.Equals(GIJOGKBMDIP, other.GIJOGKBMDIP))
		{
			return false;
		}
		if (RecommendTypeCase != other.RecommendTypeCase)
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
		if (EquipAvatar != 0)
		{
			num ^= EquipAvatar.GetHashCode();
		}
		if (HasRecommand)
		{
			num ^= HasRecommand.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			num ^= BigDataRecommendType.GetHashCode();
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.RelicRecommend)
		{
			num ^= RelicRecommend.GetHashCode();
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.EquipmentRecommend)
		{
			num ^= EquipmentRecommend.GetHashCode();
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
		{
			num ^= GIJOGKBMDIP.GetHashCode();
		}
		num ^= (int)recommendTypeCase_;
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
		if (recommendTypeCase_ == RecommendTypeOneofCase.RelicRecommend)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RelicRecommend);
		}
		if (EquipAvatar != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EquipAvatar);
		}
		if (HasRecommand)
		{
			output.WriteRawTag(48);
			output.WriteBool(HasRecommand);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.EquipmentRecommend)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EquipmentRecommend);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
		{
			output.WriteRawTag(114);
			output.WriteMessage(GIJOGKBMDIP);
		}
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)BigDataRecommendType);
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
		if (EquipAvatar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EquipAvatar);
		}
		if (HasRecommand)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BigDataRecommendType);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.RelicRecommend)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RelicRecommend);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.EquipmentRecommend)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipmentRecommend);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GIJOGKBMDIP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetBigDataRecommendScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EquipAvatar != 0)
		{
			EquipAvatar = other.EquipAvatar;
		}
		if (other.HasRecommand)
		{
			HasRecommand = other.HasRecommand;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.BigDataRecommendType != BigDataRecommendType.None)
		{
			BigDataRecommendType = other.BigDataRecommendType;
		}
		switch (other.RecommendTypeCase)
		{
		case RecommendTypeOneofCase.RelicRecommend:
			if (RelicRecommend == null)
			{
				RelicRecommend = new RelicRecommend();
			}
			RelicRecommend.MergeFrom(other.RelicRecommend);
			break;
		case RecommendTypeOneofCase.EquipmentRecommend:
			if (EquipmentRecommend == null)
			{
				EquipmentRecommend = new EquipmentRecommend();
			}
			EquipmentRecommend.MergeFrom(other.EquipmentRecommend);
			break;
		case RecommendTypeOneofCase.GIJOGKBMDIP:
			if (GIJOGKBMDIP == null)
			{
				GIJOGKBMDIP = new EBJDMKPDCNK();
			}
			GIJOGKBMDIP.MergeFrom(other.GIJOGKBMDIP);
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
			case 18u:
			{
				RelicRecommend relicRecommend = new RelicRecommend();
				if (recommendTypeCase_ == RecommendTypeOneofCase.RelicRecommend)
				{
					relicRecommend.MergeFrom(RelicRecommend);
				}
				input.ReadMessage(relicRecommend);
				RelicRecommend = relicRecommend;
				break;
			}
			case 32u:
				EquipAvatar = input.ReadUInt32();
				break;
			case 48u:
				HasRecommand = input.ReadBool();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
			{
				EquipmentRecommend equipmentRecommend = new EquipmentRecommend();
				if (recommendTypeCase_ == RecommendTypeOneofCase.EquipmentRecommend)
				{
					equipmentRecommend.MergeFrom(EquipmentRecommend);
				}
				input.ReadMessage(equipmentRecommend);
				EquipmentRecommend = equipmentRecommend;
				break;
			}
			case 114u:
			{
				EBJDMKPDCNK eBJDMKPDCNK = new EBJDMKPDCNK();
				if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
				{
					eBJDMKPDCNK.MergeFrom(GIJOGKBMDIP);
				}
				input.ReadMessage(eBJDMKPDCNK);
				GIJOGKBMDIP = eBJDMKPDCNK;
				break;
			}
			case 120u:
				BigDataRecommendType = (BigDataRecommendType)input.ReadEnum();
				break;
			}
		}
	}
}
