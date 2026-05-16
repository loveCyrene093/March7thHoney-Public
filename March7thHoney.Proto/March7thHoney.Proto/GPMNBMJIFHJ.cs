using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GPMNBMJIFHJ : IMessage<GPMNBMJIFHJ>, IMessage, IEquatable<GPMNBMJIFHJ>, IDeepCloneable<GPMNBMJIFHJ>, IBufferMessage
{
	private static readonly MessageParser<GPMNBMJIFHJ> _parser = new MessageParser<GPMNBMJIFHJ>(() => new GPMNBMJIFHJ());

	private UnknownFieldSet _unknownFields;

	public const int OADEJOMKKPFFieldNumber = 5;

	private PBGMKNEGOPK oADEJOMKKPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GPMNBMJIFHJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GPMNBMJIFHJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBGMKNEGOPK OADEJOMKKPF
	{
		get
		{
			return oADEJOMKKPF_;
		}
		set
		{
			oADEJOMKKPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPMNBMJIFHJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPMNBMJIFHJ(GPMNBMJIFHJ other)
		: this()
	{
		oADEJOMKKPF_ = ((other.oADEJOMKKPF_ != null) ? other.oADEJOMKKPF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPMNBMJIFHJ Clone()
	{
		return new GPMNBMJIFHJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GPMNBMJIFHJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GPMNBMJIFHJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OADEJOMKKPF, other.OADEJOMKKPF))
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
		if (oADEJOMKKPF_ != null)
		{
			num ^= OADEJOMKKPF.GetHashCode();
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
		if (oADEJOMKKPF_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(OADEJOMKKPF);
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
		if (oADEJOMKKPF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OADEJOMKKPF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GPMNBMJIFHJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oADEJOMKKPF_ != null)
		{
			if (oADEJOMKKPF_ == null)
			{
				OADEJOMKKPF = new PBGMKNEGOPK();
			}
			OADEJOMKKPF.MergeFrom(other.OADEJOMKKPF);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oADEJOMKKPF_ == null)
			{
				OADEJOMKKPF = new PBGMKNEGOPK();
			}
			input.ReadMessage(OADEJOMKKPF);
		}
	}
}
