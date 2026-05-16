using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NPLEDHFMFDM : IMessage<NPLEDHFMFDM>, IMessage, IEquatable<NPLEDHFMFDM>, IDeepCloneable<NPLEDHFMFDM>, IBufferMessage
{
	private static readonly MessageParser<NPLEDHFMFDM> _parser = new MessageParser<NPLEDHFMFDM>(() => new NPLEDHFMFDM());

	private UnknownFieldSet _unknownFields;

	public const int HCJPDNDOHAMFieldNumber = 1;

	private uint hCJPDNDOHAM_;

	public const int SlotFieldNumber = 2;

	private uint slot_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NPLEDHFMFDM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NPLEDHFMFDMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCJPDNDOHAM
	{
		get
		{
			return hCJPDNDOHAM_;
		}
		set
		{
			hCJPDNDOHAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPLEDHFMFDM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPLEDHFMFDM(NPLEDHFMFDM other)
		: this()
	{
		hCJPDNDOHAM_ = other.hCJPDNDOHAM_;
		slot_ = other.slot_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPLEDHFMFDM Clone()
	{
		return new NPLEDHFMFDM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NPLEDHFMFDM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NPLEDHFMFDM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCJPDNDOHAM != other.HCJPDNDOHAM)
		{
			return false;
		}
		if (Slot != other.Slot)
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
		if (HCJPDNDOHAM != 0)
		{
			num ^= HCJPDNDOHAM.GetHashCode();
		}
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
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
		if (HCJPDNDOHAM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HCJPDNDOHAM);
		}
		if (Slot != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Slot);
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
		if (HCJPDNDOHAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCJPDNDOHAM);
		}
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NPLEDHFMFDM other)
	{
		if (other != null)
		{
			if (other.HCJPDNDOHAM != 0)
			{
				HCJPDNDOHAM = other.HCJPDNDOHAM;
			}
			if (other.Slot != 0)
			{
				Slot = other.Slot;
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
				HCJPDNDOHAM = input.ReadUInt32();
				break;
			case 16u:
				Slot = input.ReadUInt32();
				break;
			}
		}
	}
}
