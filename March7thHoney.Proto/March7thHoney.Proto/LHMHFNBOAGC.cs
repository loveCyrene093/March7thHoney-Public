using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHMHFNBOAGC : IMessage<LHMHFNBOAGC>, IMessage, IEquatable<LHMHFNBOAGC>, IDeepCloneable<LHMHFNBOAGC>, IBufferMessage
{
	private static readonly MessageParser<LHMHFNBOAGC> _parser = new MessageParser<LHMHFNBOAGC>(() => new LHMHFNBOAGC());

	private UnknownFieldSet _unknownFields;

	public const int EJMJHDACFEIFieldNumber = 2;

	private uint eJMJHDACFEI_;

	public const int KLLPOAKDDHPFieldNumber = 10;

	private uint kLLPOAKDDHP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHMHFNBOAGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHMHFNBOAGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJMJHDACFEI
	{
		get
		{
			return eJMJHDACFEI_;
		}
		set
		{
			eJMJHDACFEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLLPOAKDDHP
	{
		get
		{
			return kLLPOAKDDHP_;
		}
		set
		{
			kLLPOAKDDHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHMHFNBOAGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHMHFNBOAGC(LHMHFNBOAGC other)
		: this()
	{
		eJMJHDACFEI_ = other.eJMJHDACFEI_;
		kLLPOAKDDHP_ = other.kLLPOAKDDHP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHMHFNBOAGC Clone()
	{
		return new LHMHFNBOAGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHMHFNBOAGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHMHFNBOAGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EJMJHDACFEI != other.EJMJHDACFEI)
		{
			return false;
		}
		if (KLLPOAKDDHP != other.KLLPOAKDDHP)
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
		if (EJMJHDACFEI != 0)
		{
			num ^= EJMJHDACFEI.GetHashCode();
		}
		if (KLLPOAKDDHP != 0)
		{
			num ^= KLLPOAKDDHP.GetHashCode();
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
		if (EJMJHDACFEI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EJMJHDACFEI);
		}
		if (KLLPOAKDDHP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KLLPOAKDDHP);
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
		if (EJMJHDACFEI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJMJHDACFEI);
		}
		if (KLLPOAKDDHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLLPOAKDDHP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHMHFNBOAGC other)
	{
		if (other != null)
		{
			if (other.EJMJHDACFEI != 0)
			{
				EJMJHDACFEI = other.EJMJHDACFEI;
			}
			if (other.KLLPOAKDDHP != 0)
			{
				KLLPOAKDDHP = other.KLLPOAKDDHP;
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
			case 16u:
				EJMJHDACFEI = input.ReadUInt32();
				break;
			case 80u:
				KLLPOAKDDHP = input.ReadUInt32();
				break;
			}
		}
	}
}
