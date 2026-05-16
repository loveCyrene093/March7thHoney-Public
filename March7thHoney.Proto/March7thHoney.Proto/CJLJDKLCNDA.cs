using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CJLJDKLCNDA : IMessage<CJLJDKLCNDA>, IMessage, IEquatable<CJLJDKLCNDA>, IDeepCloneable<CJLJDKLCNDA>, IBufferMessage
{
	private static readonly MessageParser<CJLJDKLCNDA> _parser = new MessageParser<CJLJDKLCNDA>(() => new CJLJDKLCNDA());

	private UnknownFieldSet _unknownFields;

	public const int RoundCntFieldNumber = 6;

	private uint roundCnt_;

	public const int BattleInfoFieldNumber = 9;

	private BattleGridFightSpecialBattleInfo battleInfo_;

	public const int BattleTargetListFieldNumber = 10;

	private static readonly FieldCodec<BattleTarget> _repeated_battleTargetList_codec = FieldCodec.ForMessage(82u, BattleTarget.Parser);

	private readonly RepeatedField<BattleTarget> battleTargetList_ = new RepeatedField<BattleTarget>();

	public const int EGLCKGKECAJFieldNumber = 11;

	private GCHPNHBDCDO eGLCKGKECAJ_;

	public const int KCOKNIJECLNFieldNumber = 12;

	private uint kCOKNIJECLN_;

	public const int AvatarListFieldNumber = 14;

	private static readonly FieldCodec<MOEDGOHOALP> _repeated_avatarList_codec = FieldCodec.ForMessage(114u, MOEDGOHOALP.Parser);

	private readonly RepeatedField<MOEDGOHOALP> avatarList_ = new RepeatedField<MOEDGOHOALP>();

	public const int IEPGKLIDHEKFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_iEPGKLIDHEK_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> iEPGKLIDHEK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CJLJDKLCNDA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CJLJDKLCNDAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoundCnt
	{
		get
		{
			return roundCnt_;
		}
		set
		{
			roundCnt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightSpecialBattleInfo BattleInfo
	{
		get
		{
			return battleInfo_;
		}
		set
		{
			battleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleTarget> BattleTargetList => battleTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCHPNHBDCDO EGLCKGKECAJ
	{
		get
		{
			return eGLCKGKECAJ_;
		}
		set
		{
			eGLCKGKECAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KCOKNIJECLN
	{
		get
		{
			return kCOKNIJECLN_;
		}
		set
		{
			kCOKNIJECLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MOEDGOHOALP> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IEPGKLIDHEK => iEPGKLIDHEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJLJDKLCNDA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJLJDKLCNDA(CJLJDKLCNDA other)
		: this()
	{
		roundCnt_ = other.roundCnt_;
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		battleTargetList_ = other.battleTargetList_.Clone();
		eGLCKGKECAJ_ = other.eGLCKGKECAJ_;
		kCOKNIJECLN_ = other.kCOKNIJECLN_;
		avatarList_ = other.avatarList_.Clone();
		iEPGKLIDHEK_ = other.iEPGKLIDHEK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJLJDKLCNDA Clone()
	{
		return new CJLJDKLCNDA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CJLJDKLCNDA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CJLJDKLCNDA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoundCnt != other.RoundCnt)
		{
			return false;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (!battleTargetList_.Equals(other.battleTargetList_))
		{
			return false;
		}
		if (EGLCKGKECAJ != other.EGLCKGKECAJ)
		{
			return false;
		}
		if (KCOKNIJECLN != other.KCOKNIJECLN)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!iEPGKLIDHEK_.Equals(other.iEPGKLIDHEK_))
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
		if (RoundCnt != 0)
		{
			num ^= RoundCnt.GetHashCode();
		}
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		num ^= battleTargetList_.GetHashCode();
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num ^= EGLCKGKECAJ.GetHashCode();
		}
		if (KCOKNIJECLN != 0)
		{
			num ^= KCOKNIJECLN.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		num ^= iEPGKLIDHEK_.GetHashCode();
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
		if (RoundCnt != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(RoundCnt);
		}
		if (battleInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(BattleInfo);
		}
		battleTargetList_.WriteTo(ref output, _repeated_battleTargetList_codec);
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)EGLCKGKECAJ);
		}
		if (KCOKNIJECLN != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KCOKNIJECLN);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		iEPGKLIDHEK_.WriteTo(ref output, _repeated_iEPGKLIDHEK_codec);
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
		if (RoundCnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundCnt);
		}
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		num += battleTargetList_.CalculateSize(_repeated_battleTargetList_codec);
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EGLCKGKECAJ);
		}
		if (KCOKNIJECLN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KCOKNIJECLN);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += iEPGKLIDHEK_.CalculateSize(_repeated_iEPGKLIDHEK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CJLJDKLCNDA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoundCnt != 0)
		{
			RoundCnt = other.RoundCnt;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new BattleGridFightSpecialBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		battleTargetList_.Add(other.battleTargetList_);
		if (other.EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			EGLCKGKECAJ = other.EGLCKGKECAJ;
		}
		if (other.KCOKNIJECLN != 0)
		{
			KCOKNIJECLN = other.KCOKNIJECLN;
		}
		avatarList_.Add(other.avatarList_);
		iEPGKLIDHEK_.Add(other.iEPGKLIDHEK_);
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
			case 48u:
				RoundCnt = input.ReadUInt32();
				break;
			case 74u:
				if (battleInfo_ == null)
				{
					BattleInfo = new BattleGridFightSpecialBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 82u:
				battleTargetList_.AddEntriesFrom(ref input, _repeated_battleTargetList_codec);
				break;
			case 88u:
				EGLCKGKECAJ = (GCHPNHBDCDO)input.ReadEnum();
				break;
			case 96u:
				KCOKNIJECLN = input.ReadUInt32();
				break;
			case 114u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 120u:
			case 122u:
				iEPGKLIDHEK_.AddEntriesFrom(ref input, _repeated_iEPGKLIDHEK_codec);
				break;
			}
		}
	}
}
