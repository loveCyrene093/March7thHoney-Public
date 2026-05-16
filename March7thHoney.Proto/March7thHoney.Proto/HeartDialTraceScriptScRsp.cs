using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeartDialTraceScriptScRsp : IMessage<HeartDialTraceScriptScRsp>, IMessage, IEquatable<HeartDialTraceScriptScRsp>, IDeepCloneable<HeartDialTraceScriptScRsp>, IBufferMessage
{
	private static readonly MessageParser<HeartDialTraceScriptScRsp> _parser = new MessageParser<HeartDialTraceScriptScRsp>(() => new HeartDialTraceScriptScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GAIPLPHEFFKFieldNumber = 4;

	private PICILIIFKBE gAIPLPHEFFK_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeartDialTraceScriptScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeartDialTraceScriptScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PICILIIFKBE GAIPLPHEFFK
	{
		get
		{
			return gAIPLPHEFFK_;
		}
		set
		{
			gAIPLPHEFFK_ = value;
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
	public HeartDialTraceScriptScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialTraceScriptScRsp(HeartDialTraceScriptScRsp other)
		: this()
	{
		gAIPLPHEFFK_ = ((other.gAIPLPHEFFK_ != null) ? other.gAIPLPHEFFK_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialTraceScriptScRsp Clone()
	{
		return new HeartDialTraceScriptScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeartDialTraceScriptScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeartDialTraceScriptScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GAIPLPHEFFK, other.GAIPLPHEFFK))
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
		if (gAIPLPHEFFK_ != null)
		{
			num ^= GAIPLPHEFFK.GetHashCode();
		}
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
		if (gAIPLPHEFFK_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(GAIPLPHEFFK);
		}
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
		if (gAIPLPHEFFK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GAIPLPHEFFK);
		}
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
	public void MergeFrom(HeartDialTraceScriptScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gAIPLPHEFFK_ != null)
		{
			if (gAIPLPHEFFK_ == null)
			{
				GAIPLPHEFFK = new PICILIIFKBE();
			}
			GAIPLPHEFFK.MergeFrom(other.GAIPLPHEFFK);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 34u:
				if (gAIPLPHEFFK_ == null)
				{
					GAIPLPHEFFK = new PICILIIFKBE();
				}
				input.ReadMessage(GAIPLPHEFFK);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
