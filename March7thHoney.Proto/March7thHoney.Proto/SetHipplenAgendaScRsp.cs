using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetHipplenAgendaScRsp : IMessage<SetHipplenAgendaScRsp>, IMessage, IEquatable<SetHipplenAgendaScRsp>, IDeepCloneable<SetHipplenAgendaScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetHipplenAgendaScRsp> _parser = new MessageParser<SetHipplenAgendaScRsp>(() => new SetHipplenAgendaScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CLKAILDCPJCFieldNumber = 6;

	private static readonly FieldCodec<EKOIHOMFMDE> _repeated_cLKAILDCPJC_codec = FieldCodec.ForMessage(50u, EKOIHOMFMDE.Parser);

	private readonly RepeatedField<EKOIHOMFMDE> cLKAILDCPJC_ = new RepeatedField<EKOIHOMFMDE>();

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetHipplenAgendaScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetHipplenAgendaScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EKOIHOMFMDE> CLKAILDCPJC => cLKAILDCPJC_;

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
	public SetHipplenAgendaScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetHipplenAgendaScRsp(SetHipplenAgendaScRsp other)
		: this()
	{
		cLKAILDCPJC_ = other.cLKAILDCPJC_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetHipplenAgendaScRsp Clone()
	{
		return new SetHipplenAgendaScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetHipplenAgendaScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetHipplenAgendaScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cLKAILDCPJC_.Equals(other.cLKAILDCPJC_))
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
		num ^= cLKAILDCPJC_.GetHashCode();
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
		cLKAILDCPJC_.WriteTo(ref output, _repeated_cLKAILDCPJC_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		num += cLKAILDCPJC_.CalculateSize(_repeated_cLKAILDCPJC_codec);
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
	public void MergeFrom(SetHipplenAgendaScRsp other)
	{
		if (other != null)
		{
			cLKAILDCPJC_.Add(other.cLKAILDCPJC_);
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
			case 50u:
				cLKAILDCPJC_.AddEntriesFrom(ref input, _repeated_cLKAILDCPJC_codec);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
