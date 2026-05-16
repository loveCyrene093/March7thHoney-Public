using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GCIMMIHKPEI : IMessage<GCIMMIHKPEI>, IMessage, IEquatable<GCIMMIHKPEI>, IDeepCloneable<GCIMMIHKPEI>, IBufferMessage
{
	private static readonly MessageParser<GCIMMIHKPEI> _parser = new MessageParser<GCIMMIHKPEI>(() => new GCIMMIHKPEI());

	private UnknownFieldSet _unknownFields;

	public const int JIKKNNOGMDBFieldNumber = 1;

	private static readonly FieldCodec<GLENEKHDKLJ> _repeated_jIKKNNOGMDB_codec = FieldCodec.ForMessage(10u, GLENEKHDKLJ.Parser);

	private readonly RepeatedField<GLENEKHDKLJ> jIKKNNOGMDB_ = new RepeatedField<GLENEKHDKLJ>();

	public const int BMHAFFGJEJKFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_bMHAFFGJEJK_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> bMHAFFGJEJK_ = new RepeatedField<uint>();

	public const int PEBIBEMBNFAFieldNumber = 8;

	private ChessRogueNousDicePhase pEBIBEMBNFA_;

	public const int BNLMPIEEEIMFieldNumber = 12;

	private static readonly MapField<uint, bool>.Codec _map_bNLMPIEEEIM_codec = new MapField<uint, bool>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForBool(16u, defaultValue: false), 98u);

	private readonly MapField<uint, bool> bNLMPIEEEIM_ = new MapField<uint, bool>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GCIMMIHKPEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GCIMMIHKPEIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GLENEKHDKLJ> JIKKNNOGMDB => jIKKNNOGMDB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BMHAFFGJEJK => bMHAFFGJEJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousDicePhase PEBIBEMBNFA
	{
		get
		{
			return pEBIBEMBNFA_;
		}
		set
		{
			pEBIBEMBNFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, bool> BNLMPIEEEIM => bNLMPIEEEIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCIMMIHKPEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCIMMIHKPEI(GCIMMIHKPEI other)
		: this()
	{
		jIKKNNOGMDB_ = other.jIKKNNOGMDB_.Clone();
		bMHAFFGJEJK_ = other.bMHAFFGJEJK_.Clone();
		pEBIBEMBNFA_ = other.pEBIBEMBNFA_;
		bNLMPIEEEIM_ = other.bNLMPIEEEIM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCIMMIHKPEI Clone()
	{
		return new GCIMMIHKPEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GCIMMIHKPEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GCIMMIHKPEI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jIKKNNOGMDB_.Equals(other.jIKKNNOGMDB_))
		{
			return false;
		}
		if (!bMHAFFGJEJK_.Equals(other.bMHAFFGJEJK_))
		{
			return false;
		}
		if (PEBIBEMBNFA != other.PEBIBEMBNFA)
		{
			return false;
		}
		if (!BNLMPIEEEIM.Equals(other.BNLMPIEEEIM))
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
		num ^= jIKKNNOGMDB_.GetHashCode();
		num ^= bMHAFFGJEJK_.GetHashCode();
		if (PEBIBEMBNFA != ChessRogueNousDicePhase.FeppemmmgmmPcpdhelpkem)
		{
			num ^= PEBIBEMBNFA.GetHashCode();
		}
		num ^= BNLMPIEEEIM.GetHashCode();
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
		jIKKNNOGMDB_.WriteTo(ref output, _repeated_jIKKNNOGMDB_codec);
		bMHAFFGJEJK_.WriteTo(ref output, _repeated_bMHAFFGJEJK_codec);
		if (PEBIBEMBNFA != ChessRogueNousDicePhase.FeppemmmgmmPcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)PEBIBEMBNFA);
		}
		bNLMPIEEEIM_.WriteTo(ref output, _map_bNLMPIEEEIM_codec);
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
		num += jIKKNNOGMDB_.CalculateSize(_repeated_jIKKNNOGMDB_codec);
		num += bMHAFFGJEJK_.CalculateSize(_repeated_bMHAFFGJEJK_codec);
		if (PEBIBEMBNFA != ChessRogueNousDicePhase.FeppemmmgmmPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PEBIBEMBNFA);
		}
		num += bNLMPIEEEIM_.CalculateSize(_map_bNLMPIEEEIM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GCIMMIHKPEI other)
	{
		if (other != null)
		{
			jIKKNNOGMDB_.Add(other.jIKKNNOGMDB_);
			bMHAFFGJEJK_.Add(other.bMHAFFGJEJK_);
			if (other.PEBIBEMBNFA != ChessRogueNousDicePhase.FeppemmmgmmPcpdhelpkem)
			{
				PEBIBEMBNFA = other.PEBIBEMBNFA;
			}
			bNLMPIEEEIM_.MergeFrom(other.bNLMPIEEEIM_);
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
			case 10u:
				jIKKNNOGMDB_.AddEntriesFrom(ref input, _repeated_jIKKNNOGMDB_codec);
				break;
			case 48u:
			case 50u:
				bMHAFFGJEJK_.AddEntriesFrom(ref input, _repeated_bMHAFFGJEJK_codec);
				break;
			case 64u:
				PEBIBEMBNFA = (ChessRogueNousDicePhase)input.ReadEnum();
				break;
			case 98u:
				bNLMPIEEEIM_.AddEntriesFrom(ref input, _map_bNLMPIEEEIM_codec);
				break;
			}
		}
	}
}
