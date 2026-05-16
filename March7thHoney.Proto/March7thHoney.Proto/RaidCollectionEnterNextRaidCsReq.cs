using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RaidCollectionEnterNextRaidCsReq : IMessage<RaidCollectionEnterNextRaidCsReq>, IMessage, IEquatable<RaidCollectionEnterNextRaidCsReq>, IDeepCloneable<RaidCollectionEnterNextRaidCsReq>, IBufferMessage
{
	private static readonly MessageParser<RaidCollectionEnterNextRaidCsReq> _parser = new MessageParser<RaidCollectionEnterNextRaidCsReq>(() => new RaidCollectionEnterNextRaidCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

	public const int RaidIdFieldNumber = 4;

	private uint raidId_;

	public const int IsSaveFieldNumber = 6;

	private uint isSave_;

	public const int WorldLevelFieldNumber = 12;

	private uint worldLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RaidCollectionEnterNextRaidCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RaidCollectionEnterNextRaidCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarList => avatarList_;

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
	public uint IsSave
	{
		get
		{
			return isSave_;
		}
		set
		{
			isSave_ = value;
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
	public RaidCollectionEnterNextRaidCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidCollectionEnterNextRaidCsReq(RaidCollectionEnterNextRaidCsReq other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		raidId_ = other.raidId_;
		isSave_ = other.isSave_;
		worldLevel_ = other.worldLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidCollectionEnterNextRaidCsReq Clone()
	{
		return new RaidCollectionEnterNextRaidCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RaidCollectionEnterNextRaidCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RaidCollectionEnterNextRaidCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (RaidId != other.RaidId)
		{
			return false;
		}
		if (IsSave != other.IsSave)
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
		num ^= avatarList_.GetHashCode();
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
		}
		if (IsSave != 0)
		{
			num ^= IsSave.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (RaidId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(RaidId);
		}
		if (IsSave != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IsSave);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(96);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		if (IsSave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IsSave);
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
	public void MergeFrom(RaidCollectionEnterNextRaidCsReq other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			if (other.RaidId != 0)
			{
				RaidId = other.RaidId;
			}
			if (other.IsSave != 0)
			{
				IsSave = other.IsSave;
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
			case 24u:
			case 26u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 32u:
				RaidId = input.ReadUInt32();
				break;
			case 48u:
				IsSave = input.ReadUInt32();
				break;
			case 96u:
				WorldLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
