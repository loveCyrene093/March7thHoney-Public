using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBCBJJDFBPL : IMessage<NBCBJJDFBPL>, IMessage, IEquatable<NBCBJJDFBPL>, IDeepCloneable<NBCBJJDFBPL>, IBufferMessage
{
	private static readonly MessageParser<NBCBJJDFBPL> _parser = new MessageParser<NBCBJJDFBPL>(() => new NBCBJJDFBPL());

	private UnknownFieldSet _unknownFields;

	public const int IHPGCAAAGBCFieldNumber = 1;

	private uint iHPGCAAAGBC_;

	public const int RankFieldNumber = 2;

	private uint rank_;

	public const int ScoreIdFieldNumber = 3;

	private uint scoreId_;

	public const int MCCLNDCJAMIFieldNumber = 4;

	private uint mCCLNDCJAMI_;

	public const int ItemListFieldNumber = 7;

	private static readonly FieldCodec<MPGIOHDMFCG> _repeated_itemList_codec = FieldCodec.ForMessage(58u, MPGIOHDMFCG.Parser);

	private readonly RepeatedField<MPGIOHDMFCG> itemList_ = new RepeatedField<MPGIOHDMFCG>();

	public const int JKPGACLKEECFieldNumber = 9;

	private uint jKPGACLKEEC_;

	public const int StateFieldNumber = 11;

	private PBKPPEAPBOM state_;

	public const int HpFieldNumber = 13;

	private uint hp_;

	public const int GDNIHALOKHCFieldNumber = 15;

	private bool gDNIHALOKHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBCBJJDFBPL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBCBJJDFBPLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHPGCAAAGBC
	{
		get
		{
			return iHPGCAAAGBC_;
		}
		set
		{
			iHPGCAAAGBC_ = value;
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
	public uint MCCLNDCJAMI
	{
		get
		{
			return mCCLNDCJAMI_;
		}
		set
		{
			mCCLNDCJAMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MPGIOHDMFCG> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKPGACLKEEC
	{
		get
		{
			return jKPGACLKEEC_;
		}
		set
		{
			jKPGACLKEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBKPPEAPBOM State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
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
	public bool GDNIHALOKHC
	{
		get
		{
			return gDNIHALOKHC_;
		}
		set
		{
			gDNIHALOKHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBCBJJDFBPL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBCBJJDFBPL(NBCBJJDFBPL other)
		: this()
	{
		iHPGCAAAGBC_ = other.iHPGCAAAGBC_;
		rank_ = other.rank_;
		scoreId_ = other.scoreId_;
		mCCLNDCJAMI_ = other.mCCLNDCJAMI_;
		itemList_ = other.itemList_.Clone();
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		state_ = other.state_;
		hp_ = other.hp_;
		gDNIHALOKHC_ = other.gDNIHALOKHC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBCBJJDFBPL Clone()
	{
		return new NBCBJJDFBPL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBCBJJDFBPL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBCBJJDFBPL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IHPGCAAAGBC != other.IHPGCAAAGBC)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (MCCLNDCJAMI != other.MCCLNDCJAMI)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (GDNIHALOKHC != other.GDNIHALOKHC)
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
		if (IHPGCAAAGBC != 0)
		{
			num ^= IHPGCAAAGBC.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (MCCLNDCJAMI != 0)
		{
			num ^= MCCLNDCJAMI.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (JKPGACLKEEC != 0)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			num ^= State.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (GDNIHALOKHC)
		{
			num ^= GDNIHALOKHC.GetHashCode();
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
		if (IHPGCAAAGBC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IHPGCAAAGBC);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Rank);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ScoreId);
		}
		if (MCCLNDCJAMI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MCCLNDCJAMI);
		}
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		if (JKPGACLKEEC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(JKPGACLKEEC);
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)State);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Hp);
		}
		if (GDNIHALOKHC)
		{
			output.WriteRawTag(120);
			output.WriteBool(GDNIHALOKHC);
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
		if (IHPGCAAAGBC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHPGCAAAGBC);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (MCCLNDCJAMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MCCLNDCJAMI);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (JKPGACLKEEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKPGACLKEEC);
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		if (GDNIHALOKHC)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBCBJJDFBPL other)
	{
		if (other != null)
		{
			if (other.IHPGCAAAGBC != 0)
			{
				IHPGCAAAGBC = other.IHPGCAAAGBC;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.MCCLNDCJAMI != 0)
			{
				MCCLNDCJAMI = other.MCCLNDCJAMI;
			}
			itemList_.Add(other.itemList_);
			if (other.JKPGACLKEEC != 0)
			{
				JKPGACLKEEC = other.JKPGACLKEEC;
			}
			if (other.State != PBKPPEAPBOM.Bnjmpchfina)
			{
				State = other.State;
			}
			if (other.Hp != 0)
			{
				Hp = other.Hp;
			}
			if (other.GDNIHALOKHC)
			{
				GDNIHALOKHC = other.GDNIHALOKHC;
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
				IHPGCAAAGBC = input.ReadUInt32();
				break;
			case 16u:
				Rank = input.ReadUInt32();
				break;
			case 24u:
				ScoreId = input.ReadUInt32();
				break;
			case 32u:
				MCCLNDCJAMI = input.ReadUInt32();
				break;
			case 58u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 72u:
				JKPGACLKEEC = input.ReadUInt32();
				break;
			case 88u:
				State = (PBKPPEAPBOM)input.ReadEnum();
				break;
			case 104u:
				Hp = input.ReadUInt32();
				break;
			case 120u:
				GDNIHALOKHC = input.ReadBool();
				break;
			}
		}
	}
}
