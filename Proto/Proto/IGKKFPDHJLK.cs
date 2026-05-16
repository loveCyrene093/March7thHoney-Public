using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IGKKFPDHJLK : IMessage<IGKKFPDHJLK>, IMessage, IEquatable<IGKKFPDHJLK>, IDeepCloneable<IGKKFPDHJLK>, IBufferMessage
{
	private static readonly MessageParser<IGKKFPDHJLK> _parser = new MessageParser<IGKKFPDHJLK>(() => new IGKKFPDHJLK());

	private UnknownFieldSet _unknownFields;

	public const int EKNHFDNEINKFieldNumber = 13;

	private DOKJPHAODDB eKNHFDNEINK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IGKKFPDHJLK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IGKKFPDHJLKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOKJPHAODDB EKNHFDNEINK
	{
		get
		{
			return eKNHFDNEINK_;
		}
		set
		{
			eKNHFDNEINK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGKKFPDHJLK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGKKFPDHJLK(IGKKFPDHJLK other)
		: this()
	{
		eKNHFDNEINK_ = ((other.eKNHFDNEINK_ != null) ? other.eKNHFDNEINK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGKKFPDHJLK Clone()
	{
		return new IGKKFPDHJLK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IGKKFPDHJLK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IGKKFPDHJLK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EKNHFDNEINK, other.EKNHFDNEINK))
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
		if (eKNHFDNEINK_ != null)
		{
			num ^= EKNHFDNEINK.GetHashCode();
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
		if (eKNHFDNEINK_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EKNHFDNEINK);
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
		if (eKNHFDNEINK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EKNHFDNEINK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IGKKFPDHJLK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eKNHFDNEINK_ != null)
		{
			if (eKNHFDNEINK_ == null)
			{
				EKNHFDNEINK = new DOKJPHAODDB();
			}
			EKNHFDNEINK.MergeFrom(other.EKNHFDNEINK);
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
			if (eKNHFDNEINK_ == null)
			{
				EKNHFDNEINK = new DOKJPHAODDB();
			}
			input.ReadMessage(EKNHFDNEINK);
		}
	}
}
