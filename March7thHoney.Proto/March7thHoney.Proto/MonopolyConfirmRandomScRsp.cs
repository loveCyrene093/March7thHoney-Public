using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyConfirmRandomScRsp : IMessage<MonopolyConfirmRandomScRsp>, IMessage, IEquatable<MonopolyConfirmRandomScRsp>, IDeepCloneable<MonopolyConfirmRandomScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyConfirmRandomScRsp> _parser = new MessageParser<MonopolyConfirmRandomScRsp>(() => new MonopolyConfirmRandomScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 6;

	private uint eventId_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int GGLDOGIHFLGFieldNumber = 13;

	private BLIJEKKOIJH gGLDOGIHFLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyConfirmRandomScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyConfirmRandomScRspReflection.Descriptor.MessageTypes[0];

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
	public BLIJEKKOIJH GGLDOGIHFLG
	{
		get
		{
			return gGLDOGIHFLG_;
		}
		set
		{
			gGLDOGIHFLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyConfirmRandomScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyConfirmRandomScRsp(MonopolyConfirmRandomScRsp other)
		: this()
	{
		eventId_ = other.eventId_;
		retcode_ = other.retcode_;
		gGLDOGIHFLG_ = ((other.gGLDOGIHFLG_ != null) ? other.gGLDOGIHFLG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyConfirmRandomScRsp Clone()
	{
		return new MonopolyConfirmRandomScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyConfirmRandomScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyConfirmRandomScRsp other)
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
		if (!object.Equals(GGLDOGIHFLG, other.GGLDOGIHFLG))
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
		if (gGLDOGIHFLG_ != null)
		{
			num ^= GGLDOGIHFLG.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(EventId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (gGLDOGIHFLG_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GGLDOGIHFLG);
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
		if (gGLDOGIHFLG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GGLDOGIHFLG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyConfirmRandomScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EventId != 0)
		{
			EventId = other.EventId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.gGLDOGIHFLG_ != null)
		{
			if (gGLDOGIHFLG_ == null)
			{
				GGLDOGIHFLG = new BLIJEKKOIJH();
			}
			GGLDOGIHFLG.MergeFrom(other.GGLDOGIHFLG);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 48u:
				EventId = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				if (gGLDOGIHFLG_ == null)
				{
					GGLDOGIHFLG = new BLIJEKKOIJH();
				}
				input.ReadMessage(GGLDOGIHFLG);
				break;
			}
		}
	}
}
