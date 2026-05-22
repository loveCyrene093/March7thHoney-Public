using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOADBBOFBJA : IMessage<DOADBBOFBJA>, IMessage, IEquatable<DOADBBOFBJA>, IDeepCloneable<DOADBBOFBJA>, IBufferMessage
{
	private static readonly MessageParser<DOADBBOFBJA> _parser = new MessageParser<DOADBBOFBJA>(() => new DOADBBOFBJA());

	private UnknownFieldSet _unknownFields;

	public const int OPHPMKFGLBAFieldNumber = 14;

	private uint oPHPMKFGLBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOADBBOFBJA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOADBBOFBJAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPHPMKFGLBA
	{
		get
		{
			return oPHPMKFGLBA_;
		}
		set
		{
			oPHPMKFGLBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOADBBOFBJA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOADBBOFBJA(DOADBBOFBJA other)
		: this()
	{
		oPHPMKFGLBA_ = other.oPHPMKFGLBA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOADBBOFBJA Clone()
	{
		return new DOADBBOFBJA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOADBBOFBJA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOADBBOFBJA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OPHPMKFGLBA != other.OPHPMKFGLBA)
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
		if (OPHPMKFGLBA != 0)
		{
			num ^= OPHPMKFGLBA.GetHashCode();
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
		if (OPHPMKFGLBA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OPHPMKFGLBA);
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
		if (OPHPMKFGLBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPHPMKFGLBA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOADBBOFBJA other)
	{
		if (other != null)
		{
			if (other.OPHPMKFGLBA != 0)
			{
				OPHPMKFGLBA = other.OPHPMKFGLBA;
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
				OPHPMKFGLBA = input.ReadUInt32();
			}
		}
	}
}
