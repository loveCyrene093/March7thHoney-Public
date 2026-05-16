using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameAugmentSync : IMessage<GridFightGameAugmentSync>, IMessage, IEquatable<GridFightGameAugmentSync>, IDeepCloneable<GridFightGameAugmentSync>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameAugmentSync> _parser = new MessageParser<GridFightGameAugmentSync>(() => new GridFightGameAugmentSync());

	private UnknownFieldSet _unknownFields;

	public const int SyncAugmentInfoFieldNumber = 6;

	private static readonly FieldCodec<GridGameAugmentInfo> _repeated_syncAugmentInfo_codec = FieldCodec.ForMessage(50u, GridGameAugmentInfo.Parser);

	private readonly RepeatedField<GridGameAugmentInfo> syncAugmentInfo_ = new RepeatedField<GridGameAugmentInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameAugmentSync> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameAugmentSyncReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameAugmentInfo> SyncAugmentInfo => syncAugmentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentSync()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentSync(GridFightGameAugmentSync other)
		: this()
	{
		syncAugmentInfo_ = other.syncAugmentInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentSync Clone()
	{
		return new GridFightGameAugmentSync(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameAugmentSync);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameAugmentSync other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!syncAugmentInfo_.Equals(other.syncAugmentInfo_))
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
		num ^= syncAugmentInfo_.GetHashCode();
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
		syncAugmentInfo_.WriteTo(ref output, _repeated_syncAugmentInfo_codec);
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
		num += syncAugmentInfo_.CalculateSize(_repeated_syncAugmentInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameAugmentSync other)
	{
		if (other != null)
		{
			syncAugmentInfo_.Add(other.syncAugmentInfo_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				syncAugmentInfo_.AddEntriesFrom(ref input, _repeated_syncAugmentInfo_codec);
			}
		}
	}
}
