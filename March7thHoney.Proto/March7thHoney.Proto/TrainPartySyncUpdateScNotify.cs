using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartySyncUpdateScNotify : IMessage<TrainPartySyncUpdateScNotify>, IMessage, IEquatable<TrainPartySyncUpdateScNotify>, IDeepCloneable<TrainPartySyncUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainPartySyncUpdateScNotify> _parser = new MessageParser<TrainPartySyncUpdateScNotify>(() => new TrainPartySyncUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int UpdateDynamicListFieldNumber = 11;

	private static readonly FieldCodec<DCIEAIDBBCI> _repeated_updateDynamicList_codec = FieldCodec.ForMessage(90u, DCIEAIDBBCI.Parser);

	private readonly RepeatedField<DCIEAIDBBCI> updateDynamicList_ = new RepeatedField<DCIEAIDBBCI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartySyncUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartySyncUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DCIEAIDBBCI> UpdateDynamicList => updateDynamicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartySyncUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartySyncUpdateScNotify(TrainPartySyncUpdateScNotify other)
		: this()
	{
		updateDynamicList_ = other.updateDynamicList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartySyncUpdateScNotify Clone()
	{
		return new TrainPartySyncUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartySyncUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartySyncUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!updateDynamicList_.Equals(other.updateDynamicList_))
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
		num ^= updateDynamicList_.GetHashCode();
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
		updateDynamicList_.WriteTo(ref output, _repeated_updateDynamicList_codec);
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
		num += updateDynamicList_.CalculateSize(_repeated_updateDynamicList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartySyncUpdateScNotify other)
	{
		if (other != null)
		{
			updateDynamicList_.Add(other.updateDynamicList_);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				updateDynamicList_.AddEntriesFrom(ref input, _repeated_updateDynamicList_codec);
			}
		}
	}
}
