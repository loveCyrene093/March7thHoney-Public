using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OHAOFLALHBL : IMessage<OHAOFLALHBL>, IMessage, IEquatable<OHAOFLALHBL>, IDeepCloneable<OHAOFLALHBL>, IBufferMessage
{
	private static readonly MessageParser<OHAOFLALHBL> _parser = new MessageParser<OHAOFLALHBL>(() => new OHAOFLALHBL());

	private UnknownFieldSet _unknownFields;

	public const int JNOMDIFNEJHFieldNumber = 2;

	private uint jNOMDIFNEJH_;

	public const int ONEBNOGLONDFieldNumber = 4;

	private uint oNEBNOGLOND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OHAOFLALHBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OHAOFLALHBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNOMDIFNEJH
	{
		get
		{
			return jNOMDIFNEJH_;
		}
		set
		{
			jNOMDIFNEJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ONEBNOGLOND
	{
		get
		{
			return oNEBNOGLOND_;
		}
		set
		{
			oNEBNOGLOND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHAOFLALHBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHAOFLALHBL(OHAOFLALHBL other)
		: this()
	{
		jNOMDIFNEJH_ = other.jNOMDIFNEJH_;
		oNEBNOGLOND_ = other.oNEBNOGLOND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHAOFLALHBL Clone()
	{
		return new OHAOFLALHBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OHAOFLALHBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OHAOFLALHBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JNOMDIFNEJH != other.JNOMDIFNEJH)
		{
			return false;
		}
		if (ONEBNOGLOND != other.ONEBNOGLOND)
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
		if (JNOMDIFNEJH != 0)
		{
			num ^= JNOMDIFNEJH.GetHashCode();
		}
		if (ONEBNOGLOND != 0)
		{
			num ^= ONEBNOGLOND.GetHashCode();
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
		if (JNOMDIFNEJH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JNOMDIFNEJH);
		}
		if (ONEBNOGLOND != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ONEBNOGLOND);
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
		if (JNOMDIFNEJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNOMDIFNEJH);
		}
		if (ONEBNOGLOND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ONEBNOGLOND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OHAOFLALHBL other)
	{
		if (other != null)
		{
			if (other.JNOMDIFNEJH != 0)
			{
				JNOMDIFNEJH = other.JNOMDIFNEJH;
			}
			if (other.ONEBNOGLOND != 0)
			{
				ONEBNOGLOND = other.ONEBNOGLOND;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				JNOMDIFNEJH = input.ReadUInt32();
				break;
			case 32u:
				ONEBNOGLOND = input.ReadUInt32();
				break;
			}
		}
	}
}
