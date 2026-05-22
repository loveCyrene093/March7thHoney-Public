using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetChallengePeakBossHardModeScRsp : IMessage<SetChallengePeakBossHardModeScRsp>, IMessage, IEquatable<SetChallengePeakBossHardModeScRsp>, IDeepCloneable<SetChallengePeakBossHardModeScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetChallengePeakBossHardModeScRsp> _parser = new MessageParser<SetChallengePeakBossHardModeScRsp>(() => new SetChallengePeakBossHardModeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IsHardModeFieldNumber = 1;

	private bool isHardMode_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int PeakGroupIdFieldNumber = 15;

	private uint peakGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetChallengePeakBossHardModeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetChallengePeakBossHardModeScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

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
	public SetChallengePeakBossHardModeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetChallengePeakBossHardModeScRsp(SetChallengePeakBossHardModeScRsp other)
		: this()
	{
		isHardMode_ = other.isHardMode_;
		retcode_ = other.retcode_;
		peakGroupId_ = other.peakGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetChallengePeakBossHardModeScRsp Clone()
	{
		return new SetChallengePeakBossHardModeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetChallengePeakBossHardModeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetChallengePeakBossHardModeScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsHardMode != other.IsHardMode)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (PeakGroupId != other.PeakGroupId)
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
		if (IsHardMode)
		{
			num ^= IsHardMode.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (PeakGroupId != 0)
		{
			num ^= PeakGroupId.GetHashCode();
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
		if (IsHardMode)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsHardMode);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (PeakGroupId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PeakGroupId);
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
		if (IsHardMode)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (PeakGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetChallengePeakBossHardModeScRsp other)
	{
		if (other != null)
		{
			if (other.IsHardMode)
			{
				IsHardMode = other.IsHardMode;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.PeakGroupId != 0)
			{
				PeakGroupId = other.PeakGroupId;
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
				IsHardMode = input.ReadBool();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				PeakGroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
