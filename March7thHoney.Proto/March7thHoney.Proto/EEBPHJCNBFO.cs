using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EEBPHJCNBFO : IMessage<EEBPHJCNBFO>, IMessage, IEquatable<EEBPHJCNBFO>, IDeepCloneable<EEBPHJCNBFO>, IBufferMessage
{
	private static readonly MessageParser<EEBPHJCNBFO> _parser = new MessageParser<EEBPHJCNBFO>(() => new EEBPHJCNBFO());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 3;

	private uint id_;

	public const int AvatarTypeFieldNumber = 4;

	private AvatarType avatarType_;

	public const int AssistUidFieldNumber = 6;

	private uint assistUid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EEBPHJCNBFO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EEBPHJCNBFOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarType AvatarType
	{
		get
		{
			return avatarType_;
		}
		set
		{
			avatarType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AssistUid
	{
		get
		{
			return assistUid_;
		}
		set
		{
			assistUid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEBPHJCNBFO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEBPHJCNBFO(EEBPHJCNBFO other)
		: this()
	{
		id_ = other.id_;
		avatarType_ = other.avatarType_;
		assistUid_ = other.assistUid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEBPHJCNBFO Clone()
	{
		return new EEBPHJCNBFO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EEBPHJCNBFO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EEBPHJCNBFO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (AssistUid != other.AssistUid)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (AssistUid != 0)
		{
			num ^= AssistUid.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Id);
		}
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)AvatarType);
		}
		if (AssistUid != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AssistUid);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (AssistUid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AssistUid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EEBPHJCNBFO other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.AvatarType != AvatarType.None)
			{
				AvatarType = other.AvatarType;
			}
			if (other.AssistUid != 0)
			{
				AssistUid = other.AssistUid;
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
				Id = input.ReadUInt32();
				break;
			case 32u:
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 48u:
				AssistUid = input.ReadUInt32();
				break;
			}
		}
	}
}
