using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LFKEDPPLOKL : IMessage<LFKEDPPLOKL>, IMessage, IEquatable<LFKEDPPLOKL>, IDeepCloneable<LFKEDPPLOKL>, IBufferMessage
{
	private static readonly MessageParser<LFKEDPPLOKL> _parser = new MessageParser<LFKEDPPLOKL>(() => new LFKEDPPLOKL());

	private UnknownFieldSet _unknownFields;

	public const int KHDLMPAKEGFFieldNumber = 11;

	private uint kHDLMPAKEGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LFKEDPPLOKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LFKEDPPLOKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHDLMPAKEGF
	{
		get
		{
			return kHDLMPAKEGF_;
		}
		set
		{
			kHDLMPAKEGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFKEDPPLOKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFKEDPPLOKL(LFKEDPPLOKL other)
		: this()
	{
		kHDLMPAKEGF_ = other.kHDLMPAKEGF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFKEDPPLOKL Clone()
	{
		return new LFKEDPPLOKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LFKEDPPLOKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LFKEDPPLOKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHDLMPAKEGF != other.KHDLMPAKEGF)
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
		if (KHDLMPAKEGF != 0)
		{
			num ^= KHDLMPAKEGF.GetHashCode();
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
		if (KHDLMPAKEGF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KHDLMPAKEGF);
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
		if (KHDLMPAKEGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHDLMPAKEGF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LFKEDPPLOKL other)
	{
		if (other != null)
		{
			if (other.KHDLMPAKEGF != 0)
			{
				KHDLMPAKEGF = other.KHDLMPAKEGF;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KHDLMPAKEGF = input.ReadUInt32();
			}
		}
	}
}
