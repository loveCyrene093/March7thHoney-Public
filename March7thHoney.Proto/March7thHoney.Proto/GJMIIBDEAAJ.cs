using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GJMIIBDEAAJ : IMessage<GJMIIBDEAAJ>, IMessage, IEquatable<GJMIIBDEAAJ>, IDeepCloneable<GJMIIBDEAAJ>, IBufferMessage
{
	private static readonly MessageParser<GJMIIBDEAAJ> _parser = new MessageParser<GJMIIBDEAAJ>(() => new GJMIIBDEAAJ());

	private UnknownFieldSet _unknownFields;

	public const int HDFJAINBKJGFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_hDFJAINBKJG_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> hDFJAINBKJG_ = new RepeatedField<uint>();

	public const int IsGetAllFieldNumber = 8;

	private bool isGetAll_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GJMIIBDEAAJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GJMIIBDEAAJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HDFJAINBKJG => hDFJAINBKJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsGetAll
	{
		get
		{
			return isGetAll_;
		}
		set
		{
			isGetAll_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJMIIBDEAAJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJMIIBDEAAJ(GJMIIBDEAAJ other)
		: this()
	{
		hDFJAINBKJG_ = other.hDFJAINBKJG_.Clone();
		isGetAll_ = other.isGetAll_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJMIIBDEAAJ Clone()
	{
		return new GJMIIBDEAAJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GJMIIBDEAAJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GJMIIBDEAAJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hDFJAINBKJG_.Equals(other.hDFJAINBKJG_))
		{
			return false;
		}
		if (IsGetAll != other.IsGetAll)
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
		num ^= hDFJAINBKJG_.GetHashCode();
		if (IsGetAll)
		{
			num ^= IsGetAll.GetHashCode();
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
		hDFJAINBKJG_.WriteTo(ref output, _repeated_hDFJAINBKJG_codec);
		if (IsGetAll)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsGetAll);
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
		num += hDFJAINBKJG_.CalculateSize(_repeated_hDFJAINBKJG_codec);
		if (IsGetAll)
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
	public void MergeFrom(GJMIIBDEAAJ other)
	{
		if (other != null)
		{
			hDFJAINBKJG_.Add(other.hDFJAINBKJG_);
			if (other.IsGetAll)
			{
				IsGetAll = other.IsGetAll;
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
			case 8u:
			case 10u:
				hDFJAINBKJG_.AddEntriesFrom(ref input, _repeated_hDFJAINBKJG_codec);
				break;
			case 64u:
				IsGetAll = input.ReadBool();
				break;
			}
		}
	}
}
