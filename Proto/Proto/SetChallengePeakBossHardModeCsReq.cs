using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetChallengePeakBossHardModeCsReq : IMessage<SetChallengePeakBossHardModeCsReq>, IMessage, IEquatable<SetChallengePeakBossHardModeCsReq>, IDeepCloneable<SetChallengePeakBossHardModeCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetChallengePeakBossHardModeCsReq> _parser = new MessageParser<SetChallengePeakBossHardModeCsReq>(() => new SetChallengePeakBossHardModeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PeakGroupIdFieldNumber = 4;

	private uint peakGroupId_;

	public const int IsHardModeFieldNumber = 6;

	private bool isHardMode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetChallengePeakBossHardModeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetChallengePeakBossHardModeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PeakGroupId
	{
		get
		{
			return peakGroupId_;
		}
		set
		{
			peakGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsHardMode
	{
		get
		{
			return isHardMode_;
		}
		set
		{
			isHardMode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetChallengePeakBossHardModeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetChallengePeakBossHardModeCsReq(SetChallengePeakBossHardModeCsReq other)
		: this()
	{
		peakGroupId_ = other.peakGroupId_;
		isHardMode_ = other.isHardMode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetChallengePeakBossHardModeCsReq Clone()
	{
		return new SetChallengePeakBossHardModeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetChallengePeakBossHardModeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetChallengePeakBossHardModeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PeakGroupId != other.PeakGroupId)
		{
			return false;
		}
		if (IsHardMode != other.IsHardMode)
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
		if (PeakGroupId != 0)
		{
			num ^= PeakGroupId.GetHashCode();
		}
		if (IsHardMode)
		{
			num ^= IsHardMode.GetHashCode();
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
		if (PeakGroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PeakGroupId);
		}
		if (IsHardMode)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsHardMode);
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
		if (PeakGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakGroupId);
		}
		if (IsHardMode)
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
	public void MergeFrom(SetChallengePeakBossHardModeCsReq other)
	{
		if (other != null)
		{
			if (other.PeakGroupId != 0)
			{
				PeakGroupId = other.PeakGroupId;
			}
			if (other.IsHardMode)
			{
				IsHardMode = other.IsHardMode;
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
			case 32u:
				PeakGroupId = input.ReadUInt32();
				break;
			case 48u:
				IsHardMode = input.ReadBool();
				break;
			}
		}
	}
}
