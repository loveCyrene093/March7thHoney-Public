using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartRaidCsReq : IMessage<StartRaidCsReq>, IMessage, IEquatable<StartRaidCsReq>, IDeepCloneable<StartRaidCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartRaidCsReq> _parser = new MessageParser<StartRaidCsReq>(() => new StartRaidCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BDBJKKOJODCFieldNumber = 2;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_bDBJKKOJODC_codec = FieldCodec.ForMessage(18u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> bDBJKKOJODC_ = new RepeatedField<EEBPHJCNBFO>();

	public const int IsSaveFieldNumber = 3;

	private uint isSave_;

	public const int PropEntityIdFieldNumber = 4;

	private uint propEntityId_;

	public const int WorldLevelFieldNumber = 8;

	private uint worldLevel_;

	public const int RaidIdFieldNumber = 9;

	private uint raidId_;

	public const int AvatarListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartRaidCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartRaidCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> BDBJKKOJODC => bDBJKKOJODC_;

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
	public uint PropEntityId
	{
		get
		{
			return propEntityId_;
		}
		set
		{
			propEntityId_ = value;
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
	public RepeatedField<uint> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartRaidCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartRaidCsReq(StartRaidCsReq other)
		: this()
	{
		bDBJKKOJODC_ = other.bDBJKKOJODC_.Clone();
		isSave_ = other.isSave_;
		propEntityId_ = other.propEntityId_;
		worldLevel_ = other.worldLevel_;
		raidId_ = other.raidId_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartRaidCsReq Clone()
	{
		return new StartRaidCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartRaidCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartRaidCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bDBJKKOJODC_.Equals(other.bDBJKKOJODC_))
		{
			return false;
		}
		if (IsSave != other.IsSave)
		{
			return false;
		}
		if (PropEntityId != other.PropEntityId)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (RaidId != other.RaidId)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		num ^= bDBJKKOJODC_.GetHashCode();
		if (IsSave != 0)
		{
			num ^= IsSave.GetHashCode();
		}
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		bDBJKKOJODC_.WriteTo(ref output, _repeated_bDBJKKOJODC_codec);
		if (IsSave != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IsSave);
		}
		if (PropEntityId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PropEntityId);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(WorldLevel);
		}
		if (RaidId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(RaidId);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		num += bDBJKKOJODC_.CalculateSize(_repeated_bDBJKKOJODC_codec);
		if (IsSave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IsSave);
		}
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartRaidCsReq other)
	{
		if (other != null)
		{
			bDBJKKOJODC_.Add(other.bDBJKKOJODC_);
			if (other.IsSave != 0)
			{
				IsSave = other.IsSave;
			}
			if (other.PropEntityId != 0)
			{
				PropEntityId = other.PropEntityId;
			}
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
			}
			if (other.RaidId != 0)
			{
				RaidId = other.RaidId;
			}
			avatarList_.Add(other.avatarList_);
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
				bDBJKKOJODC_.AddEntriesFrom(ref input, _repeated_bDBJKKOJODC_codec);
				break;
			case 24u:
				IsSave = input.ReadUInt32();
				break;
			case 32u:
				PropEntityId = input.ReadUInt32();
				break;
			case 64u:
				WorldLevel = input.ReadUInt32();
				break;
			case 72u:
				RaidId = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
