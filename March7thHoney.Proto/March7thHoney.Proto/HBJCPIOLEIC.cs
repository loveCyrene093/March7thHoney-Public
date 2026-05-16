using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HBJCPIOLEIC : IMessage<HBJCPIOLEIC>, IMessage, IEquatable<HBJCPIOLEIC>, IDeepCloneable<HBJCPIOLEIC>, IBufferMessage
{
	public enum HDOEFOCHLDAOneofCase
	{
		None = 0,
		DFMBOIDDHNM = 1,
		KJKFCLDDBKM = 2,
		LCEBFBHALHA = 3,
		FEACMLLOAFB = 12
	}

	private static readonly MessageParser<HBJCPIOLEIC> _parser = new MessageParser<HBJCPIOLEIC>(() => new HBJCPIOLEIC());

	private UnknownFieldSet _unknownFields;

	public const int PlayerInfoFieldNumber = 4;

	private PlayerSimpleInfo playerInfo_;

	public const int RemarkNameFieldNumber = 10;

	private string remarkName_ = "";

	public const int DFMBOIDDHNMFieldNumber = 1;

	public const int KJKFCLDDBKMFieldNumber = 2;

	public const int LCEBFBHALHAFieldNumber = 3;

	public const int FEACMLLOAFBFieldNumber = 12;

	private object hDOEFOCHLDA_;

	private HDOEFOCHLDAOneofCase hDOEFOCHLDACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HBJCPIOLEIC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HBJCPIOLEICReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo PlayerInfo
	{
		get
		{
			return playerInfo_;
		}
		set
		{
			playerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RemarkName
	{
		get
		{
			return remarkName_;
		}
		set
		{
			remarkName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLFIIPBIBBG DFMBOIDDHNM
	{
		get
		{
			if (hDOEFOCHLDACase_ != HDOEFOCHLDAOneofCase.DFMBOIDDHNM)
			{
				return null;
			}
			return (CLFIIPBIBBG)hDOEFOCHLDA_;
		}
		set
		{
			hDOEFOCHLDA_ = value;
			hDOEFOCHLDACase_ = ((value != null) ? HDOEFOCHLDAOneofCase.DFMBOIDDHNM : HDOEFOCHLDAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendChallengeLineup KJKFCLDDBKM
	{
		get
		{
			if (hDOEFOCHLDACase_ != HDOEFOCHLDAOneofCase.KJKFCLDDBKM)
			{
				return null;
			}
			return (FriendChallengeLineup)hDOEFOCHLDA_;
		}
		set
		{
			hDOEFOCHLDA_ = value;
			hDOEFOCHLDACase_ = ((value != null) ? HDOEFOCHLDAOneofCase.KJKFCLDDBKM : HDOEFOCHLDAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFGHKGDKCLB LCEBFBHALHA
	{
		get
		{
			if (hDOEFOCHLDACase_ != HDOEFOCHLDAOneofCase.LCEBFBHALHA)
			{
				return null;
			}
			return (DFGHKGDKCLB)hDOEFOCHLDA_;
		}
		set
		{
			hDOEFOCHLDA_ = value;
			hDOEFOCHLDACase_ = ((value != null) ? HDOEFOCHLDAOneofCase.LCEBFBHALHA : HDOEFOCHLDAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBossFriendLineupRecommendation FEACMLLOAFB
	{
		get
		{
			if (hDOEFOCHLDACase_ != HDOEFOCHLDAOneofCase.FEACMLLOAFB)
			{
				return null;
			}
			return (ChallengePeakBossFriendLineupRecommendation)hDOEFOCHLDA_;
		}
		set
		{
			hDOEFOCHLDA_ = value;
			hDOEFOCHLDACase_ = ((value != null) ? HDOEFOCHLDAOneofCase.FEACMLLOAFB : HDOEFOCHLDAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDOEFOCHLDAOneofCase HDOEFOCHLDACase => hDOEFOCHLDACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBJCPIOLEIC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBJCPIOLEIC(HBJCPIOLEIC other)
		: this()
	{
		playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
		remarkName_ = other.remarkName_;
		switch (other.HDOEFOCHLDACase)
		{
		case HDOEFOCHLDAOneofCase.DFMBOIDDHNM:
			DFMBOIDDHNM = other.DFMBOIDDHNM.Clone();
			break;
		case HDOEFOCHLDAOneofCase.KJKFCLDDBKM:
			KJKFCLDDBKM = other.KJKFCLDDBKM.Clone();
			break;
		case HDOEFOCHLDAOneofCase.LCEBFBHALHA:
			LCEBFBHALHA = other.LCEBFBHALHA.Clone();
			break;
		case HDOEFOCHLDAOneofCase.FEACMLLOAFB:
			FEACMLLOAFB = other.FEACMLLOAFB.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBJCPIOLEIC Clone()
	{
		return new HBJCPIOLEIC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHDOEFOCHLDA()
	{
		hDOEFOCHLDACase_ = HDOEFOCHLDAOneofCase.None;
		hDOEFOCHLDA_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HBJCPIOLEIC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HBJCPIOLEIC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PlayerInfo, other.PlayerInfo))
		{
			return false;
		}
		if (RemarkName != other.RemarkName)
		{
			return false;
		}
		if (!object.Equals(DFMBOIDDHNM, other.DFMBOIDDHNM))
		{
			return false;
		}
		if (!object.Equals(KJKFCLDDBKM, other.KJKFCLDDBKM))
		{
			return false;
		}
		if (!object.Equals(LCEBFBHALHA, other.LCEBFBHALHA))
		{
			return false;
		}
		if (!object.Equals(FEACMLLOAFB, other.FEACMLLOAFB))
		{
			return false;
		}
		if (HDOEFOCHLDACase != other.HDOEFOCHLDACase)
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
		if (playerInfo_ != null)
		{
			num ^= PlayerInfo.GetHashCode();
		}
		if (RemarkName.Length != 0)
		{
			num ^= RemarkName.GetHashCode();
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.DFMBOIDDHNM)
		{
			num ^= DFMBOIDDHNM.GetHashCode();
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.KJKFCLDDBKM)
		{
			num ^= KJKFCLDDBKM.GetHashCode();
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.LCEBFBHALHA)
		{
			num ^= LCEBFBHALHA.GetHashCode();
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.FEACMLLOAFB)
		{
			num ^= FEACMLLOAFB.GetHashCode();
		}
		num ^= (int)hDOEFOCHLDACase_;
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
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.DFMBOIDDHNM)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DFMBOIDDHNM);
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.KJKFCLDDBKM)
		{
			output.WriteRawTag(18);
			output.WriteMessage(KJKFCLDDBKM);
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.LCEBFBHALHA)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LCEBFBHALHA);
		}
		if (playerInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerInfo);
		}
		if (RemarkName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(RemarkName);
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.FEACMLLOAFB)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FEACMLLOAFB);
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
		if (playerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerInfo);
		}
		if (RemarkName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RemarkName);
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.DFMBOIDDHNM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DFMBOIDDHNM);
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.KJKFCLDDBKM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KJKFCLDDBKM);
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.LCEBFBHALHA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LCEBFBHALHA);
		}
		if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.FEACMLLOAFB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEACMLLOAFB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HBJCPIOLEIC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.playerInfo_ != null)
		{
			if (playerInfo_ == null)
			{
				PlayerInfo = new PlayerSimpleInfo();
			}
			PlayerInfo.MergeFrom(other.PlayerInfo);
		}
		if (other.RemarkName.Length != 0)
		{
			RemarkName = other.RemarkName;
		}
		switch (other.HDOEFOCHLDACase)
		{
		case HDOEFOCHLDAOneofCase.DFMBOIDDHNM:
			if (DFMBOIDDHNM == null)
			{
				DFMBOIDDHNM = new CLFIIPBIBBG();
			}
			DFMBOIDDHNM.MergeFrom(other.DFMBOIDDHNM);
			break;
		case HDOEFOCHLDAOneofCase.KJKFCLDDBKM:
			if (KJKFCLDDBKM == null)
			{
				KJKFCLDDBKM = new FriendChallengeLineup();
			}
			KJKFCLDDBKM.MergeFrom(other.KJKFCLDDBKM);
			break;
		case HDOEFOCHLDAOneofCase.LCEBFBHALHA:
			if (LCEBFBHALHA == null)
			{
				LCEBFBHALHA = new DFGHKGDKCLB();
			}
			LCEBFBHALHA.MergeFrom(other.LCEBFBHALHA);
			break;
		case HDOEFOCHLDAOneofCase.FEACMLLOAFB:
			if (FEACMLLOAFB == null)
			{
				FEACMLLOAFB = new ChallengePeakBossFriendLineupRecommendation();
			}
			FEACMLLOAFB.MergeFrom(other.FEACMLLOAFB);
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
			case 10u:
			{
				CLFIIPBIBBG cLFIIPBIBBG = new CLFIIPBIBBG();
				if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.DFMBOIDDHNM)
				{
					cLFIIPBIBBG.MergeFrom(DFMBOIDDHNM);
				}
				input.ReadMessage(cLFIIPBIBBG);
				DFMBOIDDHNM = cLFIIPBIBBG;
				break;
			}
			case 18u:
			{
				FriendChallengeLineup friendChallengeLineup = new FriendChallengeLineup();
				if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.KJKFCLDDBKM)
				{
					friendChallengeLineup.MergeFrom(KJKFCLDDBKM);
				}
				input.ReadMessage(friendChallengeLineup);
				KJKFCLDDBKM = friendChallengeLineup;
				break;
			}
			case 26u:
			{
				DFGHKGDKCLB dFGHKGDKCLB = new DFGHKGDKCLB();
				if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.LCEBFBHALHA)
				{
					dFGHKGDKCLB.MergeFrom(LCEBFBHALHA);
				}
				input.ReadMessage(dFGHKGDKCLB);
				LCEBFBHALHA = dFGHKGDKCLB;
				break;
			}
			case 34u:
				if (playerInfo_ == null)
				{
					PlayerInfo = new PlayerSimpleInfo();
				}
				input.ReadMessage(PlayerInfo);
				break;
			case 82u:
				RemarkName = input.ReadString();
				break;
			case 98u:
			{
				ChallengePeakBossFriendLineupRecommendation challengePeakBossFriendLineupRecommendation = new ChallengePeakBossFriendLineupRecommendation();
				if (hDOEFOCHLDACase_ == HDOEFOCHLDAOneofCase.FEACMLLOAFB)
				{
					challengePeakBossFriendLineupRecommendation.MergeFrom(FEACMLLOAFB);
				}
				input.ReadMessage(challengePeakBossFriendLineupRecommendation);
				FEACMLLOAFB = challengePeakBossFriendLineupRecommendation;
				break;
			}
			}
		}
	}
}
