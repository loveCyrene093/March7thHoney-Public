using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GNBODNMGBDL : IMessage<GNBODNMGBDL>, IMessage, IEquatable<GNBODNMGBDL>, IDeepCloneable<GNBODNMGBDL>, IBufferMessage
{
	private static readonly MessageParser<GNBODNMGBDL> _parser = new MessageParser<GNBODNMGBDL>(() => new GNBODNMGBDL());

	private UnknownFieldSet _unknownFields;

	public const int GPJHJOOIJJCFieldNumber = 2;

	private uint gPJHJOOIJJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GNBODNMGBDL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GNBODNMGBDLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPJHJOOIJJC
	{
		get
		{
			return gPJHJOOIJJC_;
		}
		set
		{
			gPJHJOOIJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNBODNMGBDL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNBODNMGBDL(GNBODNMGBDL other)
		: this()
	{
		gPJHJOOIJJC_ = other.gPJHJOOIJJC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNBODNMGBDL Clone()
	{
		return new GNBODNMGBDL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GNBODNMGBDL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GNBODNMGBDL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GPJHJOOIJJC != other.GPJHJOOIJJC)
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
		if (GPJHJOOIJJC != 0)
		{
			num ^= GPJHJOOIJJC.GetHashCode();
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
		if (GPJHJOOIJJC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GPJHJOOIJJC);
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
		if (GPJHJOOIJJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJHJOOIJJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GNBODNMGBDL other)
	{
		if (other != null)
		{
			if (other.GPJHJOOIJJC != 0)
			{
				GPJHJOOIJJC = other.GPJHJOOIJJC;
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
				GPJHJOOIJJC = input.ReadUInt32();
			}
		}
	}
}
