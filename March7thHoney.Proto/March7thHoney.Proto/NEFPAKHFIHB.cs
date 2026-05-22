using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NEFPAKHFIHB : IMessage<NEFPAKHFIHB>, IMessage, IEquatable<NEFPAKHFIHB>, IDeepCloneable<NEFPAKHFIHB>, IBufferMessage
{
	private static readonly MessageParser<NEFPAKHFIHB> _parser = new MessageParser<NEFPAKHFIHB>(() => new NEFPAKHFIHB());

	private UnknownFieldSet _unknownFields;

	public const int CountFieldNumber = 2;

	private uint count_;

	public const int CJLJNPGKJGBFieldNumber = 6;

	private uint cJLJNPGKJGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NEFPAKHFIHB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NEFPAKHFIHBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint CJLJNPGKJGB
	{
		get
		{
			return cJLJNPGKJGB_;
		}
		set
		{
			cJLJNPGKJGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEFPAKHFIHB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEFPAKHFIHB(NEFPAKHFIHB other)
		: this()
	{
		count_ = other.count_;
		cJLJNPGKJGB_ = other.cJLJNPGKJGB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEFPAKHFIHB Clone()
	{
		return new NEFPAKHFIHB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NEFPAKHFIHB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NEFPAKHFIHB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (CJLJNPGKJGB != other.CJLJNPGKJGB)
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
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (CJLJNPGKJGB != 0)
		{
			num ^= CJLJNPGKJGB.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Count);
		}
		if (CJLJNPGKJGB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CJLJNPGKJGB);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (CJLJNPGKJGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJLJNPGKJGB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NEFPAKHFIHB other)
	{
		if (other != null)
		{
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.CJLJNPGKJGB != 0)
			{
				CJLJNPGKJGB = other.CJLJNPGKJGB;
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
			case 16u:
				Count = input.ReadUInt32();
				break;
			case 48u:
				CJLJNPGKJGB = input.ReadUInt32();
				break;
			}
		}
	}
}
