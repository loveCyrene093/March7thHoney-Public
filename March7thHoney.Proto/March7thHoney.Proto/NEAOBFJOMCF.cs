using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NEAOBFJOMCF : IMessage<NEAOBFJOMCF>, IMessage, IEquatable<NEAOBFJOMCF>, IDeepCloneable<NEAOBFJOMCF>, IBufferMessage
{
	private static readonly MessageParser<NEAOBFJOMCF> _parser = new MessageParser<NEAOBFJOMCF>(() => new NEAOBFJOMCF());

	private UnknownFieldSet _unknownFields;

	public const int OLFPEGDNECFFieldNumber = 2;

	private uint oLFPEGDNECF_;

	public const int KNJLOBMINCDFieldNumber = 10;

	private uint kNJLOBMINCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NEAOBFJOMCF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NEAOBFJOMCFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OLFPEGDNECF
	{
		get
		{
			return oLFPEGDNECF_;
		}
		set
		{
			oLFPEGDNECF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KNJLOBMINCD
	{
		get
		{
			return kNJLOBMINCD_;
		}
		set
		{
			kNJLOBMINCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEAOBFJOMCF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEAOBFJOMCF(NEAOBFJOMCF other)
		: this()
	{
		oLFPEGDNECF_ = other.oLFPEGDNECF_;
		kNJLOBMINCD_ = other.kNJLOBMINCD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEAOBFJOMCF Clone()
	{
		return new NEAOBFJOMCF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NEAOBFJOMCF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NEAOBFJOMCF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OLFPEGDNECF != other.OLFPEGDNECF)
		{
			return false;
		}
		if (KNJLOBMINCD != other.KNJLOBMINCD)
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
		if (OLFPEGDNECF != 0)
		{
			num ^= OLFPEGDNECF.GetHashCode();
		}
		if (KNJLOBMINCD != 0)
		{
			num ^= KNJLOBMINCD.GetHashCode();
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
		if (OLFPEGDNECF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(OLFPEGDNECF);
		}
		if (KNJLOBMINCD != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KNJLOBMINCD);
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
		if (OLFPEGDNECF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OLFPEGDNECF);
		}
		if (KNJLOBMINCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KNJLOBMINCD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NEAOBFJOMCF other)
	{
		if (other != null)
		{
			if (other.OLFPEGDNECF != 0)
			{
				OLFPEGDNECF = other.OLFPEGDNECF;
			}
			if (other.KNJLOBMINCD != 0)
			{
				KNJLOBMINCD = other.KNJLOBMINCD;
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
			case 16u:
				OLFPEGDNECF = input.ReadUInt32();
				break;
			case 80u:
				KNJLOBMINCD = input.ReadUInt32();
				break;
			}
		}
	}
}
