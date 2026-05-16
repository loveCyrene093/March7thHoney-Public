using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IHEACEDGADM : IMessage<IHEACEDGADM>, IMessage, IEquatable<IHEACEDGADM>, IDeepCloneable<IHEACEDGADM>, IBufferMessage
{
	private static readonly MessageParser<IHEACEDGADM> _parser = new MessageParser<IHEACEDGADM>(() => new IHEACEDGADM());

	private UnknownFieldSet _unknownFields;

	public const int AFNMOJOAFMNFieldNumber = 1;

	private NODNMNCIBFG aFNMOJOAFMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IHEACEDGADM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IHEACEDGADMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NODNMNCIBFG AFNMOJOAFMN
	{
		get
		{
			return aFNMOJOAFMN_;
		}
		set
		{
			aFNMOJOAFMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHEACEDGADM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHEACEDGADM(IHEACEDGADM other)
		: this()
	{
		aFNMOJOAFMN_ = other.aFNMOJOAFMN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHEACEDGADM Clone()
	{
		return new IHEACEDGADM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IHEACEDGADM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IHEACEDGADM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AFNMOJOAFMN != other.AFNMOJOAFMN)
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
		if (AFNMOJOAFMN != NODNMNCIBFG.Pcpdhelpkem)
		{
			num ^= AFNMOJOAFMN.GetHashCode();
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
		if (AFNMOJOAFMN != NODNMNCIBFG.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)AFNMOJOAFMN);
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
		if (AFNMOJOAFMN != NODNMNCIBFG.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AFNMOJOAFMN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IHEACEDGADM other)
	{
		if (other != null)
		{
			if (other.AFNMOJOAFMN != NODNMNCIBFG.Pcpdhelpkem)
			{
				AFNMOJOAFMN = other.AFNMOJOAFMN;
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
				AFNMOJOAFMN = (NODNMNCIBFG)input.ReadEnum();
			}
		}
	}
}
