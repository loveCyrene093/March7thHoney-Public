using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChooseBoxingClubStageOptionalBuffCsReq : IMessage<ChooseBoxingClubStageOptionalBuffCsReq>, IMessage, IEquatable<ChooseBoxingClubStageOptionalBuffCsReq>, IDeepCloneable<ChooseBoxingClubStageOptionalBuffCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChooseBoxingClubStageOptionalBuffCsReq> _parser = new MessageParser<ChooseBoxingClubStageOptionalBuffCsReq>(() => new ChooseBoxingClubStageOptionalBuffCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeIdFieldNumber = 3;

	private uint challengeId_;

	public const int OOPGFEANPAEFieldNumber = 15;

	private uint oOPGFEANPAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChooseBoxingClubStageOptionalBuffCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChooseBoxingClubStageOptionalBuffCsReqReflection.Descriptor.MessageTypes[0];

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
	public uint OOPGFEANPAE
	{
		get
		{
			return oOPGFEANPAE_;
		}
		set
		{
			oOPGFEANPAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubStageOptionalBuffCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubStageOptionalBuffCsReq(ChooseBoxingClubStageOptionalBuffCsReq other)
		: this()
	{
		challengeId_ = other.challengeId_;
		oOPGFEANPAE_ = other.oOPGFEANPAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubStageOptionalBuffCsReq Clone()
	{
		return new ChooseBoxingClubStageOptionalBuffCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChooseBoxingClubStageOptionalBuffCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChooseBoxingClubStageOptionalBuffCsReq other)
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
		if (OOPGFEANPAE != other.OOPGFEANPAE)
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
		if (OOPGFEANPAE != 0)
		{
			num ^= OOPGFEANPAE.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(ChallengeId);
		}
		if (OOPGFEANPAE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OOPGFEANPAE);
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
		if (OOPGFEANPAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OOPGFEANPAE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChooseBoxingClubStageOptionalBuffCsReq other)
	{
		if (other != null)
		{
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.OOPGFEANPAE != 0)
			{
				OOPGFEANPAE = other.OOPGFEANPAE;
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
			case 24u:
				ChallengeId = input.ReadUInt32();
				break;
			case 120u:
				OOPGFEANPAE = input.ReadUInt32();
				break;
			}
		}
	}
}
