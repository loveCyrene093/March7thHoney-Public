using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HIGGMLEFJNI : IMessage<HIGGMLEFJNI>, IMessage, IEquatable<HIGGMLEFJNI>, IDeepCloneable<HIGGMLEFJNI>, IBufferMessage
{
	private static readonly MessageParser<HIGGMLEFJNI> _parser = new MessageParser<HIGGMLEFJNI>(() => new HIGGMLEFJNI());

	private UnknownFieldSet _unknownFields;

	public const int PMPHJFCCHHCFieldNumber = 14;

	private uint pMPHJFCCHHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HIGGMLEFJNI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HIGGMLEFJNIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMPHJFCCHHC
	{
		get
		{
			return pMPHJFCCHHC_;
		}
		set
		{
			pMPHJFCCHHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIGGMLEFJNI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIGGMLEFJNI(HIGGMLEFJNI other)
		: this()
	{
		pMPHJFCCHHC_ = other.pMPHJFCCHHC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIGGMLEFJNI Clone()
	{
		return new HIGGMLEFJNI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HIGGMLEFJNI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HIGGMLEFJNI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PMPHJFCCHHC != other.PMPHJFCCHHC)
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
		if (PMPHJFCCHHC != 0)
		{
			num ^= PMPHJFCCHHC.GetHashCode();
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
		if (PMPHJFCCHHC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PMPHJFCCHHC);
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
		if (PMPHJFCCHHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMPHJFCCHHC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HIGGMLEFJNI other)
	{
		if (other != null)
		{
			if (other.PMPHJFCCHHC != 0)
			{
				PMPHJFCCHHC = other.PMPHJFCCHHC;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PMPHJFCCHHC = input.ReadUInt32();
			}
		}
	}
}
