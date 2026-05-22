using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateMarkChestCsReq : IMessage<UpdateMarkChestCsReq>, IMessage, IEquatable<UpdateMarkChestCsReq>, IDeepCloneable<UpdateMarkChestCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateMarkChestCsReq> _parser = new MessageParser<UpdateMarkChestCsReq>(() => new UpdateMarkChestCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TriggerParamIdFieldNumber = 1;

	private uint triggerParamId_;

	public const int FuncIdFieldNumber = 2;

	private uint funcId_;

	public const int MarkChestInfoListFieldNumber = 10;

	private static readonly FieldCodec<MarkChestInfo> _repeated_markChestInfoList_codec = FieldCodec.ForMessage(82u, MarkChestInfo.Parser);

	private readonly RepeatedField<MarkChestInfo> markChestInfoList_ = new RepeatedField<MarkChestInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateMarkChestCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateMarkChestCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TriggerParamId
	{
		get
		{
			return triggerParamId_;
		}
		set
		{
			triggerParamId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FuncId
	{
		get
		{
			return funcId_;
		}
		set
		{
			funcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MarkChestInfo> MarkChestInfoList => markChestInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMarkChestCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMarkChestCsReq(UpdateMarkChestCsReq other)
		: this()
	{
		triggerParamId_ = other.triggerParamId_;
		funcId_ = other.funcId_;
		markChestInfoList_ = other.markChestInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMarkChestCsReq Clone()
	{
		return new UpdateMarkChestCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateMarkChestCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateMarkChestCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TriggerParamId != other.TriggerParamId)
		{
			return false;
		}
		if (FuncId != other.FuncId)
		{
			return false;
		}
		if (!markChestInfoList_.Equals(other.markChestInfoList_))
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
		if (TriggerParamId != 0)
		{
			num ^= TriggerParamId.GetHashCode();
		}
		if (FuncId != 0)
		{
			num ^= FuncId.GetHashCode();
		}
		num ^= markChestInfoList_.GetHashCode();
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
		if (TriggerParamId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TriggerParamId);
		}
		if (FuncId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FuncId);
		}
		markChestInfoList_.WriteTo(ref output, _repeated_markChestInfoList_codec);
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
		if (TriggerParamId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TriggerParamId);
		}
		if (FuncId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FuncId);
		}
		num += markChestInfoList_.CalculateSize(_repeated_markChestInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateMarkChestCsReq other)
	{
		if (other != null)
		{
			if (other.TriggerParamId != 0)
			{
				TriggerParamId = other.TriggerParamId;
			}
			if (other.FuncId != 0)
			{
				FuncId = other.FuncId;
			}
			markChestInfoList_.Add(other.markChestInfoList_);
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
			case 8u:
				TriggerParamId = input.ReadUInt32();
				break;
			case 16u:
				FuncId = input.ReadUInt32();
				break;
			case 82u:
				markChestInfoList_.AddEntriesFrom(ref input, _repeated_markChestInfoList_codec);
				break;
			}
		}
	}
}
