using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BAFDFBJHLGK : IMessage<BAFDFBJHLGK>, IMessage, IEquatable<BAFDFBJHLGK>, IDeepCloneable<BAFDFBJHLGK>, IBufferMessage
{
	private static readonly MessageParser<BAFDFBJHLGK> _parser = new MessageParser<BAFDFBJHLGK>(() => new BAFDFBJHLGK());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 1;

	private static readonly FieldCodec<AetherAvatarInfo> _repeated_avatarList_codec = FieldCodec.ForMessage(10u, AetherAvatarInfo.Parser);

	private readonly RepeatedField<AetherAvatarInfo> avatarList_ = new RepeatedField<AetherAvatarInfo>();

	public const int MonsterWaveListFieldNumber = 2;

	private static readonly FieldCodec<BattleMonsterWave> _repeated_monsterWaveList_codec = FieldCodec.ForMessage(18u, BattleMonsterWave.Parser);

	private readonly RepeatedField<BattleMonsterWave> monsterWaveList_ = new RepeatedField<BattleMonsterWave>();

	public const int BuffListFieldNumber = 3;

	private static readonly FieldCodec<BattleBuff> _repeated_buffList_codec = FieldCodec.ForMessage(26u, BattleBuff.Parser);

	private readonly RepeatedField<BattleBuff> buffList_ = new RepeatedField<BattleBuff>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BAFDFBJHLGK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BAFDFBJHLGKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AetherAvatarInfo> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleMonsterWave> MonsterWaveList => monsterWaveList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleBuff> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFDFBJHLGK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFDFBJHLGK(BAFDFBJHLGK other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		monsterWaveList_ = other.monsterWaveList_.Clone();
		buffList_ = other.buffList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFDFBJHLGK Clone()
	{
		return new BAFDFBJHLGK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BAFDFBJHLGK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BAFDFBJHLGK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!monsterWaveList_.Equals(other.monsterWaveList_))
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
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
		num ^= avatarList_.GetHashCode();
		num ^= monsterWaveList_.GetHashCode();
		num ^= buffList_.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BAFDFBJHLGK other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			monsterWaveList_.Add(other.monsterWaveList_);
			buffList_.Add(other.buffList_);
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
			case 10u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 18u:
				monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
				break;
			case 26u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			}
		}
	}
}
