using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JBJAKAMMKMD : IMessage<JBJAKAMMKMD>, IMessage, IEquatable<JBJAKAMMKMD>, IDeepCloneable<JBJAKAMMKMD>, IBufferMessage
{
	private static readonly MessageParser<JBJAKAMMKMD> _parser = new MessageParser<JBJAKAMMKMD>(() => new JBJAKAMMKMD());

	private UnknownFieldSet _unknownFields;

	public const int AOBNMCIENFNFieldNumber = 1;

	private NGPKKAMADNA aOBNMCIENFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JBJAKAMMKMD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JBJAKAMMKMDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGPKKAMADNA AOBNMCIENFN
	{
		get
		{
			return aOBNMCIENFN_;
		}
		set
		{
			aOBNMCIENFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBJAKAMMKMD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBJAKAMMKMD(JBJAKAMMKMD other)
		: this()
	{
		aOBNMCIENFN_ = ((other.aOBNMCIENFN_ != null) ? other.aOBNMCIENFN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBJAKAMMKMD Clone()
	{
		return new JBJAKAMMKMD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JBJAKAMMKMD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JBJAKAMMKMD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AOBNMCIENFN, other.AOBNMCIENFN))
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
		if (aOBNMCIENFN_ != null)
		{
			num ^= AOBNMCIENFN.GetHashCode();
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
		if (aOBNMCIENFN_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(AOBNMCIENFN);
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
		if (aOBNMCIENFN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AOBNMCIENFN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JBJAKAMMKMD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aOBNMCIENFN_ != null)
		{
			if (aOBNMCIENFN_ == null)
			{
				AOBNMCIENFN = new NGPKKAMADNA();
			}
			AOBNMCIENFN.MergeFrom(other.AOBNMCIENFN);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (aOBNMCIENFN_ == null)
			{
				AOBNMCIENFN = new NGPKKAMADNA();
			}
			input.ReadMessage(AOBNMCIENFN);
		}
	}
}
