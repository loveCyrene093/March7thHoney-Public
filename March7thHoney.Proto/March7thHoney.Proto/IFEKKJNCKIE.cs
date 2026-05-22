using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFEKKJNCKIE : IMessage<IFEKKJNCKIE>, IMessage, IEquatable<IFEKKJNCKIE>, IDeepCloneable<IFEKKJNCKIE>, IBufferMessage
{
	private static readonly MessageParser<IFEKKJNCKIE> _parser = new MessageParser<IFEKKJNCKIE>(() => new IFEKKJNCKIE());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int CBHKFOEOMFFFieldNumber = 11;

	private uint cBHKFOEOMFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFEKKJNCKIE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFEKKJNCKIEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CBHKFOEOMFF
	{
		get
		{
			return cBHKFOEOMFF_;
		}
		set
		{
			cBHKFOEOMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFEKKJNCKIE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFEKKJNCKIE(IFEKKJNCKIE other)
		: this()
	{
		avatarId_ = other.avatarId_;
		cBHKFOEOMFF_ = other.cBHKFOEOMFF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFEKKJNCKIE Clone()
	{
		return new IFEKKJNCKIE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFEKKJNCKIE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFEKKJNCKIE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (CBHKFOEOMFF != other.CBHKFOEOMFF)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (CBHKFOEOMFF != 0)
		{
			num ^= CBHKFOEOMFF.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		if (CBHKFOEOMFF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CBHKFOEOMFF);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (CBHKFOEOMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBHKFOEOMFF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFEKKJNCKIE other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.CBHKFOEOMFF != 0)
			{
				CBHKFOEOMFF = other.CBHKFOEOMFF;
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
			case 8u:
				AvatarId = input.ReadUInt32();
				break;
			case 88u:
				CBHKFOEOMFF = input.ReadUInt32();
				break;
			}
		}
	}
}
