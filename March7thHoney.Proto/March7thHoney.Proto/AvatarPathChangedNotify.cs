using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AvatarPathChangedNotify : IMessage<AvatarPathChangedNotify>, IMessage, IEquatable<AvatarPathChangedNotify>, IDeepCloneable<AvatarPathChangedNotify>, IBufferMessage
{
	private static readonly MessageParser<AvatarPathChangedNotify> _parser = new MessageParser<AvatarPathChangedNotify>(() => new AvatarPathChangedNotify());

	private UnknownFieldSet _unknownFields;

	public const int BaseAvatarIdFieldNumber = 5;

	private uint baseAvatarId_;

	public const int CurMultiPathAvatarTypeFieldNumber = 7;

	private MultiPathAvatarType curMultiPathAvatarType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AvatarPathChangedNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AvatarPathChangedNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultiPathAvatarType CurMultiPathAvatarType
	{
		get
		{
			return curMultiPathAvatarType_;
		}
		set
		{
			curMultiPathAvatarType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarPathChangedNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarPathChangedNotify(AvatarPathChangedNotify other)
		: this()
	{
		baseAvatarId_ = other.baseAvatarId_;
		curMultiPathAvatarType_ = other.curMultiPathAvatarType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarPathChangedNotify Clone()
	{
		return new AvatarPathChangedNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AvatarPathChangedNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AvatarPathChangedNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BaseAvatarId != other.BaseAvatarId)
		{
			return false;
		}
		if (CurMultiPathAvatarType != other.CurMultiPathAvatarType)
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
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
		}
		if (CurMultiPathAvatarType != MultiPathAvatarType.None)
		{
			num ^= CurMultiPathAvatarType.GetHashCode();
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
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BaseAvatarId);
		}
		if (CurMultiPathAvatarType != MultiPathAvatarType.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)CurMultiPathAvatarType);
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
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		if (CurMultiPathAvatarType != MultiPathAvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CurMultiPathAvatarType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AvatarPathChangedNotify other)
	{
		if (other != null)
		{
			if (other.BaseAvatarId != 0)
			{
				BaseAvatarId = other.BaseAvatarId;
			}
			if (other.CurMultiPathAvatarType != MultiPathAvatarType.None)
			{
				CurMultiPathAvatarType = other.CurMultiPathAvatarType;
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
			case 40u:
				BaseAvatarId = input.ReadUInt32();
				break;
			case 56u:
				CurMultiPathAvatarType = (MultiPathAvatarType)input.ReadEnum();
				break;
			}
		}
	}
}
