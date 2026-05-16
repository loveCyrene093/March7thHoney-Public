using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFiveDimMiniGameDataCsReq : IMessage<GetFiveDimMiniGameDataCsReq>, IMessage, IEquatable<GetFiveDimMiniGameDataCsReq>, IDeepCloneable<GetFiveDimMiniGameDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetFiveDimMiniGameDataCsReq> _parser = new MessageParser<GetFiveDimMiniGameDataCsReq>(() => new GetFiveDimMiniGameDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KEPMJKGJLNJFieldNumber = 15;

	private bool kEPMJKGJLNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFiveDimMiniGameDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFiveDimMiniGameDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KEPMJKGJLNJ
	{
		get
		{
			return kEPMJKGJLNJ_;
		}
		set
		{
			kEPMJKGJLNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMiniGameDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMiniGameDataCsReq(GetFiveDimMiniGameDataCsReq other)
		: this()
	{
		kEPMJKGJLNJ_ = other.kEPMJKGJLNJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMiniGameDataCsReq Clone()
	{
		return new GetFiveDimMiniGameDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFiveDimMiniGameDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFiveDimMiniGameDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KEPMJKGJLNJ != other.KEPMJKGJLNJ)
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
		if (KEPMJKGJLNJ)
		{
			num ^= KEPMJKGJLNJ.GetHashCode();
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
		if (KEPMJKGJLNJ)
		{
			output.WriteRawTag(120);
			output.WriteBool(KEPMJKGJLNJ);
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
		if (KEPMJKGJLNJ)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFiveDimMiniGameDataCsReq other)
	{
		if (other != null)
		{
			if (other.KEPMJKGJLNJ)
			{
				KEPMJKGJLNJ = other.KEPMJKGJLNJ;
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
				KEPMJKGJLNJ = input.ReadBool();
			}
		}
	}
}
