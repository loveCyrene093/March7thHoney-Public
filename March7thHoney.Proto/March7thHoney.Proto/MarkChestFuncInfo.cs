using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarkChestFuncInfo : IMessage<MarkChestFuncInfo>, IMessage, IEquatable<MarkChestFuncInfo>, IDeepCloneable<MarkChestFuncInfo>, IBufferMessage
{
	private static readonly MessageParser<MarkChestFuncInfo> _parser = new MessageParser<MarkChestFuncInfo>(() => new MarkChestFuncInfo());

	private UnknownFieldSet _unknownFields;

	public const int MarkChestInfoListFieldNumber = 3;

	private static readonly FieldCodec<MarkChestInfo> _repeated_markChestInfoList_codec = FieldCodec.ForMessage(26u, MarkChestInfo.Parser);

	private readonly RepeatedField<MarkChestInfo> markChestInfoList_ = new RepeatedField<MarkChestInfo>();

	public const int FuncIdFieldNumber = 7;

	private uint funcId_;

	public const int MarkTimeFieldNumber = 8;

	private long markTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarkChestFuncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarkChestFuncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MarkChestInfo> MarkChestInfoList => markChestInfoList_;

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
	public long MarkTime
	{
		get
		{
			return markTime_;
		}
		set
		{
			markTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChestFuncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChestFuncInfo(MarkChestFuncInfo other)
		: this()
	{
		markChestInfoList_ = other.markChestInfoList_.Clone();
		funcId_ = other.funcId_;
		markTime_ = other.markTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChestFuncInfo Clone()
	{
		return new MarkChestFuncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarkChestFuncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarkChestFuncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!markChestInfoList_.Equals(other.markChestInfoList_))
		{
			return false;
		}
		if (FuncId != other.FuncId)
		{
			return false;
		}
		if (MarkTime != other.MarkTime)
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
		num ^= markChestInfoList_.GetHashCode();
		if (FuncId != 0)
		{
			num ^= FuncId.GetHashCode();
		}
		if (MarkTime != 0L)
		{
			num ^= MarkTime.GetHashCode();
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
		markChestInfoList_.WriteTo(ref output, _repeated_markChestInfoList_codec);
		if (FuncId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FuncId);
		}
		if (MarkTime != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(MarkTime);
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
		num += markChestInfoList_.CalculateSize(_repeated_markChestInfoList_codec);
		if (FuncId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FuncId);
		}
		if (MarkTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MarkTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarkChestFuncInfo other)
	{
		if (other != null)
		{
			markChestInfoList_.Add(other.markChestInfoList_);
			if (other.FuncId != 0)
			{
				FuncId = other.FuncId;
			}
			if (other.MarkTime != 0L)
			{
				MarkTime = other.MarkTime;
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
			case 26u:
				markChestInfoList_.AddEntriesFrom(ref input, _repeated_markChestInfoList_codec);
				break;
			case 56u:
				FuncId = input.ReadUInt32();
				break;
			case 64u:
				MarkTime = input.ReadInt64();
				break;
			}
		}
	}
}
