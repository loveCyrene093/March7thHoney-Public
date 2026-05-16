using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTraitTrackSyncInfo : IMessage<GridFightTraitTrackSyncInfo>, IMessage, IEquatable<GridFightTraitTrackSyncInfo>, IDeepCloneable<GridFightTraitTrackSyncInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightTraitTrackSyncInfo> _parser = new MessageParser<GridFightTraitTrackSyncInfo>(() => new GridFightTraitTrackSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int IsSyncFieldNumber = 12;

	private bool isSync_;

	public const int TrackTraitIdListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_trackTraitIdList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> trackTraitIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTraitTrackSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightTraitTrackSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSync
	{
		get
		{
			return isSync_;
		}
		set
		{
			isSync_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TrackTraitIdList => trackTraitIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitTrackSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitTrackSyncInfo(GridFightTraitTrackSyncInfo other)
		: this()
	{
		isSync_ = other.isSync_;
		trackTraitIdList_ = other.trackTraitIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitTrackSyncInfo Clone()
	{
		return new GridFightTraitTrackSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightTraitTrackSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTraitTrackSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsSync != other.IsSync)
		{
			return false;
		}
		if (!trackTraitIdList_.Equals(other.trackTraitIdList_))
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
		if (IsSync)
		{
			num ^= IsSync.GetHashCode();
		}
		num ^= trackTraitIdList_.GetHashCode();
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
		if (IsSync)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsSync);
		}
		trackTraitIdList_.WriteTo(ref output, _repeated_trackTraitIdList_codec);
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
		if (IsSync)
		{
			num += 2;
		}
		num += trackTraitIdList_.CalculateSize(_repeated_trackTraitIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTraitTrackSyncInfo other)
	{
		if (other != null)
		{
			if (other.IsSync)
			{
				IsSync = other.IsSync;
			}
			trackTraitIdList_.Add(other.trackTraitIdList_);
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
			case 96u:
				IsSync = input.ReadBool();
				break;
			case 112u:
			case 114u:
				trackTraitIdList_.AddEntriesFrom(ref input, _repeated_trackTraitIdList_codec);
				break;
			}
		}
	}
}
