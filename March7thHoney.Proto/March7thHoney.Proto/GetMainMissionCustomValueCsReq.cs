using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMainMissionCustomValueCsReq : IMessage<GetMainMissionCustomValueCsReq>, IMessage, IEquatable<GetMainMissionCustomValueCsReq>, IDeepCloneable<GetMainMissionCustomValueCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetMainMissionCustomValueCsReq> _parser = new MessageParser<GetMainMissionCustomValueCsReq>(() => new GetMainMissionCustomValueCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MainMissionIdListFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_mainMissionIdList_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> mainMissionIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMainMissionCustomValueCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMainMissionCustomValueCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MainMissionIdList => mainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMainMissionCustomValueCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMainMissionCustomValueCsReq(GetMainMissionCustomValueCsReq other)
		: this()
	{
		mainMissionIdList_ = other.mainMissionIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMainMissionCustomValueCsReq Clone()
	{
		return new GetMainMissionCustomValueCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMainMissionCustomValueCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMainMissionCustomValueCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mainMissionIdList_.Equals(other.mainMissionIdList_))
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
		num ^= mainMissionIdList_.GetHashCode();
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
		mainMissionIdList_.WriteTo(ref output, _repeated_mainMissionIdList_codec);
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
		num += mainMissionIdList_.CalculateSize(_repeated_mainMissionIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMainMissionCustomValueCsReq other)
	{
		if (other != null)
		{
			mainMissionIdList_.Add(other.mainMissionIdList_);
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
			if (num != 32 && num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mainMissionIdList_.AddEntriesFrom(ref input, _repeated_mainMissionIdList_codec);
			}
		}
	}
}
