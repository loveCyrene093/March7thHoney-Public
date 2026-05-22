using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNHPHDCJEKG : IMessage<CNHPHDCJEKG>, IMessage, IEquatable<CNHPHDCJEKG>, IDeepCloneable<CNHPHDCJEKG>, IBufferMessage
{
	private static readonly MessageParser<CNHPHDCJEKG> _parser = new MessageParser<CNHPHDCJEKG>(() => new CNHPHDCJEKG());

	private UnknownFieldSet _unknownFields;

	public const int CDKEDFPEFIJFieldNumber = 5;

	private uint cDKEDFPEFIJ_;

	public const int ACMGBNNEACJFieldNumber = 6;

	private bool aCMGBNNEACJ_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNHPHDCJEKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNHPHDCJEKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDKEDFPEFIJ
	{
		get
		{
			return cDKEDFPEFIJ_;
		}
		set
		{
			cDKEDFPEFIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ACMGBNNEACJ
	{
		get
		{
			return aCMGBNNEACJ_;
		}
		set
		{
			aCMGBNNEACJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNHPHDCJEKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNHPHDCJEKG(CNHPHDCJEKG other)
		: this()
	{
		cDKEDFPEFIJ_ = other.cDKEDFPEFIJ_;
		aCMGBNNEACJ_ = other.aCMGBNNEACJ_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNHPHDCJEKG Clone()
	{
		return new CNHPHDCJEKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNHPHDCJEKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNHPHDCJEKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CDKEDFPEFIJ != other.CDKEDFPEFIJ)
		{
			return false;
		}
		if (ACMGBNNEACJ != other.ACMGBNNEACJ)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (CDKEDFPEFIJ != 0)
		{
			num ^= CDKEDFPEFIJ.GetHashCode();
		}
		if (ACMGBNNEACJ)
		{
			num ^= ACMGBNNEACJ.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (CDKEDFPEFIJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CDKEDFPEFIJ);
		}
		if (ACMGBNNEACJ)
		{
			output.WriteRawTag(48);
			output.WriteBool(ACMGBNNEACJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
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
		if (CDKEDFPEFIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDKEDFPEFIJ);
		}
		if (ACMGBNNEACJ)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNHPHDCJEKG other)
	{
		if (other != null)
		{
			if (other.CDKEDFPEFIJ != 0)
			{
				CDKEDFPEFIJ = other.CDKEDFPEFIJ;
			}
			if (other.ACMGBNNEACJ)
			{
				ACMGBNNEACJ = other.ACMGBNNEACJ;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 40u:
				CDKEDFPEFIJ = input.ReadUInt32();
				break;
			case 48u:
				ACMGBNNEACJ = input.ReadBool();
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
