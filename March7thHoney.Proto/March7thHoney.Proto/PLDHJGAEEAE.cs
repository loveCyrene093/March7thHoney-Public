using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLDHJGAEEAE : IMessage<PLDHJGAEEAE>, IMessage, IEquatable<PLDHJGAEEAE>, IDeepCloneable<PLDHJGAEEAE>, IBufferMessage
{
	private static readonly MessageParser<PLDHJGAEEAE> _parser = new MessageParser<PLDHJGAEEAE>(() => new PLDHJGAEEAE());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 6;

	private uint type_;

	public const int EIFIHDFLBIDFieldNumber = 9;

	private uint eIFIHDFLBID_;

	public const int LHJEFNAFHGFFieldNumber = 12;

	private uint lHJEFNAFHGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLDHJGAEEAE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLDHJGAEEAEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIFIHDFLBID
	{
		get
		{
			return eIFIHDFLBID_;
		}
		set
		{
			eIFIHDFLBID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LHJEFNAFHGF
	{
		get
		{
			return lHJEFNAFHGF_;
		}
		set
		{
			lHJEFNAFHGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLDHJGAEEAE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLDHJGAEEAE(PLDHJGAEEAE other)
		: this()
	{
		type_ = other.type_;
		eIFIHDFLBID_ = other.eIFIHDFLBID_;
		lHJEFNAFHGF_ = other.lHJEFNAFHGF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLDHJGAEEAE Clone()
	{
		return new PLDHJGAEEAE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLDHJGAEEAE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLDHJGAEEAE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (EIFIHDFLBID != other.EIFIHDFLBID)
		{
			return false;
		}
		if (LHJEFNAFHGF != other.LHJEFNAFHGF)
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
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (EIFIHDFLBID != 0)
		{
			num ^= EIFIHDFLBID.GetHashCode();
		}
		if (LHJEFNAFHGF != 0)
		{
			num ^= LHJEFNAFHGF.GetHashCode();
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
		if (Type != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Type);
		}
		if (EIFIHDFLBID != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EIFIHDFLBID);
		}
		if (LHJEFNAFHGF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LHJEFNAFHGF);
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
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (EIFIHDFLBID != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIFIHDFLBID);
		}
		if (LHJEFNAFHGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LHJEFNAFHGF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLDHJGAEEAE other)
	{
		if (other != null)
		{
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.EIFIHDFLBID != 0)
			{
				EIFIHDFLBID = other.EIFIHDFLBID;
			}
			if (other.LHJEFNAFHGF != 0)
			{
				LHJEFNAFHGF = other.LHJEFNAFHGF;
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
			case 48u:
				Type = input.ReadUInt32();
				break;
			case 72u:
				EIFIHDFLBID = input.ReadUInt32();
				break;
			case 96u:
				LHJEFNAFHGF = input.ReadUInt32();
				break;
			}
		}
	}
}
