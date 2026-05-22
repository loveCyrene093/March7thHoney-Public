using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetLevelRewardCsReq : IMessage<GetLevelRewardCsReq>, IMessage, IEquatable<GetLevelRewardCsReq>, IDeepCloneable<GetLevelRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetLevelRewardCsReq> _parser = new MessageParser<GetLevelRewardCsReq>(() => new GetLevelRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int InteractedPropEntityIdFieldNumber = 15;

	private uint interactedPropEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetLevelRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetLevelRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractedPropEntityId
	{
		get
		{
			return interactedPropEntityId_;
		}
		set
		{
			interactedPropEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetLevelRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetLevelRewardCsReq(GetLevelRewardCsReq other)
		: this()
	{
		level_ = other.level_;
		interactedPropEntityId_ = other.interactedPropEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetLevelRewardCsReq Clone()
	{
		return new GetLevelRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetLevelRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetLevelRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (InteractedPropEntityId != other.InteractedPropEntityId)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (InteractedPropEntityId != 0)
		{
			num ^= InteractedPropEntityId.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (InteractedPropEntityId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(InteractedPropEntityId);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (InteractedPropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractedPropEntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetLevelRewardCsReq other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.InteractedPropEntityId != 0)
			{
				InteractedPropEntityId = other.InteractedPropEntityId;
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
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 120u:
				InteractedPropEntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
