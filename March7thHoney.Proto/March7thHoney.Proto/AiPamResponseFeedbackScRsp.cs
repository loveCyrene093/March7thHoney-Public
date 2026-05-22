using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AiPamResponseFeedbackScRsp : IMessage<AiPamResponseFeedbackScRsp>, IMessage, IEquatable<AiPamResponseFeedbackScRsp>, IDeepCloneable<AiPamResponseFeedbackScRsp>, IBufferMessage
{
	private static readonly MessageParser<AiPamResponseFeedbackScRsp> _parser = new MessageParser<AiPamResponseFeedbackScRsp>(() => new AiPamResponseFeedbackScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FFGICGLDLKEFieldNumber = 3;

	private bool fFGICGLDLKE_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int DHEKDAGJBJBFieldNumber = 13;

	private bool dHEKDAGJBJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AiPamResponseFeedbackScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AiPamResponseFeedbackScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public AiPamResponseFeedbackScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamResponseFeedbackScRsp(AiPamResponseFeedbackScRsp other)
		: this()
	{
		fFGICGLDLKE_ = other.fFGICGLDLKE_;
		retcode_ = other.retcode_;
		dHEKDAGJBJB_ = other.dHEKDAGJBJB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamResponseFeedbackScRsp Clone()
	{
		return new AiPamResponseFeedbackScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AiPamResponseFeedbackScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AiPamResponseFeedbackScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FFGICGLDLKE != other.FFGICGLDLKE)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (DHEKDAGJBJB != other.DHEKDAGJBJB)
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
		if (FFGICGLDLKE)
		{
			num ^= FFGICGLDLKE.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (DHEKDAGJBJB)
		{
			num ^= DHEKDAGJBJB.GetHashCode();
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
		if (FFGICGLDLKE)
		{
			output.WriteRawTag(24);
			output.WriteBool(FFGICGLDLKE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (DHEKDAGJBJB)
		{
			output.WriteRawTag(104);
			output.WriteBool(DHEKDAGJBJB);
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
		if (FFGICGLDLKE)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (DHEKDAGJBJB)
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
	public void MergeFrom(AiPamResponseFeedbackScRsp other)
	{
		if (other != null)
		{
			if (other.FFGICGLDLKE)
			{
				FFGICGLDLKE = other.FFGICGLDLKE;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.DHEKDAGJBJB)
			{
				DHEKDAGJBJB = other.DHEKDAGJBJB;
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
			case 24u:
				FFGICGLDLKE = input.ReadBool();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				DHEKDAGJBJB = input.ReadBool();
				break;
			}
		}
	}
}
