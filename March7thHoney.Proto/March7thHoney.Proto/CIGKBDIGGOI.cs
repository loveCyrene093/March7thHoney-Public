using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIGKBDIGGOI : IMessage<CIGKBDIGGOI>, IMessage, IEquatable<CIGKBDIGGOI>, IDeepCloneable<CIGKBDIGGOI>, IBufferMessage
{
	private static readonly MessageParser<CIGKBDIGGOI> _parser = new MessageParser<CIGKBDIGGOI>(() => new CIGKBDIGGOI());

	private UnknownFieldSet _unknownFields;

	public const int GFBCMJMINGKFieldNumber = 8;

	private uint gFBCMJMINGK_;

	public const int IEMIMDJFMBFFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_iEMIMDJFMBF_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> iEMIMDJFMBF_ = new RepeatedField<uint>();

	public const int NPCCGNLNKNPFieldNumber = 11;

	private uint nPCCGNLNKNP_;

	public const int KLADGKBMNHNFieldNumber = 12;

	private uint kLADGKBMNHN_;

	public const int DGFGFAKNCKHFieldNumber = 14;

	private uint dGFGFAKNCKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIGKBDIGGOI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIGKBDIGGOIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFBCMJMINGK
	{
		get
		{
			return gFBCMJMINGK_;
		}
		set
		{
			gFBCMJMINGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IEMIMDJFMBF => iEMIMDJFMBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPCCGNLNKNP
	{
		get
		{
			return nPCCGNLNKNP_;
		}
		set
		{
			nPCCGNLNKNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLADGKBMNHN
	{
		get
		{
			return kLADGKBMNHN_;
		}
		set
		{
			kLADGKBMNHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGFGFAKNCKH
	{
		get
		{
			return dGFGFAKNCKH_;
		}
		set
		{
			dGFGFAKNCKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI(CIGKBDIGGOI other)
		: this()
	{
		gFBCMJMINGK_ = other.gFBCMJMINGK_;
		iEMIMDJFMBF_ = other.iEMIMDJFMBF_.Clone();
		nPCCGNLNKNP_ = other.nPCCGNLNKNP_;
		kLADGKBMNHN_ = other.kLADGKBMNHN_;
		dGFGFAKNCKH_ = other.dGFGFAKNCKH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI Clone()
	{
		return new CIGKBDIGGOI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIGKBDIGGOI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIGKBDIGGOI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GFBCMJMINGK != other.GFBCMJMINGK)
		{
			return false;
		}
		if (!iEMIMDJFMBF_.Equals(other.iEMIMDJFMBF_))
		{
			return false;
		}
		if (NPCCGNLNKNP != other.NPCCGNLNKNP)
		{
			return false;
		}
		if (KLADGKBMNHN != other.KLADGKBMNHN)
		{
			return false;
		}
		if (DGFGFAKNCKH != other.DGFGFAKNCKH)
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
		if (GFBCMJMINGK != 0)
		{
			num ^= GFBCMJMINGK.GetHashCode();
		}
		num ^= iEMIMDJFMBF_.GetHashCode();
		if (NPCCGNLNKNP != 0)
		{
			num ^= NPCCGNLNKNP.GetHashCode();
		}
		if (KLADGKBMNHN != 0)
		{
			num ^= KLADGKBMNHN.GetHashCode();
		}
		if (DGFGFAKNCKH != 0)
		{
			num ^= DGFGFAKNCKH.GetHashCode();
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
		if (GFBCMJMINGK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GFBCMJMINGK);
		}
		iEMIMDJFMBF_.WriteTo(ref output, _repeated_iEMIMDJFMBF_codec);
		if (NPCCGNLNKNP != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NPCCGNLNKNP);
		}
		if (KLADGKBMNHN != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KLADGKBMNHN);
		}
		if (DGFGFAKNCKH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DGFGFAKNCKH);
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
		if (GFBCMJMINGK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFBCMJMINGK);
		}
		num += iEMIMDJFMBF_.CalculateSize(_repeated_iEMIMDJFMBF_codec);
		if (NPCCGNLNKNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPCCGNLNKNP);
		}
		if (KLADGKBMNHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLADGKBMNHN);
		}
		if (DGFGFAKNCKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGFGFAKNCKH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIGKBDIGGOI other)
	{
		if (other != null)
		{
			if (other.GFBCMJMINGK != 0)
			{
				GFBCMJMINGK = other.GFBCMJMINGK;
			}
			iEMIMDJFMBF_.Add(other.iEMIMDJFMBF_);
			if (other.NPCCGNLNKNP != 0)
			{
				NPCCGNLNKNP = other.NPCCGNLNKNP;
			}
			if (other.KLADGKBMNHN != 0)
			{
				KLADGKBMNHN = other.KLADGKBMNHN;
			}
			if (other.DGFGFAKNCKH != 0)
			{
				DGFGFAKNCKH = other.DGFGFAKNCKH;
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
			case 64u:
				GFBCMJMINGK = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				iEMIMDJFMBF_.AddEntriesFrom(ref input, _repeated_iEMIMDJFMBF_codec);
				break;
			case 88u:
				NPCCGNLNKNP = input.ReadUInt32();
				break;
			case 96u:
				KLADGKBMNHN = input.ReadUInt32();
				break;
			case 112u:
				DGFGFAKNCKH = input.ReadUInt32();
				break;
			}
		}
	}
}
