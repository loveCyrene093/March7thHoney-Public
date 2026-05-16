using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournUseSuperRewardKeyCsReq : IMessage<RogueTournUseSuperRewardKeyCsReq>, IMessage, IEquatable<RogueTournUseSuperRewardKeyCsReq>, IDeepCloneable<RogueTournUseSuperRewardKeyCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournUseSuperRewardKeyCsReq> _parser = new MessageParser<RogueTournUseSuperRewardKeyCsReq>(() => new RogueTournUseSuperRewardKeyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DifficultyLevelFieldNumber = 1;

	private uint difficultyLevel_;

	public const int CountFieldNumber = 12;

	private uint count_;

	public const int CocoonIdFieldNumber = 14;

	private uint cocoonId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournUseSuperRewardKeyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournUseSuperRewardKeyCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DifficultyLevel
	{
		get
		{
			return difficultyLevel_;
		}
		set
		{
			difficultyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CocoonId
	{
		get
		{
			return cocoonId_;
		}
		set
		{
			cocoonId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournUseSuperRewardKeyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournUseSuperRewardKeyCsReq(RogueTournUseSuperRewardKeyCsReq other)
		: this()
	{
		difficultyLevel_ = other.difficultyLevel_;
		count_ = other.count_;
		cocoonId_ = other.cocoonId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournUseSuperRewardKeyCsReq Clone()
	{
		return new RogueTournUseSuperRewardKeyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournUseSuperRewardKeyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournUseSuperRewardKeyCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DifficultyLevel != other.DifficultyLevel)
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (CocoonId != other.CocoonId)
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
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (CocoonId != 0)
		{
			num ^= CocoonId.GetHashCode();
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
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DifficultyLevel);
		}
		if (Count != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Count);
		}
		if (CocoonId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CocoonId);
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
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (CocoonId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CocoonId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournUseSuperRewardKeyCsReq other)
	{
		if (other != null)
		{
			if (other.DifficultyLevel != 0)
			{
				DifficultyLevel = other.DifficultyLevel;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.CocoonId != 0)
			{
				CocoonId = other.CocoonId;
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
				DifficultyLevel = input.ReadUInt32();
				break;
			case 96u:
				Count = input.ReadUInt32();
				break;
			case 112u:
				CocoonId = input.ReadUInt32();
				break;
			}
		}
	}
}
