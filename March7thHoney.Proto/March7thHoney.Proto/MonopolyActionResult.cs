using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyActionResult : IMessage<MonopolyActionResult>, IMessage, IEquatable<MonopolyActionResult>, IDeepCloneable<MonopolyActionResult>, IBufferMessage
{
	private static readonly MessageParser<MonopolyActionResult> _parser = new MessageParser<MonopolyActionResult>(() => new MonopolyActionResult());

	private UnknownFieldSet _unknownFields;

	public const int DetailFieldNumber = 2;

	private JDMPAAEGMCD detail_;

	public const int SourceTypeFieldNumber = 3;

	private NGAEFPNBDAD sourceType_;

	public const int ClickCellIdFieldNumber = 7;

	private uint clickCellId_;

	public const int TriggerCellIdFieldNumber = 8;

	private uint triggerCellId_;

	public const int EffectTypeFieldNumber = 9;

	private uint effectType_;

	public const int TriggerMapIdFieldNumber = 10;

	private uint triggerMapId_;

	public const int ClickMapIdFieldNumber = 15;

	private uint clickMapId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyActionResult> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyActionResultReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDMPAAEGMCD Detail
	{
		get
		{
			return detail_;
		}
		set
		{
			detail_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGAEFPNBDAD SourceType
	{
		get
		{
			return sourceType_;
		}
		set
		{
			sourceType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClickCellId
	{
		get
		{
			return clickCellId_;
		}
		set
		{
			clickCellId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TriggerCellId
	{
		get
		{
			return triggerCellId_;
		}
		set
		{
			triggerCellId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EffectType
	{
		get
		{
			return effectType_;
		}
		set
		{
			effectType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TriggerMapId
	{
		get
		{
			return triggerMapId_;
		}
		set
		{
			triggerMapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClickMapId
	{
		get
		{
			return clickMapId_;
		}
		set
		{
			clickMapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyActionResult()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyActionResult(MonopolyActionResult other)
		: this()
	{
		detail_ = ((other.detail_ != null) ? other.detail_.Clone() : null);
		sourceType_ = other.sourceType_;
		clickCellId_ = other.clickCellId_;
		triggerCellId_ = other.triggerCellId_;
		effectType_ = other.effectType_;
		triggerMapId_ = other.triggerMapId_;
		clickMapId_ = other.clickMapId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyActionResult Clone()
	{
		return new MonopolyActionResult(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyActionResult);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyActionResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Detail, other.Detail))
		{
			return false;
		}
		if (SourceType != other.SourceType)
		{
			return false;
		}
		if (ClickCellId != other.ClickCellId)
		{
			return false;
		}
		if (TriggerCellId != other.TriggerCellId)
		{
			return false;
		}
		if (EffectType != other.EffectType)
		{
			return false;
		}
		if (TriggerMapId != other.TriggerMapId)
		{
			return false;
		}
		if (ClickMapId != other.ClickMapId)
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
		if (detail_ != null)
		{
			num ^= Detail.GetHashCode();
		}
		if (SourceType != NGAEFPNBDAD.Pcpdhelpkem)
		{
			num ^= SourceType.GetHashCode();
		}
		if (ClickCellId != 0)
		{
			num ^= ClickCellId.GetHashCode();
		}
		if (TriggerCellId != 0)
		{
			num ^= TriggerCellId.GetHashCode();
		}
		if (EffectType != 0)
		{
			num ^= EffectType.GetHashCode();
		}
		if (TriggerMapId != 0)
		{
			num ^= TriggerMapId.GetHashCode();
		}
		if (ClickMapId != 0)
		{
			num ^= ClickMapId.GetHashCode();
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
		if (detail_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Detail);
		}
		if (SourceType != NGAEFPNBDAD.Pcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SourceType);
		}
		if (ClickCellId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ClickCellId);
		}
		if (TriggerCellId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(TriggerCellId);
		}
		if (EffectType != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EffectType);
		}
		if (TriggerMapId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(TriggerMapId);
		}
		if (ClickMapId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ClickMapId);
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
		if (detail_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Detail);
		}
		if (SourceType != NGAEFPNBDAD.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SourceType);
		}
		if (ClickCellId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClickCellId);
		}
		if (TriggerCellId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TriggerCellId);
		}
		if (EffectType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectType);
		}
		if (TriggerMapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TriggerMapId);
		}
		if (ClickMapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClickMapId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyActionResult other)
	{
		if (other == null)
		{
			return;
		}
		if (other.detail_ != null)
		{
			if (detail_ == null)
			{
				Detail = new JDMPAAEGMCD();
			}
			Detail.MergeFrom(other.Detail);
		}
		if (other.SourceType != NGAEFPNBDAD.Pcpdhelpkem)
		{
			SourceType = other.SourceType;
		}
		if (other.ClickCellId != 0)
		{
			ClickCellId = other.ClickCellId;
		}
		if (other.TriggerCellId != 0)
		{
			TriggerCellId = other.TriggerCellId;
		}
		if (other.EffectType != 0)
		{
			EffectType = other.EffectType;
		}
		if (other.TriggerMapId != 0)
		{
			TriggerMapId = other.TriggerMapId;
		}
		if (other.ClickMapId != 0)
		{
			ClickMapId = other.ClickMapId;
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
			case 18u:
				if (detail_ == null)
				{
					Detail = new JDMPAAEGMCD();
				}
				input.ReadMessage(Detail);
				break;
			case 24u:
				SourceType = (NGAEFPNBDAD)input.ReadEnum();
				break;
			case 56u:
				ClickCellId = input.ReadUInt32();
				break;
			case 64u:
				TriggerCellId = input.ReadUInt32();
				break;
			case 72u:
				EffectType = input.ReadUInt32();
				break;
			case 80u:
				TriggerMapId = input.ReadUInt32();
				break;
			case 120u:
				ClickMapId = input.ReadUInt32();
				break;
			}
		}
	}
}
