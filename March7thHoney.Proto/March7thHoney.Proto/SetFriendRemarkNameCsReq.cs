using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetFriendRemarkNameCsReq : IMessage<SetFriendRemarkNameCsReq>, IMessage, IEquatable<SetFriendRemarkNameCsReq>, IDeepCloneable<SetFriendRemarkNameCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetFriendRemarkNameCsReq> _parser = new MessageParser<SetFriendRemarkNameCsReq>(() => new SetFriendRemarkNameCsReq());

	private UnknownFieldSet _unknownFields;

	public const int RemarkNameFieldNumber = 4;

	private string remarkName_ = "";

	public const int ReasonFieldNumber = 5;

	private uint reason_;

	public const int UidFieldNumber = 11;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetFriendRemarkNameCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetFriendRemarkNameCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RemarkName
	{
		get
		{
			return remarkName_;
		}
		set
		{
			remarkName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
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
	public SetFriendRemarkNameCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetFriendRemarkNameCsReq(SetFriendRemarkNameCsReq other)
		: this()
	{
		remarkName_ = other.remarkName_;
		reason_ = other.reason_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetFriendRemarkNameCsReq Clone()
	{
		return new SetFriendRemarkNameCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetFriendRemarkNameCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetFriendRemarkNameCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RemarkName != other.RemarkName)
		{
			return false;
		}
		if (Reason != other.Reason)
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
		if (RemarkName.Length != 0)
		{
			num ^= RemarkName.GetHashCode();
		}
		if (Reason != 0)
		{
			num ^= Reason.GetHashCode();
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
		if (RemarkName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(RemarkName);
		}
		if (Reason != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Reason);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(88);
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
		if (RemarkName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RemarkName);
		}
		if (Reason != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Reason);
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
	public void MergeFrom(SetFriendRemarkNameCsReq other)
	{
		if (other != null)
		{
			if (other.RemarkName.Length != 0)
			{
				RemarkName = other.RemarkName;
			}
			if (other.Reason != 0)
			{
				Reason = other.Reason;
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
			case 34u:
				RemarkName = input.ReadString();
				break;
			case 40u:
				Reason = input.ReadUInt32();
				break;
			case 88u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
