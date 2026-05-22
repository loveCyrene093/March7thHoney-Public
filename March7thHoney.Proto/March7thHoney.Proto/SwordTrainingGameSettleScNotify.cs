using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwordTrainingGameSettleScNotify : IMessage<SwordTrainingGameSettleScNotify>, IMessage, IEquatable<SwordTrainingGameSettleScNotify>, IDeepCloneable<SwordTrainingGameSettleScNotify>, IBufferMessage
{
	private static readonly MessageParser<SwordTrainingGameSettleScNotify> _parser = new MessageParser<SwordTrainingGameSettleScNotify>(() => new SwordTrainingGameSettleScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GameStoryLineIdFieldNumber = 3;

	private uint gameStoryLineId_;

	public const int FHKINAKGBBKFieldNumber = 5;

	private uint fHKINAKGBBK_;

	public const int NCPKPHMOHIMFieldNumber = 6;

	private uint nCPKPHMOHIM_;

	public const int LDKGJBALGKCFieldNumber = 8;

	private uint lDKGJBALGKC_;

	public const int PGAHFBAJAPFFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_pGAHFBAJAPF_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> pGAHFBAJAPF_ = new RepeatedField<uint>();

	public const int LEGLOIMNPECFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_lEGLOIMNPEC_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> lEGLOIMNPEC_ = new RepeatedField<uint>();

	public const int ReasonFieldNumber = 13;

	private NCCLJBCHBBP reason_;

	public const int RewardFieldNumber = 14;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwordTrainingGameSettleScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwordTrainingGameSettleScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GameStoryLineId
	{
		get
		{
			return gameStoryLineId_;
		}
		set
		{
			gameStoryLineId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHKINAKGBBK
	{
		get
		{
			return fHKINAKGBBK_;
		}
		set
		{
			fHKINAKGBBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCPKPHMOHIM
	{
		get
		{
			return nCPKPHMOHIM_;
		}
		set
		{
			nCPKPHMOHIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDKGJBALGKC
	{
		get
		{
			return lDKGJBALGKC_;
		}
		set
		{
			lDKGJBALGKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PGAHFBAJAPF => pGAHFBAJAPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LEGLOIMNPEC => lEGLOIMNPEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCCLJBCHBBP Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

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
	public SwordTrainingGameSettleScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingGameSettleScNotify(SwordTrainingGameSettleScNotify other)
		: this()
	{
		gameStoryLineId_ = other.gameStoryLineId_;
		fHKINAKGBBK_ = other.fHKINAKGBBK_;
		nCPKPHMOHIM_ = other.nCPKPHMOHIM_;
		lDKGJBALGKC_ = other.lDKGJBALGKC_;
		pGAHFBAJAPF_ = other.pGAHFBAJAPF_.Clone();
		lEGLOIMNPEC_ = other.lEGLOIMNPEC_.Clone();
		reason_ = other.reason_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingGameSettleScNotify Clone()
	{
		return new SwordTrainingGameSettleScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwordTrainingGameSettleScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwordTrainingGameSettleScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GameStoryLineId != other.GameStoryLineId)
		{
			return false;
		}
		if (FHKINAKGBBK != other.FHKINAKGBBK)
		{
			return false;
		}
		if (NCPKPHMOHIM != other.NCPKPHMOHIM)
		{
			return false;
		}
		if (LDKGJBALGKC != other.LDKGJBALGKC)
		{
			return false;
		}
		if (!pGAHFBAJAPF_.Equals(other.pGAHFBAJAPF_))
		{
			return false;
		}
		if (!lEGLOIMNPEC_.Equals(other.lEGLOIMNPEC_))
		{
			return false;
		}
		if (Reason != other.Reason)
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
		if (GameStoryLineId != 0)
		{
			num ^= GameStoryLineId.GetHashCode();
		}
		if (FHKINAKGBBK != 0)
		{
			num ^= FHKINAKGBBK.GetHashCode();
		}
		if (NCPKPHMOHIM != 0)
		{
			num ^= NCPKPHMOHIM.GetHashCode();
		}
		if (LDKGJBALGKC != 0)
		{
			num ^= LDKGJBALGKC.GetHashCode();
		}
		num ^= pGAHFBAJAPF_.GetHashCode();
		num ^= lEGLOIMNPEC_.GetHashCode();
		if (Reason != NCCLJBCHBBP.Ofpfpbhiamb)
		{
			num ^= Reason.GetHashCode();
		}
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
		if (GameStoryLineId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GameStoryLineId);
		}
		if (FHKINAKGBBK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FHKINAKGBBK);
		}
		if (NCPKPHMOHIM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NCPKPHMOHIM);
		}
		if (LDKGJBALGKC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LDKGJBALGKC);
		}
		pGAHFBAJAPF_.WriteTo(ref output, _repeated_pGAHFBAJAPF_codec);
		lEGLOIMNPEC_.WriteTo(ref output, _repeated_lEGLOIMNPEC_codec);
		if (Reason != NCCLJBCHBBP.Ofpfpbhiamb)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)Reason);
		}
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
		if (GameStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
		}
		if (FHKINAKGBBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHKINAKGBBK);
		}
		if (NCPKPHMOHIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCPKPHMOHIM);
		}
		if (LDKGJBALGKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDKGJBALGKC);
		}
		num += pGAHFBAJAPF_.CalculateSize(_repeated_pGAHFBAJAPF_codec);
		num += lEGLOIMNPEC_.CalculateSize(_repeated_lEGLOIMNPEC_codec);
		if (Reason != NCCLJBCHBBP.Ofpfpbhiamb)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
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
	public void MergeFrom(SwordTrainingGameSettleScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GameStoryLineId != 0)
		{
			GameStoryLineId = other.GameStoryLineId;
		}
		if (other.FHKINAKGBBK != 0)
		{
			FHKINAKGBBK = other.FHKINAKGBBK;
		}
		if (other.NCPKPHMOHIM != 0)
		{
			NCPKPHMOHIM = other.NCPKPHMOHIM;
		}
		if (other.LDKGJBALGKC != 0)
		{
			LDKGJBALGKC = other.LDKGJBALGKC;
		}
		pGAHFBAJAPF_.Add(other.pGAHFBAJAPF_);
		lEGLOIMNPEC_.Add(other.lEGLOIMNPEC_);
		if (other.Reason != NCCLJBCHBBP.Ofpfpbhiamb)
		{
			Reason = other.Reason;
		}
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
			case 24u:
				GameStoryLineId = input.ReadUInt32();
				break;
			case 40u:
				FHKINAKGBBK = input.ReadUInt32();
				break;
			case 48u:
				NCPKPHMOHIM = input.ReadUInt32();
				break;
			case 64u:
				LDKGJBALGKC = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				pGAHFBAJAPF_.AddEntriesFrom(ref input, _repeated_pGAHFBAJAPF_codec);
				break;
			case 88u:
			case 90u:
				lEGLOIMNPEC_.AddEntriesFrom(ref input, _repeated_lEGLOIMNPEC_codec);
				break;
			case 104u:
				Reason = (NCCLJBCHBBP)input.ReadEnum();
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
