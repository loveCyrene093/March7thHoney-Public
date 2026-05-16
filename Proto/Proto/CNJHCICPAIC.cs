using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNJHCICPAIC : IMessage<CNJHCICPAIC>, IMessage, IEquatable<CNJHCICPAIC>, IDeepCloneable<CNJHCICPAIC>, IBufferMessage
{
	private static readonly MessageParser<CNJHCICPAIC> _parser = new MessageParser<CNJHCICPAIC>(() => new CNJHCICPAIC());

	private UnknownFieldSet _unknownFields;

	public const int OFOODOBJKBJFieldNumber = 4;

	private CADKBOKEJMD oFOODOBJKBJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNJHCICPAIC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNJHCICPAICReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CADKBOKEJMD OFOODOBJKBJ
	{
		get
		{
			return oFOODOBJKBJ_;
		}
		set
		{
			oFOODOBJKBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNJHCICPAIC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNJHCICPAIC(CNJHCICPAIC other)
		: this()
	{
		oFOODOBJKBJ_ = ((other.oFOODOBJKBJ_ != null) ? other.oFOODOBJKBJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNJHCICPAIC Clone()
	{
		return new CNJHCICPAIC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNJHCICPAIC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNJHCICPAIC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OFOODOBJKBJ, other.OFOODOBJKBJ))
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
		if (oFOODOBJKBJ_ != null)
		{
			num ^= OFOODOBJKBJ.GetHashCode();
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
		if (oFOODOBJKBJ_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OFOODOBJKBJ);
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
		if (oFOODOBJKBJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFOODOBJKBJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNJHCICPAIC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oFOODOBJKBJ_ != null)
		{
			if (oFOODOBJKBJ_ == null)
			{
				OFOODOBJKBJ = new CADKBOKEJMD();
			}
			OFOODOBJKBJ.MergeFrom(other.OFOODOBJKBJ);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oFOODOBJKBJ_ == null)
			{
				OFOODOBJKBJ = new CADKBOKEJMD();
			}
			input.ReadMessage(OFOODOBJKBJ);
		}
	}
}
