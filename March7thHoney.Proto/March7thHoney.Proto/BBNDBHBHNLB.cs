using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBNDBHBHNLB : IMessage<BBNDBHBHNLB>, IMessage, IEquatable<BBNDBHBHNLB>, IDeepCloneable<BBNDBHBHNLB>, IBufferMessage
{
	private static readonly MessageParser<BBNDBHBHNLB> _parser = new MessageParser<BBNDBHBHNLB>(() => new BBNDBHBHNLB());

	private UnknownFieldSet _unknownFields;

	public const int LLKOFNDAKHGFieldNumber = 11;

	private uint lLKOFNDAKHG_;

	public const int GIJHJCDLPJFFieldNumber = 15;

	private uint gIJHJCDLPJF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBNDBHBHNLB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBNDBHBHNLBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLKOFNDAKHG
	{
		get
		{
			return lLKOFNDAKHG_;
		}
		set
		{
			lLKOFNDAKHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIJHJCDLPJF
	{
		get
		{
			return gIJHJCDLPJF_;
		}
		set
		{
			gIJHJCDLPJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBNDBHBHNLB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBNDBHBHNLB(BBNDBHBHNLB other)
		: this()
	{
		lLKOFNDAKHG_ = other.lLKOFNDAKHG_;
		gIJHJCDLPJF_ = other.gIJHJCDLPJF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBNDBHBHNLB Clone()
	{
		return new BBNDBHBHNLB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBNDBHBHNLB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBNDBHBHNLB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LLKOFNDAKHG != other.LLKOFNDAKHG)
		{
			return false;
		}
		if (GIJHJCDLPJF != other.GIJHJCDLPJF)
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
		if (LLKOFNDAKHG != 0)
		{
			num ^= LLKOFNDAKHG.GetHashCode();
		}
		if (GIJHJCDLPJF != 0)
		{
			num ^= GIJHJCDLPJF.GetHashCode();
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
		if (LLKOFNDAKHG != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LLKOFNDAKHG);
		}
		if (GIJHJCDLPJF != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GIJHJCDLPJF);
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
		if (LLKOFNDAKHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLKOFNDAKHG);
		}
		if (GIJHJCDLPJF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIJHJCDLPJF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBNDBHBHNLB other)
	{
		if (other != null)
		{
			if (other.LLKOFNDAKHG != 0)
			{
				LLKOFNDAKHG = other.LLKOFNDAKHG;
			}
			if (other.GIJHJCDLPJF != 0)
			{
				GIJHJCDLPJF = other.GIJHJCDLPJF;
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
			case 88u:
				LLKOFNDAKHG = input.ReadUInt32();
				break;
			case 120u:
				GIJHJCDLPJF = input.ReadUInt32();
				break;
			}
		}
	}
}
