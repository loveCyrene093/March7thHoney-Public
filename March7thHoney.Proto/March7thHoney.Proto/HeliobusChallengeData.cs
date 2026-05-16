using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusChallengeData : IMessage<HeliobusChallengeData>, IMessage, IEquatable<HeliobusChallengeData>, IDeepCloneable<HeliobusChallengeData>, IBufferMessage
{
	private static readonly MessageParser<HeliobusChallengeData> _parser = new MessageParser<HeliobusChallengeData>(() => new HeliobusChallengeData());

	private UnknownFieldSet _unknownFields;

	public const int StarFieldNumber = 3;

	private uint star_;

	public const int ChallengeIdFieldNumber = 10;

	private uint challengeId_;

	public const int FLMOKKBLFJGFieldNumber = 14;

	private bool fLMOKKBLFJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusChallengeData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusChallengeDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Star
	{
		get
		{
			return star_;
		}
		set
		{
			star_ = value;
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
	public bool FLMOKKBLFJG
	{
		get
		{
			return fLMOKKBLFJG_;
		}
		set
		{
			fLMOKKBLFJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeData(HeliobusChallengeData other)
		: this()
	{
		star_ = other.star_;
		challengeId_ = other.challengeId_;
		fLMOKKBLFJG_ = other.fLMOKKBLFJG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeData Clone()
	{
		return new HeliobusChallengeData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusChallengeData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusChallengeData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Star != other.Star)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (FLMOKKBLFJG != other.FLMOKKBLFJG)
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
		if (Star != 0)
		{
			num ^= Star.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (FLMOKKBLFJG)
		{
			num ^= FLMOKKBLFJG.GetHashCode();
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
		if (Star != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Star);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ChallengeId);
		}
		if (FLMOKKBLFJG)
		{
			output.WriteRawTag(112);
			output.WriteBool(FLMOKKBLFJG);
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
		if (Star != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Star);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (FLMOKKBLFJG)
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
	public void MergeFrom(HeliobusChallengeData other)
	{
		if (other != null)
		{
			if (other.Star != 0)
			{
				Star = other.Star;
			}
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.FLMOKKBLFJG)
			{
				FLMOKKBLFJG = other.FLMOKKBLFJG;
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
				Star = input.ReadUInt32();
				break;
			case 80u:
				ChallengeId = input.ReadUInt32();
				break;
			case 112u:
				FLMOKKBLFJG = input.ReadBool();
				break;
			}
		}
	}
}
