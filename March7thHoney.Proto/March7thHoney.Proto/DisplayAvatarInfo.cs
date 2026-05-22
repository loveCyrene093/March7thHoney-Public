using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DisplayAvatarInfo : IMessage<DisplayAvatarInfo>, IMessage, IEquatable<DisplayAvatarInfo>, IDeepCloneable<DisplayAvatarInfo>, IBufferMessage
{
	private static readonly MessageParser<DisplayAvatarInfo> _parser = new MessageParser<DisplayAvatarInfo>(() => new DisplayAvatarInfo());

	private UnknownFieldSet _unknownFields;

	public const int CBHKFOEOMFFFieldNumber = 11;

	private uint cBHKFOEOMFF_;

	public const int AvatarIdFieldNumber = 15;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DisplayAvatarInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DisplayAvatarInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public DisplayAvatarInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarInfo(DisplayAvatarInfo other)
		: this()
	{
		cBHKFOEOMFF_ = other.cBHKFOEOMFF_;
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarInfo Clone()
	{
		return new DisplayAvatarInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DisplayAvatarInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DisplayAvatarInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CBHKFOEOMFF != other.CBHKFOEOMFF)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		if (CBHKFOEOMFF != 0)
		{
			num ^= CBHKFOEOMFF.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
		if (CBHKFOEOMFF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CBHKFOEOMFF);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(AvatarId);
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
		if (CBHKFOEOMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBHKFOEOMFF);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DisplayAvatarInfo other)
	{
		if (other != null)
		{
			if (other.CBHKFOEOMFF != 0)
			{
				CBHKFOEOMFF = other.CBHKFOEOMFF;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
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
			case 88u:
				CBHKFOEOMFF = input.ReadUInt32();
				break;
			case 120u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
