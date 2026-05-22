using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAssistListScRsp : IMessage<GetAssistListScRsp>, IMessage, IEquatable<GetAssistListScRsp>, IDeepCloneable<GetAssistListScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAssistListScRsp> _parser = new MessageParser<GetAssistListScRsp>(() => new GetAssistListScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int AssistListFieldNumber = 8;

	private static readonly FieldCodec<PlayerAssistInfo> _repeated_assistList_codec = FieldCodec.ForMessage(66u, PlayerAssistInfo.Parser);

	private readonly RepeatedField<PlayerAssistInfo> assistList_ = new RepeatedField<PlayerAssistInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAssistListScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAssistListScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<PlayerAssistInfo> AssistList => assistList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistListScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistListScRsp(GetAssistListScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		assistList_ = other.assistList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistListScRsp Clone()
	{
		return new GetAssistListScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAssistListScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAssistListScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!assistList_.Equals(other.assistList_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= assistList_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		assistList_.WriteTo(ref output, _repeated_assistList_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += assistList_.CalculateSize(_repeated_assistList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAssistListScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			assistList_.Add(other.assistList_);
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
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				assistList_.AddEntriesFrom(ref input, _repeated_assistList_codec);
				break;
			}
		}
	}
}
