using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NECGMCGFANN : IMessage<NECGMCGFANN>, IMessage, IEquatable<NECGMCGFANN>, IDeepCloneable<NECGMCGFANN>, IBufferMessage
{
	private static readonly MessageParser<NECGMCGFANN> _parser = new MessageParser<NECGMCGFANN>(() => new NECGMCGFANN());

	private UnknownFieldSet _unknownFields;

	public const int INAHILAHIIJFieldNumber = 1;

	private bool iNAHILAHIIJ_;

	public const int LDHNPCIMLCJFieldNumber = 2;

	private bool lDHNPCIMLCJ_;

	public const int FCNGHNPFJLNFieldNumber = 3;

	private bool fCNGHNPFJLN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NECGMCGFANN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NECGMCGFANNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool INAHILAHIIJ
	{
		get
		{
			return iNAHILAHIIJ_;
		}
		set
		{
			iNAHILAHIIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LDHNPCIMLCJ
	{
		get
		{
			return lDHNPCIMLCJ_;
		}
		set
		{
			lDHNPCIMLCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FCNGHNPFJLN
	{
		get
		{
			return fCNGHNPFJLN_;
		}
		set
		{
			fCNGHNPFJLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NECGMCGFANN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NECGMCGFANN(NECGMCGFANN other)
		: this()
	{
		iNAHILAHIIJ_ = other.iNAHILAHIIJ_;
		lDHNPCIMLCJ_ = other.lDHNPCIMLCJ_;
		fCNGHNPFJLN_ = other.fCNGHNPFJLN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NECGMCGFANN Clone()
	{
		return new NECGMCGFANN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NECGMCGFANN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NECGMCGFANN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (INAHILAHIIJ != other.INAHILAHIIJ)
		{
			return false;
		}
		if (LDHNPCIMLCJ != other.LDHNPCIMLCJ)
		{
			return false;
		}
		if (FCNGHNPFJLN != other.FCNGHNPFJLN)
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
		if (INAHILAHIIJ)
		{
			num ^= INAHILAHIIJ.GetHashCode();
		}
		if (LDHNPCIMLCJ)
		{
			num ^= LDHNPCIMLCJ.GetHashCode();
		}
		if (FCNGHNPFJLN)
		{
			num ^= FCNGHNPFJLN.GetHashCode();
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
		if (INAHILAHIIJ)
		{
			output.WriteRawTag(8);
			output.WriteBool(INAHILAHIIJ);
		}
		if (LDHNPCIMLCJ)
		{
			output.WriteRawTag(16);
			output.WriteBool(LDHNPCIMLCJ);
		}
		if (FCNGHNPFJLN)
		{
			output.WriteRawTag(24);
			output.WriteBool(FCNGHNPFJLN);
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
		if (INAHILAHIIJ)
		{
			num += 2;
		}
		if (LDHNPCIMLCJ)
		{
			num += 2;
		}
		if (FCNGHNPFJLN)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NECGMCGFANN other)
	{
		if (other != null)
		{
			if (other.INAHILAHIIJ)
			{
				INAHILAHIIJ = other.INAHILAHIIJ;
			}
			if (other.LDHNPCIMLCJ)
			{
				LDHNPCIMLCJ = other.LDHNPCIMLCJ;
			}
			if (other.FCNGHNPFJLN)
			{
				FCNGHNPFJLN = other.FCNGHNPFJLN;
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
				INAHILAHIIJ = input.ReadBool();
				break;
			case 16u:
				LDHNPCIMLCJ = input.ReadBool();
				break;
			case 24u:
				FCNGHNPFJLN = input.ReadBool();
				break;
			}
		}
	}
}
