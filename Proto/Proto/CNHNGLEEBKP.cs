using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNHNGLEEBKP : IMessage<CNHNGLEEBKP>, IMessage, IEquatable<CNHNGLEEBKP>, IDeepCloneable<CNHNGLEEBKP>, IBufferMessage
{
	private static readonly MessageParser<CNHNGLEEBKP> _parser = new MessageParser<CNHNGLEEBKP>(() => new CNHNGLEEBKP());

	private UnknownFieldSet _unknownFields;

	public const int LGHOOKMNMCLFieldNumber = 1;

	private uint lGHOOKMNMCL_;

	public const int ExpFieldNumber = 8;

	private uint exp_;

	public const int LevelFieldNumber = 12;

	private uint level_;

	public const int MOOOPAMBOFKFieldNumber = 14;

	private uint mOOOPAMBOFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNHNGLEEBKP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNHNGLEEBKPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGHOOKMNMCL
	{
		get
		{
			return lGHOOKMNMCL_;
		}
		set
		{
			lGHOOKMNMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOOOPAMBOFK
	{
		get
		{
			return mOOOPAMBOFK_;
		}
		set
		{
			mOOOPAMBOFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNHNGLEEBKP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNHNGLEEBKP(CNHNGLEEBKP other)
		: this()
	{
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		exp_ = other.exp_;
		level_ = other.level_;
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNHNGLEEBKP Clone()
	{
		return new CNHNGLEEBKP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNHNGLEEBKP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNHNGLEEBKP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LGHOOKMNMCL != other.LGHOOKMNMCL)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (MOOOPAMBOFK != other.MOOOPAMBOFK)
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
		if (LGHOOKMNMCL != 0)
		{
			num ^= LGHOOKMNMCL.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
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
		if (LGHOOKMNMCL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LGHOOKMNMCL);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Exp);
		}
		if (Level != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Level);
		}
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MOOOPAMBOFK);
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
		if (LGHOOKMNMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGHOOKMNMCL);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNHNGLEEBKP other)
	{
		if (other != null)
		{
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
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
				LGHOOKMNMCL = input.ReadUInt32();
				break;
			case 64u:
				Exp = input.ReadUInt32();
				break;
			case 96u:
				Level = input.ReadUInt32();
				break;
			case 112u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			}
		}
	}
}
