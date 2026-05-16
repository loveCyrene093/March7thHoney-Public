using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMMELGEBNOG : IMessage<OMMELGEBNOG>, IMessage, IEquatable<OMMELGEBNOG>, IDeepCloneable<OMMELGEBNOG>, IBufferMessage
{
	public enum GBFCMPACOPJOneofCase
	{
		None = 0,
		MarbleGameBegin = 101,
		MarbleGameEnd = 102,
		MarbleGameRound = 103,
		MarbleGameTurn = 104,
		CakeRaceSectionBegin = 201,
		CakeRaceSectionEnd = 202,
		CakeRaceRoomSectionSettle = 203,
		DiceCombatBegin = 251,
		DiceCombatTurnEnd = 252,
		DiceCombatEnd = 253,
		DiceCombatV2Begin = 261,
		DiceCombatV2End = 262,
		DiceCombatV2TurnEnd = 263,
		DiceCombatV2TacticsPointChange = 264,
		DiceCombatV2TacticsCardChange = 265,
		DiceCombatV2DiceChangeRequest = 266,
		DiceCombatV2DiceChange = 267
	}

	private static readonly MessageParser<OMMELGEBNOG> _parser = new MessageParser<OMMELGEBNOG>(() => new OMMELGEBNOG());

	private UnknownFieldSet _unknownFields;

	public const int QueuePositionFieldNumber = 1;

	private uint queuePosition_;

	public const int CHNHLKKKJHAFieldNumber = 2;

	private uint cHNHLKKKJHA_;

	public const int MarbleGameBeginFieldNumber = 101;

	public const int MarbleGameEndFieldNumber = 102;

	public const int MarbleGameRoundFieldNumber = 103;

	public const int MarbleGameTurnFieldNumber = 104;

	public const int CakeRaceSectionBeginFieldNumber = 201;

	public const int CakeRaceSectionEndFieldNumber = 202;

	public const int CakeRaceRoomSectionSettleFieldNumber = 203;

	public const int DiceCombatBeginFieldNumber = 251;

	public const int DiceCombatTurnEndFieldNumber = 252;

	public const int DiceCombatEndFieldNumber = 253;

	public const int DiceCombatV2BeginFieldNumber = 261;

	public const int DiceCombatV2EndFieldNumber = 262;

	public const int DiceCombatV2TurnEndFieldNumber = 263;

	public const int DiceCombatV2TacticsPointChangeFieldNumber = 264;

	public const int DiceCombatV2TacticsCardChangeFieldNumber = 265;

	public const int DiceCombatV2DiceChangeRequestFieldNumber = 266;

	public const int DiceCombatV2DiceChangeFieldNumber = 267;

	private object gBFCMPACOPJ_;

	private GBFCMPACOPJOneofCase gBFCMPACOPJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMMELGEBNOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMMELGEBNOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHNHLKKKJHA
	{
		get
		{
			return cHNHLKKKJHA_;
		}
		set
		{
			cHNHLKKKJHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLNCNCNJGDL MarbleGameBegin
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.MarbleGameBegin)
			{
				return null;
			}
			return (HLNCNCNJGDL)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.MarbleGameBegin : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNJBMILMKMB MarbleGameEnd
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.MarbleGameEnd)
			{
				return null;
			}
			return (GNJBMILMKMB)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.MarbleGameEnd : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNEMCBJHACK MarbleGameRound
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.MarbleGameRound)
			{
				return null;
			}
			return (CNEMCBJHACK)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.MarbleGameRound : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBIINELNDKH MarbleGameTurn
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.MarbleGameTurn)
			{
				return null;
			}
			return (BBIINELNDKH)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.MarbleGameTurn : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJJNFNALLGA CakeRaceSectionBegin
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.CakeRaceSectionBegin)
			{
				return null;
			}
			return (FJJNFNALLGA)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.CakeRaceSectionBegin : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBBJMJJOJDP CakeRaceSectionEnd
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.CakeRaceSectionEnd)
			{
				return null;
			}
			return (BBBJMJJOJDP)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.CakeRaceSectionEnd : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLECMCJNPIL CakeRaceRoomSectionSettle
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle)
			{
				return null;
			}
			return (PLECMCJNPIL)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEOELEOKPOF DiceCombatBegin
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatBegin)
			{
				return null;
			}
			return (CEOELEOKPOF)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatBegin : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKHFNKJNMLO DiceCombatTurnEnd
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatTurnEnd)
			{
				return null;
			}
			return (CKHFNKJNMLO)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatTurnEnd : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAHPBBLMDCJ DiceCombatEnd
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatEnd)
			{
				return null;
			}
			return (CAHPBBLMDCJ)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatEnd : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHBGAHNNEKI DiceCombatV2Begin
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatV2Begin)
			{
				return null;
			}
			return (IHBGAHNNEKI)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatV2Begin : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFIAMODBOIJ DiceCombatV2End
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatV2End)
			{
				return null;
			}
			return (JFIAMODBOIJ)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatV2End : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODMJGAGNPA DiceCombatV2TurnEnd
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd)
			{
				return null;
			}
			return (GODMJGAGNPA)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMBGOODFIHB DiceCombatV2TacticsPointChange
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange)
			{
				return null;
			}
			return (OMBGOODFIHB)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCMKANNIKDP DiceCombatV2TacticsCardChange
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange)
			{
				return null;
			}
			return (BCMKANNIKDP)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLOEMBHNEPP DiceCombatV2DiceChangeRequest
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest)
			{
				return null;
			}
			return (FLOEMBHNEPP)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEBMHKKEHDG DiceCombatV2DiceChange
	{
		get
		{
			if (gBFCMPACOPJCase_ != GBFCMPACOPJOneofCase.DiceCombatV2DiceChange)
			{
				return null;
			}
			return (FEBMHKKEHDG)gBFCMPACOPJ_;
		}
		set
		{
			gBFCMPACOPJ_ = value;
			gBFCMPACOPJCase_ = ((value != null) ? GBFCMPACOPJOneofCase.DiceCombatV2DiceChange : GBFCMPACOPJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBFCMPACOPJOneofCase GBFCMPACOPJCase => gBFCMPACOPJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMMELGEBNOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMMELGEBNOG(OMMELGEBNOG other)
		: this()
	{
		queuePosition_ = other.queuePosition_;
		cHNHLKKKJHA_ = other.cHNHLKKKJHA_;
		switch (other.GBFCMPACOPJCase)
		{
		case GBFCMPACOPJOneofCase.MarbleGameBegin:
			MarbleGameBegin = other.MarbleGameBegin.Clone();
			break;
		case GBFCMPACOPJOneofCase.MarbleGameEnd:
			MarbleGameEnd = other.MarbleGameEnd.Clone();
			break;
		case GBFCMPACOPJOneofCase.MarbleGameRound:
			MarbleGameRound = other.MarbleGameRound.Clone();
			break;
		case GBFCMPACOPJOneofCase.MarbleGameTurn:
			MarbleGameTurn = other.MarbleGameTurn.Clone();
			break;
		case GBFCMPACOPJOneofCase.CakeRaceSectionBegin:
			CakeRaceSectionBegin = other.CakeRaceSectionBegin.Clone();
			break;
		case GBFCMPACOPJOneofCase.CakeRaceSectionEnd:
			CakeRaceSectionEnd = other.CakeRaceSectionEnd.Clone();
			break;
		case GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle:
			CakeRaceRoomSectionSettle = other.CakeRaceRoomSectionSettle.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatBegin:
			DiceCombatBegin = other.DiceCombatBegin.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatTurnEnd:
			DiceCombatTurnEnd = other.DiceCombatTurnEnd.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatEnd:
			DiceCombatEnd = other.DiceCombatEnd.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2Begin:
			DiceCombatV2Begin = other.DiceCombatV2Begin.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2End:
			DiceCombatV2End = other.DiceCombatV2End.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd:
			DiceCombatV2TurnEnd = other.DiceCombatV2TurnEnd.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange:
			DiceCombatV2TacticsPointChange = other.DiceCombatV2TacticsPointChange.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange:
			DiceCombatV2TacticsCardChange = other.DiceCombatV2TacticsCardChange.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest:
			DiceCombatV2DiceChangeRequest = other.DiceCombatV2DiceChangeRequest.Clone();
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2DiceChange:
			DiceCombatV2DiceChange = other.DiceCombatV2DiceChange.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMMELGEBNOG Clone()
	{
		return new OMMELGEBNOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGBFCMPACOPJ()
	{
		gBFCMPACOPJCase_ = GBFCMPACOPJOneofCase.None;
		gBFCMPACOPJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMMELGEBNOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMMELGEBNOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (CHNHLKKKJHA != other.CHNHLKKKJHA)
		{
			return false;
		}
		if (!object.Equals(MarbleGameBegin, other.MarbleGameBegin))
		{
			return false;
		}
		if (!object.Equals(MarbleGameEnd, other.MarbleGameEnd))
		{
			return false;
		}
		if (!object.Equals(MarbleGameRound, other.MarbleGameRound))
		{
			return false;
		}
		if (!object.Equals(MarbleGameTurn, other.MarbleGameTurn))
		{
			return false;
		}
		if (!object.Equals(CakeRaceSectionBegin, other.CakeRaceSectionBegin))
		{
			return false;
		}
		if (!object.Equals(CakeRaceSectionEnd, other.CakeRaceSectionEnd))
		{
			return false;
		}
		if (!object.Equals(CakeRaceRoomSectionSettle, other.CakeRaceRoomSectionSettle))
		{
			return false;
		}
		if (!object.Equals(DiceCombatBegin, other.DiceCombatBegin))
		{
			return false;
		}
		if (!object.Equals(DiceCombatTurnEnd, other.DiceCombatTurnEnd))
		{
			return false;
		}
		if (!object.Equals(DiceCombatEnd, other.DiceCombatEnd))
		{
			return false;
		}
		if (!object.Equals(DiceCombatV2Begin, other.DiceCombatV2Begin))
		{
			return false;
		}
		if (!object.Equals(DiceCombatV2End, other.DiceCombatV2End))
		{
			return false;
		}
		if (!object.Equals(DiceCombatV2TurnEnd, other.DiceCombatV2TurnEnd))
		{
			return false;
		}
		if (!object.Equals(DiceCombatV2TacticsPointChange, other.DiceCombatV2TacticsPointChange))
		{
			return false;
		}
		if (!object.Equals(DiceCombatV2TacticsCardChange, other.DiceCombatV2TacticsCardChange))
		{
			return false;
		}
		if (!object.Equals(DiceCombatV2DiceChangeRequest, other.DiceCombatV2DiceChangeRequest))
		{
			return false;
		}
		if (!object.Equals(DiceCombatV2DiceChange, other.DiceCombatV2DiceChange))
		{
			return false;
		}
		if (GBFCMPACOPJCase != other.GBFCMPACOPJCase)
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (CHNHLKKKJHA != 0)
		{
			num ^= CHNHLKKKJHA.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameBegin)
		{
			num ^= MarbleGameBegin.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameEnd)
		{
			num ^= MarbleGameEnd.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameRound)
		{
			num ^= MarbleGameRound.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameTurn)
		{
			num ^= MarbleGameTurn.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionBegin)
		{
			num ^= CakeRaceSectionBegin.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionEnd)
		{
			num ^= CakeRaceSectionEnd.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle)
		{
			num ^= CakeRaceRoomSectionSettle.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatBegin)
		{
			num ^= DiceCombatBegin.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatTurnEnd)
		{
			num ^= DiceCombatTurnEnd.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatEnd)
		{
			num ^= DiceCombatEnd.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2Begin)
		{
			num ^= DiceCombatV2Begin.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2End)
		{
			num ^= DiceCombatV2End.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd)
		{
			num ^= DiceCombatV2TurnEnd.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange)
		{
			num ^= DiceCombatV2TacticsPointChange.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange)
		{
			num ^= DiceCombatV2TacticsCardChange.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest)
		{
			num ^= DiceCombatV2DiceChangeRequest.GetHashCode();
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChange)
		{
			num ^= DiceCombatV2DiceChange.GetHashCode();
		}
		num ^= (int)gBFCMPACOPJCase_;
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
		if (QueuePosition != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(QueuePosition);
		}
		if (CHNHLKKKJHA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CHNHLKKKJHA);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameBegin)
		{
			output.WriteRawTag(170, 6);
			output.WriteMessage(MarbleGameBegin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameEnd)
		{
			output.WriteRawTag(178, 6);
			output.WriteMessage(MarbleGameEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameRound)
		{
			output.WriteRawTag(186, 6);
			output.WriteMessage(MarbleGameRound);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameTurn)
		{
			output.WriteRawTag(194, 6);
			output.WriteMessage(MarbleGameTurn);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionBegin)
		{
			output.WriteRawTag(202, 12);
			output.WriteMessage(CakeRaceSectionBegin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionEnd)
		{
			output.WriteRawTag(210, 12);
			output.WriteMessage(CakeRaceSectionEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle)
		{
			output.WriteRawTag(218, 12);
			output.WriteMessage(CakeRaceRoomSectionSettle);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatBegin)
		{
			output.WriteRawTag(218, 15);
			output.WriteMessage(DiceCombatBegin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatTurnEnd)
		{
			output.WriteRawTag(226, 15);
			output.WriteMessage(DiceCombatTurnEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatEnd)
		{
			output.WriteRawTag(234, 15);
			output.WriteMessage(DiceCombatEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2Begin)
		{
			output.WriteRawTag(170, 16);
			output.WriteMessage(DiceCombatV2Begin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2End)
		{
			output.WriteRawTag(178, 16);
			output.WriteMessage(DiceCombatV2End);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd)
		{
			output.WriteRawTag(186, 16);
			output.WriteMessage(DiceCombatV2TurnEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange)
		{
			output.WriteRawTag(194, 16);
			output.WriteMessage(DiceCombatV2TacticsPointChange);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange)
		{
			output.WriteRawTag(202, 16);
			output.WriteMessage(DiceCombatV2TacticsCardChange);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest)
		{
			output.WriteRawTag(210, 16);
			output.WriteMessage(DiceCombatV2DiceChangeRequest);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChange)
		{
			output.WriteRawTag(218, 16);
			output.WriteMessage(DiceCombatV2DiceChange);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (CHNHLKKKJHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHNHLKKKJHA);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameBegin)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MarbleGameBegin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameEnd)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MarbleGameEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameRound)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MarbleGameRound);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameTurn)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MarbleGameTurn);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionBegin)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CakeRaceSectionBegin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionEnd)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CakeRaceSectionEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CakeRaceRoomSectionSettle);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatBegin)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatBegin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatTurnEnd)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatTurnEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatEnd)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2Begin)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatV2Begin);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2End)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatV2End);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatV2TurnEnd);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatV2TacticsPointChange);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatV2TacticsCardChange);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatV2DiceChangeRequest);
		}
		if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChange)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DiceCombatV2DiceChange);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OMMELGEBNOG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		if (other.CHNHLKKKJHA != 0)
		{
			CHNHLKKKJHA = other.CHNHLKKKJHA;
		}
		switch (other.GBFCMPACOPJCase)
		{
		case GBFCMPACOPJOneofCase.MarbleGameBegin:
			if (MarbleGameBegin == null)
			{
				MarbleGameBegin = new HLNCNCNJGDL();
			}
			MarbleGameBegin.MergeFrom(other.MarbleGameBegin);
			break;
		case GBFCMPACOPJOneofCase.MarbleGameEnd:
			if (MarbleGameEnd == null)
			{
				MarbleGameEnd = new GNJBMILMKMB();
			}
			MarbleGameEnd.MergeFrom(other.MarbleGameEnd);
			break;
		case GBFCMPACOPJOneofCase.MarbleGameRound:
			if (MarbleGameRound == null)
			{
				MarbleGameRound = new CNEMCBJHACK();
			}
			MarbleGameRound.MergeFrom(other.MarbleGameRound);
			break;
		case GBFCMPACOPJOneofCase.MarbleGameTurn:
			if (MarbleGameTurn == null)
			{
				MarbleGameTurn = new BBIINELNDKH();
			}
			MarbleGameTurn.MergeFrom(other.MarbleGameTurn);
			break;
		case GBFCMPACOPJOneofCase.CakeRaceSectionBegin:
			if (CakeRaceSectionBegin == null)
			{
				CakeRaceSectionBegin = new FJJNFNALLGA();
			}
			CakeRaceSectionBegin.MergeFrom(other.CakeRaceSectionBegin);
			break;
		case GBFCMPACOPJOneofCase.CakeRaceSectionEnd:
			if (CakeRaceSectionEnd == null)
			{
				CakeRaceSectionEnd = new BBBJMJJOJDP();
			}
			CakeRaceSectionEnd.MergeFrom(other.CakeRaceSectionEnd);
			break;
		case GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle:
			if (CakeRaceRoomSectionSettle == null)
			{
				CakeRaceRoomSectionSettle = new PLECMCJNPIL();
			}
			CakeRaceRoomSectionSettle.MergeFrom(other.CakeRaceRoomSectionSettle);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatBegin:
			if (DiceCombatBegin == null)
			{
				DiceCombatBegin = new CEOELEOKPOF();
			}
			DiceCombatBegin.MergeFrom(other.DiceCombatBegin);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatTurnEnd:
			if (DiceCombatTurnEnd == null)
			{
				DiceCombatTurnEnd = new CKHFNKJNMLO();
			}
			DiceCombatTurnEnd.MergeFrom(other.DiceCombatTurnEnd);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatEnd:
			if (DiceCombatEnd == null)
			{
				DiceCombatEnd = new CAHPBBLMDCJ();
			}
			DiceCombatEnd.MergeFrom(other.DiceCombatEnd);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2Begin:
			if (DiceCombatV2Begin == null)
			{
				DiceCombatV2Begin = new IHBGAHNNEKI();
			}
			DiceCombatV2Begin.MergeFrom(other.DiceCombatV2Begin);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2End:
			if (DiceCombatV2End == null)
			{
				DiceCombatV2End = new JFIAMODBOIJ();
			}
			DiceCombatV2End.MergeFrom(other.DiceCombatV2End);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd:
			if (DiceCombatV2TurnEnd == null)
			{
				DiceCombatV2TurnEnd = new GODMJGAGNPA();
			}
			DiceCombatV2TurnEnd.MergeFrom(other.DiceCombatV2TurnEnd);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange:
			if (DiceCombatV2TacticsPointChange == null)
			{
				DiceCombatV2TacticsPointChange = new OMBGOODFIHB();
			}
			DiceCombatV2TacticsPointChange.MergeFrom(other.DiceCombatV2TacticsPointChange);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange:
			if (DiceCombatV2TacticsCardChange == null)
			{
				DiceCombatV2TacticsCardChange = new BCMKANNIKDP();
			}
			DiceCombatV2TacticsCardChange.MergeFrom(other.DiceCombatV2TacticsCardChange);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest:
			if (DiceCombatV2DiceChangeRequest == null)
			{
				DiceCombatV2DiceChangeRequest = new FLOEMBHNEPP();
			}
			DiceCombatV2DiceChangeRequest.MergeFrom(other.DiceCombatV2DiceChangeRequest);
			break;
		case GBFCMPACOPJOneofCase.DiceCombatV2DiceChange:
			if (DiceCombatV2DiceChange == null)
			{
				DiceCombatV2DiceChange = new FEBMHKKEHDG();
			}
			DiceCombatV2DiceChange.MergeFrom(other.DiceCombatV2DiceChange);
			break;
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
			case 8u:
				QueuePosition = input.ReadUInt32();
				break;
			case 16u:
				CHNHLKKKJHA = input.ReadUInt32();
				break;
			case 810u:
			{
				HLNCNCNJGDL hLNCNCNJGDL = new HLNCNCNJGDL();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameBegin)
				{
					hLNCNCNJGDL.MergeFrom(MarbleGameBegin);
				}
				input.ReadMessage(hLNCNCNJGDL);
				MarbleGameBegin = hLNCNCNJGDL;
				break;
			}
			case 818u:
			{
				GNJBMILMKMB gNJBMILMKMB = new GNJBMILMKMB();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameEnd)
				{
					gNJBMILMKMB.MergeFrom(MarbleGameEnd);
				}
				input.ReadMessage(gNJBMILMKMB);
				MarbleGameEnd = gNJBMILMKMB;
				break;
			}
			case 826u:
			{
				CNEMCBJHACK cNEMCBJHACK = new CNEMCBJHACK();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameRound)
				{
					cNEMCBJHACK.MergeFrom(MarbleGameRound);
				}
				input.ReadMessage(cNEMCBJHACK);
				MarbleGameRound = cNEMCBJHACK;
				break;
			}
			case 834u:
			{
				BBIINELNDKH bBIINELNDKH = new BBIINELNDKH();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.MarbleGameTurn)
				{
					bBIINELNDKH.MergeFrom(MarbleGameTurn);
				}
				input.ReadMessage(bBIINELNDKH);
				MarbleGameTurn = bBIINELNDKH;
				break;
			}
			case 1610u:
			{
				FJJNFNALLGA fJJNFNALLGA = new FJJNFNALLGA();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionBegin)
				{
					fJJNFNALLGA.MergeFrom(CakeRaceSectionBegin);
				}
				input.ReadMessage(fJJNFNALLGA);
				CakeRaceSectionBegin = fJJNFNALLGA;
				break;
			}
			case 1618u:
			{
				BBBJMJJOJDP bBBJMJJOJDP = new BBBJMJJOJDP();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceSectionEnd)
				{
					bBBJMJJOJDP.MergeFrom(CakeRaceSectionEnd);
				}
				input.ReadMessage(bBBJMJJOJDP);
				CakeRaceSectionEnd = bBBJMJJOJDP;
				break;
			}
			case 1626u:
			{
				PLECMCJNPIL pLECMCJNPIL = new PLECMCJNPIL();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.CakeRaceRoomSectionSettle)
				{
					pLECMCJNPIL.MergeFrom(CakeRaceRoomSectionSettle);
				}
				input.ReadMessage(pLECMCJNPIL);
				CakeRaceRoomSectionSettle = pLECMCJNPIL;
				break;
			}
			case 2010u:
			{
				CEOELEOKPOF cEOELEOKPOF = new CEOELEOKPOF();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatBegin)
				{
					cEOELEOKPOF.MergeFrom(DiceCombatBegin);
				}
				input.ReadMessage(cEOELEOKPOF);
				DiceCombatBegin = cEOELEOKPOF;
				break;
			}
			case 2018u:
			{
				CKHFNKJNMLO cKHFNKJNMLO = new CKHFNKJNMLO();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatTurnEnd)
				{
					cKHFNKJNMLO.MergeFrom(DiceCombatTurnEnd);
				}
				input.ReadMessage(cKHFNKJNMLO);
				DiceCombatTurnEnd = cKHFNKJNMLO;
				break;
			}
			case 2026u:
			{
				CAHPBBLMDCJ cAHPBBLMDCJ = new CAHPBBLMDCJ();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatEnd)
				{
					cAHPBBLMDCJ.MergeFrom(DiceCombatEnd);
				}
				input.ReadMessage(cAHPBBLMDCJ);
				DiceCombatEnd = cAHPBBLMDCJ;
				break;
			}
			case 2090u:
			{
				IHBGAHNNEKI iHBGAHNNEKI = new IHBGAHNNEKI();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2Begin)
				{
					iHBGAHNNEKI.MergeFrom(DiceCombatV2Begin);
				}
				input.ReadMessage(iHBGAHNNEKI);
				DiceCombatV2Begin = iHBGAHNNEKI;
				break;
			}
			case 2098u:
			{
				JFIAMODBOIJ jFIAMODBOIJ = new JFIAMODBOIJ();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2End)
				{
					jFIAMODBOIJ.MergeFrom(DiceCombatV2End);
				}
				input.ReadMessage(jFIAMODBOIJ);
				DiceCombatV2End = jFIAMODBOIJ;
				break;
			}
			case 2106u:
			{
				GODMJGAGNPA gODMJGAGNPA = new GODMJGAGNPA();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TurnEnd)
				{
					gODMJGAGNPA.MergeFrom(DiceCombatV2TurnEnd);
				}
				input.ReadMessage(gODMJGAGNPA);
				DiceCombatV2TurnEnd = gODMJGAGNPA;
				break;
			}
			case 2114u:
			{
				OMBGOODFIHB oMBGOODFIHB = new OMBGOODFIHB();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsPointChange)
				{
					oMBGOODFIHB.MergeFrom(DiceCombatV2TacticsPointChange);
				}
				input.ReadMessage(oMBGOODFIHB);
				DiceCombatV2TacticsPointChange = oMBGOODFIHB;
				break;
			}
			case 2122u:
			{
				BCMKANNIKDP bCMKANNIKDP = new BCMKANNIKDP();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2TacticsCardChange)
				{
					bCMKANNIKDP.MergeFrom(DiceCombatV2TacticsCardChange);
				}
				input.ReadMessage(bCMKANNIKDP);
				DiceCombatV2TacticsCardChange = bCMKANNIKDP;
				break;
			}
			case 2130u:
			{
				FLOEMBHNEPP fLOEMBHNEPP = new FLOEMBHNEPP();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChangeRequest)
				{
					fLOEMBHNEPP.MergeFrom(DiceCombatV2DiceChangeRequest);
				}
				input.ReadMessage(fLOEMBHNEPP);
				DiceCombatV2DiceChangeRequest = fLOEMBHNEPP;
				break;
			}
			case 2138u:
			{
				FEBMHKKEHDG fEBMHKKEHDG = new FEBMHKKEHDG();
				if (gBFCMPACOPJCase_ == GBFCMPACOPJOneofCase.DiceCombatV2DiceChange)
				{
					fEBMHKKEHDG.MergeFrom(DiceCombatV2DiceChange);
				}
				input.ReadMessage(fEBMHKKEHDG);
				DiceCombatV2DiceChange = fEBMHKKEHDG;
				break;
			}
			}
		}
	}
}
