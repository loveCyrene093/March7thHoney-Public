using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ECLEPFKJFLC : IMessage<ECLEPFKJFLC>, IMessage, IEquatable<ECLEPFKJFLC>, IDeepCloneable<ECLEPFKJFLC>, IBufferMessage
{
	private static readonly MessageParser<ECLEPFKJFLC> _parser = new MessageParser<ECLEPFKJFLC>(() => new ECLEPFKJFLC());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	public const int StopDescFieldNumber = 2;

	private string stopDesc_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ECLEPFKJFLC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ECLEPFKJFLCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string StopDesc
	{
		get
		{
			return stopDesc_;
		}
		set
		{
			stopDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECLEPFKJFLC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECLEPFKJFLC(ECLEPFKJFLC other)
		: this()
	{
		avatarIdList_ = other.avatarIdList_.Clone();
		stopDesc_ = other.stopDesc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECLEPFKJFLC Clone()
	{
		return new ECLEPFKJFLC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ECLEPFKJFLC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ECLEPFKJFLC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
		{
			return false;
		}
		if (StopDesc != other.StopDesc)
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
		num ^= avatarIdList_.GetHashCode();
		if (StopDesc.Length != 0)
		{
			num ^= StopDesc.GetHashCode();
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
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
		if (StopDesc.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(StopDesc);
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
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		if (StopDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StopDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ECLEPFKJFLC other)
	{
		if (other != null)
		{
			avatarIdList_.Add(other.avatarIdList_);
			if (other.StopDesc.Length != 0)
			{
				StopDesc = other.StopDesc;
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
			case 8u:
			case 10u:
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			case 18u:
				StopDesc = input.ReadString();
				break;
			}
		}
	}
}
