using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DCLIFPOFFLI : IMessage<DCLIFPOFFLI>, IMessage, IEquatable<DCLIFPOFFLI>, IDeepCloneable<DCLIFPOFFLI>, IBufferMessage
{
	private static readonly MessageParser<DCLIFPOFFLI> _parser = new MessageParser<DCLIFPOFFLI>(() => new DCLIFPOFFLI());

	private UnknownFieldSet _unknownFields;

	public const int HMIBJHDMLNBFieldNumber = 2;

	private uint hMIBJHDMLNB_;

	public const int PPNHNDEOOLJFieldNumber = 3;

	private ulong pPNHNDEOOLJ_;

	public const int NFPBAKBCCHGFieldNumber = 4;

	private uint nFPBAKBCCHG_;

	public const int NEBGNOFPAGEFieldNumber = 14;

	private static readonly FieldCodec<PHHKNAADBHA> _repeated_nEBGNOFPAGE_codec = FieldCodec.ForMessage(114u, PHHKNAADBHA.Parser);

	private readonly RepeatedField<PHHKNAADBHA> nEBGNOFPAGE_ = new RepeatedField<PHHKNAADBHA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DCLIFPOFFLI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DCLIFPOFFLIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HMIBJHDMLNB
	{
		get
		{
			return hMIBJHDMLNB_;
		}
		set
		{
			hMIBJHDMLNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PPNHNDEOOLJ
	{
		get
		{
			return pPNHNDEOOLJ_;
		}
		set
		{
			pPNHNDEOOLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFPBAKBCCHG
	{
		get
		{
			return nFPBAKBCCHG_;
		}
		set
		{
			nFPBAKBCCHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PHHKNAADBHA> NEBGNOFPAGE => nEBGNOFPAGE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCLIFPOFFLI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCLIFPOFFLI(DCLIFPOFFLI other)
		: this()
	{
		hMIBJHDMLNB_ = other.hMIBJHDMLNB_;
		pPNHNDEOOLJ_ = other.pPNHNDEOOLJ_;
		nFPBAKBCCHG_ = other.nFPBAKBCCHG_;
		nEBGNOFPAGE_ = other.nEBGNOFPAGE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCLIFPOFFLI Clone()
	{
		return new DCLIFPOFFLI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DCLIFPOFFLI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DCLIFPOFFLI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HMIBJHDMLNB != other.HMIBJHDMLNB)
		{
			return false;
		}
		if (PPNHNDEOOLJ != other.PPNHNDEOOLJ)
		{
			return false;
		}
		if (NFPBAKBCCHG != other.NFPBAKBCCHG)
		{
			return false;
		}
		if (!nEBGNOFPAGE_.Equals(other.nEBGNOFPAGE_))
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
		if (HMIBJHDMLNB != 0)
		{
			num ^= HMIBJHDMLNB.GetHashCode();
		}
		if (PPNHNDEOOLJ != 0L)
		{
			num ^= PPNHNDEOOLJ.GetHashCode();
		}
		if (NFPBAKBCCHG != 0)
		{
			num ^= NFPBAKBCCHG.GetHashCode();
		}
		num ^= nEBGNOFPAGE_.GetHashCode();
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
		if (HMIBJHDMLNB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HMIBJHDMLNB);
		}
		if (PPNHNDEOOLJ != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(PPNHNDEOOLJ);
		}
		if (NFPBAKBCCHG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NFPBAKBCCHG);
		}
		nEBGNOFPAGE_.WriteTo(ref output, _repeated_nEBGNOFPAGE_codec);
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
		if (HMIBJHDMLNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HMIBJHDMLNB);
		}
		if (PPNHNDEOOLJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PPNHNDEOOLJ);
		}
		if (NFPBAKBCCHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFPBAKBCCHG);
		}
		num += nEBGNOFPAGE_.CalculateSize(_repeated_nEBGNOFPAGE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DCLIFPOFFLI other)
	{
		if (other != null)
		{
			if (other.HMIBJHDMLNB != 0)
			{
				HMIBJHDMLNB = other.HMIBJHDMLNB;
			}
			if (other.PPNHNDEOOLJ != 0L)
			{
				PPNHNDEOOLJ = other.PPNHNDEOOLJ;
			}
			if (other.NFPBAKBCCHG != 0)
			{
				NFPBAKBCCHG = other.NFPBAKBCCHG;
			}
			nEBGNOFPAGE_.Add(other.nEBGNOFPAGE_);
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
				HMIBJHDMLNB = input.ReadUInt32();
				break;
			case 24u:
				PPNHNDEOOLJ = input.ReadUInt64();
				break;
			case 32u:
				NFPBAKBCCHG = input.ReadUInt32();
				break;
			case 114u:
				nEBGNOFPAGE_.AddEntriesFrom(ref input, _repeated_nEBGNOFPAGE_codec);
				break;
			}
		}
	}
}
