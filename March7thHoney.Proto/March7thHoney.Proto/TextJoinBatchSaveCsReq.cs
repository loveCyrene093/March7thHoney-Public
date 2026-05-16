using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TextJoinBatchSaveCsReq : IMessage<TextJoinBatchSaveCsReq>, IMessage, IEquatable<TextJoinBatchSaveCsReq>, IDeepCloneable<TextJoinBatchSaveCsReq>, IBufferMessage
{
	private static readonly MessageParser<TextJoinBatchSaveCsReq> _parser = new MessageParser<TextJoinBatchSaveCsReq>(() => new TextJoinBatchSaveCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TextJoinListFieldNumber = 14;

	private static readonly FieldCodec<CEDGNIIEIMC> _repeated_textJoinList_codec = FieldCodec.ForMessage(114u, CEDGNIIEIMC.Parser);

	private readonly RepeatedField<CEDGNIIEIMC> textJoinList_ = new RepeatedField<CEDGNIIEIMC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TextJoinBatchSaveCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TextJoinBatchSaveCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CEDGNIIEIMC> TextJoinList => textJoinList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextJoinBatchSaveCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextJoinBatchSaveCsReq(TextJoinBatchSaveCsReq other)
		: this()
	{
		textJoinList_ = other.textJoinList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextJoinBatchSaveCsReq Clone()
	{
		return new TextJoinBatchSaveCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TextJoinBatchSaveCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TextJoinBatchSaveCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!textJoinList_.Equals(other.textJoinList_))
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
		num ^= textJoinList_.GetHashCode();
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
		textJoinList_.WriteTo(ref output, _repeated_textJoinList_codec);
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
		num += textJoinList_.CalculateSize(_repeated_textJoinList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TextJoinBatchSaveCsReq other)
	{
		if (other != null)
		{
			textJoinList_.Add(other.textJoinList_);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				textJoinList_.AddEntriesFrom(ref input, _repeated_textJoinList_codec);
			}
		}
	}
}
