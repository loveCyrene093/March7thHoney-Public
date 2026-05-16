using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeBpRewardCsReq : IMessage<TakeBpRewardCsReq>, IMessage, IEquatable<TakeBpRewardCsReq>, IDeepCloneable<TakeBpRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeBpRewardCsReq> _parser = new MessageParser<TakeBpRewardCsReq>(() => new TakeBpRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 2;

	private BpRewardType type_;

	public const int OptionalRewardIdFieldNumber = 5;

	private uint optionalRewardId_;

	public const int LevelFieldNumber = 13;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeBpRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeBpRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BpRewardType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OptionalRewardId
	{
		get
		{
			return optionalRewardId_;
		}
		set
		{
			optionalRewardId_ = value;
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
	public TakeBpRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeBpRewardCsReq(TakeBpRewardCsReq other)
		: this()
	{
		type_ = other.type_;
		optionalRewardId_ = other.optionalRewardId_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeBpRewardCsReq Clone()
	{
		return new TakeBpRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeBpRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeBpRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (OptionalRewardId != other.OptionalRewardId)
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
		if (Type != BpRewardType.FaajkcacgcdOejcecbchlc)
		{
			num ^= Type.GetHashCode();
		}
		if (OptionalRewardId != 0)
		{
			num ^= OptionalRewardId.GetHashCode();
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
		if (Type != BpRewardType.FaajkcacgcdOejcecbchlc)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (OptionalRewardId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OptionalRewardId);
		}
		if (Level != 0)
		{
			output.WriteRawTag(104);
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
		if (Type != BpRewardType.FaajkcacgcdOejcecbchlc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (OptionalRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OptionalRewardId);
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
	public void MergeFrom(TakeBpRewardCsReq other)
	{
		if (other != null)
		{
			if (other.Type != BpRewardType.FaajkcacgcdOejcecbchlc)
			{
				Type = other.Type;
			}
			if (other.OptionalRewardId != 0)
			{
				OptionalRewardId = other.OptionalRewardId;
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
			case 16u:
				Type = (BpRewardType)input.ReadEnum();
				break;
			case 40u:
				OptionalRewardId = input.ReadUInt32();
				break;
			case 104u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
