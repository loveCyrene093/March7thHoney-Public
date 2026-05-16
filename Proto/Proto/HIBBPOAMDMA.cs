using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HIBBPOAMDMA : IMessage<HIBBPOAMDMA>, IMessage, IEquatable<HIBBPOAMDMA>, IDeepCloneable<HIBBPOAMDMA>, IBufferMessage
{
	private static readonly MessageParser<HIBBPOAMDMA> _parser = new MessageParser<HIBBPOAMDMA>(() => new HIBBPOAMDMA());

	private UnknownFieldSet _unknownFields;

	public const int JPLCJGPCFDOFieldNumber = 9;

	private bool jPLCJGPCFDO_;

	public const int PHKAHAHLDAEFieldNumber = 15;

	private uint pHKAHAHLDAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HIBBPOAMDMA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HIBBPOAMDMAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JPLCJGPCFDO
	{
		get
		{
			return jPLCJGPCFDO_;
		}
		set
		{
			jPLCJGPCFDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBBPOAMDMA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBBPOAMDMA(HIBBPOAMDMA other)
		: this()
	{
		jPLCJGPCFDO_ = other.jPLCJGPCFDO_;
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBBPOAMDMA Clone()
	{
		return new HIBBPOAMDMA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HIBBPOAMDMA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HIBBPOAMDMA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JPLCJGPCFDO != other.JPLCJGPCFDO)
		{
			return false;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
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
		if (JPLCJGPCFDO)
		{
			num ^= JPLCJGPCFDO.GetHashCode();
		}
		if (PHKAHAHLDAE != 0)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
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
		if (JPLCJGPCFDO)
		{
			output.WriteRawTag(72);
			output.WriteBool(JPLCJGPCFDO);
		}
		if (PHKAHAHLDAE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PHKAHAHLDAE);
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
		if (JPLCJGPCFDO)
		{
			num += 2;
		}
		if (PHKAHAHLDAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHKAHAHLDAE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HIBBPOAMDMA other)
	{
		if (other != null)
		{
			if (other.JPLCJGPCFDO)
			{
				JPLCJGPCFDO = other.JPLCJGPCFDO;
			}
			if (other.PHKAHAHLDAE != 0)
			{
				PHKAHAHLDAE = other.PHKAHAHLDAE;
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
			case 72u:
				JPLCJGPCFDO = input.ReadBool();
				break;
			case 120u:
				PHKAHAHLDAE = input.ReadUInt32();
				break;
			}
		}
	}
}
