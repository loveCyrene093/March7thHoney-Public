using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DelSaveRaidScNotify : IMessage<DelSaveRaidScNotify>, IMessage, IEquatable<DelSaveRaidScNotify>, IDeepCloneable<DelSaveRaidScNotify>, IBufferMessage
{
	private static readonly MessageParser<DelSaveRaidScNotify> _parser = new MessageParser<DelSaveRaidScNotify>(() => new DelSaveRaidScNotify());

	private UnknownFieldSet _unknownFields;

	public const int RaidIdFieldNumber = 6;

	private uint raidId_;

	public const int WorldLevelFieldNumber = 9;

	private uint worldLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DelSaveRaidScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DelSaveRaidScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RaidId
	{
		get
		{
			return raidId_;
		}
		set
		{
			raidId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelSaveRaidScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelSaveRaidScNotify(DelSaveRaidScNotify other)
		: this()
	{
		raidId_ = other.raidId_;
		worldLevel_ = other.worldLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelSaveRaidScNotify Clone()
	{
		return new DelSaveRaidScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DelSaveRaidScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DelSaveRaidScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RaidId != other.RaidId)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
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
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
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
		if (RaidId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(RaidId);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(WorldLevel);
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
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DelSaveRaidScNotify other)
	{
		if (other != null)
		{
			if (other.RaidId != 0)
			{
				RaidId = other.RaidId;
			}
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
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
			case 48u:
				RaidId = input.ReadUInt32();
				break;
			case 72u:
				WorldLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
