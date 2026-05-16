using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionCustomValueSnapshotList : IMessage<MissionCustomValueSnapshotList>, IMessage, IEquatable<MissionCustomValueSnapshotList>, IDeepCloneable<MissionCustomValueSnapshotList>, IBufferMessage
{
	private static readonly MessageParser<MissionCustomValueSnapshotList> _parser = new MessageParser<MissionCustomValueSnapshotList>(() => new MissionCustomValueSnapshotList());

	private UnknownFieldSet _unknownFields;

	public const int CustomValueListFieldNumber = 1;

	private static readonly FieldCodec<MissionCustomValueSnapshot> _repeated_customValueList_codec = FieldCodec.ForMessage(10u, MissionCustomValueSnapshot.Parser);

	private readonly RepeatedField<MissionCustomValueSnapshot> customValueList_ = new RepeatedField<MissionCustomValueSnapshot>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionCustomValueSnapshotList> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionCustomValueSnapshotListReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MissionCustomValueSnapshot> CustomValueList => customValueList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValueSnapshotList()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValueSnapshotList(MissionCustomValueSnapshotList other)
		: this()
	{
		customValueList_ = other.customValueList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValueSnapshotList Clone()
	{
		return new MissionCustomValueSnapshotList(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionCustomValueSnapshotList);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionCustomValueSnapshotList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!customValueList_.Equals(other.customValueList_))
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
		num ^= customValueList_.GetHashCode();
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
		customValueList_.WriteTo(ref output, _repeated_customValueList_codec);
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
		num += customValueList_.CalculateSize(_repeated_customValueList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionCustomValueSnapshotList other)
	{
		if (other != null)
		{
			customValueList_.Add(other.customValueList_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				customValueList_.AddEntriesFrom(ref input, _repeated_customValueList_codec);
			}
		}
	}
}
