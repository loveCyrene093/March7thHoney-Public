using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHJCFNLPFIL : IMessage<LHJCFNLPFIL>, IMessage, IEquatable<LHJCFNLPFIL>, IDeepCloneable<LHJCFNLPFIL>, IBufferMessage
{
	private static readonly MessageParser<LHJCFNLPFIL> _parser = new MessageParser<LHJCFNLPFIL>(() => new LHJCFNLPFIL());

	private UnknownFieldSet _unknownFields;

	public const int CPKIAMDIJNGFieldNumber = 1;

	private uint cPKIAMDIJNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHJCFNLPFIL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHJCFNLPFILReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CPKIAMDIJNG
	{
		get
		{
			return cPKIAMDIJNG_;
		}
		set
		{
			cPKIAMDIJNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHJCFNLPFIL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHJCFNLPFIL(LHJCFNLPFIL other)
		: this()
	{
		cPKIAMDIJNG_ = other.cPKIAMDIJNG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHJCFNLPFIL Clone()
	{
		return new LHJCFNLPFIL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHJCFNLPFIL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHJCFNLPFIL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CPKIAMDIJNG != other.CPKIAMDIJNG)
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
		if (CPKIAMDIJNG != 0)
		{
			num ^= CPKIAMDIJNG.GetHashCode();
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
		if (CPKIAMDIJNG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CPKIAMDIJNG);
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
		if (CPKIAMDIJNG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CPKIAMDIJNG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHJCFNLPFIL other)
	{
		if (other != null)
		{
			if (other.CPKIAMDIJNG != 0)
			{
				CPKIAMDIJNG = other.CPKIAMDIJNG;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CPKIAMDIJNG = input.ReadUInt32();
			}
		}
	}
}
