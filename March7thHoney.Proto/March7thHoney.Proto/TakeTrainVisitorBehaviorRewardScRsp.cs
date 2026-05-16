using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeTrainVisitorBehaviorRewardScRsp : IMessage<TakeTrainVisitorBehaviorRewardScRsp>, IMessage, IEquatable<TakeTrainVisitorBehaviorRewardScRsp>, IDeepCloneable<TakeTrainVisitorBehaviorRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeTrainVisitorBehaviorRewardScRsp> _parser = new MessageParser<TakeTrainVisitorBehaviorRewardScRsp>(() => new TakeTrainVisitorBehaviorRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int VisitorIdFieldNumber = 2;

	private uint visitorId_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int AJLIIMNDPGLFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_aJLIIMNDPGL_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> aJLIIMNDPGL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeTrainVisitorBehaviorRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeTrainVisitorBehaviorRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint VisitorId
	{
		get
		{
			return visitorId_;
		}
		set
		{
			visitorId_ = value;
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
	public RepeatedField<uint> AJLIIMNDPGL => aJLIIMNDPGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeTrainVisitorBehaviorRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeTrainVisitorBehaviorRewardScRsp(TakeTrainVisitorBehaviorRewardScRsp other)
		: this()
	{
		visitorId_ = other.visitorId_;
		retcode_ = other.retcode_;
		aJLIIMNDPGL_ = other.aJLIIMNDPGL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeTrainVisitorBehaviorRewardScRsp Clone()
	{
		return new TakeTrainVisitorBehaviorRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeTrainVisitorBehaviorRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeTrainVisitorBehaviorRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VisitorId != other.VisitorId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!aJLIIMNDPGL_.Equals(other.aJLIIMNDPGL_))
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
		if (VisitorId != 0)
		{
			num ^= VisitorId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= aJLIIMNDPGL_.GetHashCode();
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
		if (VisitorId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(VisitorId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		aJLIIMNDPGL_.WriteTo(ref output, _repeated_aJLIIMNDPGL_codec);
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
		if (VisitorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VisitorId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += aJLIIMNDPGL_.CalculateSize(_repeated_aJLIIMNDPGL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeTrainVisitorBehaviorRewardScRsp other)
	{
		if (other != null)
		{
			if (other.VisitorId != 0)
			{
				VisitorId = other.VisitorId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			aJLIIMNDPGL_.Add(other.aJLIIMNDPGL_);
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
			case 16u:
				VisitorId = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				aJLIIMNDPGL_.AddEntriesFrom(ref input, _repeated_aJLIIMNDPGL_codec);
				break;
			}
		}
	}
}
