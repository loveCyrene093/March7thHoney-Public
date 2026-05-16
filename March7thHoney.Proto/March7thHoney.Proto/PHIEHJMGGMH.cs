using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PHIEHJMGGMH : IMessage<PHIEHJMGGMH>, IMessage, IEquatable<PHIEHJMGGMH>, IDeepCloneable<PHIEHJMGGMH>, IBufferMessage
{
	private static readonly MessageParser<PHIEHJMGGMH> _parser = new MessageParser<PHIEHJMGGMH>(() => new PHIEHJMGGMH());

	private UnknownFieldSet _unknownFields;

	public const int CFADFLLLOPCFieldNumber = 4;

	private DKFAEKPKADH cFADFLLLOPC_;

	public const int IPLMEFLAGDAFieldNumber = 7;

	private uint iPLMEFLAGDA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PHIEHJMGGMH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PHIEHJMGGMHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKFAEKPKADH CFADFLLLOPC
	{
		get
		{
			return cFADFLLLOPC_;
		}
		set
		{
			cFADFLLLOPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPLMEFLAGDA
	{
		get
		{
			return iPLMEFLAGDA_;
		}
		set
		{
			iPLMEFLAGDA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHIEHJMGGMH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHIEHJMGGMH(PHIEHJMGGMH other)
		: this()
	{
		cFADFLLLOPC_ = ((other.cFADFLLLOPC_ != null) ? other.cFADFLLLOPC_.Clone() : null);
		iPLMEFLAGDA_ = other.iPLMEFLAGDA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHIEHJMGGMH Clone()
	{
		return new PHIEHJMGGMH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PHIEHJMGGMH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PHIEHJMGGMH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CFADFLLLOPC, other.CFADFLLLOPC))
		{
			return false;
		}
		if (IPLMEFLAGDA != other.IPLMEFLAGDA)
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
		if (cFADFLLLOPC_ != null)
		{
			num ^= CFADFLLLOPC.GetHashCode();
		}
		if (IPLMEFLAGDA != 0)
		{
			num ^= IPLMEFLAGDA.GetHashCode();
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
		if (cFADFLLLOPC_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CFADFLLLOPC);
		}
		if (IPLMEFLAGDA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IPLMEFLAGDA);
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
		if (cFADFLLLOPC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CFADFLLLOPC);
		}
		if (IPLMEFLAGDA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPLMEFLAGDA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PHIEHJMGGMH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cFADFLLLOPC_ != null)
		{
			if (cFADFLLLOPC_ == null)
			{
				CFADFLLLOPC = new DKFAEKPKADH();
			}
			CFADFLLLOPC.MergeFrom(other.CFADFLLLOPC);
		}
		if (other.IPLMEFLAGDA != 0)
		{
			IPLMEFLAGDA = other.IPLMEFLAGDA;
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
				if (cFADFLLLOPC_ == null)
				{
					CFADFLLLOPC = new DKFAEKPKADH();
				}
				input.ReadMessage(CFADFLLLOPC);
				break;
			case 56u:
				IPLMEFLAGDA = input.ReadUInt32();
				break;
			}
		}
	}
}
