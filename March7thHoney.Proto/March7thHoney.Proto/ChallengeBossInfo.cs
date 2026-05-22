using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossInfo : IMessage<ChallengeBossInfo>, IMessage, IEquatable<ChallengeBossInfo>, IDeepCloneable<ChallengeBossInfo>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossInfo> _parser = new MessageParser<ChallengeBossInfo>(() => new ChallengeBossInfo());

	private UnknownFieldSet _unknownFields;

	public const int SecondNodeFieldNumber = 2;

	private ChallengeBossSingleNodeInfo secondNode_;

	public const int ABNDFKFIKCIFieldNumber = 4;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_aBNDFKFIKCI_codec = FieldCodec.ForMessage(34u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> aBNDFKFIKCI_ = new RepeatedField<EEBPHJCNBFO>();

	public const int ChallengeAvatarRelicMapFieldNumber = 5;

	private static readonly MapField<uint, ChallengeBossAvatarRelicInfo>.Codec _map_challengeAvatarRelicMap_codec = new MapField<uint, ChallengeBossAvatarRelicInfo>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, ChallengeBossAvatarRelicInfo.Parser), 42u);

	private readonly MapField<uint, ChallengeBossAvatarRelicInfo> challengeAvatarRelicMap_ = new MapField<uint, ChallengeBossAvatarRelicInfo>();

	public const int FirstLineupFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_firstLineup_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> firstLineup_ = new RepeatedField<uint>();

	public const int ChallengeAvatarEquipmentMapFieldNumber = 7;

	private static readonly MapField<uint, ChallengeBossEquipmentInfo>.Codec _map_challengeAvatarEquipmentMap_codec = new MapField<uint, ChallengeBossEquipmentInfo>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, ChallengeBossEquipmentInfo.Parser), 58u);

	private readonly MapField<uint, ChallengeBossEquipmentInfo> challengeAvatarEquipmentMap_ = new MapField<uint, ChallengeBossEquipmentInfo>();

	public const int BKNKLEOCJNOFieldNumber = 10;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_bKNKLEOCJNO_codec = FieldCodec.ForMessage(82u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> bKNKLEOCJNO_ = new RepeatedField<EEBPHJCNBFO>();

	public const int FirstNodeFieldNumber = 11;

	private ChallengeBossSingleNodeInfo firstNode_;

	public const int SecondLineupFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_secondLineup_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> secondLineup_ = new RepeatedField<uint>();

	public const int Unk1FieldNumber = 15;

	private bool unk1_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBossInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossSingleNodeInfo SecondNode
	{
		get
		{
			return secondNode_;
		}
		set
		{
			secondNode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> ABNDFKFIKCI => aBNDFKFIKCI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, ChallengeBossAvatarRelicInfo> ChallengeAvatarRelicMap => challengeAvatarRelicMap_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FirstLineup => firstLineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, ChallengeBossEquipmentInfo> ChallengeAvatarEquipmentMap => challengeAvatarEquipmentMap_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> BKNKLEOCJNO => bKNKLEOCJNO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossSingleNodeInfo FirstNode
	{
		get
		{
			return firstNode_;
		}
		set
		{
			firstNode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SecondLineup => secondLineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk1
	{
		get
		{
			return unk1_;
		}
		set
		{
			unk1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossInfo(ChallengeBossInfo other)
		: this()
	{
		secondNode_ = ((other.secondNode_ != null) ? other.secondNode_.Clone() : null);
		aBNDFKFIKCI_ = other.aBNDFKFIKCI_.Clone();
		challengeAvatarRelicMap_ = other.challengeAvatarRelicMap_.Clone();
		firstLineup_ = other.firstLineup_.Clone();
		challengeAvatarEquipmentMap_ = other.challengeAvatarEquipmentMap_.Clone();
		bKNKLEOCJNO_ = other.bKNKLEOCJNO_.Clone();
		firstNode_ = ((other.firstNode_ != null) ? other.firstNode_.Clone() : null);
		secondLineup_ = other.secondLineup_.Clone();
		unk1_ = other.unk1_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossInfo Clone()
	{
		return new ChallengeBossInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(SecondNode, other.SecondNode))
		{
			return false;
		}
		if (!aBNDFKFIKCI_.Equals(other.aBNDFKFIKCI_))
		{
			return false;
		}
		if (!ChallengeAvatarRelicMap.Equals(other.ChallengeAvatarRelicMap))
		{
			return false;
		}
		if (!firstLineup_.Equals(other.firstLineup_))
		{
			return false;
		}
		if (!ChallengeAvatarEquipmentMap.Equals(other.ChallengeAvatarEquipmentMap))
		{
			return false;
		}
		if (!bKNKLEOCJNO_.Equals(other.bKNKLEOCJNO_))
		{
			return false;
		}
		if (!object.Equals(FirstNode, other.FirstNode))
		{
			return false;
		}
		if (!secondLineup_.Equals(other.secondLineup_))
		{
			return false;
		}
		if (Unk1 != other.Unk1)
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
		if (secondNode_ != null)
		{
			num ^= SecondNode.GetHashCode();
		}
		num ^= aBNDFKFIKCI_.GetHashCode();
		num ^= ChallengeAvatarRelicMap.GetHashCode();
		num ^= firstLineup_.GetHashCode();
		num ^= ChallengeAvatarEquipmentMap.GetHashCode();
		num ^= bKNKLEOCJNO_.GetHashCode();
		if (firstNode_ != null)
		{
			num ^= FirstNode.GetHashCode();
		}
		num ^= secondLineup_.GetHashCode();
		if (Unk1)
		{
			num ^= Unk1.GetHashCode();
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
		if (secondNode_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(SecondNode);
		}
		aBNDFKFIKCI_.WriteTo(ref output, _repeated_aBNDFKFIKCI_codec);
		challengeAvatarRelicMap_.WriteTo(ref output, _map_challengeAvatarRelicMap_codec);
		firstLineup_.WriteTo(ref output, _repeated_firstLineup_codec);
		challengeAvatarEquipmentMap_.WriteTo(ref output, _map_challengeAvatarEquipmentMap_codec);
		bKNKLEOCJNO_.WriteTo(ref output, _repeated_bKNKLEOCJNO_codec);
		if (firstNode_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FirstNode);
		}
		secondLineup_.WriteTo(ref output, _repeated_secondLineup_codec);
		if (Unk1)
		{
			output.WriteRawTag(120);
			output.WriteBool(Unk1);
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
		if (secondNode_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SecondNode);
		}
		num += aBNDFKFIKCI_.CalculateSize(_repeated_aBNDFKFIKCI_codec);
		num += challengeAvatarRelicMap_.CalculateSize(_map_challengeAvatarRelicMap_codec);
		num += firstLineup_.CalculateSize(_repeated_firstLineup_codec);
		num += challengeAvatarEquipmentMap_.CalculateSize(_map_challengeAvatarEquipmentMap_codec);
		num += bKNKLEOCJNO_.CalculateSize(_repeated_bKNKLEOCJNO_codec);
		if (firstNode_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FirstNode);
		}
		num += secondLineup_.CalculateSize(_repeated_secondLineup_codec);
		if (Unk1)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.secondNode_ != null)
		{
			if (secondNode_ == null)
			{
				SecondNode = new ChallengeBossSingleNodeInfo();
			}
			SecondNode.MergeFrom(other.SecondNode);
		}
		aBNDFKFIKCI_.Add(other.aBNDFKFIKCI_);
		challengeAvatarRelicMap_.MergeFrom(other.challengeAvatarRelicMap_);
		firstLineup_.Add(other.firstLineup_);
		challengeAvatarEquipmentMap_.MergeFrom(other.challengeAvatarEquipmentMap_);
		bKNKLEOCJNO_.Add(other.bKNKLEOCJNO_);
		if (other.firstNode_ != null)
		{
			if (firstNode_ == null)
			{
				FirstNode = new ChallengeBossSingleNodeInfo();
			}
			FirstNode.MergeFrom(other.FirstNode);
		}
		secondLineup_.Add(other.secondLineup_);
		if (other.Unk1)
		{
			Unk1 = other.Unk1;
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
				if (secondNode_ == null)
				{
					SecondNode = new ChallengeBossSingleNodeInfo();
				}
				input.ReadMessage(SecondNode);
				break;
			case 34u:
				aBNDFKFIKCI_.AddEntriesFrom(ref input, _repeated_aBNDFKFIKCI_codec);
				break;
			case 42u:
				challengeAvatarRelicMap_.AddEntriesFrom(ref input, _map_challengeAvatarRelicMap_codec);
				break;
			case 48u:
			case 50u:
				firstLineup_.AddEntriesFrom(ref input, _repeated_firstLineup_codec);
				break;
			case 58u:
				challengeAvatarEquipmentMap_.AddEntriesFrom(ref input, _map_challengeAvatarEquipmentMap_codec);
				break;
			case 82u:
				bKNKLEOCJNO_.AddEntriesFrom(ref input, _repeated_bKNKLEOCJNO_codec);
				break;
			case 90u:
				if (firstNode_ == null)
				{
					FirstNode = new ChallengeBossSingleNodeInfo();
				}
				input.ReadMessage(FirstNode);
				break;
			case 104u:
			case 106u:
				secondLineup_.AddEntriesFrom(ref input, _repeated_secondLineup_codec);
				break;
			case 120u:
				Unk1 = input.ReadBool();
				break;
			}
		}
	}
}
