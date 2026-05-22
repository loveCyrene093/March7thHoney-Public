using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PMBLADGCPMM : IMessage<PMBLADGCPMM>, IMessage, IEquatable<PMBLADGCPMM>, IDeepCloneable<PMBLADGCPMM>, IBufferMessage
{
	private static readonly MessageParser<PMBLADGCPMM> _parser = new MessageParser<PMBLADGCPMM>(() => new PMBLADGCPMM());

	private UnknownFieldSet _unknownFields;

	public const int EDNCOAGAIJKFieldNumber = 1;

	private uint eDNCOAGAIJK_;

	public const int OIAPHBBDPHLFieldNumber = 4;

	private JOJLACDBPNA oIAPHBBDPHL_;

	public const int ELLELJFGDPHFieldNumber = 9;

	private uint eLLELJFGDPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PMBLADGCPMM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PMBLADGCPMMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDNCOAGAIJK
	{
		get
		{
			return eDNCOAGAIJK_;
		}
		set
		{
			eDNCOAGAIJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOJLACDBPNA OIAPHBBDPHL
	{
		get
		{
			return oIAPHBBDPHL_;
		}
		set
		{
			oIAPHBBDPHL_ = value;
		}
	}

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
	public PMBLADGCPMM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMBLADGCPMM(PMBLADGCPMM other)
		: this()
	{
		eDNCOAGAIJK_ = other.eDNCOAGAIJK_;
		oIAPHBBDPHL_ = ((other.oIAPHBBDPHL_ != null) ? other.oIAPHBBDPHL_.Clone() : null);
		eLLELJFGDPH_ = other.eLLELJFGDPH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMBLADGCPMM Clone()
	{
		return new PMBLADGCPMM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PMBLADGCPMM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PMBLADGCPMM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EDNCOAGAIJK != other.EDNCOAGAIJK)
		{
			return false;
		}
		if (!object.Equals(OIAPHBBDPHL, other.OIAPHBBDPHL))
		{
			return false;
		}
		if (ELLELJFGDPH != other.ELLELJFGDPH)
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
		if (EDNCOAGAIJK != 0)
		{
			num ^= EDNCOAGAIJK.GetHashCode();
		}
		if (oIAPHBBDPHL_ != null)
		{
			num ^= OIAPHBBDPHL.GetHashCode();
		}
		if (ELLELJFGDPH != 0)
		{
			num ^= ELLELJFGDPH.GetHashCode();
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
		if (EDNCOAGAIJK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EDNCOAGAIJK);
		}
		if (oIAPHBBDPHL_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OIAPHBBDPHL);
		}
		if (ELLELJFGDPH != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ELLELJFGDPH);
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
		if (EDNCOAGAIJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDNCOAGAIJK);
		}
		if (oIAPHBBDPHL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OIAPHBBDPHL);
		}
		if (ELLELJFGDPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ELLELJFGDPH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PMBLADGCPMM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EDNCOAGAIJK != 0)
		{
			EDNCOAGAIJK = other.EDNCOAGAIJK;
		}
		if (other.oIAPHBBDPHL_ != null)
		{
			if (oIAPHBBDPHL_ == null)
			{
				OIAPHBBDPHL = new JOJLACDBPNA();
			}
			OIAPHBBDPHL.MergeFrom(other.OIAPHBBDPHL);
		}
		if (other.ELLELJFGDPH != 0)
		{
			ELLELJFGDPH = other.ELLELJFGDPH;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				EDNCOAGAIJK = input.ReadUInt32();
				break;
			case 34u:
				if (oIAPHBBDPHL_ == null)
				{
					OIAPHBBDPHL = new JOJLACDBPNA();
				}
				input.ReadMessage(OIAPHBBDPHL);
				break;
			case 72u:
				ELLELJFGDPH = input.ReadUInt32();
				break;
			}
		}
	}
}
