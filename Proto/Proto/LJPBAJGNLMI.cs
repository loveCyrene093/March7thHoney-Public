using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LJPBAJGNLMI : IMessage<LJPBAJGNLMI>, IMessage, IEquatable<LJPBAJGNLMI>, IDeepCloneable<LJPBAJGNLMI>, IBufferMessage
{
	private static readonly MessageParser<LJPBAJGNLMI> _parser = new MessageParser<LJPBAJGNLMI>(() => new LJPBAJGNLMI());

	private UnknownFieldSet _unknownFields;

	public const int JPDKKKJPPOMFieldNumber = 10;

	private uint jPDKKKJPPOM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LJPBAJGNLMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LJPBAJGNLMIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JPDKKKJPPOM
	{
		get
		{
			return jPDKKKJPPOM_;
		}
		set
		{
			jPDKKKJPPOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJPBAJGNLMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJPBAJGNLMI(LJPBAJGNLMI other)
		: this()
	{
		jPDKKKJPPOM_ = other.jPDKKKJPPOM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJPBAJGNLMI Clone()
	{
		return new LJPBAJGNLMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LJPBAJGNLMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LJPBAJGNLMI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JPDKKKJPPOM != other.JPDKKKJPPOM)
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
		if (JPDKKKJPPOM != 0)
		{
			num ^= JPDKKKJPPOM.GetHashCode();
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
		if (JPDKKKJPPOM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JPDKKKJPPOM);
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
		if (JPDKKKJPPOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JPDKKKJPPOM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LJPBAJGNLMI other)
	{
		if (other != null)
		{
			if (other.JPDKKKJPPOM != 0)
			{
				JPDKKKJPPOM = other.JPDKKKJPPOM;
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JPDKKKJPPOM = input.ReadUInt32();
			}
		}
	}
}
