using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PMPJMNNAHNL : IMessage<PMPJMNNAHNL>, IMessage, IEquatable<PMPJMNNAHNL>, IDeepCloneable<PMPJMNNAHNL>, IBufferMessage
{
	private static readonly MessageParser<PMPJMNNAHNL> _parser = new MessageParser<PMPJMNNAHNL>(() => new PMPJMNNAHNL());

	private UnknownFieldSet _unknownFields;

	public const int OFFIDMEJBGIFieldNumber = 1;

	private uint oFFIDMEJBGI_;

	public const int MNNDMPBFPJEFieldNumber = 3;

	private static readonly FieldCodec<KNCBIMAAFJG> _repeated_mNNDMPBFPJE_codec = FieldCodec.ForMessage(26u, KNCBIMAAFJG.Parser);

	private readonly RepeatedField<KNCBIMAAFJG> mNNDMPBFPJE_ = new RepeatedField<KNCBIMAAFJG>();

	public const int NicknameFieldNumber = 5;

	private string nickname_ = "";

	public const int UidFieldNumber = 6;

	private uint uid_;

	public const int RankFieldNumber = 8;

	private uint rank_;

	public const int MEKLIKLGAFIFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_mEKLIKLGAFI_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> mEKLIKLGAFI_ = new RepeatedField<uint>();

	public const int IJEEJNBNGOMFieldNumber = 10;

	private uint iJEEJNBNGOM_;

	public const int HpFieldNumber = 11;

	private uint hp_;

	public const int HeadIconFieldNumber = 13;

	private uint headIcon_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PMPJMNNAHNL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PMPJMNNAHNLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFFIDMEJBGI
	{
		get
		{
			return oFFIDMEJBGI_;
		}
		set
		{
			oFFIDMEJBGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNCBIMAAFJG> MNNDMPBFPJE => mNNDMPBFPJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Nickname
	{
		get
		{
			return nickname_;
		}
		set
		{
			nickname_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MEKLIKLGAFI => mEKLIKLGAFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJEEJNBNGOM
	{
		get
		{
			return iJEEJNBNGOM_;
		}
		set
		{
			iJEEJNBNGOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HeadIcon
	{
		get
		{
			return headIcon_;
		}
		set
		{
			headIcon_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMPJMNNAHNL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMPJMNNAHNL(PMPJMNNAHNL other)
		: this()
	{
		oFFIDMEJBGI_ = other.oFFIDMEJBGI_;
		mNNDMPBFPJE_ = other.mNNDMPBFPJE_.Clone();
		nickname_ = other.nickname_;
		uid_ = other.uid_;
		rank_ = other.rank_;
		mEKLIKLGAFI_ = other.mEKLIKLGAFI_.Clone();
		iJEEJNBNGOM_ = other.iJEEJNBNGOM_;
		hp_ = other.hp_;
		headIcon_ = other.headIcon_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMPJMNNAHNL Clone()
	{
		return new PMPJMNNAHNL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PMPJMNNAHNL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PMPJMNNAHNL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFFIDMEJBGI != other.OFFIDMEJBGI)
		{
			return false;
		}
		if (!mNNDMPBFPJE_.Equals(other.mNNDMPBFPJE_))
		{
			return false;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (!mEKLIKLGAFI_.Equals(other.mEKLIKLGAFI_))
		{
			return false;
		}
		if (IJEEJNBNGOM != other.IJEEJNBNGOM)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (HeadIcon != other.HeadIcon)
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
		if (OFFIDMEJBGI != 0)
		{
			num ^= OFFIDMEJBGI.GetHashCode();
		}
		num ^= mNNDMPBFPJE_.GetHashCode();
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		num ^= mEKLIKLGAFI_.GetHashCode();
		if (IJEEJNBNGOM != 0)
		{
			num ^= IJEEJNBNGOM.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (HeadIcon != 0)
		{
			num ^= HeadIcon.GetHashCode();
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
		if (OFFIDMEJBGI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OFFIDMEJBGI);
		}
		mNNDMPBFPJE_.WriteTo(ref output, _repeated_mNNDMPBFPJE_codec);
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Nickname);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Uid);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Rank);
		}
		mEKLIKLGAFI_.WriteTo(ref output, _repeated_mEKLIKLGAFI_codec);
		if (IJEEJNBNGOM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IJEEJNBNGOM);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Hp);
		}
		if (HeadIcon != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HeadIcon);
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
		if (OFFIDMEJBGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFFIDMEJBGI);
		}
		num += mNNDMPBFPJE_.CalculateSize(_repeated_mNNDMPBFPJE_codec);
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		num += mEKLIKLGAFI_.CalculateSize(_repeated_mEKLIKLGAFI_codec);
		if (IJEEJNBNGOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJEEJNBNGOM);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		if (HeadIcon != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HeadIcon);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PMPJMNNAHNL other)
	{
		if (other != null)
		{
			if (other.OFFIDMEJBGI != 0)
			{
				OFFIDMEJBGI = other.OFFIDMEJBGI;
			}
			mNNDMPBFPJE_.Add(other.mNNDMPBFPJE_);
			if (other.Nickname.Length != 0)
			{
				Nickname = other.Nickname;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			mEKLIKLGAFI_.Add(other.mEKLIKLGAFI_);
			if (other.IJEEJNBNGOM != 0)
			{
				IJEEJNBNGOM = other.IJEEJNBNGOM;
			}
			if (other.Hp != 0)
			{
				Hp = other.Hp;
			}
			if (other.HeadIcon != 0)
			{
				HeadIcon = other.HeadIcon;
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
			case 8u:
				OFFIDMEJBGI = input.ReadUInt32();
				break;
			case 26u:
				mNNDMPBFPJE_.AddEntriesFrom(ref input, _repeated_mNNDMPBFPJE_codec);
				break;
			case 42u:
				Nickname = input.ReadString();
				break;
			case 48u:
				Uid = input.ReadUInt32();
				break;
			case 64u:
				Rank = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				mEKLIKLGAFI_.AddEntriesFrom(ref input, _repeated_mEKLIKLGAFI_codec);
				break;
			case 80u:
				IJEEJNBNGOM = input.ReadUInt32();
				break;
			case 88u:
				Hp = input.ReadUInt32();
				break;
			case 104u:
				HeadIcon = input.ReadUInt32();
				break;
			}
		}
	}
}
