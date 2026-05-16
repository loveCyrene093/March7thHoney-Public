using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMailCsReq : IMessage<GetMailCsReq>, IMessage, IEquatable<GetMailCsReq>, IDeepCloneable<GetMailCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetMailCsReq> _parser = new MessageParser<GetMailCsReq>(() => new GetMailCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FHGKLJEHIGAFieldNumber = 1;

	private uint fHGKLJEHIGA_;

	public const int DDLPGNHADCJFieldNumber = 6;

	private uint dDLPGNHADCJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMailCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMailCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHGKLJEHIGA
	{
		get
		{
			return fHGKLJEHIGA_;
		}
		set
		{
			fHGKLJEHIGA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDLPGNHADCJ
	{
		get
		{
			return dDLPGNHADCJ_;
		}
		set
		{
			dDLPGNHADCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMailCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMailCsReq(GetMailCsReq other)
		: this()
	{
		fHGKLJEHIGA_ = other.fHGKLJEHIGA_;
		dDLPGNHADCJ_ = other.dDLPGNHADCJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMailCsReq Clone()
	{
		return new GetMailCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMailCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMailCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FHGKLJEHIGA != other.FHGKLJEHIGA)
		{
			return false;
		}
		if (DDLPGNHADCJ != other.DDLPGNHADCJ)
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
		if (FHGKLJEHIGA != 0)
		{
			num ^= FHGKLJEHIGA.GetHashCode();
		}
		if (DDLPGNHADCJ != 0)
		{
			num ^= DDLPGNHADCJ.GetHashCode();
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
		if (FHGKLJEHIGA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FHGKLJEHIGA);
		}
		if (DDLPGNHADCJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DDLPGNHADCJ);
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
		if (FHGKLJEHIGA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHGKLJEHIGA);
		}
		if (DDLPGNHADCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDLPGNHADCJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMailCsReq other)
	{
		if (other != null)
		{
			if (other.FHGKLJEHIGA != 0)
			{
				FHGKLJEHIGA = other.FHGKLJEHIGA;
			}
			if (other.DDLPGNHADCJ != 0)
			{
				DDLPGNHADCJ = other.DDLPGNHADCJ;
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
				FHGKLJEHIGA = input.ReadUInt32();
				break;
			case 48u:
				DDLPGNHADCJ = input.ReadUInt32();
				break;
			}
		}
	}
}
