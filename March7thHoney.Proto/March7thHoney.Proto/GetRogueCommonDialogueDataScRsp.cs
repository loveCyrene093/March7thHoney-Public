using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueCommonDialogueDataScRsp : IMessage<GetRogueCommonDialogueDataScRsp>, IMessage, IEquatable<GetRogueCommonDialogueDataScRsp>, IDeepCloneable<GetRogueCommonDialogueDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRogueCommonDialogueDataScRsp> _parser = new MessageParser<GetRogueCommonDialogueDataScRsp>(() => new GetRogueCommonDialogueDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JOKAEEMJLMKFieldNumber = 4;

	private static readonly FieldCodec<JIBMJCBNDKK> _repeated_jOKAEEMJLMK_codec = FieldCodec.ForMessage(34u, JIBMJCBNDKK.Parser);

	private readonly RepeatedField<JIBMJCBNDKK> jOKAEEMJLMK_ = new RepeatedField<JIBMJCBNDKK>();

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueCommonDialogueDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueCommonDialogueDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JIBMJCBNDKK> JOKAEEMJLMK => jOKAEEMJLMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueCommonDialogueDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueCommonDialogueDataScRsp(GetRogueCommonDialogueDataScRsp other)
		: this()
	{
		jOKAEEMJLMK_ = other.jOKAEEMJLMK_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueCommonDialogueDataScRsp Clone()
	{
		return new GetRogueCommonDialogueDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueCommonDialogueDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueCommonDialogueDataScRsp other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		jOKAEEMJLMK_.WriteTo(ref output, _repeated_jOKAEEMJLMK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
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
		num += jOKAEEMJLMK_.CalculateSize(_repeated_jOKAEEMJLMK_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRogueCommonDialogueDataScRsp other)
	{
		if (other != null)
		{
			jOKAEEMJLMK_.Add(other.jOKAEEMJLMK_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 34u:
				jOKAEEMJLMK_.AddEntriesFrom(ref input, _repeated_jOKAEEMJLMK_codec);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
