using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FIMOHHPINNB : IMessage<FIMOHHPINNB>, IMessage, IEquatable<FIMOHHPINNB>, IDeepCloneable<FIMOHHPINNB>, IBufferMessage
{
	private static readonly MessageParser<FIMOHHPINNB> _parser = new MessageParser<FIMOHHPINNB>(() => new FIMOHHPINNB());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private MPKJECNGFPF type_;

	public const int CountFieldNumber = 2;

	private uint count_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FIMOHHPINNB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FIMOHHPINNBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPKJECNGFPF Type
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
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIMOHHPINNB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIMOHHPINNB(FIMOHHPINNB other)
		: this()
	{
		type_ = other.type_;
		count_ = other.count_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIMOHHPINNB Clone()
	{
		return new FIMOHHPINNB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FIMOHHPINNB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FIMOHHPINNB other)
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
		if (Count != other.Count)
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
		if (Type != MPKJECNGFPF.Gkjgmdaokgn)
		{
			num ^= Type.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
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
		if (Type != MPKJECNGFPF.Gkjgmdaokgn)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Count);
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
		if (Type != MPKJECNGFPF.Gkjgmdaokgn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FIMOHHPINNB other)
	{
		if (other != null)
		{
			if (other.Type != MPKJECNGFPF.Gkjgmdaokgn)
			{
				Type = other.Type;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
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
				Type = (MPKJECNGFPF)input.ReadEnum();
				break;
			case 16u:
				Count = input.ReadUInt32();
				break;
			}
		}
	}
}
