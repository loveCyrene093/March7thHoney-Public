using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeAvatarInfo : IMessage<ChallengeAvatarInfo>, IMessage, IEquatable<ChallengeAvatarInfo>, IDeepCloneable<ChallengeAvatarInfo>, IBufferMessage
{
	private static readonly MessageParser<ChallengeAvatarInfo> _parser = new MessageParser<ChallengeAvatarInfo>(() => new ChallengeAvatarInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 7;

	private uint id_;

	public const int CBHKFOEOMFFFieldNumber = 9;

	private uint cBHKFOEOMFF_;

	public const int AvatarTypeFieldNumber = 10;

	private AvatarType avatarType_;

	public const int IndexFieldNumber = 13;

	private uint index_;

	public const int LevelFieldNumber = 15;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeAvatarInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeAvatarInfoReflection.Descriptor.MessageTypes[0];

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
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeAvatarInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeAvatarInfo(ChallengeAvatarInfo other)
		: this()
	{
		id_ = other.id_;
		cBHKFOEOMFF_ = other.cBHKFOEOMFF_;
		avatarType_ = other.avatarType_;
		index_ = other.index_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeAvatarInfo Clone()
	{
		return new ChallengeAvatarInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeAvatarInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeAvatarInfo other)
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
		if (CBHKFOEOMFF != other.CBHKFOEOMFF)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (CBHKFOEOMFF != 0)
		{
			num ^= CBHKFOEOMFF.GetHashCode();
		}
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
			output.WriteRawTag(56);
			output.WriteUInt32(Id);
		}
		if (CBHKFOEOMFF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CBHKFOEOMFF);
		}
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)AvatarType);
		}
		if (Index != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Index);
		}
		if (Level != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Level);
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
		if (CBHKFOEOMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBHKFOEOMFF);
		}
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeAvatarInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.CBHKFOEOMFF != 0)
			{
				CBHKFOEOMFF = other.CBHKFOEOMFF;
			}
			if (other.AvatarType != AvatarType.None)
			{
				AvatarType = other.AvatarType;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 56u:
				Id = input.ReadUInt32();
				break;
			case 72u:
				CBHKFOEOMFF = input.ReadUInt32();
				break;
			case 80u:
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 104u:
				Index = input.ReadUInt32();
				break;
			case 120u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
