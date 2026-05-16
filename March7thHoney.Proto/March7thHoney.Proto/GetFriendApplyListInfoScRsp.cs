using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendApplyListInfoScRsp : IMessage<GetFriendApplyListInfoScRsp>, IMessage, IEquatable<GetFriendApplyListInfoScRsp>, IDeepCloneable<GetFriendApplyListInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFriendApplyListInfoScRsp> _parser = new MessageParser<GetFriendApplyListInfoScRsp>(() => new GetFriendApplyListInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int SendApplyListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_sendApplyList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> sendApplyList_ = new RepeatedField<uint>();

	public const int ReceiveApplyListFieldNumber = 11;

	private static readonly FieldCodec<FriendApplyInfo> _repeated_receiveApplyList_codec = FieldCodec.ForMessage(90u, FriendApplyInfo.Parser);

	private readonly RepeatedField<FriendApplyInfo> receiveApplyList_ = new RepeatedField<FriendApplyInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendApplyListInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendApplyListInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> SendApplyList => sendApplyList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FriendApplyInfo> ReceiveApplyList => receiveApplyList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendApplyListInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendApplyListInfoScRsp(GetFriendApplyListInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		sendApplyList_ = other.sendApplyList_.Clone();
		receiveApplyList_ = other.receiveApplyList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendApplyListInfoScRsp Clone()
	{
		return new GetFriendApplyListInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendApplyListInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendApplyListInfoScRsp other)
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
		if (!sendApplyList_.Equals(other.sendApplyList_))
		{
			return false;
		}
		if (!receiveApplyList_.Equals(other.receiveApplyList_))
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
		num ^= sendApplyList_.GetHashCode();
		num ^= receiveApplyList_.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		sendApplyList_.WriteTo(ref output, _repeated_sendApplyList_codec);
		receiveApplyList_.WriteTo(ref output, _repeated_receiveApplyList_codec);
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
		num += sendApplyList_.CalculateSize(_repeated_sendApplyList_codec);
		num += receiveApplyList_.CalculateSize(_repeated_receiveApplyList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendApplyListInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			sendApplyList_.Add(other.sendApplyList_);
			receiveApplyList_.Add(other.receiveApplyList_);
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				sendApplyList_.AddEntriesFrom(ref input, _repeated_sendApplyList_codec);
				break;
			case 90u:
				receiveApplyList_.AddEntriesFrom(ref input, _repeated_receiveApplyList_codec);
				break;
			}
		}
	}
}
