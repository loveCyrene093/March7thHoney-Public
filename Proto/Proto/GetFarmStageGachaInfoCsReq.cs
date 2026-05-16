using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFarmStageGachaInfoCsReq : IMessage<GetFarmStageGachaInfoCsReq>, IMessage, IEquatable<GetFarmStageGachaInfoCsReq>, IDeepCloneable<GetFarmStageGachaInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetFarmStageGachaInfoCsReq> _parser = new MessageParser<GetFarmStageGachaInfoCsReq>(() => new GetFarmStageGachaInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FarmStageGachaIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_farmStageGachaIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> farmStageGachaIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFarmStageGachaInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFarmStageGachaInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FarmStageGachaIdList => farmStageGachaIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFarmStageGachaInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFarmStageGachaInfoCsReq(GetFarmStageGachaInfoCsReq other)
		: this()
	{
		farmStageGachaIdList_ = other.farmStageGachaIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFarmStageGachaInfoCsReq Clone()
	{
		return new GetFarmStageGachaInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFarmStageGachaInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFarmStageGachaInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!farmStageGachaIdList_.Equals(other.farmStageGachaIdList_))
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
		num ^= farmStageGachaIdList_.GetHashCode();
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
		farmStageGachaIdList_.WriteTo(ref output, _repeated_farmStageGachaIdList_codec);
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
		num += farmStageGachaIdList_.CalculateSize(_repeated_farmStageGachaIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFarmStageGachaInfoCsReq other)
	{
		if (other != null)
		{
			farmStageGachaIdList_.Add(other.farmStageGachaIdList_);
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
			if (num != 48 && num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				farmStageGachaIdList_.AddEntriesFrom(ref input, _repeated_farmStageGachaIdList_codec);
			}
		}
	}
}
