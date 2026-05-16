using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FAGCFBEBKEO : IMessage<FAGCFBEBKEO>, IMessage, IEquatable<FAGCFBEBKEO>, IDeepCloneable<FAGCFBEBKEO>, IBufferMessage
{
	private static readonly MessageParser<FAGCFBEBKEO> _parser = new MessageParser<FAGCFBEBKEO>(() => new FAGCFBEBKEO());

	private UnknownFieldSet _unknownFields;

	public const int PLKJCAMBAICFieldNumber = 1;

	private uint pLKJCAMBAIC_;

	public const int BKKEFFGGEFAFieldNumber = 2;

	private uint bKKEFFGGEFA_;

	public const int MBJCCKLNIBMFieldNumber = 3;

	private uint mBJCCKLNIBM_;

	public const int BLDEPELAIHMFieldNumber = 4;

	private uint bLDEPELAIHM_;

	public const int HEHMCANDKJKFieldNumber = 5;

	private uint hEHMCANDKJK_;

	public const int DGPPEAPLMPAFieldNumber = 6;

	private uint dGPPEAPLMPA_;

	public const int BossInfoFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_bossInfo_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> bossInfo_ = new RepeatedField<uint>();

	public const int KJFLCBDNLCFFieldNumber = 8;

	private static readonly FieldCodec<LOHKFKOOEIH> _repeated_kJFLCBDNLCF_codec = FieldCodec.ForMessage(66u, LOHKFKOOEIH.Parser);

	private readonly RepeatedField<LOHKFKOOEIH> kJFLCBDNLCF_ = new RepeatedField<LOHKFKOOEIH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FAGCFBEBKEO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FAGCFBEBKEOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PLKJCAMBAIC
	{
		get
		{
			return pLKJCAMBAIC_;
		}
		set
		{
			pLKJCAMBAIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKKEFFGGEFA
	{
		get
		{
			return bKKEFFGGEFA_;
		}
		set
		{
			bKKEFFGGEFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBJCCKLNIBM
	{
		get
		{
			return mBJCCKLNIBM_;
		}
		set
		{
			mBJCCKLNIBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BLDEPELAIHM
	{
		get
		{
			return bLDEPELAIHM_;
		}
		set
		{
			bLDEPELAIHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEHMCANDKJK
	{
		get
		{
			return hEHMCANDKJK_;
		}
		set
		{
			hEHMCANDKJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGPPEAPLMPA
	{
		get
		{
			return dGPPEAPLMPA_;
		}
		set
		{
			dGPPEAPLMPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BossInfo => bossInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LOHKFKOOEIH> KJFLCBDNLCF => kJFLCBDNLCF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAGCFBEBKEO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAGCFBEBKEO(FAGCFBEBKEO other)
		: this()
	{
		pLKJCAMBAIC_ = other.pLKJCAMBAIC_;
		bKKEFFGGEFA_ = other.bKKEFFGGEFA_;
		mBJCCKLNIBM_ = other.mBJCCKLNIBM_;
		bLDEPELAIHM_ = other.bLDEPELAIHM_;
		hEHMCANDKJK_ = other.hEHMCANDKJK_;
		dGPPEAPLMPA_ = other.dGPPEAPLMPA_;
		bossInfo_ = other.bossInfo_.Clone();
		kJFLCBDNLCF_ = other.kJFLCBDNLCF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAGCFBEBKEO Clone()
	{
		return new FAGCFBEBKEO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FAGCFBEBKEO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FAGCFBEBKEO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PLKJCAMBAIC != other.PLKJCAMBAIC)
		{
			return false;
		}
		if (BKKEFFGGEFA != other.BKKEFFGGEFA)
		{
			return false;
		}
		if (MBJCCKLNIBM != other.MBJCCKLNIBM)
		{
			return false;
		}
		if (BLDEPELAIHM != other.BLDEPELAIHM)
		{
			return false;
		}
		if (HEHMCANDKJK != other.HEHMCANDKJK)
		{
			return false;
		}
		if (DGPPEAPLMPA != other.DGPPEAPLMPA)
		{
			return false;
		}
		if (!bossInfo_.Equals(other.bossInfo_))
		{
			return false;
		}
		if (!kJFLCBDNLCF_.Equals(other.kJFLCBDNLCF_))
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
		if (PLKJCAMBAIC != 0)
		{
			num ^= PLKJCAMBAIC.GetHashCode();
		}
		if (BKKEFFGGEFA != 0)
		{
			num ^= BKKEFFGGEFA.GetHashCode();
		}
		if (MBJCCKLNIBM != 0)
		{
			num ^= MBJCCKLNIBM.GetHashCode();
		}
		if (BLDEPELAIHM != 0)
		{
			num ^= BLDEPELAIHM.GetHashCode();
		}
		if (HEHMCANDKJK != 0)
		{
			num ^= HEHMCANDKJK.GetHashCode();
		}
		if (DGPPEAPLMPA != 0)
		{
			num ^= DGPPEAPLMPA.GetHashCode();
		}
		num ^= bossInfo_.GetHashCode();
		num ^= kJFLCBDNLCF_.GetHashCode();
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
		if (PLKJCAMBAIC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PLKJCAMBAIC);
		}
		if (BKKEFFGGEFA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BKKEFFGGEFA);
		}
		if (MBJCCKLNIBM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MBJCCKLNIBM);
		}
		if (BLDEPELAIHM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BLDEPELAIHM);
		}
		if (HEHMCANDKJK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HEHMCANDKJK);
		}
		if (DGPPEAPLMPA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DGPPEAPLMPA);
		}
		bossInfo_.WriteTo(ref output, _repeated_bossInfo_codec);
		kJFLCBDNLCF_.WriteTo(ref output, _repeated_kJFLCBDNLCF_codec);
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
		if (PLKJCAMBAIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PLKJCAMBAIC);
		}
		if (BKKEFFGGEFA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKKEFFGGEFA);
		}
		if (MBJCCKLNIBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBJCCKLNIBM);
		}
		if (BLDEPELAIHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BLDEPELAIHM);
		}
		if (HEHMCANDKJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEHMCANDKJK);
		}
		if (DGPPEAPLMPA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGPPEAPLMPA);
		}
		num += bossInfo_.CalculateSize(_repeated_bossInfo_codec);
		num += kJFLCBDNLCF_.CalculateSize(_repeated_kJFLCBDNLCF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FAGCFBEBKEO other)
	{
		if (other != null)
		{
			if (other.PLKJCAMBAIC != 0)
			{
				PLKJCAMBAIC = other.PLKJCAMBAIC;
			}
			if (other.BKKEFFGGEFA != 0)
			{
				BKKEFFGGEFA = other.BKKEFFGGEFA;
			}
			if (other.MBJCCKLNIBM != 0)
			{
				MBJCCKLNIBM = other.MBJCCKLNIBM;
			}
			if (other.BLDEPELAIHM != 0)
			{
				BLDEPELAIHM = other.BLDEPELAIHM;
			}
			if (other.HEHMCANDKJK != 0)
			{
				HEHMCANDKJK = other.HEHMCANDKJK;
			}
			if (other.DGPPEAPLMPA != 0)
			{
				DGPPEAPLMPA = other.DGPPEAPLMPA;
			}
			bossInfo_.Add(other.bossInfo_);
			kJFLCBDNLCF_.Add(other.kJFLCBDNLCF_);
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
				PLKJCAMBAIC = input.ReadUInt32();
				break;
			case 16u:
				BKKEFFGGEFA = input.ReadUInt32();
				break;
			case 24u:
				MBJCCKLNIBM = input.ReadUInt32();
				break;
			case 32u:
				BLDEPELAIHM = input.ReadUInt32();
				break;
			case 40u:
				HEHMCANDKJK = input.ReadUInt32();
				break;
			case 48u:
				DGPPEAPLMPA = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				bossInfo_.AddEntriesFrom(ref input, _repeated_bossInfo_codec);
				break;
			case 66u:
				kJFLCBDNLCF_.AddEntriesFrom(ref input, _repeated_kJFLCBDNLCF_codec);
				break;
			}
		}
	}
}
