using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReplaceLineupCsReq : IMessage<ReplaceLineupCsReq>, IMessage, IEquatable<ReplaceLineupCsReq>, IDeepCloneable<ReplaceLineupCsReq>, IBufferMessage
{
	private static readonly MessageParser<ReplaceLineupCsReq> _parser = new MessageParser<ReplaceLineupCsReq>(() => new ReplaceLineupCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LeaderSlotFieldNumber = 1;

	private uint leaderSlot_;

	public const int FLFJMCFACKNFieldNumber = 5;

	private bool fLFJMCFACKN_;

	public const int BJADHCOFLGIFieldNumber = 6;

	private bool bJADHCOFLGI_;

	public const int IndexFieldNumber = 8;

	private uint index_;

	public const int IsVirtualFieldNumber = 9;

	private bool isVirtual_;

	public const int LineupSlotListFieldNumber = 11;

	private static readonly FieldCodec<LineupSlotData> _repeated_lineupSlotList_codec = FieldCodec.ForMessage(90u, LineupSlotData.Parser);

	private readonly RepeatedField<LineupSlotData> lineupSlotList_ = new RepeatedField<LineupSlotData>();

	public const int GameStoryLineIdFieldNumber = 12;

	private uint gameStoryLineId_;

	public const int PlaneIdFieldNumber = 14;

	private uint planeId_;

	public const int ExtraLineupTypeFieldNumber = 15;

	private ExtraLineupType extraLineupType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReplaceLineupCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ReplaceLineupCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LeaderSlot
	{
		get
		{
			return leaderSlot_;
		}
		set
		{
			leaderSlot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FLFJMCFACKN
	{
		get
		{
			return fLFJMCFACKN_;
		}
		set
		{
			fLFJMCFACKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BJADHCOFLGI
	{
		get
		{
			return bJADHCOFLGI_;
		}
		set
		{
			bJADHCOFLGI_ = value;
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
	public bool IsVirtual
	{
		get
		{
			return isVirtual_;
		}
		set
		{
			isVirtual_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LineupSlotData> LineupSlotList => lineupSlotList_;

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
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupType ExtraLineupType
	{
		get
		{
			return extraLineupType_;
		}
		set
		{
			extraLineupType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReplaceLineupCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReplaceLineupCsReq(ReplaceLineupCsReq other)
		: this()
	{
		leaderSlot_ = other.leaderSlot_;
		fLFJMCFACKN_ = other.fLFJMCFACKN_;
		bJADHCOFLGI_ = other.bJADHCOFLGI_;
		index_ = other.index_;
		isVirtual_ = other.isVirtual_;
		lineupSlotList_ = other.lineupSlotList_.Clone();
		gameStoryLineId_ = other.gameStoryLineId_;
		planeId_ = other.planeId_;
		extraLineupType_ = other.extraLineupType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReplaceLineupCsReq Clone()
	{
		return new ReplaceLineupCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ReplaceLineupCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ReplaceLineupCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LeaderSlot != other.LeaderSlot)
		{
			return false;
		}
		if (FLFJMCFACKN != other.FLFJMCFACKN)
		{
			return false;
		}
		if (BJADHCOFLGI != other.BJADHCOFLGI)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (IsVirtual != other.IsVirtual)
		{
			return false;
		}
		if (!lineupSlotList_.Equals(other.lineupSlotList_))
		{
			return false;
		}
		if (GameStoryLineId != other.GameStoryLineId)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (ExtraLineupType != other.ExtraLineupType)
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
		if (LeaderSlot != 0)
		{
			num ^= LeaderSlot.GetHashCode();
		}
		if (FLFJMCFACKN)
		{
			num ^= FLFJMCFACKN.GetHashCode();
		}
		if (BJADHCOFLGI)
		{
			num ^= BJADHCOFLGI.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (IsVirtual)
		{
			num ^= IsVirtual.GetHashCode();
		}
		num ^= lineupSlotList_.GetHashCode();
		if (GameStoryLineId != 0)
		{
			num ^= GameStoryLineId.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num ^= ExtraLineupType.GetHashCode();
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
		if (LeaderSlot != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LeaderSlot);
		}
		if (FLFJMCFACKN)
		{
			output.WriteRawTag(40);
			output.WriteBool(FLFJMCFACKN);
		}
		if (BJADHCOFLGI)
		{
			output.WriteRawTag(48);
			output.WriteBool(BJADHCOFLGI);
		}
		if (Index != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Index);
		}
		if (IsVirtual)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsVirtual);
		}
		lineupSlotList_.WriteTo(ref output, _repeated_lineupSlotList_codec);
		if (GameStoryLineId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GameStoryLineId);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PlaneId);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)ExtraLineupType);
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
		if (LeaderSlot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LeaderSlot);
		}
		if (FLFJMCFACKN)
		{
			num += 2;
		}
		if (BJADHCOFLGI)
		{
			num += 2;
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (IsVirtual)
		{
			num += 2;
		}
		num += lineupSlotList_.CalculateSize(_repeated_lineupSlotList_codec);
		if (GameStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExtraLineupType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ReplaceLineupCsReq other)
	{
		if (other != null)
		{
			if (other.LeaderSlot != 0)
			{
				LeaderSlot = other.LeaderSlot;
			}
			if (other.FLFJMCFACKN)
			{
				FLFJMCFACKN = other.FLFJMCFACKN;
			}
			if (other.BJADHCOFLGI)
			{
				BJADHCOFLGI = other.BJADHCOFLGI;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.IsVirtual)
			{
				IsVirtual = other.IsVirtual;
			}
			lineupSlotList_.Add(other.lineupSlotList_);
			if (other.GameStoryLineId != 0)
			{
				GameStoryLineId = other.GameStoryLineId;
			}
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				ExtraLineupType = other.ExtraLineupType;
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
				LeaderSlot = input.ReadUInt32();
				break;
			case 40u:
				FLFJMCFACKN = input.ReadBool();
				break;
			case 48u:
				BJADHCOFLGI = input.ReadBool();
				break;
			case 64u:
				Index = input.ReadUInt32();
				break;
			case 72u:
				IsVirtual = input.ReadBool();
				break;
			case 90u:
				lineupSlotList_.AddEntriesFrom(ref input, _repeated_lineupSlotList_codec);
				break;
			case 96u:
				GameStoryLineId = input.ReadUInt32();
				break;
			case 112u:
				PlaneId = input.ReadUInt32();
				break;
			case 120u:
				ExtraLineupType = (ExtraLineupType)input.ReadEnum();
				break;
			}
		}
	}
}
