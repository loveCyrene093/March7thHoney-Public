using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetBoxingClubResonanceLineupCsReq : IMessage<SetBoxingClubResonanceLineupCsReq>, IMessage, IEquatable<SetBoxingClubResonanceLineupCsReq>, IDeepCloneable<SetBoxingClubResonanceLineupCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetBoxingClubResonanceLineupCsReq> _parser = new MessageParser<SetBoxingClubResonanceLineupCsReq>(() => new SetBoxingClubResonanceLineupCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IDOIDDEHIJGFieldNumber = 2;

	private static readonly FieldCodec<MHJNBBPBLBO> _repeated_iDOIDDEHIJG_codec = FieldCodec.ForMessage(18u, MHJNBBPBLBO.Parser);

	private readonly RepeatedField<MHJNBBPBLBO> iDOIDDEHIJG_ = new RepeatedField<MHJNBBPBLBO>();

	public const int ChallengeIdFieldNumber = 7;

	private uint challengeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetBoxingClubResonanceLineupCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetBoxingClubResonanceLineupCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MHJNBBPBLBO> IDOIDDEHIJG => iDOIDDEHIJG_;

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
	public SetBoxingClubResonanceLineupCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetBoxingClubResonanceLineupCsReq(SetBoxingClubResonanceLineupCsReq other)
		: this()
	{
		iDOIDDEHIJG_ = other.iDOIDDEHIJG_.Clone();
		challengeId_ = other.challengeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetBoxingClubResonanceLineupCsReq Clone()
	{
		return new SetBoxingClubResonanceLineupCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetBoxingClubResonanceLineupCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetBoxingClubResonanceLineupCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iDOIDDEHIJG_.Equals(other.iDOIDDEHIJG_))
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
		num ^= iDOIDDEHIJG_.GetHashCode();
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
		iDOIDDEHIJG_.WriteTo(ref output, _repeated_iDOIDDEHIJG_codec);
		if (ChallengeId != 0)
		{
			output.WriteRawTag(56);
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
		num += iDOIDDEHIJG_.CalculateSize(_repeated_iDOIDDEHIJG_codec);
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
	public void MergeFrom(SetBoxingClubResonanceLineupCsReq other)
	{
		if (other != null)
		{
			iDOIDDEHIJG_.Add(other.iDOIDDEHIJG_);
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
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
			case 18u:
				iDOIDDEHIJG_.AddEntriesFrom(ref input, _repeated_iDOIDDEHIJG_codec);
				break;
			case 56u:
				ChallengeId = input.ReadUInt32();
				break;
			}
		}
	}
}
