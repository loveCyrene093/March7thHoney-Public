using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleRelic : IMessage<BattleRelic>, IMessage, IEquatable<BattleRelic>, IDeepCloneable<BattleRelic>, IBufferMessage
{
	private static readonly MessageParser<BattleRelic> _parser = new MessageParser<BattleRelic>(() => new BattleRelic());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int MainAffixIdFieldNumber = 3;

	private uint mainAffixId_;

	public const int SubAffixListFieldNumber = 4;

	private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage(34u, RelicAffix.Parser);

	private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

	public const int UniqueIdFieldNumber = 5;

	private uint uniqueId_;

	public const int SetIdFieldNumber = 6;

	private uint setId_;

	public const int TypeFieldNumber = 7;

	private uint type_;

	public const int RarityFieldNumber = 8;

	private uint rarity_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleRelic> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleRelicReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint MainAffixId
	{
		get
		{
			return mainAffixId_;
		}
		set
		{
			mainAffixId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RelicAffix> SubAffixList => subAffixList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SetId
	{
		get
		{
			return setId_;
		}
		set
		{
			setId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Type
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
	public uint Rarity
	{
		get
		{
			return rarity_;
		}
		set
		{
			rarity_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRelic()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRelic(BattleRelic other)
		: this()
	{
		id_ = other.id_;
		level_ = other.level_;
		mainAffixId_ = other.mainAffixId_;
		subAffixList_ = other.subAffixList_.Clone();
		uniqueId_ = other.uniqueId_;
		setId_ = other.setId_;
		type_ = other.type_;
		rarity_ = other.rarity_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRelic Clone()
	{
		return new BattleRelic(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleRelic);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleRelic other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (MainAffixId != other.MainAffixId)
		{
			return false;
		}
		if (!subAffixList_.Equals(other.subAffixList_))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (SetId != other.SetId)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Rarity != other.Rarity)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (MainAffixId != 0)
		{
			num ^= MainAffixId.GetHashCode();
		}
		num ^= subAffixList_.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (SetId != 0)
		{
			num ^= SetId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Rarity != 0)
		{
			num ^= Rarity.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (MainAffixId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MainAffixId);
		}
		subAffixList_.WriteTo(ref output, _repeated_subAffixList_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UniqueId);
		}
		if (SetId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(SetId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Type);
		}
		if (Rarity != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Rarity);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (MainAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainAffixId);
		}
		num += subAffixList_.CalculateSize(_repeated_subAffixList_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (SetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SetId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (Rarity != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rarity);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleRelic other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.MainAffixId != 0)
			{
				MainAffixId = other.MainAffixId;
			}
			subAffixList_.Add(other.subAffixList_);
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.SetId != 0)
			{
				SetId = other.SetId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Rarity != 0)
			{
				Rarity = other.Rarity;
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
				Id = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
				MainAffixId = input.ReadUInt32();
				break;
			case 34u:
				subAffixList_.AddEntriesFrom(ref input, _repeated_subAffixList_codec);
				break;
			case 40u:
				UniqueId = input.ReadUInt32();
				break;
			case 48u:
				SetId = input.ReadUInt32();
				break;
			case 56u:
				Type = input.ReadUInt32();
				break;
			case 64u:
				Rarity = input.ReadUInt32();
				break;
			}
		}
	}
}
