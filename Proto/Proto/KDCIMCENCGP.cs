using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KDCIMCENCGP : IMessage<KDCIMCENCGP>, IMessage, IEquatable<KDCIMCENCGP>, IDeepCloneable<KDCIMCENCGP>, IBufferMessage
{
	private static readonly MessageParser<KDCIMCENCGP> _parser = new MessageParser<KDCIMCENCGP>(() => new KDCIMCENCGP());

	private UnknownFieldSet _unknownFields;

	public const int LGHOOKMNMCLFieldNumber = 2;

	private uint lGHOOKMNMCL_;

	public const int LCDALEEEDJJFieldNumber = 13;

	private uint lCDALEEEDJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KDCIMCENCGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KDCIMCENCGPReflection.Descriptor.MessageTypes[0];

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
	public uint LCDALEEEDJJ
	{
		get
		{
			return lCDALEEEDJJ_;
		}
		set
		{
			lCDALEEEDJJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDCIMCENCGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDCIMCENCGP(KDCIMCENCGP other)
		: this()
	{
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		lCDALEEEDJJ_ = other.lCDALEEEDJJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDCIMCENCGP Clone()
	{
		return new KDCIMCENCGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KDCIMCENCGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KDCIMCENCGP other)
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
		if (LCDALEEEDJJ != other.LCDALEEEDJJ)
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
		if (LCDALEEEDJJ != 0)
		{
			num ^= LCDALEEEDJJ.GetHashCode();
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
			output.WriteRawTag(16);
			output.WriteUInt32(LGHOOKMNMCL);
		}
		if (LCDALEEEDJJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LCDALEEEDJJ);
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
		if (LCDALEEEDJJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCDALEEEDJJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KDCIMCENCGP other)
	{
		if (other != null)
		{
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
			}
			if (other.LCDALEEEDJJ != 0)
			{
				LCDALEEEDJJ = other.LCDALEEEDJJ;
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
			case 16u:
				LGHOOKMNMCL = input.ReadUInt32();
				break;
			case 104u:
				LCDALEEEDJJ = input.ReadUInt32();
				break;
			}
		}
	}
}
