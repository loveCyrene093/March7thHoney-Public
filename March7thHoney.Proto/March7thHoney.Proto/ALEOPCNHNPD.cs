using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ALEOPCNHNPD : IMessage<ALEOPCNHNPD>, IMessage, IEquatable<ALEOPCNHNPD>, IDeepCloneable<ALEOPCNHNPD>, IBufferMessage
{
	private static readonly MessageParser<ALEOPCNHNPD> _parser = new MessageParser<ALEOPCNHNPD>(() => new ALEOPCNHNPD());

	private UnknownFieldSet _unknownFields;

	public const int AAABOOFAFLJFieldNumber = 1;

	private uint aAABOOFAFLJ_;

	public const int FDMEFIIJLCKFieldNumber = 7;

	private uint fDMEFIIJLCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ALEOPCNHNPD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ALEOPCNHNPDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAABOOFAFLJ
	{
		get
		{
			return aAABOOFAFLJ_;
		}
		set
		{
			aAABOOFAFLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FDMEFIIJLCK
	{
		get
		{
			return fDMEFIIJLCK_;
		}
		set
		{
			fDMEFIIJLCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALEOPCNHNPD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALEOPCNHNPD(ALEOPCNHNPD other)
		: this()
	{
		aAABOOFAFLJ_ = other.aAABOOFAFLJ_;
		fDMEFIIJLCK_ = other.fDMEFIIJLCK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALEOPCNHNPD Clone()
	{
		return new ALEOPCNHNPD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ALEOPCNHNPD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ALEOPCNHNPD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AAABOOFAFLJ != other.AAABOOFAFLJ)
		{
			return false;
		}
		if (FDMEFIIJLCK != other.FDMEFIIJLCK)
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
		if (AAABOOFAFLJ != 0)
		{
			num ^= AAABOOFAFLJ.GetHashCode();
		}
		if (FDMEFIIJLCK != 0)
		{
			num ^= FDMEFIIJLCK.GetHashCode();
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
		if (AAABOOFAFLJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AAABOOFAFLJ);
		}
		if (FDMEFIIJLCK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FDMEFIIJLCK);
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
		if (AAABOOFAFLJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAABOOFAFLJ);
		}
		if (FDMEFIIJLCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FDMEFIIJLCK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ALEOPCNHNPD other)
	{
		if (other != null)
		{
			if (other.AAABOOFAFLJ != 0)
			{
				AAABOOFAFLJ = other.AAABOOFAFLJ;
			}
			if (other.FDMEFIIJLCK != 0)
			{
				FDMEFIIJLCK = other.FDMEFIIJLCK;
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
				AAABOOFAFLJ = input.ReadUInt32();
				break;
			case 56u:
				FDMEFIIJLCK = input.ReadUInt32();
				break;
			}
		}
	}
}
