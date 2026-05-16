using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesStartMiniGameCsReq : IMessage<PlanetFesStartMiniGameCsReq>, IMessage, IEquatable<PlanetFesStartMiniGameCsReq>, IDeepCloneable<PlanetFesStartMiniGameCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesStartMiniGameCsReq> _parser = new MessageParser<PlanetFesStartMiniGameCsReq>(() => new PlanetFesStartMiniGameCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ELLELJFGDPHFieldNumber = 8;

	private uint eLLELJFGDPH_;

	public const int KHDLMPAKEGFFieldNumber = 11;

	private uint kHDLMPAKEGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesStartMiniGameCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesStartMiniGameCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ELLELJFGDPH
	{
		get
		{
			return eLLELJFGDPH_;
		}
		set
		{
			eLLELJFGDPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHDLMPAKEGF
	{
		get
		{
			return kHDLMPAKEGF_;
		}
		set
		{
			kHDLMPAKEGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesStartMiniGameCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesStartMiniGameCsReq(PlanetFesStartMiniGameCsReq other)
		: this()
	{
		eLLELJFGDPH_ = other.eLLELJFGDPH_;
		kHDLMPAKEGF_ = other.kHDLMPAKEGF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesStartMiniGameCsReq Clone()
	{
		return new PlanetFesStartMiniGameCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesStartMiniGameCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesStartMiniGameCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ELLELJFGDPH != other.ELLELJFGDPH)
		{
			return false;
		}
		if (KHDLMPAKEGF != other.KHDLMPAKEGF)
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
		if (ELLELJFGDPH != 0)
		{
			num ^= ELLELJFGDPH.GetHashCode();
		}
		if (KHDLMPAKEGF != 0)
		{
			num ^= KHDLMPAKEGF.GetHashCode();
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
		if (ELLELJFGDPH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ELLELJFGDPH);
		}
		if (KHDLMPAKEGF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KHDLMPAKEGF);
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
		if (ELLELJFGDPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ELLELJFGDPH);
		}
		if (KHDLMPAKEGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHDLMPAKEGF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesStartMiniGameCsReq other)
	{
		if (other != null)
		{
			if (other.ELLELJFGDPH != 0)
			{
				ELLELJFGDPH = other.ELLELJFGDPH;
			}
			if (other.KHDLMPAKEGF != 0)
			{
				KHDLMPAKEGF = other.KHDLMPAKEGF;
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
			case 64u:
				ELLELJFGDPH = input.ReadUInt32();
				break;
			case 88u:
				KHDLMPAKEGF = input.ReadUInt32();
				break;
			}
		}
	}
}
