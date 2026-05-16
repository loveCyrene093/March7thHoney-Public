using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HAGBFHNGJIM : IMessage<HAGBFHNGJIM>, IMessage, IEquatable<HAGBFHNGJIM>, IDeepCloneable<HAGBFHNGJIM>, IBufferMessage
{
	private static readonly MessageParser<HAGBFHNGJIM> _parser = new MessageParser<HAGBFHNGJIM>(() => new HAGBFHNGJIM());

	private UnknownFieldSet _unknownFields;

	public const int OKIDHDFCPBDFieldNumber = 4;

	private PMPJMNNAHNL oKIDHDFCPBD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HAGBFHNGJIM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HAGBFHNGJIMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMPJMNNAHNL OKIDHDFCPBD
	{
		get
		{
			return oKIDHDFCPBD_;
		}
		set
		{
			oKIDHDFCPBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGBFHNGJIM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGBFHNGJIM(HAGBFHNGJIM other)
		: this()
	{
		oKIDHDFCPBD_ = ((other.oKIDHDFCPBD_ != null) ? other.oKIDHDFCPBD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGBFHNGJIM Clone()
	{
		return new HAGBFHNGJIM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HAGBFHNGJIM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HAGBFHNGJIM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OKIDHDFCPBD, other.OKIDHDFCPBD))
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
		if (oKIDHDFCPBD_ != null)
		{
			num ^= OKIDHDFCPBD.GetHashCode();
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
		if (oKIDHDFCPBD_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OKIDHDFCPBD);
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
		if (oKIDHDFCPBD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OKIDHDFCPBD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HAGBFHNGJIM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oKIDHDFCPBD_ != null)
		{
			if (oKIDHDFCPBD_ == null)
			{
				OKIDHDFCPBD = new PMPJMNNAHNL();
			}
			OKIDHDFCPBD.MergeFrom(other.OKIDHDFCPBD);
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
			if (oKIDHDFCPBD_ == null)
			{
				OKIDHDFCPBD = new PMPJMNNAHNL();
			}
			input.ReadMessage(OKIDHDFCPBD);
		}
	}
}
