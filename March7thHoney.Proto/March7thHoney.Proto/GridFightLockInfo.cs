using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightLockInfo : IMessage<GridFightLockInfo>, IMessage, IEquatable<GridFightLockInfo>, IDeepCloneable<GridFightLockInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightLockInfo> _parser = new MessageParser<GridFightLockInfo>(() => new GridFightLockInfo());

	private UnknownFieldSet _unknownFields;

	public const int LockReasonFieldNumber = 7;

	private GridFightLockReason lockReason_;

	public const int LockTypeFieldNumber = 10;

	private GridFightLockType lockType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightLockInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightLockInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockReason LockReason
	{
		get
		{
			return lockReason_;
		}
		set
		{
			lockReason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockType LockType
	{
		get
		{
			return lockType_;
		}
		set
		{
			lockType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockInfo(GridFightLockInfo other)
		: this()
	{
		lockReason_ = other.lockReason_;
		lockType_ = other.lockType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockInfo Clone()
	{
		return new GridFightLockInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightLockInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightLockInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LockReason != other.LockReason)
		{
			return false;
		}
		if (LockType != other.LockType)
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
		if (LockReason != GridFightLockReason.DfofffceffoDionkbmffdn)
		{
			num ^= LockReason.GetHashCode();
		}
		if (LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
		{
			num ^= LockType.GetHashCode();
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
		if (LockReason != GridFightLockReason.DfofffceffoDionkbmffdn)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)LockReason);
		}
		if (LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)LockType);
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
		if (LockReason != GridFightLockReason.DfofffceffoDionkbmffdn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LockReason);
		}
		if (LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LockType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightLockInfo other)
	{
		if (other != null)
		{
			if (other.LockReason != GridFightLockReason.DfofffceffoDionkbmffdn)
			{
				LockReason = other.LockReason;
			}
			if (other.LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
			{
				LockType = other.LockType;
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
				LockReason = (GridFightLockReason)input.ReadEnum();
				break;
			case 80u:
				LockType = (GridFightLockType)input.ReadEnum();
				break;
			}
		}
	}
}
