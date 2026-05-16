using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyReRollRandomScRsp : IMessage<MonopolyReRollRandomScRsp>, IMessage, IEquatable<MonopolyReRollRandomScRsp>, IDeepCloneable<MonopolyReRollRandomScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyReRollRandomScRsp> _parser = new MessageParser<MonopolyReRollRandomScRsp>(() => new MonopolyReRollRandomScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int GGLDOGIHFLGFieldNumber = 11;

	private BLIJEKKOIJH gGLDOGIHFLG_;

	public const int EventIdFieldNumber = 14;

	private uint eventId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyReRollRandomScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyReRollRandomScRspReflection.Descriptor.MessageTypes[0];

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
	public MonopolyReRollRandomScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyReRollRandomScRsp(MonopolyReRollRandomScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		gGLDOGIHFLG_ = ((other.gGLDOGIHFLG_ != null) ? other.gGLDOGIHFLG_.Clone() : null);
		eventId_ = other.eventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyReRollRandomScRsp Clone()
	{
		return new MonopolyReRollRandomScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyReRollRandomScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyReRollRandomScRsp other)
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
		if (!object.Equals(GGLDOGIHFLG, other.GGLDOGIHFLG))
		{
			return false;
		}
		if (EventId != other.EventId)
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
		if (gGLDOGIHFLG_ != null)
		{
			num ^= GGLDOGIHFLG.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (gGLDOGIHFLG_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(GGLDOGIHFLG);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(EventId);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (gGLDOGIHFLG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GGLDOGIHFLG);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyReRollRandomScRsp other)
	{
		if (other == null)
		{
			return;
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
		if (other.EventId != 0)
		{
			EventId = other.EventId;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (gGLDOGIHFLG_ == null)
				{
					GGLDOGIHFLG = new BLIJEKKOIJH();
				}
				input.ReadMessage(GGLDOGIHFLG);
				break;
			case 112u:
				EventId = input.ReadUInt32();
				break;
			}
		}
	}
}
