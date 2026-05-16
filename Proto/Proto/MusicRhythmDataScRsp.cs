using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmDataScRsp : IMessage<MusicRhythmDataScRsp>, IMessage, IEquatable<MusicRhythmDataScRsp>, IDeepCloneable<MusicRhythmDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmDataScRsp> _parser = new MessageParser<MusicRhythmDataScRsp>(() => new MusicRhythmDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LevelDataListFieldNumber = 1;

	private static readonly FieldCodec<MusicRhythmLevel> _repeated_levelDataList_codec = FieldCodec.ForMessage(10u, MusicRhythmLevel.Parser);

	private readonly RepeatedField<MusicRhythmLevel> levelDataList_ = new RepeatedField<MusicRhythmLevel>();

	public const int UnlockPhaseListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_unlockPhaseList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> unlockPhaseList_ = new RepeatedField<uint>();

	public const int ShowHintFieldNumber = 5;

	private bool showHint_;

	public const int UnlockTrackListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_unlockTrackList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> unlockTrackList_ = new RepeatedField<uint>();

	public const int MusicGroupFieldNumber = 8;

	private static readonly FieldCodec<MusicRhythmGroup> _repeated_musicGroup_codec = FieldCodec.ForMessage(66u, MusicRhythmGroup.Parser);

	private readonly RepeatedField<MusicRhythmGroup> musicGroup_ = new RepeatedField<MusicRhythmGroup>();

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int CurLevelIdFieldNumber = 11;

	private uint curLevelId_;

	public const int UnlockSongListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_unlockSongList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> unlockSongList_ = new RepeatedField<uint>();

	public const int CurSongIdFieldNumber = 14;

	private uint curSongId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MusicRhythmLevel> LevelDataList => levelDataList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnlockPhaseList => unlockPhaseList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ShowHint
	{
		get
		{
			return showHint_;
		}
		set
		{
			showHint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnlockTrackList => unlockTrackList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MusicRhythmGroup> MusicGroup => musicGroup_;

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
	public uint CurLevelId
	{
		get
		{
			return curLevelId_;
		}
		set
		{
			curLevelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnlockSongList => unlockSongList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurSongId
	{
		get
		{
			return curSongId_;
		}
		set
		{
			curSongId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmDataScRsp(MusicRhythmDataScRsp other)
		: this()
	{
		levelDataList_ = other.levelDataList_.Clone();
		unlockPhaseList_ = other.unlockPhaseList_.Clone();
		showHint_ = other.showHint_;
		unlockTrackList_ = other.unlockTrackList_.Clone();
		musicGroup_ = other.musicGroup_.Clone();
		retcode_ = other.retcode_;
		curLevelId_ = other.curLevelId_;
		unlockSongList_ = other.unlockSongList_.Clone();
		curSongId_ = other.curSongId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmDataScRsp Clone()
	{
		return new MusicRhythmDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!levelDataList_.Equals(other.levelDataList_))
		{
			return false;
		}
		if (!unlockPhaseList_.Equals(other.unlockPhaseList_))
		{
			return false;
		}
		if (ShowHint != other.ShowHint)
		{
			return false;
		}
		if (!unlockTrackList_.Equals(other.unlockTrackList_))
		{
			return false;
		}
		if (!musicGroup_.Equals(other.musicGroup_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CurLevelId != other.CurLevelId)
		{
			return false;
		}
		if (!unlockSongList_.Equals(other.unlockSongList_))
		{
			return false;
		}
		if (CurSongId != other.CurSongId)
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
		num ^= levelDataList_.GetHashCode();
		num ^= unlockPhaseList_.GetHashCode();
		if (ShowHint)
		{
			num ^= ShowHint.GetHashCode();
		}
		num ^= unlockTrackList_.GetHashCode();
		num ^= musicGroup_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CurLevelId != 0)
		{
			num ^= CurLevelId.GetHashCode();
		}
		num ^= unlockSongList_.GetHashCode();
		if (CurSongId != 0)
		{
			num ^= CurSongId.GetHashCode();
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
		levelDataList_.WriteTo(ref output, _repeated_levelDataList_codec);
		unlockPhaseList_.WriteTo(ref output, _repeated_unlockPhaseList_codec);
		if (ShowHint)
		{
			output.WriteRawTag(40);
			output.WriteBool(ShowHint);
		}
		unlockTrackList_.WriteTo(ref output, _repeated_unlockTrackList_codec);
		musicGroup_.WriteTo(ref output, _repeated_musicGroup_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (CurLevelId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CurLevelId);
		}
		unlockSongList_.WriteTo(ref output, _repeated_unlockSongList_codec);
		if (CurSongId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CurSongId);
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
		num += levelDataList_.CalculateSize(_repeated_levelDataList_codec);
		num += unlockPhaseList_.CalculateSize(_repeated_unlockPhaseList_codec);
		if (ShowHint)
		{
			num += 2;
		}
		num += unlockTrackList_.CalculateSize(_repeated_unlockTrackList_codec);
		num += musicGroup_.CalculateSize(_repeated_musicGroup_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CurLevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurLevelId);
		}
		num += unlockSongList_.CalculateSize(_repeated_unlockSongList_codec);
		if (CurSongId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurSongId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmDataScRsp other)
	{
		if (other != null)
		{
			levelDataList_.Add(other.levelDataList_);
			unlockPhaseList_.Add(other.unlockPhaseList_);
			if (other.ShowHint)
			{
				ShowHint = other.ShowHint;
			}
			unlockTrackList_.Add(other.unlockTrackList_);
			musicGroup_.Add(other.musicGroup_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.CurLevelId != 0)
			{
				CurLevelId = other.CurLevelId;
			}
			unlockSongList_.Add(other.unlockSongList_);
			if (other.CurSongId != 0)
			{
				CurSongId = other.CurSongId;
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
			case 10u:
				levelDataList_.AddEntriesFrom(ref input, _repeated_levelDataList_codec);
				break;
			case 24u:
			case 26u:
				unlockPhaseList_.AddEntriesFrom(ref input, _repeated_unlockPhaseList_codec);
				break;
			case 40u:
				ShowHint = input.ReadBool();
				break;
			case 48u:
			case 50u:
				unlockTrackList_.AddEntriesFrom(ref input, _repeated_unlockTrackList_codec);
				break;
			case 66u:
				musicGroup_.AddEntriesFrom(ref input, _repeated_musicGroup_codec);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				CurLevelId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				unlockSongList_.AddEntriesFrom(ref input, _repeated_unlockSongList_codec);
				break;
			case 112u:
				CurSongId = input.ReadUInt32();
				break;
			}
		}
	}
}
