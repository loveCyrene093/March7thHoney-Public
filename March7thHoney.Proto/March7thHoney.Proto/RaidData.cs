using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RaidData : IMessage<RaidData>, IMessage, IEquatable<RaidData>, IDeepCloneable<RaidData>, IBufferMessage
{
	private static readonly MessageParser<RaidData> _parser = new MessageParser<RaidData>(() => new RaidData());

	private UnknownFieldSet _unknownFields;

	public const int WorldLevelFieldNumber = 6;

	private uint worldLevel_;

	public const int RaidIdFieldNumber = 7;

	private uint raidId_;

	public const int RaidTargetInfoFieldNumber = 15;

	private static readonly FieldCodec<RaidTargetInfo> _repeated_raidTargetInfo_codec = FieldCodec.ForMessage(122u, March7thHoney.Proto.RaidTargetInfo.Parser);

	private readonly RepeatedField<RaidTargetInfo> raidTargetInfo_ = new RepeatedField<RaidTargetInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RaidData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RaidDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<RaidTargetInfo> RaidTargetInfo => raidTargetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidData(RaidData other)
		: this()
	{
		worldLevel_ = other.worldLevel_;
		raidId_ = other.raidId_;
		raidTargetInfo_ = other.raidTargetInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidData Clone()
	{
		return new RaidData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RaidData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RaidData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (RaidId != other.RaidId)
		{
			return false;
		}
		if (!raidTargetInfo_.Equals(other.raidTargetInfo_))
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
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
		}
		num ^= raidTargetInfo_.GetHashCode();
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
		if (WorldLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(WorldLevel);
		}
		if (RaidId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(RaidId);
		}
		raidTargetInfo_.WriteTo(ref output, _repeated_raidTargetInfo_codec);
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
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		num += raidTargetInfo_.CalculateSize(_repeated_raidTargetInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RaidData other)
	{
		if (other != null)
		{
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
			}
			if (other.RaidId != 0)
			{
				RaidId = other.RaidId;
			}
			raidTargetInfo_.Add(other.raidTargetInfo_);
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
				WorldLevel = input.ReadUInt32();
				break;
			case 56u:
				RaidId = input.ReadUInt32();
				break;
			case 122u:
				raidTargetInfo_.AddEntriesFrom(ref input, _repeated_raidTargetInfo_codec);
				break;
			}
		}
	}
}
