using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JLAGLJEDAEH : IMessage<JLAGLJEDAEH>, IMessage, IEquatable<JLAGLJEDAEH>, IDeepCloneable<JLAGLJEDAEH>, IBufferMessage
{
	private static readonly MessageParser<JLAGLJEDAEH> _parser = new MessageParser<JLAGLJEDAEH>(() => new JLAGLJEDAEH());

	private UnknownFieldSet _unknownFields;

	public const int HIOFMPHCPJPFieldNumber = 10;

	private uint hIOFMPHCPJP_;

	public const int NKEFAJCOIGJFieldNumber = 12;

	private uint nKEFAJCOIGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JLAGLJEDAEH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JLAGLJEDAEHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HIOFMPHCPJP
	{
		get
		{
			return hIOFMPHCPJP_;
		}
		set
		{
			hIOFMPHCPJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NKEFAJCOIGJ
	{
		get
		{
			return nKEFAJCOIGJ_;
		}
		set
		{
			nKEFAJCOIGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLAGLJEDAEH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLAGLJEDAEH(JLAGLJEDAEH other)
		: this()
	{
		hIOFMPHCPJP_ = other.hIOFMPHCPJP_;
		nKEFAJCOIGJ_ = other.nKEFAJCOIGJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLAGLJEDAEH Clone()
	{
		return new JLAGLJEDAEH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JLAGLJEDAEH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JLAGLJEDAEH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HIOFMPHCPJP != other.HIOFMPHCPJP)
		{
			return false;
		}
		if (NKEFAJCOIGJ != other.NKEFAJCOIGJ)
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
		if (HIOFMPHCPJP != 0)
		{
			num ^= HIOFMPHCPJP.GetHashCode();
		}
		if (NKEFAJCOIGJ != 0)
		{
			num ^= NKEFAJCOIGJ.GetHashCode();
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
		if (HIOFMPHCPJP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(HIOFMPHCPJP);
		}
		if (NKEFAJCOIGJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NKEFAJCOIGJ);
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
		if (HIOFMPHCPJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HIOFMPHCPJP);
		}
		if (NKEFAJCOIGJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKEFAJCOIGJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JLAGLJEDAEH other)
	{
		if (other != null)
		{
			if (other.HIOFMPHCPJP != 0)
			{
				HIOFMPHCPJP = other.HIOFMPHCPJP;
			}
			if (other.NKEFAJCOIGJ != 0)
			{
				NKEFAJCOIGJ = other.NKEFAJCOIGJ;
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
			case 80u:
				HIOFMPHCPJP = input.ReadUInt32();
				break;
			case 96u:
				NKEFAJCOIGJ = input.ReadUInt32();
				break;
			}
		}
	}
}
