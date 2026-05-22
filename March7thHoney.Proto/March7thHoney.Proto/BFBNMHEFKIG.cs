using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BFBNMHEFKIG : IMessage<BFBNMHEFKIG>, IMessage, IEquatable<BFBNMHEFKIG>, IDeepCloneable<BFBNMHEFKIG>, IBufferMessage
{
	private static readonly MessageParser<BFBNMHEFKIG> _parser = new MessageParser<BFBNMHEFKIG>(() => new BFBNMHEFKIG());

	private UnknownFieldSet _unknownFields;

	public const int CGDLGFHOECLFieldNumber = 11;

	private uint cGDLGFHOECL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BFBNMHEFKIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BFBNMHEFKIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGDLGFHOECL
	{
		get
		{
			return cGDLGFHOECL_;
		}
		set
		{
			cGDLGFHOECL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFBNMHEFKIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFBNMHEFKIG(BFBNMHEFKIG other)
		: this()
	{
		cGDLGFHOECL_ = other.cGDLGFHOECL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFBNMHEFKIG Clone()
	{
		return new BFBNMHEFKIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BFBNMHEFKIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BFBNMHEFKIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CGDLGFHOECL != other.CGDLGFHOECL)
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
		if (CGDLGFHOECL != 0)
		{
			num ^= CGDLGFHOECL.GetHashCode();
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
		if (CGDLGFHOECL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CGDLGFHOECL);
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
		if (CGDLGFHOECL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGDLGFHOECL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BFBNMHEFKIG other)
	{
		if (other != null)
		{
			if (other.CGDLGFHOECL != 0)
			{
				CGDLGFHOECL = other.CGDLGFHOECL;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CGDLGFHOECL = input.ReadUInt32();
			}
		}
	}
}
