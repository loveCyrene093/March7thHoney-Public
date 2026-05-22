using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSaveRaidScRsp : IMessage<GetSaveRaidScRsp>, IMessage, IEquatable<GetSaveRaidScRsp>, IDeepCloneable<GetSaveRaidScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSaveRaidScRsp> _parser = new MessageParser<GetSaveRaidScRsp>(() => new GetSaveRaidScRsp());

	private UnknownFieldSet _unknownFields;

	public const int WorldLevelFieldNumber = 1;

	private uint worldLevel_;

	public const int RaidTargetInfoFieldNumber = 3;

	private static readonly FieldCodec<RaidTargetInfo> _repeated_raidTargetInfo_codec = FieldCodec.ForMessage(26u, March7thHoney.Proto.RaidTargetInfo.Parser);

	private readonly RepeatedField<RaidTargetInfo> raidTargetInfo_ = new RepeatedField<RaidTargetInfo>();

	public const int IsSaveFieldNumber = 5;

	private bool isSave_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int RaidIdFieldNumber = 9;

	private uint raidId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSaveRaidScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSaveRaidScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<RaidTargetInfo> RaidTargetInfo => raidTargetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSave
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
	public GetSaveRaidScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSaveRaidScRsp(GetSaveRaidScRsp other)
		: this()
	{
		worldLevel_ = other.worldLevel_;
		raidTargetInfo_ = other.raidTargetInfo_.Clone();
		isSave_ = other.isSave_;
		retcode_ = other.retcode_;
		raidId_ = other.raidId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSaveRaidScRsp Clone()
	{
		return new GetSaveRaidScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSaveRaidScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSaveRaidScRsp other)
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
		if (!raidTargetInfo_.Equals(other.raidTargetInfo_))
		{
			return false;
		}
		if (IsSave != other.IsSave)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (RaidId != other.RaidId)
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
		num ^= raidTargetInfo_.GetHashCode();
		if (IsSave)
		{
			num ^= IsSave.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
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
		if (WorldLevel != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(WorldLevel);
		}
		raidTargetInfo_.WriteTo(ref output, _repeated_raidTargetInfo_codec);
		if (IsSave)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsSave);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (RaidId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(RaidId);
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
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		num += raidTargetInfo_.CalculateSize(_repeated_raidTargetInfo_codec);
		if (IsSave)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSaveRaidScRsp other)
	{
		if (other != null)
		{
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
			}
			raidTargetInfo_.Add(other.raidTargetInfo_);
			if (other.IsSave)
			{
				IsSave = other.IsSave;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.RaidId != 0)
			{
				RaidId = other.RaidId;
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
				WorldLevel = input.ReadUInt32();
				break;
			case 26u:
				raidTargetInfo_.AddEntriesFrom(ref input, _repeated_raidTargetInfo_codec);
				break;
			case 40u:
				IsSave = input.ReadBool();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				RaidId = input.ReadUInt32();
				break;
			}
		}
	}
}
