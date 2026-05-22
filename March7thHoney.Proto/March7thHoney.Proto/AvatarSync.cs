using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AvatarSync : IMessage<AvatarSync>, IMessage, IEquatable<AvatarSync>, IDeepCloneable<AvatarSync>, IBufferMessage
{
	private static readonly MessageParser<AvatarSync> _parser = new MessageParser<AvatarSync>(() => new AvatarSync());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 6;

	private static readonly FieldCodec<Avatar> _repeated_avatarList_codec = FieldCodec.ForMessage(50u, Avatar.Parser);

	private readonly RepeatedField<Avatar> avatarList_ = new RepeatedField<Avatar>();

	public const int AvatarPathDataInfoListFieldNumber = 14;

	private static readonly FieldCodec<AvatarPathData> _repeated_avatarPathDataInfoList_codec = FieldCodec.ForMessage(114u, AvatarPathData.Parser);

	private readonly RepeatedField<AvatarPathData> avatarPathDataInfoList_ = new RepeatedField<AvatarPathData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AvatarSync> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AvatarSyncReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Avatar> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarPathData> AvatarPathDataInfoList => avatarPathDataInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarSync()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarSync(AvatarSync other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		avatarPathDataInfoList_ = other.avatarPathDataInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarSync Clone()
	{
		return new AvatarSync(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AvatarSync);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AvatarSync other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!avatarPathDataInfoList_.Equals(other.avatarPathDataInfoList_))
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
		num ^= avatarList_.GetHashCode();
		num ^= avatarPathDataInfoList_.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		avatarPathDataInfoList_.WriteTo(ref output, _repeated_avatarPathDataInfoList_codec);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += avatarPathDataInfoList_.CalculateSize(_repeated_avatarPathDataInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AvatarSync other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			avatarPathDataInfoList_.Add(other.avatarPathDataInfoList_);
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
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 114u:
				avatarPathDataInfoList_.AddEntriesFrom(ref input, _repeated_avatarPathDataInfoList_codec);
				break;
			}
		}
	}
}
