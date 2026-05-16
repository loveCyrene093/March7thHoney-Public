using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GiveUpBoxingClubChallengeCsReq : IMessage<GiveUpBoxingClubChallengeCsReq>, IMessage, IEquatable<GiveUpBoxingClubChallengeCsReq>, IDeepCloneable<GiveUpBoxingClubChallengeCsReq>, IBufferMessage
{
	private static readonly MessageParser<GiveUpBoxingClubChallengeCsReq> _parser = new MessageParser<GiveUpBoxingClubChallengeCsReq>(() => new GiveUpBoxingClubChallengeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeIdFieldNumber = 1;

	private uint challengeId_;

	public const int PAMDLHOCMCCFieldNumber = 2;

	private bool pAMDLHOCMCC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GiveUpBoxingClubChallengeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GiveUpBoxingClubChallengeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool PAMDLHOCMCC
	{
		get
		{
			return pAMDLHOCMCC_;
		}
		set
		{
			pAMDLHOCMCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GiveUpBoxingClubChallengeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GiveUpBoxingClubChallengeCsReq(GiveUpBoxingClubChallengeCsReq other)
		: this()
	{
		challengeId_ = other.challengeId_;
		pAMDLHOCMCC_ = other.pAMDLHOCMCC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GiveUpBoxingClubChallengeCsReq Clone()
	{
		return new GiveUpBoxingClubChallengeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GiveUpBoxingClubChallengeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GiveUpBoxingClubChallengeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (PAMDLHOCMCC != other.PAMDLHOCMCC)
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
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (PAMDLHOCMCC)
		{
			num ^= PAMDLHOCMCC.GetHashCode();
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
		if (ChallengeId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ChallengeId);
		}
		if (PAMDLHOCMCC)
		{
			output.WriteRawTag(16);
			output.WriteBool(PAMDLHOCMCC);
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
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (PAMDLHOCMCC)
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
	public void MergeFrom(GiveUpBoxingClubChallengeCsReq other)
	{
		if (other != null)
		{
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.PAMDLHOCMCC)
			{
				PAMDLHOCMCC = other.PAMDLHOCMCC;
			}
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
				ChallengeId = input.ReadUInt32();
				break;
			case 16u:
				PAMDLHOCMCC = input.ReadBool();
				break;
			}
		}
	}
}
