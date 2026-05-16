using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOAICPAMNDN : IMessage<DOAICPAMNDN>, IMessage, IEquatable<DOAICPAMNDN>, IDeepCloneable<DOAICPAMNDN>, IBufferMessage
{
	private static readonly MessageParser<DOAICPAMNDN> _parser = new MessageParser<DOAICPAMNDN>(() => new DOAICPAMNDN());

	private UnknownFieldSet _unknownFields;

	public const int DEPLLJPKKGDFieldNumber = 2;

	private static readonly FieldCodec<CKHDNJGMEJC> _repeated_dEPLLJPKKGD_codec = FieldCodec.ForMessage(18u, CKHDNJGMEJC.Parser);

	private readonly RepeatedField<CKHDNJGMEJC> dEPLLJPKKGD_ = new RepeatedField<CKHDNJGMEJC>();

	public const int ScoreIdFieldNumber = 3;

	private uint scoreId_;

	public const int FHKEMCLFBONFieldNumber = 4;

	private GDKPBDAAKBH fHKEMCLFBON_;

	public const int EPLBCNFMLILFieldNumber = 6;

	private uint ePLBCNFMLIL_;

	public const int NENPNDKMHOMFieldNumber = 8;

	private static readonly FieldCodec<KACOOFIKHOG> _repeated_nENPNDKMHOM_codec = FieldCodec.ForMessage(66u, KACOOFIKHOG.Parser);

	private readonly RepeatedField<KACOOFIKHOG> nENPNDKMHOM_ = new RepeatedField<KACOOFIKHOG>();

	public const int BHABGAPJAHFFieldNumber = 9;

	private static readonly FieldCodec<CIPBBPHGEKJ> _repeated_bHABGAPJAHF_codec = FieldCodec.ForMessage(74u, CIPBBPHGEKJ.Parser);

	private readonly RepeatedField<CIPBBPHGEKJ> bHABGAPJAHF_ = new RepeatedField<CIPBBPHGEKJ>();

	public const int FIHLNOJAKCHFieldNumber = 10;

	private uint fIHLNOJAKCH_;

	public const int BHDGPLPJKAAFieldNumber = 11;

	private static readonly FieldCodec<GPONAKNHLJG> _repeated_bHDGPLPJKAA_codec = FieldCodec.ForMessage(90u, GPONAKNHLJG.Parser);

	private readonly RepeatedField<GPONAKNHLJG> bHDGPLPJKAA_ = new RepeatedField<GPONAKNHLJG>();

	public const int DJEHDCCAJCKFieldNumber = 13;

	private PBNLKJIEFPM dJEHDCCAJCK_;

	public const int LJBHHIDILONFieldNumber = 14;

	private PONPHHDBEJJ lJBHHIDILON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOAICPAMNDN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOAICPAMNDNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CKHDNJGMEJC> DEPLLJPKKGD => dEPLLJPKKGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDKPBDAAKBH FHKEMCLFBON
	{
		get
		{
			return fHKEMCLFBON_;
		}
		set
		{
			fHKEMCLFBON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPLBCNFMLIL
	{
		get
		{
			return ePLBCNFMLIL_;
		}
		set
		{
			ePLBCNFMLIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KACOOFIKHOG> NENPNDKMHOM => nENPNDKMHOM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CIPBBPHGEKJ> BHABGAPJAHF => bHABGAPJAHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIHLNOJAKCH
	{
		get
		{
			return fIHLNOJAKCH_;
		}
		set
		{
			fIHLNOJAKCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GPONAKNHLJG> BHDGPLPJKAA => bHDGPLPJKAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBNLKJIEFPM DJEHDCCAJCK
	{
		get
		{
			return dJEHDCCAJCK_;
		}
		set
		{
			dJEHDCCAJCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PONPHHDBEJJ LJBHHIDILON
	{
		get
		{
			return lJBHHIDILON_;
		}
		set
		{
			lJBHHIDILON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOAICPAMNDN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOAICPAMNDN(DOAICPAMNDN other)
		: this()
	{
		dEPLLJPKKGD_ = other.dEPLLJPKKGD_.Clone();
		scoreId_ = other.scoreId_;
		fHKEMCLFBON_ = ((other.fHKEMCLFBON_ != null) ? other.fHKEMCLFBON_.Clone() : null);
		ePLBCNFMLIL_ = other.ePLBCNFMLIL_;
		nENPNDKMHOM_ = other.nENPNDKMHOM_.Clone();
		bHABGAPJAHF_ = other.bHABGAPJAHF_.Clone();
		fIHLNOJAKCH_ = other.fIHLNOJAKCH_;
		bHDGPLPJKAA_ = other.bHDGPLPJKAA_.Clone();
		dJEHDCCAJCK_ = ((other.dJEHDCCAJCK_ != null) ? other.dJEHDCCAJCK_.Clone() : null);
		lJBHHIDILON_ = other.lJBHHIDILON_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOAICPAMNDN Clone()
	{
		return new DOAICPAMNDN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOAICPAMNDN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOAICPAMNDN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEPLLJPKKGD_.Equals(other.dEPLLJPKKGD_))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!object.Equals(FHKEMCLFBON, other.FHKEMCLFBON))
		{
			return false;
		}
		if (EPLBCNFMLIL != other.EPLBCNFMLIL)
		{
			return false;
		}
		if (!nENPNDKMHOM_.Equals(other.nENPNDKMHOM_))
		{
			return false;
		}
		if (!bHABGAPJAHF_.Equals(other.bHABGAPJAHF_))
		{
			return false;
		}
		if (FIHLNOJAKCH != other.FIHLNOJAKCH)
		{
			return false;
		}
		if (!bHDGPLPJKAA_.Equals(other.bHDGPLPJKAA_))
		{
			return false;
		}
		if (!object.Equals(DJEHDCCAJCK, other.DJEHDCCAJCK))
		{
			return false;
		}
		if (LJBHHIDILON != other.LJBHHIDILON)
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
		num ^= dEPLLJPKKGD_.GetHashCode();
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (fHKEMCLFBON_ != null)
		{
			num ^= FHKEMCLFBON.GetHashCode();
		}
		if (EPLBCNFMLIL != 0)
		{
			num ^= EPLBCNFMLIL.GetHashCode();
		}
		num ^= nENPNDKMHOM_.GetHashCode();
		num ^= bHABGAPJAHF_.GetHashCode();
		if (FIHLNOJAKCH != 0)
		{
			num ^= FIHLNOJAKCH.GetHashCode();
		}
		num ^= bHDGPLPJKAA_.GetHashCode();
		if (dJEHDCCAJCK_ != null)
		{
			num ^= DJEHDCCAJCK.GetHashCode();
		}
		if (LJBHHIDILON != PONPHHDBEJJ.Oeglclnjkec)
		{
			num ^= LJBHHIDILON.GetHashCode();
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
		dEPLLJPKKGD_.WriteTo(ref output, _repeated_dEPLLJPKKGD_codec);
		if (ScoreId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ScoreId);
		}
		if (fHKEMCLFBON_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FHKEMCLFBON);
		}
		if (EPLBCNFMLIL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EPLBCNFMLIL);
		}
		nENPNDKMHOM_.WriteTo(ref output, _repeated_nENPNDKMHOM_codec);
		bHABGAPJAHF_.WriteTo(ref output, _repeated_bHABGAPJAHF_codec);
		if (FIHLNOJAKCH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FIHLNOJAKCH);
		}
		bHDGPLPJKAA_.WriteTo(ref output, _repeated_bHDGPLPJKAA_codec);
		if (dJEHDCCAJCK_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DJEHDCCAJCK);
		}
		if (LJBHHIDILON != PONPHHDBEJJ.Oeglclnjkec)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)LJBHHIDILON);
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
		num += dEPLLJPKKGD_.CalculateSize(_repeated_dEPLLJPKKGD_codec);
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (fHKEMCLFBON_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHKEMCLFBON);
		}
		if (EPLBCNFMLIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPLBCNFMLIL);
		}
		num += nENPNDKMHOM_.CalculateSize(_repeated_nENPNDKMHOM_codec);
		num += bHABGAPJAHF_.CalculateSize(_repeated_bHABGAPJAHF_codec);
		if (FIHLNOJAKCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIHLNOJAKCH);
		}
		num += bHDGPLPJKAA_.CalculateSize(_repeated_bHDGPLPJKAA_codec);
		if (dJEHDCCAJCK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DJEHDCCAJCK);
		}
		if (LJBHHIDILON != PONPHHDBEJJ.Oeglclnjkec)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LJBHHIDILON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOAICPAMNDN other)
	{
		if (other == null)
		{
			return;
		}
		dEPLLJPKKGD_.Add(other.dEPLLJPKKGD_);
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.fHKEMCLFBON_ != null)
		{
			if (fHKEMCLFBON_ == null)
			{
				FHKEMCLFBON = new GDKPBDAAKBH();
			}
			FHKEMCLFBON.MergeFrom(other.FHKEMCLFBON);
		}
		if (other.EPLBCNFMLIL != 0)
		{
			EPLBCNFMLIL = other.EPLBCNFMLIL;
		}
		nENPNDKMHOM_.Add(other.nENPNDKMHOM_);
		bHABGAPJAHF_.Add(other.bHABGAPJAHF_);
		if (other.FIHLNOJAKCH != 0)
		{
			FIHLNOJAKCH = other.FIHLNOJAKCH;
		}
		bHDGPLPJKAA_.Add(other.bHDGPLPJKAA_);
		if (other.dJEHDCCAJCK_ != null)
		{
			if (dJEHDCCAJCK_ == null)
			{
				DJEHDCCAJCK = new PBNLKJIEFPM();
			}
			DJEHDCCAJCK.MergeFrom(other.DJEHDCCAJCK);
		}
		if (other.LJBHHIDILON != PONPHHDBEJJ.Oeglclnjkec)
		{
			LJBHHIDILON = other.LJBHHIDILON;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				dEPLLJPKKGD_.AddEntriesFrom(ref input, _repeated_dEPLLJPKKGD_codec);
				break;
			case 24u:
				ScoreId = input.ReadUInt32();
				break;
			case 34u:
				if (fHKEMCLFBON_ == null)
				{
					FHKEMCLFBON = new GDKPBDAAKBH();
				}
				input.ReadMessage(FHKEMCLFBON);
				break;
			case 48u:
				EPLBCNFMLIL = input.ReadUInt32();
				break;
			case 66u:
				nENPNDKMHOM_.AddEntriesFrom(ref input, _repeated_nENPNDKMHOM_codec);
				break;
			case 74u:
				bHABGAPJAHF_.AddEntriesFrom(ref input, _repeated_bHABGAPJAHF_codec);
				break;
			case 80u:
				FIHLNOJAKCH = input.ReadUInt32();
				break;
			case 90u:
				bHDGPLPJKAA_.AddEntriesFrom(ref input, _repeated_bHDGPLPJKAA_codec);
				break;
			case 106u:
				if (dJEHDCCAJCK_ == null)
				{
					DJEHDCCAJCK = new PBNLKJIEFPM();
				}
				input.ReadMessage(DJEHDCCAJCK);
				break;
			case 112u:
				LJBHHIDILON = (PONPHHDBEJJ)input.ReadEnum();
				break;
			}
		}
	}
}
