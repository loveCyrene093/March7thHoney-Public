using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TextJoinBatchSaveScRsp : IMessage<TextJoinBatchSaveScRsp>, IMessage, IEquatable<TextJoinBatchSaveScRsp>, IDeepCloneable<TextJoinBatchSaveScRsp>, IBufferMessage
{
	private static readonly MessageParser<TextJoinBatchSaveScRsp> _parser = new MessageParser<TextJoinBatchSaveScRsp>(() => new TextJoinBatchSaveScRsp());

	private UnknownFieldSet _unknownFields;

	public const int TextJoinListFieldNumber = 2;

	private static readonly FieldCodec<CEDGNIIEIMC> _repeated_textJoinList_codec = FieldCodec.ForMessage(18u, CEDGNIIEIMC.Parser);

	private readonly RepeatedField<CEDGNIIEIMC> textJoinList_ = new RepeatedField<CEDGNIIEIMC>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TextJoinBatchSaveScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TextJoinBatchSaveScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CEDGNIIEIMC> TextJoinList => textJoinList_;

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
	public TextJoinBatchSaveScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextJoinBatchSaveScRsp(TextJoinBatchSaveScRsp other)
		: this()
	{
		textJoinList_ = other.textJoinList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextJoinBatchSaveScRsp Clone()
	{
		return new TextJoinBatchSaveScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TextJoinBatchSaveScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TextJoinBatchSaveScRsp other)
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
		num ^= textJoinList_.GetHashCode();
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
		textJoinList_.WriteTo(ref output, _repeated_textJoinList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
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
		num += textJoinList_.CalculateSize(_repeated_textJoinList_codec);
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
	public void MergeFrom(TextJoinBatchSaveScRsp other)
	{
		if (other != null)
		{
			textJoinList_.Add(other.textJoinList_);
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
			case 18u:
				textJoinList_.AddEntriesFrom(ref input, _repeated_textJoinList_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
