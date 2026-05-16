using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HIBLMDNPOMN : IMessage<HIBLMDNPOMN>, IMessage, IEquatable<HIBLMDNPOMN>, IDeepCloneable<HIBLMDNPOMN>, IBufferMessage
{
	private static readonly MessageParser<HIBLMDNPOMN> _parser = new MessageParser<HIBLMDNPOMN>(() => new HIBLMDNPOMN());

	private UnknownFieldSet _unknownFields;

	public const int AFPKJLBLPLGFieldNumber = 4;

	private uint aFPKJLBLPLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HIBLMDNPOMN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HIBLMDNPOMNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFPKJLBLPLG
	{
		get
		{
			return aFPKJLBLPLG_;
		}
		set
		{
			aFPKJLBLPLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBLMDNPOMN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBLMDNPOMN(HIBLMDNPOMN other)
		: this()
	{
		aFPKJLBLPLG_ = other.aFPKJLBLPLG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBLMDNPOMN Clone()
	{
		return new HIBLMDNPOMN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HIBLMDNPOMN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HIBLMDNPOMN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AFPKJLBLPLG != other.AFPKJLBLPLG)
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
		if (AFPKJLBLPLG != 0)
		{
			num ^= AFPKJLBLPLG.GetHashCode();
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
		if (AFPKJLBLPLG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AFPKJLBLPLG);
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
		if (AFPKJLBLPLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFPKJLBLPLG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HIBLMDNPOMN other)
	{
		if (other != null)
		{
			if (other.AFPKJLBLPLG != 0)
			{
				AFPKJLBLPLG = other.AFPKJLBLPLG;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				AFPKJLBLPLG = input.ReadUInt32();
			}
		}
	}
}
