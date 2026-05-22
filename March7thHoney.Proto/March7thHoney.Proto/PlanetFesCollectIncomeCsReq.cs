using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesCollectIncomeCsReq : IMessage<PlanetFesCollectIncomeCsReq>, IMessage, IEquatable<PlanetFesCollectIncomeCsReq>, IDeepCloneable<PlanetFesCollectIncomeCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesCollectIncomeCsReq> _parser = new MessageParser<PlanetFesCollectIncomeCsReq>(() => new PlanetFesCollectIncomeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BHDHIIBCDIJFieldNumber = 5;

	private uint bHDHIIBCDIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesCollectIncomeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesCollectIncomeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHDHIIBCDIJ
	{
		get
		{
			return bHDHIIBCDIJ_;
		}
		set
		{
			bHDHIIBCDIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesCollectIncomeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesCollectIncomeCsReq(PlanetFesCollectIncomeCsReq other)
		: this()
	{
		bHDHIIBCDIJ_ = other.bHDHIIBCDIJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesCollectIncomeCsReq Clone()
	{
		return new PlanetFesCollectIncomeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesCollectIncomeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesCollectIncomeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BHDHIIBCDIJ != other.BHDHIIBCDIJ)
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
		if (BHDHIIBCDIJ != 0)
		{
			num ^= BHDHIIBCDIJ.GetHashCode();
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
		if (BHDHIIBCDIJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BHDHIIBCDIJ);
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
		if (BHDHIIBCDIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHDHIIBCDIJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesCollectIncomeCsReq other)
	{
		if (other != null)
		{
			if (other.BHDHIIBCDIJ != 0)
			{
				BHDHIIBCDIJ = other.BHDHIIBCDIJ;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BHDHIIBCDIJ = input.ReadUInt32();
			}
		}
	}
}
