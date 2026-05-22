using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LogisticsGameScRsp : IMessage<LogisticsGameScRsp>, IMessage, IEquatable<LogisticsGameScRsp>, IDeepCloneable<LogisticsGameScRsp>, IBufferMessage
{
	private static readonly MessageParser<LogisticsGameScRsp> _parser = new MessageParser<LogisticsGameScRsp>(() => new LogisticsGameScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 1;

	private uint eventId_;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int OAIKIFEKFLGFieldNumber = 7;

	private static readonly FieldCodec<JCCMGOOPHBO> _repeated_oAIKIFEKFLG_codec = FieldCodec.ForMessage(58u, JCCMGOOPHBO.Parser);

	private readonly RepeatedField<JCCMGOOPHBO> oAIKIFEKFLG_ = new RepeatedField<JCCMGOOPHBO>();

	public const int CLPNBFOKJLJFieldNumber = 12;

	private bool cLPNBFOKJLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LogisticsGameScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LogisticsGameScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

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
	public RepeatedField<JCCMGOOPHBO> OAIKIFEKFLG => oAIKIFEKFLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CLPNBFOKJLJ
	{
		get
		{
			return cLPNBFOKJLJ_;
		}
		set
		{
			cLPNBFOKJLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsGameScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsGameScRsp(LogisticsGameScRsp other)
		: this()
	{
		eventId_ = other.eventId_;
		retcode_ = other.retcode_;
		oAIKIFEKFLG_ = other.oAIKIFEKFLG_.Clone();
		cLPNBFOKJLJ_ = other.cLPNBFOKJLJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsGameScRsp Clone()
	{
		return new LogisticsGameScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LogisticsGameScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LogisticsGameScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!oAIKIFEKFLG_.Equals(other.oAIKIFEKFLG_))
		{
			return false;
		}
		if (CLPNBFOKJLJ != other.CLPNBFOKJLJ)
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
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= oAIKIFEKFLG_.GetHashCode();
		if (CLPNBFOKJLJ)
		{
			num ^= CLPNBFOKJLJ.GetHashCode();
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
		if (EventId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EventId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		oAIKIFEKFLG_.WriteTo(ref output, _repeated_oAIKIFEKFLG_codec);
		if (CLPNBFOKJLJ)
		{
			output.WriteRawTag(96);
			output.WriteBool(CLPNBFOKJLJ);
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
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += oAIKIFEKFLG_.CalculateSize(_repeated_oAIKIFEKFLG_codec);
		if (CLPNBFOKJLJ)
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
	public void MergeFrom(LogisticsGameScRsp other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			oAIKIFEKFLG_.Add(other.oAIKIFEKFLG_);
			if (other.CLPNBFOKJLJ)
			{
				CLPNBFOKJLJ = other.CLPNBFOKJLJ;
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
				EventId = input.ReadUInt32();
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 58u:
				oAIKIFEKFLG_.AddEntriesFrom(ref input, _repeated_oAIKIFEKFLG_codec);
				break;
			case 96u:
				CLPNBFOKJLJ = input.ReadBool();
				break;
			}
		}
	}
}
