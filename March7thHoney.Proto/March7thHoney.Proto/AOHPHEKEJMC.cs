using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AOHPHEKEJMC : IMessage<AOHPHEKEJMC>, IMessage, IEquatable<AOHPHEKEJMC>, IDeepCloneable<AOHPHEKEJMC>, IBufferMessage
{
	private static readonly MessageParser<AOHPHEKEJMC> _parser = new MessageParser<AOHPHEKEJMC>(() => new AOHPHEKEJMC());

	private UnknownFieldSet _unknownFields;

	public const int BEDLMDHNMBJFieldNumber = 8;

	private uint bEDLMDHNMBJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AOHPHEKEJMC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AOHPHEKEJMCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEDLMDHNMBJ
	{
		get
		{
			return bEDLMDHNMBJ_;
		}
		set
		{
			bEDLMDHNMBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHPHEKEJMC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHPHEKEJMC(AOHPHEKEJMC other)
		: this()
	{
		bEDLMDHNMBJ_ = other.bEDLMDHNMBJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHPHEKEJMC Clone()
	{
		return new AOHPHEKEJMC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AOHPHEKEJMC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AOHPHEKEJMC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BEDLMDHNMBJ != other.BEDLMDHNMBJ)
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
		if (BEDLMDHNMBJ != 0)
		{
			num ^= BEDLMDHNMBJ.GetHashCode();
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
		if (BEDLMDHNMBJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BEDLMDHNMBJ);
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
		if (BEDLMDHNMBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEDLMDHNMBJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AOHPHEKEJMC other)
	{
		if (other != null)
		{
			if (other.BEDLMDHNMBJ != 0)
			{
				BEDLMDHNMBJ = other.BEDLMDHNMBJ;
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
			if (num != 64)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BEDLMDHNMBJ = input.ReadUInt32();
			}
		}
	}
}
