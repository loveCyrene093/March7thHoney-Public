using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolySelectOptionScRsp : IMessage<MonopolySelectOptionScRsp>, IMessage, IEquatable<MonopolySelectOptionScRsp>, IDeepCloneable<MonopolySelectOptionScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolySelectOptionScRsp> _parser = new MessageParser<MonopolySelectOptionScRsp>(() => new MonopolySelectOptionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int GGLDOGIHFLGFieldNumber = 2;

	private BLIJEKKOIJH gGLDOGIHFLG_;

	public const int AMADFJNHMFFFieldNumber = 11;

	private uint aMADFJNHMFF_;

	public const int EventIdFieldNumber = 13;

	private uint eventId_;

	public const int JBLLICOOCAKFieldNumber = 14;

	private static readonly FieldCodec<NPLALEFPIEE> _repeated_jBLLICOOCAK_codec = FieldCodec.ForMessage(114u, NPLALEFPIEE.Parser);

	private readonly RepeatedField<NPLALEFPIEE> jBLLICOOCAK_ = new RepeatedField<NPLALEFPIEE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolySelectOptionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolySelectOptionScRspReflection.Descriptor.MessageTypes[0];

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
	public uint AMADFJNHMFF
	{
		get
		{
			return aMADFJNHMFF_;
		}
		set
		{
			aMADFJNHMFF_ = value;
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
	public RepeatedField<NPLALEFPIEE> JBLLICOOCAK => jBLLICOOCAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolySelectOptionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolySelectOptionScRsp(MonopolySelectOptionScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		gGLDOGIHFLG_ = ((other.gGLDOGIHFLG_ != null) ? other.gGLDOGIHFLG_.Clone() : null);
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		eventId_ = other.eventId_;
		jBLLICOOCAK_ = other.jBLLICOOCAK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolySelectOptionScRsp Clone()
	{
		return new MonopolySelectOptionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolySelectOptionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolySelectOptionScRsp other)
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
		if (AMADFJNHMFF != other.AMADFJNHMFF)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (!jBLLICOOCAK_.Equals(other.jBLLICOOCAK_))
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
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		num ^= jBLLICOOCAK_.GetHashCode();
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
			output.WriteRawTag(18);
			output.WriteMessage(GGLDOGIHFLG);
		}
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AMADFJNHMFF);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EventId);
		}
		jBLLICOOCAK_.WriteTo(ref output, _repeated_jBLLICOOCAK_codec);
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
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		num += jBLLICOOCAK_.CalculateSize(_repeated_jBLLICOOCAK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolySelectOptionScRsp other)
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
		if (other.AMADFJNHMFF != 0)
		{
			AMADFJNHMFF = other.AMADFJNHMFF;
		}
		if (other.EventId != 0)
		{
			EventId = other.EventId;
		}
		jBLLICOOCAK_.Add(other.jBLLICOOCAK_);
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
			case 18u:
				if (gGLDOGIHFLG_ == null)
				{
					GGLDOGIHFLG = new BLIJEKKOIJH();
				}
				input.ReadMessage(GGLDOGIHFLG);
				break;
			case 88u:
				AMADFJNHMFF = input.ReadUInt32();
				break;
			case 104u:
				EventId = input.ReadUInt32();
				break;
			case 114u:
				jBLLICOOCAK_.AddEntriesFrom(ref input, _repeated_jBLLICOOCAK_codec);
				break;
			}
		}
	}
}
