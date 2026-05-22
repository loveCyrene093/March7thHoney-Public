using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDoFinalRoundScRsp : IMessage<ChimeraDoFinalRoundScRsp>, IMessage, IEquatable<ChimeraDoFinalRoundScRsp>, IDeepCloneable<ChimeraDoFinalRoundScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDoFinalRoundScRsp> _parser = new MessageParser<ChimeraDoFinalRoundScRsp>(() => new ChimeraDoFinalRoundScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HMABMKKKHNBFieldNumber = 2;

	private static readonly FieldCodec<LHEDJAIOHOE> _repeated_hMABMKKKHNB_codec = FieldCodec.ForMessage(18u, LHEDJAIOHOE.Parser);

	private readonly RepeatedField<LHEDJAIOHOE> hMABMKKKHNB_ = new RepeatedField<LHEDJAIOHOE>();

	public const int OIPLJJIODILFieldNumber = 3;

	private bool oIPLJJIODIL_;

	public const int IndexFieldNumber = 4;

	private uint index_;

	public const int IFNODKPGBJKFieldNumber = 6;

	private static readonly FieldCodec<LEHNHDLEMHL> _repeated_iFNODKPGBJK_codec = FieldCodec.ForMessage(50u, LEHNHDLEMHL.Parser);

	private readonly RepeatedField<LEHNHDLEMHL> iFNODKPGBJK_ = new RepeatedField<LEHNHDLEMHL>();

	public const int NCBPOOCCCANFieldNumber = 7;

	private uint nCBPOOCCCAN_;

	public const int NKBDDIDFPNEFieldNumber = 10;

	private uint nKBDDIDFPNE_;

	public const int NJDBIEMAOAAFieldNumber = 12;

	private uint nJDBIEMAOAA_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int ACJJCPCPFDNFieldNumber = 14;

	private uint aCJJCPCPFDN_;

	public const int BMGAKKNAKFDFieldNumber = 15;

	private uint bMGAKKNAKFD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDoFinalRoundScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDoFinalRoundScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHEDJAIOHOE> HMABMKKKHNB => hMABMKKKHNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OIPLJJIODIL
	{
		get
		{
			return oIPLJJIODIL_;
		}
		set
		{
			oIPLJJIODIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LEHNHDLEMHL> IFNODKPGBJK => iFNODKPGBJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCBPOOCCCAN
	{
		get
		{
			return nCBPOOCCCAN_;
		}
		set
		{
			nCBPOOCCCAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NKBDDIDFPNE
	{
		get
		{
			return nKBDDIDFPNE_;
		}
		set
		{
			nKBDDIDFPNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJDBIEMAOAA
	{
		get
		{
			return nJDBIEMAOAA_;
		}
		set
		{
			nJDBIEMAOAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACJJCPCPFDN
	{
		get
		{
			return aCJJCPCPFDN_;
		}
		set
		{
			aCJJCPCPFDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BMGAKKNAKFD
	{
		get
		{
			return bMGAKKNAKFD_;
		}
		set
		{
			bMGAKKNAKFD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDoFinalRoundScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDoFinalRoundScRsp(ChimeraDoFinalRoundScRsp other)
		: this()
	{
		hMABMKKKHNB_ = other.hMABMKKKHNB_.Clone();
		oIPLJJIODIL_ = other.oIPLJJIODIL_;
		index_ = other.index_;
		iFNODKPGBJK_ = other.iFNODKPGBJK_.Clone();
		nCBPOOCCCAN_ = other.nCBPOOCCCAN_;
		nKBDDIDFPNE_ = other.nKBDDIDFPNE_;
		nJDBIEMAOAA_ = other.nJDBIEMAOAA_;
		retcode_ = other.retcode_;
		aCJJCPCPFDN_ = other.aCJJCPCPFDN_;
		bMGAKKNAKFD_ = other.bMGAKKNAKFD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDoFinalRoundScRsp Clone()
	{
		return new ChimeraDoFinalRoundScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDoFinalRoundScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDoFinalRoundScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hMABMKKKHNB_.Equals(other.hMABMKKKHNB_))
		{
			return false;
		}
		if (OIPLJJIODIL != other.OIPLJJIODIL)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (!iFNODKPGBJK_.Equals(other.iFNODKPGBJK_))
		{
			return false;
		}
		if (NCBPOOCCCAN != other.NCBPOOCCCAN)
		{
			return false;
		}
		if (NKBDDIDFPNE != other.NKBDDIDFPNE)
		{
			return false;
		}
		if (NJDBIEMAOAA != other.NJDBIEMAOAA)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ACJJCPCPFDN != other.ACJJCPCPFDN)
		{
			return false;
		}
		if (BMGAKKNAKFD != other.BMGAKKNAKFD)
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
		num ^= hMABMKKKHNB_.GetHashCode();
		if (OIPLJJIODIL)
		{
			num ^= OIPLJJIODIL.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		num ^= iFNODKPGBJK_.GetHashCode();
		if (NCBPOOCCCAN != 0)
		{
			num ^= NCBPOOCCCAN.GetHashCode();
		}
		if (NKBDDIDFPNE != 0)
		{
			num ^= NKBDDIDFPNE.GetHashCode();
		}
		if (NJDBIEMAOAA != 0)
		{
			num ^= NJDBIEMAOAA.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ACJJCPCPFDN != 0)
		{
			num ^= ACJJCPCPFDN.GetHashCode();
		}
		if (BMGAKKNAKFD != 0)
		{
			num ^= BMGAKKNAKFD.GetHashCode();
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
		hMABMKKKHNB_.WriteTo(ref output, _repeated_hMABMKKKHNB_codec);
		if (OIPLJJIODIL)
		{
			output.WriteRawTag(24);
			output.WriteBool(OIPLJJIODIL);
		}
		if (Index != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Index);
		}
		iFNODKPGBJK_.WriteTo(ref output, _repeated_iFNODKPGBJK_codec);
		if (NCBPOOCCCAN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NCBPOOCCCAN);
		}
		if (NKBDDIDFPNE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NKBDDIDFPNE);
		}
		if (NJDBIEMAOAA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NJDBIEMAOAA);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (ACJJCPCPFDN != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ACJJCPCPFDN);
		}
		if (BMGAKKNAKFD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BMGAKKNAKFD);
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
		num += hMABMKKKHNB_.CalculateSize(_repeated_hMABMKKKHNB_codec);
		if (OIPLJJIODIL)
		{
			num += 2;
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		num += iFNODKPGBJK_.CalculateSize(_repeated_iFNODKPGBJK_codec);
		if (NCBPOOCCCAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCBPOOCCCAN);
		}
		if (NKBDDIDFPNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKBDDIDFPNE);
		}
		if (NJDBIEMAOAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJDBIEMAOAA);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ACJJCPCPFDN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACJJCPCPFDN);
		}
		if (BMGAKKNAKFD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMGAKKNAKFD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDoFinalRoundScRsp other)
	{
		if (other != null)
		{
			hMABMKKKHNB_.Add(other.hMABMKKKHNB_);
			if (other.OIPLJJIODIL)
			{
				OIPLJJIODIL = other.OIPLJJIODIL;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			iFNODKPGBJK_.Add(other.iFNODKPGBJK_);
			if (other.NCBPOOCCCAN != 0)
			{
				NCBPOOCCCAN = other.NCBPOOCCCAN;
			}
			if (other.NKBDDIDFPNE != 0)
			{
				NKBDDIDFPNE = other.NKBDDIDFPNE;
			}
			if (other.NJDBIEMAOAA != 0)
			{
				NJDBIEMAOAA = other.NJDBIEMAOAA;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ACJJCPCPFDN != 0)
			{
				ACJJCPCPFDN = other.ACJJCPCPFDN;
			}
			if (other.BMGAKKNAKFD != 0)
			{
				BMGAKKNAKFD = other.BMGAKKNAKFD;
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
			case 18u:
				hMABMKKKHNB_.AddEntriesFrom(ref input, _repeated_hMABMKKKHNB_codec);
				break;
			case 24u:
				OIPLJJIODIL = input.ReadBool();
				break;
			case 32u:
				Index = input.ReadUInt32();
				break;
			case 50u:
				iFNODKPGBJK_.AddEntriesFrom(ref input, _repeated_iFNODKPGBJK_codec);
				break;
			case 56u:
				NCBPOOCCCAN = input.ReadUInt32();
				break;
			case 80u:
				NKBDDIDFPNE = input.ReadUInt32();
				break;
			case 96u:
				NJDBIEMAOAA = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				ACJJCPCPFDN = input.ReadUInt32();
				break;
			case 120u:
				BMGAKKNAKFD = input.ReadUInt32();
				break;
			}
		}
	}
}
