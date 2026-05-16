using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMissionStatusCsReq : IMessage<GetMissionStatusCsReq>, IMessage, IEquatable<GetMissionStatusCsReq>, IDeepCloneable<GetMissionStatusCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetMissionStatusCsReq> _parser = new MessageParser<GetMissionStatusCsReq>(() => new GetMissionStatusCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MainMissionIdListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_mainMissionIdList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> mainMissionIdList_ = new RepeatedField<uint>();

	public const int SubMissionIdListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_subMissionIdList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> subMissionIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMissionStatusCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMissionStatusCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MainMissionIdList => mainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SubMissionIdList => subMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionStatusCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionStatusCsReq(GetMissionStatusCsReq other)
		: this()
	{
		mainMissionIdList_ = other.mainMissionIdList_.Clone();
		subMissionIdList_ = other.subMissionIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionStatusCsReq Clone()
	{
		return new GetMissionStatusCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMissionStatusCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMissionStatusCsReq other)
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
		if (!subMissionIdList_.Equals(other.subMissionIdList_))
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
		num ^= subMissionIdList_.GetHashCode();
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
		subMissionIdList_.WriteTo(ref output, _repeated_subMissionIdList_codec);
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
		num += subMissionIdList_.CalculateSize(_repeated_subMissionIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMissionStatusCsReq other)
	{
		if (other != null)
		{
			mainMissionIdList_.Add(other.mainMissionIdList_);
			subMissionIdList_.Add(other.subMissionIdList_);
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
			case 40u:
			case 42u:
				mainMissionIdList_.AddEntriesFrom(ref input, _repeated_mainMissionIdList_codec);
				break;
			case 104u:
			case 106u:
				subMissionIdList_.AddEntriesFrom(ref input, _repeated_subMissionIdList_codec);
				break;
			}
		}
	}
}
