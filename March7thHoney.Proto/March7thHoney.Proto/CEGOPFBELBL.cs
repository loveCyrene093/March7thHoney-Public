using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CEGOPFBELBL : IMessage<CEGOPFBELBL>, IMessage, IEquatable<CEGOPFBELBL>, IDeepCloneable<CEGOPFBELBL>, IBufferMessage
{
	private static readonly MessageParser<CEGOPFBELBL> _parser = new MessageParser<CEGOPFBELBL>(() => new CEGOPFBELBL());

	private UnknownFieldSet _unknownFields;

	public const int KKFBLJNMDFJFieldNumber = 7;

	private uint kKFBLJNMDFJ_;

	public const int PGKLOMAJMDCFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_pGKLOMAJMDC_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> pGKLOMAJMDC_ = new RepeatedField<uint>();

	public const int KBFDOPNODBLFieldNumber = 15;

	private uint kBFDOPNODBL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CEGOPFBELBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CEGOPFBELBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKFBLJNMDFJ
	{
		get
		{
			return kKFBLJNMDFJ_;
		}
		set
		{
			kKFBLJNMDFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PGKLOMAJMDC => pGKLOMAJMDC_;

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
	public CEGOPFBELBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEGOPFBELBL(CEGOPFBELBL other)
		: this()
	{
		kKFBLJNMDFJ_ = other.kKFBLJNMDFJ_;
		pGKLOMAJMDC_ = other.pGKLOMAJMDC_.Clone();
		kBFDOPNODBL_ = other.kBFDOPNODBL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEGOPFBELBL Clone()
	{
		return new CEGOPFBELBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CEGOPFBELBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CEGOPFBELBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKFBLJNMDFJ != other.KKFBLJNMDFJ)
		{
			return false;
		}
		if (!pGKLOMAJMDC_.Equals(other.pGKLOMAJMDC_))
		{
			return false;
		}
		if (KBFDOPNODBL != other.KBFDOPNODBL)
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
		if (KKFBLJNMDFJ != 0)
		{
			num ^= KKFBLJNMDFJ.GetHashCode();
		}
		num ^= pGKLOMAJMDC_.GetHashCode();
		if (KBFDOPNODBL != 0)
		{
			num ^= KBFDOPNODBL.GetHashCode();
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
		if (KKFBLJNMDFJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KKFBLJNMDFJ);
		}
		pGKLOMAJMDC_.WriteTo(ref output, _repeated_pGKLOMAJMDC_codec);
		if (KBFDOPNODBL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(KBFDOPNODBL);
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
		if (KKFBLJNMDFJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKFBLJNMDFJ);
		}
		num += pGKLOMAJMDC_.CalculateSize(_repeated_pGKLOMAJMDC_codec);
		if (KBFDOPNODBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBFDOPNODBL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CEGOPFBELBL other)
	{
		if (other != null)
		{
			if (other.KKFBLJNMDFJ != 0)
			{
				KKFBLJNMDFJ = other.KKFBLJNMDFJ;
			}
			pGKLOMAJMDC_.Add(other.pGKLOMAJMDC_);
			if (other.KBFDOPNODBL != 0)
			{
				KBFDOPNODBL = other.KBFDOPNODBL;
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
			case 56u:
				KKFBLJNMDFJ = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				pGKLOMAJMDC_.AddEntriesFrom(ref input, _repeated_pGKLOMAJMDC_codec);
				break;
			case 120u:
				KBFDOPNODBL = input.ReadUInt32();
				break;
			}
		}
	}
}
