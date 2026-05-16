using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGMGGEMIIKA : IMessage<CGMGGEMIIKA>, IMessage, IEquatable<CGMGGEMIIKA>, IDeepCloneable<CGMGGEMIIKA>, IBufferMessage
{
	private static readonly MessageParser<CGMGGEMIIKA> _parser = new MessageParser<CGMGGEMIIKA>(() => new CGMGGEMIIKA());

	private UnknownFieldSet _unknownFields;

	public const int OKCNHPLOMCDFieldNumber = 1;

	private uint oKCNHPLOMCD_;

	public const int StateFieldNumber = 7;

	private PBKPPEAPBOM state_;

	public const int HpFieldNumber = 10;

	private uint hp_;

	public const int ItemListFieldNumber = 11;

	private static readonly FieldCodec<MPGIOHDMFCG> _repeated_itemList_codec = FieldCodec.ForMessage(90u, MPGIOHDMFCG.Parser);

	private readonly RepeatedField<MPGIOHDMFCG> itemList_ = new RepeatedField<MPGIOHDMFCG>();

	public const int ScoreIdFieldNumber = 14;

	private uint scoreId_;

	public const int MCCLNDCJAMIFieldNumber = 15;

	private uint mCCLNDCJAMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGMGGEMIIKA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGMGGEMIIKAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OKCNHPLOMCD
	{
		get
		{
			return oKCNHPLOMCD_;
		}
		set
		{
			oKCNHPLOMCD_ = value;
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
	public RepeatedField<MPGIOHDMFCG> ItemList => itemList_;

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
	public CGMGGEMIIKA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGMGGEMIIKA(CGMGGEMIIKA other)
		: this()
	{
		oKCNHPLOMCD_ = other.oKCNHPLOMCD_;
		state_ = other.state_;
		hp_ = other.hp_;
		itemList_ = other.itemList_.Clone();
		scoreId_ = other.scoreId_;
		mCCLNDCJAMI_ = other.mCCLNDCJAMI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGMGGEMIIKA Clone()
	{
		return new CGMGGEMIIKA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGMGGEMIIKA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGMGGEMIIKA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OKCNHPLOMCD != other.OKCNHPLOMCD)
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
		if (!itemList_.Equals(other.itemList_))
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (OKCNHPLOMCD != 0)
		{
			num ^= OKCNHPLOMCD.GetHashCode();
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			num ^= State.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (MCCLNDCJAMI != 0)
		{
			num ^= MCCLNDCJAMI.GetHashCode();
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
		if (OKCNHPLOMCD != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OKCNHPLOMCD);
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)State);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Hp);
		}
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		if (ScoreId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ScoreId);
		}
		if (MCCLNDCJAMI != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MCCLNDCJAMI);
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
		if (OKCNHPLOMCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKCNHPLOMCD);
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (MCCLNDCJAMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MCCLNDCJAMI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGMGGEMIIKA other)
	{
		if (other != null)
		{
			if (other.OKCNHPLOMCD != 0)
			{
				OKCNHPLOMCD = other.OKCNHPLOMCD;
			}
			if (other.State != PBKPPEAPBOM.Bnjmpchfina)
			{
				State = other.State;
			}
			if (other.Hp != 0)
			{
				Hp = other.Hp;
			}
			itemList_.Add(other.itemList_);
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.MCCLNDCJAMI != 0)
			{
				MCCLNDCJAMI = other.MCCLNDCJAMI;
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
				OKCNHPLOMCD = input.ReadUInt32();
				break;
			case 56u:
				State = (PBKPPEAPBOM)input.ReadEnum();
				break;
			case 80u:
				Hp = input.ReadUInt32();
				break;
			case 90u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 112u:
				ScoreId = input.ReadUInt32();
				break;
			case 120u:
				MCCLNDCJAMI = input.ReadUInt32();
				break;
			}
		}
	}
}
