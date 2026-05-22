using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NAGEJMIGBBL : IMessage<NAGEJMIGBBL>, IMessage, IEquatable<NAGEJMIGBBL>, IDeepCloneable<NAGEJMIGBBL>, IBufferMessage
{
	private static readonly MessageParser<NAGEJMIGBBL> _parser = new MessageParser<NAGEJMIGBBL>(() => new NAGEJMIGBBL());

	private UnknownFieldSet _unknownFields;

	public const int CKGLFINODBLFieldNumber = 1;

	private uint cKGLFINODBL_;

	public const int DENMMFJDCEDFieldNumber = 2;

	private uint dENMMFJDCED_;

	public const int LFDDHBALMGNFieldNumber = 3;

	private static readonly FieldCodec<JCPPEBGEKHC> _repeated_lFDDHBALMGN_codec = FieldCodec.ForMessage(26u, JCPPEBGEKHC.Parser);

	private readonly RepeatedField<JCPPEBGEKHC> lFDDHBALMGN_ = new RepeatedField<JCPPEBGEKHC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NAGEJMIGBBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NAGEJMIGBBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CKGLFINODBL
	{
		get
		{
			return cKGLFINODBL_;
		}
		set
		{
			cKGLFINODBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DENMMFJDCED
	{
		get
		{
			return dENMMFJDCED_;
		}
		set
		{
			dENMMFJDCED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCPPEBGEKHC> LFDDHBALMGN => lFDDHBALMGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAGEJMIGBBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAGEJMIGBBL(NAGEJMIGBBL other)
		: this()
	{
		cKGLFINODBL_ = other.cKGLFINODBL_;
		dENMMFJDCED_ = other.dENMMFJDCED_;
		lFDDHBALMGN_ = other.lFDDHBALMGN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAGEJMIGBBL Clone()
	{
		return new NAGEJMIGBBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NAGEJMIGBBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NAGEJMIGBBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CKGLFINODBL != other.CKGLFINODBL)
		{
			return false;
		}
		if (DENMMFJDCED != other.DENMMFJDCED)
		{
			return false;
		}
		if (!lFDDHBALMGN_.Equals(other.lFDDHBALMGN_))
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
		if (CKGLFINODBL != 0)
		{
			num ^= CKGLFINODBL.GetHashCode();
		}
		if (DENMMFJDCED != 0)
		{
			num ^= DENMMFJDCED.GetHashCode();
		}
		num ^= lFDDHBALMGN_.GetHashCode();
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
		if (CKGLFINODBL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CKGLFINODBL);
		}
		if (DENMMFJDCED != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DENMMFJDCED);
		}
		lFDDHBALMGN_.WriteTo(ref output, _repeated_lFDDHBALMGN_codec);
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
		if (CKGLFINODBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CKGLFINODBL);
		}
		if (DENMMFJDCED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DENMMFJDCED);
		}
		num += lFDDHBALMGN_.CalculateSize(_repeated_lFDDHBALMGN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NAGEJMIGBBL other)
	{
		if (other != null)
		{
			if (other.CKGLFINODBL != 0)
			{
				CKGLFINODBL = other.CKGLFINODBL;
			}
			if (other.DENMMFJDCED != 0)
			{
				DENMMFJDCED = other.DENMMFJDCED;
			}
			lFDDHBALMGN_.Add(other.lFDDHBALMGN_);
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
				CKGLFINODBL = input.ReadUInt32();
				break;
			case 16u:
				DENMMFJDCED = input.ReadUInt32();
				break;
			case 26u:
				lFDDHBALMGN_.AddEntriesFrom(ref input, _repeated_lFDDHBALMGN_codec);
				break;
			}
		}
	}
}
