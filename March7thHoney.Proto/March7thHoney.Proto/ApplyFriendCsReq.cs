using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ApplyFriendCsReq : IMessage<ApplyFriendCsReq>, IMessage, IEquatable<ApplyFriendCsReq>, IDeepCloneable<ApplyFriendCsReq>, IBufferMessage
{
	private static readonly MessageParser<ApplyFriendCsReq> _parser = new MessageParser<ApplyFriendCsReq>(() => new ApplyFriendCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 8;

	private FriendApplySource source_;

	public const int UidFieldNumber = 15;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ApplyFriendCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ApplyFriendCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendApplySource Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
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
	public ApplyFriendCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ApplyFriendCsReq(ApplyFriendCsReq other)
		: this()
	{
		source_ = other.source_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ApplyFriendCsReq Clone()
	{
		return new ApplyFriendCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ApplyFriendCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ApplyFriendCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Source != other.Source)
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
		if (Source != FriendApplySource.PabbphoidbfPcpdhelpkem)
		{
			num ^= Source.GetHashCode();
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
		if (Source != FriendApplySource.PabbphoidbfPcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Source);
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
		if (Source != FriendApplySource.PabbphoidbfPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
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
	public void MergeFrom(ApplyFriendCsReq other)
	{
		if (other != null)
		{
			if (other.Source != FriendApplySource.PabbphoidbfPcpdhelpkem)
			{
				Source = other.Source;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
			case 64u:
				Source = (FriendApplySource)input.ReadEnum();
				break;
			case 120u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
