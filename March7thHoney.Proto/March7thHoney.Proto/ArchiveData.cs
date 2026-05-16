using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArchiveData : IMessage<ArchiveData>, IMessage, IEquatable<ArchiveData>, IDeepCloneable<ArchiveData>, IBufferMessage
{
	private static readonly MessageParser<ArchiveData> _parser = new MessageParser<ArchiveData>(() => new ArchiveData());

	private UnknownFieldSet _unknownFields;

	public const int ArchiveAvatarIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_archiveAvatarIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> archiveAvatarIdList_ = new RepeatedField<uint>();

	public const int KillMonsterListFieldNumber = 6;

	private static readonly FieldCodec<MonsterList> _repeated_killMonsterList_codec = FieldCodec.ForMessage(50u, MonsterList.Parser);

	private readonly RepeatedField<MonsterList> killMonsterList_ = new RepeatedField<MonsterList>();

	public const int ArchiveEquipmentIdListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_archiveEquipmentIdList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> archiveEquipmentIdList_ = new RepeatedField<uint>();

	public const int RelicListFieldNumber = 8;

	private static readonly FieldCodec<RelicList> _repeated_relicList_codec = FieldCodec.ForMessage(66u, March7thHoney.Proto.RelicList.Parser);

	private readonly RepeatedField<RelicList> relicList_ = new RepeatedField<RelicList>();

	public const int ArchiveMissingEquipmentIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_archiveMissingEquipmentIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> archiveMissingEquipmentIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArchiveData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ArchiveDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ArchiveAvatarIdList => archiveAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterList> KillMonsterList => killMonsterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ArchiveEquipmentIdList => archiveEquipmentIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RelicList> RelicList => relicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ArchiveMissingEquipmentIdList => archiveMissingEquipmentIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArchiveData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArchiveData(ArchiveData other)
		: this()
	{
		archiveAvatarIdList_ = other.archiveAvatarIdList_.Clone();
		killMonsterList_ = other.killMonsterList_.Clone();
		archiveEquipmentIdList_ = other.archiveEquipmentIdList_.Clone();
		relicList_ = other.relicList_.Clone();
		archiveMissingEquipmentIdList_ = other.archiveMissingEquipmentIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArchiveData Clone()
	{
		return new ArchiveData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ArchiveData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArchiveData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!archiveAvatarIdList_.Equals(other.archiveAvatarIdList_))
		{
			return false;
		}
		if (!killMonsterList_.Equals(other.killMonsterList_))
		{
			return false;
		}
		if (!archiveEquipmentIdList_.Equals(other.archiveEquipmentIdList_))
		{
			return false;
		}
		if (!relicList_.Equals(other.relicList_))
		{
			return false;
		}
		if (!archiveMissingEquipmentIdList_.Equals(other.archiveMissingEquipmentIdList_))
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
		num ^= archiveAvatarIdList_.GetHashCode();
		num ^= killMonsterList_.GetHashCode();
		num ^= archiveEquipmentIdList_.GetHashCode();
		num ^= relicList_.GetHashCode();
		num ^= archiveMissingEquipmentIdList_.GetHashCode();
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
		archiveAvatarIdList_.WriteTo(ref output, _repeated_archiveAvatarIdList_codec);
		killMonsterList_.WriteTo(ref output, _repeated_killMonsterList_codec);
		archiveEquipmentIdList_.WriteTo(ref output, _repeated_archiveEquipmentIdList_codec);
		relicList_.WriteTo(ref output, _repeated_relicList_codec);
		archiveMissingEquipmentIdList_.WriteTo(ref output, _repeated_archiveMissingEquipmentIdList_codec);
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
		num += archiveAvatarIdList_.CalculateSize(_repeated_archiveAvatarIdList_codec);
		num += killMonsterList_.CalculateSize(_repeated_killMonsterList_codec);
		num += archiveEquipmentIdList_.CalculateSize(_repeated_archiveEquipmentIdList_codec);
		num += relicList_.CalculateSize(_repeated_relicList_codec);
		num += archiveMissingEquipmentIdList_.CalculateSize(_repeated_archiveMissingEquipmentIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArchiveData other)
	{
		if (other != null)
		{
			archiveAvatarIdList_.Add(other.archiveAvatarIdList_);
			killMonsterList_.Add(other.killMonsterList_);
			archiveEquipmentIdList_.Add(other.archiveEquipmentIdList_);
			relicList_.Add(other.relicList_);
			archiveMissingEquipmentIdList_.Add(other.archiveMissingEquipmentIdList_);
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
			case 16u:
			case 18u:
				archiveAvatarIdList_.AddEntriesFrom(ref input, _repeated_archiveAvatarIdList_codec);
				break;
			case 50u:
				killMonsterList_.AddEntriesFrom(ref input, _repeated_killMonsterList_codec);
				break;
			case 56u:
			case 58u:
				archiveEquipmentIdList_.AddEntriesFrom(ref input, _repeated_archiveEquipmentIdList_codec);
				break;
			case 66u:
				relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
				break;
			case 96u:
			case 98u:
				archiveMissingEquipmentIdList_.AddEntriesFrom(ref input, _repeated_archiveMissingEquipmentIdList_codec);
				break;
			}
		}
	}
}
