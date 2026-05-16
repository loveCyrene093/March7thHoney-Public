using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncApplyFriendScNotify : IMessage<SyncApplyFriendScNotify>, IMessage, IEquatable<SyncApplyFriendScNotify>, IDeepCloneable<SyncApplyFriendScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncApplyFriendScNotify> _parser = new MessageParser<SyncApplyFriendScNotify>(() => new SyncApplyFriendScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FriendApplyInfoFieldNumber = 4;

	private FriendApplyInfo friendApplyInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncApplyFriendScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncApplyFriendScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendApplyInfo FriendApplyInfo
	{
		get
		{
			return friendApplyInfo_;
		}
		set
		{
			friendApplyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncApplyFriendScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncApplyFriendScNotify(SyncApplyFriendScNotify other)
		: this()
	{
		friendApplyInfo_ = ((other.friendApplyInfo_ != null) ? other.friendApplyInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncApplyFriendScNotify Clone()
	{
		return new SyncApplyFriendScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncApplyFriendScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncApplyFriendScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FriendApplyInfo, other.FriendApplyInfo))
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
		if (friendApplyInfo_ != null)
		{
			num ^= FriendApplyInfo.GetHashCode();
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
		if (friendApplyInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FriendApplyInfo);
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
		if (friendApplyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FriendApplyInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncApplyFriendScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.friendApplyInfo_ != null)
		{
			if (friendApplyInfo_ == null)
			{
				FriendApplyInfo = new FriendApplyInfo();
			}
			FriendApplyInfo.MergeFrom(other.FriendApplyInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (friendApplyInfo_ == null)
			{
				FriendApplyInfo = new FriendApplyInfo();
			}
			input.ReadMessage(FriendApplyInfo);
		}
	}
}
