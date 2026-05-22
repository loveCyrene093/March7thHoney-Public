using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IIJDPFOGCIN : IMessage<IIJDPFOGCIN>, IMessage, IEquatable<IIJDPFOGCIN>, IDeepCloneable<IIJDPFOGCIN>, IBufferMessage
{
	private static readonly MessageParser<IIJDPFOGCIN> _parser = new MessageParser<IIJDPFOGCIN>(() => new IIJDPFOGCIN());

	private UnknownFieldSet _unknownFields;

	public const int JFMHILEEFCPFieldNumber = 15;

	private ANIOMKDCOEP jFMHILEEFCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IIJDPFOGCIN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IIJDPFOGCINReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANIOMKDCOEP JFMHILEEFCP
	{
		get
		{
			return jFMHILEEFCP_;
		}
		set
		{
			jFMHILEEFCP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIJDPFOGCIN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIJDPFOGCIN(IIJDPFOGCIN other)
		: this()
	{
		jFMHILEEFCP_ = ((other.jFMHILEEFCP_ != null) ? other.jFMHILEEFCP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIJDPFOGCIN Clone()
	{
		return new IIJDPFOGCIN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IIJDPFOGCIN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IIJDPFOGCIN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JFMHILEEFCP, other.JFMHILEEFCP))
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
		if (jFMHILEEFCP_ != null)
		{
			num ^= JFMHILEEFCP.GetHashCode();
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
		if (jFMHILEEFCP_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(JFMHILEEFCP);
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
		if (jFMHILEEFCP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JFMHILEEFCP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IIJDPFOGCIN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jFMHILEEFCP_ != null)
		{
			if (jFMHILEEFCP_ == null)
			{
				JFMHILEEFCP = new ANIOMKDCOEP();
			}
			JFMHILEEFCP.MergeFrom(other.JFMHILEEFCP);
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
			if (jFMHILEEFCP_ == null)
			{
				JFMHILEEFCP = new ANIOMKDCOEP();
			}
			input.ReadMessage(JFMHILEEFCP);
		}
	}
}
