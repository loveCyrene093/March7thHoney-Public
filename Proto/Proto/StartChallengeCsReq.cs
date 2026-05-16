using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartChallengeCsReq : IMessage<StartChallengeCsReq>, IMessage, IEquatable<StartChallengeCsReq>, IDeepCloneable<StartChallengeCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartChallengeCsReq> _parser = new MessageParser<StartChallengeCsReq>(() => new StartChallengeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ABNDFKFIKCIFieldNumber = 2;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_aBNDFKFIKCI_codec = FieldCodec.ForMessage(18u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> aBNDFKFIKCI_ = new RepeatedField<EEBPHJCNBFO>();

	public const int ChallengeIdFieldNumber = 5;

	private uint challengeId_;

	public const int StageInfoFieldNumber = 8;

	private ChallengeBuffInfo stageInfo_;

	public const int SecondLineupFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_secondLineup_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> secondLineup_ = new RepeatedField<uint>();

	public const int FirstLineupFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_firstLineup_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> firstLineup_ = new RepeatedField<uint>();

	public const int BKNKLEOCJNOFieldNumber = 13;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_bKNKLEOCJNO_codec = FieldCodec.ForMessage(106u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> bKNKLEOCJNO_ = new RepeatedField<EEBPHJCNBFO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartChallengeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartChallengeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> ABNDFKFIKCI => aBNDFKFIKCI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeId
	{
		get
		{
			return challengeId_;
		}
		set
		{
			challengeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBuffInfo StageInfo
	{
		get
		{
			return stageInfo_;
		}
		set
		{
			stageInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SecondLineup => secondLineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FirstLineup => firstLineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> BKNKLEOCJNO => bKNKLEOCJNO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengeCsReq(StartChallengeCsReq other)
		: this()
	{
		aBNDFKFIKCI_ = other.aBNDFKFIKCI_.Clone();
		challengeId_ = other.challengeId_;
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		secondLineup_ = other.secondLineup_.Clone();
		firstLineup_ = other.firstLineup_.Clone();
		bKNKLEOCJNO_ = other.bKNKLEOCJNO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengeCsReq Clone()
	{
		return new StartChallengeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartChallengeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartChallengeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aBNDFKFIKCI_.Equals(other.aBNDFKFIKCI_))
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
		}
		if (!secondLineup_.Equals(other.secondLineup_))
		{
			return false;
		}
		if (!firstLineup_.Equals(other.firstLineup_))
		{
			return false;
		}
		if (!bKNKLEOCJNO_.Equals(other.bKNKLEOCJNO_))
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
		num ^= aBNDFKFIKCI_.GetHashCode();
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		num ^= secondLineup_.GetHashCode();
		num ^= firstLineup_.GetHashCode();
		num ^= bKNKLEOCJNO_.GetHashCode();
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
		aBNDFKFIKCI_.WriteTo(ref output, _repeated_aBNDFKFIKCI_codec);
		if (ChallengeId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ChallengeId);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(StageInfo);
		}
		secondLineup_.WriteTo(ref output, _repeated_secondLineup_codec);
		firstLineup_.WriteTo(ref output, _repeated_firstLineup_codec);
		bKNKLEOCJNO_.WriteTo(ref output, _repeated_bKNKLEOCJNO_codec);
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
		num += aBNDFKFIKCI_.CalculateSize(_repeated_aBNDFKFIKCI_codec);
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		num += secondLineup_.CalculateSize(_repeated_secondLineup_codec);
		num += firstLineup_.CalculateSize(_repeated_firstLineup_codec);
		num += bKNKLEOCJNO_.CalculateSize(_repeated_bKNKLEOCJNO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartChallengeCsReq other)
	{
		if (other == null)
		{
			return;
		}
		aBNDFKFIKCI_.Add(other.aBNDFKFIKCI_);
		if (other.ChallengeId != 0)
		{
			ChallengeId = other.ChallengeId;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new ChallengeBuffInfo();
			}
			StageInfo.MergeFrom(other.StageInfo);
		}
		secondLineup_.Add(other.secondLineup_);
		firstLineup_.Add(other.firstLineup_);
		bKNKLEOCJNO_.Add(other.bKNKLEOCJNO_);
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
				aBNDFKFIKCI_.AddEntriesFrom(ref input, _repeated_aBNDFKFIKCI_codec);
				break;
			case 40u:
				ChallengeId = input.ReadUInt32();
				break;
			case 66u:
				if (stageInfo_ == null)
				{
					StageInfo = new ChallengeBuffInfo();
				}
				input.ReadMessage(StageInfo);
				break;
			case 80u:
			case 82u:
				secondLineup_.AddEntriesFrom(ref input, _repeated_secondLineup_codec);
				break;
			case 88u:
			case 90u:
				firstLineup_.AddEntriesFrom(ref input, _repeated_firstLineup_codec);
				break;
			case 106u:
				bKNKLEOCJNO_.AddEntriesFrom(ref input, _repeated_bKNKLEOCJNO_codec);
				break;
			}
		}
	}
}
