using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JIFOPBNNKON : IMessage<JIFOPBNNKON>, IMessage, IEquatable<JIFOPBNNKON>, IDeepCloneable<JIFOPBNNKON>, IBufferMessage
{
	private static readonly MessageParser<JIFOPBNNKON> _parser = new MessageParser<JIFOPBNNKON>(() => new JIFOPBNNKON());

	private UnknownFieldSet _unknownFields;

	public const int OGONJOGDDIEFieldNumber = 14;

	private uint oGONJOGDDIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JIFOPBNNKON> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JIFOPBNNKONReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGONJOGDDIE
	{
		get
		{
			return oGONJOGDDIE_;
		}
		set
		{
			oGONJOGDDIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIFOPBNNKON()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIFOPBNNKON(JIFOPBNNKON other)
		: this()
	{
		oGONJOGDDIE_ = other.oGONJOGDDIE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIFOPBNNKON Clone()
	{
		return new JIFOPBNNKON(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JIFOPBNNKON);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JIFOPBNNKON other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OGONJOGDDIE != other.OGONJOGDDIE)
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
		if (OGONJOGDDIE != 0)
		{
			num ^= OGONJOGDDIE.GetHashCode();
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
		if (OGONJOGDDIE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OGONJOGDDIE);
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
		if (OGONJOGDDIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGONJOGDDIE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JIFOPBNNKON other)
	{
		if (other != null)
		{
			if (other.OGONJOGDDIE != 0)
			{
				OGONJOGDDIE = other.OGONJOGDDIE;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				OGONJOGDDIE = input.ReadUInt32();
			}
		}
	}
}
