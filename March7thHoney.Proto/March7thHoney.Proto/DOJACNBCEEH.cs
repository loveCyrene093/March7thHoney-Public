using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOJACNBCEEH : IMessage<DOJACNBCEEH>, IMessage, IEquatable<DOJACNBCEEH>, IDeepCloneable<DOJACNBCEEH>, IBufferMessage
{
	private static readonly MessageParser<DOJACNBCEEH> _parser = new MessageParser<DOJACNBCEEH>(() => new DOJACNBCEEH());

	private UnknownFieldSet _unknownFields;

	public const int HHIMINBGJDIFieldNumber = 15;

	private uint hHIMINBGJDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOJACNBCEEH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOJACNBCEEHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HHIMINBGJDI
	{
		get
		{
			return hHIMINBGJDI_;
		}
		set
		{
			hHIMINBGJDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOJACNBCEEH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOJACNBCEEH(DOJACNBCEEH other)
		: this()
	{
		hHIMINBGJDI_ = other.hHIMINBGJDI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOJACNBCEEH Clone()
	{
		return new DOJACNBCEEH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOJACNBCEEH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOJACNBCEEH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HHIMINBGJDI != other.HHIMINBGJDI)
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
		if (HHIMINBGJDI != 0)
		{
			num ^= HHIMINBGJDI.GetHashCode();
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
		if (HHIMINBGJDI != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HHIMINBGJDI);
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
		if (HHIMINBGJDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HHIMINBGJDI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOJACNBCEEH other)
	{
		if (other != null)
		{
			if (other.HHIMINBGJDI != 0)
			{
				HHIMINBGJDI = other.HHIMINBGJDI;
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
			if (num != 120)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HHIMINBGJDI = input.ReadUInt32();
			}
		}
	}
}
