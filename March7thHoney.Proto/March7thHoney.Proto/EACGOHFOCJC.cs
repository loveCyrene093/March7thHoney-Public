using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EACGOHFOCJC : IMessage<EACGOHFOCJC>, IMessage, IEquatable<EACGOHFOCJC>, IDeepCloneable<EACGOHFOCJC>, IBufferMessage
{
	private static readonly MessageParser<EACGOHFOCJC> _parser = new MessageParser<EACGOHFOCJC>(() => new EACGOHFOCJC());

	private UnknownFieldSet _unknownFields;

	public const int INCHLHNKHCHFieldNumber = 10;

	private uint iNCHLHNKHCH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EACGOHFOCJC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EACGOHFOCJCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INCHLHNKHCH
	{
		get
		{
			return iNCHLHNKHCH_;
		}
		set
		{
			iNCHLHNKHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EACGOHFOCJC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EACGOHFOCJC(EACGOHFOCJC other)
		: this()
	{
		iNCHLHNKHCH_ = other.iNCHLHNKHCH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EACGOHFOCJC Clone()
	{
		return new EACGOHFOCJC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EACGOHFOCJC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EACGOHFOCJC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (INCHLHNKHCH != other.INCHLHNKHCH)
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
		if (INCHLHNKHCH != 0)
		{
			num ^= INCHLHNKHCH.GetHashCode();
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
		if (INCHLHNKHCH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(INCHLHNKHCH);
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
		if (INCHLHNKHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INCHLHNKHCH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EACGOHFOCJC other)
	{
		if (other != null)
		{
			if (other.INCHLHNKHCH != 0)
			{
				INCHLHNKHCH = other.INCHLHNKHCH;
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				INCHLHNKHCH = input.ReadUInt32();
			}
		}
	}
}
