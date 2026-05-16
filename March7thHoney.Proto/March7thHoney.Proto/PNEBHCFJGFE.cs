using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PNEBHCFJGFE : IMessage<PNEBHCFJGFE>, IMessage, IEquatable<PNEBHCFJGFE>, IDeepCloneable<PNEBHCFJGFE>, IBufferMessage
{
	private static readonly MessageParser<PNEBHCFJGFE> _parser = new MessageParser<PNEBHCFJGFE>(() => new PNEBHCFJGFE());

	private UnknownFieldSet _unknownFields;

	public const int KBNHAPKLBNDFieldNumber = 2;

	private uint kBNHAPKLBND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PNEBHCFJGFE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PNEBHCFJGFEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBNHAPKLBND
	{
		get
		{
			return kBNHAPKLBND_;
		}
		set
		{
			kBNHAPKLBND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNEBHCFJGFE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNEBHCFJGFE(PNEBHCFJGFE other)
		: this()
	{
		kBNHAPKLBND_ = other.kBNHAPKLBND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNEBHCFJGFE Clone()
	{
		return new PNEBHCFJGFE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PNEBHCFJGFE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PNEBHCFJGFE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBNHAPKLBND != other.KBNHAPKLBND)
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
		if (KBNHAPKLBND != 0)
		{
			num ^= KBNHAPKLBND.GetHashCode();
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
		if (KBNHAPKLBND != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KBNHAPKLBND);
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
		if (KBNHAPKLBND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBNHAPKLBND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PNEBHCFJGFE other)
	{
		if (other != null)
		{
			if (other.KBNHAPKLBND != 0)
			{
				KBNHAPKLBND = other.KBNHAPKLBND;
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
			if (num != 16)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KBNHAPKLBND = input.ReadUInt32();
			}
		}
	}
}
