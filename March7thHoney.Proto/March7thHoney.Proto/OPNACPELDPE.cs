using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OPNACPELDPE : IMessage<OPNACPELDPE>, IMessage, IEquatable<OPNACPELDPE>, IDeepCloneable<OPNACPELDPE>, IBufferMessage
{
	private static readonly MessageParser<OPNACPELDPE> _parser = new MessageParser<OPNACPELDPE>(() => new OPNACPELDPE());

	private UnknownFieldSet _unknownFields;

	public const int PHDLMLHKIHHFieldNumber = 14;

	private uint pHDLMLHKIHH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OPNACPELDPE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OPNACPELDPEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHDLMLHKIHH
	{
		get
		{
			return pHDLMLHKIHH_;
		}
		set
		{
			pHDLMLHKIHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPNACPELDPE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPNACPELDPE(OPNACPELDPE other)
		: this()
	{
		pHDLMLHKIHH_ = other.pHDLMLHKIHH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPNACPELDPE Clone()
	{
		return new OPNACPELDPE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OPNACPELDPE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OPNACPELDPE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHDLMLHKIHH != other.PHDLMLHKIHH)
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
		if (PHDLMLHKIHH != 0)
		{
			num ^= PHDLMLHKIHH.GetHashCode();
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
		if (PHDLMLHKIHH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PHDLMLHKIHH);
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
		if (PHDLMLHKIHH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHDLMLHKIHH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OPNACPELDPE other)
	{
		if (other != null)
		{
			if (other.PHDLMLHKIHH != 0)
			{
				PHDLMLHKIHH = other.PHDLMLHKIHH;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PHDLMLHKIHH = input.ReadUInt32();
			}
		}
	}
}
