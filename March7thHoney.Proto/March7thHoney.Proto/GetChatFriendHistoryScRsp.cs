using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChatFriendHistoryScRsp : IMessage<GetChatFriendHistoryScRsp>, IMessage, IEquatable<GetChatFriendHistoryScRsp>, IDeepCloneable<GetChatFriendHistoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetChatFriendHistoryScRsp> _parser = new MessageParser<GetChatFriendHistoryScRsp>(() => new GetChatFriendHistoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int FriendHistoryInfoFieldNumber = 13;

	private static readonly FieldCodec<FriendHistoryInfo> _repeated_friendHistoryInfo_codec = FieldCodec.ForMessage(106u, March7thHoney.Proto.FriendHistoryInfo.Parser);

	private readonly RepeatedField<FriendHistoryInfo> friendHistoryInfo_ = new RepeatedField<FriendHistoryInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChatFriendHistoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChatFriendHistoryScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<FriendHistoryInfo> FriendHistoryInfo => friendHistoryInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChatFriendHistoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChatFriendHistoryScRsp(GetChatFriendHistoryScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		friendHistoryInfo_ = other.friendHistoryInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChatFriendHistoryScRsp Clone()
	{
		return new GetChatFriendHistoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetChatFriendHistoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChatFriendHistoryScRsp other)
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
		if (!friendHistoryInfo_.Equals(other.friendHistoryInfo_))
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
		num ^= friendHistoryInfo_.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		friendHistoryInfo_.WriteTo(ref output, _repeated_friendHistoryInfo_codec);
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
		num += friendHistoryInfo_.CalculateSize(_repeated_friendHistoryInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetChatFriendHistoryScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			friendHistoryInfo_.Add(other.friendHistoryInfo_);
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
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				friendHistoryInfo_.AddEntriesFrom(ref input, _repeated_friendHistoryInfo_codec);
				break;
			}
		}
	}
}
