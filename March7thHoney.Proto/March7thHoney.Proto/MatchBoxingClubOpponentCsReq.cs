using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchBoxingClubOpponentCsReq : IMessage<MatchBoxingClubOpponentCsReq>, IMessage, IEquatable<MatchBoxingClubOpponentCsReq>, IDeepCloneable<MatchBoxingClubOpponentCsReq>, IBufferMessage
{
	private static readonly MessageParser<MatchBoxingClubOpponentCsReq> _parser = new MessageParser<MatchBoxingClubOpponentCsReq>(() => new MatchBoxingClubOpponentCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

	public const int ChallengeIdFieldNumber = 4;

	private uint challengeId_;

	public const int IDOIDDEHIJGFieldNumber = 6;

	private static readonly FieldCodec<MHJNBBPBLBO> _repeated_iDOIDDEHIJG_codec = FieldCodec.ForMessage(50u, MHJNBBPBLBO.Parser);

	private readonly RepeatedField<MHJNBBPBLBO> iDOIDDEHIJG_ = new RepeatedField<MHJNBBPBLBO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchBoxingClubOpponentCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchBoxingClubOpponentCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarList => avatarList_;

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
	public RepeatedField<MHJNBBPBLBO> IDOIDDEHIJG => iDOIDDEHIJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchBoxingClubOpponentCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchBoxingClubOpponentCsReq(MatchBoxingClubOpponentCsReq other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		challengeId_ = other.challengeId_;
		iDOIDDEHIJG_ = other.iDOIDDEHIJG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchBoxingClubOpponentCsReq Clone()
	{
		return new MatchBoxingClubOpponentCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchBoxingClubOpponentCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchBoxingClubOpponentCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (!iDOIDDEHIJG_.Equals(other.iDOIDDEHIJG_))
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
		num ^= avatarList_.GetHashCode();
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		num ^= iDOIDDEHIJG_.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (ChallengeId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ChallengeId);
		}
		iDOIDDEHIJG_.WriteTo(ref output, _repeated_iDOIDDEHIJG_codec);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		num += iDOIDDEHIJG_.CalculateSize(_repeated_iDOIDDEHIJG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchBoxingClubOpponentCsReq other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			iDOIDDEHIJG_.Add(other.iDOIDDEHIJG_);
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
			case 16u:
			case 18u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 32u:
				ChallengeId = input.ReadUInt32();
				break;
			case 50u:
				iDOIDDEHIJG_.AddEntriesFrom(ref input, _repeated_iDOIDDEHIJG_codec);
				break;
			}
		}
	}
}
