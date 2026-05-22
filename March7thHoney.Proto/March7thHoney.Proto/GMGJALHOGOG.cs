using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GMGJALHOGOG : IMessage<GMGJALHOGOG>, IMessage, IEquatable<GMGJALHOGOG>, IDeepCloneable<GMGJALHOGOG>, IBufferMessage
{
	private static readonly MessageParser<GMGJALHOGOG> _parser = new MessageParser<GMGJALHOGOG>(() => new GMGJALHOGOG());

	private UnknownFieldSet _unknownFields;

	public const int FOOLMIADMMHFieldNumber = 6;

	private uint fOOLMIADMMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GMGJALHOGOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GMGJALHOGOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOOLMIADMMH
	{
		get
		{
			return fOOLMIADMMH_;
		}
		set
		{
			fOOLMIADMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMGJALHOGOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMGJALHOGOG(GMGJALHOGOG other)
		: this()
	{
		fOOLMIADMMH_ = other.fOOLMIADMMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMGJALHOGOG Clone()
	{
		return new GMGJALHOGOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GMGJALHOGOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GMGJALHOGOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FOOLMIADMMH != other.FOOLMIADMMH)
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
		if (FOOLMIADMMH != 0)
		{
			num ^= FOOLMIADMMH.GetHashCode();
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
		if (FOOLMIADMMH != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(FOOLMIADMMH);
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
		if (FOOLMIADMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOOLMIADMMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GMGJALHOGOG other)
	{
		if (other != null)
		{
			if (other.FOOLMIADMMH != 0)
			{
				FOOLMIADMMH = other.FOOLMIADMMH;
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
			if (num != 48)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FOOLMIADMMH = input.ReadUInt32();
			}
		}
	}
}
