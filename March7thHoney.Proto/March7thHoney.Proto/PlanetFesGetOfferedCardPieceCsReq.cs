using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGetOfferedCardPieceCsReq : IMessage<PlanetFesGetOfferedCardPieceCsReq>, IMessage, IEquatable<PlanetFesGetOfferedCardPieceCsReq>, IDeepCloneable<PlanetFesGetOfferedCardPieceCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGetOfferedCardPieceCsReq> _parser = new MessageParser<PlanetFesGetOfferedCardPieceCsReq>(() => new PlanetFesGetOfferedCardPieceCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PHALKDHHPPBFieldNumber = 5;

	private ulong pHALKDHHPPB_;

	public const int JFHMCDFDABIFieldNumber = 8;

	private bool jFHMCDFDABI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGetOfferedCardPieceCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGetOfferedCardPieceCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PHALKDHHPPB
	{
		get
		{
			return pHALKDHHPPB_;
		}
		set
		{
			pHALKDHHPPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JFHMCDFDABI
	{
		get
		{
			return jFHMCDFDABI_;
		}
		set
		{
			jFHMCDFDABI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetOfferedCardPieceCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetOfferedCardPieceCsReq(PlanetFesGetOfferedCardPieceCsReq other)
		: this()
	{
		pHALKDHHPPB_ = other.pHALKDHHPPB_;
		jFHMCDFDABI_ = other.jFHMCDFDABI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetOfferedCardPieceCsReq Clone()
	{
		return new PlanetFesGetOfferedCardPieceCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGetOfferedCardPieceCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGetOfferedCardPieceCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHALKDHHPPB != other.PHALKDHHPPB)
		{
			return false;
		}
		if (JFHMCDFDABI != other.JFHMCDFDABI)
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
		if (PHALKDHHPPB != 0L)
		{
			num ^= PHALKDHHPPB.GetHashCode();
		}
		if (JFHMCDFDABI)
		{
			num ^= JFHMCDFDABI.GetHashCode();
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
		if (PHALKDHHPPB != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(PHALKDHHPPB);
		}
		if (JFHMCDFDABI)
		{
			output.WriteRawTag(64);
			output.WriteBool(JFHMCDFDABI);
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
		if (PHALKDHHPPB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PHALKDHHPPB);
		}
		if (JFHMCDFDABI)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesGetOfferedCardPieceCsReq other)
	{
		if (other != null)
		{
			if (other.PHALKDHHPPB != 0L)
			{
				PHALKDHHPPB = other.PHALKDHHPPB;
			}
			if (other.JFHMCDFDABI)
			{
				JFHMCDFDABI = other.JFHMCDFDABI;
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
				PHALKDHHPPB = input.ReadUInt64();
				break;
			case 64u:
				JFHMCDFDABI = input.ReadBool();
				break;
			}
		}
	}
}
