using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterActivityFantasticStoryCsReq : IMessage<EnterActivityFantasticStoryCsReq>, IMessage, IEquatable<EnterActivityFantasticStoryCsReq>, IDeepCloneable<EnterActivityFantasticStoryCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterActivityFantasticStoryCsReq> _parser = new MessageParser<EnterActivityFantasticStoryCsReq>(() => new EnterActivityFantasticStoryCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BattleIdFieldNumber = 3;

	private uint battleId_;

	public const int CEIMNDJFDJDFieldNumber = 5;

	private uint cEIMNDJFDJD_;

	public const int BuffListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

	public const int AvatarListFieldNumber = 15;

	private static readonly FieldCodec<OIIADJCEMKB> _repeated_avatarList_codec = FieldCodec.ForMessage(122u, OIIADJCEMKB.Parser);

	private readonly RepeatedField<OIIADJCEMKB> avatarList_ = new RepeatedField<OIIADJCEMKB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterActivityFantasticStoryCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterActivityFantasticStoryCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEIMNDJFDJD
	{
		get
		{
			return cEIMNDJFDJD_;
		}
		set
		{
			cEIMNDJFDJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OIIADJCEMKB> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterActivityFantasticStoryCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterActivityFantasticStoryCsReq(EnterActivityFantasticStoryCsReq other)
		: this()
	{
		battleId_ = other.battleId_;
		cEIMNDJFDJD_ = other.cEIMNDJFDJD_;
		buffList_ = other.buffList_.Clone();
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterActivityFantasticStoryCsReq Clone()
	{
		return new EnterActivityFantasticStoryCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterActivityFantasticStoryCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterActivityFantasticStoryCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BattleId != other.BattleId)
		{
			return false;
		}
		if (CEIMNDJFDJD != other.CEIMNDJFDJD)
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
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
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
		}
		if (CEIMNDJFDJD != 0)
		{
			num ^= CEIMNDJFDJD.GetHashCode();
		}
		num ^= buffList_.GetHashCode();
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
		if (BattleId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BattleId);
		}
		if (CEIMNDJFDJD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CEIMNDJFDJD);
		}
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
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
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (CEIMNDJFDJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEIMNDJFDJD);
		}
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterActivityFantasticStoryCsReq other)
	{
		if (other != null)
		{
			if (other.BattleId != 0)
			{
				BattleId = other.BattleId;
			}
			if (other.CEIMNDJFDJD != 0)
			{
				CEIMNDJFDJD = other.CEIMNDJFDJD;
			}
			buffList_.Add(other.buffList_);
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
			case 24u:
				BattleId = input.ReadUInt32();
				break;
			case 40u:
				CEIMNDJFDJD = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 122u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
