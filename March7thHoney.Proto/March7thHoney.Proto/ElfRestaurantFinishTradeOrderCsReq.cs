using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantFinishTradeOrderCsReq : IMessage<ElfRestaurantFinishTradeOrderCsReq>, IMessage, IEquatable<ElfRestaurantFinishTradeOrderCsReq>, IDeepCloneable<ElfRestaurantFinishTradeOrderCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantFinishTradeOrderCsReq> _parser = new MessageParser<ElfRestaurantFinishTradeOrderCsReq>(() => new ElfRestaurantFinishTradeOrderCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IIMKIFDKJHOFieldNumber = 12;

	private uint iIMKIFDKJHO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantFinishTradeOrderCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantFinishTradeOrderCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIMKIFDKJHO
	{
		get
		{
			return iIMKIFDKJHO_;
		}
		set
		{
			iIMKIFDKJHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantFinishTradeOrderCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantFinishTradeOrderCsReq(ElfRestaurantFinishTradeOrderCsReq other)
		: this()
	{
		iIMKIFDKJHO_ = other.iIMKIFDKJHO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantFinishTradeOrderCsReq Clone()
	{
		return new ElfRestaurantFinishTradeOrderCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantFinishTradeOrderCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantFinishTradeOrderCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IIMKIFDKJHO != other.IIMKIFDKJHO)
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
		if (IIMKIFDKJHO != 0)
		{
			num ^= IIMKIFDKJHO.GetHashCode();
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
		if (IIMKIFDKJHO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(IIMKIFDKJHO);
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
		if (IIMKIFDKJHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIMKIFDKJHO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantFinishTradeOrderCsReq other)
	{
		if (other != null)
		{
			if (other.IIMKIFDKJHO != 0)
			{
				IIMKIFDKJHO = other.IIMKIFDKJHO;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IIMKIFDKJHO = input.ReadUInt32();
			}
		}
	}
}
