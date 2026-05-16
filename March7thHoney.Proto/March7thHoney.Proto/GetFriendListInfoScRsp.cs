using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendListInfoScRsp : IMessage<GetFriendListInfoScRsp>, IMessage, IEquatable<GetFriendListInfoScRsp>, IDeepCloneable<GetFriendListInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFriendListInfoScRsp> _parser = new MessageParser<GetFriendListInfoScRsp>(() => new GetFriendListInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int BlackListFieldNumber = 12;

	private static readonly FieldCodec<PlayerSimpleInfo> _repeated_blackList_codec = FieldCodec.ForMessage(98u, PlayerSimpleInfo.Parser);

	private readonly RepeatedField<PlayerSimpleInfo> blackList_ = new RepeatedField<PlayerSimpleInfo>();

	public const int FriendListFieldNumber = 15;

	private static readonly FieldCodec<FriendSimpleInfo> _repeated_friendList_codec = FieldCodec.ForMessage(122u, FriendSimpleInfo.Parser);

	private readonly RepeatedField<FriendSimpleInfo> friendList_ = new RepeatedField<FriendSimpleInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendListInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendListInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<PlayerSimpleInfo> BlackList => blackList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FriendSimpleInfo> FriendList => friendList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendListInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendListInfoScRsp(GetFriendListInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		blackList_ = other.blackList_.Clone();
		friendList_ = other.friendList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendListInfoScRsp Clone()
	{
		return new GetFriendListInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendListInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendListInfoScRsp other)
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
		if (!blackList_.Equals(other.blackList_))
		{
			return false;
		}
		if (!friendList_.Equals(other.friendList_))
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
		num ^= blackList_.GetHashCode();
		num ^= friendList_.GetHashCode();
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
		blackList_.WriteTo(ref output, _repeated_blackList_codec);
		friendList_.WriteTo(ref output, _repeated_friendList_codec);
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
		num += blackList_.CalculateSize(_repeated_blackList_codec);
		num += friendList_.CalculateSize(_repeated_friendList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendListInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			blackList_.Add(other.blackList_);
			friendList_.Add(other.friendList_);
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
			case 98u:
				blackList_.AddEntriesFrom(ref input, _repeated_blackList_codec);
				break;
			case 122u:
				friendList_.AddEntriesFrom(ref input, _repeated_friendList_codec);
				break;
			}
		}
	}
}
