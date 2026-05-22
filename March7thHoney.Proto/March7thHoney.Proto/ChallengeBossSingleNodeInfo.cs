using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossSingleNodeInfo : IMessage<ChallengeBossSingleNodeInfo>, IMessage, IEquatable<ChallengeBossSingleNodeInfo>, IDeepCloneable<ChallengeBossSingleNodeInfo>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossSingleNodeInfo> _parser = new MessageParser<ChallengeBossSingleNodeInfo>(() => new ChallengeBossSingleNodeInfo());

	private UnknownFieldSet _unknownFields;

	public const int MaxScoreFieldNumber = 3;

	private uint maxScore_;

	public const int IsWinFieldNumber = 4;

	private bool isWin_;

	public const int JBJODEHADJBFieldNumber = 7;

	private bool jBJODEHADJB_;

	public const int BuffIdFieldNumber = 8;

	private uint buffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossSingleNodeInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBossSingleNodeInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxScore
	{
		get
		{
			return maxScore_;
		}
		set
		{
			maxScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JBJODEHADJB
	{
		get
		{
			return jBJODEHADJB_;
		}
		set
		{
			jBJODEHADJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossSingleNodeInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossSingleNodeInfo(ChallengeBossSingleNodeInfo other)
		: this()
	{
		maxScore_ = other.maxScore_;
		isWin_ = other.isWin_;
		jBJODEHADJB_ = other.jBJODEHADJB_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossSingleNodeInfo Clone()
	{
		return new ChallengeBossSingleNodeInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossSingleNodeInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossSingleNodeInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MaxScore != other.MaxScore)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (JBJODEHADJB != other.JBJODEHADJB)
		{
			return false;
		}
		if (BuffId != other.BuffId)
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
		if (MaxScore != 0)
		{
			num ^= MaxScore.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (JBJODEHADJB)
		{
			num ^= JBJODEHADJB.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
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
		if (MaxScore != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MaxScore);
		}
		if (IsWin)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsWin);
		}
		if (JBJODEHADJB)
		{
			output.WriteRawTag(56);
			output.WriteBool(JBJODEHADJB);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BuffId);
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
		if (MaxScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxScore);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (JBJODEHADJB)
		{
			num += 2;
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossSingleNodeInfo other)
	{
		if (other != null)
		{
			if (other.MaxScore != 0)
			{
				MaxScore = other.MaxScore;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.JBJODEHADJB)
			{
				JBJODEHADJB = other.JBJODEHADJB;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
				MaxScore = input.ReadUInt32();
				break;
			case 32u:
				IsWin = input.ReadBool();
				break;
			case 56u:
				JBJODEHADJB = input.ReadBool();
				break;
			case 64u:
				BuffId = input.ReadUInt32();
				break;
			}
		}
	}
}
