using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTreasureDungeonMonsterCsReq : IMessage<FightTreasureDungeonMonsterCsReq>, IMessage, IEquatable<FightTreasureDungeonMonsterCsReq>, IDeepCloneable<FightTreasureDungeonMonsterCsReq>, IBufferMessage
{
	private static readonly MessageParser<FightTreasureDungeonMonsterCsReq> _parser = new MessageParser<FightTreasureDungeonMonsterCsReq>(() => new FightTreasureDungeonMonsterCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TargetSideFieldNumber = 5;

	private uint targetSide_;

	public const int CJOPNFDBJHDFieldNumber = 9;

	private uint cJOPNFDBJHD_;

	public const int AvatarListFieldNumber = 13;

	private static readonly FieldCodec<FNGPALCMBKK> _repeated_avatarList_codec = FieldCodec.ForMessage(106u, FNGPALCMBKK.Parser);

	private readonly RepeatedField<FNGPALCMBKK> avatarList_ = new RepeatedField<FNGPALCMBKK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTreasureDungeonMonsterCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FightTreasureDungeonMonsterCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJOPNFDBJHD
	{
		get
		{
			return cJOPNFDBJHD_;
		}
		set
		{
			cJOPNFDBJHD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FNGPALCMBKK> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTreasureDungeonMonsterCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTreasureDungeonMonsterCsReq(FightTreasureDungeonMonsterCsReq other)
		: this()
	{
		targetSide_ = other.targetSide_;
		cJOPNFDBJHD_ = other.cJOPNFDBJHD_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTreasureDungeonMonsterCsReq Clone()
	{
		return new FightTreasureDungeonMonsterCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FightTreasureDungeonMonsterCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTreasureDungeonMonsterCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (CJOPNFDBJHD != other.CJOPNFDBJHD)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (CJOPNFDBJHD != 0)
		{
			num ^= CJOPNFDBJHD.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		if (TargetSide != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(TargetSide);
		}
		if (CJOPNFDBJHD != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CJOPNFDBJHD);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (CJOPNFDBJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPNFDBJHD);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTreasureDungeonMonsterCsReq other)
	{
		if (other != null)
		{
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.CJOPNFDBJHD != 0)
			{
				CJOPNFDBJHD = other.CJOPNFDBJHD;
			}
			avatarList_.Add(other.avatarList_);
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
			case 40u:
				TargetSide = input.ReadUInt32();
				break;
			case 72u:
				CJOPNFDBJHD = input.ReadUInt32();
				break;
			case 106u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
