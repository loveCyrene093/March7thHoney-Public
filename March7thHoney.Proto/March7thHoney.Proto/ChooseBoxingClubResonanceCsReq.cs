using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChooseBoxingClubResonanceCsReq : IMessage<ChooseBoxingClubResonanceCsReq>, IMessage, IEquatable<ChooseBoxingClubResonanceCsReq>, IDeepCloneable<ChooseBoxingClubResonanceCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChooseBoxingClubResonanceCsReq> _parser = new MessageParser<ChooseBoxingClubResonanceCsReq>(() => new ChooseBoxingClubResonanceCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeIdFieldNumber = 10;

	private uint challengeId_;

	public const int NGBACICAAPOFieldNumber = 11;

	private uint nGBACICAAPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChooseBoxingClubResonanceCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChooseBoxingClubResonanceCsReqReflection.Descriptor.MessageTypes[0];

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
	public uint NGBACICAAPO
	{
		get
		{
			return nGBACICAAPO_;
		}
		set
		{
			nGBACICAAPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubResonanceCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubResonanceCsReq(ChooseBoxingClubResonanceCsReq other)
		: this()
	{
		challengeId_ = other.challengeId_;
		nGBACICAAPO_ = other.nGBACICAAPO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubResonanceCsReq Clone()
	{
		return new ChooseBoxingClubResonanceCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChooseBoxingClubResonanceCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChooseBoxingClubResonanceCsReq other)
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
		if (NGBACICAAPO != other.NGBACICAAPO)
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
		if (NGBACICAAPO != 0)
		{
			num ^= NGBACICAAPO.GetHashCode();
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
			output.WriteRawTag(80);
			output.WriteUInt32(ChallengeId);
		}
		if (NGBACICAAPO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NGBACICAAPO);
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
		if (NGBACICAAPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGBACICAAPO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChooseBoxingClubResonanceCsReq other)
	{
		if (other != null)
		{
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.NGBACICAAPO != 0)
			{
				NGBACICAAPO = other.NGBACICAAPO;
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
			case 80u:
				ChallengeId = input.ReadUInt32();
				break;
			case 88u:
				NGBACICAAPO = input.ReadUInt32();
				break;
			}
		}
	}
}
