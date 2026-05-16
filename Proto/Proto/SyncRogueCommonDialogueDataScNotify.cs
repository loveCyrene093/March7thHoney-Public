using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueCommonDialogueDataScNotify : IMessage<SyncRogueCommonDialogueDataScNotify>, IMessage, IEquatable<SyncRogueCommonDialogueDataScNotify>, IDeepCloneable<SyncRogueCommonDialogueDataScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueCommonDialogueDataScNotify> _parser = new MessageParser<SyncRogueCommonDialogueDataScNotify>(() => new SyncRogueCommonDialogueDataScNotify());

	private UnknownFieldSet _unknownFields;

	public const int JOKAEEMJLMKFieldNumber = 12;

	private static readonly FieldCodec<JIBMJCBNDKK> _repeated_jOKAEEMJLMK_codec = FieldCodec.ForMessage(98u, JIBMJCBNDKK.Parser);

	private readonly RepeatedField<JIBMJCBNDKK> jOKAEEMJLMK_ = new RepeatedField<JIBMJCBNDKK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueCommonDialogueDataScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueCommonDialogueDataScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JIBMJCBNDKK> JOKAEEMJLMK => jOKAEEMJLMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonDialogueDataScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonDialogueDataScNotify(SyncRogueCommonDialogueDataScNotify other)
		: this()
	{
		jOKAEEMJLMK_ = other.jOKAEEMJLMK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonDialogueDataScNotify Clone()
	{
		return new SyncRogueCommonDialogueDataScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueCommonDialogueDataScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueCommonDialogueDataScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jOKAEEMJLMK_.Equals(other.jOKAEEMJLMK_))
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
		num ^= jOKAEEMJLMK_.GetHashCode();
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
		jOKAEEMJLMK_.WriteTo(ref output, _repeated_jOKAEEMJLMK_codec);
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
		num += jOKAEEMJLMK_.CalculateSize(_repeated_jOKAEEMJLMK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueCommonDialogueDataScNotify other)
	{
		if (other != null)
		{
			jOKAEEMJLMK_.Add(other.jOKAEEMJLMK_);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jOKAEEMJLMK_.AddEntriesFrom(ref input, _repeated_jOKAEEMJLMK_codec);
			}
		}
	}
}
