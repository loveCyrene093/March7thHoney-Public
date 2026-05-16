using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightCurrentInfo : IMessage<GridFightCurrentInfo>, IMessage, IEquatable<GridFightCurrentInfo>, IDeepCloneable<GridFightCurrentInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightCurrentInfo> _parser = new MessageParser<GridFightCurrentInfo>(() => new GridFightCurrentInfo());

	private UnknownFieldSet _unknownFields;

	public const int PendingActionFieldNumber = 2;

	private GridFightPendingAction pendingAction_;

	public const int UniqueIdFieldNumber = 3;

	private uint uniqueId_;

	public const int RogueCurrentGameInfoFieldNumber = 8;

	private static readonly FieldCodec<GridFightGameInfo> _repeated_rogueCurrentGameInfo_codec = FieldCodec.ForMessage(66u, GridFightGameInfo.Parser);

	private readonly RepeatedField<GridFightGameInfo> rogueCurrentGameInfo_ = new RepeatedField<GridFightGameInfo>();

	public const int IsOverlockFieldNumber = 9;

	private bool isOverlock_;

	public const int DivisionIdFieldNumber = 11;

	private uint divisionId_;

	public const int GridFightGameDataFieldNumber = 12;

	private GridFightGameData gridFightGameData_;

	public const int SeasonFieldNumber = 13;

	private uint season_;

	public const int BCHPAOCOHILFieldNumber = 14;

	private FCBEHGJBJCN bCHPAOCOHIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightCurrentInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightCurrentInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAction PendingAction
	{
		get
		{
			return pendingAction_;
		}
		set
		{
			pendingAction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightGameInfo> RogueCurrentGameInfo => rogueCurrentGameInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOverlock
	{
		get
		{
			return isOverlock_;
		}
		set
		{
			isOverlock_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DivisionId
	{
		get
		{
			return divisionId_;
		}
		set
		{
			divisionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameData GridFightGameData
	{
		get
		{
			return gridFightGameData_;
		}
		set
		{
			gridFightGameData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCBEHGJBJCN BCHPAOCOHIL
	{
		get
		{
			return bCHPAOCOHIL_;
		}
		set
		{
			bCHPAOCOHIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightCurrentInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightCurrentInfo(GridFightCurrentInfo other)
		: this()
	{
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		uniqueId_ = other.uniqueId_;
		rogueCurrentGameInfo_ = other.rogueCurrentGameInfo_.Clone();
		isOverlock_ = other.isOverlock_;
		divisionId_ = other.divisionId_;
		gridFightGameData_ = ((other.gridFightGameData_ != null) ? other.gridFightGameData_.Clone() : null);
		season_ = other.season_;
		bCHPAOCOHIL_ = ((other.bCHPAOCOHIL_ != null) ? other.bCHPAOCOHIL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightCurrentInfo Clone()
	{
		return new GridFightCurrentInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightCurrentInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightCurrentInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!rogueCurrentGameInfo_.Equals(other.rogueCurrentGameInfo_))
		{
			return false;
		}
		if (IsOverlock != other.IsOverlock)
		{
			return false;
		}
		if (DivisionId != other.DivisionId)
		{
			return false;
		}
		if (!object.Equals(GridFightGameData, other.GridFightGameData))
		{
			return false;
		}
		if (Season != other.Season)
		{
			return false;
		}
		if (!object.Equals(BCHPAOCOHIL, other.BCHPAOCOHIL))
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
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		num ^= rogueCurrentGameInfo_.GetHashCode();
		if (IsOverlock)
		{
			num ^= IsOverlock.GetHashCode();
		}
		if (DivisionId != 0)
		{
			num ^= DivisionId.GetHashCode();
		}
		if (gridFightGameData_ != null)
		{
			num ^= GridFightGameData.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (bCHPAOCOHIL_ != null)
		{
			num ^= BCHPAOCOHIL.GetHashCode();
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
		if (pendingAction_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PendingAction);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(UniqueId);
		}
		rogueCurrentGameInfo_.WriteTo(ref output, _repeated_rogueCurrentGameInfo_codec);
		if (IsOverlock)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsOverlock);
		}
		if (DivisionId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(DivisionId);
		}
		if (gridFightGameData_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(GridFightGameData);
		}
		if (Season != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Season);
		}
		if (bCHPAOCOHIL_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BCHPAOCOHIL);
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
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		num += rogueCurrentGameInfo_.CalculateSize(_repeated_rogueCurrentGameInfo_codec);
		if (IsOverlock)
		{
			num += 2;
		}
		if (DivisionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DivisionId);
		}
		if (gridFightGameData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightGameData);
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Season);
		}
		if (bCHPAOCOHIL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BCHPAOCOHIL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightCurrentInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new GridFightPendingAction();
			}
			PendingAction.MergeFrom(other.PendingAction);
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		rogueCurrentGameInfo_.Add(other.rogueCurrentGameInfo_);
		if (other.IsOverlock)
		{
			IsOverlock = other.IsOverlock;
		}
		if (other.DivisionId != 0)
		{
			DivisionId = other.DivisionId;
		}
		if (other.gridFightGameData_ != null)
		{
			if (gridFightGameData_ == null)
			{
				GridFightGameData = new GridFightGameData();
			}
			GridFightGameData.MergeFrom(other.GridFightGameData);
		}
		if (other.Season != 0)
		{
			Season = other.Season;
		}
		if (other.bCHPAOCOHIL_ != null)
		{
			if (bCHPAOCOHIL_ == null)
			{
				BCHPAOCOHIL = new FCBEHGJBJCN();
			}
			BCHPAOCOHIL.MergeFrom(other.BCHPAOCOHIL);
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
				if (pendingAction_ == null)
				{
					PendingAction = new GridFightPendingAction();
				}
				input.ReadMessage(PendingAction);
				break;
			case 24u:
				UniqueId = input.ReadUInt32();
				break;
			case 66u:
				rogueCurrentGameInfo_.AddEntriesFrom(ref input, _repeated_rogueCurrentGameInfo_codec);
				break;
			case 72u:
				IsOverlock = input.ReadBool();
				break;
			case 88u:
				DivisionId = input.ReadUInt32();
				break;
			case 98u:
				if (gridFightGameData_ == null)
				{
					GridFightGameData = new GridFightGameData();
				}
				input.ReadMessage(GridFightGameData);
				break;
			case 104u:
				Season = input.ReadUInt32();
				break;
			case 114u:
				if (bCHPAOCOHIL_ == null)
				{
					BCHPAOCOHIL = new FCBEHGJBJCN();
				}
				input.ReadMessage(BCHPAOCOHIL);
				break;
			}
		}
	}
}
