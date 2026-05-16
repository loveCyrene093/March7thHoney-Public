using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EENHHHMDHKH : IMessage<EENHHHMDHKH>, IMessage, IEquatable<EENHHHMDHKH>, IDeepCloneable<EENHHHMDHKH>, IBufferMessage
{
	private static readonly MessageParser<EENHHHMDHKH> _parser = new MessageParser<EENHHHMDHKH>(() => new EENHHHMDHKH());

	private UnknownFieldSet _unknownFields;

	public const int LFPCNONADHPFieldNumber = 2;

	private uint lFPCNONADHP_;

	public const int LKEMJDFAPAGFieldNumber = 9;

	private uint lKEMJDFAPAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EENHHHMDHKH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EENHHHMDHKHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFPCNONADHP
	{
		get
		{
			return lFPCNONADHP_;
		}
		set
		{
			lFPCNONADHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LKEMJDFAPAG
	{
		get
		{
			return lKEMJDFAPAG_;
		}
		set
		{
			lKEMJDFAPAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EENHHHMDHKH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EENHHHMDHKH(EENHHHMDHKH other)
		: this()
	{
		lFPCNONADHP_ = other.lFPCNONADHP_;
		lKEMJDFAPAG_ = other.lKEMJDFAPAG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EENHHHMDHKH Clone()
	{
		return new EENHHHMDHKH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EENHHHMDHKH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EENHHHMDHKH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LFPCNONADHP != other.LFPCNONADHP)
		{
			return false;
		}
		if (LKEMJDFAPAG != other.LKEMJDFAPAG)
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
		if (LFPCNONADHP != 0)
		{
			num ^= LFPCNONADHP.GetHashCode();
		}
		if (LKEMJDFAPAG != 0)
		{
			num ^= LKEMJDFAPAG.GetHashCode();
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
		if (LFPCNONADHP != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LFPCNONADHP);
		}
		if (LKEMJDFAPAG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LKEMJDFAPAG);
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
		if (LFPCNONADHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFPCNONADHP);
		}
		if (LKEMJDFAPAG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LKEMJDFAPAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EENHHHMDHKH other)
	{
		if (other != null)
		{
			if (other.LFPCNONADHP != 0)
			{
				LFPCNONADHP = other.LFPCNONADHP;
			}
			if (other.LKEMJDFAPAG != 0)
			{
				LKEMJDFAPAG = other.LKEMJDFAPAG;
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
				LFPCNONADHP = input.ReadUInt32();
				break;
			case 72u:
				LKEMJDFAPAG = input.ReadUInt32();
				break;
			}
		}
	}
}
