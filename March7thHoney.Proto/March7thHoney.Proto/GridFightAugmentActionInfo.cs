using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightAugmentActionInfo : IMessage<GridFightAugmentActionInfo>, IMessage, IEquatable<GridFightAugmentActionInfo>, IDeepCloneable<GridFightAugmentActionInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightAugmentActionInfo> _parser = new MessageParser<GridFightAugmentActionInfo>(() => new GridFightAugmentActionInfo());

	private UnknownFieldSet _unknownFields;

	public const int PendingAugmentInfoListFieldNumber = 9;

	private static readonly FieldCodec<GridFightPendingAugmentInfo> _repeated_pendingAugmentInfoList_codec = FieldCodec.ForMessage(74u, GridFightPendingAugmentInfo.Parser);

	private readonly RepeatedField<GridFightPendingAugmentInfo> pendingAugmentInfoList_ = new RepeatedField<GridFightPendingAugmentInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightAugmentActionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightAugmentActionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightPendingAugmentInfo> PendingAugmentInfoList => pendingAugmentInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightAugmentActionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightAugmentActionInfo(GridFightAugmentActionInfo other)
		: this()
	{
		pendingAugmentInfoList_ = other.pendingAugmentInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightAugmentActionInfo Clone()
	{
		return new GridFightAugmentActionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightAugmentActionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightAugmentActionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pendingAugmentInfoList_.Equals(other.pendingAugmentInfoList_))
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
		num ^= pendingAugmentInfoList_.GetHashCode();
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
		pendingAugmentInfoList_.WriteTo(ref output, _repeated_pendingAugmentInfoList_codec);
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
		num += pendingAugmentInfoList_.CalculateSize(_repeated_pendingAugmentInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightAugmentActionInfo other)
	{
		if (other != null)
		{
			pendingAugmentInfoList_.Add(other.pendingAugmentInfoList_);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pendingAugmentInfoList_.AddEntriesFrom(ref input, _repeated_pendingAugmentInfoList_codec);
			}
		}
	}
}
