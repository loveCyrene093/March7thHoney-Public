using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EMCICPOHAAL : IMessage<EMCICPOHAAL>, IMessage, IEquatable<EMCICPOHAAL>, IDeepCloneable<EMCICPOHAAL>, IBufferMessage
{
	private static readonly MessageParser<EMCICPOHAAL> _parser = new MessageParser<EMCICPOHAAL>(() => new EMCICPOHAAL());

	private UnknownFieldSet _unknownFields;

	public const int HPMHACBNOOKFieldNumber = 4;

	private int hPMHACBNOOK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EMCICPOHAAL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EMCICPOHAALReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HPMHACBNOOK
	{
		get
		{
			return hPMHACBNOOK_;
		}
		set
		{
			hPMHACBNOOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMCICPOHAAL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMCICPOHAAL(EMCICPOHAAL other)
		: this()
	{
		hPMHACBNOOK_ = other.hPMHACBNOOK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMCICPOHAAL Clone()
	{
		return new EMCICPOHAAL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EMCICPOHAAL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EMCICPOHAAL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HPMHACBNOOK != other.HPMHACBNOOK)
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
		if (HPMHACBNOOK != 0)
		{
			num ^= HPMHACBNOOK.GetHashCode();
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
		if (HPMHACBNOOK != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(HPMHACBNOOK);
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
		if (HPMHACBNOOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HPMHACBNOOK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EMCICPOHAAL other)
	{
		if (other != null)
		{
			if (other.HPMHACBNOOK != 0)
			{
				HPMHACBNOOK = other.HPMHACBNOOK;
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
				HPMHACBNOOK = input.ReadInt32();
			}
		}
	}
}
