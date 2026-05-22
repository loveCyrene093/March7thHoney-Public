using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AiPamResponseFeedbackCsReq : IMessage<AiPamResponseFeedbackCsReq>, IMessage, IEquatable<AiPamResponseFeedbackCsReq>, IDeepCloneable<AiPamResponseFeedbackCsReq>, IBufferMessage
{
	private static readonly MessageParser<AiPamResponseFeedbackCsReq> _parser = new MessageParser<AiPamResponseFeedbackCsReq>(() => new AiPamResponseFeedbackCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DHEKDAGJBJBFieldNumber = 4;

	private bool dHEKDAGJBJB_;

	public const int FFGICGLDLKEFieldNumber = 6;

	private bool fFGICGLDLKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AiPamResponseFeedbackCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AiPamResponseFeedbackCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DHEKDAGJBJB
	{
		get
		{
			return dHEKDAGJBJB_;
		}
		set
		{
			dHEKDAGJBJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FFGICGLDLKE
	{
		get
		{
			return fFGICGLDLKE_;
		}
		set
		{
			fFGICGLDLKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamResponseFeedbackCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamResponseFeedbackCsReq(AiPamResponseFeedbackCsReq other)
		: this()
	{
		dHEKDAGJBJB_ = other.dHEKDAGJBJB_;
		fFGICGLDLKE_ = other.fFGICGLDLKE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamResponseFeedbackCsReq Clone()
	{
		return new AiPamResponseFeedbackCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AiPamResponseFeedbackCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AiPamResponseFeedbackCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DHEKDAGJBJB != other.DHEKDAGJBJB)
		{
			return false;
		}
		if (FFGICGLDLKE != other.FFGICGLDLKE)
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
		if (DHEKDAGJBJB)
		{
			num ^= DHEKDAGJBJB.GetHashCode();
		}
		if (FFGICGLDLKE)
		{
			num ^= FFGICGLDLKE.GetHashCode();
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
		if (DHEKDAGJBJB)
		{
			output.WriteRawTag(32);
			output.WriteBool(DHEKDAGJBJB);
		}
		if (FFGICGLDLKE)
		{
			output.WriteRawTag(48);
			output.WriteBool(FFGICGLDLKE);
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
		if (DHEKDAGJBJB)
		{
			num += 2;
		}
		if (FFGICGLDLKE)
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
	public void MergeFrom(AiPamResponseFeedbackCsReq other)
	{
		if (other != null)
		{
			if (other.DHEKDAGJBJB)
			{
				DHEKDAGJBJB = other.DHEKDAGJBJB;
			}
			if (other.FFGICGLDLKE)
			{
				FFGICGLDLKE = other.FFGICGLDLKE;
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
			case 32u:
				DHEKDAGJBJB = input.ReadBool();
				break;
			case 48u:
				FFGICGLDLKE = input.ReadBool();
				break;
			}
		}
	}
}
