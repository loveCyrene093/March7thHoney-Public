using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PINBJNLCIAH : IMessage<PINBJNLCIAH>, IMessage, IEquatable<PINBJNLCIAH>, IDeepCloneable<PINBJNLCIAH>, IBufferMessage
{
	private static readonly MessageParser<PINBJNLCIAH> _parser = new MessageParser<PINBJNLCIAH>(() => new PINBJNLCIAH());

	private UnknownFieldSet _unknownFields;

	public const int HCDADOGHADLFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_hCDADOGHADL_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> hCDADOGHADL_ = new RepeatedField<uint>();

	public const int IEINECPHOFLFieldNumber = 6;

	private uint iEINECPHOFL_;

	public const int PIICKMEOBIPFieldNumber = 8;

	private int pIICKMEOBIP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PINBJNLCIAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PINBJNLCIAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HCDADOGHADL => hCDADOGHADL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEINECPHOFL
	{
		get
		{
			return iEINECPHOFL_;
		}
		set
		{
			iEINECPHOFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PIICKMEOBIP
	{
		get
		{
			return pIICKMEOBIP_;
		}
		set
		{
			pIICKMEOBIP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PINBJNLCIAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PINBJNLCIAH(PINBJNLCIAH other)
		: this()
	{
		hCDADOGHADL_ = other.hCDADOGHADL_.Clone();
		iEINECPHOFL_ = other.iEINECPHOFL_;
		pIICKMEOBIP_ = other.pIICKMEOBIP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PINBJNLCIAH Clone()
	{
		return new PINBJNLCIAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PINBJNLCIAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PINBJNLCIAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hCDADOGHADL_.Equals(other.hCDADOGHADL_))
		{
			return false;
		}
		if (IEINECPHOFL != other.IEINECPHOFL)
		{
			return false;
		}
		if (PIICKMEOBIP != other.PIICKMEOBIP)
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
		num ^= hCDADOGHADL_.GetHashCode();
		if (IEINECPHOFL != 0)
		{
			num ^= IEINECPHOFL.GetHashCode();
		}
		if (PIICKMEOBIP != 0)
		{
			num ^= PIICKMEOBIP.GetHashCode();
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
		hCDADOGHADL_.WriteTo(ref output, _repeated_hCDADOGHADL_codec);
		if (IEINECPHOFL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IEINECPHOFL);
		}
		if (PIICKMEOBIP != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PIICKMEOBIP);
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
		num += hCDADOGHADL_.CalculateSize(_repeated_hCDADOGHADL_codec);
		if (IEINECPHOFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEINECPHOFL);
		}
		if (PIICKMEOBIP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PIICKMEOBIP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PINBJNLCIAH other)
	{
		if (other != null)
		{
			hCDADOGHADL_.Add(other.hCDADOGHADL_);
			if (other.IEINECPHOFL != 0)
			{
				IEINECPHOFL = other.IEINECPHOFL;
			}
			if (other.PIICKMEOBIP != 0)
			{
				PIICKMEOBIP = other.PIICKMEOBIP;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 40u:
			case 42u:
				hCDADOGHADL_.AddEntriesFrom(ref input, _repeated_hCDADOGHADL_codec);
				break;
			case 48u:
				IEINECPHOFL = input.ReadUInt32();
				break;
			case 64u:
				PIICKMEOBIP = input.ReadInt32();
				break;
			}
		}
	}
}
