using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NMBGLKALLBM : IMessage<NMBGLKALLBM>, IMessage, IEquatable<NMBGLKALLBM>, IDeepCloneable<NMBGLKALLBM>, IBufferMessage
{
	private static readonly MessageParser<NMBGLKALLBM> _parser = new MessageParser<NMBGLKALLBM>(() => new NMBGLKALLBM());

	private UnknownFieldSet _unknownFields;

	public const int LMLFOELDMJDFieldNumber = 1;

	private KGFMBNIIPPA lMLFOELDMJD_;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int NIIKHEBEDIGFieldNumber = 3;

	private ItemList nIIKHEBEDIG_;

	public const int FMPNNHDPGKDFieldNumber = 5;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_fMPNNHDPGKD_codec = FieldCodec.ForMessage(42u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> fMPNNHDPGKD_ = new RepeatedField<GKDEKJKOIJN>();

	public const int EKFCLEJNGKEFieldNumber = 6;

	private ItemList eKFCLEJNGKE_;

	public const int HEOEKAPBNIEFieldNumber = 7;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_hEOEKAPBNIE_codec = FieldCodec.ForMessage(58u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> hEOEKAPBNIE_ = new RepeatedField<GKDEKJKOIJN>();

	public const int RewardFieldNumber = 10;

	private ItemList reward_;

	public const int MEKLIBAPGONFieldNumber = 14;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_mEKLIBAPGON_codec = FieldCodec.ForMessage(114u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> mEKLIBAPGON_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NMBGLKALLBM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NMBGLKALLBMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGFMBNIIPPA LMLFOELDMJD
	{
		get
		{
			return lMLFOELDMJD_;
		}
		set
		{
			lMLFOELDMJD_ = value;
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
	public ItemList NIIKHEBEDIG
	{
		get
		{
			return nIIKHEBEDIG_;
		}
		set
		{
			nIIKHEBEDIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> FMPNNHDPGKD => fMPNNHDPGKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList EKFCLEJNGKE
	{
		get
		{
			return eKFCLEJNGKE_;
		}
		set
		{
			eKFCLEJNGKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> HEOEKAPBNIE => hEOEKAPBNIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> MEKLIBAPGON => mEKLIBAPGON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMBGLKALLBM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMBGLKALLBM(NMBGLKALLBM other)
		: this()
	{
		lMLFOELDMJD_ = other.lMLFOELDMJD_;
		retcode_ = other.retcode_;
		nIIKHEBEDIG_ = ((other.nIIKHEBEDIG_ != null) ? other.nIIKHEBEDIG_.Clone() : null);
		fMPNNHDPGKD_ = other.fMPNNHDPGKD_.Clone();
		eKFCLEJNGKE_ = ((other.eKFCLEJNGKE_ != null) ? other.eKFCLEJNGKE_.Clone() : null);
		hEOEKAPBNIE_ = other.hEOEKAPBNIE_.Clone();
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		mEKLIBAPGON_ = other.mEKLIBAPGON_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMBGLKALLBM Clone()
	{
		return new NMBGLKALLBM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NMBGLKALLBM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NMBGLKALLBM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LMLFOELDMJD != other.LMLFOELDMJD)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(NIIKHEBEDIG, other.NIIKHEBEDIG))
		{
			return false;
		}
		if (!fMPNNHDPGKD_.Equals(other.fMPNNHDPGKD_))
		{
			return false;
		}
		if (!object.Equals(EKFCLEJNGKE, other.EKFCLEJNGKE))
		{
			return false;
		}
		if (!hEOEKAPBNIE_.Equals(other.hEOEKAPBNIE_))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (!mEKLIBAPGON_.Equals(other.mEKLIBAPGON_))
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
		if (LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			num ^= LMLFOELDMJD.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (nIIKHEBEDIG_ != null)
		{
			num ^= NIIKHEBEDIG.GetHashCode();
		}
		num ^= fMPNNHDPGKD_.GetHashCode();
		if (eKFCLEJNGKE_ != null)
		{
			num ^= EKFCLEJNGKE.GetHashCode();
		}
		num ^= hEOEKAPBNIE_.GetHashCode();
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		num ^= mEKLIBAPGON_.GetHashCode();
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
		if (LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)LMLFOELDMJD);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (nIIKHEBEDIG_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NIIKHEBEDIG);
		}
		fMPNNHDPGKD_.WriteTo(ref output, _repeated_fMPNNHDPGKD_codec);
		if (eKFCLEJNGKE_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EKFCLEJNGKE);
		}
		hEOEKAPBNIE_.WriteTo(ref output, _repeated_hEOEKAPBNIE_codec);
		if (reward_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Reward);
		}
		mEKLIBAPGON_.WriteTo(ref output, _repeated_mEKLIBAPGON_codec);
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
		if (LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LMLFOELDMJD);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (nIIKHEBEDIG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NIIKHEBEDIG);
		}
		num += fMPNNHDPGKD_.CalculateSize(_repeated_fMPNNHDPGKD_codec);
		if (eKFCLEJNGKE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EKFCLEJNGKE);
		}
		num += hEOEKAPBNIE_.CalculateSize(_repeated_hEOEKAPBNIE_codec);
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		num += mEKLIBAPGON_.CalculateSize(_repeated_mEKLIBAPGON_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NMBGLKALLBM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			LMLFOELDMJD = other.LMLFOELDMJD;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.nIIKHEBEDIG_ != null)
		{
			if (nIIKHEBEDIG_ == null)
			{
				NIIKHEBEDIG = new ItemList();
			}
			NIIKHEBEDIG.MergeFrom(other.NIIKHEBEDIG);
		}
		fMPNNHDPGKD_.Add(other.fMPNNHDPGKD_);
		if (other.eKFCLEJNGKE_ != null)
		{
			if (eKFCLEJNGKE_ == null)
			{
				EKFCLEJNGKE = new ItemList();
			}
			EKFCLEJNGKE.MergeFrom(other.EKFCLEJNGKE);
		}
		hEOEKAPBNIE_.Add(other.hEOEKAPBNIE_);
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		mEKLIBAPGON_.Add(other.mEKLIBAPGON_);
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
			case 8u:
				LMLFOELDMJD = (KGFMBNIIPPA)input.ReadEnum();
				break;
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (nIIKHEBEDIG_ == null)
				{
					NIIKHEBEDIG = new ItemList();
				}
				input.ReadMessage(NIIKHEBEDIG);
				break;
			case 42u:
				fMPNNHDPGKD_.AddEntriesFrom(ref input, _repeated_fMPNNHDPGKD_codec);
				break;
			case 50u:
				if (eKFCLEJNGKE_ == null)
				{
					EKFCLEJNGKE = new ItemList();
				}
				input.ReadMessage(EKFCLEJNGKE);
				break;
			case 58u:
				hEOEKAPBNIE_.AddEntriesFrom(ref input, _repeated_hEOEKAPBNIE_codec);
				break;
			case 82u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 114u:
				mEKLIBAPGON_.AddEntriesFrom(ref input, _repeated_mEKLIBAPGON_codec);
				break;
			}
		}
	}
}
