using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPHIINCNKEI : IMessage<DPHIINCNKEI>, IMessage, IEquatable<DPHIINCNKEI>, IDeepCloneable<DPHIINCNKEI>, IBufferMessage
{
	private static readonly MessageParser<DPHIINCNKEI> _parser = new MessageParser<DPHIINCNKEI>(() => new DPHIINCNKEI());

	private UnknownFieldSet _unknownFields;

	public const int ODIOMDIDJIKFieldNumber = 10;

	private DLKILGMHPFM oDIOMDIDJIK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPHIINCNKEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPHIINCNKEIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLKILGMHPFM ODIOMDIDJIK
	{
		get
		{
			return oDIOMDIDJIK_;
		}
		set
		{
			oDIOMDIDJIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHIINCNKEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHIINCNKEI(DPHIINCNKEI other)
		: this()
	{
		oDIOMDIDJIK_ = ((other.oDIOMDIDJIK_ != null) ? other.oDIOMDIDJIK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHIINCNKEI Clone()
	{
		return new DPHIINCNKEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPHIINCNKEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPHIINCNKEI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ODIOMDIDJIK, other.ODIOMDIDJIK))
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
		if (oDIOMDIDJIK_ != null)
		{
			num ^= ODIOMDIDJIK.GetHashCode();
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
		if (oDIOMDIDJIK_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ODIOMDIDJIK);
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
		if (oDIOMDIDJIK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ODIOMDIDJIK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPHIINCNKEI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oDIOMDIDJIK_ != null)
		{
			if (oDIOMDIDJIK_ == null)
			{
				ODIOMDIDJIK = new DLKILGMHPFM();
			}
			ODIOMDIDJIK.MergeFrom(other.ODIOMDIDJIK);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oDIOMDIDJIK_ == null)
			{
				ODIOMDIDJIK = new DLKILGMHPFM();
			}
			input.ReadMessage(ODIOMDIDJIK);
		}
	}
}
