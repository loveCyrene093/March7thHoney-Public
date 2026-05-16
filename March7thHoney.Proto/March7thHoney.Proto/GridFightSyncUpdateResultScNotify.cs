using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSyncUpdateResultScNotify : IMessage<GridFightSyncUpdateResultScNotify>, IMessage, IEquatable<GridFightSyncUpdateResultScNotify>, IDeepCloneable<GridFightSyncUpdateResultScNotify>, IBufferMessage
{
	private static readonly MessageParser<GridFightSyncUpdateResultScNotify> _parser = new MessageParser<GridFightSyncUpdateResultScNotify>(() => new GridFightSyncUpdateResultScNotify());

	private UnknownFieldSet _unknownFields;

	public const int SyncResultDataListFieldNumber = 8;

	private static readonly FieldCodec<GridFightSyncResultData> _repeated_syncResultDataList_codec = FieldCodec.ForMessage(66u, GridFightSyncResultData.Parser);

	private readonly RepeatedField<GridFightSyncResultData> syncResultDataList_ = new RepeatedField<GridFightSyncResultData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSyncUpdateResultScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSyncUpdateResultScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightSyncResultData> SyncResultDataList => syncResultDataList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncUpdateResultScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncUpdateResultScNotify(GridFightSyncUpdateResultScNotify other)
		: this()
	{
		syncResultDataList_ = other.syncResultDataList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncUpdateResultScNotify Clone()
	{
		return new GridFightSyncUpdateResultScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSyncUpdateResultScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSyncUpdateResultScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!syncResultDataList_.Equals(other.syncResultDataList_))
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
		num ^= syncResultDataList_.GetHashCode();
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
		syncResultDataList_.WriteTo(ref output, _repeated_syncResultDataList_codec);
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
		num += syncResultDataList_.CalculateSize(_repeated_syncResultDataList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSyncUpdateResultScNotify other)
	{
		if (other != null)
		{
			syncResultDataList_.Add(other.syncResultDataList_);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				syncResultDataList_.AddEntriesFrom(ref input, _repeated_syncResultDataList_codec);
			}
		}
	}
}
