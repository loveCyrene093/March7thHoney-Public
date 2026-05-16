using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRaidInfoScRsp : IMessage<GetRaidInfoScRsp>, IMessage, IEquatable<GetRaidInfoScRsp>, IDeepCloneable<GetRaidInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRaidInfoScRsp> _parser = new MessageParser<GetRaidInfoScRsp>(() => new GetRaidInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeTakenRewardIdListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_challengeTakenRewardIdList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> challengeTakenRewardIdList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int ChallengeRaidListFieldNumber = 13;

	private static readonly FieldCodec<ENDOLEJCHKP> _repeated_challengeRaidList_codec = FieldCodec.ForMessage(106u, ENDOLEJCHKP.Parser);

	private readonly RepeatedField<ENDOLEJCHKP> challengeRaidList_ = new RepeatedField<ENDOLEJCHKP>();

	public const int FinishedRaidInfoListFieldNumber = 14;

	private static readonly FieldCodec<FinishedRaidInfo> _repeated_finishedRaidInfoList_codec = FieldCodec.ForMessage(114u, FinishedRaidInfo.Parser);

	private readonly RepeatedField<FinishedRaidInfo> finishedRaidInfoList_ = new RepeatedField<FinishedRaidInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRaidInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRaidInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ChallengeTakenRewardIdList => challengeTakenRewardIdList_;

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
	public RepeatedField<ENDOLEJCHKP> ChallengeRaidList => challengeRaidList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FinishedRaidInfo> FinishedRaidInfoList => finishedRaidInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRaidInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRaidInfoScRsp(GetRaidInfoScRsp other)
		: this()
	{
		challengeTakenRewardIdList_ = other.challengeTakenRewardIdList_.Clone();
		retcode_ = other.retcode_;
		challengeRaidList_ = other.challengeRaidList_.Clone();
		finishedRaidInfoList_ = other.finishedRaidInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRaidInfoScRsp Clone()
	{
		return new GetRaidInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRaidInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRaidInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!challengeTakenRewardIdList_.Equals(other.challengeTakenRewardIdList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!challengeRaidList_.Equals(other.challengeRaidList_))
		{
			return false;
		}
		if (!finishedRaidInfoList_.Equals(other.finishedRaidInfoList_))
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
		num ^= challengeTakenRewardIdList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= challengeRaidList_.GetHashCode();
		num ^= finishedRaidInfoList_.GetHashCode();
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
		challengeTakenRewardIdList_.WriteTo(ref output, _repeated_challengeTakenRewardIdList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		challengeRaidList_.WriteTo(ref output, _repeated_challengeRaidList_codec);
		finishedRaidInfoList_.WriteTo(ref output, _repeated_finishedRaidInfoList_codec);
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
		num += challengeTakenRewardIdList_.CalculateSize(_repeated_challengeTakenRewardIdList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += challengeRaidList_.CalculateSize(_repeated_challengeRaidList_codec);
		num += finishedRaidInfoList_.CalculateSize(_repeated_finishedRaidInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRaidInfoScRsp other)
	{
		if (other != null)
		{
			challengeTakenRewardIdList_.Add(other.challengeTakenRewardIdList_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			challengeRaidList_.Add(other.challengeRaidList_);
			finishedRaidInfoList_.Add(other.finishedRaidInfoList_);
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
			case 56u:
			case 58u:
				challengeTakenRewardIdList_.AddEntriesFrom(ref input, _repeated_challengeTakenRewardIdList_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				challengeRaidList_.AddEntriesFrom(ref input, _repeated_challengeRaidList_codec);
				break;
			case 114u:
				finishedRaidInfoList_.AddEntriesFrom(ref input, _repeated_finishedRaidInfoList_codec);
				break;
			}
		}
	}
}
