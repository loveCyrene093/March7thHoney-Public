using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NAKPLIGJELP : IMessage<NAKPLIGJELP>, IMessage, IEquatable<NAKPLIGJELP>, IDeepCloneable<NAKPLIGJELP>, IBufferMessage
{
	private static readonly MessageParser<NAKPLIGJELP> _parser = new MessageParser<NAKPLIGJELP>(() => new NAKPLIGJELP());

	private UnknownFieldSet _unknownFields;

	public const int KBFDOPNODBLFieldNumber = 9;

	private uint kBFDOPNODBL_;

	public const int BPCEACCENPNFieldNumber = 13;

	private uint bPCEACCENPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NAKPLIGJELP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NAKPLIGJELPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBFDOPNODBL
	{
		get
		{
			return kBFDOPNODBL_;
		}
		set
		{
			kBFDOPNODBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BPCEACCENPN
	{
		get
		{
			return bPCEACCENPN_;
		}
		set
		{
			bPCEACCENPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKPLIGJELP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKPLIGJELP(NAKPLIGJELP other)
		: this()
	{
		kBFDOPNODBL_ = other.kBFDOPNODBL_;
		bPCEACCENPN_ = other.bPCEACCENPN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKPLIGJELP Clone()
	{
		return new NAKPLIGJELP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NAKPLIGJELP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NAKPLIGJELP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBFDOPNODBL != other.KBFDOPNODBL)
		{
			return false;
		}
		if (BPCEACCENPN != other.BPCEACCENPN)
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
		if (KBFDOPNODBL != 0)
		{
			num ^= KBFDOPNODBL.GetHashCode();
		}
		if (BPCEACCENPN != 0)
		{
			num ^= BPCEACCENPN.GetHashCode();
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
		if (KBFDOPNODBL != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KBFDOPNODBL);
		}
		if (BPCEACCENPN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BPCEACCENPN);
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
		if (KBFDOPNODBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBFDOPNODBL);
		}
		if (BPCEACCENPN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BPCEACCENPN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NAKPLIGJELP other)
	{
		if (other != null)
		{
			if (other.KBFDOPNODBL != 0)
			{
				KBFDOPNODBL = other.KBFDOPNODBL;
			}
			if (other.BPCEACCENPN != 0)
			{
				BPCEACCENPN = other.BPCEACCENPN;
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
				KBFDOPNODBL = input.ReadUInt32();
				break;
			case 104u:
				BPCEACCENPN = input.ReadUInt32();
				break;
			}
		}
	}
}
