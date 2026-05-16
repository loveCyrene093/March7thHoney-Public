using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JAEOAGNKNBL : IMessage<JAEOAGNKNBL>, IMessage, IEquatable<JAEOAGNKNBL>, IDeepCloneable<JAEOAGNKNBL>, IBufferMessage
{
	private static readonly MessageParser<JAEOAGNKNBL> _parser = new MessageParser<JAEOAGNKNBL>(() => new JAEOAGNKNBL());

	private UnknownFieldSet _unknownFields;

	public const int KJOPCDJBLGNFieldNumber = 5;

	private IEDEMFKBHFL kJOPCDJBLGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JAEOAGNKNBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JAEOAGNKNBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEDEMFKBHFL KJOPCDJBLGN
	{
		get
		{
			return kJOPCDJBLGN_;
		}
		set
		{
			kJOPCDJBLGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAEOAGNKNBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAEOAGNKNBL(JAEOAGNKNBL other)
		: this()
	{
		kJOPCDJBLGN_ = ((other.kJOPCDJBLGN_ != null) ? other.kJOPCDJBLGN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAEOAGNKNBL Clone()
	{
		return new JAEOAGNKNBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JAEOAGNKNBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JAEOAGNKNBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KJOPCDJBLGN, other.KJOPCDJBLGN))
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
		if (kJOPCDJBLGN_ != null)
		{
			num ^= KJOPCDJBLGN.GetHashCode();
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
		if (kJOPCDJBLGN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(KJOPCDJBLGN);
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
		if (kJOPCDJBLGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KJOPCDJBLGN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JAEOAGNKNBL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kJOPCDJBLGN_ != null)
		{
			if (kJOPCDJBLGN_ == null)
			{
				KJOPCDJBLGN = new IEDEMFKBHFL();
			}
			KJOPCDJBLGN.MergeFrom(other.KJOPCDJBLGN);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (kJOPCDJBLGN_ == null)
			{
				KJOPCDJBLGN = new IEDEMFKBHFL();
			}
			input.ReadMessage(KJOPCDJBLGN);
		}
	}
}
