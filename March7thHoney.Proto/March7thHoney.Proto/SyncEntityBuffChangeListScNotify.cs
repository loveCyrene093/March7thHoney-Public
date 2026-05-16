using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncEntityBuffChangeListScNotify : IMessage<SyncEntityBuffChangeListScNotify>, IMessage, IEquatable<SyncEntityBuffChangeListScNotify>, IDeepCloneable<SyncEntityBuffChangeListScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncEntityBuffChangeListScNotify> _parser = new MessageParser<SyncEntityBuffChangeListScNotify>(() => new SyncEntityBuffChangeListScNotify());

	private UnknownFieldSet _unknownFields;

	public const int EntityBuffChangeListFieldNumber = 10;

	private static readonly FieldCodec<EntityBuffChangeInfo> _repeated_entityBuffChangeList_codec = FieldCodec.ForMessage(82u, EntityBuffChangeInfo.Parser);

	private readonly RepeatedField<EntityBuffChangeInfo> entityBuffChangeList_ = new RepeatedField<EntityBuffChangeInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncEntityBuffChangeListScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncEntityBuffChangeListScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EntityBuffChangeInfo> EntityBuffChangeList => entityBuffChangeList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncEntityBuffChangeListScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncEntityBuffChangeListScNotify(SyncEntityBuffChangeListScNotify other)
		: this()
	{
		entityBuffChangeList_ = other.entityBuffChangeList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncEntityBuffChangeListScNotify Clone()
	{
		return new SyncEntityBuffChangeListScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncEntityBuffChangeListScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncEntityBuffChangeListScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!entityBuffChangeList_.Equals(other.entityBuffChangeList_))
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
		num ^= entityBuffChangeList_.GetHashCode();
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
		entityBuffChangeList_.WriteTo(ref output, _repeated_entityBuffChangeList_codec);
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
		num += entityBuffChangeList_.CalculateSize(_repeated_entityBuffChangeList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncEntityBuffChangeListScNotify other)
	{
		if (other != null)
		{
			entityBuffChangeList_.Add(other.entityBuffChangeList_);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				entityBuffChangeList_.AddEntriesFrom(ref input, _repeated_entityBuffChangeList_codec);
			}
		}
	}
}
