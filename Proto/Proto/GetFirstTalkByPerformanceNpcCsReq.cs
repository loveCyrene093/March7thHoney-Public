using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFirstTalkByPerformanceNpcCsReq : IMessage<GetFirstTalkByPerformanceNpcCsReq>, IMessage, IEquatable<GetFirstTalkByPerformanceNpcCsReq>, IDeepCloneable<GetFirstTalkByPerformanceNpcCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetFirstTalkByPerformanceNpcCsReq> _parser = new MessageParser<GetFirstTalkByPerformanceNpcCsReq>(() => new GetFirstTalkByPerformanceNpcCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PerformanceIdListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_performanceIdList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> performanceIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFirstTalkByPerformanceNpcCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFirstTalkByPerformanceNpcCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PerformanceIdList => performanceIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFirstTalkByPerformanceNpcCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFirstTalkByPerformanceNpcCsReq(GetFirstTalkByPerformanceNpcCsReq other)
		: this()
	{
		performanceIdList_ = other.performanceIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFirstTalkByPerformanceNpcCsReq Clone()
	{
		return new GetFirstTalkByPerformanceNpcCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFirstTalkByPerformanceNpcCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFirstTalkByPerformanceNpcCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!performanceIdList_.Equals(other.performanceIdList_))
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
		num ^= performanceIdList_.GetHashCode();
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
		performanceIdList_.WriteTo(ref output, _repeated_performanceIdList_codec);
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
		num += performanceIdList_.CalculateSize(_repeated_performanceIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFirstTalkByPerformanceNpcCsReq other)
	{
		if (other != null)
		{
			performanceIdList_.Add(other.performanceIdList_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				performanceIdList_.AddEntriesFrom(ref input, _repeated_performanceIdList_codec);
			}
		}
	}
}
