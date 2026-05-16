using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncHandleFriendScNotify : IMessage<SyncHandleFriendScNotify>, IMessage, IEquatable<SyncHandleFriendScNotify>, IDeepCloneable<SyncHandleFriendScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncHandleFriendScNotify> _parser = new MessageParser<SyncHandleFriendScNotify>(() => new SyncHandleFriendScNotify());

	private UnknownFieldSet _unknownFields;

	public const int IsAcceptFieldNumber = 2;

	private bool isAccept_;

	public const int FriendInfoFieldNumber = 12;

	private FriendSimpleInfo friendInfo_;

	public const int UidFieldNumber = 15;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncHandleFriendScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncHandleFriendScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsAccept
	{
		get
		{
			return isAccept_;
		}
		set
		{
			isAccept_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSimpleInfo FriendInfo
	{
		get
		{
			return friendInfo_;
		}
		set
		{
			friendInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncHandleFriendScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncHandleFriendScNotify(SyncHandleFriendScNotify other)
		: this()
	{
		isAccept_ = other.isAccept_;
		friendInfo_ = ((other.friendInfo_ != null) ? other.friendInfo_.Clone() : null);
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncHandleFriendScNotify Clone()
	{
		return new SyncHandleFriendScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncHandleFriendScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncHandleFriendScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsAccept != other.IsAccept)
		{
			return false;
		}
		if (!object.Equals(FriendInfo, other.FriendInfo))
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (IsAccept)
		{
			num ^= IsAccept.GetHashCode();
		}
		if (friendInfo_ != null)
		{
			num ^= FriendInfo.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (IsAccept)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsAccept);
		}
		if (friendInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FriendInfo);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Uid);
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
		if (IsAccept)
		{
			num += 2;
		}
		if (friendInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FriendInfo);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncHandleFriendScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsAccept)
		{
			IsAccept = other.IsAccept;
		}
		if (other.friendInfo_ != null)
		{
			if (friendInfo_ == null)
			{
				FriendInfo = new FriendSimpleInfo();
			}
			FriendInfo.MergeFrom(other.FriendInfo);
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				IsAccept = input.ReadBool();
				break;
			case 98u:
				if (friendInfo_ == null)
				{
					FriendInfo = new FriendSimpleInfo();
				}
				input.ReadMessage(FriendInfo);
				break;
			case 120u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
