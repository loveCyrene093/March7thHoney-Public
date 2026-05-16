using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JLPGIGPCIAG : IMessage<JLPGIGPCIAG>, IMessage, IEquatable<JLPGIGPCIAG>, IDeepCloneable<JLPGIGPCIAG>, IBufferMessage
{
	private static readonly MessageParser<JLPGIGPCIAG> _parser = new MessageParser<JLPGIGPCIAG>(() => new JLPGIGPCIAG());

	private UnknownFieldSet _unknownFields;

	public const int EBMKBDJMAAFFieldNumber = 11;

	private ItemCostData eBMKBDJMAAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JLPGIGPCIAG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JLPGIGPCIAGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData EBMKBDJMAAF
	{
		get
		{
			return eBMKBDJMAAF_;
		}
		set
		{
			eBMKBDJMAAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLPGIGPCIAG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLPGIGPCIAG(JLPGIGPCIAG other)
		: this()
	{
		eBMKBDJMAAF_ = ((other.eBMKBDJMAAF_ != null) ? other.eBMKBDJMAAF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLPGIGPCIAG Clone()
	{
		return new JLPGIGPCIAG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JLPGIGPCIAG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JLPGIGPCIAG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EBMKBDJMAAF, other.EBMKBDJMAAF))
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
		if (eBMKBDJMAAF_ != null)
		{
			num ^= EBMKBDJMAAF.GetHashCode();
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
		if (eBMKBDJMAAF_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EBMKBDJMAAF);
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
		if (eBMKBDJMAAF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EBMKBDJMAAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JLPGIGPCIAG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eBMKBDJMAAF_ != null)
		{
			if (eBMKBDJMAAF_ == null)
			{
				EBMKBDJMAAF = new ItemCostData();
			}
			EBMKBDJMAAF.MergeFrom(other.EBMKBDJMAAF);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (eBMKBDJMAAF_ == null)
			{
				EBMKBDJMAAF = new ItemCostData();
			}
			input.ReadMessage(EBMKBDJMAAF);
		}
	}
}
