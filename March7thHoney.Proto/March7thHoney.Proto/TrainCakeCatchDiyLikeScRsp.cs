using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainCakeCatchDiyLikeScRsp : IMessage<TrainCakeCatchDiyLikeScRsp>, IMessage, IEquatable<TrainCakeCatchDiyLikeScRsp>, IDeepCloneable<TrainCakeCatchDiyLikeScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainCakeCatchDiyLikeScRsp> _parser = new MessageParser<TrainCakeCatchDiyLikeScRsp>(() => new TrainCakeCatchDiyLikeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int JNNKJAEMOBNFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_jNNKJAEMOBN_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> jNNKJAEMOBN_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainCakeCatchDiyLikeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainCakeCatchDiyLikeScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> JNNKJAEMOBN => jNNKJAEMOBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyLikeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyLikeScRsp(TrainCakeCatchDiyLikeScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		jNNKJAEMOBN_ = other.jNNKJAEMOBN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyLikeScRsp Clone()
	{
		return new TrainCakeCatchDiyLikeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainCakeCatchDiyLikeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainCakeCatchDiyLikeScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!jNNKJAEMOBN_.Equals(other.jNNKJAEMOBN_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= jNNKJAEMOBN_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		jNNKJAEMOBN_.WriteTo(ref output, _repeated_jNNKJAEMOBN_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += jNNKJAEMOBN_.CalculateSize(_repeated_jNNKJAEMOBN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainCakeCatchDiyLikeScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			jNNKJAEMOBN_.Add(other.jNNKJAEMOBN_);
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
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				jNNKJAEMOBN_.AddEntriesFrom(ref input, _repeated_jNNKJAEMOBN_codec);
				break;
			}
		}
	}
}
