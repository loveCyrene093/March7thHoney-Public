using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HJOHLMHFHIE : IMessage<HJOHLMHFHIE>, IMessage, IEquatable<HJOHLMHFHIE>, IDeepCloneable<HJOHLMHFHIE>, IBufferMessage
{
	private static readonly MessageParser<HJOHLMHFHIE> _parser = new MessageParser<HJOHLMHFHIE>(() => new HJOHLMHFHIE());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int KHDLMPAKEGFFieldNumber = 13;

	private uint kHDLMPAKEGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HJOHLMHFHIE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HJOHLMHFHIEReflection.Descriptor.MessageTypes[0];

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
	public HJOHLMHFHIE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJOHLMHFHIE(HJOHLMHFHIE other)
		: this()
	{
		retcode_ = other.retcode_;
		kHDLMPAKEGF_ = other.kHDLMPAKEGF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJOHLMHFHIE Clone()
	{
		return new HJOHLMHFHIE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HJOHLMHFHIE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HJOHLMHFHIE other)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
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
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (KHDLMPAKEGF != 0)
		{
			output.WriteRawTag(104);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
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
	public void MergeFrom(HJOHLMHFHIE other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				KHDLMPAKEGF = input.ReadUInt32();
				break;
			}
		}
	}
}
