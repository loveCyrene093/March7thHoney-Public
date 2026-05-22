using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EMBCNJNGMKI : IMessage<EMBCNJNGMKI>, IMessage, IEquatable<EMBCNJNGMKI>, IDeepCloneable<EMBCNJNGMKI>, IBufferMessage
{
	private static readonly MessageParser<EMBCNJNGMKI> _parser = new MessageParser<EMBCNJNGMKI>(() => new EMBCNJNGMKI());

	private UnknownFieldSet _unknownFields;

	public const int PANFIPHAGPBFieldNumber = 1;

	private uint pANFIPHAGPB_;

	public const int KBADJDFLAPEFieldNumber = 2;

	private uint kBADJDFLAPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EMBCNJNGMKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EMBCNJNGMKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PANFIPHAGPB
	{
		get
		{
			return pANFIPHAGPB_;
		}
		set
		{
			pANFIPHAGPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBADJDFLAPE
	{
		get
		{
			return kBADJDFLAPE_;
		}
		set
		{
			kBADJDFLAPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMBCNJNGMKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMBCNJNGMKI(EMBCNJNGMKI other)
		: this()
	{
		pANFIPHAGPB_ = other.pANFIPHAGPB_;
		kBADJDFLAPE_ = other.kBADJDFLAPE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMBCNJNGMKI Clone()
	{
		return new EMBCNJNGMKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EMBCNJNGMKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EMBCNJNGMKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PANFIPHAGPB != other.PANFIPHAGPB)
		{
			return false;
		}
		if (KBADJDFLAPE != other.KBADJDFLAPE)
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
		if (PANFIPHAGPB != 0)
		{
			num ^= PANFIPHAGPB.GetHashCode();
		}
		if (KBADJDFLAPE != 0)
		{
			num ^= KBADJDFLAPE.GetHashCode();
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
		if (PANFIPHAGPB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PANFIPHAGPB);
		}
		if (KBADJDFLAPE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KBADJDFLAPE);
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
		if (PANFIPHAGPB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PANFIPHAGPB);
		}
		if (KBADJDFLAPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBADJDFLAPE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EMBCNJNGMKI other)
	{
		if (other != null)
		{
			if (other.PANFIPHAGPB != 0)
			{
				PANFIPHAGPB = other.PANFIPHAGPB;
			}
			if (other.KBADJDFLAPE != 0)
			{
				KBADJDFLAPE = other.KBADJDFLAPE;
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
			case 8u:
				PANFIPHAGPB = input.ReadUInt32();
				break;
			case 16u:
				KBADJDFLAPE = input.ReadUInt32();
				break;
			}
		}
	}
}
