using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartAetherDivideChallengeBattleCsReq : IMessage<StartAetherDivideChallengeBattleCsReq>, IMessage, IEquatable<StartAetherDivideChallengeBattleCsReq>, IDeepCloneable<StartAetherDivideChallengeBattleCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartAetherDivideChallengeBattleCsReq> _parser = new MessageParser<StartAetherDivideChallengeBattleCsReq>(() => new StartAetherDivideChallengeBattleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeIdFieldNumber = 12;

	private uint challengeId_;

	public const int FNCINGFDLPAFieldNumber = 14;

	private uint fNCINGFDLPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartAetherDivideChallengeBattleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartAetherDivideChallengeBattleCsReqReflection.Descriptor.MessageTypes[0];

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
	public uint FNCINGFDLPA
	{
		get
		{
			return fNCINGFDLPA_;
		}
		set
		{
			fNCINGFDLPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideChallengeBattleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideChallengeBattleCsReq(StartAetherDivideChallengeBattleCsReq other)
		: this()
	{
		challengeId_ = other.challengeId_;
		fNCINGFDLPA_ = other.fNCINGFDLPA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideChallengeBattleCsReq Clone()
	{
		return new StartAetherDivideChallengeBattleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartAetherDivideChallengeBattleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartAetherDivideChallengeBattleCsReq other)
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
		if (FNCINGFDLPA != other.FNCINGFDLPA)
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
		if (FNCINGFDLPA != 0)
		{
			num ^= FNCINGFDLPA.GetHashCode();
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
			output.WriteRawTag(96);
			output.WriteUInt32(ChallengeId);
		}
		if (FNCINGFDLPA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FNCINGFDLPA);
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
		if (FNCINGFDLPA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FNCINGFDLPA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartAetherDivideChallengeBattleCsReq other)
	{
		if (other != null)
		{
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.FNCINGFDLPA != 0)
			{
				FNCINGFDLPA = other.FNCINGFDLPA;
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
			case 96u:
				ChallengeId = input.ReadUInt32();
				break;
			case 112u:
				FNCINGFDLPA = input.ReadUInt32();
				break;
			}
		}
	}
}
