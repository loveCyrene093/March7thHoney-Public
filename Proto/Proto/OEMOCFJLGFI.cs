using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEMOCFJLGFI : IMessage<OEMOCFJLGFI>, IMessage, IEquatable<OEMOCFJLGFI>, IDeepCloneable<OEMOCFJLGFI>, IBufferMessage
{
	private static readonly MessageParser<OEMOCFJLGFI> _parser = new MessageParser<OEMOCFJLGFI>(() => new OEMOCFJLGFI());

	private UnknownFieldSet _unknownFields;

	public const int AANENKIIIMFFieldNumber = 1;

	private string aANENKIIIMF_ = "";

	public const int CountFieldNumber = 2;

	private uint count_;

	public const int TotalDamageFieldNumber = 3;

	private double totalDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEMOCFJLGFI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEMOCFJLGFIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AANENKIIIMF
	{
		get
		{
			return aANENKIIIMF_;
		}
		set
		{
			aANENKIIIMF_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEMOCFJLGFI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEMOCFJLGFI(OEMOCFJLGFI other)
		: this()
	{
		aANENKIIIMF_ = other.aANENKIIIMF_;
		count_ = other.count_;
		totalDamage_ = other.totalDamage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEMOCFJLGFI Clone()
	{
		return new OEMOCFJLGFI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEMOCFJLGFI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEMOCFJLGFI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AANENKIIIMF != other.AANENKIIIMF)
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamage, other.TotalDamage))
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
		if (AANENKIIIMF.Length != 0)
		{
			num ^= AANENKIIIMF.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (TotalDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamage);
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
		if (AANENKIIIMF.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AANENKIIIMF);
		}
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Count);
		}
		if (TotalDamage != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(TotalDamage);
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
		if (AANENKIIIMF.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AANENKIIIMF);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (TotalDamage != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OEMOCFJLGFI other)
	{
		if (other != null)
		{
			if (other.AANENKIIIMF.Length != 0)
			{
				AANENKIIIMF = other.AANENKIIIMF;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.TotalDamage != 0.0)
			{
				TotalDamage = other.TotalDamage;
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
				AANENKIIIMF = input.ReadString();
				break;
			case 16u:
				Count = input.ReadUInt32();
				break;
			case 25u:
				TotalDamage = input.ReadDouble();
				break;
			}
		}
	}
}
