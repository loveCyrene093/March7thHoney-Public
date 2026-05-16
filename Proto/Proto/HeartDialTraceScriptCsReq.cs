using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeartDialTraceScriptCsReq : IMessage<HeartDialTraceScriptCsReq>, IMessage, IEquatable<HeartDialTraceScriptCsReq>, IDeepCloneable<HeartDialTraceScriptCsReq>, IBufferMessage
{
	private static readonly MessageParser<HeartDialTraceScriptCsReq> _parser = new MessageParser<HeartDialTraceScriptCsReq>(() => new HeartDialTraceScriptCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GAIPLPHEFFKFieldNumber = 10;

	private PICILIIFKBE gAIPLPHEFFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeartDialTraceScriptCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeartDialTraceScriptCsReqReflection.Descriptor.MessageTypes[0];

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
	public HeartDialTraceScriptCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialTraceScriptCsReq(HeartDialTraceScriptCsReq other)
		: this()
	{
		gAIPLPHEFFK_ = ((other.gAIPLPHEFFK_ != null) ? other.gAIPLPHEFFK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialTraceScriptCsReq Clone()
	{
		return new HeartDialTraceScriptCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeartDialTraceScriptCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeartDialTraceScriptCsReq other)
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
			output.WriteRawTag(82);
			output.WriteMessage(GAIPLPHEFFK);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeartDialTraceScriptCsReq other)
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (gAIPLPHEFFK_ == null)
			{
				GAIPLPHEFFK = new PICILIIFKBE();
			}
			input.ReadMessage(GAIPLPHEFFK);
		}
	}
}
