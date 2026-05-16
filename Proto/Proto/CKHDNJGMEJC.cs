using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CKHDNJGMEJC : IMessage<CKHDNJGMEJC>, IMessage, IEquatable<CKHDNJGMEJC>, IDeepCloneable<CKHDNJGMEJC>, IBufferMessage
{
	private static readonly MessageParser<CKHDNJGMEJC> _parser = new MessageParser<CKHDNJGMEJC>(() => new CKHDNJGMEJC());

	private UnknownFieldSet _unknownFields;

	public const int NumFieldNumber = 4;

	private uint num_;

	public const int PassengerIdFieldNumber = 9;

	private uint passengerId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CKHDNJGMEJC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CKHDNJGMEJCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

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
	public CKHDNJGMEJC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKHDNJGMEJC(CKHDNJGMEJC other)
		: this()
	{
		num_ = other.num_;
		passengerId_ = other.passengerId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKHDNJGMEJC Clone()
	{
		return new CKHDNJGMEJC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CKHDNJGMEJC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CKHDNJGMEJC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (PassengerId != other.PassengerId)
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
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (PassengerId != 0)
		{
			num ^= PassengerId.GetHashCode();
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
		if (Num != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Num);
		}
		if (PassengerId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PassengerId);
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
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (PassengerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PassengerId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CKHDNJGMEJC other)
	{
		if (other != null)
		{
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.PassengerId != 0)
			{
				PassengerId = other.PassengerId;
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
			case 32u:
				Num = input.ReadUInt32();
				break;
			case 72u:
				PassengerId = input.ReadUInt32();
				break;
			}
		}
	}
}
