using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BDDBAKBOMKP : IMessage<BDDBAKBOMKP>, IMessage, IEquatable<BDDBAKBOMKP>, IDeepCloneable<BDDBAKBOMKP>, IBufferMessage
{
	private static readonly MessageParser<BDDBAKBOMKP> _parser = new MessageParser<BDDBAKBOMKP>(() => new BDDBAKBOMKP());

	private UnknownFieldSet _unknownFields;

	public const int MaxHpFieldNumber = 1;

	private int maxHp_;

	public const int StatusFieldNumber = 2;

	private FateMasterStatusType status_;

	public const int AvatarIdFieldNumber = 4;

	private uint avatarId_;

	public const int IAKFPMOEJLFFieldNumber = 5;

	private static readonly FieldCodec<FNONPMBOFNE> _repeated_iAKFPMOEJLF_codec = FieldCodec.ForMessage(42u, FNONPMBOFNE.Parser);

	private readonly RepeatedField<FNONPMBOFNE> iAKFPMOEJLF_ = new RepeatedField<FNONPMBOFNE>();

	public const int HpFieldNumber = 9;

	private int hp_;

	public const int RankFieldNumber = 11;

	private uint rank_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BDDBAKBOMKP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BDDBAKBOMKPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateMasterStatusType Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FNONPMBOFNE> IAKFPMOEJLF => iAKFPMOEJLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDDBAKBOMKP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDDBAKBOMKP(BDDBAKBOMKP other)
		: this()
	{
		maxHp_ = other.maxHp_;
		status_ = other.status_;
		avatarId_ = other.avatarId_;
		iAKFPMOEJLF_ = other.iAKFPMOEJLF_.Clone();
		hp_ = other.hp_;
		rank_ = other.rank_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDDBAKBOMKP Clone()
	{
		return new BDDBAKBOMKP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BDDBAKBOMKP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BDDBAKBOMKP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MaxHp != other.MaxHp)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!iAKFPMOEJLF_.Equals(other.iAKFPMOEJLF_))
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (Rank != other.Rank)
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
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
		}
		if (Status != FateMasterStatusType.KghocaphldgPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= iAKFPMOEJLF_.GetHashCode();
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
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
		if (MaxHp != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MaxHp);
		}
		if (Status != FateMasterStatusType.KghocaphldgPcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Status);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AvatarId);
		}
		iAKFPMOEJLF_.WriteTo(ref output, _repeated_iAKFPMOEJLF_codec);
		if (Hp != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Hp);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Rank);
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
		if (MaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxHp);
		}
		if (Status != FateMasterStatusType.KghocaphldgPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += iAKFPMOEJLF_.CalculateSize(_repeated_iAKFPMOEJLF_codec);
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hp);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BDDBAKBOMKP other)
	{
		if (other != null)
		{
			if (other.MaxHp != 0)
			{
				MaxHp = other.MaxHp;
			}
			if (other.Status != FateMasterStatusType.KghocaphldgPcpdhelpkem)
			{
				Status = other.Status;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			iAKFPMOEJLF_.Add(other.iAKFPMOEJLF_);
			if (other.Hp != 0)
			{
				Hp = other.Hp;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				MaxHp = input.ReadInt32();
				break;
			case 16u:
				Status = (FateMasterStatusType)input.ReadEnum();
				break;
			case 32u:
				AvatarId = input.ReadUInt32();
				break;
			case 42u:
				iAKFPMOEJLF_.AddEntriesFrom(ref input, _repeated_iAKFPMOEJLF_codec);
				break;
			case 72u:
				Hp = input.ReadInt32();
				break;
			case 88u:
				Rank = input.ReadUInt32();
				break;
			}
		}
	}
}
