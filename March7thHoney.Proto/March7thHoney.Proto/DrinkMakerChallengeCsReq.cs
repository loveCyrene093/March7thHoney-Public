using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DrinkMakerChallengeCsReq : IMessage<DrinkMakerChallengeCsReq>, IMessage, IEquatable<DrinkMakerChallengeCsReq>, IDeepCloneable<DrinkMakerChallengeCsReq>, IBufferMessage
{
	private static readonly MessageParser<DrinkMakerChallengeCsReq> _parser = new MessageParser<DrinkMakerChallengeCsReq>(() => new DrinkMakerChallengeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IHDMLHFAEKHFieldNumber = 5;

	private CIGKBDIGGOI iHDMLHFAEKH_;

	public const int ChallengeIdFieldNumber = 13;

	private uint challengeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DrinkMakerChallengeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DrinkMakerChallengeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI IHDMLHFAEKH
	{
		get
		{
			return iHDMLHFAEKH_;
		}
		set
		{
			iHDMLHFAEKH_ = value;
		}
	}

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
	public DrinkMakerChallengeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerChallengeCsReq(DrinkMakerChallengeCsReq other)
		: this()
	{
		iHDMLHFAEKH_ = ((other.iHDMLHFAEKH_ != null) ? other.iHDMLHFAEKH_.Clone() : null);
		challengeId_ = other.challengeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerChallengeCsReq Clone()
	{
		return new DrinkMakerChallengeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DrinkMakerChallengeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DrinkMakerChallengeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IHDMLHFAEKH, other.IHDMLHFAEKH))
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
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
		if (iHDMLHFAEKH_ != null)
		{
			num ^= IHDMLHFAEKH.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
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
		if (iHDMLHFAEKH_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(IHDMLHFAEKH);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ChallengeId);
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
		if (iHDMLHFAEKH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IHDMLHFAEKH);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DrinkMakerChallengeCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iHDMLHFAEKH_ != null)
		{
			if (iHDMLHFAEKH_ == null)
			{
				IHDMLHFAEKH = new CIGKBDIGGOI();
			}
			IHDMLHFAEKH.MergeFrom(other.IHDMLHFAEKH);
		}
		if (other.ChallengeId != 0)
		{
			ChallengeId = other.ChallengeId;
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
			case 42u:
				if (iHDMLHFAEKH_ == null)
				{
					IHDMLHFAEKH = new CIGKBDIGGOI();
				}
				input.ReadMessage(IHDMLHFAEKH);
				break;
			case 104u:
				ChallengeId = input.ReadUInt32();
				break;
			}
		}
	}
}
