using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AKCFLPEANJB : IMessage<AKCFLPEANJB>, IMessage, IEquatable<AKCFLPEANJB>, IDeepCloneable<AKCFLPEANJB>, IBufferMessage
{
	private static readonly MessageParser<AKCFLPEANJB> _parser = new MessageParser<AKCFLPEANJB>(() => new AKCFLPEANJB());

	private UnknownFieldSet _unknownFields;

	public const int MEEPFKLLIJBFieldNumber = 3;

	private static readonly FieldCodec<FILKLBIIFNO> _repeated_mEEPFKLLIJB_codec = FieldCodec.ForMessage(26u, FILKLBIIFNO.Parser);

	private readonly RepeatedField<FILKLBIIFNO> mEEPFKLLIJB_ = new RepeatedField<FILKLBIIFNO>();

	public const int HDPINGEDMCMFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_hDPINGEDMCM_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> hDPINGEDMCM_ = new RepeatedField<uint>();

	public const int FPFIHHBNBANFieldNumber = 5;

	private uint fPFIHHBNBAN_;

	public const int OPCGJFMGEEHFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_oPCGJFMGEEH_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> oPCGJFMGEEH_ = new RepeatedField<uint>();

	public const int CHLKDEDPOBGFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_cHLKDEDPOBG_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> cHLKDEDPOBG_ = new RepeatedField<uint>();

	public const int GDNPJLLOHEEFieldNumber = 13;

	private uint gDNPJLLOHEE_;

	public const int FGFBHFJODJAFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_fGFBHFJODJA_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> fGFBHFJODJA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AKCFLPEANJB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AKCFLPEANJBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FILKLBIIFNO> MEEPFKLLIJB => mEEPFKLLIJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HDPINGEDMCM => hDPINGEDMCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPFIHHBNBAN
	{
		get
		{
			return fPFIHHBNBAN_;
		}
		set
		{
			fPFIHHBNBAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OPCGJFMGEEH => oPCGJFMGEEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CHLKDEDPOBG => cHLKDEDPOBG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDNPJLLOHEE
	{
		get
		{
			return gDNPJLLOHEE_;
		}
		set
		{
			gDNPJLLOHEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FGFBHFJODJA => fGFBHFJODJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKCFLPEANJB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKCFLPEANJB(AKCFLPEANJB other)
		: this()
	{
		mEEPFKLLIJB_ = other.mEEPFKLLIJB_.Clone();
		hDPINGEDMCM_ = other.hDPINGEDMCM_.Clone();
		fPFIHHBNBAN_ = other.fPFIHHBNBAN_;
		oPCGJFMGEEH_ = other.oPCGJFMGEEH_.Clone();
		cHLKDEDPOBG_ = other.cHLKDEDPOBG_.Clone();
		gDNPJLLOHEE_ = other.gDNPJLLOHEE_;
		fGFBHFJODJA_ = other.fGFBHFJODJA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKCFLPEANJB Clone()
	{
		return new AKCFLPEANJB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AKCFLPEANJB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AKCFLPEANJB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mEEPFKLLIJB_.Equals(other.mEEPFKLLIJB_))
		{
			return false;
		}
		if (!hDPINGEDMCM_.Equals(other.hDPINGEDMCM_))
		{
			return false;
		}
		if (FPFIHHBNBAN != other.FPFIHHBNBAN)
		{
			return false;
		}
		if (!oPCGJFMGEEH_.Equals(other.oPCGJFMGEEH_))
		{
			return false;
		}
		if (!cHLKDEDPOBG_.Equals(other.cHLKDEDPOBG_))
		{
			return false;
		}
		if (GDNPJLLOHEE != other.GDNPJLLOHEE)
		{
			return false;
		}
		if (!fGFBHFJODJA_.Equals(other.fGFBHFJODJA_))
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
		num ^= mEEPFKLLIJB_.GetHashCode();
		num ^= hDPINGEDMCM_.GetHashCode();
		if (FPFIHHBNBAN != 0)
		{
			num ^= FPFIHHBNBAN.GetHashCode();
		}
		num ^= oPCGJFMGEEH_.GetHashCode();
		num ^= cHLKDEDPOBG_.GetHashCode();
		if (GDNPJLLOHEE != 0)
		{
			num ^= GDNPJLLOHEE.GetHashCode();
		}
		num ^= fGFBHFJODJA_.GetHashCode();
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
		mEEPFKLLIJB_.WriteTo(ref output, _repeated_mEEPFKLLIJB_codec);
		hDPINGEDMCM_.WriteTo(ref output, _repeated_hDPINGEDMCM_codec);
		if (FPFIHHBNBAN != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FPFIHHBNBAN);
		}
		oPCGJFMGEEH_.WriteTo(ref output, _repeated_oPCGJFMGEEH_codec);
		cHLKDEDPOBG_.WriteTo(ref output, _repeated_cHLKDEDPOBG_codec);
		if (GDNPJLLOHEE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GDNPJLLOHEE);
		}
		fGFBHFJODJA_.WriteTo(ref output, _repeated_fGFBHFJODJA_codec);
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
		num += mEEPFKLLIJB_.CalculateSize(_repeated_mEEPFKLLIJB_codec);
		num += hDPINGEDMCM_.CalculateSize(_repeated_hDPINGEDMCM_codec);
		if (FPFIHHBNBAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPFIHHBNBAN);
		}
		num += oPCGJFMGEEH_.CalculateSize(_repeated_oPCGJFMGEEH_codec);
		num += cHLKDEDPOBG_.CalculateSize(_repeated_cHLKDEDPOBG_codec);
		if (GDNPJLLOHEE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDNPJLLOHEE);
		}
		num += fGFBHFJODJA_.CalculateSize(_repeated_fGFBHFJODJA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AKCFLPEANJB other)
	{
		if (other != null)
		{
			mEEPFKLLIJB_.Add(other.mEEPFKLLIJB_);
			hDPINGEDMCM_.Add(other.hDPINGEDMCM_);
			if (other.FPFIHHBNBAN != 0)
			{
				FPFIHHBNBAN = other.FPFIHHBNBAN;
			}
			oPCGJFMGEEH_.Add(other.oPCGJFMGEEH_);
			cHLKDEDPOBG_.Add(other.cHLKDEDPOBG_);
			if (other.GDNPJLLOHEE != 0)
			{
				GDNPJLLOHEE = other.GDNPJLLOHEE;
			}
			fGFBHFJODJA_.Add(other.fGFBHFJODJA_);
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
			case 26u:
				mEEPFKLLIJB_.AddEntriesFrom(ref input, _repeated_mEEPFKLLIJB_codec);
				break;
			case 32u:
			case 34u:
				hDPINGEDMCM_.AddEntriesFrom(ref input, _repeated_hDPINGEDMCM_codec);
				break;
			case 40u:
				FPFIHHBNBAN = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				oPCGJFMGEEH_.AddEntriesFrom(ref input, _repeated_oPCGJFMGEEH_codec);
				break;
			case 96u:
			case 98u:
				cHLKDEDPOBG_.AddEntriesFrom(ref input, _repeated_cHLKDEDPOBG_codec);
				break;
			case 104u:
				GDNPJLLOHEE = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				fGFBHFJODJA_.AddEntriesFrom(ref input, _repeated_fGFBHFJODJA_codec);
				break;
			}
		}
	}
}
