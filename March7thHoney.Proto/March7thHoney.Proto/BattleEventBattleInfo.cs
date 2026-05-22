using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleEventBattleInfo : IMessage<BattleEventBattleInfo>, IMessage, IEquatable<BattleEventBattleInfo>, IDeepCloneable<BattleEventBattleInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleEventBattleInfo> _parser = new MessageParser<BattleEventBattleInfo>(() => new BattleEventBattleInfo());

	private UnknownFieldSet _unknownFields;

	public const int BattleEventIdFieldNumber = 1;

	private uint battleEventId_;

	public const int StatusFieldNumber = 2;

	private BattleEventProperty status_;

	public const int SkillInfoFieldNumber = 3;

	private static readonly FieldCodec<PLDMGGBPHPB> _repeated_skillInfo_codec = FieldCodec.ForMessage(26u, PLDMGGBPHPB.Parser);

	private readonly RepeatedField<PLDMGGBPHPB> skillInfo_ = new RepeatedField<PLDMGGBPHPB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleEventBattleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleEventBattleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleEventId
	{
		get
		{
			return battleEventId_;
		}
		set
		{
			battleEventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEventProperty Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PLDMGGBPHPB> SkillInfo => skillInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEventBattleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEventBattleInfo(BattleEventBattleInfo other)
		: this()
	{
		battleEventId_ = other.battleEventId_;
		status_ = ((other.status_ != null) ? other.status_.Clone() : null);
		skillInfo_ = other.skillInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEventBattleInfo Clone()
	{
		return new BattleEventBattleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleEventBattleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleEventBattleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BattleEventId != other.BattleEventId)
		{
			return false;
		}
		if (!object.Equals(Status, other.Status))
		{
			return false;
		}
		if (!skillInfo_.Equals(other.skillInfo_))
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
		if (BattleEventId != 0)
		{
			num ^= BattleEventId.GetHashCode();
		}
		if (status_ != null)
		{
			num ^= Status.GetHashCode();
		}
		num ^= skillInfo_.GetHashCode();
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
		if (BattleEventId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BattleEventId);
		}
		if (status_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Status);
		}
		skillInfo_.WriteTo(ref output, _repeated_skillInfo_codec);
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
		if (BattleEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleEventId);
		}
		if (status_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Status);
		}
		num += skillInfo_.CalculateSize(_repeated_skillInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleEventBattleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleEventId != 0)
		{
			BattleEventId = other.BattleEventId;
		}
		if (other.status_ != null)
		{
			if (status_ == null)
			{
				Status = new BattleEventProperty();
			}
			Status.MergeFrom(other.Status);
		}
		skillInfo_.Add(other.skillInfo_);
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
			case 8u:
				BattleEventId = input.ReadUInt32();
				break;
			case 18u:
				if (status_ == null)
				{
					Status = new BattleEventProperty();
				}
				input.ReadMessage(Status);
				break;
			case 26u:
				skillInfo_.AddEntriesFrom(ref input, _repeated_skillInfo_codec);
				break;
			}
		}
	}
}
