using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GLAAJKHKMHB : IMessage<GLAAJKHKMHB>, IMessage, IEquatable<GLAAJKHKMHB>, IDeepCloneable<GLAAJKHKMHB>, IBufferMessage
{
	private static readonly MessageParser<GLAAJKHKMHB> _parser = new MessageParser<GLAAJKHKMHB>(() => new GLAAJKHKMHB());

	private UnknownFieldSet _unknownFields;

	public const int DBIBNHEOPPIFieldNumber = 3;

	private uint dBIBNHEOPPI_;

	public const int ItemValueFieldNumber = 8;

	private uint itemValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GLAAJKHKMHB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GLAAJKHKMHBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBIBNHEOPPI
	{
		get
		{
			return dBIBNHEOPPI_;
		}
		set
		{
			dBIBNHEOPPI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLAAJKHKMHB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLAAJKHKMHB(GLAAJKHKMHB other)
		: this()
	{
		dBIBNHEOPPI_ = other.dBIBNHEOPPI_;
		itemValue_ = other.itemValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLAAJKHKMHB Clone()
	{
		return new GLAAJKHKMHB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GLAAJKHKMHB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GLAAJKHKMHB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DBIBNHEOPPI != other.DBIBNHEOPPI)
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
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
		if (DBIBNHEOPPI != 0)
		{
			num ^= DBIBNHEOPPI.GetHashCode();
		}
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
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
		if (DBIBNHEOPPI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DBIBNHEOPPI);
		}
		if (ItemValue != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ItemValue);
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
		if (DBIBNHEOPPI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBIBNHEOPPI);
		}
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GLAAJKHKMHB other)
	{
		if (other != null)
		{
			if (other.DBIBNHEOPPI != 0)
			{
				DBIBNHEOPPI = other.DBIBNHEOPPI;
			}
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
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
			case 24u:
				DBIBNHEOPPI = input.ReadUInt32();
				break;
			case 64u:
				ItemValue = input.ReadUInt32();
				break;
			}
		}
	}
}
