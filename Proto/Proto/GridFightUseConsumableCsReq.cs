using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightUseConsumableCsReq : IMessage<GridFightUseConsumableCsReq>, IMessage, IEquatable<GridFightUseConsumableCsReq>, IDeepCloneable<GridFightUseConsumableCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightUseConsumableCsReq> _parser = new MessageParser<GridFightUseConsumableCsReq>(() => new GridFightUseConsumableCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DisplayValueFieldNumber = 4;

	private GridFightConsumableTargetInfo displayValue_;

	public const int ItemIdFieldNumber = 9;

	private uint itemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightUseConsumableCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightUseConsumableCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightConsumableTargetInfo DisplayValue
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
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUseConsumableCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUseConsumableCsReq(GridFightUseConsumableCsReq other)
		: this()
	{
		displayValue_ = ((other.displayValue_ != null) ? other.displayValue_.Clone() : null);
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUseConsumableCsReq Clone()
	{
		return new GridFightUseConsumableCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightUseConsumableCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightUseConsumableCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DisplayValue, other.DisplayValue))
		{
			return false;
		}
		if (ItemId != other.ItemId)
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
		if (displayValue_ != null)
		{
			num ^= DisplayValue.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
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
		if (displayValue_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(DisplayValue);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ItemId);
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
		if (displayValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DisplayValue);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightUseConsumableCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.displayValue_ != null)
		{
			if (displayValue_ == null)
			{
				DisplayValue = new GridFightConsumableTargetInfo();
			}
			DisplayValue.MergeFrom(other.DisplayValue);
		}
		if (other.ItemId != 0)
		{
			ItemId = other.ItemId;
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
			case 34u:
				if (displayValue_ == null)
				{
					DisplayValue = new GridFightConsumableTargetInfo();
				}
				input.ReadMessage(DisplayValue);
				break;
			case 72u:
				ItemId = input.ReadUInt32();
				break;
			}
		}
	}
}
