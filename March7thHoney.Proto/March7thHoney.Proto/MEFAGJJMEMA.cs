using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MEFAGJJMEMA : IMessage<MEFAGJJMEMA>, IMessage, IEquatable<MEFAGJJMEMA>, IDeepCloneable<MEFAGJJMEMA>, IBufferMessage
{
	private static readonly MessageParser<MEFAGJJMEMA> _parser = new MessageParser<MEFAGJJMEMA>(() => new MEFAGJJMEMA());

	private UnknownFieldSet _unknownFields;

	public const int HEJAOOCHEFGFieldNumber = 12;

	private uint hEJAOOCHEFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MEFAGJJMEMA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MEFAGJJMEMAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEJAOOCHEFG
	{
		get
		{
			return hEJAOOCHEFG_;
		}
		set
		{
			hEJAOOCHEFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEFAGJJMEMA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEFAGJJMEMA(MEFAGJJMEMA other)
		: this()
	{
		hEJAOOCHEFG_ = other.hEJAOOCHEFG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEFAGJJMEMA Clone()
	{
		return new MEFAGJJMEMA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MEFAGJJMEMA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MEFAGJJMEMA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HEJAOOCHEFG != other.HEJAOOCHEFG)
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
		if (HEJAOOCHEFG != 0)
		{
			num ^= HEJAOOCHEFG.GetHashCode();
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
		if (HEJAOOCHEFG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HEJAOOCHEFG);
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
		if (HEJAOOCHEFG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEJAOOCHEFG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MEFAGJJMEMA other)
	{
		if (other != null)
		{
			if (other.HEJAOOCHEFG != 0)
			{
				HEJAOOCHEFG = other.HEJAOOCHEFG;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HEJAOOCHEFG = input.ReadUInt32();
			}
		}
	}
}
