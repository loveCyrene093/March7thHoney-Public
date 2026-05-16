using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OFFBNGEIDFM : IMessage<OFFBNGEIDFM>, IMessage, IEquatable<OFFBNGEIDFM>, IDeepCloneable<OFFBNGEIDFM>, IBufferMessage
{
	private static readonly MessageParser<OFFBNGEIDFM> _parser = new MessageParser<OFFBNGEIDFM>(() => new OFFBNGEIDFM());

	private UnknownFieldSet _unknownFields;

	public const int GGDPAAJFMJBFieldNumber = 15;

	private Vector gGDPAAJFMJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OFFBNGEIDFM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OFFBNGEIDFMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector GGDPAAJFMJB
	{
		get
		{
			return gGDPAAJFMJB_;
		}
		set
		{
			gGDPAAJFMJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFFBNGEIDFM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFFBNGEIDFM(OFFBNGEIDFM other)
		: this()
	{
		gGDPAAJFMJB_ = ((other.gGDPAAJFMJB_ != null) ? other.gGDPAAJFMJB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFFBNGEIDFM Clone()
	{
		return new OFFBNGEIDFM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OFFBNGEIDFM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OFFBNGEIDFM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GGDPAAJFMJB, other.GGDPAAJFMJB))
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
		if (gGDPAAJFMJB_ != null)
		{
			num ^= GGDPAAJFMJB.GetHashCode();
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
		if (gGDPAAJFMJB_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(GGDPAAJFMJB);
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
		if (gGDPAAJFMJB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GGDPAAJFMJB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OFFBNGEIDFM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gGDPAAJFMJB_ != null)
		{
			if (gGDPAAJFMJB_ == null)
			{
				GGDPAAJFMJB = new Vector();
			}
			GGDPAAJFMJB.MergeFrom(other.GGDPAAJFMJB);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (gGDPAAJFMJB_ == null)
			{
				GGDPAAJFMJB = new Vector();
			}
			input.ReadMessage(GGDPAAJFMJB);
		}
	}
}
