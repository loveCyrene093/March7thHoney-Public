using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetFriendMarkCsReq : IMessage<SetFriendMarkCsReq>, IMessage, IEquatable<SetFriendMarkCsReq>, IDeepCloneable<SetFriendMarkCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetFriendMarkCsReq> _parser = new MessageParser<SetFriendMarkCsReq>(() => new SetFriendMarkCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 3;

	private uint reason_;

	public const int KBNKNAHGPHGFieldNumber = 7;

	private bool kBNKNAHGPHG_;

	public const int UidFieldNumber = 8;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetFriendMarkCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetFriendMarkCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool KBNKNAHGPHG
	{
		get
		{
			return kBNKNAHGPHG_;
		}
		set
		{
			kBNKNAHGPHG_ = value;
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
	public SetFriendMarkCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetFriendMarkCsReq(SetFriendMarkCsReq other)
		: this()
	{
		reason_ = other.reason_;
		kBNKNAHGPHG_ = other.kBNKNAHGPHG_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetFriendMarkCsReq Clone()
	{
		return new SetFriendMarkCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetFriendMarkCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetFriendMarkCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (KBNKNAHGPHG != other.KBNKNAHGPHG)
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
		if (Reason != 0)
		{
			num ^= Reason.GetHashCode();
		}
		if (KBNKNAHGPHG)
		{
			num ^= KBNKNAHGPHG.GetHashCode();
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
		if (Reason != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Reason);
		}
		if (KBNKNAHGPHG)
		{
			output.WriteRawTag(56);
			output.WriteBool(KBNKNAHGPHG);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(64);
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
		if (Reason != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Reason);
		}
		if (KBNKNAHGPHG)
		{
			num += 2;
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
	public void MergeFrom(SetFriendMarkCsReq other)
	{
		if (other != null)
		{
			if (other.Reason != 0)
			{
				Reason = other.Reason;
			}
			if (other.KBNKNAHGPHG)
			{
				KBNKNAHGPHG = other.KBNKNAHGPHG;
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
			case 24u:
				Reason = input.ReadUInt32();
				break;
			case 56u:
				KBNKNAHGPHG = input.ReadBool();
				break;
			case 64u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
