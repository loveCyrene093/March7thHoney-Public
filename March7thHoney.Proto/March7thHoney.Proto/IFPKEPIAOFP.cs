using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFPKEPIAOFP : IMessage<IFPKEPIAOFP>, IMessage, IEquatable<IFPKEPIAOFP>, IDeepCloneable<IFPKEPIAOFP>, IBufferMessage
{
	private static readonly MessageParser<IFPKEPIAOFP> _parser = new MessageParser<IFPKEPIAOFP>(() => new IFPKEPIAOFP());

	private UnknownFieldSet _unknownFields;

	public const int FMECAHALPKGFieldNumber = 1;

	private ELLNDNEBHDK fMECAHALPKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFPKEPIAOFP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFPKEPIAOFPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELLNDNEBHDK FMECAHALPKG
	{
		get
		{
			return fMECAHALPKG_;
		}
		set
		{
			fMECAHALPKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFPKEPIAOFP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFPKEPIAOFP(IFPKEPIAOFP other)
		: this()
	{
		fMECAHALPKG_ = ((other.fMECAHALPKG_ != null) ? other.fMECAHALPKG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFPKEPIAOFP Clone()
	{
		return new IFPKEPIAOFP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFPKEPIAOFP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFPKEPIAOFP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FMECAHALPKG, other.FMECAHALPKG))
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
		if (fMECAHALPKG_ != null)
		{
			num ^= FMECAHALPKG.GetHashCode();
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
		if (fMECAHALPKG_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FMECAHALPKG);
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
		if (fMECAHALPKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMECAHALPKG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFPKEPIAOFP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fMECAHALPKG_ != null)
		{
			if (fMECAHALPKG_ == null)
			{
				FMECAHALPKG = new ELLNDNEBHDK();
			}
			FMECAHALPKG.MergeFrom(other.FMECAHALPKG);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fMECAHALPKG_ == null)
			{
				FMECAHALPKG = new ELLNDNEBHDK();
			}
			input.ReadMessage(FMECAHALPKG);
		}
	}
}
