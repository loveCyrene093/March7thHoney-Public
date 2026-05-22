using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HILCNKINEIA : IMessage<HILCNKINEIA>, IMessage, IEquatable<HILCNKINEIA>, IDeepCloneable<HILCNKINEIA>, IBufferMessage
{
	private static readonly MessageParser<HILCNKINEIA> _parser = new MessageParser<HILCNKINEIA>(() => new HILCNKINEIA());

	private UnknownFieldSet _unknownFields;

	public const int MNOHDHCMKELFieldNumber = 13;

	private EIPPGFCFJEO mNOHDHCMKEL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HILCNKINEIA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HILCNKINEIAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIPPGFCFJEO MNOHDHCMKEL
	{
		get
		{
			return mNOHDHCMKEL_;
		}
		set
		{
			mNOHDHCMKEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HILCNKINEIA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HILCNKINEIA(HILCNKINEIA other)
		: this()
	{
		mNOHDHCMKEL_ = ((other.mNOHDHCMKEL_ != null) ? other.mNOHDHCMKEL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HILCNKINEIA Clone()
	{
		return new HILCNKINEIA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HILCNKINEIA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HILCNKINEIA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MNOHDHCMKEL, other.MNOHDHCMKEL))
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
		if (mNOHDHCMKEL_ != null)
		{
			num ^= MNOHDHCMKEL.GetHashCode();
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
		if (mNOHDHCMKEL_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(MNOHDHCMKEL);
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
		if (mNOHDHCMKEL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNOHDHCMKEL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HILCNKINEIA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mNOHDHCMKEL_ != null)
		{
			if (mNOHDHCMKEL_ == null)
			{
				MNOHDHCMKEL = new EIPPGFCFJEO();
			}
			MNOHDHCMKEL.MergeFrom(other.MNOHDHCMKEL);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (mNOHDHCMKEL_ == null)
			{
				MNOHDHCMKEL = new EIPPGFCFJEO();
			}
			input.ReadMessage(MNOHDHCMKEL);
		}
	}
}
