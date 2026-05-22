using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCHLKJCNCEN : IMessage<PCHLKJCNCEN>, IMessage, IEquatable<PCHLKJCNCEN>, IDeepCloneable<PCHLKJCNCEN>, IBufferMessage
{
	private static readonly MessageParser<PCHLKJCNCEN> _parser = new MessageParser<PCHLKJCNCEN>(() => new PCHLKJCNCEN());

	private UnknownFieldSet _unknownFields;

	public const int AssistMonsterEntityIdListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCHLKJCNCEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCHLKJCNCENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AssistMonsterEntityIdList => assistMonsterEntityIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCHLKJCNCEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCHLKJCNCEN(PCHLKJCNCEN other)
		: this()
	{
		assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCHLKJCNCEN Clone()
	{
		return new PCHLKJCNCEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCHLKJCNCEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCHLKJCNCEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_))
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
		num ^= assistMonsterEntityIdList_.GetHashCode();
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
		assistMonsterEntityIdList_.WriteTo(ref output, _repeated_assistMonsterEntityIdList_codec);
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
		num += assistMonsterEntityIdList_.CalculateSize(_repeated_assistMonsterEntityIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCHLKJCNCEN other)
	{
		if (other != null)
		{
			assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
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
			if (num != 120 && num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				assistMonsterEntityIdList_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityIdList_codec);
			}
		}
	}
}
