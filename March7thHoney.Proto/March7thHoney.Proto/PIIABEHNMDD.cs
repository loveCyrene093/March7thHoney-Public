using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PIIABEHNMDD : IMessage<PIIABEHNMDD>, IMessage, IEquatable<PIIABEHNMDD>, IDeepCloneable<PIIABEHNMDD>, IBufferMessage
{
	private static readonly MessageParser<PIIABEHNMDD> _parser = new MessageParser<PIIABEHNMDD>(() => new PIIABEHNMDD());

	private UnknownFieldSet _unknownFields;

	public const int ItemCountFieldNumber = 8;

	private uint itemCount_;

	public const int EGIMPFHCCDJFieldNumber = 12;

	private uint eGIMPFHCCDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PIIABEHNMDD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PIIABEHNMDDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemCount
	{
		get
		{
			return itemCount_;
		}
		set
		{
			itemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EGIMPFHCCDJ
	{
		get
		{
			return eGIMPFHCCDJ_;
		}
		set
		{
			eGIMPFHCCDJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIIABEHNMDD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIIABEHNMDD(PIIABEHNMDD other)
		: this()
	{
		itemCount_ = other.itemCount_;
		eGIMPFHCCDJ_ = other.eGIMPFHCCDJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIIABEHNMDD Clone()
	{
		return new PIIABEHNMDD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PIIABEHNMDD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PIIABEHNMDD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemCount != other.ItemCount)
		{
			return false;
		}
		if (EGIMPFHCCDJ != other.EGIMPFHCCDJ)
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
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
		}
		if (EGIMPFHCCDJ != 0)
		{
			num ^= EGIMPFHCCDJ.GetHashCode();
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
		if (ItemCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ItemCount);
		}
		if (EGIMPFHCCDJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EGIMPFHCCDJ);
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
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemCount);
		}
		if (EGIMPFHCCDJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EGIMPFHCCDJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PIIABEHNMDD other)
	{
		if (other != null)
		{
			if (other.ItemCount != 0)
			{
				ItemCount = other.ItemCount;
			}
			if (other.EGIMPFHCCDJ != 0)
			{
				EGIMPFHCCDJ = other.EGIMPFHCCDJ;
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
			case 64u:
				ItemCount = input.ReadUInt32();
				break;
			case 96u:
				EGIMPFHCCDJ = input.ReadUInt32();
				break;
			}
		}
	}
}
