using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AIOPPHPGNLM : IMessage<AIOPPHPGNLM>, IMessage, IEquatable<AIOPPHPGNLM>, IDeepCloneable<AIOPPHPGNLM>, IBufferMessage
{
	private static readonly MessageParser<AIOPPHPGNLM> _parser = new MessageParser<AIOPPHPGNLM>(() => new AIOPPHPGNLM());

	private UnknownFieldSet _unknownFields;

	public const int ELLELJFGDPHFieldNumber = 1;

	private PLIGIAFNLCB eLLELJFGDPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AIOPPHPGNLM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AIOPPHPGNLMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLIGIAFNLCB ELLELJFGDPH
	{
		get
		{
			return eLLELJFGDPH_;
		}
		set
		{
			eLLELJFGDPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIOPPHPGNLM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIOPPHPGNLM(AIOPPHPGNLM other)
		: this()
	{
		eLLELJFGDPH_ = other.eLLELJFGDPH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIOPPHPGNLM Clone()
	{
		return new AIOPPHPGNLM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AIOPPHPGNLM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AIOPPHPGNLM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ELLELJFGDPH != other.ELLELJFGDPH)
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
		if (ELLELJFGDPH != PLIGIAFNLCB.Pcpdhelpkem)
		{
			num ^= ELLELJFGDPH.GetHashCode();
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
		if (ELLELJFGDPH != PLIGIAFNLCB.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ELLELJFGDPH);
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
		if (ELLELJFGDPH != PLIGIAFNLCB.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ELLELJFGDPH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AIOPPHPGNLM other)
	{
		if (other != null)
		{
			if (other.ELLELJFGDPH != PLIGIAFNLCB.Pcpdhelpkem)
			{
				ELLELJFGDPH = other.ELLELJFGDPH;
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
				ELLELJFGDPH = (PLIGIAFNLCB)input.ReadEnum();
			}
		}
	}
}
