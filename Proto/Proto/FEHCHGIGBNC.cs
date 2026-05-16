using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FEHCHGIGBNC : IMessage<FEHCHGIGBNC>, IMessage, IEquatable<FEHCHGIGBNC>, IDeepCloneable<FEHCHGIGBNC>, IBufferMessage
{
	private static readonly MessageParser<FEHCHGIGBNC> _parser = new MessageParser<FEHCHGIGBNC>(() => new FEHCHGIGBNC());

	private UnknownFieldSet _unknownFields;

	public const int JHGLGKCDPNBFieldNumber = 12;

	private uint jHGLGKCDPNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FEHCHGIGBNC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FEHCHGIGBNCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHGLGKCDPNB
	{
		get
		{
			return jHGLGKCDPNB_;
		}
		set
		{
			jHGLGKCDPNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEHCHGIGBNC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEHCHGIGBNC(FEHCHGIGBNC other)
		: this()
	{
		jHGLGKCDPNB_ = other.jHGLGKCDPNB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEHCHGIGBNC Clone()
	{
		return new FEHCHGIGBNC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FEHCHGIGBNC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FEHCHGIGBNC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHGLGKCDPNB != other.JHGLGKCDPNB)
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
		if (JHGLGKCDPNB != 0)
		{
			num ^= JHGLGKCDPNB.GetHashCode();
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
		if (JHGLGKCDPNB != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JHGLGKCDPNB);
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
		if (JHGLGKCDPNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHGLGKCDPNB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FEHCHGIGBNC other)
	{
		if (other != null)
		{
			if (other.JHGLGKCDPNB != 0)
			{
				JHGLGKCDPNB = other.JHGLGKCDPNB;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JHGLGKCDPNB = input.ReadUInt32();
			}
		}
	}
}
