using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class POGBFKHOEML : IMessage<POGBFKHOEML>, IMessage, IEquatable<POGBFKHOEML>, IDeepCloneable<POGBFKHOEML>, IBufferMessage
{
	private static readonly MessageParser<POGBFKHOEML> _parser = new MessageParser<POGBFKHOEML>(() => new POGBFKHOEML());

	private UnknownFieldSet _unknownFields;

	public const int BJJOCLINMEJFieldNumber = 13;

	private uint bJJOCLINMEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<POGBFKHOEML> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => POGBFKHOEMLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BJJOCLINMEJ
	{
		get
		{
			return bJJOCLINMEJ_;
		}
		set
		{
			bJJOCLINMEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POGBFKHOEML()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POGBFKHOEML(POGBFKHOEML other)
		: this()
	{
		bJJOCLINMEJ_ = other.bJJOCLINMEJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POGBFKHOEML Clone()
	{
		return new POGBFKHOEML(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as POGBFKHOEML);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(POGBFKHOEML other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BJJOCLINMEJ != other.BJJOCLINMEJ)
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
		if (BJJOCLINMEJ != 0)
		{
			num ^= BJJOCLINMEJ.GetHashCode();
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
		if (BJJOCLINMEJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BJJOCLINMEJ);
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
		if (BJJOCLINMEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BJJOCLINMEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(POGBFKHOEML other)
	{
		if (other != null)
		{
			if (other.BJJOCLINMEJ != 0)
			{
				BJJOCLINMEJ = other.BJJOCLINMEJ;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BJJOCLINMEJ = input.ReadUInt32();
			}
		}
	}
}
