using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NOGNBKNEFGP : IMessage<NOGNBKNEFGP>, IMessage, IEquatable<NOGNBKNEFGP>, IDeepCloneable<NOGNBKNEFGP>, IBufferMessage
{
	private static readonly MessageParser<NOGNBKNEFGP> _parser = new MessageParser<NOGNBKNEFGP>(() => new NOGNBKNEFGP());

	private UnknownFieldSet _unknownFields;

	public const int FEILNIKNPCBFieldNumber = 1;

	private AKGOAIPLJLJ fEILNIKNPCB_;

	public const int JHADMBDCPEOFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_jHADMBDCPEO_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> jHADMBDCPEO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NOGNBKNEFGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NOGNBKNEFGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGOAIPLJLJ FEILNIKNPCB
	{
		get
		{
			return fEILNIKNPCB_;
		}
		set
		{
			fEILNIKNPCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JHADMBDCPEO => jHADMBDCPEO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOGNBKNEFGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOGNBKNEFGP(NOGNBKNEFGP other)
		: this()
	{
		fEILNIKNPCB_ = ((other.fEILNIKNPCB_ != null) ? other.fEILNIKNPCB_.Clone() : null);
		jHADMBDCPEO_ = other.jHADMBDCPEO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOGNBKNEFGP Clone()
	{
		return new NOGNBKNEFGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NOGNBKNEFGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NOGNBKNEFGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
		{
			return false;
		}
		if (!jHADMBDCPEO_.Equals(other.jHADMBDCPEO_))
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
		if (fEILNIKNPCB_ != null)
		{
			num ^= FEILNIKNPCB.GetHashCode();
		}
		num ^= jHADMBDCPEO_.GetHashCode();
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
		if (fEILNIKNPCB_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FEILNIKNPCB);
		}
		jHADMBDCPEO_.WriteTo(ref output, _repeated_jHADMBDCPEO_codec);
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
		if (fEILNIKNPCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		num += jHADMBDCPEO_.CalculateSize(_repeated_jHADMBDCPEO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NOGNBKNEFGP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fEILNIKNPCB_ != null)
		{
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new AKGOAIPLJLJ();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
		}
		jHADMBDCPEO_.Add(other.jHADMBDCPEO_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				if (fEILNIKNPCB_ == null)
				{
					FEILNIKNPCB = new AKGOAIPLJLJ();
				}
				input.ReadMessage(FEILNIKNPCB);
				break;
			case 72u:
			case 74u:
				jHADMBDCPEO_.AddEntriesFrom(ref input, _repeated_jHADMBDCPEO_codec);
				break;
			}
		}
	}
}
