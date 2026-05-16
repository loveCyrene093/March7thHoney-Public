using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAssistListCsReq : IMessage<GetAssistListCsReq>, IMessage, IEquatable<GetAssistListCsReq>, IDeepCloneable<GetAssistListCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetAssistListCsReq> _parser = new MessageParser<GetAssistListCsReq>(() => new GetAssistListCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KJJNOKFKMCPFieldNumber = 10;

	private bool kJJNOKFKMCP_;

	public const int ICHENOJECAPFieldNumber = 12;

	private bool iCHENOJECAP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAssistListCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAssistListCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KJJNOKFKMCP
	{
		get
		{
			return kJJNOKFKMCP_;
		}
		set
		{
			kJJNOKFKMCP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICHENOJECAP
	{
		get
		{
			return iCHENOJECAP_;
		}
		set
		{
			iCHENOJECAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistListCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistListCsReq(GetAssistListCsReq other)
		: this()
	{
		kJJNOKFKMCP_ = other.kJJNOKFKMCP_;
		iCHENOJECAP_ = other.iCHENOJECAP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistListCsReq Clone()
	{
		return new GetAssistListCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAssistListCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAssistListCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KJJNOKFKMCP != other.KJJNOKFKMCP)
		{
			return false;
		}
		if (ICHENOJECAP != other.ICHENOJECAP)
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
		if (KJJNOKFKMCP)
		{
			num ^= KJJNOKFKMCP.GetHashCode();
		}
		if (ICHENOJECAP)
		{
			num ^= ICHENOJECAP.GetHashCode();
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
		if (KJJNOKFKMCP)
		{
			output.WriteRawTag(80);
			output.WriteBool(KJJNOKFKMCP);
		}
		if (ICHENOJECAP)
		{
			output.WriteRawTag(96);
			output.WriteBool(ICHENOJECAP);
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
		if (KJJNOKFKMCP)
		{
			num += 2;
		}
		if (ICHENOJECAP)
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
	public void MergeFrom(GetAssistListCsReq other)
	{
		if (other != null)
		{
			if (other.KJJNOKFKMCP)
			{
				KJJNOKFKMCP = other.KJJNOKFKMCP;
			}
			if (other.ICHENOJECAP)
			{
				ICHENOJECAP = other.ICHENOJECAP;
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
			case 80u:
				KJJNOKFKMCP = input.ReadBool();
				break;
			case 96u:
				ICHENOJECAP = input.ReadBool();
				break;
			}
		}
	}
}
