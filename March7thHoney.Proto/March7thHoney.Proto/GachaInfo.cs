using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GachaInfo : IMessage<GachaInfo>, IMessage, IEquatable<GachaInfo>, IDeepCloneable<GachaInfo>, IBufferMessage
{
	private static readonly MessageParser<GachaInfo> _parser = new MessageParser<GachaInfo>(() => new GachaInfo());

	private UnknownFieldSet _unknownFields;

	public const int EndTimeFieldNumber = 2;

	private long endTime_;

	public const int BeginTimeFieldNumber = 3;

	private long beginTime_;

	public const int ItemDetailListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_itemDetailList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> itemDetailList_ = new RepeatedField<uint>();

	public const int GachaIdFieldNumber = 7;

	private uint gachaId_;

	public const int PAPOKACIPPJFieldNumber = 8;

	private uint pAPOKACIPPJ_;

	public const int CBHAEFNAFLEFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_cBHAEFNAFLE_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> cBHAEFNAFLE_ = new RepeatedField<uint>();

	public const int DetailUrlFieldNumber = 10;

	private string detailUrl_ = "";

	public const int PrizeItemListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_prizeItemList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> prizeItemList_ = new RepeatedField<uint>();

	public const int HistoryUrlFieldNumber = 12;

	private string historyUrl_ = "";

	public const int FJIBOAGDNDGFieldNumber = 13;

	private uint fJIBOAGDNDG_;

	public const int OKFNNHNLBOOFieldNumber = 14;

	private uint oKFNNHNLBOO_;

	public const int GachaCeilingFieldNumber = 15;

	private GachaCeiling gachaCeiling_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BeginTime
	{
		get
		{
			return beginTime_;
		}
		set
		{
			beginTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ItemDetailList => itemDetailList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PAPOKACIPPJ
	{
		get
		{
			return pAPOKACIPPJ_;
		}
		set
		{
			pAPOKACIPPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CBHAEFNAFLE => cBHAEFNAFLE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DetailUrl
	{
		get
		{
			return detailUrl_;
		}
		set
		{
			detailUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PrizeItemList => prizeItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HistoryUrl
	{
		get
		{
			return historyUrl_;
		}
		set
		{
			historyUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJIBOAGDNDG
	{
		get
		{
			return fJIBOAGDNDG_;
		}
		set
		{
			fJIBOAGDNDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OKFNNHNLBOO
	{
		get
		{
			return oKFNNHNLBOO_;
		}
		set
		{
			oKFNNHNLBOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaCeiling GachaCeiling
	{
		get
		{
			return gachaCeiling_;
		}
		set
		{
			gachaCeiling_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaInfo(GachaInfo other)
		: this()
	{
		endTime_ = other.endTime_;
		beginTime_ = other.beginTime_;
		itemDetailList_ = other.itemDetailList_.Clone();
		gachaId_ = other.gachaId_;
		pAPOKACIPPJ_ = other.pAPOKACIPPJ_;
		cBHAEFNAFLE_ = other.cBHAEFNAFLE_.Clone();
		detailUrl_ = other.detailUrl_;
		prizeItemList_ = other.prizeItemList_.Clone();
		historyUrl_ = other.historyUrl_;
		fJIBOAGDNDG_ = other.fJIBOAGDNDG_;
		oKFNNHNLBOO_ = other.oKFNNHNLBOO_;
		gachaCeiling_ = ((other.gachaCeiling_ != null) ? other.gachaCeiling_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaInfo Clone()
	{
		return new GachaInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (!itemDetailList_.Equals(other.itemDetailList_))
		{
			return false;
		}
		if (GachaId != other.GachaId)
		{
			return false;
		}
		if (PAPOKACIPPJ != other.PAPOKACIPPJ)
		{
			return false;
		}
		if (!cBHAEFNAFLE_.Equals(other.cBHAEFNAFLE_))
		{
			return false;
		}
		if (DetailUrl != other.DetailUrl)
		{
			return false;
		}
		if (!prizeItemList_.Equals(other.prizeItemList_))
		{
			return false;
		}
		if (HistoryUrl != other.HistoryUrl)
		{
			return false;
		}
		if (FJIBOAGDNDG != other.FJIBOAGDNDG)
		{
			return false;
		}
		if (OKFNNHNLBOO != other.OKFNNHNLBOO)
		{
			return false;
		}
		if (!object.Equals(GachaCeiling, other.GachaCeiling))
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
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		num ^= itemDetailList_.GetHashCode();
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (PAPOKACIPPJ != 0)
		{
			num ^= PAPOKACIPPJ.GetHashCode();
		}
		num ^= cBHAEFNAFLE_.GetHashCode();
		if (DetailUrl.Length != 0)
		{
			num ^= DetailUrl.GetHashCode();
		}
		num ^= prizeItemList_.GetHashCode();
		if (HistoryUrl.Length != 0)
		{
			num ^= HistoryUrl.GetHashCode();
		}
		if (FJIBOAGDNDG != 0)
		{
			num ^= FJIBOAGDNDG.GetHashCode();
		}
		if (OKFNNHNLBOO != 0)
		{
			num ^= OKFNNHNLBOO.GetHashCode();
		}
		if (gachaCeiling_ != null)
		{
			num ^= GachaCeiling.GetHashCode();
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
		if (EndTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(EndTime);
		}
		if (BeginTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(BeginTime);
		}
		itemDetailList_.WriteTo(ref output, _repeated_itemDetailList_codec);
		if (GachaId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GachaId);
		}
		if (PAPOKACIPPJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PAPOKACIPPJ);
		}
		cBHAEFNAFLE_.WriteTo(ref output, _repeated_cBHAEFNAFLE_codec);
		if (DetailUrl.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(DetailUrl);
		}
		prizeItemList_.WriteTo(ref output, _repeated_prizeItemList_codec);
		if (HistoryUrl.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(HistoryUrl);
		}
		if (FJIBOAGDNDG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FJIBOAGDNDG);
		}
		if (OKFNNHNLBOO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OKFNNHNLBOO);
		}
		if (gachaCeiling_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(GachaCeiling);
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
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BeginTime);
		}
		num += itemDetailList_.CalculateSize(_repeated_itemDetailList_codec);
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaId);
		}
		if (PAPOKACIPPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PAPOKACIPPJ);
		}
		num += cBHAEFNAFLE_.CalculateSize(_repeated_cBHAEFNAFLE_codec);
		if (DetailUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DetailUrl);
		}
		num += prizeItemList_.CalculateSize(_repeated_prizeItemList_codec);
		if (HistoryUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HistoryUrl);
		}
		if (FJIBOAGDNDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJIBOAGDNDG);
		}
		if (OKFNNHNLBOO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKFNNHNLBOO);
		}
		if (gachaCeiling_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GachaCeiling);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EndTime != 0L)
		{
			EndTime = other.EndTime;
		}
		if (other.BeginTime != 0L)
		{
			BeginTime = other.BeginTime;
		}
		itemDetailList_.Add(other.itemDetailList_);
		if (other.GachaId != 0)
		{
			GachaId = other.GachaId;
		}
		if (other.PAPOKACIPPJ != 0)
		{
			PAPOKACIPPJ = other.PAPOKACIPPJ;
		}
		cBHAEFNAFLE_.Add(other.cBHAEFNAFLE_);
		if (other.DetailUrl.Length != 0)
		{
			DetailUrl = other.DetailUrl;
		}
		prizeItemList_.Add(other.prizeItemList_);
		if (other.HistoryUrl.Length != 0)
		{
			HistoryUrl = other.HistoryUrl;
		}
		if (other.FJIBOAGDNDG != 0)
		{
			FJIBOAGDNDG = other.FJIBOAGDNDG;
		}
		if (other.OKFNNHNLBOO != 0)
		{
			OKFNNHNLBOO = other.OKFNNHNLBOO;
		}
		if (other.gachaCeiling_ != null)
		{
			if (gachaCeiling_ == null)
			{
				GachaCeiling = new GachaCeiling();
			}
			GachaCeiling.MergeFrom(other.GachaCeiling);
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
			case 16u:
				EndTime = input.ReadInt64();
				break;
			case 24u:
				BeginTime = input.ReadInt64();
				break;
			case 48u:
			case 50u:
				itemDetailList_.AddEntriesFrom(ref input, _repeated_itemDetailList_codec);
				break;
			case 56u:
				GachaId = input.ReadUInt32();
				break;
			case 64u:
				PAPOKACIPPJ = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				cBHAEFNAFLE_.AddEntriesFrom(ref input, _repeated_cBHAEFNAFLE_codec);
				break;
			case 82u:
				DetailUrl = input.ReadString();
				break;
			case 88u:
			case 90u:
				prizeItemList_.AddEntriesFrom(ref input, _repeated_prizeItemList_codec);
				break;
			case 98u:
				HistoryUrl = input.ReadString();
				break;
			case 104u:
				FJIBOAGDNDG = input.ReadUInt32();
				break;
			case 112u:
				OKFNNHNLBOO = input.ReadUInt32();
				break;
			case 122u:
				if (gachaCeiling_ == null)
				{
					GachaCeiling = new GachaCeiling();
				}
				input.ReadMessage(GachaCeiling);
				break;
			}
		}
	}
}
