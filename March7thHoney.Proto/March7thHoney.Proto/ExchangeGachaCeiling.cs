using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeGachaCeiling : IMessage<ExchangeGachaCeiling>, IMessage, IEquatable<ExchangeGachaCeiling>, IDeepCloneable<ExchangeGachaCeiling>, IBufferMessage
{
	private static readonly MessageParser<ExchangeGachaCeiling> _parser = new MessageParser<ExchangeGachaCeiling>(() => new ExchangeGachaCeiling());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int TransferItemListFieldNumber = 3;

	private ItemList transferItemList_;

	public const int GachaCeilingFieldNumber = 6;

	private GachaCeiling gachaCeiling_;

	public const int GachaTypeFieldNumber = 8;

	private uint gachaType_;

	public const int AvatarIdFieldNumber = 9;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeGachaCeiling> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ExchangeGachaCeilingReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ItemList TransferItemList
	{
		get
		{
			return transferItemList_;
		}
		set
		{
			transferItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaCeiling GachaCeiling
	{
		get
		{
			return gachaCeiling_;
		}
		set
		{
			gachaCeiling_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaType
	{
		get
		{
			return gachaType_;
		}
		set
		{
			gachaType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeGachaCeiling()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeGachaCeiling(ExchangeGachaCeiling other)
		: this()
	{
		retcode_ = other.retcode_;
		transferItemList_ = ((other.transferItemList_ != null) ? other.transferItemList_.Clone() : null);
		gachaCeiling_ = ((other.gachaCeiling_ != null) ? other.gachaCeiling_.Clone() : null);
		gachaType_ = other.gachaType_;
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeGachaCeiling Clone()
	{
		return new ExchangeGachaCeiling(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ExchangeGachaCeiling);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeGachaCeiling other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(TransferItemList, other.TransferItemList))
		{
			return false;
		}
		if (!object.Equals(GachaCeiling, other.GachaCeiling))
		{
			return false;
		}
		if (GachaType != other.GachaType)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (transferItemList_ != null)
		{
			num ^= TransferItemList.GetHashCode();
		}
		if (gachaCeiling_ != null)
		{
			num ^= GachaCeiling.GetHashCode();
		}
		if (GachaType != 0)
		{
			num ^= GachaType.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (transferItemList_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TransferItemList);
		}
		if (gachaCeiling_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GachaCeiling);
		}
		if (GachaType != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GachaType);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AvatarId);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (transferItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TransferItemList);
		}
		if (gachaCeiling_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GachaCeiling);
		}
		if (GachaType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaType);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeGachaCeiling other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.transferItemList_ != null)
		{
			if (transferItemList_ == null)
			{
				TransferItemList = new ItemList();
			}
			TransferItemList.MergeFrom(other.TransferItemList);
		}
		if (other.gachaCeiling_ != null)
		{
			if (gachaCeiling_ == null)
			{
				GachaCeiling = new GachaCeiling();
			}
			GachaCeiling.MergeFrom(other.GachaCeiling);
		}
		if (other.GachaType != 0)
		{
			GachaType = other.GachaType;
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (transferItemList_ == null)
				{
					TransferItemList = new ItemList();
				}
				input.ReadMessage(TransferItemList);
				break;
			case 50u:
				if (gachaCeiling_ == null)
				{
					GachaCeiling = new GachaCeiling();
				}
				input.ReadMessage(GachaCeiling);
				break;
			case 64u:
				GachaType = input.ReadUInt32();
				break;
			case 72u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
