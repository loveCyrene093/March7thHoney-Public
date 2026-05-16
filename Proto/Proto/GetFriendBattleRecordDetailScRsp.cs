using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendBattleRecordDetailScRsp : IMessage<GetFriendBattleRecordDetailScRsp>, IMessage, IEquatable<GetFriendBattleRecordDetailScRsp>, IDeepCloneable<GetFriendBattleRecordDetailScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFriendBattleRecordDetailScRsp> _parser = new MessageParser<GetFriendBattleRecordDetailScRsp>(() => new GetFriendBattleRecordDetailScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PAEEBAGOEDJFieldNumber = 1;

	private static readonly FieldCodec<NCLCIIMIHDH> _repeated_pAEEBAGOEDJ_codec = FieldCodec.ForMessage(10u, NCLCIIMIHDH.Parser);

	private readonly RepeatedField<NCLCIIMIHDH> pAEEBAGOEDJ_ = new RepeatedField<NCLCIIMIHDH>();

	public const int KIIONJBDKNJFieldNumber = 6;

	private HBNJABPHLML kIIONJBDKNJ_;

	public const int ENCPHHLDNLBFieldNumber = 9;

	private PKECJPJCONJ eNCPHHLDNLB_;

	public const int BIKINNADKFKFieldNumber = 12;

	private static readonly FieldCodec<FriendChallengeClearanceInfo> _repeated_bIKINNADKFK_codec = FieldCodec.ForMessage(98u, FriendChallengeClearanceInfo.Parser);

	private readonly RepeatedField<FriendChallengeClearanceInfo> bIKINNADKFK_ = new RepeatedField<FriendChallengeClearanceInfo>();

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int UidFieldNumber = 15;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendBattleRecordDetailScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendBattleRecordDetailScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NCLCIIMIHDH> PAEEBAGOEDJ => pAEEBAGOEDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBNJABPHLML KIIONJBDKNJ
	{
		get
		{
			return kIIONJBDKNJ_;
		}
		set
		{
			kIIONJBDKNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKECJPJCONJ ENCPHHLDNLB
	{
		get
		{
			return eNCPHHLDNLB_;
		}
		set
		{
			eNCPHHLDNLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FriendChallengeClearanceInfo> BIKINNADKFK => bIKINNADKFK_;

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
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendBattleRecordDetailScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendBattleRecordDetailScRsp(GetFriendBattleRecordDetailScRsp other)
		: this()
	{
		pAEEBAGOEDJ_ = other.pAEEBAGOEDJ_.Clone();
		kIIONJBDKNJ_ = ((other.kIIONJBDKNJ_ != null) ? other.kIIONJBDKNJ_.Clone() : null);
		eNCPHHLDNLB_ = ((other.eNCPHHLDNLB_ != null) ? other.eNCPHHLDNLB_.Clone() : null);
		bIKINNADKFK_ = other.bIKINNADKFK_.Clone();
		retcode_ = other.retcode_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendBattleRecordDetailScRsp Clone()
	{
		return new GetFriendBattleRecordDetailScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendBattleRecordDetailScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendBattleRecordDetailScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pAEEBAGOEDJ_.Equals(other.pAEEBAGOEDJ_))
		{
			return false;
		}
		if (!object.Equals(KIIONJBDKNJ, other.KIIONJBDKNJ))
		{
			return false;
		}
		if (!object.Equals(ENCPHHLDNLB, other.ENCPHHLDNLB))
		{
			return false;
		}
		if (!bIKINNADKFK_.Equals(other.bIKINNADKFK_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		num ^= pAEEBAGOEDJ_.GetHashCode();
		if (kIIONJBDKNJ_ != null)
		{
			num ^= KIIONJBDKNJ.GetHashCode();
		}
		if (eNCPHHLDNLB_ != null)
		{
			num ^= ENCPHHLDNLB.GetHashCode();
		}
		num ^= bIKINNADKFK_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		pAEEBAGOEDJ_.WriteTo(ref output, _repeated_pAEEBAGOEDJ_codec);
		if (kIIONJBDKNJ_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(KIIONJBDKNJ);
		}
		if (eNCPHHLDNLB_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ENCPHHLDNLB);
		}
		bIKINNADKFK_.WriteTo(ref output, _repeated_bIKINNADKFK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Uid);
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
		num += pAEEBAGOEDJ_.CalculateSize(_repeated_pAEEBAGOEDJ_codec);
		if (kIIONJBDKNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KIIONJBDKNJ);
		}
		if (eNCPHHLDNLB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENCPHHLDNLB);
		}
		num += bIKINNADKFK_.CalculateSize(_repeated_bIKINNADKFK_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendBattleRecordDetailScRsp other)
	{
		if (other == null)
		{
			return;
		}
		pAEEBAGOEDJ_.Add(other.pAEEBAGOEDJ_);
		if (other.kIIONJBDKNJ_ != null)
		{
			if (kIIONJBDKNJ_ == null)
			{
				KIIONJBDKNJ = new HBNJABPHLML();
			}
			KIIONJBDKNJ.MergeFrom(other.KIIONJBDKNJ);
		}
		if (other.eNCPHHLDNLB_ != null)
		{
			if (eNCPHHLDNLB_ == null)
			{
				ENCPHHLDNLB = new PKECJPJCONJ();
			}
			ENCPHHLDNLB.MergeFrom(other.ENCPHHLDNLB);
		}
		bIKINNADKFK_.Add(other.bIKINNADKFK_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
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
				pAEEBAGOEDJ_.AddEntriesFrom(ref input, _repeated_pAEEBAGOEDJ_codec);
				break;
			case 50u:
				if (kIIONJBDKNJ_ == null)
				{
					KIIONJBDKNJ = new HBNJABPHLML();
				}
				input.ReadMessage(KIIONJBDKNJ);
				break;
			case 74u:
				if (eNCPHHLDNLB_ == null)
				{
					ENCPHHLDNLB = new PKECJPJCONJ();
				}
				input.ReadMessage(ENCPHHLDNLB);
				break;
			case 98u:
				bIKINNADKFK_.AddEntriesFrom(ref input, _repeated_bIKINNADKFK_codec);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
