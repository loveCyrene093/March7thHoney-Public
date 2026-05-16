using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HBCMBPKGBJK : IMessage<HBCMBPKGBJK>, IMessage, IEquatable<HBCMBPKGBJK>, IDeepCloneable<HBCMBPKGBJK>, IBufferMessage
{
	private static readonly MessageParser<HBCMBPKGBJK> _parser = new MessageParser<HBCMBPKGBJK>(() => new HBCMBPKGBJK());

	private UnknownFieldSet _unknownFields;

	public const int MEKLIBAPGONFieldNumber = 2;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_mEKLIBAPGON_codec = FieldCodec.ForMessage(18u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> mEKLIBAPGON_ = new RepeatedField<GKDEKJKOIJN>();

	public const int HEOEKAPBNIEFieldNumber = 4;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_hEOEKAPBNIE_codec = FieldCodec.ForMessage(34u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> hEOEKAPBNIE_ = new RepeatedField<GKDEKJKOIJN>();

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int FIIJCFJJLOOFieldNumber = 11;

	private bool fIIJCFJJLOO_;

	public const int FMPNNHDPGKDFieldNumber = 12;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_fMPNNHDPGKD_codec = FieldCodec.ForMessage(98u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> fMPNNHDPGKD_ = new RepeatedField<GKDEKJKOIJN>();

	public const int RewardFieldNumber = 14;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HBCMBPKGBJK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HBCMBPKGBJKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> MEKLIBAPGON => mEKLIBAPGON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> HEOEKAPBNIE => hEOEKAPBNIE_;

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
	public bool FIIJCFJJLOO
	{
		get
		{
			return fIIJCFJJLOO_;
		}
		set
		{
			fIIJCFJJLOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> FMPNNHDPGKD => fMPNNHDPGKD_;

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
	public HBCMBPKGBJK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBCMBPKGBJK(HBCMBPKGBJK other)
		: this()
	{
		mEKLIBAPGON_ = other.mEKLIBAPGON_.Clone();
		hEOEKAPBNIE_ = other.hEOEKAPBNIE_.Clone();
		retcode_ = other.retcode_;
		fIIJCFJJLOO_ = other.fIIJCFJJLOO_;
		fMPNNHDPGKD_ = other.fMPNNHDPGKD_.Clone();
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBCMBPKGBJK Clone()
	{
		return new HBCMBPKGBJK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HBCMBPKGBJK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HBCMBPKGBJK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mEKLIBAPGON_.Equals(other.mEKLIBAPGON_))
		{
			return false;
		}
		if (!hEOEKAPBNIE_.Equals(other.hEOEKAPBNIE_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (FIIJCFJJLOO != other.FIIJCFJJLOO)
		{
			return false;
		}
		if (!fMPNNHDPGKD_.Equals(other.fMPNNHDPGKD_))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
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
		num ^= mEKLIBAPGON_.GetHashCode();
		num ^= hEOEKAPBNIE_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (FIIJCFJJLOO)
		{
			num ^= FIIJCFJJLOO.GetHashCode();
		}
		num ^= fMPNNHDPGKD_.GetHashCode();
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		mEKLIBAPGON_.WriteTo(ref output, _repeated_mEKLIBAPGON_codec);
		hEOEKAPBNIE_.WriteTo(ref output, _repeated_hEOEKAPBNIE_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (FIIJCFJJLOO)
		{
			output.WriteRawTag(88);
			output.WriteBool(FIIJCFJJLOO);
		}
		fMPNNHDPGKD_.WriteTo(ref output, _repeated_fMPNNHDPGKD_codec);
		if (reward_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(Reward);
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
		num += mEKLIBAPGON_.CalculateSize(_repeated_mEKLIBAPGON_codec);
		num += hEOEKAPBNIE_.CalculateSize(_repeated_hEOEKAPBNIE_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (FIIJCFJJLOO)
		{
			num += 2;
		}
		num += fMPNNHDPGKD_.CalculateSize(_repeated_fMPNNHDPGKD_codec);
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HBCMBPKGBJK other)
	{
		if (other == null)
		{
			return;
		}
		mEKLIBAPGON_.Add(other.mEKLIBAPGON_);
		hEOEKAPBNIE_.Add(other.hEOEKAPBNIE_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.FIIJCFJJLOO)
		{
			FIIJCFJJLOO = other.FIIJCFJJLOO;
		}
		fMPNNHDPGKD_.Add(other.fMPNNHDPGKD_);
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
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
				mEKLIBAPGON_.AddEntriesFrom(ref input, _repeated_mEKLIBAPGON_codec);
				break;
			case 34u:
				hEOEKAPBNIE_.AddEntriesFrom(ref input, _repeated_hEOEKAPBNIE_codec);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				FIIJCFJJLOO = input.ReadBool();
				break;
			case 98u:
				fMPNNHDPGKD_.AddEntriesFrom(ref input, _repeated_fMPNNHDPGKD_codec);
				break;
			case 114u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			}
		}
	}
}
