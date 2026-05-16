using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StatisticEvent : IMessage<StatisticEvent>, IMessage, IEquatable<StatisticEvent>, IDeepCloneable<StatisticEvent>, IBufferMessage
{
	private static readonly MessageParser<StatisticEvent> _parser = new MessageParser<StatisticEvent>(() => new StatisticEvent());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private BattleStaticticEventType type_;

	public const int PICEGMCCHMEFieldNumber = 2;

	private uint pICEGMCCHME_;

	public const int DisplayValueFieldNumber = 3;

	private uint displayValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StatisticEvent> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StatisticEventReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStaticticEventType Type
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
	public uint PICEGMCCHME
	{
		get
		{
			return pICEGMCCHME_;
		}
		set
		{
			pICEGMCCHME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatisticEvent()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatisticEvent(StatisticEvent other)
		: this()
	{
		type_ = other.type_;
		pICEGMCCHME_ = other.pICEGMCCHME_;
		displayValue_ = other.displayValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatisticEvent Clone()
	{
		return new StatisticEvent(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StatisticEvent);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StatisticEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (PICEGMCCHME != other.PICEGMCCHME)
		{
			return false;
		}
		if (DisplayValue != other.DisplayValue)
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
		if (Type != BattleStaticticEventType.BattleStaticticEventNone)
		{
			num ^= Type.GetHashCode();
		}
		if (PICEGMCCHME != 0)
		{
			num ^= PICEGMCCHME.GetHashCode();
		}
		if (DisplayValue != 0)
		{
			num ^= DisplayValue.GetHashCode();
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
		if (Type != BattleStaticticEventType.BattleStaticticEventNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (PICEGMCCHME != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PICEGMCCHME);
		}
		if (DisplayValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DisplayValue);
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
		if (Type != BattleStaticticEventType.BattleStaticticEventNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (PICEGMCCHME != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PICEGMCCHME);
		}
		if (DisplayValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DisplayValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StatisticEvent other)
	{
		if (other != null)
		{
			if (other.Type != BattleStaticticEventType.BattleStaticticEventNone)
			{
				Type = other.Type;
			}
			if (other.PICEGMCCHME != 0)
			{
				PICEGMCCHME = other.PICEGMCCHME;
			}
			if (other.DisplayValue != 0)
			{
				DisplayValue = other.DisplayValue;
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
				Type = (BattleStaticticEventType)input.ReadEnum();
				break;
			case 16u:
				PICEGMCCHME = input.ReadUInt32();
				break;
			case 24u:
				DisplayValue = input.ReadUInt32();
				break;
			}
		}
	}
}
