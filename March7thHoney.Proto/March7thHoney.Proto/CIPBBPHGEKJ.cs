using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIPBBPHGEKJ : IMessage<CIPBBPHGEKJ>, IMessage, IEquatable<CIPBBPHGEKJ>, IDeepCloneable<CIPBBPHGEKJ>, IBufferMessage
{
	private static readonly MessageParser<CIPBBPHGEKJ> _parser = new MessageParser<CIPBBPHGEKJ>(() => new CIPBBPHGEKJ());

	private UnknownFieldSet _unknownFields;

	public const int PassengerIdFieldNumber = 2;

	private uint passengerId_;

	public const int UniqueIdFieldNumber = 9;

	private uint uniqueId_;

	public const int KKIOIFLJEELFieldNumber = 14;

	private uint kKIOIFLJEEL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIPBBPHGEKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIPBBPHGEKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PassengerId
	{
		get
		{
			return passengerId_;
		}
		set
		{
			passengerId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKIOIFLJEEL
	{
		get
		{
			return kKIOIFLJEEL_;
		}
		set
		{
			kKIOIFLJEEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIPBBPHGEKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIPBBPHGEKJ(CIPBBPHGEKJ other)
		: this()
	{
		passengerId_ = other.passengerId_;
		uniqueId_ = other.uniqueId_;
		kKIOIFLJEEL_ = other.kKIOIFLJEEL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIPBBPHGEKJ Clone()
	{
		return new CIPBBPHGEKJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIPBBPHGEKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIPBBPHGEKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PassengerId != other.PassengerId)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (KKIOIFLJEEL != other.KKIOIFLJEEL)
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
		if (PassengerId != 0)
		{
			num ^= PassengerId.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (KKIOIFLJEEL != 0)
		{
			num ^= KKIOIFLJEEL.GetHashCode();
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
		if (PassengerId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PassengerId);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(UniqueId);
		}
		if (KKIOIFLJEEL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(KKIOIFLJEEL);
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
		if (PassengerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PassengerId);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (KKIOIFLJEEL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKIOIFLJEEL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIPBBPHGEKJ other)
	{
		if (other != null)
		{
			if (other.PassengerId != 0)
			{
				PassengerId = other.PassengerId;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.KKIOIFLJEEL != 0)
			{
				KKIOIFLJEEL = other.KKIOIFLJEEL;
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
				PassengerId = input.ReadUInt32();
				break;
			case 72u:
				UniqueId = input.ReadUInt32();
				break;
			case 112u:
				KKIOIFLJEEL = input.ReadUInt32();
				break;
			}
		}
	}
}
