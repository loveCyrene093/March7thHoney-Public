using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEJGBJBLIEI : IMessage<OEJGBJBLIEI>, IMessage, IEquatable<OEJGBJBLIEI>, IDeepCloneable<OEJGBJBLIEI>, IBufferMessage
{
	private static readonly MessageParser<OEJGBJBLIEI> _parser = new MessageParser<OEJGBJBLIEI>(() => new OEJGBJBLIEI());

	private UnknownFieldSet _unknownFields;

	public const int DEIFKMPAFHKFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_dEIFKMPAFHK_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> dEIFKMPAFHK_ = new RepeatedField<uint>();

	public const int BFDJJAPDJOHFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_bFDJJAPDJOH_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> bFDJJAPDJOH_ = new RepeatedField<uint>();

	public const int BuffListFieldNumber = 7;

	private static readonly FieldCodec<FateBuffData> _repeated_buffList_codec = FieldCodec.ForMessage(58u, FateBuffData.Parser);

	private readonly RepeatedField<FateBuffData> buffList_ = new RepeatedField<FateBuffData>();

	public const int AAELPBLPFLJFieldNumber = 11;

	private static readonly MapField<uint, uint>.Codec _map_aAELPBLPFLJ_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 90u);

	private readonly MapField<uint, uint> aAELPBLPFLJ_ = new MapField<uint, uint>();

	public const int LPGAKJJFLJNFieldNumber = 12;

	private uint lPGAKJJFLJN_;

	public const int INPKEDEIBJNFieldNumber = 15;

	private static readonly FieldCodec<JDKAJMEPECF> _repeated_iNPKEDEIBJN_codec = FieldCodec.ForMessage(122u, JDKAJMEPECF.Parser);

	private readonly RepeatedField<JDKAJMEPECF> iNPKEDEIBJN_ = new RepeatedField<JDKAJMEPECF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEJGBJBLIEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEJGBJBLIEIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DEIFKMPAFHK => dEIFKMPAFHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BFDJJAPDJOH => bFDJJAPDJOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FateBuffData> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> AAELPBLPFLJ => aAELPBLPFLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPGAKJJFLJN
	{
		get
		{
			return lPGAKJJFLJN_;
		}
		set
		{
			lPGAKJJFLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JDKAJMEPECF> INPKEDEIBJN => iNPKEDEIBJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEJGBJBLIEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEJGBJBLIEI(OEJGBJBLIEI other)
		: this()
	{
		dEIFKMPAFHK_ = other.dEIFKMPAFHK_.Clone();
		bFDJJAPDJOH_ = other.bFDJJAPDJOH_.Clone();
		buffList_ = other.buffList_.Clone();
		aAELPBLPFLJ_ = other.aAELPBLPFLJ_.Clone();
		lPGAKJJFLJN_ = other.lPGAKJJFLJN_;
		iNPKEDEIBJN_ = other.iNPKEDEIBJN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEJGBJBLIEI Clone()
	{
		return new OEJGBJBLIEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEJGBJBLIEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEJGBJBLIEI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEIFKMPAFHK_.Equals(other.dEIFKMPAFHK_))
		{
			return false;
		}
		if (!bFDJJAPDJOH_.Equals(other.bFDJJAPDJOH_))
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (!AAELPBLPFLJ.Equals(other.AAELPBLPFLJ))
		{
			return false;
		}
		if (LPGAKJJFLJN != other.LPGAKJJFLJN)
		{
			return false;
		}
		if (!iNPKEDEIBJN_.Equals(other.iNPKEDEIBJN_))
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
		num ^= dEIFKMPAFHK_.GetHashCode();
		num ^= bFDJJAPDJOH_.GetHashCode();
		num ^= buffList_.GetHashCode();
		num ^= AAELPBLPFLJ.GetHashCode();
		if (LPGAKJJFLJN != 0)
		{
			num ^= LPGAKJJFLJN.GetHashCode();
		}
		num ^= iNPKEDEIBJN_.GetHashCode();
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
		dEIFKMPAFHK_.WriteTo(ref output, _repeated_dEIFKMPAFHK_codec);
		bFDJJAPDJOH_.WriteTo(ref output, _repeated_bFDJJAPDJOH_codec);
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		aAELPBLPFLJ_.WriteTo(ref output, _map_aAELPBLPFLJ_codec);
		if (LPGAKJJFLJN != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LPGAKJJFLJN);
		}
		iNPKEDEIBJN_.WriteTo(ref output, _repeated_iNPKEDEIBJN_codec);
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
		num += dEIFKMPAFHK_.CalculateSize(_repeated_dEIFKMPAFHK_codec);
		num += bFDJJAPDJOH_.CalculateSize(_repeated_bFDJJAPDJOH_codec);
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += aAELPBLPFLJ_.CalculateSize(_map_aAELPBLPFLJ_codec);
		if (LPGAKJJFLJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPGAKJJFLJN);
		}
		num += iNPKEDEIBJN_.CalculateSize(_repeated_iNPKEDEIBJN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OEJGBJBLIEI other)
	{
		if (other != null)
		{
			dEIFKMPAFHK_.Add(other.dEIFKMPAFHK_);
			bFDJJAPDJOH_.Add(other.bFDJJAPDJOH_);
			buffList_.Add(other.buffList_);
			aAELPBLPFLJ_.MergeFrom(other.aAELPBLPFLJ_);
			if (other.LPGAKJJFLJN != 0)
			{
				LPGAKJJFLJN = other.LPGAKJJFLJN;
			}
			iNPKEDEIBJN_.Add(other.iNPKEDEIBJN_);
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
			case 10u:
				dEIFKMPAFHK_.AddEntriesFrom(ref input, _repeated_dEIFKMPAFHK_codec);
				break;
			case 32u:
			case 34u:
				bFDJJAPDJOH_.AddEntriesFrom(ref input, _repeated_bFDJJAPDJOH_codec);
				break;
			case 58u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 90u:
				aAELPBLPFLJ_.AddEntriesFrom(ref input, _map_aAELPBLPFLJ_codec);
				break;
			case 96u:
				LPGAKJJFLJN = input.ReadUInt32();
				break;
			case 122u:
				iNPKEDEIBJN_.AddEntriesFrom(ref input, _repeated_iNPKEDEIBJN_codec);
				break;
			}
		}
	}
}
