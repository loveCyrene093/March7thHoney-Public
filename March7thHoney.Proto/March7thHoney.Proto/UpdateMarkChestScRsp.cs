using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateMarkChestScRsp : IMessage<UpdateMarkChestScRsp>, IMessage, IEquatable<UpdateMarkChestScRsp>, IDeepCloneable<UpdateMarkChestScRsp>, IBufferMessage
{
	private static readonly MessageParser<UpdateMarkChestScRsp> _parser = new MessageParser<UpdateMarkChestScRsp>(() => new UpdateMarkChestScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MarkChestFuncInfoFieldNumber = 6;

	private static readonly FieldCodec<MarkChestFuncInfo> _repeated_markChestFuncInfo_codec = FieldCodec.ForMessage(50u, March7thHoney.Proto.MarkChestFuncInfo.Parser);

	private readonly RepeatedField<MarkChestFuncInfo> markChestFuncInfo_ = new RepeatedField<MarkChestFuncInfo>();

	public const int FuncIdFieldNumber = 9;

	private uint funcId_;

	public const int TriggerParamIdFieldNumber = 14;

	private uint triggerParamId_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateMarkChestScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateMarkChestScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MarkChestFuncInfo> MarkChestFuncInfo => markChestFuncInfo_;

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMarkChestScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMarkChestScRsp(UpdateMarkChestScRsp other)
		: this()
	{
		markChestFuncInfo_ = other.markChestFuncInfo_.Clone();
		funcId_ = other.funcId_;
		triggerParamId_ = other.triggerParamId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMarkChestScRsp Clone()
	{
		return new UpdateMarkChestScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateMarkChestScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateMarkChestScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!markChestFuncInfo_.Equals(other.markChestFuncInfo_))
		{
			return false;
		}
		if (FuncId != other.FuncId)
		{
			return false;
		}
		if (TriggerParamId != other.TriggerParamId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= markChestFuncInfo_.GetHashCode();
		if (FuncId != 0)
		{
			num ^= FuncId.GetHashCode();
		}
		if (TriggerParamId != 0)
		{
			num ^= TriggerParamId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
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
		markChestFuncInfo_.WriteTo(ref output, _repeated_markChestFuncInfo_codec);
		if (FuncId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FuncId);
		}
		if (TriggerParamId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(TriggerParamId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
		}
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
		num += markChestFuncInfo_.CalculateSize(_repeated_markChestFuncInfo_codec);
		if (FuncId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FuncId);
		}
		if (TriggerParamId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TriggerParamId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateMarkChestScRsp other)
	{
		if (other != null)
		{
			markChestFuncInfo_.Add(other.markChestFuncInfo_);
			if (other.FuncId != 0)
			{
				FuncId = other.FuncId;
			}
			if (other.TriggerParamId != 0)
			{
				TriggerParamId = other.TriggerParamId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
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
			case 50u:
				markChestFuncInfo_.AddEntriesFrom(ref input, _repeated_markChestFuncInfo_codec);
				break;
			case 72u:
				FuncId = input.ReadUInt32();
				break;
			case 112u:
				TriggerParamId = input.ReadUInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
