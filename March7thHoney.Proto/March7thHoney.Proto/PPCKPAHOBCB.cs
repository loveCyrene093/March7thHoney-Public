using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PPCKPAHOBCB : IMessage<PPCKPAHOBCB>, IMessage, IEquatable<PPCKPAHOBCB>, IDeepCloneable<PPCKPAHOBCB>, IBufferMessage
{
	private static readonly MessageParser<PPCKPAHOBCB> _parser = new MessageParser<PPCKPAHOBCB>(() => new PPCKPAHOBCB());

	private UnknownFieldSet _unknownFields;

	public const int JCEMJBMMCOGFieldNumber = 7;

	private ADPDKFBHJPN jCEMJBMMCOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PPCKPAHOBCB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PPCKPAHOBCBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADPDKFBHJPN JCEMJBMMCOG
	{
		get
		{
			return jCEMJBMMCOG_;
		}
		set
		{
			jCEMJBMMCOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPCKPAHOBCB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPCKPAHOBCB(PPCKPAHOBCB other)
		: this()
	{
		jCEMJBMMCOG_ = ((other.jCEMJBMMCOG_ != null) ? other.jCEMJBMMCOG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPCKPAHOBCB Clone()
	{
		return new PPCKPAHOBCB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PPCKPAHOBCB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PPCKPAHOBCB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JCEMJBMMCOG, other.JCEMJBMMCOG))
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
		if (jCEMJBMMCOG_ != null)
		{
			num ^= JCEMJBMMCOG.GetHashCode();
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
		if (jCEMJBMMCOG_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(JCEMJBMMCOG);
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
		if (jCEMJBMMCOG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JCEMJBMMCOG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PPCKPAHOBCB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jCEMJBMMCOG_ != null)
		{
			if (jCEMJBMMCOG_ == null)
			{
				JCEMJBMMCOG = new ADPDKFBHJPN();
			}
			JCEMJBMMCOG.MergeFrom(other.JCEMJBMMCOG);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (jCEMJBMMCOG_ == null)
			{
				JCEMJBMMCOG = new ADPDKFBHJPN();
			}
			input.ReadMessage(JCEMJBMMCOG);
		}
	}
}
