using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlleyPlacingShip : IMessage<AlleyPlacingShip>, IMessage, IEquatable<AlleyPlacingShip>, IDeepCloneable<AlleyPlacingShip>, IBufferMessage
{
	private static readonly MessageParser<AlleyPlacingShip> _parser = new MessageParser<AlleyPlacingShip>(() => new AlleyPlacingShip());

	private UnknownFieldSet _unknownFields;

	public const int GoodsListFieldNumber = 1;

	private static readonly FieldCodec<JMDDGOGNBEK> _repeated_goodsList_codec = FieldCodec.ForMessage(10u, JMDDGOGNBEK.Parser);

	private readonly RepeatedField<JMDDGOGNBEK> goodsList_ = new RepeatedField<JMDDGOGNBEK>();

	public const int ShipIdFieldNumber = 13;

	private uint shipId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlleyPlacingShip> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AlleyPlacingShipReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JMDDGOGNBEK> GoodsList => goodsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ShipId
	{
		get
		{
			return shipId_;
		}
		set
		{
			shipId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingShip()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingShip(AlleyPlacingShip other)
		: this()
	{
		goodsList_ = other.goodsList_.Clone();
		shipId_ = other.shipId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingShip Clone()
	{
		return new AlleyPlacingShip(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AlleyPlacingShip);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlleyPlacingShip other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!goodsList_.Equals(other.goodsList_))
		{
			return false;
		}
		if (ShipId != other.ShipId)
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
		num ^= goodsList_.GetHashCode();
		if (ShipId != 0)
		{
			num ^= ShipId.GetHashCode();
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
		goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
		if (ShipId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ShipId);
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
		num += goodsList_.CalculateSize(_repeated_goodsList_codec);
		if (ShipId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShipId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlleyPlacingShip other)
	{
		if (other != null)
		{
			goodsList_.Add(other.goodsList_);
			if (other.ShipId != 0)
			{
				ShipId = other.ShipId;
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
			case 10u:
				goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
				break;
			case 104u:
				ShipId = input.ReadUInt32();
				break;
			}
		}
	}
}
