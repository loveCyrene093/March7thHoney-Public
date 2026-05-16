using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChallengeScRsp : IMessage<GetChallengeScRsp>, IMessage, IEquatable<GetChallengeScRsp>, IDeepCloneable<GetChallengeScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetChallengeScRsp> _parser = new MessageParser<GetChallengeScRsp>(() => new GetChallengeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MHAPIHCJPJMFieldNumber = 1;

	private uint mHAPIHCJPJM_;

	public const int ChallengeListFieldNumber = 4;

	private static readonly FieldCodec<Challenge> _repeated_challengeList_codec = FieldCodec.ForMessage(34u, Challenge.Parser);

	private readonly RepeatedField<Challenge> challengeList_ = new RepeatedField<Challenge>();

	public const int ChallengeGroupListFieldNumber = 8;

	private static readonly FieldCodec<ChallengeGroup> _repeated_challengeGroupList_codec = FieldCodec.ForMessage(66u, ChallengeGroup.Parser);

	private readonly RepeatedField<ChallengeGroup> challengeGroupList_ = new RepeatedField<ChallengeGroup>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int MaxLevelListFieldNumber = 12;

	private static readonly FieldCodec<ChallengeHistoryMaxLevel> _repeated_maxLevelList_codec = FieldCodec.ForMessage(98u, ChallengeHistoryMaxLevel.Parser);

	private readonly RepeatedField<ChallengeHistoryMaxLevel> maxLevelList_ = new RepeatedField<ChallengeHistoryMaxLevel>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChallengeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChallengeScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHAPIHCJPJM
	{
		get
		{
			return mHAPIHCJPJM_;
		}
		set
		{
			mHAPIHCJPJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Challenge> ChallengeList => challengeList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChallengeGroup> ChallengeGroupList => challengeGroupList_;

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
	public RepeatedField<ChallengeHistoryMaxLevel> MaxLevelList => maxLevelList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChallengeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChallengeScRsp(GetChallengeScRsp other)
		: this()
	{
		mHAPIHCJPJM_ = other.mHAPIHCJPJM_;
		challengeList_ = other.challengeList_.Clone();
		challengeGroupList_ = other.challengeGroupList_.Clone();
		retcode_ = other.retcode_;
		maxLevelList_ = other.maxLevelList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChallengeScRsp Clone()
	{
		return new GetChallengeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetChallengeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChallengeScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MHAPIHCJPJM != other.MHAPIHCJPJM)
		{
			return false;
		}
		if (!challengeList_.Equals(other.challengeList_))
		{
			return false;
		}
		if (!challengeGroupList_.Equals(other.challengeGroupList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!maxLevelList_.Equals(other.maxLevelList_))
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
		if (MHAPIHCJPJM != 0)
		{
			num ^= MHAPIHCJPJM.GetHashCode();
		}
		num ^= challengeList_.GetHashCode();
		num ^= challengeGroupList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= maxLevelList_.GetHashCode();
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
		if (MHAPIHCJPJM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MHAPIHCJPJM);
		}
		challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
		challengeGroupList_.WriteTo(ref output, _repeated_challengeGroupList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		maxLevelList_.WriteTo(ref output, _repeated_maxLevelList_codec);
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
		if (MHAPIHCJPJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHAPIHCJPJM);
		}
		num += challengeList_.CalculateSize(_repeated_challengeList_codec);
		num += challengeGroupList_.CalculateSize(_repeated_challengeGroupList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += maxLevelList_.CalculateSize(_repeated_maxLevelList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetChallengeScRsp other)
	{
		if (other != null)
		{
			if (other.MHAPIHCJPJM != 0)
			{
				MHAPIHCJPJM = other.MHAPIHCJPJM;
			}
			challengeList_.Add(other.challengeList_);
			challengeGroupList_.Add(other.challengeGroupList_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			maxLevelList_.Add(other.maxLevelList_);
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
				MHAPIHCJPJM = input.ReadUInt32();
				break;
			case 34u:
				challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
				break;
			case 66u:
				challengeGroupList_.AddEntriesFrom(ref input, _repeated_challengeGroupList_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				maxLevelList_.AddEntriesFrom(ref input, _repeated_maxLevelList_codec);
				break;
			}
		}
	}
}
