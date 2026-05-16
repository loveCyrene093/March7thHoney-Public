using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class POHIEKPHMGH : IMessage<POHIEKPHMGH>, IMessage, IEquatable<POHIEKPHMGH>, IDeepCloneable<POHIEKPHMGH>, IBufferMessage
{
	private static readonly MessageParser<POHIEKPHMGH> _parser = new MessageParser<POHIEKPHMGH>(() => new POHIEKPHMGH());

	private UnknownFieldSet _unknownFields;

	public const int KJAJMEHIGFEFieldNumber = 3;

	private uint kJAJMEHIGFE_;

	public const int PGDPMACFCMCFieldNumber = 5;

	private uint pGDPMACFCMC_;

	public const int HOLLBADILEFFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_hOLLBADILEF_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> hOLLBADILEF_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<POHIEKPHMGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => POHIEKPHMGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KJAJMEHIGFE
	{
		get
		{
			return kJAJMEHIGFE_;
		}
		set
		{
			kJAJMEHIGFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGDPMACFCMC
	{
		get
		{
			return pGDPMACFCMC_;
		}
		set
		{
			pGDPMACFCMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HOLLBADILEF => hOLLBADILEF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POHIEKPHMGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POHIEKPHMGH(POHIEKPHMGH other)
		: this()
	{
		kJAJMEHIGFE_ = other.kJAJMEHIGFE_;
		pGDPMACFCMC_ = other.pGDPMACFCMC_;
		hOLLBADILEF_ = other.hOLLBADILEF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POHIEKPHMGH Clone()
	{
		return new POHIEKPHMGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as POHIEKPHMGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(POHIEKPHMGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KJAJMEHIGFE != other.KJAJMEHIGFE)
		{
			return false;
		}
		if (PGDPMACFCMC != other.PGDPMACFCMC)
		{
			return false;
		}
		if (!hOLLBADILEF_.Equals(other.hOLLBADILEF_))
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
		if (KJAJMEHIGFE != 0)
		{
			num ^= KJAJMEHIGFE.GetHashCode();
		}
		if (PGDPMACFCMC != 0)
		{
			num ^= PGDPMACFCMC.GetHashCode();
		}
		num ^= hOLLBADILEF_.GetHashCode();
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
		if (KJAJMEHIGFE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KJAJMEHIGFE);
		}
		if (PGDPMACFCMC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PGDPMACFCMC);
		}
		hOLLBADILEF_.WriteTo(ref output, _repeated_hOLLBADILEF_codec);
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
		if (KJAJMEHIGFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KJAJMEHIGFE);
		}
		if (PGDPMACFCMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGDPMACFCMC);
		}
		num += hOLLBADILEF_.CalculateSize(_repeated_hOLLBADILEF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(POHIEKPHMGH other)
	{
		if (other != null)
		{
			if (other.KJAJMEHIGFE != 0)
			{
				KJAJMEHIGFE = other.KJAJMEHIGFE;
			}
			if (other.PGDPMACFCMC != 0)
			{
				PGDPMACFCMC = other.PGDPMACFCMC;
			}
			hOLLBADILEF_.Add(other.hOLLBADILEF_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				KJAJMEHIGFE = input.ReadUInt32();
				break;
			case 40u:
				PGDPMACFCMC = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				hOLLBADILEF_.AddEntriesFrom(ref input, _repeated_hOLLBADILEF_codec);
				break;
			}
		}
	}
}
