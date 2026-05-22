using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BABKEAFELGE : IMessage<BABKEAFELGE>, IMessage, IEquatable<BABKEAFELGE>, IDeepCloneable<BABKEAFELGE>, IBufferMessage
{
	private static readonly MessageParser<BABKEAFELGE> _parser = new MessageParser<BABKEAFELGE>(() => new BABKEAFELGE());

	private UnknownFieldSet _unknownFields;

	public const int FEILNIKNPCBFieldNumber = 5;

	private AKGOAIPLJLJ fEILNIKNPCB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BABKEAFELGE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BABKEAFELGEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGOAIPLJLJ FEILNIKNPCB
	{
		get
		{
			return fEILNIKNPCB_;
		}
		set
		{
			fEILNIKNPCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABKEAFELGE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABKEAFELGE(BABKEAFELGE other)
		: this()
	{
		fEILNIKNPCB_ = ((other.fEILNIKNPCB_ != null) ? other.fEILNIKNPCB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABKEAFELGE Clone()
	{
		return new BABKEAFELGE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BABKEAFELGE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BABKEAFELGE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
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
		if (fEILNIKNPCB_ != null)
		{
			num ^= FEILNIKNPCB.GetHashCode();
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
		if (fEILNIKNPCB_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(FEILNIKNPCB);
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
		if (fEILNIKNPCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BABKEAFELGE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fEILNIKNPCB_ != null)
		{
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new AKGOAIPLJLJ();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new AKGOAIPLJLJ();
			}
			input.ReadMessage(FEILNIKNPCB);
		}
	}
}
