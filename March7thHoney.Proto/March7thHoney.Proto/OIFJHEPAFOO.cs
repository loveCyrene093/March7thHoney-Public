using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OIFJHEPAFOO : IMessage<OIFJHEPAFOO>, IMessage, IEquatable<OIFJHEPAFOO>, IDeepCloneable<OIFJHEPAFOO>, IBufferMessage
{
	private static readonly MessageParser<OIFJHEPAFOO> _parser = new MessageParser<OIFJHEPAFOO>(() => new OIFJHEPAFOO());

	private UnknownFieldSet _unknownFields;

	public const int ONJKBENNMFCFieldNumber = 1;

	private GFNMAKHPAOE oNJKBENNMFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OIFJHEPAFOO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OIFJHEPAFOOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNMAKHPAOE ONJKBENNMFC
	{
		get
		{
			return oNJKBENNMFC_;
		}
		set
		{
			oNJKBENNMFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIFJHEPAFOO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIFJHEPAFOO(OIFJHEPAFOO other)
		: this()
	{
		oNJKBENNMFC_ = ((other.oNJKBENNMFC_ != null) ? other.oNJKBENNMFC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIFJHEPAFOO Clone()
	{
		return new OIFJHEPAFOO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OIFJHEPAFOO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OIFJHEPAFOO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ONJKBENNMFC, other.ONJKBENNMFC))
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
		if (oNJKBENNMFC_ != null)
		{
			num ^= ONJKBENNMFC.GetHashCode();
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
		if (oNJKBENNMFC_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ONJKBENNMFC);
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
		if (oNJKBENNMFC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ONJKBENNMFC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OIFJHEPAFOO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oNJKBENNMFC_ != null)
		{
			if (oNJKBENNMFC_ == null)
			{
				ONJKBENNMFC = new GFNMAKHPAOE();
			}
			ONJKBENNMFC.MergeFrom(other.ONJKBENNMFC);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oNJKBENNMFC_ == null)
			{
				ONJKBENNMFC = new GFNMAKHPAOE();
			}
			input.ReadMessage(ONJKBENNMFC);
		}
	}
}
