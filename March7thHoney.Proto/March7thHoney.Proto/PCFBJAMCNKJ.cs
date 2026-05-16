using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCFBJAMCNKJ : IMessage<PCFBJAMCNKJ>, IMessage, IEquatable<PCFBJAMCNKJ>, IDeepCloneable<PCFBJAMCNKJ>, IBufferMessage
{
	private static readonly MessageParser<PCFBJAMCNKJ> _parser = new MessageParser<PCFBJAMCNKJ>(() => new PCFBJAMCNKJ());

	private UnknownFieldSet _unknownFields;

	public const int OGKNEBGDEFNFieldNumber = 7;

	private uint oGKNEBGDEFN_;

	public const int LOIJLIKOMJNFieldNumber = 15;

	private uint lOIJLIKOMJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCFBJAMCNKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCFBJAMCNKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGKNEBGDEFN
	{
		get
		{
			return oGKNEBGDEFN_;
		}
		set
		{
			oGKNEBGDEFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIJLIKOMJN
	{
		get
		{
			return lOIJLIKOMJN_;
		}
		set
		{
			lOIJLIKOMJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCFBJAMCNKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCFBJAMCNKJ(PCFBJAMCNKJ other)
		: this()
	{
		oGKNEBGDEFN_ = other.oGKNEBGDEFN_;
		lOIJLIKOMJN_ = other.lOIJLIKOMJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCFBJAMCNKJ Clone()
	{
		return new PCFBJAMCNKJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCFBJAMCNKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCFBJAMCNKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OGKNEBGDEFN != other.OGKNEBGDEFN)
		{
			return false;
		}
		if (LOIJLIKOMJN != other.LOIJLIKOMJN)
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
		if (OGKNEBGDEFN != 0)
		{
			num ^= OGKNEBGDEFN.GetHashCode();
		}
		if (LOIJLIKOMJN != 0)
		{
			num ^= LOIJLIKOMJN.GetHashCode();
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
		if (OGKNEBGDEFN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OGKNEBGDEFN);
		}
		if (LOIJLIKOMJN != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LOIJLIKOMJN);
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
		if (OGKNEBGDEFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGKNEBGDEFN);
		}
		if (LOIJLIKOMJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIJLIKOMJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCFBJAMCNKJ other)
	{
		if (other != null)
		{
			if (other.OGKNEBGDEFN != 0)
			{
				OGKNEBGDEFN = other.OGKNEBGDEFN;
			}
			if (other.LOIJLIKOMJN != 0)
			{
				LOIJLIKOMJN = other.LOIJLIKOMJN;
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
			case 56u:
				OGKNEBGDEFN = input.ReadUInt32();
				break;
			case 120u:
				LOIJLIKOMJN = input.ReadUInt32();
				break;
			}
		}
	}
}
