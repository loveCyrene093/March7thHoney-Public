using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DAGLHILOCKL : IMessage<DAGLHILOCKL>, IMessage, IEquatable<DAGLHILOCKL>, IDeepCloneable<DAGLHILOCKL>, IBufferMessage
{
	private static readonly MessageParser<DAGLHILOCKL> _parser = new MessageParser<DAGLHILOCKL>(() => new DAGLHILOCKL());

	private UnknownFieldSet _unknownFields;

	public const int HOKJFKNPKAJFieldNumber = 1;

	private uint hOKJFKNPKAJ_;

	public const int NEEPAJPDHKKFieldNumber = 2;

	private uint nEEPAJPDHKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DAGLHILOCKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DAGLHILOCKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOKJFKNPKAJ
	{
		get
		{
			return hOKJFKNPKAJ_;
		}
		set
		{
			hOKJFKNPKAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NEEPAJPDHKK
	{
		get
		{
			return nEEPAJPDHKK_;
		}
		set
		{
			nEEPAJPDHKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAGLHILOCKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAGLHILOCKL(DAGLHILOCKL other)
		: this()
	{
		hOKJFKNPKAJ_ = other.hOKJFKNPKAJ_;
		nEEPAJPDHKK_ = other.nEEPAJPDHKK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAGLHILOCKL Clone()
	{
		return new DAGLHILOCKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DAGLHILOCKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DAGLHILOCKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HOKJFKNPKAJ != other.HOKJFKNPKAJ)
		{
			return false;
		}
		if (NEEPAJPDHKK != other.NEEPAJPDHKK)
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
		if (HOKJFKNPKAJ != 0)
		{
			num ^= HOKJFKNPKAJ.GetHashCode();
		}
		if (NEEPAJPDHKK != 0)
		{
			num ^= NEEPAJPDHKK.GetHashCode();
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
		if (HOKJFKNPKAJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HOKJFKNPKAJ);
		}
		if (NEEPAJPDHKK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NEEPAJPDHKK);
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
		if (HOKJFKNPKAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOKJFKNPKAJ);
		}
		if (NEEPAJPDHKK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NEEPAJPDHKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DAGLHILOCKL other)
	{
		if (other != null)
		{
			if (other.HOKJFKNPKAJ != 0)
			{
				HOKJFKNPKAJ = other.HOKJFKNPKAJ;
			}
			if (other.NEEPAJPDHKK != 0)
			{
				NEEPAJPDHKK = other.NEEPAJPDHKK;
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
				HOKJFKNPKAJ = input.ReadUInt32();
				break;
			case 16u:
				NEEPAJPDHKK = input.ReadUInt32();
				break;
			}
		}
	}
}
