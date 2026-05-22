using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JANNOEMCKOI : IMessage<JANNOEMCKOI>, IMessage, IEquatable<JANNOEMCKOI>, IDeepCloneable<JANNOEMCKOI>, IBufferMessage
{
	private static readonly MessageParser<JANNOEMCKOI> _parser = new MessageParser<JANNOEMCKOI>(() => new JANNOEMCKOI());

	private UnknownFieldSet _unknownFields;

	public const int BuffListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

	public const int AvatarListFieldNumber = 14;

	private static readonly FieldCodec<StrongChallengeAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage(114u, StrongChallengeAvatar.Parser);

	private readonly RepeatedField<StrongChallengeAvatar> avatarList_ = new RepeatedField<StrongChallengeAvatar>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JANNOEMCKOI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JANNOEMCKOIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<StrongChallengeAvatar> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JANNOEMCKOI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JANNOEMCKOI(JANNOEMCKOI other)
		: this()
	{
		buffList_ = other.buffList_.Clone();
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JANNOEMCKOI Clone()
	{
		return new JANNOEMCKOI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JANNOEMCKOI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JANNOEMCKOI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		num ^= buffList_.GetHashCode();
		num ^= avatarList_.GetHashCode();
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
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JANNOEMCKOI other)
	{
		if (other != null)
		{
			buffList_.Add(other.buffList_);
			avatarList_.Add(other.avatarList_);
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
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 114u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
