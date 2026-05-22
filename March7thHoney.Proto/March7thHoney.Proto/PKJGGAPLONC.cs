using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKJGGAPLONC : IMessage<PKJGGAPLONC>, IMessage, IEquatable<PKJGGAPLONC>, IDeepCloneable<PKJGGAPLONC>, IBufferMessage
{
	private static readonly MessageParser<PKJGGAPLONC> _parser = new MessageParser<PKJGGAPLONC>(() => new PKJGGAPLONC());

	private UnknownFieldSet _unknownFields;

	public const int AvatarTypeFieldNumber = 1;

	private AvatarType avatarType_;

	public const int IdFieldNumber = 2;

	private uint id_;

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int IndexFieldNumber = 4;

	private uint index_;

	public const int CBHKFOEOMFFFieldNumber = 5;

	private uint cBHKFOEOMFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKJGGAPLONC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKJGGAPLONCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PKJGGAPLONC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKJGGAPLONC(PKJGGAPLONC other)
		: this()
	{
		avatarType_ = other.avatarType_;
		id_ = other.id_;
		level_ = other.level_;
		index_ = other.index_;
		cBHKFOEOMFF_ = other.cBHKFOEOMFF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKJGGAPLONC Clone()
	{
		return new PKJGGAPLONC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKJGGAPLONC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKJGGAPLONC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Index != other.Index)
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
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
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
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)AvatarType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Id);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Level);
		}
		if (Index != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Index);
		}
		if (CBHKFOEOMFF != 0)
		{
			output.WriteRawTag(40);
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
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
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
	public void MergeFrom(PKJGGAPLONC other)
	{
		if (other != null)
		{
			if (other.AvatarType != AvatarType.None)
			{
				AvatarType = other.AvatarType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
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
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 16u:
				Id = input.ReadUInt32();
				break;
			case 24u:
				Level = input.ReadUInt32();
				break;
			case 32u:
				Index = input.ReadUInt32();
				break;
			case 40u:
				CBHKFOEOMFF = input.ReadUInt32();
				break;
			}
		}
	}
}
