using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartFightFestScRsp : IMessage<StartFightFestScRsp>, IMessage, IEquatable<StartFightFestScRsp>, IDeepCloneable<StartFightFestScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartFightFestScRsp> _parser = new MessageParser<StartFightFestScRsp>(() => new StartFightFestScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BattleInfoFieldNumber = 6;

	private SceneBattleInfo battleInfo_;

	public const int IdFieldNumber = 8;

	private uint id_;

	public const int TypeFieldNumber = 9;

	private FightFestType type_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int EventIdFieldNumber = 14;

	private uint eventId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartFightFestScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartFightFestScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo BattleInfo
	{
		get
		{
			return battleInfo_;
		}
		set
		{
			battleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
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
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartFightFestScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartFightFestScRsp(StartFightFestScRsp other)
		: this()
	{
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		id_ = other.id_;
		type_ = other.type_;
		retcode_ = other.retcode_;
		eventId_ = other.eventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartFightFestScRsp Clone()
	{
		return new StartFightFestScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartFightFestScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartFightFestScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EventId != other.EventId)
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
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Type != FightFestType.MhkeafapmfpPcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
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
		if (battleInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BattleInfo);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Id);
		}
		if (Type != FightFestType.MhkeafapmfpPcpdhelpkem)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)Type);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(EventId);
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
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Type != FightFestType.MhkeafapmfpPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartFightFestScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new SceneBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Type != FightFestType.MhkeafapmfpPcpdhelpkem)
		{
			Type = other.Type;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.EventId != 0)
		{
			EventId = other.EventId;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 50u:
				if (battleInfo_ == null)
				{
					BattleInfo = new SceneBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 64u:
				Id = input.ReadUInt32();
				break;
			case 72u:
				Type = (FightFestType)input.ReadEnum();
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				EventId = input.ReadUInt32();
				break;
			}
		}
	}
}
