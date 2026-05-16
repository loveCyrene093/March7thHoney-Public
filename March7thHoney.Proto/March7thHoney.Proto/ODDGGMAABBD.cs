using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ODDGGMAABBD : IMessage<ODDGGMAABBD>, IMessage, IEquatable<ODDGGMAABBD>, IDeepCloneable<ODDGGMAABBD>, IBufferMessage
{
	private static readonly MessageParser<ODDGGMAABBD> _parser = new MessageParser<ODDGGMAABBD>(() => new ODDGGMAABBD());

	private UnknownFieldSet _unknownFields;

	public const int EPDCGJBJOJMFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_ePDCGJBJOJM_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> ePDCGJBJOJM_ = new RepeatedField<uint>();

	public const int ItemIdFieldNumber = 14;

	private uint itemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ODDGGMAABBD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ODDGGMAABBDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EPDCGJBJOJM => ePDCGJBJOJM_;

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
	public ODDGGMAABBD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODDGGMAABBD(ODDGGMAABBD other)
		: this()
	{
		ePDCGJBJOJM_ = other.ePDCGJBJOJM_.Clone();
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODDGGMAABBD Clone()
	{
		return new ODDGGMAABBD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ODDGGMAABBD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ODDGGMAABBD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ePDCGJBJOJM_.Equals(other.ePDCGJBJOJM_))
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
		num ^= ePDCGJBJOJM_.GetHashCode();
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
		ePDCGJBJOJM_.WriteTo(ref output, _repeated_ePDCGJBJOJM_codec);
		if (ItemId != 0)
		{
			output.WriteRawTag(112);
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
		num += ePDCGJBJOJM_.CalculateSize(_repeated_ePDCGJBJOJM_codec);
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
	public void MergeFrom(ODDGGMAABBD other)
	{
		if (other != null)
		{
			ePDCGJBJOJM_.Add(other.ePDCGJBJOJM_);
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
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
			case 10u:
				ePDCGJBJOJM_.AddEntriesFrom(ref input, _repeated_ePDCGJBJOJM_codec);
				break;
			case 112u:
				ItemId = input.ReadUInt32();
				break;
			}
		}
	}
}
